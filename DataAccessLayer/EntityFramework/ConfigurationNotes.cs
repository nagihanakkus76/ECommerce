using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    internal class ConfigurationNotes
    {
        //  protected override void OnModelCreating(ModelBuilder modelBuilder)
        //
        //Bütün konfigürasyonlar Fluent API ile burada yapılır.Ya da entityler içerisinde  Data Annotationsile yapılır.
        //}

        // HER İKİSİNDE DE YAPILABİLEN KONFİGÜRASYONLAR :

        //***GetEntityTypes()   => tüm entityleri getiren fonksiyondur.
        //  var entities = modelBuilder.Model.GetEntityTypes();

        //***Table-ToTable   => Generate edilecek tablonun ismini belirlememizi sağlayan yapılanmadır.
        //1.yöntem => oluşturulan entitynin başında [Table("TabloAdı")] yazılarak yapılabilir.
        // 2.yöntem => modelBuilder.Entity<User>.ToTable("Users");

        //***Column-HasColumnName-HasCOlumnType-HasColumnOrder => EF tablolarındaki kolonlar sınıflardaki
        //prop lara karşıllık gelmektedir.Default olarak propların adı kolon adıyken türleri kolon
        //türleridir.Generate edilecek kolon isimlerine ve türlerine müdahale edilecekse bu konfigürasyonlar
        //kullanılır.
        //1.yöntem => oluşturulan entitynin başında [Column("ColumnAdı", TypeName="tipAdı")] yazılarak yapılabilir.
        //2.yöntem => modelBuilder.Entity<User>().Property(p => p.UserName)
        //    .HasColumnName("DeğiştirilmekIstenenIsim")
        //    .HasColumnType("text")
        //    .HasColumnOrder(7);

        //***ForeignKey-HasForeignKey  => İlişkisel tablo tasarımlarında esas tabloya karşılık
        //gelecek verilerin tutulduğu kolonu foreign key olarak temsil etmekteyiz.
        //Ef Core da foreign key kolonu genellikle Entity tanımlama kuralları gereği default
        //yapılanmalarla oluşturulur. Tabloları da ilişkilendirmel gerekiyor kullanılacaksa.
        //1.yöntem => oluşturulan entitynin başında [ForeignKey(nameof(Hangi entity nin id si ise o entitynin ismi))] yazılarak yapılabilir.
        //2.yöntem => modelBuilder.Entity<User>()
        //     .HasOne(x => x.Gender).HasForeignKey(x => x.kolonAdıyani hangi kolonun fk olmasını istiyorsak o kolon);

        //***NotMapped-Ignore => EF Core entity sınıfları içerisindeki tüm koloları default olarak
        //modellnen tabloya migrate eder.Bazen entity sınıfları içerisinde bir kolona karşılık gelmeyen
        //proplar tanımlayabiliriz.Bu propların ef core tarafından tablo oluşturmasını engellemek için
        //notmapped ya da Ignore  kullanabiliriz.
        //1.yöntem => oluşturulan entitynin başında [NotMapped()] yazılarak yapılabilir.
        //2.yöntem => modelBuilder.Entity<User>()
        //    .Ignore(p => p.UserName); =>tabloda olmasını istemediğimiz prop ismi yazılır.

        //***Key-HasKey => Ef core da default convention olarak bir entitynin içerisindeki
        //  id , EntityId, EntityID vs. şeklinde tanımlanan tüm proplar varsayılan olarak
        //  primary key constraint uygulanır.
        // Key ya da haskey yapılanmalarıyla istediğimiz herhangi bir propa default convention
        // dışında primarykey uygulayabiliriz.
        //EF core da bir entity içerisinde kesinlikle bir PK'i temsil edecek bir prop bulunmalıdır.
        //Aksi taktirde ef core miration oluştururken hata verecektir.Tablonun Pk'i yoksa bildirmek gerekir.
        //1.yöntem => oluşturulan entitynin başında [Key] yazılarak yapılabilir.
        //2.yöntem =>  modelBuilder.Entity<User>().HasKey(x => x.Password); id olması istenilen prop yazılır.
        // modelBuilder.Entity<User>().HasNoKey(); eğer tablonun PK'i yoksa bu şekilde belirtilir.

        //***Timestamp-IsRowVersion
        //İleride-sonraki derslerde veri tutarlılığı ile ilgili bir ders olacak orada daha detaylı değinilecek.
        //Bir satırdaki verinin bütünsel olarak değişikliğini takip etmemizi sağlayacak olan versiyon mantığı konuşulacak.
        //İşte bir verinin versiyonunu oluşturmamızı sağlayan yapılanma bu konfigürasyonlardır.
        //1.yöntem => oluşturulan entitynin başında [Timestamp] yazılarak yapılabilir.
        //2.yöntem => modelBuilder.Entity<User>().Property(p =>p.RowVersion).IsRowVersion();

        //***Required-IsRequired
        //Bir kolonun nullable ya da nort null olmasını belirleyebiliriz.
        //Ef core da bir prop default olaraknot null şeklinde tanımlanır.Eğer ki prop'i null yapmak istiyorsak
        //türü üzerinde ? operatörü ile bildirimde bulunmamız gerekmektedir.
        //1.yöntem => oluşturulan entitynin başında [Required] yazılarak yapılabilir.
        //2.yöntem => modelBuilder.Entity<User>().Property(p =>p.FirstName).IsRequired();

        //***MaxLenght-StringLenght-HasMaxLenght
        //Bir kolonun max karakter değerini vermemizi sağlar.
        //1.yöntem => oluşturulan entitynin başında [MaxLenght(30)] ya da [StringLenght(30)]  yazılarak yapılabilir.
        //2.yöntem => modelBuilder.Entity<User>().Property(p => p.FirstName).HasMaxLength(30);

        //***Precision-HasPrecision
        //Küsüratlı sayılkarda bir kesinlik belirtmemizi sağlayan ve noktanın hanesini bildirmemizi sağlayan bir yapılanmadır.Virgülden sonra kaç hane olması gerektiğini belirtir.
        //1.yöntem => oluşturulan entitynin başında [Precision(3,2) ]  yazılarak yapılabilir.
        //2.yöntem => modelBuilder.Entity<User>().Property(p => p.FirstName(burada decimal yada double bir tür bulunmalı)).HasPrecision(3,2);

        //***Unicode-IsUnicode
        //kolon içerisinde unicode karakterler kullanılmak istenilirse bu yapıdan faydalanılır.
        //1.yöntem => oluşturulan entitynin başında [Unicode] ]  yazılarak yapılabilir.
        //2.yöntem => modelBuilder.Entity<User>().Property(p => p.FirstName).IsUnicode();

        //***Comment-HasComment
        //Ef Core üzerinden oluştutulmuş olan veritabanı nesneleri üzerinde bir açıklama / yorum yapmak isteniyorsa Comment kullanılabilir.
        //1.yöntem => oluşturulan entitynin başında [Comment("Açıklama yazılır") ]  yazılarak yapılabilir.
        //2.yöntem => modelBuilder.Entity<User>().Property(p => p.FirstName).Comment("Açıklama yazılır.");
        //3.varyant => modelBuilder.Entity<User>().Comment("Açıklama yazılır.").Property(p => p.FirstName).Comment("Açıklama yazılır."); yani Comment istenilen yerde kullanılır.

        //***ConcurrencyCheck-IsConcurrencyToken
        //verinin bütünsel olarak tutarlılığını sağlar. İlerideki derslerde derinlemesine incelinecektir.

        //***InVerseProperty
        //İki entity arasında birden fazla ilişki varsa bu ilişkilerin hangi navigation property üzerinden olacağını ayarlamamızı sağlayan bir konfigurasyondur.
        //kullanım şekli
        //class Flight
        //{
        //    public Airport DepartureAirport { get; set; }
        //    public Airport ArrivalAirport { get; set; }
        //}

        //class Airport
        //{
        //    [InverseProperty(nameof(Flight.DepartureAirport))]
        //    public ICollection<Flight> DepartureAirport { get; set; }

        //    [InverseProperty(nameof(Flight.ArrivalAirport))]
        //    public ICollection<Flight> ArrivalAirport { get; set; }

        //}

        //SADECE FLUENT API ÜZERİNDEN YAPILAN KONFİGÜRASYONLAR:

        //***Composite Key
        //Bir tabloda birden fazla kolonu kümülatif olarak primary key yapmak istiyorsak bunu Composite key ile yapabiliriz.
        // 1.yöntem => modelBuilder.Entity<User>().HasKey("Id","Id2");
        // 2.yöntem => modelBuilder.Entity<User>().HasKey(p => new{p.Id , p.Id2});

        //***HasDefaultSchema
        //Ef Coree üzerinden inşa edilenherhangi bir veritabannı nesnesi default olarak dbo şemasına sahiptir.Bunu özelleştirmek için kullanılan bir yapılanmadır.
        //modelBuilder.HasDefaultSchema("Şema adı yani istenilen şema ismi");

        //***Property
        // modelBuilder.Entity<User>().Property(p => p.Name)
        //*** 1-HasDefaultValue
        //Tablodaki herhangi bir kolonun değer gönderilmediği durumda default olarak hangi değeri alacağını belirler.
        //modelBuilder.Entity<User>().Property(p => p.Name).HasDefaultValue("Ali");

        //*** 2-HasDefaultValueSql
        //Tablodaki herhangi bir kolonun değer gönderilmediği durumda default olarak hangi sql cümleciğinden değeri alacağını belirler.
        //modelBuilder.Entity<User>().Property(p => p.Name).HasDefaultValueSql("GETDATE()"); => Sql fonksiyonlarını verebiliriz.

        //***HasComputedColumnSql
        //Tablolarda birden fazla kolondaki verileri işleyerek değerini oluşturan kolonlara computed column denir.
        //Ef Core üzerinden bu tarz computed column oluşturabilmek için kullanılan bir yapılanmadır.

        //class Example
        //{
        //    public int Id { get; set; }
        //    public int X { get; set; }
        //    public int Y { get; set; }
        //    public int Computed { get; set; }
        //}
        //modelBuilder.Entity<Example>().Property(p => p.Computed).HasComputedColumnSql("[X] + [Y]");

        //***HasConstraintName
        //Ef croe üzerinden oluşturulan constraintlere default isim yerine özelleştirilmiş bir isim verebilmek için kullanılan yapılanmadır.
        //modelBuilder.Entity<Person>()
        //.HasOne(p => p.Department)
        //.WithMany(d => d.Persons)
        //.HasForeignKey(p => p.DepartmentId)
        //.HasConstraintName("DId");

        //***HasData
        //Seed Data işleminde kullanılır.Migrate sürecinde veritabanını inşa ederken bir yandan da yazılım üzerinden hazır veriler oluşturmak istiyorsak
        //eğer seed data kullanıırız.İşte HasData konfigürasyonu bu operasyonun yapılandırma ayağıdır.
        //HasData ile migrate sürecinde oluşturulacak olan verilerin pk olan id kolonlarına iradeli bir şekilde değerlerin verilmesi zorunludur!!!!!

        // modelBuilder.Entity<Gender>()
        //.HasData(
        //new Gender() { ID = 1, Name = "Kadın" },
        //new Gender() { ID = 2, Name = "Erkek" });


        //***HasDiscriminator
        //ileride entitylerin arasında kalıtımsal olduğu TPT ve TPH isminde konuları inceliyor olacağız.
        //İşte bu konularla ilgili yapılandırmalarımız HasDiscriminator ve HasValue fonksiyonlarıdır.
        //modelBuilder.Entity<Entity(Base Entity ismi)>()
        //.HasDiscriminator<stirng(istenilen tür)>("Ayırıcı")
        //.HasValue<A(Devided entity adı)>(1);
        //.HasValue<B(Devided entity adı)>(2);
        //.HasValue<Entity(Base entity adı)>(3);

        //***HasValue

        //***HasField
        //Backing Field özelliğini kullanmamızı sağlayan bir yapılanmadır.
        // modelBuilder.Entity<Person>().Property(p => p.Name).HasField(nameof(Person.name));

        //***HasNoKey
        //Normal şartlarda Ef Core'da tüm entitylerin bir PK kolonu olmak zorundadır.Eğerki entity'de PK kolonu olmayacaksa bunun bildirilmesi gerekmektedir.
        //İşte bu bildirim için kullanılan fonksiyondur. 
        // modelBuilder.Entity<Person>().HasNoKey();

        //***HasIndex
        //Sonraki derslerde Ef core üzerinden Index yapılanmasını detaylıca inceliyor olacağız.
        //Bu yapılanmaya dair konfigürasyonlarımız HasIndex ve Index Attribute'dur.
        // modelBuilder.Entity<Person>().HasIndex(p => p.Name)
        // modelBuilder.Entity<Person>().HasIndex(p =>new (p.Name, p.Surname)) => birden fazla indexleme yapılacaksa bu şekilde kullanılır.

        //***HasQuaryFilter
        //ieride göreceğimiz Global Query Filter başlıklı dersimizin yapılandırmasıdır.
        //Temeldeki görevi bir entitye karşılık uygulama bazında global bir filtre koymaktır.
        // modelBuilder.Entity<Person>()
        // .HasQuaryFilter(p => p.Active == true)

        // DataBaseGenerated - ValueGeneratedOnAddOrUpdate , ValueGeneratedOnAdd , ValueGeneratedNever

    }
}
