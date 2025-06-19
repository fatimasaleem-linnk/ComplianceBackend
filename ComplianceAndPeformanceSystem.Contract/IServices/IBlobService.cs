using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.IServices
{
    public interface IBlobService
    {
        Task<string> UploadFileAsync(string filePath);
        Task<filePath> UploadFile(IFormFile file);
        IFormFile ConvertBase64ToIFormFile(string base64String, string fileName, string contentType);
    }
    public class filePath
    {
        public string? fileUrl { get; set; }
        public string? Path { get; set; }
    }
}
