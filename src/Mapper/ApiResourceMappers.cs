using System.Text;
using AutoMapper;
using IdentityServer4.Storage.Mysql.Domain;

namespace IdentityServer4.Storage.Mysql.Mapper
{

    /// <summary>
    /// Extension methods to map to/from entity/model for API resources.
    /// </summary>
    public static class ApiResourceMappers
    {
        static ApiResourceMappers()
        {
            Mapper = new MapperConfiguration(cfg => cfg.AddProfile<ApiResourceMapperProfile>())
                .CreateMapper();
        }

        internal static IMapper Mapper { get; }

        /// <summary>
        /// Maps an entity to a model.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public static Models.ApiResource ToModel(this ApiResourceDO entity)
        {
            return entity == null ? null : Mapper.Map<Models.ApiResource>(entity);
        }

        /// <summary>
        /// Maps a model to an entity.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public static ApiResourceDO ToEntity(this Models.ApiResource model)
        {
            return model == null ? null : Mapper.Map<ApiResourceDO>(model);
        }
    }
}
