using Newtonsoft.Json;
using Shop.Web.Models;
using Shop.Web.Services.IServices;
using System.Text;

namespace Shop.Web.Services
{
	public class BaseService : IBaseService
	{
		public ResponceDto responceModel { get; set; }
		public IHttpClientFactory httpClient { get; set; }

		public BaseService(IHttpClientFactory httpClientFactory)
		{
			responceModel= new ResponceDto();
			httpClient = httpClientFactory;
		}

		public async Task<T> SendAsync<T>(ApiRequest apiRequest)
		{
			try
			{
				var client = httpClient.CreateClient("ShopAPI");
				HttpRequestMessage message = new HttpRequestMessage();
				message.Headers.Add("Accept", "application/json");
				message.RequestUri = new Uri(apiRequest.Url);
				client.DefaultRequestHeaders.Clear();
				if (apiRequest.Data != null)
				{
					message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data), 
														Encoding.UTF8, "application/json");
				}
				HttpResponseMessage apiResponse = null;
				switch (apiRequest.ApiType)
				{
					case SD.ApiType.GET:
						message.Method = HttpMethod.Get;
						break;
					case SD.ApiType.POST:
						message.Method = HttpMethod.Post;
						break;
					case SD.ApiType.PUT:
						message.Method = HttpMethod.Put;
						break;
					case SD.ApiType.DELETE:
						message.Method = HttpMethod.Delete;	
						break;
					default:
						message.Method = HttpMethod.Get;
						break;
				}
				apiResponse = await client.SendAsync(message);
				var apiContent = await apiResponse.Content.ReadAsStringAsync();
				var apiResponsDto = JsonConvert.DeserializeObject<T>(apiContent);
				return apiResponsDto;
			}
			catch (Exception ex)
			{

				var dto = new ResponceDto
				{
					DisplayMessage = "Error",
					ErrorMesage = new List<string> { Convert.ToString(ex.Message) }
				};
				var res = JsonConvert.SerializeObject(dto);
				var apiResponseDto = JsonConvert.DeserializeObject<T>(res);
				return apiResponseDto;
			}
		}
		public void Dispose()
		{
			GC.SuppressFinalize(true);
		}
	}
}