using SmartAstra.Framework.Common;
using System;

namespace SmartAstra.Entities
{
    public class Schedule: BaseEntity
    {
        public DateTime StartDateTime { get; set; }
        public bool IsRecurring { get; set; }
        public Recurrence Recurrence { get; set; }
        public TimeSpan RecurrenceTime { get; set; }
    }
}
