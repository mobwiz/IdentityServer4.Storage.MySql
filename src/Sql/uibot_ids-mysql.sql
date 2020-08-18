/*
Navicat MySQL Data Transfer

Source Server         : localdb
Source Server Version : 50731
Source Host           : 192.168.3.11:3306
Source Database       : uibot_ids

Target Server Type    : MYSQL
Target Server Version : 50731
File Encoding         : 65001

Date: 2020-08-18 23:52:09
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for api_resource_claims
-- ----------------------------
DROP TABLE IF EXISTS `api_resource_claims`;
CREATE TABLE `api_resource_claims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(200) CHARACTER SET utf8 NOT NULL,
  `ApiResourceId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of api_resource_claims
-- ----------------------------

-- ----------------------------
-- Table structure for api_resource_properties
-- ----------------------------
DROP TABLE IF EXISTS `api_resource_properties`;
CREATE TABLE `api_resource_properties` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Key` varchar(250) CHARACTER SET utf8 NOT NULL,
  `Value` text CHARACTER SET utf8 NOT NULL,
  `ApiResourceId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of api_resource_properties
-- ----------------------------

-- ----------------------------
-- Table structure for api_resource_scopes
-- ----------------------------
DROP TABLE IF EXISTS `api_resource_scopes`;
CREATE TABLE `api_resource_scopes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Scope` varchar(200) CHARACTER SET utf8 NOT NULL,
  `ApiResourceId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of api_resource_scopes
-- ----------------------------

-- ----------------------------
-- Table structure for api_resource_secrets
-- ----------------------------
DROP TABLE IF EXISTS `api_resource_secrets`;
CREATE TABLE `api_resource_secrets` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Description` text CHARACTER SET utf8,
  `Value` text CHARACTER SET utf8 NOT NULL,
  `Expiration` varchar(27) CHARACTER SET utf8 DEFAULT NULL,
  `Type` varchar(250) CHARACTER SET utf8 NOT NULL,
  `Created` varchar(27) CHARACTER SET utf8 NOT NULL,
  `ApiResourceId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of api_resource_secrets
-- ----------------------------

-- ----------------------------
-- Table structure for api_resources
-- ----------------------------
DROP TABLE IF EXISTS `api_resources`;
CREATE TABLE `api_resources` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Enabled` bit(1) NOT NULL,
  `Name` varchar(200) CHARACTER SET utf8 NOT NULL,
  `DisplayName` varchar(200) CHARACTER SET utf8 DEFAULT NULL,
  `Description` text CHARACTER SET utf8,
  `AllowedAccessTokenSigningAlgorithms` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `ShowInDiscoveryDocument` bit(1) NOT NULL,
  `Created` varchar(27) CHARACTER SET utf8 NOT NULL,
  `Updated` varchar(27) CHARACTER SET utf8 DEFAULT NULL,
  `LastAccessed` varchar(27) CHARACTER SET utf8 DEFAULT NULL,
  `NonEditable` bit(1) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of api_resources
-- ----------------------------

-- ----------------------------
-- Table structure for api_scope_claims
-- ----------------------------
DROP TABLE IF EXISTS `api_scope_claims`;
CREATE TABLE `api_scope_claims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(200) CHARACTER SET utf8 NOT NULL,
  `ScopeId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of api_scope_claims
-- ----------------------------

-- ----------------------------
-- Table structure for api_scope_properties
-- ----------------------------
DROP TABLE IF EXISTS `api_scope_properties`;
CREATE TABLE `api_scope_properties` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Key` varchar(250) CHARACTER SET utf8 NOT NULL,
  `Value` text CHARACTER SET utf8 NOT NULL,
  `ScopeId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of api_scope_properties
-- ----------------------------

-- ----------------------------
-- Table structure for api_scopes
-- ----------------------------
DROP TABLE IF EXISTS `api_scopes`;
CREATE TABLE `api_scopes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Enabled` bit(1) NOT NULL,
  `Name` varchar(200) CHARACTER SET utf8 NOT NULL,
  `DisplayName` varchar(200) CHARACTER SET utf8 DEFAULT NULL,
  `Description` text CHARACTER SET utf8,
  `Required` bit(1) NOT NULL,
  `Emphasize` bit(1) NOT NULL,
  `ShowInDiscoveryDocument` bit(1) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of api_scopes
-- ----------------------------

-- ----------------------------
-- Table structure for client_claims
-- ----------------------------
DROP TABLE IF EXISTS `client_claims`;
CREATE TABLE `client_claims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(250) CHARACTER SET utf8 NOT NULL,
  `Value` varchar(250) CHARACTER SET utf8 NOT NULL,
  `ClientId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of client_claims
-- ----------------------------

-- ----------------------------
-- Table structure for client_cors_origins
-- ----------------------------
DROP TABLE IF EXISTS `client_cors_origins`;
CREATE TABLE `client_cors_origins` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Origin` varchar(150) CHARACTER SET utf8 NOT NULL,
  `ClientId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of client_cors_origins
-- ----------------------------

-- ----------------------------
-- Table structure for client_grant_types
-- ----------------------------
DROP TABLE IF EXISTS `client_grant_types`;
CREATE TABLE `client_grant_types` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `GrantType` varchar(250) CHARACTER SET utf8 NOT NULL,
  `ClientId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of client_grant_types
-- ----------------------------

-- ----------------------------
-- Table structure for client_post_logout_redirect_uris
-- ----------------------------
DROP TABLE IF EXISTS `client_post_logout_redirect_uris`;
CREATE TABLE `client_post_logout_redirect_uris` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PostLogoutRedirectUri` text CHARACTER SET utf8 NOT NULL,
  `ClientId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of client_post_logout_redirect_uris
-- ----------------------------

-- ----------------------------
-- Table structure for client_properties
-- ----------------------------
DROP TABLE IF EXISTS `client_properties`;
CREATE TABLE `client_properties` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Key` varchar(250) CHARACTER SET utf8 NOT NULL,
  `Value` text CHARACTER SET utf8 NOT NULL,
  `ClientId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of client_properties
-- ----------------------------

-- ----------------------------
-- Table structure for client_redirect_uris
-- ----------------------------
DROP TABLE IF EXISTS `client_redirect_uris`;
CREATE TABLE `client_redirect_uris` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RedirectUri` text CHARACTER SET utf8 NOT NULL,
  `ClientId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of client_redirect_uris
-- ----------------------------

-- ----------------------------
-- Table structure for client_scopes
-- ----------------------------
DROP TABLE IF EXISTS `client_scopes`;
CREATE TABLE `client_scopes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Scope` varchar(200) CHARACTER SET utf8 NOT NULL,
  `ClientId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of client_scopes
-- ----------------------------

-- ----------------------------
-- Table structure for client_secrets
-- ----------------------------
DROP TABLE IF EXISTS `client_secrets`;
CREATE TABLE `client_secrets` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Description` text CHARACTER SET utf8,
  `Value` text CHARACTER SET utf8 NOT NULL,
  `Expiration` varchar(27) CHARACTER SET utf8 DEFAULT NULL,
  `Type` varchar(250) CHARACTER SET utf8 NOT NULL,
  `Created` varchar(27) CHARACTER SET utf8 NOT NULL,
  `ClientId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of client_secrets
-- ----------------------------

-- ----------------------------
-- Table structure for ClientIdPRestrictions
-- ----------------------------
DROP TABLE IF EXISTS `ClientIdPRestrictions`;
CREATE TABLE `ClientIdPRestrictions` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Provider` varchar(200) CHARACTER SET utf8 NOT NULL,
  `ClientId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of ClientIdPRestrictions
-- ----------------------------

-- ----------------------------
-- Table structure for clients
-- ----------------------------
DROP TABLE IF EXISTS `clients`;
CREATE TABLE `clients` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Enabled` bit(1) NOT NULL,
  `ClientId` varchar(200) CHARACTER SET utf8 NOT NULL,
  `ProtocolType` varchar(200) CHARACTER SET utf8 NOT NULL,
  `RequireClientSecret` bit(1) NOT NULL,
  `ClientName` varchar(200) CHARACTER SET utf8 DEFAULT NULL,
  `Description` text CHARACTER SET utf8,
  `ClientUri` text CHARACTER SET utf8,
  `LogoUri` text CHARACTER SET utf8,
  `RequireConsent` bit(1) NOT NULL,
  `AllowRememberConsent` bit(1) NOT NULL,
  `AlwaysIncludeUserClaimsInIdToken` bit(1) NOT NULL,
  `RequirePkce` bit(1) NOT NULL,
  `AllowPlainTextPkce` bit(1) NOT NULL,
  `RequireRequestObject` bit(1) NOT NULL,
  `AllowAccessTokensViaBrowser` bit(1) NOT NULL,
  `FrontChannelLogoutUri` text CHARACTER SET utf8,
  `FrontChannelLogoutSessionRequired` bit(1) NOT NULL,
  `BackChannelLogoutUri` text CHARACTER SET utf8,
  `BackChannelLogoutSessionRequired` bit(1) NOT NULL,
  `AllowOfflineAccess` bit(1) NOT NULL,
  `IdentityTokenLifetime` int(11) NOT NULL,
  `AllowedIdentityTokenSigningAlgorithms` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `AccessTokenLifetime` int(11) NOT NULL,
  `AuthorizationCodeLifetime` int(11) NOT NULL,
  `ConsentLifetime` int(11) DEFAULT NULL,
  `AbsoluteRefreshTokenLifetime` int(11) NOT NULL,
  `SlidingRefreshTokenLifetime` int(11) NOT NULL,
  `RefreshTokenUsage` int(11) NOT NULL,
  `UpdateAccessTokenClaimsOnRefresh` bit(1) NOT NULL,
  `RefreshTokenExpiration` int(11) NOT NULL,
  `AccessTokenType` int(11) NOT NULL,
  `EnableLocalLogin` bit(1) NOT NULL,
  `IncludeJwtId` bit(1) NOT NULL,
  `AlwaysSendClientClaims` bit(1) NOT NULL,
  `ClientClaimsPrefix` varchar(200) CHARACTER SET utf8 DEFAULT NULL,
  `PairWiseSubjectSalt` varchar(200) CHARACTER SET utf8 DEFAULT NULL,
  `Created` varchar(27) CHARACTER SET utf8 NOT NULL,
  `Updated` varchar(27) CHARACTER SET utf8 DEFAULT NULL,
  `LastAccessed` varchar(27) CHARACTER SET utf8 DEFAULT NULL,
  `UserSsoLifetime` int(11) DEFAULT NULL,
  `UserCodeType` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `DeviceCodeLifetime` int(11) NOT NULL,
  `NonEditable` bit(1) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of clients
-- ----------------------------

-- ----------------------------
-- Table structure for device_codes
-- ----------------------------
DROP TABLE IF EXISTS `device_codes`;
CREATE TABLE `device_codes` (
  `UserCode` varchar(200) CHARACTER SET utf8 NOT NULL,
  `DeviceCode` varchar(200) CHARACTER SET utf8 NOT NULL,
  `SubjectId` varchar(200) CHARACTER SET utf8 DEFAULT NULL,
  `SessionId` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `ClientId` varchar(200) CHARACTER SET utf8 NOT NULL,
  `Description` varchar(200) CHARACTER SET utf8 DEFAULT NULL,
  `CreationTime` varchar(27) CHARACTER SET utf8 NOT NULL,
  `Expiration` varchar(27) CHARACTER SET utf8 NOT NULL,
  `Data` longtext CHARACTER SET utf8 NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of device_codes
-- ----------------------------

-- ----------------------------
-- Table structure for identity_resource_claims
-- ----------------------------
DROP TABLE IF EXISTS `identity_resource_claims`;
CREATE TABLE `identity_resource_claims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(200) CHARACTER SET utf8 NOT NULL,
  `IdentityResourceId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of identity_resource_claims
-- ----------------------------

-- ----------------------------
-- Table structure for identity_resource_properties
-- ----------------------------
DROP TABLE IF EXISTS `identity_resource_properties`;
CREATE TABLE `identity_resource_properties` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Key` varchar(250) CHARACTER SET utf8 NOT NULL,
  `Value` text CHARACTER SET utf8 NOT NULL,
  `IdentityResourceId` int(11) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of identity_resource_properties
-- ----------------------------

-- ----------------------------
-- Table structure for identity_resources
-- ----------------------------
DROP TABLE IF EXISTS `identity_resources`;
CREATE TABLE `identity_resources` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Enabled` bit(1) NOT NULL,
  `Name` varchar(200) CHARACTER SET utf8 NOT NULL,
  `DisplayName` varchar(200) CHARACTER SET utf8 DEFAULT NULL,
  `Description` text CHARACTER SET utf8,
  `Required` bit(1) NOT NULL,
  `Emphasize` bit(1) NOT NULL,
  `ShowInDiscoveryDocument` bit(1) NOT NULL,
  `Created` varchar(27) CHARACTER SET utf8 NOT NULL,
  `Updated` varchar(27) CHARACTER SET utf8 DEFAULT NULL,
  `NonEditable` bit(1) NOT NULL,
  KEY `Id` (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of identity_resources
-- ----------------------------

-- ----------------------------
-- Table structure for persisted_grants
-- ----------------------------
DROP TABLE IF EXISTS `persisted_grants`;
CREATE TABLE `persisted_grants` (
  `Key` varchar(200) CHARACTER SET utf8 NOT NULL,
  `Type` varchar(50) CHARACTER SET utf8 NOT NULL,
  `SubjectId` varchar(200) CHARACTER SET utf8 DEFAULT NULL,
  `SessionId` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `ClientId` varchar(200) CHARACTER SET utf8 NOT NULL,
  `Description` varchar(200) CHARACTER SET utf8 DEFAULT NULL,
  `CreationTime` varchar(27) CHARACTER SET utf8 NOT NULL,
  `Expiration` varchar(27) CHARACTER SET utf8 DEFAULT NULL,
  `ConsumedTime` varchar(27) CHARACTER SET utf8 DEFAULT NULL,
  `Data` longtext CHARACTER SET utf8 NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of persisted_grants
-- ----------------------------
