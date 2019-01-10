using System;
namespace AttendannceLeave.Models
{
    public enum LeaveType { Compoff, Casual, Sick };
    public enum LeavesStatus { Approved, Rejected, Pending };
    public class AppliedLeave
    {
        public LeaveType Type { get; set; }
        public LeavesStatus Status { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
