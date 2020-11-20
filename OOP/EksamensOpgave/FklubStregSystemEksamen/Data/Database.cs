using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace FklubStregSystemEksamen.Data
{
    class Database<T> : IList<T> where T : IDatabase
    {
        Type currentType = typeof(T);
        private List<T> internalList = new List<T>();
        public T this[int index] { get => internalList[index]; set => internalList[index] = value; }

        public int Count => internalList.Count;

        public bool IsReadOnly => true;

        public void Add(T item)
        {
            internalList.Add(item);
        }

        public void Clear()
        {
            internalList.Clear();
        }

        public bool Contains(T item)
        {
            return internalList.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            internalList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in internalList)
            {
                yield return item;
            }
        }

        public int IndexOf(T item)
        {
            return internalList.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            internalList.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return internalList.Remove(item);
        }

        public void RemoveAt(int index)
        {
            internalList.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void FillFromDatabaseFile(string filePath)
        {

            switch (currentType)
            {
                case ("..\\Data\\users.csv"):
                    FillAsUser();
                    break;
                default:
                case ("..\\Data\\products.csv"):
                    FillAsProduct();
                    break;
                case ("..\\Data\\Transactions.txt"):
                    FillAsTransaction();
                    break;
            }
        }

        private void FillAsTransaction()
        {
            throw new NotImplementedException();
        }

        private void FillAsProduct()
        {
            string filePath = @"C:\Git\P3\Personal\OOP\EksamensOpgave\FklubStregSystemEksamen\Data\products.csv"; //TODO make relative if i have the time
            Console.WriteLine(filePath);
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    foreach (var item in values)
                    {
                        listA.Add(item);
                    }
                    foreach (var coloumn1 in listA)
                    {
                        Console.WriteLine(coloumn1);
                    }
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            Console.ReadLine();
        }

        private void FillAsUser()
        {
            string filePath = @"C:\Git\P3\Personal\OOP\EksamensOpgave\FklubStregSystemEksamen\Data\users.csv"; //TODO make relative if i have the time
            Console.WriteLine(filePath);
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    User u = new User(values[1], values[2], values[3], values[5], Convert.ToInt32(values[4]));
                    //internalList.Add(u);

                    foreach (var item in values)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            Console.ReadLine();
        }
    }
}
