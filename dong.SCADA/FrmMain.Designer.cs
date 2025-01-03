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
            SuspendLayout();
            // 
            // Footer
            // 
            Footer.Location = new Point(250, 820);
            Footer.Size = new Size(1385, 92);
            // 
            // Header
            // 
            Header.Location = new Point(250, 0);
            Header.Size = new Size(1385, 85);
            // 
            // Aside
            // 
            Aside.Location = new Point(0, 0);
            Aside.Size = new Size(250, 912);
            // 
            // FrmMain
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1635, 912);
            CloseAskString = "是否关闭系统";
            EscClose = true;
            Name = "FrmMain";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "Form1";
            ZoomScaleRect = new Rectangle(19, 19, 1461, 677);
            ResumeLayout(false);
        }

        #endregion
    }
}
