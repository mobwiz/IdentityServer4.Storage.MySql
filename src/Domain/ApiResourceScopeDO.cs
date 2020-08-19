
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("api_resource_scopes")]
    public class ApiResourceScopeDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id"), Key]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ApiResourceId")]
        public int ApiResourceId { get; set; }

    }
}
