
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("device_codes")]
    public class DeviceCodeDO
    {
        /// <summary>
        /// 
        /// </summary>
        [Column("UserCode")]
        public string UserCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("DeviceCode")]
        public string DeviceCode { get; set; }

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
        [Column("Data")]
        public string Data { get; set; }

    }
}
