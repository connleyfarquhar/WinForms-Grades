using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades__WinForms_
{
    public partial class Form1 : Form
    {
        public static List<int> GradeList = new List<int>();
        public static Form1 formFunction;

        /// <summary>
        /// Constructor to initialise the components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            formFunction = this;
        }

        /// <summary>
        /// When the Add button is clicked, add the grade to the list.
        /// If it is not a number, send an error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGradeButton_Click(object sender, EventArgs e)
        {
            int addedMark = 0;

            try
            {
                addedMark = Convert.ToInt32(AddGradeTextBox.Text);

                // If statement holds control over the users input, if user tries to enter a grade under 0 or over 100, it will error.
                // Handled in one statement using OR Operator.
                if (addedMark < 0 || addedMark > 100)
                {
                    MessageBox.Show("Invalid Mark Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine($"Exception Caught in AddGradeButton_Click\n"); // Send to debug window for analysis.
                }

                // Else if these conditions pass, grade added to the list.
                else
                {
                    GradeList.Add(addedMark);
                    MessageBox.Show($"{addedMark} added to the grades list", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } 
            
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Mark Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"Exception Caught in AddGradeButton_Click\n{ex}"); // Send to debug window for analysis.
            }
            AddGradeTextBox.Text = ""; // clear the box for next grade.
        }

        /// <summary>
        /// On Show Summary click, send user to Grades Summary page
        /// Send the gradeslist structure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowSummaryButton_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Clear Button pressed. Ask if they are sure. 
        /// If so, clear the grade list of all stored grades.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear the stored grades?", "Clear Stored Grades?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                GradeList.Clear();
                MessageBox.Show("Grade List Cleared!", "Clear Complete!");
            }
        }
    }
}
