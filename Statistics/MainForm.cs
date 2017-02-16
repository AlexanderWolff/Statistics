using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Statistics
{
    public partial class MainForm : Form
    {
        //Stores loaded data
        List<double> numbers;

        public MainForm()
        {
            //Initialisation procedure
            InitializeComponent();
            numbers = new List<double>();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            //Load data from file
            if (radioButton_file.Checked)
            {
                //Get path
                openFileDialog.ShowDialog();

                //Abort if no file is selected
                if (openFileDialog.FileName == "") return;

                string path = openFileDialog.FileName;

                this.numbers.Clear();
                this.numbers.AddRange(FileIO.ReadCSV(path));
            }
            //Generate data
            else if (radioButton_generate.Checked)
            {
                this.numbers.Clear();
                this.numbers.AddRange(Mathematics.generateRandom((int)numericUpDown.Value, 1, 100));
            }

            //Populate RichTextBox
            displayData(this.numbers, 1);

            //Plot Scatter Graph
            updateScatterGraph(this.numbers);

            //Find arithmetic mean
            double mean = Mathematics.calculateMean(this.numbers);

            //Find standard deviation
            double standard_deviation = Mathematics.calculateStandardDeviation(this.numbers);

            //Find frequencies of numbers in bins of 10
            int[] bins = new int[10];

            for (int i = 0; i < 10; i++)
            {
                bins[i] = Mathematics.getCount(this.numbers, i * 10, (i + 1) * 10);
            }

            //Display Arithmetic Mean
            label_mean.Text = "Arithmetic Mean : " + mean.ToString();

            //Display Standard Deviation
            label_standarddeviaiton.Text = "Standard Deviation : " + standard_deviation.ToString();

            //Plot Histogram
            updateHistogram(bins);

        }

        /// <summary>
        /// Populates Histogram Graph with specified data
        /// </summary>
        /// <param name="bins">Histogram bins</param>
        private void updateHistogram(int[] bins)
        {
            //Clear existing data
            chart_data.Series["bins"].Points.Clear();

            //Populate Histogram
            for (int i = 0; i < bins.Length; i++)
            {
                chart_data.Series["bins"].Points.AddXY((i * 10)+5, bins[i]);
            }
        }

        /// <summary>
        /// Populates Scatter Graph with specified data
        /// </summary>
        /// <param name="data">Integer list to plot</param>
        private void updateScatterGraph(List<double> data)
        {
            //Clear existing data
            chart_data.Series["datapoints"].Points.Clear();

            //Populate Scatter Plot
            for(int i = 0; i < data.Count; i++)
            {
                double x = ((double)(i + 1) / (double)data.Count) * 100;
                chart_data.Series["datapoints"].Points.AddXY(x, data[i]);
            }

            chart_data.Series["datapoints"].MarkerSize = (data.Count < 1000) ? 5 : 2;
        }

        /// <summary>
        /// Updates RichTextBox_data.Text to contain the contents of the specified list, formatted with the specified amount of columns
        /// </summary>
        /// <param name="data">List of datapoints to write</param>
        /// <param name="columns">Number of columns per line</param>
        private void displayData( List<double> data, int columns )
        {
            //Clear previous text
            string data_text = "";

            //Sentinel
            int column = 1;

            //Populate text list
            foreach(var integer in data)
            {
                data_text += integer.ToString();
                data_text += (column < columns) ? "\t": "\n";

                //Increment if less than columns: Reset if more than columns
                column = (column < columns) ? column + 1 : 1;
            }

            //Update textbox
            richTextBox_data.Text = data_text;
        }
    }
}
