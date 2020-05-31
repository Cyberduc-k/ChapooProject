using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui
{
    public partial class CP_Popup_Sure : CP_Popup_Parent
    {
        public CP_Popup_Sure(int count)
        {
            InitializeComponent();

            CP_Popup_Sure_lblText.Text = "Weet je zeker dat je " + count + " medewerkers van de lijst wilt verwijderen?";
            CP_Popup_Parent_btnOK.Enabled = true;
        }

        public CP_Popup_Sure(string name)
        {
            InitializeComponent();

            CP_Popup_Sure_lblText.Text = "Weet je zeker dat je " + name + " wilt aanpassen?";
            CP_Popup_Parent_btnOK.Enabled = true;
        }

        public override void OnClickCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public override void OnClickOK(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
