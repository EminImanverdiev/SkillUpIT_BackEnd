# Kurs İdarəetmə Sistemi (Education CRM)

Bu layihə, kurs tədrisi üçün tələbə, müəllim və adminlərin idarə olunmasını təmin edən bir sistemdir. Sistem **Onion Architecture** istifadə edilərək yazılıb və C# dili ilə hazırlanmışdır.

---

## Layihə Haqqında

Bu layihənin əsas məqsədi kurs proseslərini rəqəmsal idarə etməkdir. Sistem vasitəsilə:
- **Adminlər** sistemdə yeni istifadəçilər yarada, dərsliklər əlavə edə və idarə edə bilərlər.
- **Müəllimlər** şagirdlərin fəaliyyəti və dərs materiallarını idarə edə bilərlər.
- **Tələbələr** dərs materiallarına daxil ola və tapşırıqları yerinə yetirə bilərlər.

---

## Texnologiyalar

Layihədə istifadə edilən əsas texnologiyalar:
- **Backend:** C#, ASP.NET Core  
- **Arxitektura:** Onion Architecture  
- **Verilənlər Bazası:** MS SQL Server  
- **JWT Authentication:** İstifadəçi autentifikasiyası üçün  
- **Entity Framework Core:** ORM idarəetməsi üçün  

---

## Funksionallıqlar

### Admin Rolu:
- Yeni istifadəçilər əlavə etmək (müəllimlər və tələbələr).
- İstifadəçi məlumatlarını redaktə etmək və ya silmək.
- Dərslikləri və tapşırıqları idarə etmək.

### Müəllim Rolu:
- Şagirdlərin fəaliyyətini izləmək.
- Tapşırıqlar və dərs materialları əlavə etmək.
- Şagirdlərin nəticələrini qiymətləndirmək.

### Tələbə Rolu:
- Öz profilini idarə etmək.
- Dərsliklərə və tapşırıqlara baxmaq.
- Müəllimlər tərəfindən təyin olunan tapşırıqları yerinə yetirmək.

---

## Layihənin Strukturu

```
|-- Core
|   |-- SkillUpIT.Application
|   |-- SkillUpIT.Domain
|
|-- Infrastructure
|   |-- SkillUpIT.Infrastructure
|   |-- SkillUpIT.Persistence
|
|-- Presentation
|   |-- SkillUpIT.API
```

- **Core**: Tətbiq və domen qatları (entitilər, interfeyslər, servis logikası).
- **Infrastructure**: Verilənlər bazası əlaqələri və xidmətlərin implementasiyası.
- **Presentation**: API layer (controller-lər).

---

## İstifadəçi Rolları və İcazələr
Layihə JWT ilə avtorizasiyanı dəstəkləyir. Rollar aşağıdakı kimidir:
- **Admin:** Tam icazələr.
- **Müəllim:** Yalnız müəllim funksionallıqları.
- **Tələbə:** Öz məlumatlarına və dərsliklərə çıxış.

---

## Əlaqə
Əgər hər hansı sualınız və ya təklifiniz varsa, mənimlə əlaqə saxlaya bilərsiniz:
- **E-poçt:** emin.imanverdievv@gmail.com  
- **GitHub:** https://github.com/EminImanverdiev/SkillUpIT_BackEnd.git
