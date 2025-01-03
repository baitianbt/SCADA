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

namespace dong.SCADA
{
    public partial class FrmDemo : Form
    {
        public FrmDemo()
        {

            InitializeComponent();
            panel1.Capture = false;
        }
        private bool isDragging = false;
        private bool isResizing = false;
        private Point lastCursor;
        private int minWidth = 200;
        private int minHeight = 150;




        private void FrmDemo_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void FrmDemo_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void FrmDemo_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message m = Message.Create(this.Handle, 0x84, IntPtr.Zero, IntPtr.Zero);
                WndProc(ref m);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (isResizing)
            //{
            //    // 进行缩放操作
            //    int newWidth = this.Width + (e.X - lastCursor.X);
            //    int newHeight = this.Height + (e.Y - lastCursor.Y);

            //    // 限制最小宽度和高度
            //    if (newWidth >= minWidth) this.Width = newWidth;
            //    if (newHeight >= minHeight) this.Height = newHeight;

            //    lastCursor = e.Location;
            //}
            //else if (isDragging)
            //{
            //    // 进行移动操作
            //    this.Left = this.Left + (e.X - lastCursor.X);
            //    this.Top = this.Top + (e.Y - lastCursor.Y);
            //}
            //else
            //{
            //    // 判断是否鼠标在右下角，用于改变鼠标指针形状
            //    if (e.X >= this.Width - 10 && e.Y >= this.Height - 10)
            //    {
            //        this.Cursor = Cursors.SizeNWSE;  // 可缩放的指针
            //    }
            //    else
            //    {
            //        this.Cursor = Cursors.Default;   // 默认指针
            //    }
            //}
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HT_CAPTION = 0x2;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                m.Result = (IntPtr)HT_CAPTION; // 让鼠标能够在任何地方捕捉到窗体标题栏
                return;
            }

            base.WndProc(ref m);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //isDragging = false;
            //isResizing = false;
        }
    }
}
