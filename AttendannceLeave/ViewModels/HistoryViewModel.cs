using System;
using System.Collections.ObjectModel;
using AttendannceLeave.Models;
using AttendannceLeave.Services;

namespace AttendannceLeave.ViewModels
{
    public class HistoryViewModel
    {
        public ObservableCollection<AppliedLeave> LeaveList { get; set; }
        public HistoryViewModel()
        {
            PopulateList();
        }

        private void PopulateList()
        {
            var history =   HistorySerivce.GetHistory();
            LeaveList = new ObservableCollection<AppliedLeave>();
            LeaveList.Clear();
            foreach (AppliedLeave leave in history)
            {
                LeaveList.Add(leave);
            }
        }
    }
}
