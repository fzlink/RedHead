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

namespace RedHead
{
    public partial class Form1 : Form
    {
        Bitmap image;


        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Resim seçme
            DialogResult result = imageSelectDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string filename = imageSelectDialog.FileName;
                image = new Bitmap(filename);
                pictureBox1.Image = image;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public class ImageBoundException : Exception
        {
            public ImageBoundException(string message) : base(message)
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if(image == null)
            {
                stringError.Text = "Please select an image";
            }
            else
            {
                var selectedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                int selectedAlgorithm = selectedButton.TabIndex;

                try
                {
                    // Noktaları alma
                    int startPointX = int.Parse(startXText.Text);
                    int startPointY = int.Parse(startYText.Text);
                    int finishPointX = int.Parse(finishXText.Text);
                    int finishPointY = int.Parse(finishYText.Text);

                    // Doğrulama
                    if(startPointX < 0 || startPointY < 0 || finishPointX < 0 || finishPointY < 0) { throw (new ImageBoundException("The number you entered exceeds the image size.")); }
                    if (startPointX >= image.Width || finishPointX >= image.Width) { throw (new ImageBoundException("The number you entered exceeds the image size.")); }
                    if (startPointY >= image.Height || finishPointY >= image.Height) { throw (new ImageBoundException("The number you entered exceeds the image size.")); }

                    int[] startPoints = { startPointX, startPointY };
                    int[] finishPoints = { finishPointX, finishPointY };
                    //Algoritmayı çağırma
                    PathFindingController pfc = new PathFindingController(selectedAlgorithm, startPoints, finishPoints, image, this);
                    stringError.Text = "";
                }
                catch (FormatException)
                {
                    stringError.Text = "Points you entered are not valid.";
                }
                catch (ImageBoundException ie)
                {
                    stringError.Text = ie.Message;
                }
            }

            

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void UpdateForm(long elapsedTime, int maximumArrayLen, int dequeueCount, long totalCost, Bitmap paintedImage)
        {
            //Formu güncelleme
            elapsedTimeMs.Text = "Time elapsed for: " + elapsedTime + " milliseconds";
            costText.Text = "Total Cost: " + totalCost;
            maximumQueueLen.Text = "Maximum Queue Length: " + maximumArrayLen;
            dequeueCountLabel.Text = "Number of dequeues: " + dequeueCount;
            pictureBox1.Image = paintedImage;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void diagnosticsButton_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                stringError.Text = "Please select an image";
            }
            else
            {
                try
                {
                    // Noktaları alma
                    int startPointX = int.Parse(startXText.Text);
                    int startPointY = int.Parse(startYText.Text);
                    int finishPointX = int.Parse(finishXText.Text);
                    int finishPointY = int.Parse(finishYText.Text);

                    // Doğrulama
                    if (startPointX < 0 || startPointY < 0 || finishPointX < 0 || finishPointY < 0) { throw (new ImageBoundException("The number you entered exceeds the image size.")); }
                    if (startPointX >= image.Width || finishPointX >= image.Width) { throw (new ImageBoundException("The number you entered exceeds the image size.")); }
                    if (startPointY >= image.Height || finishPointY >= image.Height) { throw (new ImageBoundException("The number you entered exceeds the image size.")); }

                    int[] startPoints = { startPointX, startPointY };
                    int[] finishPoints = { finishPointX, finishPointY };
                    //Algoritmayı çağırma
                    PathFindingController pfc = new PathFindingController(true, startPoints, finishPoints, image);
                    stringError.Text = "";
                }
                catch (FormatException)
                {
                    stringError.Text = "Points you entered are not valid.";
                }
                catch (ImageBoundException ie)
                {
                    stringError.Text = ie.Message;
                }
            }
        }
    }
}
