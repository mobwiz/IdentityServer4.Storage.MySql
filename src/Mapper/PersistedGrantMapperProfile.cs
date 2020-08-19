using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace IdentityServer4.Storage.Mysql.Mapper
{


    /// <summary>
    /// Defines entity/model mapping for persisted grants.
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class PersistedGrantMapperProfile : Profile
    {
        /// <summary>
        /// <see cref="PersistedGrantMapperProfile">
        /// </see>
        /// </summary>
        public PersistedGrantMapperProfile()
        {
            CreateMap<Domain.PersistedGrantDO, Models.PersistedGrant>(MemberList.Destination)
                .ReverseMap();
        }
    }
}
