using System;
using DAL.models;

namespace DTO
{
    public class AutoProfilMapper : AutoMapper.Profile
    {
        public AutoProfilMapper()
        {

            CreateMap<Member, DTOmembers>();
            CreateMap<DTOmembers, Member>();
            CreateMap<KoronaTable, DTOKoronaTable>();
            CreateMap<DTOKoronaTable, KoronaTable>();

        }
    }
}

