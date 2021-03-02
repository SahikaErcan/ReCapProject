# ReCapProject

> ## _'Araba Kiralama Sistemi'_ çok katmanlı ve SOLID prensiplerine dayalı bir projedir.
- *Kurumsal bir projeye başlarken _Blank Solution_ (Boş Çözüm) şeklinde projemizi oluşturuyoruz. . Bir çözüm, birbirleri ile ilişkili projeleri (DataAccess,Business gibi.) düzenlemek için kullanılan bir kapsayıcıdır.*
> _Blank Solution_ (Boş Çözüm) : Adına rağmen çözüm bir "yanıt" değildir. Bir çözüm, yalnızca bir veya daha fazla ilgili projeyi düzenlemek için Visual Studio tarafından kullanılan bir kapsayıcıdır. Visual Studio 'da bir çözüm açtığınızda, çözüm içerdiği tüm projeleri otomatik olarak yükler.
- *Oluşturduğumuz boş çözüme katmanlar(projeler) ekliyoruz. Proje oluştururken "Class Library(.NET Standard)" standardını seçerek _Entities, DataAccess_ ve _Business_ olarak isimlendirdiğimiz katmanları oluşturuyoruz. Projeyi test etme amacıyla _ConsoleUI_ olarak isimlendirdiğimiz "Console App(.Net Core)" oluşturuyoruz.* 

## Katmalar

![xx1](https://user-images.githubusercontent.com/72580629/109650096-d2031080-7b6d-11eb-98fe-c56cfcad1fc8.JPG) 

###### DataAccess (*Veri Erişim Katmanı*) : Sadece veriye erişmek için gerekli kodlar yazılır. Veriye erişmek için farklı teknikler vardır. İhtiyaca bağlı farklı teknikler kullanmak durumunda kalabiliriz. Uygulamada yapacağımız teknik değişikliklerden diğer projelerin etkilenmesi ve istenilen kod bloğuna erişim kolaylığı sağlamak amacı ile katmanlar kullanıyoruz.
###### Business (*İş Katmanı*) : Kuralları yazdığımız yer.
###### Entities (*Yardımcı Katman*) : Tüm katmanlarda kullanabileceğimiz yapıları bu katmanda bulundururuz.
###### ConcoleUI (*API*) : Business, DataAccess ve Enities katmanlarını API katmanı ile dış dünyaya aktarırız.

**ConsoleUI hariç tüm katmanlara _Abstract_ ve _Concrete_ klasörleri ekliyoruz.**

![xx2](https://user-images.githubusercontent.com/72580629/109654402-35437180-7b73-11eb-8ed1-21fc43a8036d.JPG)

###### Abstract : Soyut nesneleri yani interface'leri, abstract nesneleri ve base classları bu klasörün içine ekleyeceğiz.
###### Concrete : Somut nesneleri yani gerçek işi yapan class'ları bu klasörün içine ekleyeceğiz.

:exclamation: Oluşturduğumuz class'ları "_**public**_" yapmalıyız ki diğer katmanlar da bu class'lara erişim hakkı kazansınlar. Çünkü DataAccess ürünü ekleyecek ise Business ürünü kontrol edecektir. ConsoleUI de ürünü gösterecektir.
