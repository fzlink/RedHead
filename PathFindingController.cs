using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace RedHead
{
    class PathFindingController
    {
        public enum Algorithm { BestFirst = 0, BestFirstHeap = 1, AStar = 2, AStarHeap = 3}; // Hangi algoritmanın kullanılacağını seçmek için
        private Algorithm selectedAlgorithm { get; set; } // Seçilen algoritma
        private int[] startPoints { get; set; } // startPoints[0] == X, startPoints[1] == Y
        private int[] finishPoints { get; set; } // finishPoints[0] == X, finishPoints[1] == Y
        private Bitmap image { get; set; } // Resim
        private Form1 form; // Arayüze veri yollamak için
        private bool isDiagnostics; // Algoritmaların sırayla çalıştırılıp karşılaştırma tablolarını çıkartmak isteniyorsa
        private List<DiagnosticResult> diagnosticResults; // Her algoritmanın ürettiği sonuçlar

        public PathFindingController(int selectedAlgorithmIndex, int[] startPoints, int[] finishPoints, Bitmap image, Form1 form) //Tek algoritma çalıştırmak için constructor
        {
            selectedAlgorithm = (Algorithm)selectedAlgorithmIndex;
            this.startPoints = startPoints;
            this.finishPoints = finishPoints;
            this.image = image;
            this.form = form;

            
            SelectAndExecuteAlgorithm();
        }

        public PathFindingController(bool isDiagnostics,int[] startPoints, int[] finishPoints, Bitmap image) // Karşılaştırma için constructor
        {
            this.isDiagnostics = isDiagnostics;
            this.startPoints = startPoints;
            this.finishPoints = finishPoints;
            this.image = image;
            this.diagnosticResults = new List<DiagnosticResult>(4); // 4 Algoritma için 4'lük yer

            SelectAndExecuteAlgorithm();
        }

        private void SelectAndExecuteAlgorithm() //Algoritma seçme ve çalıştırma
        {
            if (isDiagnostics) // Karşılaştırma için hepsi çalıştırılacaksa
            {
                BestFirstSearch();
                BestFirstSearchHeap();
                AStar();
                AStarHeap();
                ShowDiagnostics();
            }
            else //Tek bir algoritma çalıştırılacaksa
            {
                if (selectedAlgorithm == Algorithm.BestFirst)
                {
                    BestFirstSearch();
                }
                else if(selectedAlgorithm == Algorithm.BestFirstHeap)
                {
                    BestFirstSearchHeap();
                }
                else if(selectedAlgorithm == Algorithm.AStar)
                {
                    AStar();
                }
                else if(selectedAlgorithm == Algorithm.AStarHeap)
                {
                    AStarHeap();
                }
            }
        }

        private void ShowDiagnostics() //Karşılaştırma formu gösterme
        {
            DiagnosticsForm dForm = new DiagnosticsForm(); // Karşılaştırma formu
            dForm.UpdateForm(diagnosticResults); // Forma verileri gönder
            dForm.Show(); // Formu göster

        }

        private void BestFirstSearch()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); // Süreyi hesaplamak için kronometre
            int maximumArrayLength = 0; // Kuyrukta bulunan maksimum eleman sayısı
            int dequeueCount = 0; // Kuyruktan çekme sayısı

            Queue<Node> nodes = new Queue<Node>(); // Kuyruk
            Node startNode = new Node(null, startPoints[0], startPoints[1]); // Başlangıç noktası
            Evaluate(startNode); // Başlangıç noktasını değerlendirme
            nodes.Enqueue(startNode); // Kuyruğa ekleme

            int[,] visited = new int[image.Width, image.Height]; // Visited matrisi
            visited[startNode.x, startNode.y] = 1; // Başlangıç noktasını set etme

            bool found = false; // Bulundu mu
            Node node = new Node();
            while (nodes.Count > 0 && !found) //Kuyruk boş mu ve bulundu mu
            {
                node = nodes.Dequeue(); // Kuyruğun başından eleman çekme
                dequeueCount++; // Kuyruktan çekme sayısını artırma

                if (node.x == finishPoints[0] && node.y == finishPoints[1]) // Bitiş noktası mı
                {
                    found = true;
                }

                List<Node> neighbours = new List<Node>(); // Komşular dizisi
                PopulateNeighbours(node, neighbours); // Komşuları belirleme

                foreach (Node item in neighbours)
                {
                    if (item.x >= 0 && item.y >= 0 && item.x < image.Width && item.y < image.Height) //Resmin içerisinde mi
                    {
                        if (visited[item.x, item.y] == 0) // Ziyaret edildi mi
                        {
                            Evaluate(item); // Değerlendirme-h(n)
                            GiveWeight(item); // Ağırlık-g(n) (kullanılmasa da maliyetin A* dan yüksek çıktığını göstermek için eklenmiştir)
                            nodes.Enqueue(item); //Kuyruğa ekleme
                            visited[item.x, item.y] = 1; // Ziyaret edildi
                        }
                    }
                }

                var list = nodes.OrderBy(o => o.h).ToList(); // Kuyruğu h(n)'e göre sıralama (f(n) = h(n))
                nodes = new Queue<Node>(list);

                if (nodes.Count > maximumArrayLength) // Maksimum eleman sayısı mı
                {
                    maximumArrayLength = nodes.Count;
                }
            }

            if (found) // Bulunduysa
            {
                watch.Stop(); // Kronometreyi durdur
                var elapsedTime = watch.ElapsedMilliseconds; // Süre
                Finalize(PaintPath(node), elapsedTime, maximumArrayLength, dequeueCount, node.g); // Arayüze yansıtma
            }
        }

        // Daha önce de açıklanan değişkenler tekrar açıklanmamıştır.
        private void BestFirstSearchHeap()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int maximumArrayLength = 0;
            int dequeueCount = 0;

            MinHeap nodes = new MinHeap(true); // Heap oluşturma true == best first search olduğu
            Node startNode = new Node(null, startPoints[0], startPoints[1]);
            Evaluate(startNode);
            nodes.Insert(startNode); // Heap'e ekleme

            int[,] visited = new int[image.Width, image.Height];
            visited[startNode.x, startNode.y] = 1;

            bool found = false;
            Node node = new Node();
            while (nodes.list.Count > 0 && !found)
            {
                node = nodes.PullMin(); // Heapin root undan en küçüğü çekme
                dequeueCount++;

                if (node.x == finishPoints[0] && node.y == finishPoints[1])
                {
                    found = true;
                }


                List<Node> neighbours = new List<Node>();
                PopulateNeighbours(node, neighbours);

                foreach (Node item in neighbours)
                {
                    if (item.x >= 0 && item.y >= 0 && item.x < image.Width && item.y < image.Height)
                    {
                        if (visited[item.x, item.y] == 0)
                        {
                            Evaluate(item);
                            GiveWeight(item);
                            nodes.Insert(item);
                            visited[item.x, item.y] = 1;
                        }
                    }
                }
                if (nodes.list.Count > maximumArrayLength)
                {
                    maximumArrayLength = nodes.list.Count;
                }
            }
            if (found)
            {
                watch.Stop();
                var elapsedTime = watch.ElapsedMilliseconds;
                Finalize(PaintPath(node), elapsedTime, maximumArrayLength, dequeueCount, node.g);
            }
        }

        // Daha önce de açıklanan değişkenler tekrar açıklanmamıştır.
        private void AStar()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int maximumArrayLength = 0;
            int dequeueCount = 0;

            Queue<Node> nodes = new Queue<Node>();
            Node startNode = new Node(null, startPoints[0], startPoints[1]);
            Evaluate(startNode);
            nodes.Enqueue(startNode);


            int[,] visited = new int[image.Width, image.Height];
            visited[startNode.x, startNode.y] = 1;

            bool found = false;
            Node node = new Node();
            while (nodes.Count > 0 && !found)
            {
                node = nodes.Dequeue();
                dequeueCount++;

                if (node.x == finishPoints[0] && node.y == finishPoints[1])
                {
                    found = true;
                }
              
                List<Node> neighbours = new List<Node>();
                PopulateNeighbours(node, neighbours);

                foreach (Node item in neighbours)
                {
                    if (item.x >= 0 && item.y >= 0 && item.x < image.Width && item.y < image.Height)
                    {
                        if(visited[item.x, item.y] == 0)
                        {
                            Evaluate(item);
                            GiveWeight(item);
                            nodes.Enqueue(item);
                            visited[item.x, item.y] = 1;
                        }
                    }
                }
                
                var list = nodes.OrderBy(o => o.f).ToList(); // Kuyruğu f(n)'e göre sıralama (f(n) = h(n) + g(n))
                nodes = new Queue<Node>(list);
                if (nodes.Count > maximumArrayLength)
                {
                    maximumArrayLength = nodes.Count;
                }
            }
            if (found)
            {
                watch.Stop();
                var elapsedTime = watch.ElapsedMilliseconds;
                Finalize(PaintPath(node), elapsedTime, maximumArrayLength, dequeueCount, node.g);
            }
        }

        // Daha önce de açıklanan değişkenler tekrar açıklanmamıştır.
        private void AStarHeap()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int maximumArrayLength = 0;
            int dequeueCount = 0;

            MinHeap nodes = new MinHeap(false); // Heap oluşturma false == A*
            Node startNode = new Node(null, startPoints[0], startPoints[1]);
            Evaluate(startNode);
            nodes.Insert(startNode);


            int[,] visited = new int[image.Width, image.Height];
            visited[startNode.x, startNode.y] = 1;

            bool found = false;
            Node node = new Node();
            while (nodes.list.Count > 0 && !found)
            {
                node = nodes.PullMin();

                dequeueCount++;

                if (node.x == finishPoints[0] && node.y == finishPoints[1])
                {
                    found = true;
                }
                
                List<Node> neighbours = new List<Node>();
                PopulateNeighbours(node, neighbours);

                foreach (Node item in neighbours)
                {
                    if (item.x >= 0 && item.y >= 0 && item.x < image.Width && item.y < image.Height)
                    {
                        if (visited[item.x,item.y] == 0)
                        {
                            Evaluate(item);
                            GiveWeight(item);
                            nodes.Insert(item);
                            visited[item.x, item.y] = 1;
                        }
                    }
                }

                if (nodes.list.Count > maximumArrayLength)
                {
                    maximumArrayLength = nodes.list.Count;
                }
            }
            if (found)
            {
                watch.Stop();
                var elapsedTime = watch.ElapsedMilliseconds;
                Finalize(PaintPath(node),elapsedTime,maximumArrayLength,dequeueCount,node.g);
            }
        }

        private void Finalize(Bitmap paintedImage, long elapsedTime, int maximumArrayLength, int dequeueCount,long totalCost) // Sonuç bulununca
        {
            if (isDiagnostics) // Karşılaştırma için ise
            {
                diagnosticResults.Add(new DiagnosticResult(paintedImage, elapsedTime, maximumArrayLength, dequeueCount, totalCost)); // Sonuç listesine ekle
            }
            else // Tek algoritma çalıştırmak için ise
            {
                form.UpdateForm(elapsedTime, maximumArrayLength, dequeueCount, totalCost, paintedImage); // Forma verileri gönder
            }
        }

        private static void PopulateNeighbours(Node node, List<Node> neighbours) // Komşuları belirleme
        {
            int x = node.x;
            int y = node.y;

            neighbours.Add(new Node(node, x - 1, y));  //1
            neighbours.Add(new Node(node, x - 1, y + 1)); //2
            neighbours.Add(new Node(node, x, y + 1)); //3
            neighbours.Add(new Node(node, x + 1, y + 1)); //4
            neighbours.Add(new Node(node, x + 1, y)); //5
            neighbours.Add(new Node(node, x + 1, y - 1)); //6
            neighbours.Add(new Node(node, x, y - 1)); //7
            neighbours.Add(new Node(node, x - 1, y - 1)); //8

            // ____ ____ ____ 
            //|__8_|__7_|__6_|
            //|__1_|__x_|__5_|
            //|__2_|__3_|__4_|
            
            //Noktanın etrafındaki 8 diğer komşu nokta

        }

        private void GiveWeight(Node item) // Ağırlık verme - g(n)
        {
            byte redValue = image.GetPixel(item.x, item.y).R; // Resimdeki R değeri
            if (redValue == 0) { redValue = 1; } // R 0 ise 1 yapılır
            item.g = item.parent.g + (255 - redValue); // Başlangıçtan parenta kadar olan maliyet + seçilen noktaya gelmenin maliyeti
        }

        private void Evaluate(Node node) // Değerlendirme - h(n)
        {
            int x = node.x; // Kolaylık sağlaması açısından
            int y = node.y; // Kolaylık sağlaması açısından

            // Bitiş noktasına olan kuş uçuşu uzaklık = √(x1-x2)² + (y1-y2)²

            long distance = Convert.ToInt64(Math.Sqrt((finishPoints[0] - x) * (finishPoints[0] - x) + (finishPoints[1] - y) * (finishPoints[1] - y)));

            byte redValue = image.GetPixel(node.x, node.y).R;// Resimdeki R değeri
            if (redValue == 0) { redValue = 1; }// R 0 ise 1 yapılır
            int cost = (255 - redValue); // Maliyet

            node.h = distance * cost; // h(n) uzaklık * kırmızılık olarak belirlenmiştir.
            // Seçilen nokta ne kadar kırmızıysa h(n) değeri o kadar azalır.
            // Uzaklıkla çarpılarak kırmızı noktalar arasından hedefe yakın olana gidilmesi istenmiştir.
        }

        private Bitmap PaintPath(Node node) // Yolun boyanması
        {
            Node paintNode = node; // Değişken olarak gelen değerin değiştirilmemesi için
            bool onStart = false; // Başlangıca gelindi mi
            Bitmap tmpImage = (Bitmap)image.Clone(); // Resmin kopyası
            while(!onStart) // Başlangıca gelinene kadar
            {
                if (paintNode.x == startPoints[0] && paintNode.y == startPoints[1]) // Başlangıç noktası mı
                {
                    onStart = true;
                }
                tmpImage.SetPixel(paintNode.x, paintNode.y, Color.Aqua); // Pikseli turkuaz renge boyamak
                if(paintNode.y + 1 < tmpImage.Height) tmpImage.SetPixel(paintNode.x, paintNode.y + 1, Color.Aqua); // Pikselin aşağısını boyamak
                if(paintNode.y - 1 >= 0) tmpImage.SetPixel(paintNode.x, paintNode.y - 1, Color.Aqua); // Pikselin yukarısını boyamak
                if(paintNode.x - 1 >= 0) tmpImage.SetPixel(paintNode.x - 1, paintNode.y, Color.Aqua); // Pikselin solunu boyamak
                if(paintNode.x + 1 < tmpImage.Width) tmpImage.SetPixel(paintNode.x + 1, paintNode.y, Color.Aqua); // Pikselin sağını boyamak
                //Çizilen yolun daha belirgin olması için etrafı da boyanmıştır.
                paintNode = paintNode.parent; // Parent noktasına git

            }
            //Paint Start and Finish
            PointF startLocation = new PointF(startPoints[0], startPoints[1]);
            PointF finishLocation = new PointF(finishPoints[0], finishPoints[1]);
            using (Graphics graphics = Graphics.FromImage(tmpImage))
            {
                using (Font arialFont = new Font("Arial", 24))
                {
                    graphics.DrawString("Start", arialFont, Brushes.LightGreen, startLocation); // Başlangıç noktasına "START" yazmak için
                    graphics.DrawString("Finish", arialFont, Brushes.LightGreen, finishLocation); // Bitiş noktasına "FINISH" yazmak için
                }
            }
            return tmpImage;
        }


    }

    public class Node // Nokta (Piksel)
    {
        public Node parent { get; set; } // Parent noktası
        public int x { get; set; } // X koordinatı
        public int y { get; set; } // Y koordinatı
        public long h { get; set; } // h(n) değeri
        public long g { get; set; } // g(n) değeri
        public long f // f(n) değeri
        {
            get
            {
                return g + h;
            }
        }

        public Node(Node parent, int x, int y) // Constructor
        {
            this.parent = parent;
            this.x = x;
            this.y = y;
        }

        public Node()
        {

        }
    }

}
