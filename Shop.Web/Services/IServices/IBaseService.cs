using Shop.Web.Models;

namespace Shop.Web.Services.IServices
{
	public interface IBaseService:IDisposable
	{
		ResponceDto responceModel { get; set; }
		Task<T> SendAsync<T>(ApiRequest apiRequest);
	}
}
