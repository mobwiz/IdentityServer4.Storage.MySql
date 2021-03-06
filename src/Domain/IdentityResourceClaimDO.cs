﻿
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("identity_resource_claims")]
    public class IdentityResourceClaimDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id"), Key]
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
