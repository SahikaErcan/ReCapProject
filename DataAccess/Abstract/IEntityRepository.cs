using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{ /*Generic Repository Design Pattern yapısı oluşturuyoruz.Birbirini tekrar eden durumaları önlemek
   * için bu yapı kullanılır.*/
    /* T yi sınırlandırıyoruz. Sınırlanmamış hali ile "int" bile yazsak kabul edecektir.Bu istediğimiz
     * bir durum değil bu nedenle T yi filtreliyoruz. Bu olaya "Generic Constraint" denir.
     * "class" referans tip demektir. Ancak  biz bütün class'ları değil sadece "Entities" Katmanında ki
     * "Concrete" klasöründeki classları görsün istiyoruz.Bu nedenle "IEntity" interface'ini kullanıyoruz.
     * Bu adıma kadar 'T bir referans tip olmalı ve T ya Entity ya da Entity'den implemente bir şey
     * olmalı' diyoruz.Ancak soyut sınıf olan IEntity bizim işimize yaramıyor. Bunu önlemek içinde
     * "new()" ifadesini kullanıyoruz.*/
    public interface IEntityRepository<T> where T: class, IEntity, new() 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // Tüm datayıda getirebilir, belirli bir kısmıda getirebilir.
        /* "filter=null" filtre vermeye de bilirsin demek. Filtre verilmemişse tüm datayı döndürür.*/
        T Get(Expression<Func<T, bool>> filter); // Tek bir elemanı getirmek için kullanılır.
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
//Interface metodları default publictir ama kendisi değildir.Bu nedenle oluşturduktan sonra public diye belirliyoruz.