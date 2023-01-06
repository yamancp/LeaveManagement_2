using AutoMapper;
using LeaveManagement_2.Data;
using LeaveManagement_2.Models;

namespace LeaveManagement_2.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
