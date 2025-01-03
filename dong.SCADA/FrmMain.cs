using Sunny.UI;

namespace dong.SCADA
{
    public partial class FrmMain : UIAsideHeaderMainFooterFrame
    {
        public FrmMain()
        {
            InitializeComponent();

            //设置关联
            Aside.TabControl = MainTabControl;

            //设置初始页面索引（关联页面，唯一不重复即可）
            int pageIndex = 1000;

            TreeNode parent = Aside.CreateNode("监控模块", 61451, 24, pageIndex);

            Aside.CreateChildNode(parent, AddPage(new PageEquipmentMonitor(), ++pageIndex));
            

            TreeNode parent1 = Aside.CreateNode("总控模块", 61451, 24, pageIndex);
            Aside.CreateChildNode(parent1, AddPage(new PageTotalEquipmentControl(), ++pageIndex));

            //增加页面到Main
            //AddPage(new PageEquipmentMonitor(), 1001);
            //AddPage(new PageEquipmentMonitor1(), 1002);
            //AddPage(new PageEquipmentMonitor(), 1003);

            ////设置Header节点索引
            //Aside.CreateNode("Page1", 1001);
            //Aside.CreateNode("Page2", 1002);
            //Aside.CreateNode("Page3", 1003);

            //显示默认界面
            Aside.SelectFirst();
        }
    }
}
