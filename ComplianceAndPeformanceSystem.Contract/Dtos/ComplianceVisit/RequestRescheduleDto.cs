using ComplianceAndPeformanceSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit;

    public class RequestRescheduleDto
    {
    public int Id { get; set; }
    public Guid ComplianceDetailsID { get; set; }
    public long LicensedEntityId { get; set; }
    public int RequestedByUserId { get; set; }
    public DateTime RequestedAt { get; set; }
    public DateTime ProposedDate { get; set; }
    public string Reason { get; set; } = "";
    public string? Status { get; set; } // Pending, Approved, Rejected
    public DateTime? ReviewedAt { get; set; }
    public int? ReviewedByUserId { get; set; }
    public string? ReviewReason { get; set; }
    }
   
    public class ReviewRescheduleDto
    {
    public Guid ComplianceDetailsID { get; set; }
    public Guid RequestId { get; set; }
    public bool Approve { get; set; }
    public string? Reason { get; set; } 
    public string? ApprovalWithEdit { get; set; }
    public DateTime NewProposedDate { get; set; }
    }


