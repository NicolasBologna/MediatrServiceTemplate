using AutoMapper;
using MediatR;
using $datanamespace$;
using $domainnamespace$;

namespace $rootnamespace$
{
    public class Update$fileinputname$Command : IRequest
    {
        public Guid Id { get; set; }
    }

    public class Update$fileinputname$CommandHandler : IRequestHandler<Update$fileinputname$Command>
    {
        private readonly IGenericRepository<$fileinputname$> _repository;
        private readonly IMapper _mapper;

        public Update$fileinputname$CommandHandler(IGenericRepository<$fileinputname$> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(Update$fileinputname$Command request, CancellationToken cancellationToken)
        {
            var dbObject = await _repository.GetByIdAsync(request.Id);

            if (dbObject is null)
            {
                throw new Exception();
            }

            _mapper.Map(request, dbObject);

            await _repository.SaveAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
