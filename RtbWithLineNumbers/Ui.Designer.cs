namespace WASP_huninat.WinForms.CustomControls.RtbWithLineNumbers
{
    partial class UI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ScrollPnl = new Panel();
            TxtTbl = new SplitContainer();
            LineRtb = new RichTextBox();
            TextRtb = new RichTextBox();
            ScrollPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtTbl).BeginInit();
            TxtTbl.Panel1.SuspendLayout();
            TxtTbl.Panel2.SuspendLayout();
            TxtTbl.SuspendLayout();
            SuspendLayout();
            // 
            // ScrollPnl
            // 
            ScrollPnl.AutoScroll = true;
            ScrollPnl.Controls.Add(TxtTbl);
            ScrollPnl.Dock = DockStyle.Top;
            ScrollPnl.Location = new Point(0, 0);
            ScrollPnl.Name = "ScrollPnl";
            ScrollPnl.Size = new Size(500, 120);
            ScrollPnl.TabIndex = 0;
            // 
            // TxtTbl
            // 
            TxtTbl.Dock = DockStyle.Top;
            TxtTbl.FixedPanel = FixedPanel.Panel1;
            TxtTbl.IsSplitterFixed = true;
            TxtTbl.Location = new Point(0, 0);
            TxtTbl.Name = "TxtTbl";
            // 
            // TxtTbl.Panel1
            // 
            TxtTbl.Panel1.Controls.Add(LineRtb);
            // 
            // TxtTbl.Panel2
            // 
            TxtTbl.Panel2.Controls.Add(TextRtb);
            TxtTbl.Size = new Size(500, 100);
            TxtTbl.TabIndex = 0;
            // 
            // LineRtb
            // 
            LineRtb.BorderStyle = BorderStyle.None;
            LineRtb.Dock = DockStyle.Fill;
            LineRtb.Location = new Point(0, 0);
            LineRtb.MinimumSize = new Size(50, 0);
            LineRtb.Name = "LineRtb";
            LineRtb.ReadOnly = true;
            LineRtb.ScrollBars = RichTextBoxScrollBars.Horizontal;
            LineRtb.Size = new Size(50, 100);
            LineRtb.TabIndex = 0;
            LineRtb.Text = "";
            LineRtb.WordWrap = false;
            // 
            // TextRtb
            // 
            TextRtb.AcceptsTab = true;
            TextRtb.BorderStyle = BorderStyle.None;
            TextRtb.Dock = DockStyle.Fill;
            TextRtb.Location = new Point(0, 0);
            TextRtb.Name = "TextRtb";
            TextRtb.ScrollBars = RichTextBoxScrollBars.Horizontal;
            TextRtb.Size = new Size(446, 100);
            TextRtb.TabIndex = 0;
            TextRtb.Text = "";
            TextRtb.WordWrap = false;
            TextRtb.TextChanged += TextRtb_TextChanged;
            TextRtb.KeyDown += TextRtb_KeyDown;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ScrollPnl);
            Name = "UI";
            Size = new Size(500, 150);
            SizeChanged += UI_SizeChanged;
            ScrollPnl.ResumeLayout(false);
            TxtTbl.Panel1.ResumeLayout(false);
            TxtTbl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TxtTbl).EndInit();
            TxtTbl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ScrollPnl;
        private SplitContainer TxtTbl;
        private RichTextBox LineRtb;
        private RichTextBox TextRtb;
    }
}