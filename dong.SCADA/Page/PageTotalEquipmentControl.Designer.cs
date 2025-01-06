namespace dong.SCADA
{
    partial class PageTotalEquipmentControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            btn_DryRun = new Sunny.UI.UISymbolButton();
            btn_AlarmReset = new Sunny.UI.UISymbolButton();
            btn_MachineReset = new Sunny.UI.UISymbolButton();
            btn_Stop = new Sunny.UI.UISymbolButton();
            btn_Start = new Sunny.UI.UISymbolButton();
            device_CX = new Sunny.UI.UITitlePanel();
            device_TZ = new UserControls.UserDeviceUnitControl();
            userDeviceUnitControl1 = new UserControls.UserDeviceUnitControl();
            userDeviceUnitControl2 = new UserControls.UserDeviceUnitControl();
            userDeviceUnitControl3 = new UserControls.UserDeviceUnitControl();
            userDeviceUnitControl4 = new UserControls.UserDeviceUnitControl();
            userDeviceUnitControl5 = new UserControls.UserDeviceUnitControl();
            userDeviceUnitControl6 = new UserControls.UserDeviceUnitControl();
            userDeviceUnitControl7 = new UserControls.UserDeviceUnitControl();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiTitlePanel1.SuspendLayout();
            device_CX.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(btn_DryRun);
            uiTitlePanel1.Controls.Add(btn_AlarmReset);
            uiTitlePanel1.Controls.Add(btn_MachineReset);
            uiTitlePanel1.Controls.Add(btn_Stop);
            uiTitlePanel1.Controls.Add(btn_Start);
            uiTitlePanel1.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel1.Location = new Point(9, 10);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.Padding = new Padding(1, 40, 1, 1);
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1216, 189);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "产线总控";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel1.TitleHeight = 40;
            // 
            // btn_DryRun
            // 
            btn_DryRun.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_DryRun.Location = new Point(979, 54);
            btn_DryRun.MinimumSize = new Size(1, 1);
            btn_DryRun.Name = "btn_DryRun";
            btn_DryRun.Radius = 10;
            btn_DryRun.Size = new Size(211, 99);
            btn_DryRun.Symbol = 61452;
            btn_DryRun.SymbolSize = 40;
            btn_DryRun.TabIndex = 4;
            btn_DryRun.Tag = "空运行";
            btn_DryRun.TagString = "空运行";
            btn_DryRun.Text = "报警复位";
            btn_DryRun.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_AlarmReset
            // 
            btn_AlarmReset.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_AlarmReset.Location = new Point(739, 54);
            btn_AlarmReset.MinimumSize = new Size(1, 1);
            btn_AlarmReset.Name = "btn_AlarmReset";
            btn_AlarmReset.Radius = 10;
            btn_AlarmReset.Size = new Size(211, 99);
            btn_AlarmReset.Symbol = 61473;
            btn_AlarmReset.SymbolSize = 40;
            btn_AlarmReset.TabIndex = 3;
            btn_AlarmReset.TagString = "报警复位";
            btn_AlarmReset.Text = "报警复位";
            btn_AlarmReset.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_MachineReset
            // 
            btn_MachineReset.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_MachineReset.Location = new Point(499, 54);
            btn_MachineReset.MinimumSize = new Size(1, 1);
            btn_MachineReset.Name = "btn_MachineReset";
            btn_MachineReset.Radius = 10;
            btn_MachineReset.Size = new Size(211, 99);
            btn_MachineReset.Symbol = 61473;
            btn_MachineReset.SymbolSize = 40;
            btn_MachineReset.TabIndex = 2;
            btn_MachineReset.TagString = "机械复位";
            btn_MachineReset.Text = "机械复位";
            btn_MachineReset.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_Stop
            // 
            btn_Stop.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_Stop.Location = new Point(259, 54);
            btn_Stop.MinimumSize = new Size(1, 1);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Radius = 10;
            btn_Stop.Size = new Size(211, 99);
            btn_Stop.Symbol = 62093;
            btn_Stop.SymbolSize = 40;
            btn_Stop.TabIndex = 1;
            btn_Stop.TagString = "总停止";
            btn_Stop.Text = "总停止";
            btn_Stop.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_Start
            // 
            btn_Start.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_Start.Location = new Point(20, 55);
            btn_Start.MinimumSize = new Size(1, 1);
            btn_Start.Name = "btn_Start";
            btn_Start.Radius = 10;
            btn_Start.Size = new Size(211, 99);
            btn_Start.Symbol = 561649;
            btn_Start.SymbolSize = 40;
            btn_Start.TabIndex = 0;
            btn_Start.TagString = "总启动";
            btn_Start.Text = "总启动";
            btn_Start.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // device_CX
            // 
            device_CX.Controls.Add(userDeviceUnitControl6);
            device_CX.Controls.Add(userDeviceUnitControl7);
            device_CX.Controls.Add(userDeviceUnitControl4);
            device_CX.Controls.Add(userDeviceUnitControl5);
            device_CX.Controls.Add(userDeviceUnitControl2);
            device_CX.Controls.Add(userDeviceUnitControl3);
            device_CX.Controls.Add(userDeviceUnitControl1);
            device_CX.Controls.Add(device_TZ);
            device_CX.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            device_CX.Location = new Point(9, 209);
            device_CX.Margin = new Padding(4, 5, 4, 5);
            device_CX.MinimumSize = new Size(1, 1);
            device_CX.Name = "device_CX";
            device_CX.Padding = new Padding(1, 40, 1, 1);
            device_CX.ShowText = false;
            device_CX.Size = new Size(582, 546);
            device_CX.TabIndex = 1;
            device_CX.Text = "设备单元控制";
            device_CX.TextAlignment = ContentAlignment.MiddleCenter;
            device_CX.TitleHeight = 40;
            // 
            // device_TZ
            // 
            device_TZ.CloseVariableName = "脱脂工位关";
            device_TZ.EquipmentUnitName = "脱脂工位";
            device_TZ.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            device_TZ.Location = new Point(20, 67);
            device_TZ.MinimumSize = new Size(1, 1);
            device_TZ.Name = "device_TZ";
            device_TZ.OpenVariableName = "脱脂工位开";
            device_TZ.Size = new Size(201, 54);
            device_TZ.State = false;
            device_TZ.TabIndex = 0;
            device_TZ.Text = "userDeviceUnitControl1";
            device_TZ.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceUnitControl1
            // 
            userDeviceUnitControl1.CloseVariableName = "粗洗工位关";
            userDeviceUnitControl1.EquipmentUnitName = "粗洗工位";
            userDeviceUnitControl1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl1.Location = new Point(350, 67);
            userDeviceUnitControl1.MinimumSize = new Size(1, 1);
            userDeviceUnitControl1.Name = "userDeviceUnitControl1";
            userDeviceUnitControl1.OpenVariableName = "粗洗工位开";
            userDeviceUnitControl1.Size = new Size(201, 54);
            userDeviceUnitControl1.State = false;
            userDeviceUnitControl1.TabIndex = 1;
            userDeviceUnitControl1.Text = "userDeviceUnitControl1";
            userDeviceUnitControl1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceUnitControl2
            // 
            userDeviceUnitControl2.CloseVariableName = "粗洗工位关";
            userDeviceUnitControl2.EquipmentUnitName = "粗洗工位";
            userDeviceUnitControl2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl2.Location = new Point(350, 171);
            userDeviceUnitControl2.MinimumSize = new Size(1, 1);
            userDeviceUnitControl2.Name = "userDeviceUnitControl2";
            userDeviceUnitControl2.OpenVariableName = "粗洗工位开";
            userDeviceUnitControl2.Size = new Size(201, 54);
            userDeviceUnitControl2.State = false;
            userDeviceUnitControl2.TabIndex = 3;
            userDeviceUnitControl2.Text = "userDeviceUnitControl2";
            userDeviceUnitControl2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceUnitControl3
            // 
            userDeviceUnitControl3.CloseVariableName = "脱脂工位关";
            userDeviceUnitControl3.EquipmentUnitName = "脱脂工位";
            userDeviceUnitControl3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl3.Location = new Point(20, 171);
            userDeviceUnitControl3.MinimumSize = new Size(1, 1);
            userDeviceUnitControl3.Name = "userDeviceUnitControl3";
            userDeviceUnitControl3.OpenVariableName = "脱脂工位开";
            userDeviceUnitControl3.Size = new Size(201, 54);
            userDeviceUnitControl3.State = false;
            userDeviceUnitControl3.TabIndex = 2;
            userDeviceUnitControl3.Text = "userDeviceUnitControl1";
            userDeviceUnitControl3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceUnitControl4
            // 
            userDeviceUnitControl4.CloseVariableName = "粗洗工位关";
            userDeviceUnitControl4.EquipmentUnitName = "粗洗工位";
            userDeviceUnitControl4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl4.Location = new Point(350, 275);
            userDeviceUnitControl4.MinimumSize = new Size(1, 1);
            userDeviceUnitControl4.Name = "userDeviceUnitControl4";
            userDeviceUnitControl4.OpenVariableName = "粗洗工位开";
            userDeviceUnitControl4.Size = new Size(201, 54);
            userDeviceUnitControl4.State = false;
            userDeviceUnitControl4.TabIndex = 5;
            userDeviceUnitControl4.Text = "userDeviceUnitControl4";
            userDeviceUnitControl4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceUnitControl5
            // 
            userDeviceUnitControl5.CloseVariableName = "脱脂工位关";
            userDeviceUnitControl5.EquipmentUnitName = "脱脂工位";
            userDeviceUnitControl5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl5.Location = new Point(20, 275);
            userDeviceUnitControl5.MinimumSize = new Size(1, 1);
            userDeviceUnitControl5.Name = "userDeviceUnitControl5";
            userDeviceUnitControl5.OpenVariableName = "脱脂工位开";
            userDeviceUnitControl5.Size = new Size(201, 54);
            userDeviceUnitControl5.State = false;
            userDeviceUnitControl5.TabIndex = 4;
            userDeviceUnitControl5.Text = "userDeviceUnitControl1";
            userDeviceUnitControl5.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceUnitControl6
            // 
            userDeviceUnitControl6.CloseVariableName = "粗洗工位关";
            userDeviceUnitControl6.EquipmentUnitName = "粗洗工位";
            userDeviceUnitControl6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl6.Location = new Point(350, 380);
            userDeviceUnitControl6.MinimumSize = new Size(1, 1);
            userDeviceUnitControl6.Name = "userDeviceUnitControl6";
            userDeviceUnitControl6.OpenVariableName = "粗洗工位开";
            userDeviceUnitControl6.Size = new Size(201, 54);
            userDeviceUnitControl6.State = false;
            userDeviceUnitControl6.TabIndex = 7;
            userDeviceUnitControl6.Text = "userDeviceUnitControl6";
            userDeviceUnitControl6.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceUnitControl7
            // 
            userDeviceUnitControl7.CloseVariableName = "脱脂工位关";
            userDeviceUnitControl7.EquipmentUnitName = "脱脂工位";
            userDeviceUnitControl7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl7.Location = new Point(20, 380);
            userDeviceUnitControl7.MinimumSize = new Size(1, 1);
            userDeviceUnitControl7.Name = "userDeviceUnitControl7";
            userDeviceUnitControl7.OpenVariableName = "脱脂工位开";
            userDeviceUnitControl7.Size = new Size(201, 54);
            userDeviceUnitControl7.State = false;
            userDeviceUnitControl7.TabIndex = 6;
            userDeviceUnitControl7.Text = "userDeviceUnitControl1";
            userDeviceUnitControl7.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(uiTextBox1);
            uiTitlePanel2.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel2.Location = new Point(599, 209);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.Padding = new Padding(5, 45, 5, 5);
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(624, 546);
            uiTitlePanel2.TabIndex = 2;
            uiTitlePanel2.Text = "日志栏";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel2.TitleHeight = 40;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Dock = DockStyle.Fill;
            uiTextBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox1.Location = new Point(5, 45);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Multiline = true;
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(614, 496);
            uiTextBox1.TabIndex = 0;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // PageTotalEquipmentControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1232, 765);
            ControlBoxFillHoverColor = Color.FromArgb(122, 176, 243);
            Controls.Add(uiTitlePanel2);
            Controls.Add(device_CX);
            Controls.Add(uiTitlePanel1);
            Name = "PageTotalEquipmentControl";
            Padding = new Padding(5);
            RectColor = Color.FromArgb(122, 176, 243);
            Symbol = 57397;
            Text = "设备单元控制";
            uiTitlePanel1.ResumeLayout(false);
            device_CX.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UISymbolButton btn_Start;
        private Sunny.UI.UISymbolButton btn_AlarmReset;
        private Sunny.UI.UISymbolButton btn_MachineReset;
        private Sunny.UI.UISymbolButton btn_Stop;
        private Sunny.UI.UISymbolButton btn_DryRun;
        private Sunny.UI.UITitlePanel device_CX;
        private UserControls.UserDeviceUnitControl device_TZ;
        private UserControls.UserDeviceUnitControl userDeviceUnitControl1;
        private UserControls.UserDeviceUnitControl userDeviceUnitControl6;
        private UserControls.UserDeviceUnitControl userDeviceUnitControl7;
        private UserControls.UserDeviceUnitControl userDeviceUnitControl4;
        private UserControls.UserDeviceUnitControl userDeviceUnitControl5;
        private UserControls.UserDeviceUnitControl userDeviceUnitControl2;
        private UserControls.UserDeviceUnitControl userDeviceUnitControl3;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UITextBox uiTextBox1;
    }
}