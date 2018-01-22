namespace notFlappy
{
    partial class Form1
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
            this.time = new System.Windows.Forms.Timer(this.components);
            this.textScore = new System.Windows.Forms.Label();
            this.textEnd1 = new System.Windows.Forms.Label();
            this.textEnd2 = new System.Windows.Forms.Label();
            this.textStart = new System.Windows.Forms.Label();
            this.timeSlow = new System.Windows.Forms.Timer(this.components);
            this.clouds = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeCheat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Interval = 15;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textScore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textScore.Location = new System.Drawing.Point(12, 577);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(116, 16);
            this.textScore.TabIndex = 4;
            this.textScore.Text = "Current Score: ---";
            // 
            // textEnd1
            // 
            this.textEnd1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEnd1.AutoSize = true;
            this.textEnd1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textEnd1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textEnd1.Location = new System.Drawing.Point(236, 235);
            this.textEnd1.Name = "textEnd1";
            this.textEnd1.Size = new System.Drawing.Size(47, 16);
            this.textEnd1.TabIndex = 5;
            this.textEnd1.Text = "label2";
            this.textEnd1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textEnd2
            // 
            this.textEnd2.AutoSize = true;
            this.textEnd2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textEnd2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textEnd2.Location = new System.Drawing.Point(236, 272);
            this.textEnd2.Name = "textEnd2";
            this.textEnd2.Size = new System.Drawing.Size(47, 16);
            this.textEnd2.TabIndex = 6;
            this.textEnd2.Text = "label3";
            this.textEnd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textStart
            // 
            this.textStart.AutoSize = true;
            this.textStart.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textStart.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textStart.Location = new System.Drawing.Point(98, 484);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(354, 41);
            this.textStart.TabIndex = 7;
            this.textStart.Text = "Press Enter to Start!";
            // 
            // timeSlow
            // 
            this.timeSlow.Tick += new System.EventHandler(this.timeSlow_Tick);
            // 
            // clouds
            // 
            this.clouds.BackColor = System.Drawing.Color.Transparent;
            this.clouds.Image = global::notFlappy.Properties.Resources.sky;
            this.clouds.Location = new System.Drawing.Point(0, -175);
            this.clouds.Name = "clouds";
            this.clouds.Size = new System.Drawing.Size(530, 177);
            this.clouds.TabIndex = 8;
            this.clouds.TabStop = false;
            // 
            // ground
            // 
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.Image = global::notFlappy.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 552);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(530, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::notFlappy.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(305, 382);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(112, 303);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::notFlappy.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(305, -120);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(112, 303);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = global::notFlappy.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(39, 258);
            this.flappyBird.Margin = new System.Windows.Forms.Padding(0);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(77, 66);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(71, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Location = new System.Drawing.Point(71, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            this.label4.UseWaitCursor = true;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(402, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "CTRL+X to Exit";
            // 
            // timeCheat
            // 
            this.timeCheat.Interval = 15;
            this.timeCheat.Tick += new System.EventHandler(this.timeCheat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(530, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textStart);
            this.Controls.Add(this.textEnd2);
            this.Controls.Add(this.textEnd1);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.clouds);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definitely Not Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.clouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Label textEnd1;
        private System.Windows.Forms.Label textEnd2;
        private System.Windows.Forms.Label textStart;
        private System.Windows.Forms.Timer timeSlow;
        private System.Windows.Forms.PictureBox clouds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timeCheat;
    }
}

