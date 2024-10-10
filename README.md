

# Dependency Injection (DI) Örneği - DIPratik
Bu proje, C# dilinde Dependency Injection kullanarak bir sınıf yapısı oluşturmayı amaçlayan basit bir örnektir. Projede bir öğretmen (Teacher) sınıfı, öğretmenle ilgili bilgileri barındıran bir arayüz (ITeacher) ve öğretmenin bulunduğu bir sınıf (ClassRoom) bulunmaktadır.

#Proje Özeti
Bu proje, Dependency Injection (Bağımlılık Enjeksiyonu) prensibine dayalı olarak geliştirilmiştir. ITeacher arayüzü kullanılarak, Teacher sınıfı bağımsız bir şekilde enjekte edilmiştir. Bu yöntemle, sınıflar arasındaki bağlılık azaltılarak esneklik sağlanmıştır.

# Kullanılan Sınıflar:
ITeacher: Öğretmen bilgilerini içeren bir arayüz.

Teacher: ITeacher arayüzünden türeyen ve öğretmen bilgilerini sağlayan sınıf.

ClassRoom: ITeacher arayüzü ile öğretmen bilgilerini alan ve sınıfın öğretmenini tanıtan sınıf.

#Kullanılan Teknolojiler
.NET 8

C# Programlama Dili

# Projenin Faydaları

### Bağımlılıkların Azaltılması: 
  Dependency Injection, kodunuzu daha modüler ve test edilebilir hale getirir.
### Kolay Güncelleme: 
İleride yapılacak güncellemelerde, farklı ITeacher implementasyonları kolayca sisteme entegre edilebilir.
### Kod Esnekliği:
Sınıflar arasındaki bağımlılıklar minimize edilerek daha sürdürülebilir bir kod yapısı sağlanır.
