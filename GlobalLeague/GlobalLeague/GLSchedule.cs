﻿using System;
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
    public partial class GLSchedule : Form
    {
        public GLSchedule()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GLModes glm = new GLModes();
            glm.Show();
        }
    }
}
