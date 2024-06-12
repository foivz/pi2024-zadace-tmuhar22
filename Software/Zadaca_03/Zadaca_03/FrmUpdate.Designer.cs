namespace Zadaca_03
{
    partial class FrmUpdate
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
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.numTasteGrade = new System.Windows.Forms.NumericUpDown();
            this.numQuantityGrade = new System.Windows.Forms.NumericUpDown();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMeni = new System.Windows.Forms.Label();
            this.lblTaste = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdRecenzije = new System.Windows.Forms.Label();
            this.cmbMeni = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTasteGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReviews
            // 
            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(29, 12);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.Size = new System.Drawing.Size(650, 220);
            this.dgvReviews.TabIndex = 0;
            // 
            // numTasteGrade
            // 
            this.numTasteGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numTasteGrade.Location = new System.Drawing.Point(191, 315);
            this.numTasteGrade.Name = "numTasteGrade";
            this.numTasteGrade.Size = new System.Drawing.Size(44, 20);
            this.numTasteGrade.TabIndex = 2;
            // 
            // numQuantityGrade
            // 
            this.numQuantityGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numQuantityGrade.Location = new System.Drawing.Point(190, 341);
            this.numQuantityGrade.Name = "numQuantityGrade";
            this.numQuantityGrade.Size = new System.Drawing.Size(45, 20);
            this.numQuantityGrade.TabIndex = 3;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComment.Location = new System.Drawing.Point(190, 370);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(254, 63);
            this.txtComment.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(190, 461);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj Redak";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMeni
            // 
            this.lblMeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMeni.AutoSize = true;
            this.lblMeni.BackColor = System.Drawing.Color.Transparent;
            this.lblMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeni.Location = new System.Drawing.Point(77, 288);
            this.lblMeni.Name = "lblMeni";
            this.lblMeni.Size = new System.Drawing.Size(96, 16);
            this.lblMeni.TabIndex = 6;
            this.lblMeni.Text = "Naziv Menija";
            // 
            // lblTaste
            // 
            this.lblTaste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTaste.AutoSize = true;
            this.lblTaste.BackColor = System.Drawing.Color.Transparent;
            this.lblTaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaste.Location = new System.Drawing.Point(69, 315);
            this.lblTaste.Name = "lblTaste";
            this.lblTaste.Size = new System.Drawing.Size(104, 16);
            this.lblTaste.TabIndex = 7;
            this.lblTaste.Text = "Ocjena Okusa";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ocjena Količine";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Komentar";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(337, 461);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 39);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(191, 254);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 12;
            // 
            // txtIdRecenzije
            // 
            this.txtIdRecenzije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdRecenzije.AutoSize = true;
            this.txtIdRecenzije.BackColor = System.Drawing.Color.Transparent;
            this.txtIdRecenzije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRecenzije.Location = new System.Drawing.Point(86, 258);
            this.txtIdRecenzije.Name = "txtIdRecenzije";
            this.txtIdRecenzije.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdRecenzije.Size = new System.Drawing.Size(87, 16);
            this.txtIdRecenzije.TabIndex = 14;
            this.txtIdRecenzije.Text = "Id recenzije";
            // 
            // cmbMeni
            // 
            this.cmbMeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMeni.FormattingEnabled = true;
            this.cmbMeni.Location = new System.Drawing.Point(191, 288);
            this.cmbMeni.Name = "cmbMeni";
            this.cmbMeni.Size = new System.Drawing.Size(121, 21);
            this.cmbMeni.TabIndex = 15;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Zadaca_03.Resource1.abstract_background_gradient_abstract_modern_background_for_mobile_apps_free_vector;
            this.ClientSize = new System.Drawing.Size(678, 522);
            this.Controls.Add(this.cmbMeni);
            this.Controls.Add(this.txtIdRecenzije);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTaste);
            this.Controls.Add(this.lblMeni);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.numQuantityGrade);
            this.Controls.Add(this.numTasteGrade);
            this.Controls.Add(this.dgvReviews);
            this.Name = "FrmUpdate";
            this.Text = "FrmUpdate";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTasteGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.NumericUpDown numTasteGrade;
        private System.Windows.Forms.NumericUpDown numQuantityGrade;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMeni;
        private System.Windows.Forms.Label lblTaste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label txtIdRecenzije;
        private System.Windows.Forms.ComboBox cmbMeni;
    }
}