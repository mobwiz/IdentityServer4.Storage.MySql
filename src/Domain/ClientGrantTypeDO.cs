
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("client_grant_types")]
    public class ClientGrantTypeDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("GrantType")]
        public string GrantType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ClientId")]
        public int ClientId { get; set; }

    }
}
