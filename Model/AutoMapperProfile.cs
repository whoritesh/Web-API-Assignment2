using AutoMapper;

namespace EmployeeManagementSystem.Model
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Employee, EmployeesDto>();
            CreateMap<EmployeesDto, Employee>();
            CreateMap<Department, DepartmentsDto>();
            CreateMap<DepartmentsDto, Department>();
        }
    }
}
