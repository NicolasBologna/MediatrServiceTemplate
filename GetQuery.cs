using AutoMapper;
using MediatR;
using $rootnamespace$.Models;

namespace $rootnamespace$.Queries;

public class Get$fileinputname$Query : IRequest<Get$fileinputname$Response>
{
    public Guid $fileinputname$Id { get; set; }
}

public class Get$fileinputname$QueryHandler : IRequestHandler<Get$fileinputname$Query, Get$fileinputname$Response>
{
    private readonly IMapper _mapper;

    public Get$fileinputname$QueryHandler(IMapper mapper)
    {
        _mapper = mapper;
    }
    public async Task<Get$fileinputname$Response> Handle(Get$fileinputname$Query request, CancellationToken cancellationToken)
    {
        return new Get$fileinputname$Response();
    }
}