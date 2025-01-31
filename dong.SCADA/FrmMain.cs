using dong.SCADA.Page;
using Sunny.UI;

namespace dong.SCADA
{
    public partial class FrmMain : UIForm2
    {
        public FrmMain()
        {
            InitializeComponent();


            //设置关联
        
            this.MainTabControl = MainContainer;
           
            uiNavMenu1.TabControl = MainContainer ;
            //设置初始页面索引（关联页面，唯一不重复即可）
            int pageIndex = 1000;

            // 首页功能，展示欢迎界面以及界面功能介绍
            uiNavMenu1.CreateNode(AddPage(new PageHome(), ++pageIndex));


            // 系统设置 -- 菜单管理、字典表维护、
            TreeNode parentSystemSet = uiNavMenu1.CreateNode("系统设置", 559631, 24, pageIndex);

            // 用户设置  -- 用户管理、角色管理、权限管理
            TreeNode parentUserSet = uiNavMenu1.CreateNode("账号管理", 361447, 24, pageIndex);

            // 基础数据维护 -- 生产工单、设备信息、工艺信息、产品信息、物料信息、供应商信息、客户信息

            // 报表  -- 生产报表、设备报表、工艺报表、产品报表、物料报表、供应商报表、客户报表

            // 日志 -- 操作日志、异常日志、系统日志、登录日志、访问日志、SQL日志、服务器日志、程序异常

            // 任务和消息 -- 任务管理、消息管理、通知管理、提醒管理、邮件管理、短信管理、微信管理、钉钉管理

            

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

        private void Header1_MouseDown(object sender, MouseEventArgs e)
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

        private void Header1_MouseMove(object sender, MouseEventArgs e)
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

        private void Header1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
        }


        #endregion



        private void uiSymbolLabel2_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                uiSymbolLabel2.Symbol = 62160;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; 
                uiSymbolLabel2.Symbol = 62162; 
            }
        }

        private void uiSymbolLabel1_Click(object sender, EventArgs e)
        {
            this.Close(); // 关闭窗体
        }

        private void uiSymbolLabel9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // 最小化窗体
        }
    }
}
