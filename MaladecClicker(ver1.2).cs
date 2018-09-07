using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
       
       int i = 5;  
        //form1 = 1 окно 
        public Form1()
        {
            InitializeComponent();
            Counter.Text = "-";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked!!!!");

            if (i <= 0)
            {
                Debug.WriteLine("Nothing to do. Exiting!!!!");
                return;
            }

            i--; // i = число кликов которое остается нажать           
            Counter.Text = i.ToString();    //i переводим в текст 
        }

        private void click_Click(object sender, EventArgs e)
        {
            click.Text = "нажатий";
        }

        private void howm_Click(object sender, EventArgs e)
        {
            howm.Text = "До следующего звания тебе осталось:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/elothewizz");
            vk.Text = "vk dev page";
        }

        private void vkg_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/undevit");
            vkg.Text = "vk dev group";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Counter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Количество кликов которое тебе осталось нажать, до следующего уровня");
            //bckuptest
        }
    }
}
