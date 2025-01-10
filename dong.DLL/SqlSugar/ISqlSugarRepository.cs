using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace dong.DLL
{
    public interface ISqlSugarRepository<T> : ISugarRepository, ISimpleClient<T> where T : class, new()
    {
       

    }
}
