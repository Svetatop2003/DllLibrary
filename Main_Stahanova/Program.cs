using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DllLibrary;

namespace Main_Stahanova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Нежный аллигатор", "Москва");
            for (int i = 1; i <= 3; i++)
            {
               store.Products.Add(new Product($"Инструменты. Набор {i}", "17"));
               store.Products.Add(new Product($"Игрушки. Набор {i}", "13"));
            }
            store.ShowAll();
        }
    }
}
