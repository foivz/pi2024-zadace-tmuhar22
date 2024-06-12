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
            this.txtMenuName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTasteGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReviews
            // 
            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(29, 12);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.Size = new System.Drawing.Size(732, 249);
            this.dgvReviews.TabIndex = 0;
            // 
            // numTasteGrade
            // 
            this.numTasteGrade.Location = new System.Drawing.Point(124, 311);
            this.numTasteGrade.Name = "numTasteGrade";
            this.numTasteGrade.Size = new System.Drawing.Size(44, 20);
            this.numTasteGrade.TabIndex = 2;
            // 
            // numQuantityGrade
            // 
            this.numQuantityGrade.Location = new System.Drawing.Point(124, 337);
            this.numQuantityGrade.Name = "numQuantityGrade";
            this.numQuantityGrade.Size = new System.Drawing.Size(44, 20);
            this.numQuantityGrade.TabIndex = 3;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(124, 366);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(253, 56);
            this.txtComment.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(418, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj Redak";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMeni
            // 
            this.lblMeni.AutoSize = true;
            this.lblMeni.Location = new System.Drawing.Point(26, 287);
            this.lblMeni.Name = "lblMeni";
            this.lblMeni.Size = new System.Drawing.Size(68, 13);
            this.lblMeni.TabIndex = 6;
            this.lblMeni.Text = "Naziv Menija";
            // 
            // lblTaste
            // 
            this.lblTaste.AutoSize = true;
            this.lblTaste.Location = new System.Drawing.Point(26, 313);
            this.lblTaste.Name = "lblTaste";
            this.lblTaste.Size = new System.Drawing.Size(75, 13);
            this.lblTaste.TabIndex = 7;
            this.lblTaste.Text = "Ocjena Okusa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ocjena Količine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Komentar";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(585, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 32);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(124, 284);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(197, 20);
            this.txtMenuName.TabIndex = 11;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMenuName);
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
        private System.Windows.Forms.TextBox txtMenuName;
    }
}