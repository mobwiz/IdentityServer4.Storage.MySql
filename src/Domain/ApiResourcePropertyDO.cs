
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("api_resource_properties")]
    public class ApiResourcePropertyDO
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
        [Column("ApiResourceId")]
        public int ApiResourceId { get; set; }

    }
}
