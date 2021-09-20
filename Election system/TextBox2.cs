using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_system
{
    class TextBox2 : UserControl
    {
        // The TextBox
        private TextBox textBox = new TextBox();

        // Border color of the textbox
        private Color borderColor = Color.Gray;

        // Ctor
        public TextBox2()
        {
            this.Paint += new PaintEventHandler(TextBoxEx_Paint);
            this.Resize += new EventHandler(TextBoxEx_Resize);
            textBox.Multiline = false;
            textBox.BorderStyle = BorderStyle.None;
            this.Controls.Add(textBox);

            InvalidateSize();
        }

        // Exposed properties of the textbox
        public override string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
        // ... Expose other properties you need...

        // The border color property
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        // Expose the Click event for the texbox
        public event EventHandler TextBoxClick
        {
            add { textBox.Click += value; }
            remove { textBox.Click -= value; }
        }
        // ... Expose other events you need...

        private void TextBoxEx_Resize(object sender, EventArgs e)
        {
            InvalidateSize();
        }
        private void TextBoxEx_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
        }
        private void InvalidateSize()
        {
            textBox.Size = new Size(this.Width - 2, this.Height - 2);
            textBox.Location = new Point(1, 1);
        }
    }
}
