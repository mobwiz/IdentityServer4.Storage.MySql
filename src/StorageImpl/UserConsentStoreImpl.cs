using IdentityServer4.Models;
using IdentityServer4.Stores;
using System;
using System.Threading.Tasks;

namespace IdentityServer4.Storage.Mysql.StorageImpl
{
    internal class UserConsentStoreImpl : IUserConsentStore
    {
        public Task<Consent> GetUserConsentAsync(string subjectId, string clientId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveUserConsentAsync(string subjectId, string clientId)
        {
            throw new NotImplementedException();
        }

        public Task StoreUserConsentAsync(Consent consent)
        {
            throw new NotImplementedException();
        }
    }
}
