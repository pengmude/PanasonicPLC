using Pansonic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansonicPLC_Test
{
    public partial class FormReadCode : Form
    {
        PanasonicPLC PLC = new PanasonicPLC();
        bool IsConnect = false;
        public FormReadCode()
        {
            InitializeComponent();
        }

        private void FormReadCode_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        bool ConnectPLC(string com)
        {
            PLC.MewtocolSet(com, 115200, 8, 1, Parity.Odd);    //设置串口参数
                                                                  // PLC.MewtocolClose();                                //先关闭相应串口
            bool s = PLC.MewtocolOpen();                            //再打开PLC串口通讯
            if (s)
            {
                MessageBox.Show("连接成功!");
                device_plc_status.Text = "PLC已连接";
                return true;
            }
            else
            {
                MessageBox.Show("连接失败!");
                device_plc_status.Text = "PLC连接失败";
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                short[] res = PLC.ReadWordsPoint(txb_len.Text, int.Parse(txb_len.Text));
                txb_result.Text = ShortArrayToString(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string ShortArrayToString(short[] shortArray)
        {
            StringBuilder sb = new StringBuilder();
            foreach (short value in shortArray)
            {
                // 确保short值在ASCII范围内（0-255）
                if (value >= 0 && value <= 255)
                {
                    char charValue = (char)value;
                    sb.Append(charValue);
                }
                else
                {
                    throw new Exception("非ASCll编码字符");  // 抛出异常
                }
            }
            return sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsConnect = ConnectPLC(comboBox1.Text);
        }
    }
}
