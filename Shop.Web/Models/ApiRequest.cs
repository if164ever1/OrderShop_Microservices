using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;
using static Shop.Web.SD;

namespace Shop.Web.Models
{
	public class ApiRequest
	{
		public ApiType ApiType { get; set; } = ApiType.GET;
		public string Url { get; set; }
		public object Data { get; set; }
		public string AccessToken { get; set; }
	}
}
