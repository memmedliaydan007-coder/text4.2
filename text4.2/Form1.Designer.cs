namespace text4._2
{
    partial class QeydlerDefteri
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            rtbMetn = new RichTextBox();
            statusStrip1 = new StatusStrip();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            mnFayl = new ToolStripMenuItem();
            mnFormat = new ToolStripMenuItem();
            mnYeni = new ToolStripMenuItem();
            mnAc = new ToolStripMenuItem();
            mnSaxla = new ToolStripMenuItem();
            mnCixis = new ToolStripMenuItem();
            mnFont = new ToolStripMenuItem();
            mnReng = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnFayl, mnFormat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // rtbMetn
            // 
            rtbMetn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbMetn.Location = new Point(12, 27);
            rtbMetn.Name = "rtbMetn";
            rtbMetn.Size = new Size(776, 315);
            rtbMetn.TabIndex = 1;
            rtbMetn.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // mnFayl
            // 
            mnFayl.DropDownItems.AddRange(new ToolStripItem[] { mnYeni, mnAc, mnSaxla, mnCixis });
            mnFayl.Name = "mnFayl";
            mnFayl.Size = new Size(40, 20);
            mnFayl.Text = "Fayl";
            // 
            // mnFormat
            // 
            mnFormat.DropDownItems.AddRange(new ToolStripItem[] { mnFont, mnReng });
            mnFormat.Name = "mnFormat";
            mnFormat.Size = new Size(57, 20);
            mnFormat.Text = "Format";
            // 
            // mnYeni
            // 
            mnYeni.Name = "mnYeni";
            mnYeni.Size = new Size(180, 22);
            mnYeni.Text = "Yeni";
            // 
            // mnAc
            // 
            mnAc.Name = "mnAc";
            mnAc.Size = new Size(180, 22);
            mnAc.Text = "Aç";
            // 
            // mnSaxla
            // 
            mnSaxla.Name = "mnSaxla";
            mnSaxla.Size = new Size(180, 22);
            mnSaxla.Text = "Saxla";
            // 
            // mnCixis
            // 
            mnCixis.Name = "mnCixis";
            mnCixis.Size = new Size(180, 22);
            mnCixis.Text = "Çıxış";
            // 
            // mnFont
            // 
            mnFont.Name = "mnFont";
            mnFont.Size = new Size(180, 22);
            mnFont.Text = "Şrift";
            // 
            // mnReng
            // 
            mnReng.Name = "mnReng";
            mnReng.Size = new Size(180, 22);
            mnReng.Text = "Rəng";
            // 
            // QeydlerDefteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(rtbMetn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QeydlerDefteri";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private RichTextBox rtbMetn;
        private StatusStrip statusStrip1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem mnFayl;
        private ToolStripMenuItem mnYeni;
        private ToolStripMenuItem mnAc;
        private ToolStripMenuItem mnSaxla;
        private ToolStripMenuItem mnCixis;
        private ToolStripMenuItem mnFormat;
        private ToolStripMenuItem mnFont;
        private ToolStripMenuItem mnReng;
    }
}
