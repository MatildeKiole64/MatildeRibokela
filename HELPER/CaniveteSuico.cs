using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.UI.WinForms;


namespace HELPER
{
    public static class CaniveteSuico
    {
        public static void LimparTudo(this Control c)
        {
            foreach (Control control in c.Controls)
            {
                if (control is SiticoneTextBox)
                {
                    SiticoneTextBox txt = (SiticoneTextBox)control;
                    txt.Clear();
                }
                if (control is ListView)
                {
                    var lvw = (ListView)control;
                    lvw.Items.Clear();
                }
                Limpar(control);
            }
        }

        public static void Limpar(this Control c)
        {
            foreach (Control control in c.Controls)
            {
                if (control is SiticoneTextBox)
                {
                    SiticoneTextBox txt = (SiticoneTextBox)control;
                    txt.Clear();
                }
            }
        }

        public static void Centralizar(this Control control, Control parent) 
        {
            int x = control.Width / 2 - parent.Width / 2;
            int y = control.Height / 2 - parent.Height / 2;
            parent.Location = new Point(x, y);
        }
    }
}
