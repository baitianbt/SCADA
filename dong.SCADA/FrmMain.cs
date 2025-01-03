using Sunny.UI;

namespace dong.SCADA
{
    public partial class FrmMain : UIForm2
    {
        public FrmMain()
        {
            InitializeComponent();

           
            //设置关联
            uiNavMenu1.TabControl = MainTabControl;

            //设置初始页面索引（关联页面，唯一不重复即可）
            int pageIndex = 1000;

            TreeNode parent = uiNavMenu1.CreateNode("监控模块", 61451, 24, pageIndex);

            uiNavMenu1.CreateChildNode(parent, AddPage(new PageEquipmentMonitor(), ++pageIndex));

            TreeNode parent1 = uiNavMenu1.CreateNode("总控模块", 61451, 24, pageIndex);
            uiNavMenu1.CreateChildNode(parent1, AddPage(new PageTotalEquipmentControl(), ++pageIndex));



            //显示默认界面
            uiNavMenu1.SelectFirst();
        }


        #region 无边框窗体拖动/调整大小



        


        private bool isDragging = false;
        private bool isResizing = false;
        private Point lastCursor;
        private int minWidth = 200;
        private int minHeight = 150;


    
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            // 判断是否在右下角进行缩放
            if (e.X >= this.Width - 10 && e.Y >= this.Height - 10)
            {
                isResizing = true;
            }
            else
            {
                isDragging = true;
                lastCursor = e.Location;
            }
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                // 进行缩放操作
                int newWidth = this.Width + (e.X - lastCursor.X);
                int newHeight = this.Height + (e.Y - lastCursor.Y);

                // 限制最小宽度和高度
                if (newWidth >= minWidth) this.Width = newWidth;
                if (newHeight >= minHeight) this.Height = newHeight;

                lastCursor = e.Location;
            }
            else if (isDragging)
            {
                // 进行移动操作
                this.Left = this.Left + (e.X - lastCursor.X);
                this.Top = this.Top + (e.Y - lastCursor.Y);
            }
            else
            {
                // 判断是否鼠标在右下角，用于改变鼠标指针形状
                if (e.X >= this.Width - 10 && e.Y >= this.Height - 10)
                {
                    this.Cursor = Cursors.SizeNWSE;  // 可缩放的指针
                }
                else
                {
                    this.Cursor = Cursors.Default;   // 默认指针
                }
            }

        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
        }
        #endregion

       
    }
}
