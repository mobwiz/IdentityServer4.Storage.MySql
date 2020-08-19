
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("api_resource_secrets")]
    public class ApiResourceSecretDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Id"), Key]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Value")]
        public string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Created")]
        public string Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ApiResourceId")]
        public int ApiResourceId { get; set; }

    }
}
