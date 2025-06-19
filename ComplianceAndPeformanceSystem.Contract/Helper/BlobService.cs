using ComplianceAndPeformanceSystem.Contract.IServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace ComplianceAndPeformanceSystem.Contract.Helper
{
    public class BlobService : IBlobService
    {
        private readonly IWebHostEnvironment _environment;
        IConfiguration _configuration;
        private readonly string BaseUrl = "https://apitest.swcc.gov.sa/Compliance";

        public BlobService(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _configuration = configuration;
        }

        public async Task<string> UploadFileAsync(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty", nameof(filePath));
            }
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found", filePath);
            }
            var fileName = Path.GetFileName(filePath);
            var destinationPath = Path.Combine(_environment.ContentRootPath, "Files", fileName);
            using (var sourceStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var destinationStream = new FileStream(destinationPath, FileMode.Create))
            {
                await sourceStream.CopyToAsync(destinationStream);
            }
            var _savePath = _configuration["FileSavePath"];
            var fileUrl = _savePath + $"/{fileName}";
            return fileUrl;
        }

        public async Task<filePath> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("File cannot be null or empty", nameof(file));
            }
            var _savePath = _configuration["FileSavePath"];

            var fileName = Path.GetFileName(file.FileName);
            string Extension = $"{DateTime.Now:yyyyMMddHHmmss}_{fileName}";
            var destinationPath = Path.Combine(_environment.ContentRootPath, "Files", Extension);

            using (var stream = new FileStream(destinationPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            var path = _savePath + $"/{Extension}";
            return new filePath { fileUrl = path, Path = destinationPath };
        }

        public IFormFile ConvertBase64ToIFormFile(string base64String, string fileName, string contentType)
        {
            if (base64String != null && fileName != null && contentType != null)
            {
                byte[] fileBytes = Convert.FromBase64String(base64String);
                var stream = new MemoryStream(fileBytes);
                IFormFile formFile = new FormFile(stream, 0, fileBytes.Length, fileName, fileName)
                {
                    Headers = new HeaderDictionary(),
                    ContentType = contentType
                };
                return formFile;
            }
            return null;
        }
    }
}
