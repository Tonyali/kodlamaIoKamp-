using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  // türü Type tan gelen T yazarak ne girersek türü o yapar.
    {
        T[] items;
        //constructor(ctor tab+ tab) - class new lendiğinde çalışır. Sıfır elemanlı, eleman sayısını sıfırlar.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Referans nosunu tutturmak için geçici array oluştur.
            items = new T[items.Length + 1];  // eski değerleri kaybetmemek için geçici array e yaz
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  // geçici arraydeki değerleri yeni arraye al
            }

            items[items.Length - 1] = item;  //eklenmek istenen elemanı dizinin sonuna ekle
        }
        

    }
}
