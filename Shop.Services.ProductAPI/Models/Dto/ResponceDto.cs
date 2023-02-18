namespace Shop.Services.ProductAPI.Models.Dto
{
	public class ResponceDto
	{
		public bool IsSuccess { get; set; }
		public object Result { get; set; }
		public string DisplayMessage { get; set; }
		public List<string> ErrorMesage { get; set; }
	}
}
