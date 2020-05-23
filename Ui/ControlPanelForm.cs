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
    public partial class ControlPanelForm : Form
    {
        public ControlPanelForm()
        {
            InitializeComponent();
        }

        private void CP_btnHome_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnHome);
        }

        private void CP_btnVoorraad_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnVoorraad);
        }

        private void CP_btnMenukaarten_Click(object sender, EventArgs e)
        {
            SetHightlight(CP_btnMenukaarten);
        }

        //Method to highlight a button
        private void SetHightlight(Button btn)
        {
            CP_btnHome.BackColor = Color.FromArgb(0, 165, 229);
            CP_btnMenukaarten.BackColor = Color.FromArgb(0, 165, 229);
            CP_btnVoorraad.BackColor = Color.FromArgb(0, 165, 229);

            btn.BackColor = Color.FromArgb(0, 184, 255);
        }
    }
}
