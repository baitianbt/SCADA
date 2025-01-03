namespace dong.SCADA
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            uiPanel1 = new Sunny.UI.UIPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiNavMenu1 = new Sunny.UI.UINavMenu();
            pictureBox1 = new PictureBox();
            Footer = new Sunny.UI.UIPanel();
            MainContainer = new Sunny.UI.UITabControl();
            Header2 = new Sunny.UI.UIPanel();
            Header1 = new Sunny.UI.UIPanel();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(uiNavMenu1);
            uiPanel1.Controls.Add(pictureBox1);
            uiPanel1.Dock = DockStyle.Left;
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(2, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiPanel1.RectSides = ToolStripStatusLabelBorderSides.None;
            uiPanel1.Size = new Size(218, 910);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.FromArgb(90, 136, 211);
            uiLabel1.Dock = DockStyle.Bottom;
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.White;
            uiLabel1.Location = new Point(0, 860);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(218, 50);
            uiLabel1.TabIndex = 2;
            uiLabel1.Text = "版本：2024.0626.1";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiNavMenu1
            // 
            uiNavMenu1.BackColor = Color.FromArgb(90, 136, 211);
            uiNavMenu1.BorderStyle = BorderStyle.None;
            uiNavMenu1.Dock = DockStyle.Fill;
            uiNavMenu1.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            uiNavMenu1.FillColor = Color.FromArgb(90, 136, 211);
            uiNavMenu1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiNavMenu1.ForeColor = Color.White;
            uiNavMenu1.FullRowSelect = true;
            uiNavMenu1.HotTracking = true;
            uiNavMenu1.HoverColor = Color.FromArgb(90, 136, 211);
            uiNavMenu1.ItemHeight = 50;
            uiNavMenu1.LineColor = Color.FromArgb(90, 136, 211);
            uiNavMenu1.Location = new Point(0, 245);
            uiNavMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiNavMenu1.Name = "uiNavMenu1";
            uiNavMenu1.ScrollFillColor = Color.FromArgb(90, 136, 211);
            uiNavMenu1.SecondBackColor = Color.FromArgb(90, 136, 211);
            uiNavMenu1.SelectedColor = Color.FromArgb(90, 136, 211);
            uiNavMenu1.SelectedColor2 = Color.FromArgb(90, 136, 211);
            uiNavMenu1.ShowLines = false;
            uiNavMenu1.ShowPlusMinus = false;
            uiNavMenu1.ShowRootLines = false;
            uiNavMenu1.Size = new Size(218, 665);
            uiNavMenu1.TabIndex = 1;
            uiNavMenu1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(90, 136, 211);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(3);
            pictureBox1.Size = new Size(218, 245);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Footer
            // 
            Footer.Dock = DockStyle.Bottom;
            Footer.FillColor = Color.FromArgb(122, 176, 243);
            Footer.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Footer.Location = new Point(220, 860);
            Footer.Margin = new Padding(4, 5, 4, 5);
            Footer.MinimumSize = new Size(1, 1);
            Footer.Name = "Footer";
            Footer.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            Footer.RectSides = ToolStripStatusLabelBorderSides.None;
            Footer.Size = new Size(1413, 50);
            Footer.TabIndex = 2;
            Footer.Text = null;
            Footer.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // MainContainer
            // 
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.DrawMode = TabDrawMode.OwnerDrawFixed;
            MainContainer.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            MainContainer.ItemSize = new Size(0, 1);
            MainContainer.Location = new Point(220, 110);
            MainContainer.MainPage = "";
            MainContainer.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            MainContainer.Name = "MainContainer";
            MainContainer.SelectedIndex = 0;
            MainContainer.Size = new Size(1413, 750);
            MainContainer.SizeMode = TabSizeMode.Fixed;
            MainContainer.TabBackColor = Color.FromArgb(243, 249, 255);
            MainContainer.TabIndex = 4;
            MainContainer.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            MainContainer.TabVisible = false;
            MainContainer.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // Header2
            // 
            Header2.Dock = DockStyle.Top;
            Header2.FillColor = Color.AliceBlue;
            Header2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Header2.Location = new Point(220, 55);
            Header2.Margin = new Padding(4, 5, 4, 5);
            Header2.MinimumSize = new Size(1, 1);
            Header2.Name = "Header2";
            Header2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            Header2.RectSides = ToolStripStatusLabelBorderSides.None;
            Header2.Size = new Size(1413, 55);
            Header2.TabIndex = 3;
            Header2.Text = null;
            Header2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Header1
            // 
            Header1.BackColor = Color.FromArgb(122, 176, 243);
            Header1.Dock = DockStyle.Top;
            Header1.FillColor = Color.FromArgb(122, 176, 243);
            Header1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Header1.Location = new Point(220, 0);
            Header1.Margin = new Padding(4, 5, 4, 5);
            Header1.MinimumSize = new Size(1, 1);
            Header1.Name = "Header1";
            Header1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            Header1.RectSides = ToolStripStatusLabelBorderSides.None;
            Header1.Size = new Size(1413, 55);
            Header1.TabIndex = 1;
            Header1.Text = null;
            Header1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(90, 136, 211);
            ClientSize = new Size(1635, 912);
            CloseAskString = "是否关闭系统";
            Controls.Add(MainContainer);
            Controls.Add(Header2);
            Controls.Add(Footer);
            Controls.Add(Header1);
            Controls.Add(uiPanel1);
            EscClose = true;
            Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            Padding = new Padding(2, 0, 2, 2);
            Resizable = true;
            ShowDragStretch = true;
            ShowTitle = false;
            Text = "Form1";
            ZoomScaleRect = new Rectangle(19, 19, 1461, 677);
            MouseDown += FrmMain_MouseDown;
            MouseMove += FrmMain_MouseMove;
            MouseUp += FrmMain_MouseUp;
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel Footer;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UINavMenu uiNavMenu1;
        private PictureBox pictureBox1;
        private Sunny.UI.UITabControl MainContainer;
        private Sunny.UI.UIPanel Header2;
        private Sunny.UI.UIPanel Header1;
    }
}
