namespace RGB
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            trbR = new TrackBar();
            trbG = new TrackBar();
            trbB = new TrackBar();
            tbR = new TextBox();
            tbG = new TextBox();
            tbB = new TextBox();
            btCopyRGB = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tsl1 = new ToolStripStatusLabel();
            lbA = new Label();
            tbA = new TextBox();
            trbA = new TrackBar();
            rbIsA = new RadioButton();
            cbRaz = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbB).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbA).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 169);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // trbR
            // 
            trbR.Location = new Point(161, 12);
            trbR.Maximum = 255;
            trbR.Name = "trbR";
            trbR.Size = new Size(225, 45);
            trbR.TabIndex = 1;
            trbR.TickStyle = TickStyle.None;
            trbR.Scroll += trbR_Scroll;
            // 
            // trbG
            // 
            trbG.Location = new Point(161, 46);
            trbG.Maximum = 255;
            trbG.Name = "trbG";
            trbG.Size = new Size(225, 45);
            trbG.TabIndex = 2;
            trbG.TickStyle = TickStyle.None;
            trbG.Scroll += trbR_Scroll;
            // 
            // trbB
            // 
            trbB.Location = new Point(161, 81);
            trbB.Maximum = 255;
            trbB.Name = "trbB";
            trbB.Size = new Size(225, 45);
            trbB.TabIndex = 3;
            trbB.TickStyle = TickStyle.None;
            trbB.Scroll += trbR_Scroll;
            // 
            // tbR
            // 
            tbR.Location = new Point(392, 12);
            tbR.Name = "tbR";
            tbR.Size = new Size(71, 23);
            tbR.TabIndex = 4;
            // 
            // tbG
            // 
            tbG.Location = new Point(392, 46);
            tbG.Name = "tbG";
            tbG.Size = new Size(71, 23);
            tbG.TabIndex = 5;
            // 
            // tbB
            // 
            tbB.Location = new Point(392, 81);
            tbB.Name = "tbB";
            tbB.Size = new Size(71, 23);
            tbB.TabIndex = 6;
            // 
            // btCopyRGB
            // 
            btCopyRGB.Location = new Point(392, 188);
            btCopyRGB.Name = "btCopyRGB";
            btCopyRGB.Size = new Size(100, 23);
            btCopyRGB.TabIndex = 7;
            btCopyRGB.Text = "Копировать";
            toolTip1.SetToolTip(btCopyRGB, "Копировать RGB значение в буфер обмена");
            btCopyRGB.UseCompatibleTextRendering = true;
            btCopyRGB.UseVisualStyleBackColor = true;
            btCopyRGB.Click += btCopyRGB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(470, 14);
            label1.Name = "label1";
            label1.Size = new Size(20, 21);
            label1.TabIndex = 8;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 192, 0);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(469, 47);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 9;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(470, 82);
            label3.Name = "label3";
            label3.Size = new Size(20, 21);
            label3.TabIndex = 10;
            label3.Text = "B";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Копировать RGB в буфер обмена";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, tsl1 });
            statusStrip1.Location = new Point(0, 214);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(498, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.LinkColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // tsl1
            // 
            tsl1.BackColor = Color.White;
            tsl1.LinkColor = Color.White;
            tsl1.Name = "tsl1";
            tsl1.Size = new Size(0, 17);
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.BackColor = Color.White;
            lbA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbA.ForeColor = Color.RosyBrown;
            lbA.Location = new Point(470, 118);
            lbA.Name = "lbA";
            lbA.Size = new Size(21, 21);
            lbA.TabIndex = 14;
            lbA.Text = "A";
            // 
            // tbA
            // 
            tbA.Location = new Point(392, 117);
            tbA.Name = "tbA";
            tbA.Size = new Size(71, 23);
            tbA.TabIndex = 13;
            // 
            // trbA
            // 
            trbA.Location = new Point(161, 117);
            trbA.Maximum = 255;
            trbA.Name = "trbA";
            trbA.Size = new Size(225, 45);
            trbA.TabIndex = 12;
            trbA.TickStyle = TickStyle.None;
            trbA.Scroll += trbR_Scroll;
            // 
            // rbIsA
            // 
            rbIsA.AutoSize = true;
            rbIsA.Location = new Point(168, 143);
            rbIsA.Name = "rbIsA";
            rbIsA.Size = new Size(174, 19);
            rbIsA.TabIndex = 15;
            rbIsA.TabStop = true;
            rbIsA.Text = "Учитывать прозрачность А";
            rbIsA.UseVisualStyleBackColor = true;
            // 
            // cbRaz
            // 
            cbRaz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbRaz.FormattingEnabled = true;
            cbRaz.Items.AddRange(new object[] { ";", ",", ":" });
            cbRaz.Location = new Point(352, 182);
            cbRaz.Name = "cbRaz";
            cbRaz.Size = new Size(34, 29);
            cbRaz.TabIndex = 16;
            cbRaz.Text = ";";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 191);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 17;
            label4.Text = "Разделитель";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 220, 211);
            ClientSize = new Size(498, 236);
            Controls.Add(label4);
            Controls.Add(cbRaz);
            Controls.Add(rbIsA);
            Controls.Add(lbA);
            Controls.Add(tbA);
            Controls.Add(trbA);
            Controls.Add(statusStrip1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCopyRGB);
            Controls.Add(tbB);
            Controls.Add(tbG);
            Controls.Add(tbR);
            Controls.Add(trbB);
            Controls.Add(trbG);
            Controls.Add(trbR);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "RGB VS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbR).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbG).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbB).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TrackBar trbR;
        private TrackBar trbG;
        private TrackBar trbB;
        private TextBox tbR;
        private TextBox tbG;
        private TextBox tbB;
        private Button btCopyRGB;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tsl1;
        private Label lbA;
        private TextBox tbA;
        private TrackBar trbA;
        private RadioButton rbIsA;
        private ComboBox cbRaz;
        private Label label4;
    }
}
