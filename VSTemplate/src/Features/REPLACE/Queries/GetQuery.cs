using AutoMapper;
using MediatR;
using $datanamespace$;
using $domainnamespace$;

namespace $rootnamespace$;

public class Get$fileinputname$Query : IRequest<Get$fileinputname$Response>
{
    public Guid $fileinputname$Id { get; set; }
}

public class Get$fileinputname$QueryHandler : IRequestHandler<Get$fileinputname$Query, Get$fileinputname$Response>
{
    private readonly IReadRepository<$fileinputname$> _repo;
    private readonly IMapper _mapper;

    public Get$fileinputname$QueryHandler(IReadRepository<$fileinputname$> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    public async Task<Get$fileinputname$Response> Handle(Get$fileinputname$Query request, CancellationToken cancellationToken)
    {
        var item = await _repo.GetByIdAsync(request.$fileinputname$Id);

        if (item is null)
        {
            throw new Exception();
        }

        return _mapper.Map<Get$fileinputname$Response>(item);
    }
}
