using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca_03.Models;
using Zadaca_03.Repositories;

namespace Zadaca_03
{
    public partial class FrmReviews : Form
    {
        public FrmReviews()
        {
            InitializeComponent();
        }

        private void FrmReviews_Load(object sender, EventArgs e)
        {
            ShowReviews();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
         // Dohvati tekst iz TextBox-a i pretvori ga u mala slova radi lakše usporedbe
         string searchTerm = txtSearch.Text.ToLower();

         // Dohvati sve recenzije
         List<Reviews> allReviews = ReviewRepository.GetReviews();

         // Filtriraj recenzije prema pretraživanju
        List<Reviews> filteredReviews = allReviews.Where(r => r.Comment.ToLower().Contains(searchTerm) 
        || r.MenuName.ToLower().Contains(searchTerm) 
        || r.TasteGrade.ToString().Contains(searchTerm)
        || r.QuantityGrade.ToString().Contains(searchTerm)).ToList();

        // Prikaži filtrirane recenzije
        dgvReviews.DataSource = filteredReviews;

        // Postavite ispravan prikaz stupaca nakon filtriranja
        dgvReviews.Columns["IdMeni"].Visible = false;
        dgvReviews.Columns["MenuName"].DisplayIndex = 1;
        dgvReviews.Columns["MenuName"].HeaderText = "Naziv Menija";
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Reviews selectedReview = dgvReviews.CurrentRow.DataBoundItem as Reviews;
            if (selectedReview != null)
            {
                // Potvrda brisanja
                var confirmResult = MessageBox.Show("Jeste li sigurni da želite obrisati recenziju?", "Potvrda brisanja", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Brisanje recenzije iz baze podataka
                    ReviewRepository.DeleteReview(selectedReview.Id);

                    // Ažuriranje prikaza u DataGridView
                    ShowReviews();
                }
            }
            else
            {
                MessageBox.Show("Please select a review to delete.");
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUpdate frmUpdate = new FrmUpdate();
            frmUpdate.ShowDialog();
            this.Show();
        }
    }
}
