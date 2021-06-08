using System;
using System.Drawing;
using System.Windows.Forms;
    
namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80; 
                return cp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
            this.TransparencyKey = Color.Gold;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
