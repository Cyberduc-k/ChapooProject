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

        public void SetAsRemoveEmployee(int count)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u " + count + " medewerkers wilt verwijderen?";
        }

        public void SetAsRemoveEmployee(string name)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u " + name + " wilt verwijderen?";
        }

        public void SetAsRemoveDish(int count)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u " + count + " gerechten wilt verwijderen?";
        }

        public void SetAsRemoveDish(string name)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u " + name + " wilt verwijderen?";
        }

        public void SetAsRemoveDrink(int count)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u " + count + " dranken wilt verwijderen?";
        }

        public void SetAsRemoveDrink(string name)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u " + name + " wilt verwijderen?";
        }

        public void SetAsEmptyStock(string name)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u de voorraad van " + name + " wilt legen?";
        }

        public void SetAsEmptyStock(int count)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u " + count + " voorraden wilt legen?";
        }
        
        public void SetAsChangeStock(string name)
        {
            CP_Popup_Sure_lblText.Text = "Weet u zeker dat u van " + name + " de voorraad wilt weizigen?";
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
