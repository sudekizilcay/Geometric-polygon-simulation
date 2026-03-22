# Geometrik Çokgen Modelleme ve Simülasyon Sistemi

Bu proje, **Nesne Yönelimli Programlama (OOP)** prensipleri doğrultusunda, iki boyutlu düzlemde düzenli çokgenlerin matematiksel olarak modellenmesi ve grafiksel olarak görselleştirilmesi amacıyla geliştirilmiştir.
Uygulama; kartezyen ve kutupsal koordinat sistemleri arasında dönüşümler, trigonometrik rotasyon algoritmaları ve dinamik çizim tekniklerini bir araya getirmektedir.

---

## Proje Tanımı

Sistem, kullanıcının belirlediği parametrelere göre (**kenar sayısı, merkez koordinatları, yarıçap ve renk**) düzenli çokgenlerin oluşturulmasını sağlar. Oluşturulan çokgenler, merkez noktaları etrafında saat yönünde veya saat yönünün tersine döndürülebilir.

Geometrik hesaplamalar, özel olarak tasarlanmış sınıflar aracılığıyla gerçekleştirilmekte olup, her çokgenin köşe koordinatları anlık olarak hesaplanarak kullanıcıya sunulmaktadır. Bu sayede hem görsel hem de matematiksel doğruluk sağlanmaktadır.

---

## Özellikler

- Parametrik çokgen oluşturma (kenar sayısı, yarıçap, merkez noktası)  
- Saat yönünde ve saat yönünün tersine rotasyon  
- Kartezyen ve kutupsal koordinat dönüşümleri  
- Gerçek zamanlı köşe koordinat hesaplama  
- RGB tabanlı renk seçimi ve görselleştirme  
- Dinamik grafik çizimi  

---

## Sistem Bileşenleri

### Point2D
Koordinat sistemleri arasında dönüşüm işlemlerini gerçekleştiren ve nokta bazlı matematiksel hesaplamaları yöneten temel sınıftır.

### Polygon
Çokgenin geometrik yapısını oluşturan ve rotasyon işlemlerini gerçekleştiren iş mantığı katmanıdır.

### ColorRGB
Grafiksel çizimlerde kullanılan renk bileşenlerini temsil eden yapıdır.

### Form1
Kullanıcıdan alınan girdileri işleyen ve grafiksel çıktıları yöneten arayüz katmanıdır.

---

## Çalışma Mantığı

Uygulama, çokgen köşelerini trigonometrik fonksiyonlar yardımıyla hesaplar. Her köşe noktası, belirlenen merkez etrafında açı bazlı olarak konumlandırılır. Rotasyon işlemleri, açı değerlerinin kümülatif olarak güncellenmesi ile gerçekleştirilir.

Bu yaklaşım, hem matematiksel doğruluk hem de görsel tutarlılık sağlar.

---

## Kurulum ve Çalıştırma

Projeyi çalıştırmak için aşağıdaki adımlar izlenmelidir:

1. Visual Studio ortamında proje dosyasını açın  
2. .NET Framework 4.7.2 sürümünün yüklü olduğundan emin olun  
3. Projeyi derleyin (**Build**)  
4. Uygulamayı çalıştırın (**Run**)  

---

## Kullanım

Uygulama arayüzü üzerinden:

1. Çokgenin kenar sayısı belirlenir  
2. Merkez koordinatları girilir  
3. Yarıçap değeri ayarlanır  
4. RGB değerleri ile renk seçilir  
5. Döndürme işlemi başlatılır  

Tüm değişiklikler anlık olarak grafik ekran üzerinde gözlemlenebilir.

---

## Projenin Amacı

Bu proje, nesne yönelimli yazılım geliştirme yaklaşımının, bilgisayar grafikleri ve temel geometrik algoritmalar ile nasıl entegre edilebileceğini göstermek amacıyla geliştirilmiştir.
Aynı zamanda, matematiksel modelleme ile görsel çıktı üretimi arasındaki ilişkiyi uygulamalı olarak incelemeyi hedeflemektedir.
