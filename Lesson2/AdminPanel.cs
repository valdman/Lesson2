using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    partial class AdminPanel : Form
    {

        private string _name;
        private string _password;

        public AdminPanel(CarService service)
        {
            
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            changeTheLayout();
        }

        private void changeTheLayout()
        {
            adminLayout.Visible = !adminLayout.Visible;
            autorizationLayout.Visible = !autorizationLayout.Visible;
        }

        private void unlogin_Click(object sender, EventArgs e)
        {
            changeTheLayout();
        }
    }
}
