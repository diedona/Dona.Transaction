using Dona.Transaction.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dona.Transaction.Domain
{
    public class ProductStorageLog
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int StorageId { get; set; }
        public Storage Storage { get; set; }
        public int? QuantityIn { get; set; }
        public int? QuantityOut { get; set; }
        public EnumLogType Type { get; set; }
    }
}
