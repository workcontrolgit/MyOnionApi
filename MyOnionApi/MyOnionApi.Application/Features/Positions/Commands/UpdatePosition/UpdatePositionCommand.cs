using MediatR;
using MyOnionApi.Application.Exceptions;
using MyOnionApi.Application.Interfaces.Repositories;
using MyOnionApi.Application.Wrappers;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyOnionApi.Application.Features.Positions.Commands.UpdatePosition
{
    public class UpdatePositionCommand : IRequest<Response<Guid>>
    {
        public Guid Id { get; set; }
        public string positionTitle { get; set; }
        public string positionDescription { get; set; }
        public string positionNumber { get; set; }
        public decimal positionSalary { get; set; }

        public class UpdatePositionCommandHandler : IRequestHandler<UpdatePositionCommand, Response<Guid>>
        {
            private readonly IPositionRepositoryAsync _positionRepository;

            public UpdatePositionCommandHandler(IPositionRepositoryAsync positionRepository)
            {
                _positionRepository = positionRepository;
            }

            public async Task<Response<Guid>> Handle(UpdatePositionCommand command, CancellationToken cancellationToken)
            {
                var position = await _positionRepository.GetByIdAsync(command.Id);

                if (position == null)
                {
                    throw new ApiException($"Position Not Found.");
                }
                else
                {
                    position.PositionTitle = command.positionTitle;
                    position.PositionSalary = command.positionSalary;
                    position.PositionDescription = command.positionDescription;
                    position.PositionNumber = command.positionNumber;
                    await _positionRepository.UpdateAsync(position);
                    return new Response<Guid>(position.Id);
                }
            }
        }
    }
}