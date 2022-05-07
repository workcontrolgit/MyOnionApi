using MyOnionApi.Application.Features.Positions.Queries.GetPositions;
using MyOnionApi.Application.Parameters;
using MyOnionApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyOnionApi.Application.Interfaces.Repositories
{
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);

        Task<bool> SeedDataAsync(int rowCount);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedPositionReponseAsync(GetPositionsQuery requestParameters);
    }
}