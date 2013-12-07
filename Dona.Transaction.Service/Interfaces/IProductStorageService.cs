using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dona.Transaction.Service.Interfaces
{
    public interface IProductStorageService
    {
        bool RemoveProductQuantityFromStorage(int ProductId, int StorageId, int Quantity);
        bool AddProductQuantityToStorage(int ProductId, int StorageId, int Quantity);
    }
}
