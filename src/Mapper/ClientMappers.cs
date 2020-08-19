using System;
using System.Text;
using AutoMapper;


namespace IdentityServer4.Storage.Mysql.Mapper
{

    /// <summary>
    /// Extension methods to map to/from entity/model for clients.
    /// </summary>
    public static class ClientMappers
    {
        static ClientMappers()
        {
            Mapper = new MapperConfiguration(cfg => cfg.AddProfile<ClientMapperProfile>())
                .CreateMapper();
        }

        internal static IMapper Mapper { get; }

        /// <summary>
        /// Maps an entity to a model.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public static Models.Client ToModel(this Domain.ClientDO entity)
        {
            return Mapper.Map<Models.Client>(entity);
        }

        /// <summary>
        /// Maps a model to an entity.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public static Domain.ClientDO ToEntity(this Models.Client model)
        {
            return Mapper.Map<Domain.ClientDO>(model);
        }
    }
}
