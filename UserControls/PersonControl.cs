using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
        }

        private Person _person;

        public Person Person {
            get
            {
                _person.FirstName = firstName.Text;
                _person.LastName = lastName.Text;
                _person.Age = int.Parse(age.Text);
                return _person;
            }

            set
            {
                firstName.Text = value.FirstName;
                lastName.Text = value.LastName;
                age.Text = value.Age.ToString();
                _person = value; 
            }
        }

        private void PersonControl_Load(object sender, EventArgs e)
        {

        }
    }
}
