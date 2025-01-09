using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace dong.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("RejectUsers")]
    public partial class RejectUsers
    {
           public RejectUsers(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;} = null!;

           /// <summary>
           /// Desc:显示名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string DisplayName {get;set;} = null!;

           /// <summary>
           /// Desc:注册时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime RegisterTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string RejectedBy {get;set;} = null!;

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime RejectedTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? RejectedReason {get;set;}

    }
}
