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
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ShowStudents();
        }

        private void ShowStudents()
        {
            List<Student> students = StudentRepository.GetStudents();
            dgvStudents.DataSource = students;
            dgvStudents.Columns["Id"].DisplayIndex = 0;
            dgvStudents.Columns["FirstName"].DisplayIndex = 1;
            dgvStudents.Columns["LastName"].DisplayIndex = 2;
            dgvStudents.Columns["NumberOfReviews"].DisplayIndex = 3;

        }

    }
}
