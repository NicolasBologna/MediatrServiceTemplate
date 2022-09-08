using AutoMapper;
using $projectname$.Features.$servicename$.Commands;
using $projectname$.Features.$servicename$.Models;
using $datanamespace$;
using $domainnamespace$;

namespace $rootnamespace$
{
    public class $servicename$Profile : Profile
    {
        public $servicename$Profile()
        {
            CreateMap<$servicename$, Get$servicename$Response>();
            CreateMap<$servicename$, Get$servicename$sResponse>();
            CreateMap<Create$servicename$Command, JobOffer>();
            CreateMap<Update$servicename$Command, $servicename$>();
        }
    }
}
