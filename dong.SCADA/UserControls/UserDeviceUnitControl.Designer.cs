namespace dong.SCADA.UserControls
{
    partial class UserDeviceUnitControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_DeviceName = new Sunny.UI.UILabel();
            sw_Device = new Sunny.UI.UISwitch();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Controls.Add(lbl_DeviceName, 0, 0);
            tableLayoutPanel1.Controls.Add(sw_Device, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(250, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_DeviceName
            // 
            lbl_DeviceName.Dock = DockStyle.Fill;
            lbl_DeviceName.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_DeviceName.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_DeviceName.Location = new Point(3, 0);
            lbl_DeviceName.Name = "lbl_DeviceName";
            lbl_DeviceName.Size = new Size(124, 60);
            lbl_DeviceName.TabIndex = 0;
            lbl_DeviceName.Text = "工位名称";
            lbl_DeviceName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sw_Device
            // 
            sw_Device.Dock = DockStyle.Fill;
            sw_Device.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sw_Device.Location = new Point(133, 3);
            sw_Device.MinimumSize = new Size(1, 1);
            sw_Device.Name = "sw_Device";
            sw_Device.Size = new Size(114, 54);
            sw_Device.TabIndex = 1;
            sw_Device.Text = "uiSwitch1";
            // 
            // UserDeviceUnitControl
            // 
            Controls.Add(tableLayoutPanel1);
            Name = "UserDeviceUnitControl";
            Size = new Size(250, 60);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILabel lbl_DeviceName;
        private Sunny.UI.UISwitch sw_Device;
    }
}
