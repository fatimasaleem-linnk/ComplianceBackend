using Microsoft.Extensions.Configuration;
using ComplianceAndPeformanceSystem.Contract.Common.Exceptions;
using ComplianceAndPeformanceSystem.Contract.IServices;

namespace ComplianceAndPeformanceSystem.BLL.Services;


public class AttachmentService(IConfiguration configuration) : IAttachmentService
{
    public string GetMappedDirectory(string directoryMask, Dictionary<string, string> maskVars)
    {
        string baseDir = configuration.GetSection("Attachment").GetSection("AttachmentPath").Value;
        foreach (var item in maskVars)
            directoryMask = directoryMask.Replace("{" + item.Key + "}", item.Value);

        if (directoryMask.Contains("{") || directoryMask.Contains("}"))
        {
            List<string> missingMaskVarList = new List<string>();
            var missingMaskVarSplitted = directoryMask.Split('{');
            foreach (var item in missingMaskVarSplitted)
                missingMaskVarList.Add(item.Split('}')[0]);
            new BadRequestException("This Mask Variables are missing: " + string.Join(",", missingMaskVarList));
        }

        baseDir += directoryMask;

        if (!Directory.Exists(baseDir))
            Directory.CreateDirectory(baseDir);
       
        return baseDir;
    }

    public byte[] DownloadAttachment(string filePath)
    {
        return File.ReadAllBytes(Path.Combine(filePath));
    }

    public void UploadAttachment(List<KeyValuePair<Stream, string>> attachments)
    {
        foreach (var attachment in attachments)
        {
            using (FileStream outputFileStream = File.Create(attachment.Value))
            {
                attachment.Key.CopyTo(outputFileStream);
            }
        }
    }

    public void DeleteAttachment(string filePath)
    {
        File.Delete(Path.Combine(filePath));
    }
}
