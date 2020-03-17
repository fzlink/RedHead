using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHead
{
    public class DiagnosticResult
    {
        public Bitmap image { get; set; } // Resim
        public long elapsedMilliSeconds { get; set; } //Geçen süre
        public int maximumQueueLength { get; set; } // Maximum kuyruk uzunluğu
        public int dequeueCount { get; set; } // Kuyruktan çekme sayısı
        public long cost { get; set; } // Maliyet

        public DiagnosticResult(Bitmap image, long elapsedMilliSeconds, int maximumQueueLength, int dequeueCount, long cost)
        {
            this.image = image;
            this.elapsedMilliSeconds = elapsedMilliSeconds;
            this.maximumQueueLength = maximumQueueLength;
            this.dequeueCount = dequeueCount;
            this.cost = cost;
        }
    }
}
