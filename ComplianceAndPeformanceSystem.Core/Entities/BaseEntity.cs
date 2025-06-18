﻿namespace ComplianceAndPeformanceSystem.Core.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public bool? IsDeleted { get; set; }
}
