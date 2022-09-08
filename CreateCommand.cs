using AutoMapper;
using MediatR;

namespace $rootnamespace$.Commands
{
    public class Create$fileinputname$Command : IRequest<Guid>
    {
    }

    public class Create$fileinputname$CommandHandler : IRequestHandler<Create$fileinputname$Command, Guid>
    {
        private readonly IMapper _mapper;

        public Create$fileinputname$CommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<Guid> Handle(Create$fileinputname$Command request, CancellationToken cancellationToken)
        {
t			hrow new NotImplementedException();
        }
    }
}
