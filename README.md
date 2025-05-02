# .Net Core 8 Web API Projesi

Bu proje, .Net Core 8 Web API geliştirme sürecinde kullanılan temel yapı taşlarını içeren bir örnek projedir. Proje, Onion Architecture, CQRS, Mediatr, JWT Authentication ve Authorization, Redis entegrasyonu gibi konularda derinlemesine bir rehber sunmaktadır.

## İçerik

1. Onion Architecture'a Giriş
   - Projenin katmanlı yapısının temelleri.
   - Onion Architecture'ın avantajları ve nasıl uygulanacağı.

2. Versiyon Kontrolü ve Github
   - Projenin GitHub üzerinden yönetimi.
   - Proje versiyonlarının takip edilmesi.

3. Prod ve Dev Ortamlarının Ayrıştırılması
   - `appsettings` yapılandırmaları.
   - Prod ve Dev ortamları için ayarlamalar.

4. Entity Oluşumları ve İlişkiler
   - Ürün ve ürünler için gerekli entity'ler.
   - OneToMany ve ManyToMany ilişkilerinin yapılandırılması.

5. Entity Konfigurasyonları ve Fake Data Seed İşlemleri
   - EF Core ile entity yapılandırma.
   - Bogus kütüphanesi ile fake veriler oluşturulması.

6. EF Core Code First ile Migration ve Veritabanı Oluşturma
   - Code First yaklaşımıyla migration işlemleri.
   - Veritabanı şeması oluşturulması.

7. Generic Repository
   - CRUD işlemleri için Generic Repository tasarımı.
   - Okuma ve yazma repository'leri.

8. Unit of Work Pattern
   - Unit of Work pattern'ı kullanarak daha dinamik veri erişimi.

9. CQRS ve Mediatr
   - CQRS (Command Query Responsibility Segregation) nedir ve nasıl uygulanır?
   - Mediatr kütüphanesi ile uygulama içi iletişim.

10. AutoMapper Kullanımı
    - Nesneler arası veri aktarımı için AutoMapper kullanımı.
    - AutoMapper kütüphanesinin özelleştirilmesi.

11. Global Exception Handler
    - Global exception handler ile hata yönetimi.

12. Fluent Validation
    - Fluent Validation kütüphanesi ile veri doğrulama işlemleri.

13. Authentication ve Authorization
    - IdentityDbContext ile kullanıcı yönetimi.
    - JWT ile authentication ve authorization işlemleri.

14. Refresh Token ve Access Token Yönetimi
    - JWT ile refresh ve access token yönetimi.

15. Redis ile Performans İyileştirme
    - Redis bağlantısı, RedisService ve RedisPipelineBehavior yapıları.

16. Performans Testleri
    - EFCore, Redis ve MSSQL performans testleri (1 milyon veri).
