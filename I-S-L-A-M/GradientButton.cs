using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace I_S_L_A_M
{
    [DefaultEvent("Click")]
    public partial class GradientButton : UserControl
    {
        int wh = 20;
        float ang = 45;
        Color Cl0 = Color.DodgerBlue, Cl1 = Color.Tomato;
        Timer t = new Timer();
        string txt = "i'm a Gradient Button";

        public GradientButton()
        {
            DoubleBuffered = true;
            t.Interval = 10;
            t.Start();
            t.Tick += (s, e) => { Angle = Angle % 360 + 1; };
            ForeColor = Color.Black;
        }

        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }
        public string Texty
        {
            get { return txt; }
            set { txt = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }

        public Color Color0
        {
            get { return Cl0; }
            set { Cl0 = value; }
        }
        public Color Color1
        {
            get { return Cl1; }
            set { Cl1 = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle,Cl0,Cl1,ang), gp);
            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
            base.OnPaint(e);
        }
    }
}
