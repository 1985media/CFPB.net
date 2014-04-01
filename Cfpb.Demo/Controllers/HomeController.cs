using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Cfpb.Hdma.Lar;

namespace Cfpb.Demo.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public async Task<ActionResult> Index()
		{
			var select = new List<string>
		        {
					Fields.ApplicantIncome000s,
			        Fields.CoApplicantEthnicity,
					Fields.CoApplicantEthnicityName,
					Fields.DenialReason1,
					Fields.DenialReason2,
					Fields.DenialReason3,
					Fields.DenialReasonName1,
					Fields.DenialReasonName2,
					Fields.DenialReasonName3,
					Fields.StateCode,
					Fields.StateAbbr,
					Fields.StateName,
					Fields.HudMedianFamilyIncome,
					Fields.LoanType,
					Fields.LoanTypeName,
					Fields.OwnerOccupancy,
					Fields.OwnerOccupancyName,
					Fields.PropertyType,
					Fields.PurchaserTypeName,
					Fields.LoanAmount000s,
					Fields.CountyCode,
					Fields.CountyName,
					Fields.Msamd,
					Fields.MsamdName,
					Fields.PropertyType,
					Fields.PropertyTypeName,
					Fields.AsOfYear
		        };

			var where = string.Format("{0}=37 and {1}=6 and {3}=2011 and {2}='31084'", Fields.CountyCode, Fields.StateCode, Fields.Msamd, Fields.AsOfYear);
			//var data = await Utility.Query(select: select, where: where, limit:10);

			var years = new List<int> { 2007, 2008, 2009, 2010, 2011, 2012 };
			var yearTasks = years.Select(GetMedianIncomeByYear);
			await Task.WhenAll(yearTasks);
			ViewBag.Incomes = incomes.OrderBy(i => i.Item1);


			var incomeDataTasks = years.Select(GetIncomesByYear);
			await Task.WhenAll(incomeDataTasks);


			ViewBag.BoxChartData = GetBoxChartData(incomeData);

			ViewBag.AreaChartData = GetAreaChartData(incomeData);

			return View();
		}

		private List<Tuple<int, int>> incomes = new List<Tuple<int, int>>();
		private List<Tuple<int, List<int>>> incomeData = new List<Tuple<int, List<int>>>();

		private async Task GetMedianIncomeByYear(int year)
		{
			var select = new List<string>
		        {
					Fields.HudMedianFamilyIncome,
		        };

			var where = string.Format("{0}=37 and {1}=6 and {2}={3} and {4}='31084'", Fields.CountyCode, Fields.StateCode, Fields.AsOfYear, year, Fields.Msamd);
			var result = await Utility.Query(@select: select, @where: where, limit: 1);
			incomes.Add(result.Results.Any()
							? new Tuple<int, int>(year, result.Results.First().HudMedianFamilyIncome)
							: new Tuple<int, int>(year, 0));
		}

		private async Task GetIncomesByYear(int year)
		{
			var select = new List<string>
				{
					Fields.ApplicantIncome000s,
					Fields.AsOfYear
				};
			var where = string.Format("{0}=37 and {1}=6 and {2}='31084' and {3}={4}", Fields.CountyCode, Fields.StateCode, Fields.Msamd, Fields.AsOfYear, year, Fields.ApplicantIncome000s);
			var result = await Utility.Query(@select: select, @where: where, limit: 10000);

			var data = result.Results.Where(r => r.ApplicantIncome000s > 0).Select(r => r.ApplicantIncome000s).OrderBy(r => r).ToList();

			incomeData.Add(new Tuple<int, List<int>>(year, data));
		}

		private static List<Tuple<int, List<int>>> GetBoxChartData(IEnumerable<Tuple<int, List<int>>> rawData)
		{
			return (from yearData in rawData
			        let count = yearData.Item2.Count
			        let data = yearData.Item2
			        let q1 = count%2 == 0 ? data[count/4] : (data[count/4] + data[count/4 + 1])/2
			        let q2 = count%2 == 0 ? (data[count/2] + data[count/2 - 1])/2 : data[(count - 1)/2]
			        let q3 = count%2 == 0 ? data[3*count/4] : (data[3*count/4] + data[3*count/4 - 1])/2
			        select new Tuple<int, List<int>>(yearData.Item1, new List<int>
				        {
					        data.First(), q1, q2, q3, data.Last()
				        })).ToList();
		}

		private static List<Tuple<int, List<int>>> GetAreaChartData(IEnumerable<Tuple<int, List<int>>> rawData)
		{
			var result = new List<Tuple<int, List<int>>>();
			
			foreach (var yearData in rawData)
			{
				var values = yearData.Item2.Where(r => r <= 300).ToList();
				var incomes = new int[values.Max() + 1];
				foreach (var data in values.GroupBy(r => r))
				{
					incomes[data.Key] = data.Count();
				}
				result.Add(new Tuple<int, List<int>>(yearData.Item1, incomes.ToList()));
			}

			return result;
		}
	}
}
