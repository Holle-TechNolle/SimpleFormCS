using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormCS
{
    class SmallForm : Form
    {
        
    }
    class MyForm01 : Form
    {
        private TextBox MessageTextBox;
        private Label MessageLabel;
        private Button ShowMessageButton;
        

        public MyForm01()
        {
            this.Text = "My Form";

            MessageTextBox = new TextBox()
            {
                Location = new Point(25, 25),
                Width = 200                
            };
            this.Controls.Add(MessageTextBox);

            ShowMessageButton = new Button()
            {
                Location = new Point(25, 75),
                Width = 200,
                Text = "Show message"
            };
            this.Controls.Add(ShowMessageButton);
            ShowMessageButton.Click += ShowMessageButton_Click;

            MessageLabel = new Label()
            {
                Location = new Point(25, 125),
                Width = 200,
                Text = "[Label]"
            };
            this.Controls.Add(MessageLabel);
        }

        private void ShowMessageButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = MessageTextBox.Text;
        }
    }
}
