using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information
/*List<int> sayiListesi= new List<int>();
Random rastgele=new Random();
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));
sayiListesi.Add(rastgele.Next(100));

List<string> renkListesi= new List<string>();
renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Mor");
renkListesi.Add("Siyah");
renkListesi.Add("Yeşil");

renkListesi.ForEach(renk=> Console.WriteLine(renk));
sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
sayiListesi.RemoveAt(0);
sayiListesi.RemoveAt(1);
sayiListesi.RemoveAt(2);
//renkListesi.Remove("Siyah");
renkListesi.ForEach(renk=> Console.WriteLine(renk));
sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
Console.WriteLine(renkListesi.BinarySearch("Siyah")); */

List<Kullanıcılar> Kullancı_Listesi= new List<Kullanıcılar>();
Kullanıcılar kullanıcı1= new Kullanıcılar();
Kullanıcılar kullanıcı2= new Kullanıcılar();
Kullanıcılar kullanıcı3= new Kullanıcılar();

kullanıcı1.Isim="Ayşe";
kullanıcı1.Soy_isim="Cengiz";
kullanıcı1.Yas=31;
kullanıcı2.Isim="Furkan";
kullanıcı2.Soy_isim="Cengiz";
kullanıcı2.Yas=12;
kullanıcı2.Isim="Hayriya";
kullanıcı2.Soy_isim="Türkmen";
kullanıcı2.Yas=22;
kullanıcı3.Isim="Kemal";
kullanıcı3.Soy_isim="Kadir";
kullanıcı3.Yas=45;
Kullancı_Listesi.Add(kullanıcı1);
Kullancı_Listesi.Add(kullanıcı2);
Kullancı_Listesi.Add(kullanıcı3);
public class Kullanıcılar {

    string isim;
    string soy_isim;

    int yas;

    public string Soy_isim { get => soy_isim; set => soy_isim = value; }
    public string Isim { get => isim; set => isim = value; }
    public int Yas { get => yas; set => yas = value; }
}
