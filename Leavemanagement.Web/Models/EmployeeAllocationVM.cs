﻿using Leavemanagement.Web.Data;

namespace Leavemanagement.Web.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM>  LeaveAllocations { get; set; }
    }
}
