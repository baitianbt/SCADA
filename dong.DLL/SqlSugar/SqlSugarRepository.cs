using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace dong.DLL.SqlSugar
{
    internal class SqlSugarRepository<T> : SimpleClient<T>,ISqlSugarRepository<T> where T : class, new()
    {
    }
}
