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
    public partial class SportsGameSelection : Form
    {
        public SportsGameSelection()
        {
            InitializeComponent();
        }

        private void bck_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameSelection sg = new GameSelection();
            sg.Show();
        }
    }
}
