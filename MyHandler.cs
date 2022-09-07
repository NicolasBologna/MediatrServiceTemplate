using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace $rootnamespace$
{
	public class $servicename$Request : IRequest<$servicename$Response>
	{
		
	}

	public class $servicename$Handler : IRequestHandler<$servicename$Request, $servicename$Response>
	{
		private readonly IMapper _mapper;

		public $servicename$Handler(IMapper mapper)
		{
			_mapper = mapper;
		}

		public async Task<$servicename$Response> Handle($servicename$Request request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
