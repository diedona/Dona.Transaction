using Dona.Transaction.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dona.Transaction.Service
{
    public class ProductStorageService : IProductStorageService
    {
        public bool RemoveProductQuantityFromStorage(int ProductId, int StorageId, int Quantity)
        {
            throw new NotImplementedException();
        }

        public bool AddProductQuantityToStorage(int ProductId, int StorageId, int Quantity)
        {
            throw new NotImplementedException();
        }
    }
}
