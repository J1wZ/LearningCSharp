using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class MyList<T>
    {

        public T[] Values;

        public T[] Items
        {
            get { return Values; }
            set { Values = value; }
        }

        public MyList()
        {
            this.Values = new T[0];
        }

        public MyList(T a)
        {
            this.Values = new T[1];
            this.Values[0] = a;
        }

        

        public void AddValue(T a)
        {
            int id = 0;
            if (this.Values.Length >= 0)
            {
                Array.Resize(ref this.Values, this.Values.Length + 1);
                id = this.Values.Length -1;
            }
            this.Values[id] = a;
            Console.WriteLine("Элемент добавлен.");
        }

        public int FindIndexOf(T el)
        {
            for (int i = 0; i < this.Values.Length; i++)
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
            return this.Values.Length;
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
                Console.WriteLine($"Ощибка:{e.Message}");
            }
        }

        public void PrintList()
        {
            try
            {
                if (this.Values.Length < 1)
                {
                    throw new Exception("В листе ничего нет.");
                }
                else
                {
                    for (int i = 0; i < this.CountElem(); i++)
                    {
                        Console.WriteLine(this.Values[i]);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ощибка:{e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                if (id < 0 || id >= this.Values.Length)
                {
                    throw new Exception("Элемента с таким индексом не существует.");
                }
                else
                {
                    MyList<T> cup = new MyList<T>();
                    for (int i =0; i < this.Values.Length; i++)
                    {
                        if (i != id)
                        {
                            Array.Resize(ref cup.Values, cup.Values.Length + 1);
                            cup.Values[cup.Values.Length - 1] = this.Values[i];
                        }
                    }
                    Array.Resize(ref this.Values, cup.Values.Length);
                    Array.Copy(cup.Values, this.Values, this.Values.Length);
                    Console.WriteLine("Элемент удален.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ощибка:{ex.Message}");
            }
        }
    }
}
