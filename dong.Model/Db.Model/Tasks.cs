using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace dong.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Tasks")]
    public partial class Tasks
    {
           public Tasks(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:任务名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TaskName {get;set;} = null!;

           /// <summary>
           /// Desc:分配人
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AssignName {get;set;} = null!;

           /// <summary>
           /// Desc:完成任务人
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;} = null!;

           /// <summary>
           /// Desc:任务所需时间(天)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TaskTime {get;set;}

           /// <summary>
           /// Desc:完成进度
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double TaskProgress {get;set;}

           /// <summary>
           /// Desc:分配时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime AssignTime {get;set;}

    }
}
