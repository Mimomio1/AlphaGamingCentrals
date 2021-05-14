using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalLeague
{
    public partial class Captain : Form
    {
        public Captain()
        {
            InitializeComponent();
        }

        private void Captain_Load(object sender, EventArgs e)
        {

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalLeague gl = new GlobalLeague();
            gl.Show();
        }
    }
}
