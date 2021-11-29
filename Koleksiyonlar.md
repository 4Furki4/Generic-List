# Koleksiyonlar 

**AVANTAJ**-Koleksiyonlar nesnelerden oluşur ve istenildiği gibi -arraylerin aksine- genişletilebilir-RAM yettiği müddetçe. 

Koleksiyonlar System.Collections namespace'i yani isim uzayı altında bulunurlar. Yani bir koleksiyon tipini kullanmak istiyorsanız System.Collections'ı using direktifi ile programınıza import ediyor olmanız gerekiyor.

.Net platformunda 2 tane veri tipi var: Değer veri tipleri ve Referans veri tipleri.

* Değer veri tipleri: Integer, Boolean, Double, Float, boolean, char, enum
* Referans veri tipleri: String, Array, class, interface, delegate, pointer

Değer tipindeki veriyi Referans tipinde yapmak için boxing denilen işlem uygulanmalı, tersi içinse unboxing. 

**DEZAVANTAJ** Değer veri tipindeki bir veriyi koleksiyona eklemek için boxing işlemi yapmalıyız ve bu işlem maaliyetlidir.



-----

## Stack ve Heap

Stack ve heap ram'in mantıksal bölümleridir.

Stack'te pointer, adresler ve değer tiplerini tutarken, Heap referans tipi verileri tutar.

Struct tipindeki değişkenler Strack'te saklanır. Class tipindeki değişkenlerin adresleri Stack'te, kendisiyse Heap'te tutulur.

![](https://i1.wp.com/gokhan-gokalp.com/wp-content/uploads/2014/07/heapstack.jpg?ssl=1)



* Eğer program esnasında boyutları bildirilmiş değişmez bir değer kullanıyorsak *stack*, değişebilir bir değer kullanıyorsak *heap* bizim için uygun olacaktır.

  Stack ve Heap Farkları için güzel bir [**yazı**](https://medium.com/yigit-xcodeproj/stack-ve-heap-arasindaki-fark-nedir-stack-vs-heap-c61e3d463dd7)

