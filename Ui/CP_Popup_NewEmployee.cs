using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace Ui
{
    public partial class CP_Popup_NewEmployee : Form
    {
        public CP_Popup_NewEmployee()
        {
            InitializeComponent();
        }

        private void CP_Popup_NewEmployee_btnOK_Click(object sender, EventArgs e)
        {

        }

        private void CP_PopupNewEmployee_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
