using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;


namespace MELTADO_CAFE.Controls
{
    //public class ToggleBtn: CheckBox
    //{

    //    /// Fields
    //    private Color onBackColor = Color.MediumSlateBlue;
    //    private Color onTogglecolor = Color.WhiteSmoke;
    //    private Color offBackColor = Color.Gray;
    //    private Color offToggleColor = Color.Gainsboro;
    //    private bool solidStyle = true;
    //    public Color OnBackColor
    //    {
    //        get
    //        {
    //            return onBackColor;
    //        }
    //        set
    //        {
    //            onBackColor = value;
    //            this.Invalidate();
    //        }
    //    }
    //    public Color OnTogglecolor
    //    {
    //        get
    //        {
    //            return OnTogglecolor;
    //        }
    //        set
    //        {
    //            OnTogglecolor = value;
    //            this.Invalidate();
    //        }
    //    }

    //    public Color OffBackColor
    //    {
    //        get
    //        {
    //            return OffBackColor;
    //        }
    //        set
    //        {
    //            OffBackColor = value;
    //            this.Invalidate();
    //        }
    //    }

    //    public Color OffToggleColor
    //    {
    //        get
    //        {
    //            return OffToggleColor;
    //        }
    //        set
    //        {
    //            OffToggleColor = value;
    //            this.Invalidate();
    //        }
    //    }

    //    public override string Text 
    //    {
    //        get
    //        {
    //            return base.Text;
    //        }
    //        set
    //        {

    //        }
    //    }
    //    [DefaultValue(true)]
    //    public bool SolidStyle
    //    {
    //        get
    //        {
    //            return solidStyle;
    //        }
    //        set
    //        {
    //            solidStyle = value;
    //            this.Invalidate();
    //        }
    //    }


    //    //constructor
    //    public ToggleBtn()
    //    {
    //        this.MinimumSize = new Size(45, 22);

    //    }

    //    //Methods
    //    private GraphicsPath GetGraphicsPath()
    //    {
    //        int arcSize = this.Height - 1;
    //        Rectangle leftarc = new Rectangle(0, 0, arcSize, arcSize);
    //        Rectangle rightarc = new Rectangle(this.Width - arcSize, 0, arcSize, arcSize);

    //        GraphicsPath path = new GraphicsPath();
    //        path.StartFigure();
    //        path.AddArc(leftarc, 90, 180);
    //        path.AddArc(rightarc, 270, 180);
    //        path.CloseFigure();

    //        return path;
    //    }
    //    protected override void OnPaint(PaintEventArgs pevent)
    //    {
    //        int toggleSize = this.Height - 5;
    //        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
    //        pevent.Graphics.Clear(this.Parent.BackColor);
    //        if(this.Checked)
    //        {
    //            if(solidStyle)
    //            pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetGraphicsPath());
    //            else pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetGraphicsPath());
    //            pevent.Graphics.FillEllipse(new SolidBrush(onTogglecolor),
    //                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
    //        }else
    //        {
    //            if(solidStyle)
    //                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetGraphicsPath());
    //            else pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetGraphicsPath());
    //            pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetGraphicsPath());
    //            pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
    //                new Rectangle(2, 2, toggleSize, toggleSize));
    //        }
    //    }
    //}


    public class ToggleBtn : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        public Color OnBackColor
        {
            get => onBackColor;
            set { onBackColor = value; this.Invalidate(); }
        }

        public Color OnToggleColor
        {
            get => onToggleColor;
            set { onToggleColor = value; this.Invalidate(); }
        }

        public Color OffBackColor
        {
            get => offBackColor;
            set { offBackColor = value; this.Invalidate(); }
        }

        public Color OffToggleColor
        {
            get => offToggleColor;
            set { offToggleColor = value; this.Invalidate(); }
        }

        public override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        [DefaultValue(true)]
        public bool SolidStyle
        {
            get => solidStyle;
            set { solidStyle = value; this.Invalidate(); }
        }

        public ToggleBtn()
        {
            this.MinimumSize = new Size(45, 22);
        }

        private GraphicsPath GetGraphicsPath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)
            {
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetGraphicsPath());
                else
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetGraphicsPath());

                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetGraphicsPath());
                else
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetGraphicsPath());

                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }

}
