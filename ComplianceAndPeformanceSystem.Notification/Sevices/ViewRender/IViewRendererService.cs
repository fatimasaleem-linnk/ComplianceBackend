namespace ComplianceAndPeformanceSystem.Notification.Services;

public interface IViewRendererService
{
    Task<string> RenderPartialToStringAsync<TModel>(string partialName, TModel model);
}
