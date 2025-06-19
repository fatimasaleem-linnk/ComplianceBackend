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
        RescheduleRequested = 200,
        //Rescheduled = 201,
        Completed = 202,
        Cancelled = 203
    }
}
