using System;
using System.Collections.Generic;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<string> harfler=new List<string>();
            List<int>sayılar=new List<int>();

            harfler.Add("a");
            harfler.Add("b");
            harfler.Add("c");
            harfler.Add("d");
            harfler.Add("e");

            sayılar.Add(10);
            sayılar.Add(15);
            sayılar.Add(20);
            sayılar.Add(12);

            harfler.ForEach(harf=>Console.WriteLine(harf));
            sayılar.ForEach(sayı=>Console.WriteLine(sayı));

           Console.WriteLine(harfler.BinarySearch("b"));// aranan değerin indexini verir
            sayılar.Remove(10);
           Console.WriteLine(sayılar.Count);//eleman sayısı
           Console.WriteLine(harfler.Contains("C"));//içeriyormu?

           List<Arabalar> arabalar=new List<Arabalar>();
           Arabalar araba1=new Arabalar();
           araba1.marka="TESLA";
           araba1.model="Y";
           araba1.yıl=2023;

            Arabalar araba2=new Arabalar();
           araba2.marka="BMW";
           araba2.model="330i";
           araba2.yıl=2022;

            arabalar.Add(araba1);
            arabalar.Add(araba2);

            arabalar.Add(new Arabalar(){
                marka="Mercedes",
                model="CLS",
                yıl=2015
                
                
            });

           // arabalar.ForEach(x=>Console.WriteLine(x));

            foreach(var uye in arabalar){
                Console.WriteLine(uye.marka);
                Console.WriteLine(uye.model);
                Console.WriteLine(uye.yıl);
            }
        }
    }


    public class Arabalar{
        private string Marka;
        private string Model;
        private int Yıl;

        public string marka{get=>Marka;set=>Marka=value;}
        public string model{get=>Model;set=>Model=value;}
        public int yıl{get=>Yıl;set=>Yıl=value;}


    }
}