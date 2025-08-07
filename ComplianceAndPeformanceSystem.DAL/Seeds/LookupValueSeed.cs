using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Seeds;

public class LookupValueSeed : IEntityTypeConfiguration<LookupValue>
{
    public void Configure(EntityTypeBuilder<LookupValue> builder)
    {
        builder.HasData(new List<LookupValue>()
        {
              #region Licensed Entity
new LookupValue()
{
    Id = 1,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Red Sea Joint Facilities",
    ValueAr = "مرافق البحر الأحمر المشتركة",
    LicenseNumber = "LIC-2025-01-0001"
},
new LookupValue()
{
    Id = 2,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "NEOM",
    ValueAr = "نيوم",
    LicenseNumber = "LIC-2025-01-0002"
},
new LookupValue()
{
    Id = 3,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "National Water Company",
    ValueAr = "شركة المياه الوطنية",
    LicenseNumber = "LIC-2025-01-0003"
},
new LookupValue()
{
    Id = 4,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Al-Fath International Water and Electricity Works Company",
    ValueAr = "شركة الفتح الدولية لأعمال المياه والكهرباء",
    LicenseNumber = "LIC-2025-01-0004"
},
new LookupValue()
{
    Id = 5,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Public Corporation for Potable Water Conversion",
    ValueAr = "المؤسسة العامة لتحلية مياه الشرب",
    LicenseNumber = "LIC-2025-01-0005"
},
new LookupValue()
{
    Id = 6,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Al-Rakab Electricity Company in Jubail and Yanbu",
    ValueAr = "شركة الركاب للكهرباء في الجبيل وينبع",
    LicenseNumber = "LIC-2025-01-0006"
},
new LookupValue()
{
    Id = 7,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Shaiba Project Company for Water Development",
    ValueAr = "شركة مشروع شيبة لتنمية المياه",
    LicenseNumber = "LIC-2025-01-0007"
},
new LookupValue()
{
    Id = 8,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Third Sister Company",
    ValueAr = "الشركة الشقيقة الثالثة",
    LicenseNumber = "LIC-2025-01-0008"
},
new LookupValue()
{
    Id = 9,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Rabigh Third Company",
    ValueAr = "شركة رابغ الثالثة",
    LicenseNumber = "LIC-2025-01-0009"
},
new LookupValue()
{
    Id = 10,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Saudi Water Partnership Company",
    ValueAr = "الشركة السعودية لشراكات المياه",
    LicenseNumber = "LIC-2025-01-0010"
},
new LookupValue()
{
    Id = 11,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Al-Alam Scientific Station Company",
    ValueAr = "شركة محطة العلم العلمية",
    LicenseNumber = "LIC-2025-01-0011"
},
new LookupValue()
{
    Id = 12,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Jazalah Company",
    ValueAr = "شركة جزالة",
    LicenseNumber = "LIC-2025-01-0012"
},
new LookupValue()
{
    Id = 13,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Canada",
    ValueAr = "كندا",
    LicenseNumber = "LIC-2025-01-0013"
},
new LookupValue()
{
    Id = 14,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "SWACO",
    ValueAr = "سواكو",
    LicenseNumber = "LIC-2025-01-0014"
},
new LookupValue()
{
    Id = 15,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Shas Contracting",
    ValueAr = "شركة شاس للمقاولات",
    LicenseNumber = "LIC-2025-01-0015"
},
new LookupValue()
{
    Id = 16,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Shas Water Services",
    ValueAr = "شركة شاس لخدمات المياه",
    LicenseNumber = "LIC-2025-01-0016"
},
new LookupValue()
{
    Id = 17,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Durar Absher",
    ValueAr = "درر أبشر",
    LicenseNumber = "LIC-2025-01-0017"
},
new LookupValue()
{
    Id = 18,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Abdulaziz bin Othman bin Salma and Partners Water Company",
    ValueAr = "شركة عبد العزيز بن عثمان بن سلمة وشركاؤه للمياه",
    LicenseNumber = "LIC-2025-01-0018"
},
new LookupValue()
{
    Id = 19,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Abdulaziz bin Othman bin Salma and Partners for Trade",
    ValueAr = "شركة عبد العزيز بن عثمان بن سلمة وشركاؤه للتجارة",
    LicenseNumber = "LIC-2025-01-0019"
},
new LookupValue()
{
    Id = 20,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Contracting and Transport",
    ValueAr = "المقاولات والنقل",
    LicenseNumber = "LIC-2025-01-0020"
},
new LookupValue()
{
    Id = 21,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Abdullah Mohammed Al-Saad Water Desalination Establishment",
    ValueAr = "مؤسسة عبد الله محمد السعد لتحلية المياه",
    LicenseNumber = "LIC-2025-01-0021"
},
new LookupValue()
{
    Id = 22,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Abdulrazaq Al-Abdulkarim Ali bin Abdulrazaq Al-Abdulkarim Contracting Establishment",
    ValueAr = "مؤسسة عبد الرزاق العبد الكريم علي بن عبد الرزاق العبد الكريم للمقاولات",
    LicenseNumber = "LIC-2025-01-0022"
},
new LookupValue()
{
    Id = 23,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Hassan Abdullah Al-Amari",
    ValueAr = "حسن عبد الله العماري",
    LicenseNumber = "LIC-2025-01-0023"
},
new LookupValue()
{
    Id = 24,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Yanbu International Aviation Company",
    ValueAr = "شركة ينبع الدولية للطيران",
    LicenseNumber = "LIC-2025-01-0024"
},
new LookupValue()
{
    Id = 25,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Water Transport and Technology Company",
    ValueAr = "شركة نقل وتقنية المياه",
    LicenseNumber = "LIC-2025-01-0025"
},
new LookupValue()
{
    Id = 26,
    CategoryId = 1,
    CreatedOn = new DateTime(2025,1,1),
    ModifiedOn = new DateTime(2025,1,1),
    ValueEn = "Another",
    ValueAr = "أخرى",
    LicenseNumber = "LIC-2025-01-0026"
},
#endregion

            #region Activity

            new LookupValue()
            {
                Id = 27,
                CategoryId = 2,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Desalinated water production",
                ValueAr = "إنتاج المياه المحلاة"
            },

            new LookupValue()
            {
                Id = 28,
                CategoryId = 2,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Wastewater treatment",
                ValueAr = "معالجة مياه الصرف الصحي"
            }, 
            new LookupValue()
            {
                Id = 29,
                CategoryId = 2,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Strategic storage",
                ValueAr = "التخزين الاستراتيجي"
            },
            new LookupValue()
            {
                Id = 30,
                CategoryId = 2,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Purified water production",
                ValueAr = "إنتاج المياه النقية"
            },
             new LookupValue()
            {
                Id = 31,
                CategoryId = 2,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Strategic storage",
                ValueAr = "التخزين الاستراتيجي"
            },
            new LookupValue()
            {
                Id = 32,
                CategoryId = 2,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Desalinated and purified water distribution",
                ValueAr = "توزيع المياه المحلاة والمنقاة"
            },
            new LookupValue()
            {
                Id = 33,
                CategoryId = 2,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Main buyer",
                ValueAr = "المشتري الرئيسي"
            },
            new LookupValue()
            {
                Id = 34,
                CategoryId = 2,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Mini-stations",
                ValueAr = "المحطات الصغيرة"
            },
           
            #endregion

            #region Plant Name
            new LookupValue()
            {
                Id = 35,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "RO",
                ValueAr = "RO"
            },
            new LookupValue()
            {
                Id = 36,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "STP1",
                ValueAr = "محطة معالجة مياه الصرف الصحي ١"
            },
            new LookupValue()
            {
                Id = 37,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Duba Station",
                ValueAr = "محطة ضباء"
            },

            new LookupValue()
            {
                Id = 38,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Saad Station",
                ValueAr = "محطة سعد"
            },

            new LookupValue()
            {
                Id = 39,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Al Khobar Station 1",
                ValueAr = "محطة الخبر ١"
            },

            new LookupValue()
            {
                Id = 40,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Al Khobar Station 2",
                ValueAr = "محطة الخبر ٢"
            },

            new LookupValue()
            {
                Id = 41,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Breiman Phase 1 and 2",
                ValueAr = "بريمان - المرحلة ١ و٢"
            },

            new LookupValue()
            {
                Id = 42,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "TBD",
                ValueAr = "لم يُحدد بعد"
            },

            new LookupValue()
            {
                Id = 43,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Arar Tanks",
                ValueAr = "خزانات عرعر"
            },

            new LookupValue()
            {
                Id = 44,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Turaif Tanks",
                ValueAr = "خزانات طريف"
            },

            new LookupValue()
            {
                Id = 45,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Al Narjis Project",
                ValueAr = "مشروع النرجس"
            },

            new LookupValue()
            {
                Id = 46,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Abha (Umm Al Rukb)",
                ValueAr = "أبها (أم الركب)"
            },

            new LookupValue()
            {
                Id = 47,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Baljurashi Tank",
                ValueAr = "خزان بلجرشي"
            },

            new LookupValue()
            {
                Id = 48,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Jazan Tank",
                ValueAr = "خزان جازان"
            },

            new LookupValue()
            {
                Id = 49,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Al Fateh Seawater Desalination Plant",
                ValueAr = "محطة تحلية مياه البحر الفاتح"
            },

            new LookupValue()
            {
                Id = 50,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Jeddah RO3",
                ValueAr = "جدة RO٣"
            },

            new LookupValue()
            {
                Id = 51,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Al Khobar RO 2",
                ValueAr = "محطة تحلية مياه الخبر RO٢"
            },

            new LookupValue()
            {
                Id = 52,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Jubail Industrial City SWRO Stage 1",
                ValueAr = "محطة تحلية مياه البحر في مدينة الجبيل الصناعية - المرحلة ١"
            },

            new LookupValue()
            {
                Id = 53,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Stage 2-3",
                ValueAr = "المرحلتان ٢-٣"
            },

            new LookupValue()
            {
                Id = 54,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Stage 5",
                ValueAr = "المرحلة ٥"
            },

            new LookupValue()
            {
                Id = 55,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Drinking Water Network",
                ValueAr = "شبكة مياه الشرب"
            },

            new LookupValue()
            {
                Id = 56,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Yanbu PRW Tanks at PSDP-6",
                ValueAr = "خزانات مياه ينبع العامة في مشروع تطوير مياه الشعيبة - المرحلة السادسة"
            },

            new LookupValue()
            {
                Id = 57,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Shuaiba 2nd Water Development Project Company",
                ValueAr = "شركة مشروع تطوير مياه الشعيبة الثاني"
            },

            new LookupValue()
            {
                Id = 58,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Al Shuqaiq 3rd Water Company",
                ValueAr = "شركة الشقيق الثالثة للمياه"
            },

            new LookupValue()
            {
                Id = 59,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Rabigh 3rd Company",
                ValueAr = "شركة رابغ الثالثة"
            },

            new LookupValue()
            {
                Id = 60,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Contracts",
                ValueAr = "العقود"
            },

            new LookupValue()
            {
                Id = 61,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Taif Independent Water Plant",
                ValueAr = "محطة مياه الطائف المستقلة"
            },

            new LookupValue()
            {
                Id = 62,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Jazlah Station",
                ValueAr = "محطة جزلة"
            },

            new LookupValue()
            {
                Id = 63,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Rabigh Station",
                ValueAr = "محطة رابغ"
            },

            new LookupValue()
            {
                Id = 64,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Jeddah Islamic Port Station",
                ValueAr = "محطة ميناء جدة الإسلامي"
            },

            new LookupValue()
            {
                Id = 65,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "North Obhur",
                ValueAr = "أبحر الشمالية"
            },

            new LookupValue()
            {
                Id = 66,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Shaas Water Production and Treatment Plant",
                ValueAr = "محطة إنتاج ومعالجة مياه شآس"
            },

            new LookupValue()
            {
                Id = 67,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = " Shaas Water Services Company Limited",
                ValueAr = "شركة شآس لخدمات المياه المحدودة"
            },

            new LookupValue()
            {
                Id = 68,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Al Muqbil Desalination Plant",
                ValueAr = "محطة تحلية المقبل"
            },

            new LookupValue()
            {
                Id = 69,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Abdulaziz Bin Salma Company",
                ValueAr = "شركة عبد العزيز بن سلمى"
            },

            new LookupValue()
            {
                Id = 70,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Abdulaziz Bin Salma Company, Saad Station",
                ValueAr = "شركة عبد العزيز بن سلمى، محطة سعد"
            },

            new LookupValue()
            {
                Id = 71,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Abdulkarim Station",
                ValueAr = "محطة عبد الكريم"
            },

            new LookupValue()
            {
                Id = 72,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Station 1",
                ValueAr = "المحطة ١"
            },

            new LookupValue()
            {
                Id = 73,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Yanbu Independent Water Production Plant",
                ValueAr = "محطة ينبع المستقلة لإنتاج المياه"
            },

            new LookupValue()
            {
                Id = 74,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Jubail System",
                ValueAr = "شبكة الجبيل"
            },

            new LookupValue()
            {
                Id = 75,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "System Ras Al Khair",
                ValueAr = "نظام رأس الخير"
            },

            new LookupValue()
            {
                Id = 76,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Yanbu - Madinah System",
                ValueAr = "نظام ينبع - المدينة المنورة"
            },

            new LookupValue()
            {
                Id = 77,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Shaqiq Transport System",
                ValueAr = "نظام نقل الشقيق"
            },

            new LookupValue()
            {
                Id = 78,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Shuaiba Transport System",
                ValueAr = "نظام نقل الشعيبة"
            },

            new LookupValue()
            {
                Id = 79,
                CategoryId = 3,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Rabigh Transport System",
                ValueAr = "نظام نقل رابغ"
            },

            #endregion

            #region Location
            new LookupValue()
            {
                Id = 80,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Umluj",
                ValueAr="أملج"
            },

            new LookupValue()
            {
                Id = 81,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Duba",
                ValueAr="ضباء"
            },

            new LookupValue()
            {
                Id = 82,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Saad",
                ValueAr="سعد"
            },

            new LookupValue()
            {
                Id = 83,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Al-Madinah",
                ValueAr="المدينة المنورة"
            },

            new LookupValue()
            {
                Id = 84,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Arar",
                ValueAr="عرعر"
            },

            new LookupValue()
            {
                Id = 85,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Tarif",
                ValueAr="طريف"
            },

            new LookupValue()
            {
                Id = 86,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Riyadh",
                ValueAr="الرياض"
            },

            new LookupValue()
            {
                Id = 87,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Abha",
                ValueAr="أبها"
            },

            new LookupValue()
            {
                Id = 88,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Al-Baha",
                ValueAr="الباحة"
            },

            new LookupValue()
            {
                Id = 89,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Jazan",
                ValueAr="جازان"
            },

            new LookupValue()
            {
                Id = 90,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Jeddah",
                ValueAr="جدة"
            },

            new LookupValue()
            {
                Id = 91,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Al-Khobar",
                ValueAr="الخبر"
            },

            new LookupValue()
            {
                Id = 92,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Rabigh",
                ValueAr="رابغ"
            },

            new LookupValue()
            {
                Id = 93,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Taif",
                ValueAr="الطائف"
            },

            new LookupValue()
            {
                Id = 94,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Jubail",
                ValueAr="الجبيل"
            },

            new LookupValue()
            {
                Id = 95,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Rabigh",
                ValueAr="رابغ"
            },

            new LookupValue()
            {
                Id = 96,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Jeddah",
                ValueAr="جدة"
            },

            new LookupValue()
            {
                Id = 97,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Ras Al-Khair",
                ValueAr="رأس الخير"
            },

            new LookupValue()
            {
                Id = 98,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Yanbu-Al-Madinah",
                ValueAr="ينبع-المدينة المنورة"
            },

            new LookupValue()
            {
                Id = 99,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Al-Shaqiq",
                ValueAr="الشقيق"
            },

            new LookupValue()
            {
                Id = 100,
                CategoryId = 4,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Al-Shuaiba",
                ValueAr="الشعيبة"
            },
            #endregion
        
            #region Quarter Planned For Visit
            new LookupValue()
            {
                Id = 101,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "First Quarter - January",
                ValueAr = "الربع الأول - يناير"
            },

            new LookupValue()
            {
                Id = 102,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "First Quarter - February",
                ValueAr = "الربع الأول - فبراير"
            },

             new LookupValue()
            {
                Id = 103,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "First Quarter - March",
                ValueAr = "الربع الأول - مارس"
            },

            new LookupValue()
            {
                Id = 104,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Second Quarter - April",
                ValueAr = "الربع الثاني - ابريل"
            },

            new LookupValue()
            {
                Id = 105,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Second Quarter - May",
                ValueAr = "الربع الثاني - مايو"
            },

            new LookupValue()
            {
                Id = 106,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Second Quarter - June",
                ValueAr = "الربع الثاني - يونية"
            },

            new LookupValue()
            {
                Id = 107,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Third Quarter - July",
                ValueAr = "الربع الثالث - يوليو"
            },

            new LookupValue()
            {
                Id = 108,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Third Quarter - August",
                ValueAr = "الربع الثالث - اغسطس"
            },
            new LookupValue()
            {
                Id = 109,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Third Quarter - September",
                ValueAr = "الربع الثالث - سيبتمبر"
            },
             new LookupValue()
            {
                Id = 110,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Forth Quarter - October",
                ValueAr = "الربع الرابع - اكتوبر"
            },

            new LookupValue()
            {
                Id = 111,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Forth Quarter - November",
                ValueAr = "الربع الرابع - نوفمبر"
            },

               new LookupValue()
            {
                Id = 112,
                CategoryId = 5,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn = "Forth Quarter - December",
                ValueAr = "الربع الرابع - ديسمبر"
            },

            #endregion

            #region Visit Type
            new LookupValue()
            {
                Id = 113,
                CategoryId = 6,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="routine",
                ValueAr = "روتينية"
            },

            new LookupValue()
            {
                Id = 114,
                CategoryId = 6,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="follow-up",
                ValueAr = "متابعة"
            },


            new LookupValue()
            {
                Id = 115,
                CategoryId = 6,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="complaint",
                ValueAr = "شكوى"
            },
            
            #endregion

            #region Plan Status
            new LookupValue()
            {
                Id = 116,
                CategoryId = 7,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="New",
                ValueAr = "جديد"
            },

            new LookupValue()
            {
                Id = 117,
                CategoryId = 7,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Pending Review  the Compliance Manager",
                ValueAr = "قيد الانتظار والمراجعة مدير الاداره"
            },

            new LookupValue()
            {
                Id = 118,
                CategoryId = 7,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Pending Review the Performance Monitoring Manager",
                ValueAr = "قيد الانتظار والمراجعة مدير عام مراجعة الاداء"
            },

            new LookupValue()
            {
                Id = 119,
                CategoryId = 7,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Approval of Compliance Manager",
                ValueAr = "قبول المدير الادارة"
            },

            new LookupValue()
            {
                Id = 120,
                CategoryId = 7,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Approval of the Performance Monitoring Manager",
                ValueAr = "قبول مدير عام مراجعة الاداء"
            },

            new LookupValue()
            {
                Id = 121,
                CategoryId = 7,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Return Plan of Compliance Manager",
                ValueAr = "ارجاع من المدير الادارة"
            },


            new LookupValue()
            {
                Id = 122,
                CategoryId = 7,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Return Plan of the Performance Monitoring Manager",
                ValueAr = "ارجاع من مدير عام مراجعة الاداء"
            },
            #endregion
         
            
            #region Visit Status
            new LookupValue()
            {
                Id = 123,
                CategoryId = 8,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Scheduled",
                ValueAr = "مجدولة"
            },

            new LookupValue()
            {
                Id = 124,
                CategoryId = 8,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Rescheduled",
                ValueAr = "تمت إعادة جدولة"
            },

            new LookupValue()
            {
                Id = 125,
                CategoryId = 8,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Conflict Of Interest Disclosure",
                ValueAr = "الإفصاح عن تضارب المصالح"
            },

            new LookupValue()
            {
                Id = 126,
                CategoryId = 8,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="New",
                ValueAr = "جديد"
            },
            new LookupValue()
            {
                Id = 127,
                CategoryId = 8,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="RescheduleRequested",
                ValueAr = "طلب إعادة جدولة"
            },
            new LookupValue()
            {
                Id = 128,
                CategoryId = 8,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Completed",
                ValueAr = "مكتملة"
            },
            new LookupValue()
            {
                Id = 129,
                CategoryId = 8,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Cancelled",
                ValueAr = "ملغية"
            },

            #region Figma Part 2 unmerged
            new LookupValue()
            {
                Id = 130,
                CategoryId = 8,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Conflict Of Interest Resolved",
                ValueAr = "تم حل تضارب المصالح"
            },

            new LookupValue()
            {
                Id = 131,
                CategoryId = 8,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="No Team Member Available",
                ValueAr = "لا يوجد عضو فريق متاح"
            },
            #endregion
            #endregion

            #region Attachment Type
            new LookupValue()
            {
                Id = 132,
                CategoryId = 9,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="VisitAttachment",
                ValueAr = "مرفقات الزيارة"
            },

            new LookupValue()
            {
                Id = 133,
                CategoryId = 9,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="ReportSendAttachment",
                ValueAr = "المرفقات التابعة للتقارير"
            },

            new LookupValue()
            {
                Id = 134,
                CategoryId = 9,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="ReportReplyAttachment",
                ValueAr = "المرفقات الرد للتقارير"
            },

           
            #endregion

            #region Report Type 
            new LookupValue()
            {
                Id = 135,
                CategoryId = 10,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="أولي",
                ValueAr = "Initial "
            },
            new LookupValue()
            {
                Id = 136,
                CategoryId = 10,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="نهائي",
                ValueAr = "Final "
            },
            #endregion

            #region Compleated Status 
            new LookupValue()
            {
                Id = 137,
                CategoryId = 11,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="مكتملة",
                ValueAr = "Compleated "
            },
            new LookupValue()
            {
                Id = 138,
                CategoryId = 11,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="متوقفة",
                ValueAr = "Remaining "
            },
            #endregion

            #region Attachment Type
            new LookupValue()
            {
                Id = 139,
                CategoryId = 9,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="ReportAttachment",
                ValueAr = "مرفقات التقارير"
            },
            new LookupValue()
            {
                Id = 140,
                CategoryId = 9,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="CorrectPlanAttachment",
                ValueAr = "مرفقات الخطة التصحيحية"
            },

            #endregion

            #region Plan Status
            new LookupValue()
            {
                Id = 141,
                CategoryId = 7,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Compliance Specialist Preparing Delayed",
                ValueAr = "أخصائي الامتثال متاخر في اعداد الخطة"
            },
            new LookupValue()
            {
                Id = 142,
                CategoryId = 7,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Compliance Manager Overdue",
                ValueAr = "مدير الامتثال متاخر"
            },
            new LookupValue()
            {
                Id = 143,
                CategoryId = 7,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Peformance Monitoring Manager Overdue",
                ValueAr = "مدير مراقبة الأداء متأخر"
            },
            #endregion

            #region Template Type
            new LookupValue()
            {
                Id = 144,
                CategoryId = 12,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="Email",
                ValueAr = "البريد الالكتروني"
            },
            new LookupValue()
            {
                Id = 145,
                CategoryId = 12,
                CreatedOn = new DateTime(2025,1,1),
                ModifiedOn = new DateTime(2025,1,1),
                ValueEn="SMS",
                ValueAr = "رسائل نصية"
            },
            #endregion
        });

    }

}
