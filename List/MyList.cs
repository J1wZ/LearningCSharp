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
            try
            {
                if (this.Count == 0 || this.Count >= this.Copacity)
                {
                    throw new Exception("Не возможно обрезать Лист.");
                }
                else
                {
                    Array.Resize(ref this.Values, this.Count);
                    this.Copacity = this.Count;
                    Console.WriteLine("Лист обрезан.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка:{e.Message}");
            }
        }

        public void AddValue(T a)
        {
            if (this.Count > this.Copacity)
            {
                Array.Resize(ref this.Values, this.Copacity + 5);
                this.Copacity += 5;
            }
            if (this.Count == 0)
            {
                this.Values[this.Count] = a;
            }
            else
            {
                this.Values[this.Count] = a;
            }
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
            try
            {
                int Id = this.FindIndexOf(el);
                if (Id == -1)
                {
                    throw new Exception("Такого элемента не существует.");
                }
                else
                {
                    Delete(Id);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ошибка:{e.Message}");
            }
        }

        public void PrintList()
        {
            try
            {
                if (this.Count < 1)
                {
                    throw new Exception("В листе ничего нет.");
                }
                else
                {
                    for (int i = 0; i < this.Count; i++)
                    {
                        Console.WriteLine(this.Values[i]);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ошибка:{e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                if (id < 0 || id >= this.Count)
                {
                    throw new Exception("Элемента с таким индексом не существует.");
                }
                else
                {
                    MyList<T> cup = new MyList<T>();
                    for (int i =0; i < this.Count; i++)
                    {
                        if (i != id)
                        {
                            //Array.Resize(ref cup.Values, cup.Values.Length + 1);
                            //cup.Values[cup.Values.Length - 1] = this.Values[i];
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
            catch(Exception ex)
            {
                Console.WriteLine($"Ошибка:{ex.Message}");
            }
        }
    }
}
