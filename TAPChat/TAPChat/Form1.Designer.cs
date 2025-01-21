namespace TAPChat
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.btnAddTarget = new System.Windows.Forms.Button();
            this.lstMessageDisplay = new System.Windows.Forms.ListBox();
            this.dgvKnownIPs = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.chkEmbedIps = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnownIPs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(16, 41);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(1189, 22);
            this.txtMessage.TabIndex = 0;
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(16, 73);
            this.txtIpAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(360, 22);
            this.txtIpAddress.TabIndex = 1;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(607, 73);
            this.txtNickname.Margin = new System.Windows.Forms.Padding(4);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(267, 22);
            this.txtNickname.TabIndex = 2;
            // 
            // btnAddTarget
            // 
            this.btnAddTarget.Location = new System.Drawing.Point(385, 73);
            this.btnAddTarget.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTarget.Name = "btnAddTarget";
            this.btnAddTarget.Size = new System.Drawing.Size(213, 28);
            this.btnAddTarget.TabIndex = 3;
            this.btnAddTarget.Text = "Add Target";
            this.btnAddTarget.UseVisualStyleBackColor = true;
            // 
            // lstMessageDisplay
            // 
            this.lstMessageDisplay.FormattingEnabled = true;
            this.lstMessageDisplay.ItemHeight = 16;
            this.lstMessageDisplay.Location = new System.Drawing.Point(16, 105);
            this.lstMessageDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.lstMessageDisplay.Name = "lstMessageDisplay";
            this.lstMessageDisplay.Size = new System.Drawing.Size(857, 436);
            this.lstMessageDisplay.TabIndex = 4;
            // 
            // dgvKnownIPs
            // 
            this.dgvKnownIPs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnownIPs.Location = new System.Drawing.Point(887, 73);
            this.dgvKnownIPs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKnownIPs.Name = "dgvKnownIPs";
            this.dgvKnownIPs.RowHeadersWidth = 51;
            this.dgvKnownIPs.Size = new System.Drawing.Size(320, 466);
            this.dgvKnownIPs.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(16, 21);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(67, 16);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Message:";
            // 
            // chkEmbedIps
            // 
            this.chkEmbedIps.AutoSize = true;
            this.chkEmbedIps.Location = new System.Drawing.Point(867, 12);
            this.chkEmbedIps.Margin = new System.Windows.Forms.Padding(4);
            this.chkEmbedIps.Name = "chkEmbedIps";
            this.chkEmbedIps.Size = new System.Drawing.Size(137, 20);
            this.chkEmbedIps.TabIndex = 7;
            this.chkEmbedIps.Text = "Embed Known IPs";
            this.chkEmbedIps.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1025, 5);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(181, 28);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 554);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.chkEmbedIps);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgvKnownIPs);
            this.Controls.Add(this.lstMessageDisplay);
            this.Controls.Add(this.btnAddTarget);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.txtMessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TAPChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnownIPs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Button btnAddTarget;
        private System.Windows.Forms.ListBox lstMessageDisplay;
        private System.Windows.Forms.DataGridView dgvKnownIPs;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox chkEmbedIps;
        private System.Windows.Forms.Button btnSend;
    }
}

