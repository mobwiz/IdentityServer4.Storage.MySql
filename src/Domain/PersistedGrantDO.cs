
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("persisted_grants")]
    public class PersistedGrantDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("Key"), Key]
        public string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("SubjectId")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("SessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ClientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("CreationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ConsumedTime")]
        public string ConsumedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Data")]
        public string Data { get; set; }

    }
}
