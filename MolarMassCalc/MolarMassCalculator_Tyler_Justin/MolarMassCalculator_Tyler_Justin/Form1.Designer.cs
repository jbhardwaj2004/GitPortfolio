namespace MolarMassCalculator_Tyler_Justin
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_sortbyname = new System.Windows.Forms.Button();
            this.btn_scs = new System.Windows.Forms.Button();
            this.btn_sortbyatomicnum = new System.Windows.Forms.Button();
            this.txt_chemicalformual = new System.Windows.Forms.TextBox();
            this.lbl_chemicalformula = new System.Windows.Forms.Label();
            this.txt_molarmass = new System.Windows.Forms.TextBox();
            this.lbl_molarmass = new System.Windows.Forms.Label();
            this.txt_searchtextbox = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtInvalidSymbols = new System.Windows.Forms.TextBox();
            this.lblInvalidSymbols = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.Size = new System.Drawing.Size(613, 283);
            this.dataGridView.TabIndex = 0;
            // 
            // btn_sortbyname
            // 
            this.btn_sortbyname.Location = new System.Drawing.Point(646, 12);
            this.btn_sortbyname.Name = "btn_sortbyname";
            this.btn_sortbyname.Size = new System.Drawing.Size(142, 31);
            this.btn_sortbyname.TabIndex = 1;
            this.btn_sortbyname.Text = "Sort By Name";
            this.btn_sortbyname.UseVisualStyleBackColor = true;
            this.btn_sortbyname.Click += new System.EventHandler(this.btn_sortbyname_Click);
            // 
            // btn_scs
            // 
            this.btn_scs.Location = new System.Drawing.Point(646, 49);
            this.btn_scs.Name = "btn_scs";
            this.btn_scs.Size = new System.Drawing.Size(142, 31);
            this.btn_scs.TabIndex = 2;
            this.btn_scs.Text = "Single Character Symbols";
            this.btn_scs.UseVisualStyleBackColor = true;
            this.btn_scs.Click += new System.EventHandler(this.btn_scs_Click);
            // 
            // btn_sortbyatomicnum
            // 
            this.btn_sortbyatomicnum.Location = new System.Drawing.Point(646, 86);
            this.btn_sortbyatomicnum.Name = "btn_sortbyatomicnum";
            this.btn_sortbyatomicnum.Size = new System.Drawing.Size(142, 31);
            this.btn_sortbyatomicnum.TabIndex = 3;
            this.btn_sortbyatomicnum.Text = "Sort By Atomix #";
            this.btn_sortbyatomicnum.UseVisualStyleBackColor = true;
            this.btn_sortbyatomicnum.Click += new System.EventHandler(this.btn_sortbyatomicnum_Click);
            // 
            // txt_chemicalformual
            // 
            this.txt_chemicalformual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_chemicalformual.Location = new System.Drawing.Point(164, 328);
            this.txt_chemicalformual.Name = "txt_chemicalformual";
            this.txt_chemicalformual.Size = new System.Drawing.Size(266, 20);
            this.txt_chemicalformual.TabIndex = 4;
            this.txt_chemicalformual.TextChanged += new System.EventHandler(this.txt_chemicalformual_TextChanged);
            // 
            // lbl_chemicalformula
            // 
            this.lbl_chemicalformula.AutoSize = true;
            this.lbl_chemicalformula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chemicalformula.Location = new System.Drawing.Point(23, 328);
            this.lbl_chemicalformula.Name = "lbl_chemicalformula";
            this.lbl_chemicalformula.Size = new System.Drawing.Size(135, 16);
            this.lbl_chemicalformula.TabIndex = 5;
            this.lbl_chemicalformula.Text = "Chemical Formula:";
            // 
            // txt_molarmass
            // 
            this.txt_molarmass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_molarmass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_molarmass.Location = new System.Drawing.Point(643, 328);
            this.txt_molarmass.Name = "txt_molarmass";
            this.txt_molarmass.ReadOnly = true;
            this.txt_molarmass.Size = new System.Drawing.Size(125, 20);
            this.txt_molarmass.TabIndex = 6;
            // 
            // lbl_molarmass
            // 
            this.lbl_molarmass.AutoSize = true;
            this.lbl_molarmass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_molarmass.Location = new System.Drawing.Point(493, 328);
            this.lbl_molarmass.Name = "lbl_molarmass";
            this.lbl_molarmass.Size = new System.Drawing.Size(144, 16);
            this.lbl_molarmass.TabIndex = 7;
            this.lbl_molarmass.Text = "Approx. Molar Mass";
            // 
            // txt_searchtextbox
            // 
            this.txt_searchtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_searchtextbox.Location = new System.Drawing.Point(646, 171);
            this.txt_searchtextbox.Name = "txt_searchtextbox";
            this.txt_searchtextbox.Size = new System.Drawing.Size(125, 20);
            this.txt_searchtextbox.TabIndex = 8;
            this.txt_searchtextbox.TextChanged += new System.EventHandler(this.txt_searchtextbox_TextChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(644, 154);
            this.lbl_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(41, 13);
            this.lbl_search.TabIndex = 9;
            this.lbl_search.Text = "Search";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtInvalidSymbols
            // 
            this.txtInvalidSymbols.Enabled = false;
            this.txtInvalidSymbols.Location = new System.Drawing.Point(646, 247);
            this.txtInvalidSymbols.Name = "txtInvalidSymbols";
            this.txtInvalidSymbols.Size = new System.Drawing.Size(125, 20);
            this.txtInvalidSymbols.TabIndex = 10;
            // 
            // lblInvalidSymbols
            // 
            this.lblInvalidSymbols.AutoSize = true;
            this.lblInvalidSymbols.Location = new System.Drawing.Point(644, 231);
            this.lblInvalidSymbols.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvalidSymbols.Name = "lblInvalidSymbols";
            this.lblInvalidSymbols.Size = new System.Drawing.Size(80, 13);
            this.lblInvalidSymbols.TabIndex = 11;
            this.lblInvalidSymbols.Text = "Invalid Symbols";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.lblInvalidSymbols);
            this.Controls.Add(this.txtInvalidSymbols);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txt_searchtextbox);
            this.Controls.Add(this.lbl_molarmass);
            this.Controls.Add(this.txt_molarmass);
            this.Controls.Add(this.lbl_chemicalformula);
            this.Controls.Add(this.txt_chemicalformual);
            this.Controls.Add(this.btn_sortbyatomicnum);
            this.Controls.Add(this.btn_scs);
            this.Controls.Add(this.btn_sortbyname);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_sortbyname;
        private System.Windows.Forms.Button btn_scs;
        private System.Windows.Forms.Button btn_sortbyatomicnum;
        private System.Windows.Forms.TextBox txt_chemicalformual;
        private System.Windows.Forms.Label lbl_chemicalformula;
        private System.Windows.Forms.TextBox txt_molarmass;
        private System.Windows.Forms.Label lbl_molarmass;
        private System.Windows.Forms.TextBox txt_searchtextbox;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtInvalidSymbols;
        private System.Windows.Forms.Label lblInvalidSymbols;
    }
}

