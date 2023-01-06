using LeaveManagement_2.Contracts;
using LeaveManagement_2.Data;

namespace LeaveManagement_2.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
