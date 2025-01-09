using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace dong.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("NavigationRole")]
    public partial class NavigationRole
    {
           public NavigationRole(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int NavigationID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RoleID {get;set;}

    }
}
