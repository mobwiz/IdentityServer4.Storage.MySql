using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace IdentityServer4.Storage.Mysql.Mapper
{
    /// <summary>
    /// Defines entity/model mapping for identity resources.
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class IdentityResourceMapperProfile : Profile
    {
        /// <summary>
        /// <see cref="IdentityResourceMapperProfile"/>
        /// </summary>
        public IdentityResourceMapperProfile()
        {
            CreateMap<Domain.IdentityResourcePropertyDO, KeyValuePair<string, string>>()
                .ReverseMap();

            CreateMap<Domain.IdentityResourceDO, Models.IdentityResource>(MemberList.Destination)
                .ConstructUsing(src => new Models.IdentityResource())
                .ReverseMap();

            CreateMap<Domain.IdentityResourceClaimDO, string>()
               .ConstructUsing(x => x.Type)
               .ReverseMap()
               .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src));
        }
    }
}
