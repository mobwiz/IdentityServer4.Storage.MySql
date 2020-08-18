
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("client_claims")]
    public class ClientClaim
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Type")]
        public string Type { get; set; }

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
