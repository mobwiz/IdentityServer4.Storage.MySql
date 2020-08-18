
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("identity_resource_claims")]
    public class IdentityResourceClaim
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
        [Column("IdentityResourceId")]
        public int IdentityResourceId { get; set; }

    }
}
