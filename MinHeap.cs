using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedHead
{
    public class MinHeap // Root ta minimum bulunan bir Binary Heap
    {
        public int size; // Eleman sayısı
        public List<Node> list; // Dizi
        private bool isBestFirst; // Best First Search mü

        public MinHeap(bool isBestFirst) // Constructor
        {
            this.isBestFirst = isBestFirst;
            list = new List<Node>(); // Diziyi oluşturma
        }

        private void swap(int first, int second) // Dizi içerisinde yer değiştirme işlemi
        {
            Node tmp = list[first];
            list[first] = list[second];
            list[second] = tmp;
        }

        private int parent(int i) // Parent indisi
        {
            return (i - 1) / 2;
        }
        private int left(int i) // Sol dalın indisi
        {
            return i * 2 + 1;
        }
        private int right(int i) // Sağ dalın indisi
        {
            return i * 2 + 2;
        }



        public Node PullMin() // Root taki elemanı çekme ( En Küçük (f(n) veya h(n)) )
        {
            if(size == 0) // Dizi boşsa
            {
                return null;
            }
            if(size == 1) // Tek eleman varsa
            {
                size--; // Eleman sayısını azaltma
                Node tmp = list[0]; // Rootu çekme
                list.Remove(list[0]); // Rootu diziden silme
                return tmp; //Rootu döndürme
            }
            Node node = list[0]; // Rootu çekme
            list[0] = list[size - 1]; // Listenin sonundaki elemanı başa alma
            list.RemoveAt(size - 1); // Listenin sonundaki elemanı silme
            size--; // Eleman sayısını azaltma
            Heapify(0); //Roota gelen elemanı en küçük değilse kaydırma
            return node; // Rootu döndürme
        }

        public void Insert(Node node)
        {
            list.Add(node); // Dizinin sonuna ekleme
            int i = size; // Eleman sayısı
            size++; // Eleman sayısını artırma

            if (isBestFirst) // Best First Search ise
            {
                while (i != 0 && list[parent(i)].h > list[i].h) // Parent noktanın h(n) i daha büyükse yukarı kaydır ve roota gelip gelmediğini kontrol et
                {
                    swap(i, parent(i)); // parent ile yer değiş
                    i = parent(i); // Kaydırıldığı için indisi parent indisi yap
                }
            }
            else // Best First Search değilse
            {
                while (i != 0 && list[parent(i)].f > list[i].f) // Parent noktanın f(n) i daha büyükse yukarı kaydır ve roota gelip gelmediğini kontrol et
                {
                    swap(i, parent(i)); // parent ile yer değiş
                    i = parent(i); // Kaydırıldığı için indisi parent indisi yap
                }
            }
        }

        private void Heapify(int i) // Min Heap özelliğini koruma (Aşağı kaydırarak)
        {
            int left = this.left(i); // Sol dalın indisi
            int right = this.right(i); // Sağ dalın indisi
            int min = i;
            if (isBestFirst) // Best First Search ise
            {
                if (left < size && list[left].h < list[i].h) // Dizinin dışında değilse ve solundaki nokta daha küçükse (h(n))
                    min = left; // en küçük = sol
                if (right < size && list[right].h < list[min].h) // Dizinin dışında değilse ve sağındaki nokta en küçükse (h(n))
                    min = right; // en küçük = sağ
            }
            else // Best First Search değilse
            {
                if (left < size && list[left].f < list[i].f) // Dizinin dışında değilse ve solundaki nokta daha küçükse (f(n))
                    min = left; // en küçük = sol
                if (right < size && list[right].f < list[min].f) // Dizinin dışında değilse ve sağındaki nokta en küçükse (f(n))
                    min = right; // en küçük = sağ
            }
            if (min != i) // En küçük hala kendi değilse tekrar çağırılmayacak
            {
                swap(i, min); // Küçük olan ile yer değiştirme
                Heapify(min); // Recursive olarak tekrar kaydırma
            }
        }
    }
}
