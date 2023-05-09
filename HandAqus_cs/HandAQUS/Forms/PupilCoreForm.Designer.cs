namespace HandAQUS.Forms
{
    partial class PupilCoreForm
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
            this.btnCallibrate = new System.Windows.Forms.Button();
            this.LblForButtons = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.btnSTART = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallibrate
            // 
            this.btnCallibrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCallibrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallibrate.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallibrate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCallibrate.Location = new System.Drawing.Point(468, 62);
            this.btnCallibrate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCallibrate.Name = "btnCallibrate";
            this.btnCallibrate.Size = new System.Drawing.Size(150, 62);
            this.btnCallibrate.TabIndex = 22;
            this.btnCallibrate.Text = "CALLIBRATE";
            this.btnCallibrate.UseVisualStyleBackColor = false;
            this.btnCallibrate.Click += new System.EventHandler(this.btnCallibrate_Click);
            // 
            // LblForButtons
            // 
            this.LblForButtons.AutoSize = true;
            this.LblForButtons.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold);
            this.LblForButtons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LblForButtons.Location = new System.Drawing.Point(158, 310);
            this.LblForButtons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblForButtons.Name = "LblForButtons";
            this.LblForButtons.Size = new System.Drawing.Size(460, 32);
            this.LblForButtons.TabIndex = 23;
            this.LblForButtons.Text = "FIRST STEP: please press FIND GLASSES";
            this.LblForButtons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(205, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 62);
            this.button1.TabIndex = 24;
            this.button1.Text = "FIND GLASSES";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSTOP
            // 
            this.btnSTOP.BackColor = System.Drawing.SystemColors.Control;
            this.btnSTOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTOP.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTOP.Image = global::HandAQUS.Properties.Resources.icons8_stop_32;
            this.btnSTOP.Location = new System.Drawing.Point(468, 184);
            this.btnSTOP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(104, 58);
            this.btnSTOP.TabIndex = 20;
            this.btnSTOP.Text = "STOP";
            this.btnSTOP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSTOP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSTOP.UseCompatibleTextRendering = true;
            this.btnSTOP.UseVisualStyleBackColor = false;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // btnSTART
            // 
            this.btnSTART.BackColor = System.Drawing.SystemColors.Control;
            this.btnSTART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTART.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTART.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSTART.Image = global::HandAQUS.Properties.Resources.icons8_play_30;
            this.btnSTART.Location = new System.Drawing.Point(251, 184);
            this.btnSTART.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSTART.Size = new System.Drawing.Size(104, 58);
            this.btnSTART.TabIndex = 18;
            this.btnSTART.Text = "START";
            this.btnSTART.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSTART.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSTART.UseCompatibleTextRendering = true;
            this.btnSTART.UseVisualStyleBackColor = false;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // PupilCoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCallibrate);
            this.Controls.Add(this.LblForButtons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSTOP);
            this.Controls.Add(this.btnSTART);
            this.Name = "PupilCoreForm";
            this.Text = "PupilCore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCallibrate;
        private System.Windows.Forms.Label LblForButtons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSTOP;
        private System.Windows.Forms.Button btnSTART;
    }
}