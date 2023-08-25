
using Microsoft.EntityFrameworkCore;


/*EticaretContext context = new();
Urun urun = new();
{
    string UrunAdi = " B �r�n�";
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
    string UrunAdi = " O �r�n�";
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

#region OnConfiguring �le Konfig�rasyon Ayar�n� Geli�tirmek
//EF CORE tool'unu yap�land�rmak i�in kullabd���m�z bir metottur.
//Context nesnesinde override edilerk kullan�lmaktad�r.
#endregion
#region Basit D�zeyde Entity Tan�mlama Kurallar�     
//EF Core, her tablonun default olarak bir primary key kolonu olmas�n� kabul eder !
//Haliyle, bu kolonu temsil eden bir property tan�mlad���m�z taktirde hata verecektir!
#endregion
#region Tablo Ad�n� Belirleme

#endregion
