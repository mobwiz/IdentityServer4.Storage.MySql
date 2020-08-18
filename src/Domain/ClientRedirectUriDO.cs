
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("client_redirect_uris")]
    public class ClientRedirectUriDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("RedirectUri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ClientId")]
        public int ClientId { get; set; }

    }
}
