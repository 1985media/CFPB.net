using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using Cfpb.Hdma;
using Newtonsoft.Json;

namespace Cfpb
{
    internal static class Utility
    {
		public static async Task<Result<T>> Request<T>(string endpoint, DataFormat dataFormat, List<string> select, string where, List<string> group, int? limit, int? offset, string orderBy, string callback)
		{
			//var result = File.ReadAllText(@"D:\Projects\HdmaSdk\HdmaSdk.Data\hmda_lar.json");
			//return JsonConvert.DeserializeObject<Result<T>>(result);

			var query = new List<string>();

			if (select != null && select.Any())
			{
				query.Add("$select=" + string.Join(",", select));
			}

			if (!string.IsNullOrEmpty(where))
			{
				query.Add("$where=" + HttpUtility.UrlEncode(where));
			}

			if (group != null && group.Any())
			{
				query.Add("$group=" + string.Join(",", group));
			}

			if (limit.HasValue)
			{
				query.Add("$limit=" + limit.ToString());
			}

			if (offset.HasValue)
			{
				query.Add("$offset=" + offset.ToString());
			}

			if (!string.IsNullOrEmpty(orderBy))
			{
				query.Add("$orderBy=" + orderBy);
			}

			if (!string.IsNullOrEmpty(callback))
			{
				query.Add("$callback=" + callback);
			}

			var queryString = query.Any() ? string.Join("&", query) : string.Empty;

			var url = string.Format("https://api.consumerfinance.gov:443{0}.{1}?{2}", endpoint, dataFormat.ToString().ToLower(), queryString);
			
			using (var wb = new WebClient())
			{
				var response = await wb.DownloadStringTaskAsync(url);
				return JsonConvert.DeserializeObject<Result<T>>(response);
			}
		}
    }
}
