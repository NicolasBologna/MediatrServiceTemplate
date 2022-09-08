using AutoMapper;
using MediatR;

namespace $rootnamespace$.Commands
{
    public class Update$fileinputname$Command : IRequest
    {
        public Guid Id { get; set; }
    }

    public class Update$fileinputname$CommandHandler : IRequestHandler<Update$fileinputname$Command>
    {
        private readonly IMapper _mapper;

        public Update$fileinputname$CommandHandler(IMapper mapper)
        {

            _mapper = mapper;
        }

        public async Task<Unit> Handle(Update$fileinputname$Command request, CancellationToken cancellationToken)
        {

            return Unit.Value;
        }
    }
}
