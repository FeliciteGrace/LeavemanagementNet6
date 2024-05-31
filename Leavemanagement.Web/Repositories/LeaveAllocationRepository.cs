using AutoMapper;
using Leavemanagement.Web.Constants;
using Leavemanagement.Web.Contracts;
using Leavemanagement.Web.Data;
using Leavemanagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using System.Security.Cryptography;

namespace Leavemanagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;
        private readonly ApplicationDbContext context;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }
        public async Task AllocateLeave(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var period = DateTime.Now.Year;
            var allocations = new List<LeaveAllocation>();

            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });
            }

            await AddRangeAsync(allocations);
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(l => l.EmployeeId == employeeId
                                                        && l.LeaveTypeId == leaveTypeId
                                                        && l.Period == period);
        }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
        {
            var leaveAllocation = await context.LeaveAllocations
                                    .Include(al => al.LeaveType).FirstOrDefaultAsync(al => al.Id == id);
            if (leaveAllocation == null)
            {
                return null;
            }
            LeaveAllocationEditVM model = mapper.Map<LeaveAllocationEditVM>(leaveAllocation);
            model.Employee = mapper.Map<EmployeeAllocationVM>(
                await userManager.FindByIdAsync(leaveAllocation.EmployeeId));
            return model;
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var leaveAllocations = await context.LeaveAllocations
                .Include(al => al.LeaveType)
                .Where(al => al.EmployeeId == employeeId)
                .ToListAsync();
            var employee = await userManager.FindByIdAsync(employeeId);

            EmployeeAllocationVM employeeAllocations = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocations.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(leaveAllocations);
            return employeeAllocations;
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);
            return true;
        }
    }
}
