using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindkeyboard2._0
{
    public partial class enactment_page : Form
    {
        FileStream fs;
        String[] portn;
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        public enactment_page()
        {
            InitializeComponent();
            String settiing_path = System.Environment.CurrentDirectory;
            String filename = "settingdate.txt";
            File.Create(settiing_path + @"\" + filename);
            //fs = File.Create(settiing_path + @"\"+filename);
            portn = SerialPort.GetPortNames();
            gearcoomport_cb.Items.AddRange(portn);
            bluetooth_cb.Items.AddRange(portn);

        }

        private void enactment_page_Load(object sender, EventArgs e)
        {
            
        }

        private void enactment_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            //fs.Close();
        }
    }
}
