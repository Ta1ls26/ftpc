using System;
using System.Net;
using System.Windows.Forms;

namespace ftpc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ssil1;
            ssil1 = textBox1.Text;
           try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ssil1);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.GetResponse();
                textBox4.Text = @"Подключение возможно";
            }
            catch
            {
                textBox4.Text = @"Проблемы с подключением";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
