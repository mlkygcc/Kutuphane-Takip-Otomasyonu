# Kütüphane Takip Otomasyonu 
Bu proje, C# ve MSSQL kullanılarak geliştirilmiş, kütüphane işlemlerini dijital ortamda yönetmeyi sağlayan bir Masaüstü (Windows Forms) uygulamasıdır. Proje, tek bir yönetici (Admin) üzerinden tüm kitap, üye ve kiralama işlemlerinin yürütüldüğü merkezi bir yapıya sahiptir. Sistem Admin Paneli mimarisi üzerine kuruludur; yani sisteme sadece yetkili yönetici giriş yapabilir ve tüm modülleri tek bir panelden yönetir.

# Temel Özellikler
**Güvenli Admin Girişi**: Veritabanı kontrollü kullanıcı doğrulama sistemi.

**Admin Dashboard**: Toplam kitap, üye ve kiradaki kitap sayılarının anlık görüntülendiği bilgi kartları, kiralanmış kitapların ve kime kiralandıkları bilgilerinin yer aldığı tablo.

**Kitap İşlemleri**: Kitap ekleme, silme, güncelleme ve listeleme.

**Üye İşlemleri**: Yeni üye kaydı, üye silme ve bilgi güncelleme.

#Emanet (Kiralama) Sistemi:

Üyeye kitap kiralama (durum güncelleme).

Kitapların "Müsait" veya "Kirada" durumlarının otomatik takibi.

**Gelişmiş Filtreleme**: Üye ve kitap listelerinde anlık arama yapabilme.

# Kullanılan Teknolojiler ve Araçlar
Proje geliştirilirken aşağıdaki teknolojiler ve kütüphaneler kullanılmıştır:

**Dil**: C# 

**Arayüz**: .NET Framework (Windows Forms Application)

**Veritabanı**: Microsoft SQL Server (MSSQL)

**IDE**: Visual Studio

**Veritabanı Yönetimi**: SQL Server Management Studio (SSMS)

# Kurulum
Projeyi kendi bilgisayarınızda çalıştırmak için şu adımları izleyin:

Projeyi İndirin: Bu repoyu bilgisayarınıza klonlayın veya ZIP olarak indirin.

Veritabanını Kurun:

Proje dosyaları içinde bulunan kutuphane.sql dosyasını SSMS ile açın.

Script'i çalıştırarak veritabanını ve tabloları oluşturun.

(Script içinde varsayılan Admin kullanıcısı tanımlıdır).

Bağlantı Ayarı:

Visual Studio'da projeyi açın.

Form kodlarındaki SqlConnection satırını kendi bilgisayarınızın sunucu adına göre güncelleyin.

@"Data Source=.\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True"

Start tuşuna basarak uygulamayı başlatın.

## Giriş Bilgileri 
Uygulama sadece yetkili personel (admin) kullanımına açıktır.

Kullanıcı Adı: admin

Şifre: 12345

# Ekran Görüntüleri


**Geliştirici**: Meleksu YAĞCI
