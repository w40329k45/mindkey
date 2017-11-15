using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace mindkeyboard2._0
{
     class Syshelper
    {

        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        public static extern void mouse_event(
            int dwFlags,
            int dx,
            int dy,
            int cButtons,
            int dwExtraInfo
        );
        const int MOUSEEVENTF_MOVE = 0x0001;      //移动鼠标 
        const int MOUSEEVENTF_LEFTDOWN = 0x0002; //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTUP = 0x0004; //模拟鼠标左键抬起 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008; //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTUP = 0x0010; //模拟鼠标右键抬起 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;// 模拟鼠标中键抬起 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000; //标示是否采用绝对坐标


        public void downclick(float attention)
        {
            if (attention >= 50) mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 1, 0);
        }

        public void movemouse(int[] data_b)
        {
            int x = data_b[0] / 100;
            int y = data_b[1] / 100;

            if (x< -3) mouse_event(MOUSEEVENTF_MOVE, -8 * x, 0, 0, 0);
            else if (x > 3) mouse_event(MOUSEEVENTF_MOVE, -8 * x, 0, 0, 0);
            if (y < -3) mouse_event(MOUSEEVENTF_MOVE, 0, 5 * y, 0, 0);
            else if (y > 3) mouse_event(MOUSEEVENTF_MOVE, 0, 5 * y, 0, 0);

        }
    }
}
