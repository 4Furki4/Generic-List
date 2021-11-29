# Generic List
----------
* System.Collections.Generic namespace'inden gelir.
* List<T> isim = new List<T>(); parantez içi boş olursa sadece initiliaze edilmiş olur ama sayı girerek belli bir uzunlukta liste oluşturabilirsin.
* T-> Generic'tir. Object türündedir. Nesnelerin tipini-int fln- belirtir.

List_ismi.Add(ED) = Değer Ekler.
List_ismi.Count() = Listenin uzunluğunu verir.
--------
### Listeleri Kullanırken değişik bir foreach kullanımı mevcut:
```c#
Liste_ismi.ForEach(sayi=>Console.WriteLine(sayi)); 
```
--------

### Eleman çıkarma:
* List_ismi.Remove(item) = Doğrudan değeri çıkarır
* List_ismi.RemoveAt(index) = indexteki objeyi çıkarır.

### Eleman Bulma:
* Liste_ismi.Contains(eleman) = vakaya bağlı boolean(T-F) döndürür.

### Elemanın Index'ini bulma: 
* Liste_ismi.BinarySearch(item) = index'i verir.

### Diziyi Listeye çevirme:
string[] kediCinsleri= {British, Tekir};
List<string> Kediler= new List<T>(KediCinsleri)

### Class tipinde Liste oluşturma.
* Değişken sadece Class'ın ismi oluyor, class içindeyse propertyleri olabiliyor ve onları da constractor'lar ile oluşturabilirsin.