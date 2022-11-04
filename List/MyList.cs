using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class MyList<T>
    {
        public int Count { get; set; }
        public int Copacity { get; set; }
        public T[] Values;

        public T[] Items
        {
            get { return Values; }
            set { Values = value; }
        }

        public MyList()
        {
            this.Values = new T[5];
            this.Count = 0;
            this.Copacity = 5;
        }

        public MyList(T a)
        {
            this.Values = new T[5];
            this.Values[0] = a;
            this.Count = 1;
            this.Copacity = 5;
        }

        public void Trim()
        {
          
                if (this.Count == 0 || this.Count >= this.Copacity)
                {
                    Console.WriteLine("Не возможно обрезать Лист.");
                }
                else
                {
                    Array.Resize(ref this.Values, this.Count);
                    this.Copacity = this.Count;
                    Console.WriteLine("Лист обрезан.");
                }
            
          
        }

        public void AddValue(T a)
        {
            if (this.Count > this.Copacity)
            {
                Array.Resize(ref this.Values, this.Copacity * 2);
                this.Copacity *= 2;
            }

            this.Values[this.Count] = a;
            
            this.Count++;
            Console.WriteLine("Элемент добавлен.");
        }

        public int FindIndexOf(T el)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Values[i].Equals(el))
                {
                    return i;
                }
            }
            return -1;
        }

        public int CountElem()
        {
            return this.Count;
        }

        public int GetCopacity()
        {
            return this.Copacity;
        }

        public void Delete(T el)
        {
           
                int Id = this.FindIndexOf(el);
                if (Id == -1)
                {
                    Console.WriteLine("Такого элемента не существует.");
                }
                else
                {
                    Delete(Id);
                }
            
     
        }

        public void PrintList()
        {
                if (this.Count < 1)
                {
                Console.WriteLine("В листе ничего нет.");
                }
                else
                {
                    for (int i = 0; i < this.Count; i++)
                    {
                        Console.WriteLine(this.Values[i]);
                    }
                }
            
        }

        public void Delete(int id)
        {

                if (id < 0 || id >= this.Count)
                {
                    Console.WriteLine("Элемента с таким индексом не существует.");
                }
                else
                {
                    MyList<T> cup = new MyList<T>();
                    for (int i =0; i < this.Count; i++)
                    {
                        if (i != id)
                        {
                            cup.AddValue(this.Values[i]);
                        }
                    }
                    Array.Resize(ref this.Values, cup.Copacity);
                    Array.Copy(cup.Values, this.Values, cup.Copacity);
                    this.Count--;
                    this.Copacity = cup.Copacity;
                    Console.WriteLine("Элемент удален.");
                }
            
        }
    }
}
