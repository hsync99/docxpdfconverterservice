namespace docxpdfconverterservice.Services
{
    public interface IConvertationService
    {
        Task<string> ConvertToPdf(string filepath);
    }
}
