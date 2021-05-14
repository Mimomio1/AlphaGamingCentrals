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
    public partial class GameSelection : Form
    {
        public GameSelection()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void btn_ShootingG_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShootingGamingSelection shg = new ShootingGamingSelection();
            shg.Show();
        }

        private void btn_Sports_Click(object sender, EventArgs e)
        {
            this.Hide();
            SportsGameSelection sgs = new SportsGameSelection();
            sgs.Show();
        }

        private void btn_Fighting_Click(object sender, EventArgs e)
        {
            this.Hide();
            FightingGameSelection fg = new FightingGameSelection();
            fg.Show();
        }
    }
}
