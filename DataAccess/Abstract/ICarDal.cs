using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    /** Car ile ilgili veritabanında yapacağım silme, ekleme, güncelleme, listeleme, gibi
      * operasyonları içeren interface **/
    /* Operasyonları gerçekleştirmek için kullanılacak vertabanı "Entities" katmanında bu
     * nedenle başka bir katman kullanmak istiyorsak referans vermeliyiz.
      "DataAccess > Add > Project Referance... ı açıyoruz ve ilgili katmanları (Entities) seçiyoruz."*/
    /* Bu referans olayı ile DataAccess katmanı, Entities Katmanındaki "Car, Brand ve Color" ve daha
       sonra oluşacak olan başka şeyleri ekler, siler, günceller, listeler... */
    public interface ICarDal:IEntityRepository<Car>
    {
       
    }
}
