# KuaforRandevu

Kuaför/güzellik salonları için randevu yönetim sistemi. ASP.NET Core ile N-Tier mimari kullanılarak geliştirildi; müşteri tarafı randevu alma akışının yanında, salon yönetimi için ayrı bir CMS/yönetim paneli içerir.

## Teknoloji Stack

- ASP.NET Core
- Entity Framework Core (Code-First migrations)
- MSSQL
- Repository Pattern / N-Tier mimari
- View Component tabanlı modüler arayüz (Breadcrumb, Chat, CmsService, Widget)

## Proje Yapısı

```
KuaforRandevu/
├── EntityLayer/          # Domain modelleri (Appointment, Customer, Employee, Service, ...)
├── DataAccessLayer/      # DbContext, Repository implementasyonları, migrations
├── BusinessLayer/        # Servisler, iş kuralları
└── KuaforRandevu/         # Web (Controllers, Views, Areas/Cms, wwwroot)
```

## Yönetim Paneli (Areas/Cms)

Salon yönetimi için ayrı bir ASP.NET Core Area olarak tutulan admin paneli:

- **AdminCrudBaseController** — ortak CRUD işlemleri için taban controller
- **CmsController / CustomerController** — içerik ve müşteri yönetimi
- **ViewComponents** — Breadcrumb, Chat, CmsService, Widget gibi yeniden kullanılabilir arayüz bileşenleri

## Kurulum

```bash
git clone https://github.com/ridvancomez/KuaforRandevu.git
cd KuaforRandevu
dotnet restore
dotnet ef database update --project DataAccessLayer --startup-project KuaforRandevu
dotnet run --project KuaforRandevu
```

## Durum

🚧 Aktif geliştirme aşamasında.
