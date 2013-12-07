using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dona.Transaction.Domain
{
    public class ProductStorage
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Storage Storage { get; set; }
        public int StorageId { get; set; }
        public int Quantity { get; set; }
    }
}
