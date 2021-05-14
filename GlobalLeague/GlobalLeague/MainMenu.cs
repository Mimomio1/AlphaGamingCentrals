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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile pf = new Profile();
            pf.Show();
        }

        private void btn_GLModes_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLModes gl = new GLModes();
            gl.Show();
        }

        private void btn_SelectGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameSelection gs = new GameSelection();
            gs.Show();
        }

        private void btn_TeamBuilder_Click(object sender, EventArgs e)
        {
            this.Hide();
            lbl_TeamBuilder tb = new lbl_TeamBuilder();
            tb.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalLeague gl = new GlobalLeague();
            gl.Show();
        }
    }
}
