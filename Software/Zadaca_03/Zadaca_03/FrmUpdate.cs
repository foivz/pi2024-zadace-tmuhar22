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
    }
}
