
using Microsoft.EntityFrameworkCore;


/*EticaretContext context = new();
Urun urun = new();
{
    string UrunAdi = " B ürünü";
    int Fiyat = 2000;
};

Console.WriteLine(context.Entry(urun).State);


await context.AddRangeAsync(urun);

Console.WriteLine(context.Entry(urun).State);
await context.SaveChangesAsync();
Console.WriteLine(context.Entry(urun).State); */

EticaretContext context = new();
Urun urun1 = new();
{
    string UrunAdi = " O ürünü";
    int Fiyat = 2000;
};

await context.AddAsync(urun1);
await context.SaveChangesAsync();

Console.WriteLine(urun1.UrunID);





public class EticaretContext : DbContext
{
    public DbSet<Urun>  Urunler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=EticaretDb;TrustServerCertificate=True;Encrypt=False;Trusted_Connection=True;Trusted_Connection=True");
       //Provider
       //ConnectionString
       //Lazy Loading
       //vb.

    }
}
public class Urun
{
    // public int Id { get; set; }
    //public int ID { get; set; }
    //public int UrunId { get; set; }
    public int UrunID { get; set; }

}

#region OnConfiguring Ýle Konfigürasyon Ayarýný Geliþtirmek
//EF CORE tool'unu yapýlandýrmak için kullabdýðýmýz bir metottur.
//Context nesnesinde override edilerk kullanýlmaktadýr.
#endregion
#region Basit Düzeyde Entity Tanýmlama Kurallarý     
//EF Core, her tablonun default olarak bir primary key kolonu olmasýný kabul eder !
//Haliyle, bu kolonu temsil eden bir property tanýmladýðýmýz taktirde hata verecektir!
#endregion
#region Tablo Adýný Belirleme

#endregion
