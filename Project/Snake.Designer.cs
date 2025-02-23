namespace Proiect
{
    partial class Snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            this.pictureArena = new System.Windows.Forms.PictureBox();
            this.buttonSart = new System.Windows.Forms.Button();
            this.labelSC2 = new System.Windows.Forms.Label();
            this.labelSc = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.labelPauza = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArena)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureArena
            // 
            this.pictureArena.BackColor = System.Drawing.Color.Transparent;
            this.pictureArena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureArena.Location = new System.Drawing.Point(0, 0);
            this.pictureArena.Name = "pictureArena";
            this.pictureArena.Size = new System.Drawing.Size(800, 450);
            this.pictureArena.TabIndex = 1;
            this.pictureArena.TabStop = false;
            this.pictureArena.Click += new System.EventHandler(this.pictureArena_Click);
            this.pictureArena.Paint += new System.Windows.Forms.PaintEventHandler(this.Design);
            // 
            // buttonSart
            // 
            this.buttonSart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSart.Location = new System.Drawing.Point(12, 84);
            this.buttonSart.Name = "buttonSart";
            this.buttonSart.Size = new System.Drawing.Size(103, 53);
            this.buttonSart.TabIndex = 2;
            this.buttonSart.Text = "Start";
            this.buttonSart.UseVisualStyleBackColor = true;
            this.buttonSart.Click += new System.EventHandler(this.buttonSart_Click);
            // 
            // labelSC2
            // 
            this.labelSC2.AutoSize = true;
            this.labelSC2.BackColor = System.Drawing.Color.Transparent;
            this.labelSC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSC2.ForeColor = System.Drawing.Color.Firebrick;
            this.labelSC2.Location = new System.Drawing.Point(215, 9);
            this.labelSC2.Name = "labelSC2";
            this.labelSC2.Size = new System.Drawing.Size(307, 54);
            this.labelSC2.TabIndex = 4;
            this.labelSC2.Text = "Scor maxim: ";
            // 
            // labelSc
            // 
            this.labelSc.AutoEllipsis = true;
            this.labelSc.AutoSize = true;
            this.labelSc.BackColor = System.Drawing.Color.Transparent;
            this.labelSc.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSc.ForeColor = System.Drawing.Color.Firebrick;
            this.labelSc.Location = new System.Drawing.Point(12, 9);
            this.labelSc.Name = "labelSc";
            this.labelSc.Size = new System.Drawing.Size(151, 54);
            this.labelSc.TabIndex = 5;
            this.labelSc.Text = "Scor: ";
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Location = new System.Drawing.Point(671, 400);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(117, 38);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Autodistugere";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 40;
            this.moveTimer.Tick += new System.EventHandler(this.MoveTimerEvent);
            // 
            // labelPauza
            // 
            this.labelPauza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPauza.AutoSize = true;
            this.labelPauza.BackColor = System.Drawing.Color.Transparent;
            this.labelPauza.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPauza.ForeColor = System.Drawing.Color.Red;
            this.labelPauza.Location = new System.Drawing.Point(306, 191);
            this.labelPauza.Name = "labelPauza";
            this.labelPauza.Size = new System.Drawing.Size(230, 68);
            this.labelPauza.TabIndex = 7;
            this.labelPauza.Text = "PAUZA";
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources.f417ac8f865dfb8f63db9363d8de1684;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPauza);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelSc);
            this.Controls.Add(this.labelSC2);
            this.Controls.Add(this.buttonSart);
            this.Controls.Add(this.pictureArena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Snake";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Snake_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureArena;
        private System.Windows.Forms.Button buttonSart;
        private System.Windows.Forms.Label labelSC2;
        private System.Windows.Forms.Label labelSc;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer moveTimer;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label labelPauza;
    }
}