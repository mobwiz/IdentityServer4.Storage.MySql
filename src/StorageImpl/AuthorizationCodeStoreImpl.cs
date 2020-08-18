using IdentityServer4.Models;
using IdentityServer4.Stores;
using System;
using System.Threading.Tasks;

namespace IdentityServer4.Storage.Mysql.StorageImpl
{
    internal class AuthorizationCodeStoreImpl : IAuthorizationCodeStore
    {
        public Task<AuthorizationCode> GetAuthorizationCodeAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAuthorizationCodeAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task<string> StoreAuthorizationCodeAsync(AuthorizationCode code)
        {
            throw new NotImplementedException();
        }
    }
}
