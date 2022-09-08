using AutoMapper;
using MediatR;
using $datanamespace$;
using $domainnamespace$;

namespace $rootnamespace$
{
	public class Get$fileinputname$Query : IRequest<List<Get$fileinputname$sResponse>>
	{
	}

	public class Get$fileinputname$sQueryHandler : IRequestHandler<Get$fileinputname$sQuery, List<Get$fileinputname$sResponse>>
	{
		private readonly IReadRepository<$fileinputname$> _repo;
		private readonly IMapper _mapper;

		public Get$fileinputname$sQueryHandler(IReadRepository<$fileinputname$> repo, IMapper mapper)
		{
			_repo = repo;
			_mapper = mapper;
		}
		public async Task<List<Get$fileinputname$sResponse>> Handle(Get$fileinputname$sQuery request, CancellationToken cancellationToken)
		{
			var items = await _repo.GetAllAsync();

			return _mapper.Map<List<Get$fileinputname$sResponse>>(items);
		}
	}
}
