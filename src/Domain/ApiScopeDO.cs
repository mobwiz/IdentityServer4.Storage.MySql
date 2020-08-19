
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("api_scopes")]
    public class ApiScopeDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id"), Key]
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
        [Column("Required")]
        public bool Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Emphasize")]
        public bool Emphasize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ShowInDiscoveryDocument")]
        public bool ShowInDiscoveryDocument { get; set; }

    }
}
