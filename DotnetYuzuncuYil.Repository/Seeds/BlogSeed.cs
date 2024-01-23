using DotnetYuzuncuYil.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Repository.Seeds
{
    public class BlogSeed : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasData(
                new Blog
                {
                    Id = 1,
                    Name = "2023'ü Geride Bırakırken",
                    BlogContent = "Yeni bir yıla girerken, 2023'ü büyük bir acı ile başlayıp 100. yıl coşkusuyla uğurladık." +
                    " Türkiye Finans olarak, bu yıl boyunca yenilikçi yapımızın odağına insanı alarak değerli paydaşlarımızla birlikte yoğun bir yıl geçirdik.",
                    BlogCreateDate = DateTime.Now,
                    BlogImage = "https://www.turkiyefinans.com.tr/tr-tr/blog/PublishingImages/2023-detay.jpg",
                    CategoryID = 2,
                    WriterID = 3
                },
               new Blog
               {
                   Id = 2,
                   Name = "Bel inceltme Hareketleri",
                   BlogContent = "İyi görünen insanları diğerlerinden ayıran temel özelliklerden biri ince bir bele sahip olmalarıdır. " +
                   "İnce bir bel estetik açıdan göze daha hoş gelir. İnce olmak ve fit görünmek için çok çalışırız. Bel çevresinde biriken yağlardan tamamen kurtulamayız. " +
                   "Bu yağlardan kurtulmak istiyorsak bel bölgesini hedef alan bazı egzersizler vardır. " +
                   "Bel inceltmek için en hızlı hareketleri evde, hiçbir aparat kullanmadan uygulayabilirsiniz",
                   BlogCreateDate = DateTime.Now,
                   BlogImage = "https://www.skechers.com.tr/blog/wp-content/uploads/2023/05/Bel-inceltme-Hareketleri.jpg",
                   CategoryID = 4,
                   WriterID = 1
               },
                new Blog
                {
                    Id = 3,
                    Name = "Kaplumbağa Terbiyecisi Tablosu Hikayesi ve Anlamı",
                    BlogContent = "Kaplumbağa Terbiyecisi Tablosu, Osman Hamdi Bey tarafından 1906 ve 1907 yıllarında iki farklı çeşidini çizdiği resimlerdir." +
                      "Osmanlı İmparatorluğu Lale Devri’ndeki “Sadabad Eğlenceleri” nde gece bahçelerin aydınlatılması için kaplumbağaların sırtlarına mumlar dikilerek " +
                      "serbest bırakılmaları bilgisi hikaye olarak anlatılır.\r\n\r\nO dönemde kaplumbağalar, dikkat çeken hizmetliler olarak görülür ve eğlencelere dahil edilirdi.",
                    BlogCreateDate = DateTime.Now,
                    BlogImage = "https://www.lavitasarim.com/wp-content/uploads/2020/08/kaplumbaga-terbiyecisi-osman-hamdi-bey-lavi-tasarim.jpg",
                    CategoryID = 1,
                    WriterID = 2
                }
                );
        }
    }
}
