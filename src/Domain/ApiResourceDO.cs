
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("api_resources")]
    public class ApiResourceDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AllowedAccessTokenSigningAlgorithms")]
        public string AllowedAccessTokenSigningAlgorithms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ShowInDiscoveryDocument")]
        public bool ShowInDiscoveryDocument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Created")]
        public string Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Updated")]
        public string Updated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("LastAccessed")]
        public string LastAccessed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("NonEditable")]
        public bool NonEditable { get; set; }

    }
}
