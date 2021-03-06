﻿
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("api_scope_claims")]
    public class ApiScopeClaimDO
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
        [Column("ScopeId")]
        public int ScopeId { get; set; }

    }
}
