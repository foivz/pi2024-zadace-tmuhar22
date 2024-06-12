using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Zadaca_03.Models;
using Zadaca_03.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zadaca_03
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            LoadMenus();
            ShowReviews();

            numTasteGrade.Minimum = 1;
            numTasteGrade.Maximum = 5;

            numQuantityGrade.Minimum = 1;
            numQuantityGrade.Maximum = 5;
        }

        private void LoadMenus()
        {
            List<Menus> menus = MeniRepository.GetMenus();
            cmbMeni.DataSource = menus;
            cmbMeni.DisplayMember = "Name";
            cmbMeni.ValueMember = "Id";
        }

        private void ShowReviews()
        {
            List<Reviews> reviews = ReviewRepository.GetReviews();
            dgvReviews.DataSource = reviews;
            dgvReviews.Columns["Id"].DisplayIndex = 0;
            dgvReviews.Columns["IdMeni"].Visible = false;
            dgvReviews.Columns["MenuName"].DisplayIndex = 1;
            dgvReviews.Columns["MenuName"].HeaderText = "Naziv Menija";
            dgvReviews.Columns["TasteGrade"].DisplayIndex = 2;
            dgvReviews.Columns["QuantityGrade"].DisplayIndex = 3;
            dgvReviews.Columns["Comment"].DisplayIndex = 4;
            dgvReviews.Columns["DateOfReview"].DisplayIndex = 5;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int reviewId = int.Parse(txtId.Text);
                int meniId = (int)cmbMeni.SelectedValue; // Get selected menu ID from ComboBox
                int tasteGrade = int.Parse(numTasteGrade.Text);
                int quantityGrade = int.Parse(numQuantityGrade.Text);
                string comment = txtComment.Text;
                DateTime dateOfReview = DateTime.Now;

                Reviews newReview = new Reviews
                {
                    Id = reviewId,
                    IdMeni = meniId,
                    TasteGrade = tasteGrade,
                    QuantityGrade = quantityGrade,
                    Comment = comment,
                    DateOfReview = dateOfReview,
                };

                ReviewRepository.InsertReview(newReview);
                ShowReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmReviews frmReviews = new FrmReviews();
            frmReviews.Show();
            this.Close();
        }

    }
}
