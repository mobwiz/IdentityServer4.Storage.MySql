using IdentityServer4.Models;
using IdentityServer4.Stores;
using System;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer4.Storage.Mysql.Repository.Impl
{
    internal class ClientStoreImpl : IClientStore
    {
        public Task<Client> FindClientByIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }
    }
}
