using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindkeyboard2._0
{
    public partial class SimpleForm : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        public SimpleForm()
        {
            InitializeComponent();
        }

        private void SimpleForm_Load(object sender, EventArgs e)
        {

        }

        private void printscreenb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

        private void scrolllockb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{SCROLLLOCK}");
        }

        private void pausebreakb_Click(object sender, EventArgs e)
        {

        }

        private void insertb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{INS}");
        }

        private void homeb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void pageub_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void delb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
        }

        private void endb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{END}");
        }

        private void pagedb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(C)");
        }

        private void pastbtn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(V)");
        }

        private void cutbtn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(X)");
        }

        private void choceallbtn_Click(object sender, EventArgs e)
        {
            SendKeys.Send(keys: "^a");
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^s");
        }

        private void closeformbtn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%({F4})");
        }

        private void chromebtm_Click(object sender, EventArgs e)
        {

        }

        private void leftpagebtn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{PGUP}");
        }

        private void rightpagebtn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{PGDN}");
        }

        private void startb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{ESC}");
        }

        private void workbtn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^+{ESC}");
        }

        private void escb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void enactment_btn_Click(object sender, EventArgs e)
        {
            enactment_page frm = new enactment_page();
            frm.ShowDialog(this);
        }
    }
}
