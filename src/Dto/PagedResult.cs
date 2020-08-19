using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer4.Storage.Mysql.Dto
{
    public class PagedResult<T>
    {
        public int Total { get; set; }
        public IEnumerable<T> Data { get; set; }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        public int TotalPages
        {
            get
            {
                return Total % PageSize == 0 ? Total / PageSize : Total / PageSize + 1;
            }
        }
    }
}
