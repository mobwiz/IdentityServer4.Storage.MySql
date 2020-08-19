using Dapper;
using IdentityServer4.Storage.Mysql.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer4.Storage.Mysql.Repository
{
    internal class ClientRepository
    {
        private IDbConnection _connection;

        public ClientRepository(IDbConnection dbConnection)
        {
            _connection = dbConnection;
        }

        public async Task<int> CreateClient(ClientDO client)
        {
            return (await _connection.InsertAsync(client)) ?? 0;
        }

        public async Task<bool> UpdateClient(ClientDO client)
        {
            return (await _connection.UpdateAsync(client)) > 0;
        }

        public async Task<bool> RemoveClient(int clientId)
        {
            var clientObj = await _connection.GetAsync<ClientDO>(clientId);
            if (clientObj != null)
            {
                return (await _connection.DeleteAsync(clientObj)) > 0;
            }

            return false;
        }       
        

    }
}
