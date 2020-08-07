using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HELPER
{
    public class Movimento
    {
        private Form Frm;
        private bool Segurando;
        private Point Ponto;
        public Movimento(Form Frm)
        {
            this.Frm = Frm;
        }
        public void DarMovimento(Control control)
        {
            control.MouseMove += new MouseEventHandler(MouseMove);
            control.MouseUp += new MouseEventHandler(MouseUp);
            control.MouseDown += new MouseEventHandler(MouseDown);
        }
        public void DarMovimento()
        {
            Frm.MouseMove += new MouseEventHandler(MouseMove);
            Frm.MouseUp += new MouseEventHandler(MouseUp);
            Frm.MouseDown += new MouseEventHandler(MouseDown);
        }
        private void MouseUp(object sender, MouseEventArgs e)
        {
            Segurando = false;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Segurando = true;
                Ponto = new Point(e.X, e.Y);
            }
            else
            {
                Segurando = false;
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            Point OutroPonto;
            if (Segurando)
            {
                OutroPonto = Frm.PointToScreen(new Point(e.X, e.Y));
                OutroPonto.Offset(-Ponto.X, -Ponto.Y);
                Frm.Location = OutroPonto;
            }
        }

    }

}
