using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SemestralniPrace_JanHolda.RoundedUI
{
    public class RoundedPanel : Panel
    {
        //Hodnoty pro Ohraniceni
        private int borderRadius = 15;
        
        //Constructor
        public RoundedPanel()
        {
            this.Size = new Size(150, 40);
        }
        //Vlastnosti
        public int BorderRadius 
        { 
            get => borderRadius; 
            set{ borderRadius = value; this.Invalidate();} 
        }
        //Metoda
        private GraphicsPath GetPath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius,radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }
        //Override Metody
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF rectangleF = new RectangleF(0,0, this.Width, this.Height);
            if(borderRadius>2)
            {
                using(GraphicsPath graphicPath = GetPath(rectangleF, borderRadius))
                using(Pen pen = new Pen(this.Parent.BackColor,2))
                {
                    this.Region = new Region(graphicPath);
                    e.Graphics.DrawPath(pen, graphicPath);
                }
            }
            else this.Region = new Region(rectangleF);
        }
    }
}
