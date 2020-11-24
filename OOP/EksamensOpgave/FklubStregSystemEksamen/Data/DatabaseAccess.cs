using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace FklubStregSystemEksamen.Data
{
    public class DatabaseAccess
    {
        public Database<Transaction> transactions = new Database<Transaction>();
        public Database<User> users = new Database<User>();
        public Database<Product> products = new Database<Product>();
        public IDProvider Transid = new IDProvider();
        public DatabaseAccess()
        {
            FillTransaction();
            FillProduct();
            FillUser();
        }
        private void FillTransaction()
        {      
            string filePath = @"C:\Git\P3\Personal\OOP\EksamensOpgave\FklubStregSystemEksamen\Data\Transactions.txt"; //TODO make relative if i have the time
            StreamReader reader;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (line != String.Empty)
                    {
                        if (values[7] == "Buy")
                        {
                            BuyTransaction t = new BuyTransaction(Transid.Next(), new User(Convert.ToInt32(values[0]), values[1], values[2], values[3], values[4], Convert.ToDecimal(values[5])),
                                                                  DateTime.Parse(values[6]),
                                                                   new Product(Convert.ToInt32(values[8]), values[9], Convert.ToDecimal(values[10]), Convert.ToInt32(values[11])));
                            transactions.Add(t);
                        }
                        else if (values[7] == "Insert")
                        {
                            InsertCashTransaction t = new InsertCashTransaction(Transid.Next(), new User(Convert.ToInt32(values[0]), values[1], values[2], values[3], values[4], Convert.ToDecimal(values[5])),
                                                                  DateTime.Parse(values[6]),
                                                                  Convert.ToDecimal(values[8]));
                            transactions.Add(t);
                        }
                    }
                }
                reader.Close();
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }
        }

        private void FillProduct()
        {
            IDProvider id = new IDProvider();
            string filePath = @"C:\Git\P3\Personal\OOP\EksamensOpgave\FklubStregSystemEksamen\Data\products.csv"; //TODO make relative if i have the time
            StreamReader reader;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                string header = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    line = StripHTML(line);
                    var values = line.Split(';');
                    Product p = new Product(id.Next(), values[1], Convert.ToDecimal(values[2]), Convert.ToInt32(values[3]));
                    products.Add(p);
                }
                reader.Close();
            }         
            else
            {
                throw new FileNotFoundException("File not found");
            }
        }

        private void FillUser()
        {
            IDProvider id = new IDProvider();
            string filePath = @"C:\Git\P3\Personal\OOP\EksamensOpgave\FklubStregSystemEksamen\Data\users.csv"; //TODO make relative if i have the time
            StreamReader reader;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                string header = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    line = StripHTML(line);
                    var values = line.Split(',');
                    User u = new User(id.Next(), values[1], values[2], values[3], values[5], Convert.ToInt32(values[4]));
                    users.Add(u);
                }
                reader.Close();
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }
        }

        private string StripHTML(string input)
        {
            string first = Regex.Replace(input, "<.*?>", String.Empty);
            return first.Replace("\"", String.Empty).Trim();
        }

        public void Add(IDatabase item)
        {
            if (item is User)
            {
                users.Add((User)item);
            }
            else if (item is Product)
            {
                users.Add((User)item);
            }
            else if (item is Transaction)
            {
                transactions.Add((Transaction)item);
            }
        }
    }
}
