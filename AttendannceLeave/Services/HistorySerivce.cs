using System;
using System.Collections.Generic;
using AttendannceLeave.Models;

namespace AttendannceLeave.Services
{
    public class HistorySerivce
    {
        public static List<AppliedLeave> GetHistory()
        {

            DateTime dt2 = DateTime.Now;
            AppliedLeave a1 = new AppliedLeave { FromDate = dt2, ToDate = dt2, Status = LeavesStatus.Approved, Type = LeaveType.Casual };
            AppliedLeave a2 = new AppliedLeave { FromDate = dt2, ToDate = dt2, Status = LeavesStatus.Pending, Type = LeaveType.Sick };
            AppliedLeave a3 = new AppliedLeave { FromDate = dt2, ToDate = dt2, Status = LeavesStatus.Pending, Type = LeaveType.Sick };
            AppliedLeave a4 = new AppliedLeave { FromDate = dt2, ToDate = dt2, Status = LeavesStatus.Pending, Type = LeaveType.Compoff };
            AppliedLeave a5 = new AppliedLeave { FromDate = dt2, ToDate = dt2, Status = LeavesStatus.Rejected, Type = LeaveType.Casual };

            List<AppliedLeave> list = new List<AppliedLeave>();
            list.Add(a1);
            list.Add(a2);
            list.Add(a3); 
            list.Add(a4);
            list.Add(a5);

            //hs.AppliedLeaves.Add(new AppliedLeave { FromDate = new DateTime(2012, 2, 2), ToDate = new DateTime(2012, 2, 2), Status = LeavesStatus.Pending, Type = LeaveType.Compoff });
            //hs.AppliedLeaves.Add(new AppliedLeave { FromDate = new DateTime(2012, 2, 2), ToDate = new DateTime(2012, 2, 2), Status = LeavesStatus.Rejected, Type = LeaveType.Sick });
            //hs.AppliedLeaves.Add(new AppliedLeave { FromDate = new DateTime(2012, 2, 2), ToDate = new DateTime(2012, 2, 2), Status = LeavesStatus.Pending, Type = LeaveType.Sick });
            //hs.AppliedLeaves.Add(new AppliedLeave { FromDate = new DateTime(2012, 2, 2), ToDate = new DateTime(2012, 2, 2), Status = LeavesStatus.Pending, Type = LeaveType.Sick });


            return list;

       }

    }
}
