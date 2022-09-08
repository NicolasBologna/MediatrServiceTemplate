using AutoMapper;
using MediatR;
using $rootnamespace$.Models;

namespace $rootnamespace$.Queries
{
	public class Get$fileinputname$Query : IRequest<List<Get$fileinputname$sResponse>>
	{
	}

	public class Get$fileinputname$sQueryHandler : IRequestHandler<Get$fileinputname$sQuery, List<Get$fileinputname$sResponse>>
	{
		private readonly IMapper _mapper;

		public Get$fileinputname$sQueryHandler(IMapper mapper)
		{
			_mapper = mapper;
		}
		public async Task<List<Get$fileinputname$sResponse>> Handle(Get$fileinputname$sQuery request, CancellationToken cancellationToken)
		{
			return new List<Get$fileinputname$sResponse>();
		}
	}
}