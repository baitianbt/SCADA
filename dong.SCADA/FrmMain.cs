using Sunny.UI;

namespace dong.SCADA
{
    public partial class FrmMain : UIForm2
    {
        public FrmMain()
        {
            InitializeComponent();

           
            //���ù���
            uiNavMenu1.TabControl = MainTabControl;

            //���ó�ʼҳ������������ҳ�棬Ψһ���ظ����ɣ�
            int pageIndex = 1000;

            TreeNode parent = uiNavMenu1.CreateNode("���ģ��", 61451, 24, pageIndex);

            uiNavMenu1.CreateChildNode(parent, AddPage(new PageEquipmentMonitor(), ++pageIndex));

            TreeNode parent1 = uiNavMenu1.CreateNode("�ܿ�ģ��", 61451, 24, pageIndex);
            uiNavMenu1.CreateChildNode(parent1, AddPage(new PageTotalEquipmentControl(), ++pageIndex));



            //��ʾĬ�Ͻ���
            uiNavMenu1.SelectFirst();
        }


        #region �ޱ߿����϶�/������С



        


        private bool isDragging = false;
        private bool isResizing = false;
        private Point lastCursor;
        private int minWidth = 200;
        private int minHeight = 150;


    
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            // �ж��Ƿ������½ǽ�������
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
                // �������Ų���
                int newWidth = this.Width + (e.X - lastCursor.X);
                int newHeight = this.Height + (e.Y - lastCursor.Y);

                // ������С��Ⱥ͸߶�
                if (newWidth >= minWidth) this.Width = newWidth;
                if (newHeight >= minHeight) this.Height = newHeight;

                lastCursor = e.Location;
            }
            else if (isDragging)
            {
                // �����ƶ�����
                this.Left = this.Left + (e.X - lastCursor.X);
                this.Top = this.Top + (e.Y - lastCursor.Y);
            }
            else
            {
                // �ж��Ƿ���������½ǣ����ڸı����ָ����״
                if (e.X >= this.Width - 10 && e.Y >= this.Height - 10)
                {
                    this.Cursor = Cursors.SizeNWSE;  // �����ŵ�ָ��
                }
                else
                {
                    this.Cursor = Cursors.Default;   // Ĭ��ָ��
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
