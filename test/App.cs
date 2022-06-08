using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace test
{
    internal class App
    {

        public void Run()
        {
            string filePath1 = @"D:\Programing Projects\c#\test\test\input.txt";
            string filePath2 = @"D:\Programing Projects\c#\test\test\output.txt";


            List<string> list1 = new List<string>();
            list1 = File.ReadAllLines(filePath1).ToList();

            List<string> list2 = new List<string>();


            for (int i = 0; i < 4; i++)
            {
                string a = list1[i].ToString();
                string[] b = a.Replace(" ", string.Empty).Split(";");
                foreach (var item in b)
                {
                    if (b[2] == "true")
                    {
                        list2.Add(b[3]);
                        break;
                    }

                }
            }

            int z = 0;
            for(int i = 0; i < list2.Count; i++)
            {
                string k = list2[i];
                
                int x = Int32.Parse(k);
                z += x;
            }

            string time = DateTime.Now.ToString("h:mm:ss tt");


            list2.Clear();
            list2.Add(z.ToString());
            list2.Add(time);
            File.WriteAllLines(filePath2, list2);
            

        }
    }
}