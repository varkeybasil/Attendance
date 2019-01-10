using System;
using System.Collections.Generic;
using AttendannceLeave.Models;

namespace AttendannceLeave.Services
{
    public class SummaryService
    {
        public static List<LeaveObject> GetSummary()
        {
            List<LeaveObject> l = new List<LeaveObject>();
            LeaveObject l1 = new LeaveObject { Leaveleft = 1, Type = LeaveType.Casual };
            LeaveObject l2 = new LeaveObject { Leaveleft = 2, Type = LeaveType.Compoff };
            LeaveObject l3 = new LeaveObject { Leaveleft = 3, Type = LeaveType.Sick };
            l.Add(l1);
            l.Add(l2);
            l.Add(l3);


            return l;
        }

    }
}
