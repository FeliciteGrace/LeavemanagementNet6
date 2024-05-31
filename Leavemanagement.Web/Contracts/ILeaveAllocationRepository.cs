using Leavemanagement.Web.Data;
using Leavemanagement.Web.Models;

namespace Leavemanagement.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task AllocateLeave(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId , int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int Id);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);

    }
}
