using AutoMapper;
using Leavemanagement.Web.Data;
using Leavemanagement.Web.Models;

namespace Leavemanagement.Web.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
