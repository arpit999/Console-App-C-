/*
  Class:  Form1.cs
  Author: Arpit Patel
  Student ID: 000762465
  Date:   Decembner 7, 2018

*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5b
{
    public partial class Form1 : Form
    {
        string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open dialog for selecting txt file and read data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select a text file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                //richTextBox1.Text = System.IO.File.ReadAllText(fname);
                StreamReader reader = new StreamReader(fileName);
                List<Episode> episodeList = new List<Episode>();
                List<Companion> companionsList = new List<Companion>();
                List<Doctor> doctorList = new List<Doctor>();

                listBox.Items.Clear();

                //get text file data row and split by colon store into array
                while (!reader.EndOfStream)
                {

                    String lineRead = reader.ReadLine(); // read line
                    String[] fields = lineRead.Split('|');


                    switch (lineRead.Substring(0, 1).Trim())
                    {
                        case "E":

                            episodeList.Add(new Episode(fields[1], fields[2], fields[3], fields[4])); 

                            break;

                        case "C":

                            companionsList.Add(new Companion(fields[1], fields[2], fields[3], fields[4]));

                            break;

                        case "D":

                            doctorList.Add(new Doctor(fields[1], fields[2], fields[3], fields[4], fields[5]));

                            break;
                    }




                }


                foreach (Doctor i in doctorList)
                {
                    listBox.Items.Add(i);
                }


                }
            }

        /// <summary>
        /// close the form window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application
            this.Close();
        }
    }
}
