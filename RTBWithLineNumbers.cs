namespace WASP_huninat.WinForms.CustomControls
{
    public partial class RTBWithLineNumbers : UserControl
    {
        private int _firstLine = 0;

        public RTBWithLineNumbers()
        {
            InitializeComponent();
        }

        private void RTBWithLineNumbers_Load(object sender, EventArgs e)
        {
            splitContainer1.Height = panel1.Height;
            panel1.VerticalScroll.Maximum = Line.Lines.Length * Line.Font.Height;
            panel1.VerticalScroll.SmallChange = Code.Font.Height;
        }

        private void Code_KeyDown(object sender, KeyEventArgs e)
        {
            splitContainer1.Height = panel1.Height + (Code.Lines.Length * Code.Font.Height);

            int fontHeight = Code.Font.Height;

            int currentLine = Code.GetFirstCharIndexOfCurrentLine();
            currentLine = Code.GetLineFromCharIndex(currentLine);

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
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
        }
    }
}