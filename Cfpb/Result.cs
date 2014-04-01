using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cfpb
{
	public class Result<T>
	{
		[JsonProperty("total")]
		public int Total { get; set; }

		[JsonProperty("slice")]
		public string Slice { get; set; }

		[JsonProperty("dataset")]
		public string Dataset { get; set; }

		[JsonProperty("computing")]
		public string Computing { get; set; }

		[JsonProperty("page")]
		public int Page { get; set; }

		[JsonProperty("errors")]
		public JObject Errors { get; set; }

		[JsonProperty("size")]
		public int Size { get; set; }

		[JsonProperty("_links")]
		public List<JObject> Links { get; set; }

		[JsonProperty("results")]
		public List<T> Results { get; set; }
	}
}
