using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace dong.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ResetUsers")]
    public partial class ResetUsers
    {
           public ResetUsers(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;} = null!;

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string DisplayName {get;set;} = null!;

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Reason {get;set;} = null!;

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ResetTime {get;set;}

    }
}
