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
    public partial class GlobalLeague : Form
    {
        public GlobalLeague()
        {
            InitializeComponent();
        }

        private void Captain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Captain cp = new Captain();
            cp.Show();
        }

        private void Player_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player pl = new Player();
            pl.Show();
        }
    }
}
