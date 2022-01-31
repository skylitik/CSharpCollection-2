using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }


        async void button1_Click(object sender, EventArgs e)
        {
            
            for (Opacity = 0; Opacity < 1; Opacity += .02)
            {
                
                await Task.Delay(10);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello cat";
        }
    }

   
}
