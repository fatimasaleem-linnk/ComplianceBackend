namespace ComplianceAndPeformanceSystem.Contract.Common.Exceptions;

public class ValidationException : Exception
{
    public ValidationException()
        : base("One or more validation failures have occurred.")
    {
        Failures = new Dictionary<string, string[]>();
    }

    public ValidationException(List<KeyValuePair<string,string>> failures)
        : this()
    {
        var propertyNames = failures
            .Select(e => e.Key)
            .Distinct();

        foreach (var propertyName in propertyNames)
        {
            var propertyFailures = failures
                .Where(e => e.Key == propertyName)
                .Select(e => e.Value)
                .ToArray();

            Failures.Add(propertyName, propertyFailures);
        }
    }

    public IDictionary<string, string[]> Failures { get; }
}

