using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace vegyes_fel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> {"ÁDÁm", "RÓZSIKAA", "lama", "isTiKe"};
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();

            for (int i = 1; i < 11; i++)
            {
                list.Add(i);
            }
            foreach (int i in list)
            {
                list2.Add(pov(i));
            }
            foreach(var item in stri(strings))
            {
                Console.WriteLine(item);
            }
        }

        static int pov(int x)
        {
            return x * x;
        }

        static int adder(List<int> list)
        {
            int ossz = 0;
            foreach (int i in list)
            {
                ossz += i;
            }
            return ossz;
        }

        static List<int> paros(List<int> list)
        {
            List<int> list2 = new List<int>();
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    list2.Add(item);
                }
            }
            return list2;
        }

        static List<int> szoroz(List<int> list, int szam)
        {
            List<int> list2 = new List<int>();
            foreach (var item in list)
            {
                list2.Add(item * szam);
            }
            return list2;
        }


        static List<int> fuz(List<int> list, List<int> list3)
        {
            int m = Math.Min(list.Count, list3.Count);
            List<int> list2 = new List<int>();
            for (int i = 0; i < m; i++)
            {
                list2.Add(list[i]);
                list2.Add(list3[i]);
            }
            if (list3.Count > m)
            {
                for (int i = m; i < list3.Count; i++)
                {
                    list2.Add(list3[i]);
                }
            }
            else if (list.Count > m)
            {
                for (int i = m; i < list.Count; i++)
                {
                    list2.Add(list[i]);
                }
            }
            return list2;
        }


        static int maxi(List<int> list)
        {
            int m = list[0];
            foreach (var item in list)
            {
                if (item > m)
                {
                    m = item;
                }
            }
            return m;
        }



        static int mini(List<int> list)
        {
            int m = list[0];
            foreach (var item in list)
            {
                if (item < m)
                {
                    m = item;
                }
            }
            return m;
        }

        static bool paritas(List<int> list)
        {
            bool result = true;
            foreach (var item in list)
            {
                if (item % 2 == 1)
                {
                    result = false;
                }
            }
            return result;
        }


        static List<int> skip(List<int> list)
        {
            List<int> list2 = new List<int>();
            for (int i = 0; i < list.Count(); i += 2)
            {
                list2.Add(list[i]);
            }

            return list2;
        }

        static List<int> rev(List<int> list)
        {
            list.Reverse();
            List<int> list2 = new List<int>();
            list2 = list;

            return list2;
        }


        static List<string> stri(List<string> list)
        {
            List<string> list2 = new List<string>();
            string  s = "";
            foreach (var item in list)
            {
                s = item.ToLower();
                s = ("" + s[0]).ToUpper()+ s.Substring(1);

                list2.Add(s);
            }
            return list2;
        }
        static List<string> hosszuak(List<string> list)
        {
            List<string> list2 = new List<string>();
            foreach (var item in list)
            {
                if (item.Length > 5)
                {
                    list2.Add(item);
                }
            }
            return list2;
        }
}
