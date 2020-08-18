
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("api_scope_properties")]
    public class ApiScopePropertyDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Key")]
        public string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Value")]
        public string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ScopeId")]
        public int ScopeId { get; set; }

    }
}
