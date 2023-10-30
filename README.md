# BTK_NYT_6.HomeWork_GameAppApp
A Rock Paper Scissors Game Create By Using C# Language and By Taking Advantage From C# OOP Min Princebles Capsulation, Abstraction,Polymorphism,Inheritance
Oyun Uygulaması - Gereksinimler:

Abstract Sınıfların Kullanımı:

Player: Oyuncunun temel özelliklerini ve davranışlarını içeren abstract sınıf.
ComputerPlayer: Bilgisayar oyuncusunun temel özelliklerini ve davranışlarını içeren abstract sınıf.
Ortak Davranışların Tanımı:

Player ve ComputerPlayer sınıfları, oyuncu adını ve seçilen hamleyi (taş, kağıt, makas) içeren ortak davranışları tanımlayacak.
Polimorfizm:

Oyuncuların (oyuncu ve bilgisayar) farklı hamle stratejileri olacak.
Her iki oyuncu türü de aynı abstract davranışları uygulayacak, ancak kendi özel hamle stratejilerini kullanacak.
Alt Sınıflar Arasında Kod Paylaşımı:

HumanPlayer sınıfı, Player sınıfından türetilerek oyuncunun adını alacak ve hamle yapma stratejisini uygulayacak.
RandomComputerPlayer sınıfı, ComputerPlayer sınıfından türetilerek bilgisayarın rastgele hamle yapma stratejisini uygulayacak.
Konsol Ortamı:

Kullanıcıya hamle seçenekleri sunulacak ve girdi alınacak.
Oyuncuların hamleleri ve sonuçları konsol üzerinde gösterilecek.
Gereksinimler:

Oyuncuların isimleri giriş olarak istenecek.
Kullanıcıya taş, kağıt veya makas seçenekleri sunulacak.
Bilgisayar rastgele bir hamle yapacak.
Oyuncuların ve bilgisayarın hamleleri ekrana yazdırılacak.
Hamle sonucu (kazanan, kaybeden veya berabere) açıklanacak.
Oyuncuların puanları takip edilecek.
Oyunun bir turu sona erdiğinde kullanıcıya devam etmek isteyip istemediği sorulacak.
Kullanıcı oyunu sonlandırmak istediğinde toplam puanlar ekrana yazdırılacak.
Oyun boyunca yapılan hamleler kaydedilecek ve geçmiş hamleler görüntülenebilecek.
Oyun içindeki farklı oyuncu tipleri için stratejiler belirlenebilecek.
Bu örnekte, taş-kağıt-makas oyununu konsol ortamında gerçekleştiren bir uygulama tasarımı görülmektedir. Abstract sınıfların, ortak davranışların, polimorfizmin ve kod paylaşımının nasıl kullanılabileceği örnek bir uygulama olarak tasarlanmıştır.
