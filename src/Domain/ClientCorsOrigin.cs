
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("client_cors_origins")]
    public class ClientCorsOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Origin")]
        public string Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ClientId")]
        public int ClientId { get; set; }

    }
}
