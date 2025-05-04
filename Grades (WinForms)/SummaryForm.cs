using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades__WinForms_
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            NumMarksTextBox.Text = GetNumMarks().ToString();
            TotalMarksTextBox.Text = CalculateTotalMarks().ToString();
            AverageMarkTextBox.Text = GetAverageMarks().ToString();
            HighestMarkTextBox.Text = CalculateHighest(Form1.GradeList).ToString();
            LowestMarkTextBox.Text = CalculateLowest(Form1.GradeList).ToString();
        }
        
        /// <summary>
        /// Take the count of the gradelist items from Form1 and return.
        /// </summary>
        /// <returns>Integer of number of items in GradesList</returns>
        private int GetNumMarks()
        {
            return Form1.GradeList.Count;
        }

        /// <summary>
        /// sums up all the items in the GradesList List
        /// </summary>
        /// <returns>Integer of total marks given</returns>
        private int CalculateTotalMarks()
        {
            int total = 0;  
            foreach (int mark in Form1.GradeList)
            {
                total += mark;
            }
            return total;
        }

        /// <summary>
        /// calculates the average marks in the GradesList list
        /// </summary>
        /// <returns>double of AverageMarks</returns>
        private double GetAverageMarks()
        {
            double average = 0;
            try
            {
                //cast as doubles to avoid integer division.
                average = (double)CalculateTotalMarks() / (double)GetNumMarks();
            }
            catch (Exception ex)
            {
                average = 0;
                Debug.WriteLine($"Exception caught in GetAverageMarks:\n{ex}");
            }
            return Math.Round(average,2);
        }

        /// <summary>
        /// Function will calculate the highest grade from the user.
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        private int CalculateHighest(List<int> grades)
        {
            // Algorithm will calculate highest grade input for each input, taking the highest number and making it the highest.
            int highest = grades[0];

            for (int currentIndex = 1; currentIndex < grades.Count; currentIndex++)
            {
                if (grades[currentIndex] > highest)
                {
                    highest = grades[currentIndex];
                }
            }

            return highest;
        }

        /// <summary>
        /// Function will calculate the lowest grade input from the user.
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        private int CalculateLowest(List<int> grades)
        {
            // Algorithm will calculate lowest grade input for each input, taking the lowest number and making it the lowest.
            int lowest = grades[0];
            for (int currentIndex = 1; currentIndex < grades.Count; currentIndex++)
            {
                if (grades[currentIndex] < lowest)
                {
                    lowest = grades[currentIndex];
                }
            }

            return lowest;
        }

        /// <summary>
        /// Go back to the Main Page
        /// </summary>
        /// <param name="sender">Button that was clicked</param>
        /// <param name="e">arguments</param>
        private void MainPageButton_Click(object sender, EventArgs e)
        {
            // Fixes issues reguarding Main Menu button within the application, button now directs to the main page of the program.
            // Also Fully closes the program on close rather than it being held in the background, calling the instance variable from Form1.cs
            Form1.formFunction.Show();
            this.Close();
        }

    }
}
