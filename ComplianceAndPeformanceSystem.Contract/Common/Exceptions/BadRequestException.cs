namespace ComplianceAndPeformanceSystem.Contract.Common.Exceptions;

public class BadRequestException(string message) : Exception(message)
{
}