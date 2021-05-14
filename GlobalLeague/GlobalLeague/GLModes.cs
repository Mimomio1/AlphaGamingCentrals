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
    public partial class GLModes : Form
    {
        public GLModes()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void btm_standings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Standings st = new Standings();
            st.Show();
        }

        private void btn_PracticeM_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameSelection sg = new GameSelection();
            sg.Show();
        }

        private void btn_Tourny_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tournament tmt = new Tournament();
            tmt.Show();
        }
    }
}
