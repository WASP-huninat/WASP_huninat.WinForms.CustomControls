namespace WASP_huninat.WinForms.CustomControls.RtbWithLineNumbers
{
    public class Logic
    {
        public RichTextBox LineRtb { get; set; }
        public RichTextBox TextRtb { get; set; }
        public SplitContainer TablePnl { get; set; }
        public Panel ScrollPnl { get; set; }
        public Font RtbFont { get; set; }

        public int ScrollToCurrentLine()
        {
            int currentLineCount = TextRtb.Lines.Length;
            int fontHeight = TextRtb.Font.Height;
            
            TablePnl.Height = ScrollPnl.Height + (fontHeight * currentLineCount);

            int currentLine = TextRtb.GetFirstCharIndexOfCurrentLine();
            currentLine = TextRtb.GetLineFromCharIndex(currentLine);
            currentLine *= fontHeight;

            LineRtb.Text = "0";
            for (int i = 1; i < currentLineCount; i++)
            {
                LineRtb.AppendText(Environment.NewLine + i.ToString());
            }

            if (currentLine > ScrollPnl.VerticalScroll.Maximum)
            {
                return 0;
            }

            return currentLine;
        }

        public int ChangeLineOnKeyPress(KeyEventArgs e)
        {
            int fontHeight = TextRtb.Font.Height;
            int scrollValue = ScrollPnl.VerticalScroll.Value;

            if (e.KeyData == Keys.Up && scrollValue != 0)
            {
                return scrollValue - fontHeight;
            }
            if (e.KeyData == Keys.Down && scrollValue != TablePnl.Height - ScrollPnl.Height - fontHeight)
            {
                return scrollValue + fontHeight;
            }
            return scrollValue;
        }
    }
}
