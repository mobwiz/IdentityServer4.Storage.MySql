
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("identity_resource_properties")]
    public class IdentityResourcePropertyDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id"), Key]
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
        [Column("IdentityResourceId")]
        public int IdentityResourceId { get; set; }

    }
}
