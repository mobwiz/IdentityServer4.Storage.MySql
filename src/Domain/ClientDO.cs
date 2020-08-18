
using System;
using Dapper;


namespace IdentityServer4.Storage.Mysql.Domain
{
    [Table("clients")]
    public class ClientDO
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
        [Column("ClientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ProtocolType")]
        public string ProtocolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("RequireClientSecret")]
        public bool RequireClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ClientName")]
        public string ClientName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ClientUri")]
        public string ClientUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("LogoUri")]
        public string LogoUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("RequireConsent")]
        public bool RequireConsent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AllowRememberConsent")]
        public bool AllowRememberConsent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AlwaysIncludeUserClaimsInIdToken")]
        public bool AlwaysIncludeUserClaimsInIdToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("RequirePkce")]
        public bool RequirePkce { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AllowPlainTextPkce")]
        public bool AllowPlainTextPkce { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("RequireRequestObject")]
        public bool RequireRequestObject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AllowAccessTokensViaBrowser")]
        public bool AllowAccessTokensViaBrowser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("FrontChannelLogoutUri")]
        public string FrontChannelLogoutUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("FrontChannelLogoutSessionRequired")]
        public bool FrontChannelLogoutSessionRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("BackChannelLogoutUri")]
        public string BackChannelLogoutUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("BackChannelLogoutSessionRequired")]
        public bool BackChannelLogoutSessionRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AllowOfflineAccess")]
        public bool AllowOfflineAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("IdentityTokenLifetime")]
        public int IdentityTokenLifetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AllowedIdentityTokenSigningAlgorithms")]
        public string AllowedIdentityTokenSigningAlgorithms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AccessTokenLifetime")]
        public int AccessTokenLifetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AuthorizationCodeLifetime")]
        public int AuthorizationCodeLifetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ConsentLifetime")]
        public int ConsentLifetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AbsoluteRefreshTokenLifetime")]
        public int AbsoluteRefreshTokenLifetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("SlidingRefreshTokenLifetime")]
        public int SlidingRefreshTokenLifetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("RefreshTokenUsage")]
        public int RefreshTokenUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("UpdateAccessTokenClaimsOnRefresh")]
        public bool UpdateAccessTokenClaimsOnRefresh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("RefreshTokenExpiration")]
        public int RefreshTokenExpiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AccessTokenType")]
        public int AccessTokenType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("EnableLocalLogin")]
        public bool EnableLocalLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("IncludeJwtId")]
        public bool IncludeJwtId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("AlwaysSendClientClaims")]
        public bool AlwaysSendClientClaims { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("ClientClaimsPrefix")]
        public string ClientClaimsPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("PairWiseSubjectSalt")]
        public string PairWiseSubjectSalt { get; set; }

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
        [Column("UserSsoLifetime")]
        public int UserSsoLifetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("UserCodeType")]
        public string UserCodeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("DeviceCodeLifetime")]
        public int DeviceCodeLifetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("NonEditable")]
        public bool NonEditable { get; set; }

    }
}
