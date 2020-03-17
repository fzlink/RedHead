using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedHead
{
    public partial class DiagnosticsForm : Form
    {
        public DiagnosticsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateForm(List<DiagnosticResult> diagnosticResults)
        {
            // Karşılaştırma formu tablo ve resim ekleme
            timeChart.Series["Time"].Points.AddXY("BFS", diagnosticResults[0].elapsedMilliSeconds);
            timeChart.Series["Time"].Points.AddXY("BFS w/ Heap", diagnosticResults[1].elapsedMilliSeconds);
            timeChart.Series["Time"].Points.AddXY("A*", diagnosticResults[2].elapsedMilliSeconds);
            timeChart.Series["Time"].Points.AddXY("A* w/ Heap", diagnosticResults[3].elapsedMilliSeconds);

            costChart.Series["Cost"].Points.AddXY("BFS", diagnosticResults[0].cost);
            //costChart.Series["Cost"].Points.AddXY("Best-First Search w/ Heap", diagnosticResults[1].cost);
            costChart.Series["Cost"].Points.AddXY("A*", diagnosticResults[2].cost);
            //costChart.Series["Cost"].Points.AddXY("A* w/ Heap", diagnosticResults[3].cost);

            maxLenChart.Series["Max Queue Len"].Points.AddXY("BFS", diagnosticResults[0].maximumQueueLength);
            //maxLenChart.Series["Max Queue Len"].Points.AddXY("Best-First Search w/ Heap", diagnosticResults[1].maximumQueueLength);
            maxLenChart.Series["Max Queue Len"].Points.AddXY("A*", diagnosticResults[2].maximumQueueLength);
            //maxLenChart.Series["Max Queue Len"].Points.AddXY("A* w/ Heap", diagnosticResults[3].maximumQueueLength);

            deqChart.Series["Dequeue Count"].Points.AddXY("BFS", diagnosticResults[0].dequeueCount);
            //deqChart.Series["Dequeue Count"].Points.AddXY("Best-First Search w/ Heap", diagnosticResults[1].dequeueCount);
            deqChart.Series["Dequeue Count"].Points.AddXY("A*", diagnosticResults[2].dequeueCount);
            //deqChart.Series["Dequeue Count"].Points.AddXY("A* w/ Heap", diagnosticResults[3].dequeueCount);

            pictureBox1.Image = diagnosticResults[0].image;
            pictureBox2.Image = diagnosticResults[2].image;
        }
    }
}
