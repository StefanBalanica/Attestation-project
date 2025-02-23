namespace Proiect
{
    partial class Pong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Jucator1 = new System.Windows.Forms.PictureBox();
            this.labelScor1 = new System.Windows.Forms.Label();
            this.labelScor2 = new System.Windows.Forms.Label();
            this.LinieCentru = new System.Windows.Forms.PictureBox();
            this.Minge = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.Jucator2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelScor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Jucator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinieCentru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jucator2)).BeginInit();
            this.SuspendLayout();
            // 
            // Jucator1
            // 
            this.Jucator1.BackColor = System.Drawing.Color.Red;
            this.Jucator1.Location = new System.Drawing.Point(12, 146);
            this.Jucator1.Name = "Jucator1";
            this.Jucator1.Size = new System.Drawing.Size(31, 177);
            this.Jucator1.TabIndex = 1;
            this.Jucator1.TabStop = false;
            // 
            // labelScor1
            // 
            this.labelScor1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelScor1.AutoSize = true;
            this.labelScor1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScor1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScor1.Location = new System.Drawing.Point(234, 9);
            this.labelScor1.Name = "labelScor1";
            this.labelScor1.Size = new System.Drawing.Size(59, 68);
            this.labelScor1.TabIndex = 6;
            this.labelScor1.Text = "0";
            this.labelScor1.Click += new System.EventHandler(this.labelScor1_Click);
            // 
            // labelScor2
            // 
            this.labelScor2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelScor2.AutoSize = true;
            this.labelScor2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScor2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScor2.Location = new System.Drawing.Point(523, 9);
            this.labelScor2.Name = "labelScor2";
            this.labelScor2.Size = new System.Drawing.Size(59, 68);
            this.labelScor2.TabIndex = 7;
            this.labelScor2.Text = "0";
            // 
            // LinieCentru
            // 
            this.LinieCentru.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LinieCentru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinieCentru.Location = new System.Drawing.Point(409, 1);
            this.LinieCentru.Name = "LinieCentru";
            this.LinieCentru.Size = new System.Drawing.Size(10, 449);
            this.LinieCentru.TabIndex = 8;
            this.LinieCentru.TabStop = false;
            // 
            // Minge
            // 
            this.Minge.BackColor = System.Drawing.Color.Transparent;
            this.Minge.Image = global::Proiect.Properties.Resources.final2;
            this.Minge.Location = new System.Drawing.Point(341, 199);
            this.Minge.Name = "Minge";
            this.Minge.Size = new System.Drawing.Size(50, 50);
            this.Minge.TabIndex = 9;
            this.Minge.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(355, 333);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 47);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Restart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Jucator2
            // 
            this.Jucator2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Jucator2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Jucator2.Location = new System.Drawing.Point(757, 146);
            this.Jucator2.Name = "Jucator2";
            this.Jucator2.Size = new System.Drawing.Size(31, 177);
            this.Jucator2.TabIndex = 11;
            this.Jucator2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.TImerJoc);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStop.Location = new System.Drawing.Point(331, 386);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(163, 52);
            this.buttonStop.TabIndex = 12;
            this.buttonStop.Text = "Autodistrugere";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelScor
            // 
            this.labelScor.AutoSize = true;
            this.labelScor.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelScor.Location = new System.Drawing.Point(338, 19);
            this.labelScor.Name = "labelScor";
            this.labelScor.Size = new System.Drawing.Size(156, 45);
            this.labelScor.TabIndex = 13;
            this.labelScor.Text = "PAUZA";
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelScor);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.Jucator2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.Minge);
            this.Controls.Add(this.LinieCentru);
            this.Controls.Add(this.labelScor2);
            this.Controls.Add(this.labelScor1);
            this.Controls.Add(this.Jucator1);
            this.Name = "Pong";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Jucator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinieCentru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jucator2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Jucator1;
        private System.Windows.Forms.Label labelScor1;
        private System.Windows.Forms.Label labelScor2;
        private System.Windows.Forms.PictureBox LinieCentru;
        private System.Windows.Forms.PictureBox Minge;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox Jucator2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelScor;
    }
}