﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFromDesigner01
{
    public partial class MyFrom : Form
    {
        public MyFrom()
        {
            InitializeComponent();
        }

        private void ShowMessageButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = MessageTextBox.Text;
        }
    }
}
