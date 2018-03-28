using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1Beta
{
    public class OtoparkKuyrugu : IOtopark
    {
        public Araba[] Otopark;  
        public int front = -1;
        public int rear = -1;
        public int size = 0;
        public int counter = 0;

        public OtoparkKuyrugu(int size)
        {
            this.size = size;
            Otopark = new Araba[size];
        }

        public void Insert(Araba a)
        {
            if (front == -1)
                front = 0;

            Otopark[++rear] = a;
            counter++;                                                    //Arabalara sıra numarası ver..                    
        }

        public object Remove()
        {
            if (IsEmpty())
                return "Otoparkta çıkarılacak araç yok.";

            object temp = Otopark[front];          

            Otopark[front] = null;

            front++;
            counter--;
            return temp;
        }
        public bool IsEmpty()
        {
            return counter == 0;
        }

        public object  Peek()
        {
            return Otopark[front];
        }

        public void Insert(object a)
        {
            throw new NotImplementedException();
        }

        /* public void Insert(object a)
         {
             throw new NotImplementedException();
         }*/
    }
}
