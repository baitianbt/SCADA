using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace dong.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Navigations")]
    public partial class Navigations
    {
           public Navigations(){


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
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ParentId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;} = null!;

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Order {get;set;}

           /// <summary>
           /// Desc:
           /// Default:none
           /// Nullable:True
           /// </summary>           
           public string? Icon {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Url {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string Category {get;set;} = null!;

           /// <summary>
           /// Desc:
           /// Default:_self
           /// Nullable:False
           /// </summary>           
           public string Target {get;set;} = null!;

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int IsResource {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'BA'
           /// Nullable:False
           /// </summary>           
           public string Application {get;set;} = null!;

    }
}
