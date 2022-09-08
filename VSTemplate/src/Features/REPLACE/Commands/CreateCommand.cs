using AutoMapper;
using MediatR;
using $datanamespace$;
using $domainnamespace$;

namespace $rootnamespace$
{
    public class Create$fileinputname$Command : IRequest<Guid>
    {
    }

    public class Create$fileinputname$CommandHandler : IRequestHandler<Create$fileinputname$Command, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<$fileinputname$> _repo;

        public Create$fileinputname$CommandHandler(IMapper mapper, IGenericRepository<$fileinputname$> repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<Guid> Handle(Create$fileinputname$Command request, CancellationToken cancellationToken)
        {
            var newObject = _mapper.Map<$fileinputname$>(request);

            _repo.Add(newObject);
            try
            {
                await _repo.SaveAsync(cancellationToken);
            }
            catch (Exception ex)
            {

            }

            return newObject.Id;
        }
    }
}
