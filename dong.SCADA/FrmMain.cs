using Sunny.UI;

namespace dong.SCADA
{
    public partial class FrmMain : UIAsideHeaderMainFooterFrame
    {
        public FrmMain()
        {
            InitializeComponent();

            //���ù���
            Aside.TabControl = MainTabControl;

            //���ó�ʼҳ������������ҳ�棬Ψһ���ظ����ɣ�
            int pageIndex = 1000;

            TreeNode parent = Aside.CreateNode("���ģ��", 61451, 24, pageIndex);

            Aside.CreateChildNode(parent, AddPage(new PageEquipmentMonitor(), ++pageIndex));
            

            TreeNode parent1 = Aside.CreateNode("�ܿ�ģ��", 61451, 24, pageIndex);
            Aside.CreateChildNode(parent1, AddPage(new PageTotalEquipmentControl(), ++pageIndex));

            //����ҳ�浽Main
            //AddPage(new PageEquipmentMonitor(), 1001);
            //AddPage(new PageEquipmentMonitor1(), 1002);
            //AddPage(new PageEquipmentMonitor(), 1003);

            ////����Header�ڵ�����
            //Aside.CreateNode("Page1", 1001);
            //Aside.CreateNode("Page2", 1002);
            //Aside.CreateNode("Page3", 1003);

            //��ʾĬ�Ͻ���
            Aside.SelectFirst();
        }
    }
}
