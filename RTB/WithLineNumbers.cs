using System.ComponentModel;
using System.Text;

namespace WASP_huninat.WinForms.CustomControls.RTB
{
    [ToolboxItem(true)]
    [ToolboxItemFilter("Custom Controls")]
    [Description("A custom RTB with LineNumbers")]
    public partial class WithLineNumbers : UserControl
    {
        #region UI Properties
        public new Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                Line.BackColor = value;
                Code.BackColor = value;
            }
        }

        override public Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                Line.ForeColor = value;
                Code.ForeColor = value;
            }
        }

        public Color SplitColor
        {
            get { return splitContainer1.BackColor; }
            set
            {
                splitContainer1.BackColor = value;
            }
        }

        public RichTextBox RTB
        {
            get { return Code; }
            set { Code = value; }
        }

        override public Font Font
        {
            get { return Code.Font; }
            set
            {
                base.Font = value;
                Line.Font = value;
                Code.Font = value;                    
            }
        }
        #endregion

        public WithLineNumbers()
        {
            InitializeComponent();
        }

        private void ScrollToCurrentLine(Keys key)
        {
            splitContainer1.Height = panel1.Height + Code.Lines.Length * Code.Font.Height;

            int fontHeight = Code.Font.Height;

            int currentLine = Code.GetFirstCharIndexOfCurrentLine();
            currentLine = Code.GetLineFromCharIndex(currentLine);

            if (key == Keys.Enter || key == Keys.Down)
            {
                currentLine -= (panel1.Height - fontHeight) / fontHeight;
            }
            else
            {
                currentLine -= panel1.Height / fontHeight;
            }

            currentLine *= fontHeight;
            currentLine += Code.Margin.All * 2;

            if (currentLine >= 0)
            {
                panel1.VerticalScroll.Value = currentLine;
                panel1.PerformLayout();
            }
            UpdateLineNumbers();
        }

        private void UpdateLineNumbers()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("0");
            for (int i = 1; i < Code.Lines.Length; i++)
            {
                sb.Append(Environment.NewLine + i);
            }

            Line.Text = sb.ToString();

            Line.Invalidate();
        }

        private void RTBWithLineNumbers_Load(object sender, EventArgs e)
        {
            splitContainer1.Height = panel1.Height;
            panel1.VerticalScroll.Maximum = Line.Lines.Length * Line.Font.Height;
            panel1.VerticalScroll.SmallChange = Code.Font.Height;
        }

        private void Code_KeyDown(object sender, KeyEventArgs e)
        {
            ScrollToCurrentLine(e.KeyCode);
        }

        private void RTBWithLineNumbers_SizeChanged(object sender, EventArgs e)
        {
            panel1.Height = this.Height;
            ScrollToCurrentLine(Keys.A);
        }

        private void Code_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateLineNumbers();
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {
            UpdateLineNumbers();
        }
    }
}