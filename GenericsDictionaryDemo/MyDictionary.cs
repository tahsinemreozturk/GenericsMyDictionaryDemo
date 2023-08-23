using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace GenericsDictionaryDemo
{
    internal class MyDictionary<TKey, TValue> //classin alacagi parametreler
    {
        TKey[]  keys; //classtaki tum metotlarin erisebilecegi sekilde dizi tanimlamasi yapiyoruz.
        TValue[] values;
        public MyDictionary() //class ilk cagirildigina constructor`u calistiracaktir. burada newleyerek 
                              // dizilerimi olusturuyoruz. bellekte bir dizi referans degeri olustu...              
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey item, TValue item2) //2 veri turunde parametre alan add metodu yazdik.
        {
            TKey[] KeyTemp = keys;         //Dizilere ekleme yapiliginda bir onceki refernas degeri kaybolacaktir.     
            TValue[] ValuesTemp = values; //Diziler kaybolasin diye gecici olarak dizi referanslarini burada tutuyoruz.

            keys = new TKey[keys.Length + 1]; // Mevcut dizinin boyutunu arttirarak istenen eklemeleri yapmaya zemin hazirliyoruz.

            for (int i = 0; i < KeyTemp.Length; i++)
            {
                keys[i] = KeyTemp[i];      //Yeni elemani dizi icin tempdeki elemanlar aktariliyor.
            }
            keys[keys.Length - 1] = item; //Aktarim bittiginde sonda bos bir indis olustugu icin bunu siliyoruz.

            values = new TValue[keys.Length + 1];

            for (int i = 0; i < ValuesTemp.Length; i++)
            {
                values[i] = ValuesTemp[i];
            }
            values[keys.Length - 1] = item2;

            Console.WriteLine("{0}, {1}", item, item2); //Bu yaoi cagirilgidinda istenilen verileri yazdirmasini sagliyoruz.


        }
    }
}
