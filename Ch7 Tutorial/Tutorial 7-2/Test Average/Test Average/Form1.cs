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

namespace Test_Average
{
    public partial class Form1 : Form
    {
        private const int SIZE = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            int[] scores = new int[SIZE];
            int highestScore = 0;
            int lowestScore = 0;
            double average = 0.0;
            double median = 0.0;
            GetScoresFromFile(scores);

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    testScoresListBox.Items.Add(scores[i]);
            //}
            foreach(int value in scores)
            {
                testScoresListBox.Items.Add(value);
            }

            highestScore = Highest(scores);
            highScoreLabel.Text = highestScore.ToString();

            lowestScore = Lowest(scores);
            lowScoreLabel.Text = lowestScore.ToString();

            average = Average(scores);
            averageScoreLabel.Text = average.ToString();

            
            median = Median(scores);
            medianscorelabel.Text = median.ToString(); 

        }

        private int Lowest(int[] scores)
        {
            int lowest = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < lowest)
                {
                    lowest = scores[i];
                }
            }
            return lowest;
        }

        private int Highest(int[] scores)
        {
            int highest = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > highest)
                {
                    highest = scores[i];
                }
            }
            return highest;
        }

        private double Average(int[] scores)
        {
            int sum = 0;
            for (int i = 0; i<scores.Length; i++)
            {
                sum += scores[i]; //sum = sum + score[i]
           
            }
            //MessageBox.Show("sum =" + sum);
            return sum / scores.Length;//casting

        }

        private double Median(int[] scores)
        {

            Array.Sort(scores);


            if (scores.Length % 2 != 0)
            {
                return scores[scores.Length / 2];
            }
            else
            {

                int midIndex1 = scores.Length / 2 - 1;
                int midIndex2 = scores.Length / 2;
                return (scores[midIndex1] + scores[midIndex2]) / 2.0;
            }
        }



            private void GetScoresFromFile(int[] scores)
        {
            StreamReader inputFile = null;
            int index = 0;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);

                while (!inputFile.EndOfStream && index < scores.Length )
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
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
