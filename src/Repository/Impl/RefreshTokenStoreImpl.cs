using IdentityServer4.Models;
using IdentityServer4.Stores;
using System;
using System.Threading.Tasks;

namespace IdentityServer4.Storage.Mysql.Repository.Impl
{
    internal class RefreshTokenStoreImpl : IRefreshTokenStore
    {
        public Task<RefreshToken> GetRefreshTokenAsync(string refreshTokenHandle)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRefreshTokenAsync(string refreshTokenHandle)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRefreshTokensAsync(string subjectId, string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<string> StoreRefreshTokenAsync(RefreshToken refreshToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRefreshTokenAsync(string handle, RefreshToken refreshToken)
        {
            throw new NotImplementedException();
        }
    }

}
