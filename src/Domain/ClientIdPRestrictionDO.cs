using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("client_id_prestriction")]
    public class ClientIdPRestrictionDO
    {
        [Key, Column("Id")]
        public int Id { get; set; }

        [Column("Provider")]
        public string Provider { get; set; }

        [Column("ClientId")]
        public int ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ClientDO Client { get; set; }
    }
}
