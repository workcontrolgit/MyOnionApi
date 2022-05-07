using MyOnionApi.Application.Features.Employees.Queries.GetEmployees;
using MyOnionApi.Application.Parameters;
using MyOnionApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyOnionApi.Application.Interfaces.Repositories
{
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedEmployeeReponseAsync(GetEmployeesQuery requestParameter);
    }
}