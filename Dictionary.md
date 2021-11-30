# Dictionary

* Verileri anahtar ve değer olarak tutarlar.
* Kullandığımız Array'lere benzetecek olursak, değerler, Arraylerdeki değerlere, key'lerse index'lerine karşılık geliyor gibi.
* System.Collections.Generic namespace'inde bulunurlar.

Syntax'i: Dictionary<anahtarın_tipi,değerin_tipi> kullanıcılar = new Dictionary<anahtarın_tipi,değerin_tipi>();

###### Foreach ile yazdırırsan key ile value bir eş olarak tutulduğu için hem key hem de value yazılır ancak key ile erişip yazarsan sadece value yazılır. item.Key veya item.Value ile bunları birbirinden ayırabilirsin.

## Metotlar

#### .Count
Kaç tane elemanı olduğunu söyler.

#### .ContainsKey ve .ContainsValue
anahtarın veya değerin bulunup bulunmadığını kontrol eder ve bool döner.
#### .Remove(key)
anahtardaki çifti siler.
### Keys
dictionary_ismi.Keys ile sadece anahtarlar üzerinde çalışabilirsin.

### Value
dictionary_ismi.Values ile sadece değerler üzerinde çalışabilirsin.