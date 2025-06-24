using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Enums
{
    public enum VisitStatusEnum
    {
        New = 126,
        Scheduled = 123,
        Rescheduled = 124,
        ConflictOfInterestDisclosure = 125,
        //Rescheduled = 201,
        RescheduleRequested = 127,
        Completed = 128,
        Cancelled = 129,
        ConflictOfInterestResolved = 130,
        NoTeamMemberAvailable = 131,
    }
}
