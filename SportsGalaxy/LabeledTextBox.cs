using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsGalaxy
{
    public partial class LabeledTextBox : UserControl
    {
        public LabeledTextBox()
        {
            InitializeComponent();

            this.Height = textBox1.Bottom + 5;
        }

        //Expose the TextBox's Text property
        [Category("Custom Properties")]
        [Description("The text displayed in the label above the text box.")]
        public string LabelText
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        //Expose the TextBox's Text property
        [Category("Custom Properties")]
        public Color labelColor
        {
            get => label1.ForeColor;
            set => label1.ForeColor = value;
        }

        [Category("Custom Properties")]
        [Description("The text typed inside the entry field.")]
        public override string Text
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        [Category("Custom Events")]
        public event EventHandler TextChangedEvent
        {
            add => textBox1.TextChanged += value;
            remove => textBox1.TextChanged -= value;
        }
    }
}
