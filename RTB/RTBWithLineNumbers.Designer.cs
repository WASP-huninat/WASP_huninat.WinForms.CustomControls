namespace WASP_huninat.WinForms.CustomControls.Test
{
    partial class RTBWithLineNumbers
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
            splitContainer1 = new SplitContainer();
            Line = new RichTextBox();
            Code = new RichTextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ControlDark;
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Line);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Code);
            splitContainer1.Size = new Size(500, 100);
            splitContainer1.TabIndex = 0;
            splitContainer1.TabStop = false;
            // 
            // Line
            // 
            Line.BackColor = SystemColors.Control;
            Line.BorderStyle = BorderStyle.None;
            Line.Dock = DockStyle.Fill;
            Line.Location = new Point(0, 0);
            Line.Name = "Line";
            Line.ReadOnly = true;
            Line.ScrollBars = RichTextBoxScrollBars.None;
            Line.Size = new Size(50, 100);
            Line.TabIndex = 0;
            Line.Text = "0";
            // 
            // Code
            // 
            Code.BackColor = SystemColors.Control;
            Code.BorderStyle = BorderStyle.None;
            Code.Dock = DockStyle.Fill;
            Code.Location = new Point(0, 0);
            Code.Name = "Code";
            Code.ScrollBars = RichTextBoxScrollBars.None;
            Code.Size = new Size(446, 100);
            Code.TabIndex = 0;
            Code.Text = "";
            Code.WordWrap = false;
            Code.KeyDown += Code_KeyDown;
            Code.KeyUp += Code_KeyUp;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 120);
            panel1.TabIndex = 2;
            // 
            // RTBWithLineNumbers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel1);
            Name = "RTBWithLineNumbers";
            Size = new Size(500, 150);
            Load += RTBWithLineNumbers_Load;
            SizeChanged += RTBWithLineNumbers_SizeChanged;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private RichTextBox Line;
        private RichTextBox Code;
        private Panel panel1;
    }
}
