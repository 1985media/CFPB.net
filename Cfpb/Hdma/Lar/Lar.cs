using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cfpb.Hdma.Lar
{
	public class Utility
	{
		private const string Endpoint = "/data/hmda/slice/hmda_lar";

		public static async Task<Result<LarObject>> Query(List<string> select = null, string where = null, List<string> group = null, int? limit = null, int? offset = null, string orderBy = null, string callback = null)
		{
			return await Cfpb.Utility.Request<LarObject>(Endpoint, DataFormat.Json, select, where, group, limit, offset, orderBy, callback);
		}

	}
}
