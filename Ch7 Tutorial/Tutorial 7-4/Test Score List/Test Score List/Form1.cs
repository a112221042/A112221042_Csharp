using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void getScoresButton_Click(object sender, EventArgs e)
        {
            List<int> scoresList = new List<int>();
            double average;
            int numAboveAverage;
            int numBekowAverage;

            GetScoresFromFile(scoresList);

            foreach (int value in scoresList)
            {
                testScoresListBox.Items.Add(value);
            }

            average = Average(scoresList);
            averageLabel.Text = average.ToString("nl");



            numAboveAverage = AboveAverage(scoresList);
            aboveAverageLabel.Text = numAboveAverage.ToString();
        }


        private int AboveAverage(List<int> scores)
        {
            double average = Average(scores);
            int numAbove = 0;

            foreach (int value in scores)
            {
                if (value > average)

                {
                    numAbove++;
                }
            }
            return numAbove;
        }
        private double Average(List<int> scores)
        {
            int sum = 0;
            foreach (int value in scores)
            {
                sum += value;
            }
            return (double)sum / scores.Count;

        }
        private void GetScoresFromFile(List<int> scores)
        {
            StreamReader inputFile = null;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);

                while (!inputFile.EndOfStream)
                {
                    scores.Add(int.Parse(inputFile.ReadLine()));

                }
            }

            else
            {
                MessageBox.Show("已取消");
            }
            inputFile.Close();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

    }
}
