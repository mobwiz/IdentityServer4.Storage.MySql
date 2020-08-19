using Dapper;
using IdentityServer4.Storage.Mysql.Domain;
using IdentityServer4.Storage.Mysql.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer4.Storage.Mysql.Repository
{
    internal class ClientRepository : RepositoryBase
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

        public async Task<ClientDO> GetClientById(string clientId)
        {
            var result = await _connection.GetListPagedAsync<ClientDO>(1, 1, "WHERE ClientId = @clientId", "Id ASC", new { clientId = clientId });
            return result.FirstOrDefault();
        }

        public async Task<PagedResult<ClientDO>> GetClientList(string name, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
