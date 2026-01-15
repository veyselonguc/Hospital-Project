# 🏥 Hastane Yönetim Sistemi

Modern ve kullanıcı dostu bir hastane randevu yönetim platformu. Hasta, doktor ve yönetici rolleri için kapsamlı özellikler sunar.

## 📋 Özellikler

- **Randevu Yönetimi**: Hastalar online randevu alabilir, randevularını takip edebilir
- **Doktor Modülü**: Doktorlar kendi randevularını görüntüleyebilir ve yönetebilir
- **Yönetici Paneli**: Departmanlar, doktorlar ve randevular için tam CRUD işlemleri
- **Departman Sistemi**: Farklı tıbbi bölümler ve doktor atamaları
- **İletişim Formu**: Hastalar sistem üzerinden mesaj gönderebilir

## 🛠️ Teknolojiler

- **Framework**: ASP.NET MVC
- **ORM**: Entity Framework (Code First)
- **Veritabanı**: SQL Server
- **Frontend**: Bootstrap, jQuery
- **Authentication**: Forms Authentication

## 🚀 Kurulum

1. **Projeyi klonlayın**
   ```bash
   git clone https://github.com/veyselonguc/Hospital-Project.git
   ```

2. **Veritabanı bağlantısını yapılandırın**
   
   `Web.config` dosyasındaki connection string'i güncelleyin:
   ```xml
   <connectionStrings>
     <add name="AppDbContext" 
          connectionString="Data Source=YOUR_SERVER;Initial Catalog=DocmedHospitalDb;Integrated Security=true;" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

3. **Migration'ları çalıştırın**
   
   Package Manager Console'da:
   ```
   Update-Database
   ```

4. **Projeyi çalıştırın**
  

## 📁 Proje Yapısı

```
HospitalProject/
├── Controllers/      # MVC Controller'lar
├── Entities/         # Entity sınıfları (Appointment, Doctor, Department, vb.)
├── Context/          # DbContext ve veritabanı yapılandırması
├── Views/            # Razor görünümleri
├── Migrations/       # EF Code First migrations
└── Content/          # CSS, görseller ve statik dosyalar
```

## 👥 Modüller

- **Default**: Ana sayfa ve genel kullanıcı arayüzü
- **Login**: Kimlik doğrulama
- **Appointment**: Randevu işlemleri
- **Doctor**: Doktor yönetimi
- **Department**: Departman yönetimi
- **Admin**: Yönetici paneli

## 📌 Önemli Notlar

- Proje .NET Framework gerektirir
- SQL Server Express veya üzeri sürüm önerilir
- İlk çalıştırmada migration'lar otomatik uygulanmalıdır

## 📸 Ekran Görüntüleri

<img width="1568" height="779" alt="Ekran görüntüsü 2025-05-31 133351" src="https://github.com/user-attachments/assets/6522ca11-5503-4c54-957f-3e05f6cedaa8" />
<img width="1558" height="722" alt="Ekran görüntüsü 2025-05-31 133221" src="https://github.com/user-attachments/assets/02d06b68-ed8c-442b-98cb-d3c13f67fc65" />
<img width="1561" height="716" alt="Ekran görüntüsü 2025-05-31 133243" src="https://github.com/user-attachments/assets/3f9611c2-56db-4594-ab43-bf2748e6abf7" />

