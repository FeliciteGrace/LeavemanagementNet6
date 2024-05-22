using Leavemanagement.Web.Contracts;
using Leavemanagement.Web.Data;

namespace Leavemanagement.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
