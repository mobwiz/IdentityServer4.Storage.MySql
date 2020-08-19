using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using IdentityServer4.Storage.Mysql;
using IdentityServer4.Storage.Mysql.Domain;

namespace IdentityServer4.Storage.Mysql.Mapper
{
    /// <summary>
    /// Extension methods to map to/from entity/model for identity resources.
    /// </summary>
    public static class IdentityResourceMappers
    {
        static IdentityResourceMappers()
        {
            Mapper = new MapperConfiguration(cfg => cfg.AddProfile<IdentityResourceMapperProfile>())
                .CreateMapper();
        }

        internal static IMapper Mapper { get; }

        /// <summary>
        /// Maps an entity to a model.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public static Models.IdentityResource ToModel(this IdentityResourceDO entity)
        {
            return entity == null ? null : Mapper.Map<Models.IdentityResource>(entity);
        }

        /// <summary>
        /// Maps a model to an entity.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public static IdentityResourceDO ToEntity(this Models.IdentityResource model)
        {
            return model == null ? null : Mapper.Map<IdentityResourceDO>(model);
        }
    }
}
