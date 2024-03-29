﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;
using System.Drawing.Drawing2D;

namespace SemestralniPrace_JanHolda.RoundedUI
{
    public class RoundedButton : Button
    {
        //Default hodnoty
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.White;

        public int BorderSize { 
            get => borderSize; 
            set { borderSize = value; this.Invalidate();}
        }
        public int BorderRadius { 
            get => borderRadius;
            set {
                if (value <= this.Height)
                    borderRadius = value;
                else borderRadius = this.Height;
                borderRadius = value; 
                this.Invalidate();
            }
        }
        public Color BorderColor { 
            get => borderColor; 
            set { borderColor = value; this.Invalidate();}
        }

        public Color BackgroundColor
        {
            get { return this.BackColor; } 
            set { this.BackColor = value; }
        }
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumAquamarine;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        //Metoda
        //Vytvoření rohů
        private GraphicsPath GetFigurePath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1,1, this.Width - 0.8F, this.Height - 1);

            if(borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    //Větší rozlišení
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    //Control bordel
                    if (borderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                };
            }
            //Normalní Button
            else 
            {
                //Button povrch
                this.Region = new Region(rectBorder);
                //Button border
                if(borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor,borderSize))
                    {
                        penBorder.Alignment= PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width-1, this.Height-1);
                    }
                }
            }
        }
        //Vytvoření Buttonu
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        //Změna pozadí
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if(this.DesignMode)
                this.Invalidate();
        }
        //Změna velikosti
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                BorderRadius = this.Height;
        }
    }
}
