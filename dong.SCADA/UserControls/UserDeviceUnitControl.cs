using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace dong.SCADA.UserControls
{
    public partial class UserDeviceUnitControl : UIUserControl
    {
        public UserDeviceUnitControl()
        {
            InitializeComponent();
        }
       

        private string equipmentUnitName = "设备单元";
        [Browsable(true)]//使属性可以暴露出来，显示到窗口中
        [Category("自定义属性")]//自定义属性
        [Description("设备单元的名称")]
        public string EquipmentUnitName
        {
            get { return equipmentUnitName; }
            set
            {
                equipmentUnitName = value;
                this.lbl_DeviceName.Text = equipmentUnitName;
            }
        }

        private bool state;
        [Browsable(true)]//使属性可以暴露出来，显示到窗口中
        [Category("自定义属性")]//自定义属性
        [Description("设备状态")]
        public bool State
        {
            get
            {
                state = this.sw_Device.Active;
                return state;
            }
            set
            {
                state = value;

                this.sw_Device.Active = state;
            }
        }

        private string openVariableName = "";
        [Browsable(true)]//使属性可以暴露出来，显示到窗口中
        [Category("自定义属性")]//自定义属性
        [Description("获取变量名称")]
        public string OpenVariableName
        {
            get { return openVariableName; }
            set { openVariableName = value; }
        }



        private string closeVariableName = "";
        [Browsable(true)]//使属性可以暴露出来，显示到窗口中
        [Category("自定义属性")]//自定义属性
        [Description("获取变量名称")]
        public string CloseVariableName
        {
            get { return closeVariableName; }
            set { closeVariableName = value; }
        }

        [Browsable(true)]
        [Category("自定义事件")]
        [Description("点击事件")]
        public event EventHandler ClickEvent;
        private void sw_Device_Click(object sender, EventArgs e)
        {
            ClickEvent?.Invoke(this, e);
        }
    }
}
