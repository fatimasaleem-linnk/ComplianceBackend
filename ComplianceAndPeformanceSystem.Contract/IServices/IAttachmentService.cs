namespace ComplianceAndPeformanceSystem.Contract.IServices;

public interface IAttachmentService
{
    public string GetMappedDirectory(string directoryMask, Dictionary<string, string> maskVars);
    public void UploadAttachment(List<KeyValuePair<Stream, string>> attachments);

    public byte[] DownloadAttachment(string filePath);

    public void DeleteAttachment(string filePath);

}
