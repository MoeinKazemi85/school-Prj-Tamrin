﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Tamrin
{
    public partial class FrmLessons : Form
    {
        public FrmLessons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddLesson frmAddLesson = new FrmAddLesson();
            frmAddLesson.ShowDialog();
        }
    }
}
