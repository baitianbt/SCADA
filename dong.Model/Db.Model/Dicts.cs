using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace dong.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Dicts")]
    public partial class Dicts
    {
           public Dicts(){


           }
           /// <summary>
           /// Desc:字典Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:字典种类
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Category {get;set;} = null!;

           /// <summary>
           /// Desc:字典名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;} = null!;

           /// <summary>
           /// Desc:字典代码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Code {get;set;} = null!;

           /// <summary>
           /// Desc:0表示系统使用，1表示自定义
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int Define {get;set;}

    }
}
