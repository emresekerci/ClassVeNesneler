using ClassVeNesneler;

Person kisi1 = new Person();
kisi1.Ad = "Emre";
kisi1.Soyad = "Şekerci";
kisi1.DogumTarihi = new DateTime(1999, 1, 18); 

Person kisi2 = new Person();
kisi2.Ad = "Ahmet";
kisi2.Soyad = "Demir";
kisi2.DogumTarihi = new DateTime(1979, 4, 27); 

Person kisi3 = new Person();
kisi3.Ad = "Cansu";
kisi3.Soyad = "Taşdan";
kisi3.DogumTarihi = new DateTime(1997, 3, 4); 

kisi1.KisiBilgisi();
kisi2.KisiBilgisi();
kisi3.KisiBilgisi();
