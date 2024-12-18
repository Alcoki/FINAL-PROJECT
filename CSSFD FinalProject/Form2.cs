using System;
using System.Windows.Forms;
using CSSFD_FinalProject.Managers;

namespace CSSFD_FinalProject
{
    public partial class Form2 : Form
    {
        private string studentNumber;
        private string fullName;
        private int studentYear;
        private GradeManager gradeManager;
        public Form2(string studentNumber, string fullName, int studentYear)
        {
            InitializeComponent();
            this.studentNumber = studentNumber;
            this.fullName = fullName;
            this.studentYear = studentYear;
            gradeManager = new GradeManager();
        }

        private void LoadGrades()
        {
            try
            {
                dgvGrades.DataSource = gradeManager.GetGrades(studentNumber, studentYear);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grades: " + ex.Message);
            }
        }

        private void btnViewGrades_Click(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubject.Text) || string.IsNullOrEmpty(txtGrade.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string subjectName = txtSubject.Text;
            string grade = txtGrade.Text;

            try
            {
                bool success = gradeManager.AddGrade(studentNumber, subjectName, Convert.ToDecimal(grade), studentYear);
                if (success)
                {
                    MessageBox.Show("Grade added successfully.");
                    LoadGrades();
                }
                else
                {
                    MessageBox.Show("Failed to add grade. Try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding grade: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a grade to update.");
                return;
            }

            string subjectName = dgvGrades.SelectedRows[0].Cells["Subject"].Value.ToString();
            string newGrade = txtUpdate.Text.Trim();

            if (string.IsNullOrEmpty(newGrade) || !decimal.TryParse(newGrade, out decimal newGradeDecimal))
            {
                MessageBox.Show("Please enter a valid grade.");
                return;
            }

            try
            {
                bool success = gradeManager.UpdateGrade(studentNumber, subjectName, newGradeDecimal, studentYear);
                if (success)
                {
                    MessageBox.Show("Grade updated successfully.");
                    LoadGrades();
                }
                else
                {
                    MessageBox.Show("No matching grade found to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating grade: " + ex.Message);
            }
        }

        private void btnDeleteGrade_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeleteSubject.Text))
            {
                MessageBox.Show("Please enter the subject to delete.");
                return;
            }

            string subjectToDelete = txtDeleteSubject.Text;

            try
            {
                bool success = gradeManager.DeleteGrade(studentNumber, subjectToDelete, studentYear);
                if (success)
                {
                    MessageBox.Show("Grade deleted successfully.");
                    LoadGrades();
                }
                else
                {
                    MessageBox.Show("No matching grade found to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting grade: " + ex.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {fullName}";
            LoadGrades();
        }
    }
}