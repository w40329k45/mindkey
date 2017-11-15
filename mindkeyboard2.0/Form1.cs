using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using ThinkGearNET;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
//using Tdictionary;

namespace mindkeyboard2._0
{
    public partial class Form1 : Form
    {
        protected System.IO.Ports.SerialPort ports = new SerialPort();
        protected ThinkGearWrapper _thinkgearnet = new ThinkGearWrapper();
        String[] portn;
        String ardport,gearport;
        int count;
        SerialPort myport = new SerialPort();//arduino 
        InputLanguage nowlanguage = InputLanguage.CurrentInputLanguage;//取得當前語系
        Syshelper syshelper = new Syshelper();
        Process TGC;
        public ImeMode GetImeMode = new ImeMode();


        //改變視窗屬性
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        public Form1()
        {
            InitializeComponent();
            //timer1.Enabled = true;
            //timer1.Tick+= new EventHandler(timer1_Tick); ;
            //findcomport();
            portn = SerialPort.GetPortNames();
            geatcomportc.Items.AddRange(portn);
            ardcomportc.Items.AddRange(portn);

        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            // _thinkgearnet = new ThinkGearWrapper();
            //

            //取得電腦輸入法
            //imeb.Text = nowlanguage.Culture.ToString();
            //imeb.Text = nowlanguage.Handle.ToString();
            imeb.Text = this.ImeMode.ToString();

            //開啟腦波連結程式
            TGC = new Process();
            TGC.StartInfo.FileName = @"C:\Program Files (x86)\NeuroSky\MindWave Mobile core\ThinkGear Connector\ThinkGear Connector.exe";
            //TGC.StartInfo.FileName = TGCpath;
            TGC.Start();


           

        }

        void link()
        {
            myport.BaudRate = 9600;
            myport.PortName = ardport;
            label1.Text = gearport;
            while (!_thinkgearnet.Connect(gearport, 57600, true))
            {
                label1.Text = "1111";
            }
            //label1.Text = count.ToString();
            //label1.Text += "ard:"+ardport;
            myport.Open();
            _thinkgearnet.ThinkGearChanged += showattention;
            myport.DataReceived += _myport;
        }

        void showattention(object sender,ThinkGearChangedEventArgs e)
        {
              BeginInvoke(new MethodInvoker(delegate
                              {
                                  attshow.Text = e.ThinkGearState.Attention+","+e.ThinkGearState.Meditation;
                              }));

            syshelper.downclick(e.ThinkGearState.Attention);
            Thread.Sleep(5000);
            //attshow.Text = _thinkgearnet.ThinkGearState.ToString();
        }

        void _myport(object sender,SerialDataReceivedEventArgs e)
            {
            int[] data_b = new int[2];
            BeginInvoke(new MethodInvoker(delegate
            {
                String data_xy = myport.ReadLine();
                ardshow.Text = data_xy;

                String[] data_a = data_xy.Split(',');
                
                int j = 0;
                foreach (string i in data_a)
                {
                    data_b[j] = int.Parse(i);
                    j++;
                }
                    
            }));
            Thread.Sleep(500);
            syshelper.movemouse(data_b);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("Q");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("q");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("W");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("w");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("E");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("e");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("R");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("r");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("T");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("t");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("Y");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("y");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("U");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("u");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("I");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("i");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("O");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("o");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("P");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("p");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("A");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("a");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("S");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("s");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("D");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("d");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("F");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("f");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("G");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("g");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("H");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("h");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("J");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("j");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("K");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("k");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("L");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("l");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("Z");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("z");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("X");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("x");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("C");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("c");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("V");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("v");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("B");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("b");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("N");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("n");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (capscheck.Checked || Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("M");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("m");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("{{}");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("[");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("{}}");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("]");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("{|}");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("\\");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("{:}");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send(";");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("{\"}");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("'");
        }

        private void button32_Click(object sender, EventArgs e)//enter
        {
            SendKeys.Send("{ENTER}");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("<");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send(",");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send(">");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send(".");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("?");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("/");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("!");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("1");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("@");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("2");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("#");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("3");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("$");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("4");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("%");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("5");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("{^}");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("6");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("&");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("7");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("*");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("8");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("{(}");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("9");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if ( Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("{)}");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("0");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("_");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("-");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("{+}");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("=");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void button49_Click(object sender, EventArgs e)//space
        {
            SendKeys.Send(" ");
        }

        private void connectb_Click(object sender, EventArgs e)
        {
            gearport = geatcomportc.Text;
            ardport = ardcomportc.Text;
            geatcomportc.Enabled = false;
            ardcomportc.Enabled = false;
            link();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if ( Lshiftc.Checked || Rshiftc.Checked)
            {
                SendKeys.Send("{~}");
                Lshiftc.Checked = false;
                Rshiftc.Checked = false;
            }
            else SendKeys.Send("`");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }
        private void leftstartb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{ESC}");
        }

        private void rightstartb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{ESC}");
        }

        private void escb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void f1b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void f2b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void f3b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void f4b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void f5b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void f6b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void f7b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void f8b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void f9b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void f10b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void f11b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void f12b_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        private void imeb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("+");
            imeb.Text = nowlanguage.LayoutName;
            //imeb.Text = nowlanguage.Handle.ToString();
            //imeb.Text=this.ImeMode.ToString();
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

        private void pagedb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void endb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{END}");
        }

        private void delb_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TGC.Kill();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LC_Click(object sender, EventArgs e)
        {

        }

        private void RC_Click(object sender, EventArgs e)
        {

        }

        private void enactment_btn_Click(object sender, EventArgs e)
        {
            enactment_page frm = new enactment_page();
            frm.ShowDialog(this);
        }

        private void attshow_Click(object sender, EventArgs e)
        {

        }
    }
}
