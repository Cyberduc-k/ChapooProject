using System;
using System.Windows.Forms;

namespace Ui
{
    public partial class CP_Popup_Sure : CP_Popup_Parent
    {
        public CP_Popup_Sure()
        {
            InitializeComponent();

            CP_Popup_Parent_btnOK.Enabled = true;
        }

        public void SetAsRemove(int count)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u " + count + " medewerkers wilt verwijderen?";
        }

        public void SetAsRemove(string name)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u " + name + " wilt verwijderen?";
        }

        public void SetAsEdit(string name)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u " + name + " wilt aanpassen?";
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
