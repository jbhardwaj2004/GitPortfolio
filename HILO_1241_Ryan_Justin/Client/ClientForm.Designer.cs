namespace Client
{
    partial class ClientForm
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
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.trkGuess = new System.Windows.Forms.TrackBar();
            this.lblTrackbarMin = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.lblTrackbarMax = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(12, 12);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(88, 38);
            this.btnConnect1.TabIndex = 0;
            this.btnConnect1.Text = "Connect";
            this.btnConnect1.UseVisualStyleBackColor = true;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // btnConnect2
            // 
            this.btnConnect2.Location = new System.Drawing.Point(106, 12);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(88, 38);
            this.btnConnect2.TabIndex = 1;
            this.btnConnect2.Text = "Connect";
            this.btnConnect2.UseVisualStyleBackColor = true;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // trkGuess
            // 
            this.trkGuess.Location = new System.Drawing.Point(12, 70);
            this.trkGuess.Maximum = 1000;
            this.trkGuess.Minimum = 1;
            this.trkGuess.Name = "trkGuess";
            this.trkGuess.Size = new System.Drawing.Size(776, 45);
            this.trkGuess.TabIndex = 2;
            this.trkGuess.TickFrequency = 10;
            this.trkGuess.Value = 1;
            this.trkGuess.Scroll += new System.EventHandler(this.trkGuess_Scroll);
            // 
            // lblTrackbarMin
            // 
            this.lblTrackbarMin.AutoSize = true;
            this.lblTrackbarMin.Location = new System.Drawing.Point(12, 118);
            this.lblTrackbarMin.Name = "lblTrackbarMin";
            this.lblTrackbarMin.Size = new System.Drawing.Size(13, 13);
            this.lblTrackbarMin.TabIndex = 3;
            this.lblTrackbarMin.Text = "1";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Location = new System.Drawing.Point(390, 118);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentValue.TabIndex = 4;
            this.lblCurrentValue.Text = "1";
            // 
            // lblTrackbarMax
            // 
            this.lblTrackbarMax.AutoSize = true;
            this.lblTrackbarMax.Location = new System.Drawing.Point(753, 118);
            this.lblTrackbarMax.Name = "lblTrackbarMax";
            this.lblTrackbarMax.Size = new System.Drawing.Size(31, 13);
            this.lblTrackbarMax.TabIndex = 5;
            this.lblTrackbarMax.Text = "1000";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(345, 160);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(88, 38);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 134);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(772, 20);
            this.txtMessage.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(668, 160);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(120, 38);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 208);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblTrackbarMax);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.lblTrackbarMin);
            this.Controls.Add(this.trkGuess);
            this.Controls.Add(this.btnConnect2);
            this.Controls.Add(this.btnConnect1);
            this.Name = "ClientForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkGuess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.TrackBar trkGuess;
        private System.Windows.Forms.Label lblTrackbarMin;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.Label lblTrackbarMax;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

