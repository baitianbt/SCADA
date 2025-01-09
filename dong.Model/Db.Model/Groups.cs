using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace dong.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Groups")]
    public partial class Groups
    {
           public Groups(){


           }
           /// <summary>
           /// Desc:ID
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
           public string GroupCode {get;set;} = null!;

           /// <summary>
           /// Desc:部门名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string GroupName {get;set;} = null!;

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Description {get;set;}

    }
}
