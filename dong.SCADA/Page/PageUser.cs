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

namespace dong.SCADA.Page
{
    public partial class PageUser : UIPage
    {
        public PageUser()
        {
            InitializeComponent();
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            uiButton2.ShowContextMenuStrip(uiContextMenuStrip1, 0, uiButton2.Height);
        }
    }
}
