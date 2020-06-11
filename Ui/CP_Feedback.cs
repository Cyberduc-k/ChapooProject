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
    public partial class CP_Feedback : Form
    {
        public CP_Feedback(string message, int delay)
        {
            //Show the green feedback form placed on the center top of the parent form
            InitializeComponent();
            Left = 336;
            Top = 40;

            CP_Feedback_lblMessage.Text = message;
            Task.Delay(delay).ContinueWith(t => CloseAfterDelay());
        }

        //Code taken from https://stackoverflow.com/questions/10775367/cross-thread-operation-not-valid-control-textbox1-accessed-from-a-thread-othe
        //Used becuase otherwise Closing the form isn't posible form the task thread
        delegate void CloseAfterDelayCallback();

        public void CloseAfterDelay()
        {
            if(InvokeRequired)
            {
                CloseAfterDelayCallback callback = new CloseAfterDelayCallback(CloseAfterDelay);
                Invoke(callback);
            }
            else
                Close();
        }
    }
}
