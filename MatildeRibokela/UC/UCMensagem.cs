using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatildeRibokela.UC
{
    public partial class UCMessage : UserControl
    {
        public UCMessage()
        {
            InitializeComponent();
        }

        public void SetMessage(string mensagem, bool success)
        {
            Message.Text = mensagem;

            if (success)
            {
                Message.ForeColor = panel1.BackColor = Color.FromArgb(118, 177, 98);
                BackColor = Color.FromArgb(243, 250, 240);
            }
            else
            {
                Message.ForeColor = panel1.BackColor = Color.FromArgb(223, 50, 56);
                BackColor = Color.FromArgb(252, 234, 234);
            }
        }
    }
}
