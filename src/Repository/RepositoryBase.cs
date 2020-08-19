using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer4.Storage.Mysql.Repository
{
    public abstract class RepositoryBase
    {
        protected void AppendParameter(Func<bool> condition,
           DynamicParameters para,
           object paraValue,
           StringBuilder sb,
           string sqlCondition)
        {
            if (condition())
            {
                para.AddDynamicParams(paraValue);
                sb.AppendLine(sqlCondition);
            }
        }
    }
}
