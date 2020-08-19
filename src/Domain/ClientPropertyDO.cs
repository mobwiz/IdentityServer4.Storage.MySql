
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("client_properties")]
    public class ClientPropertyDO
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
        [Column("ClientId")]
        public int ClientId { get; set; }

    }
}
