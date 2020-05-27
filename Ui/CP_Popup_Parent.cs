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

namespace Ui
{
    public abstract partial class CP_Popup_Parent : Form
    {
        public CP_Popup_Parent()
        {
            InitializeComponent();
        }

        private void CP_Popup_Parent_btnOK_Click(object sender, EventArgs e)
        {
            OnClickOK(sender, e);
        }

        private void CP_Popup_Parent_btnCancel_Click(object sender, EventArgs e)
        {
            OnClickCancel(sender, e);
        }

        public abstract void OnClickOK(object sender, EventArgs e);

        public abstract void OnClickCancel(object sender, EventArgs e);

        public void LoadIcon(string icon)
        {
            try
            {
                Icon = new Icon(icon);
            }
            catch (Exception e)
            {
                ErrorHandler.Instance.HandleError("Het icoon con niet ingeladen worden", "Icoon niet gevonden", e);
            }
        }

        public void UpdateOKbtn(List<bool> vars)
        {
            foreach (bool var in vars)
            {
                if (!var)
                {
                    CP_Popup_Parent_btnOK.Enabled = false;
                    return;
                }
            }

            CP_Popup_Parent_btnOK.Enabled = true;
        }
    }
}
