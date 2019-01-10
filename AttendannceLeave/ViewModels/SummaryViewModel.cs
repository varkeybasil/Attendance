using System;
using System.Collections.ObjectModel;
using AttendannceLeave.Models;
using AttendannceLeave.Services;

namespace AttendannceLeave.ViewModels
{
    public class SummaryViewModel
    {
        public ObservableCollection<LeaveObject> LeaveList { get; set; }
        public ObservableCollection<AppliedLeave> AppliedLeaveList { get; set; }
        public SummaryViewModel()
        {
            PopulateList();

        }

        private void PopulateList()
        {
            var history = HistorySerivce.GetHistory();
            AppliedLeaveList = new ObservableCollection<AppliedLeave>();
            AppliedLeaveList.Clear();
            foreach (AppliedLeave leave in history)
            {
                AppliedLeaveList.Add(leave);
            }

            var summary = SummaryService.GetSummary();
            LeaveList = new ObservableCollection<LeaveObject>();
            LeaveList.Clear();
            foreach (LeaveObject leave in summary)
            {
                LeaveList.Add(leave);
            }

        }
    }
}
