
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("client_scopes")]
    public class ClientScopeDO
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
        [Column("ClientId")]
        public int ClientId { get; set; }

    }
}
