using AutoMapper;
using MyOnionApi.Application.Features.Employees.Queries.GetEmployees;
using MyOnionApi.Application.Features.Positions.Commands.CreatePosition;
using MyOnionApi.Application.Features.Positions.Queries.GetPositions;
using MyOnionApi.Domain.Entities;

namespace MyOnionApi.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}