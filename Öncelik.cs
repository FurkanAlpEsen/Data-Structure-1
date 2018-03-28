using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1Beta
{
    public class Öncelik
    {
        public Araba[] Otopark;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public Öncelik(int size)
        {
            this.size = size;
            Otopark = new Araba[size];
        }
        public void Insert(Araba o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Otopark[front] = o;
                count++;
            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if (Otopark[i].sure > o.sure)
                        Otopark[i + 1] = Otopark[i];
                    else
                        break;
                }
                Otopark[i + 1] = o;
                
                count++;
            }
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object temp = Otopark[front];
            Otopark[front] = null;
            front++;
            count--;
            return temp;
        }

        public object Peek()
        {
            return Otopark[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
