using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer4.Storage.Mysql.Dto
{
    public class PagedResult<T>
    {
        public int Total { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}
