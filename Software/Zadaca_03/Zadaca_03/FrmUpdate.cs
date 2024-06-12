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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string menuName = txtMenuName.Text;
            int tasteGrade = int.Parse(numTasteGrade.Text);
            int quantityGrade = int.Parse(numQuantityGrade.Text);
            string comment = txtComment.Text;
            DateTime dateOfReview = DateTime.Now;

            int menuId = GetMenuIdByName(menuName);

            Reviews newReview = new Reviews
            {
                IdMeni = menuId,
                TasteGrade = tasteGrade,
                QuantityGrade = quantityGrade,
                Comment = comment,
                DateOfReview = dateOfReview,
                MenuName = menuName
            };

            ReviewRepository.InsertReview(newReview);
            ShowReviews();
        }

        private int GetMenuIdByName(string menuName)
        {
            // Logika za dohvaćanje Id menija prema imenu menija
            // Pretpostavimo da postoji metoda u nekom MenuRepositoryju koja to omogućava
            return MeniRepository.GetMenuIdByName(menuName);
        }

    }
}
