using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Zametki:Control
    {

        SolidBrush brush = new SolidBrush(Color.DarkSeaGreen);
        public Zametki(Size Size, Point Location, Color color) : this()
        {
            this.Size = Size;
            this.Location = Location;
            this.BackColor = color;
        }

        public Zametki()
        {
           
            this.Paint += Button_Peint;


        }


      

        private void Button_Peint(object sender, System.EventArgs e)
        {
            var draw = this.CreateGraphics();
            draw.FillRectangle(brush, new Rectangle(new Point(0,0),new Size(55,55)));
            

        }


    }
}
