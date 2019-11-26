using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GDALTranslate;
using System.IO;
using OSGeo.GDAL;

namespace TiffConverterCoreFinal
{
    public partial class Form1 : Form
    {
        private string inputPath;
        private string outputPath;

        List<string> files = new List<string>();

        internal TcTranslate translate;

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        

        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void input_Click(object sender, EventArgs e)
        {
            using (fbd)
            {
                
                DialogResult result = fbd.ShowDialog();
                inputFolderText.Text = fbd.SelectedPath.ToString();
                inputPath = inputFolderText.Text;

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var test = Directory.GetFiles(inputPath, "*.tif");
                    
                    foreach (var i in test)
                    {
                        if (i.ToString().EndsWith(".tif"))
                        {
                            files.Add(i.ToString());
                        }

                    }

                    MessageBox.Show("TIFF files found: " + files.Count, "Message");

                }
            }
        }

        private void output_Click(object sender, EventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                outputFolderText.Text = fbd.SelectedPath.ToString();
                outputPath = outputFolderText.Text;
            }
        }


        private void make_KMZ_Click(object sender, EventArgs e)
        {
            Process();

        }

        private void Process()
        {
            translate = new TcTranslate("test.kmz", inputPath + @"\", outputPath + @"\");
            translate.TranslateAction(files);

            // MessageBox.Show("TranslateAction called");
        }

        private void inputFolderText_TextChanged(object sender, EventArgs e)
        {

        }


        private void outputFolderText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}