namespace WASP_huninat.WinForms.CustomControls.RtbWithLineNumbers
{
    public partial class UI : UserControl
    {
        public Logic Logic = new Logic();

        public new Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                ScrollPnl.BackColor = Parent.BackColor;
                LineRtb.BackColor = value;
                TextRtb.BackColor = value;
            }
        }

        override public Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                LineRtb.ForeColor = value;
                TextRtb.ForeColor = value;
            }
        }

        override public string Text
        {
            get { return TextRtb.Text; }
            set { TextRtb.Text = value; }
        }

        override public Font Font
        {
            get { return TextRtb.Font; }
            set { base.Font = value; LineRtb.Font = value; TextRtb.Font = value; }
        }

        public UI()
        {
            InitializeComponent();

            Logic.LineRtb = LineRtb;
            Logic.TextRtb = TextRtb;
            Logic.TablePnl = TxtTbl;
            Logic.ScrollPnl = ScrollPnl;

            TxtTbl.Height = this.Height;
            ScrollPnl.Height = this.Height;
        }

        private void TextRtb_KeyDown(object sender, KeyEventArgs e)
        {
            ScrollPnl.VerticalScroll.Value = Logic.ChangeLineOnKeyPress(e);
            ScrollPnl.PerformLayout();
        }

        private void TextRtb_TextChanged(object sender, EventArgs e)
        {
            ScrollPnl.VerticalScroll.Value = Logic.ScrollToCurrentLine();
            ScrollPnl.PerformLayout();
        }

        private void UI_SizeChanged(object sender, EventArgs e)
        {
            SetHeight(this.Height);
            ScrollPnl.VerticalScroll.Value = Logic.ScrollToCurrentLine();
            ScrollPnl.PerformLayout();
        }

        public void SetHeight(int hight)
        {
            ScrollPnl.Height = hight;
            TxtTbl.Height = ScrollPnl.Height;
            ScrollPnl.VerticalScroll.Value = Logic.ScrollToCurrentLine();
            ScrollPnl.PerformLayout();
        }
    }
}
