using ShopNow.Model;
using ShopNow.Repository.Common.Repository.Interface;
using ShopNow.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Repository.Common.Repository.Impl
{
    internal class CategoryRepository:EFRepositoryBase<ECommerceContext,Category,int>,ICategoryRepository
    {
    }
}
