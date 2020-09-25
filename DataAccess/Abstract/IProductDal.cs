using Core.DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Repository Pattern
        //Listeleme
        //Ekleme
        //Silme
        //Güncelleme
    }
}
