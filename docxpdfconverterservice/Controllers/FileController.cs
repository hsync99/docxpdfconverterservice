using docxpdfconverterservice.Services;
using Microsoft.AspNetCore.Mvc;

namespace docxpdfconverterservice.Controllers
{
    public class FileController : Controller
    {
        IConvertationService _convertService;
        public FileController(IConvertationService convertService)
        {
            _convertService = convertService;

        }

        [HttpPost]
        [Route("ToPDF")]
        public async Task<IActionResult> ConvertPDF(IFormFile file)
        {
            var filePath = Path.GetFullPath(file.FileName);
            using (var stream = System.IO.File.Create(filePath))
            {
                await file.CopyToAsync(stream);
            }
            string filename = file.FileName.Replace(".docx", ".pdf");
            var result = await _convertService.ConvertToPdf(filePath);
            System.IO.File.Delete(filePath);
            try
            {
                byte[] filecontent = System.IO.File.ReadAllBytes(result);
                System.IO.File.Delete(result);
                return File(filecontent, "application/pdf", filename);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }
    }
}
