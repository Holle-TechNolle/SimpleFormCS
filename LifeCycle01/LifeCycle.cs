using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeCycleNS
{
    public partial class LifeCycle : Form
    {
        public LifeCycle()
        {
            InitializeComponent();
        }

        private void LifeCycle_Load(object sender, EventArgs e)
        {
            ListBox.Items.Add("Oranges");
            ListBox.Items.Add("Grapes");
            ListBox.Items.Add("Bananas");
            ListBox.Items.Add("Peaches");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex >= 0)
            {
               Label.Text = ListBox.Text;
            }
            else MessageBox.Show("Make a selection first, Dunce", "Asshole", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void LifeCycle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult.No == MessageBox.Show("Are you sure?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                e.Cancel = true;
            }
        }
    }
}
