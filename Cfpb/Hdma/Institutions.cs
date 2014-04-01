using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Cfpb.Hdma
{
	public class Institutions
	{
		private const string Endpoint = "/data/hmda/slice/institutions";

		public static List<JObject> Query(List<string> select = null, string where = null, List<string> group = null, int? limit = null, int? offset = null, string orderBy = null, string callback = null)
		{
			throw new NotImplementedException();
			//return Utility.Request<JObject>(Endpoint, DataFormat.Json, select, where, group, limit, offset, orderBy, callback);
		}
	}
}
