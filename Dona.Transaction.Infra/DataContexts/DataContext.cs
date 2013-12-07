using Dona.Transaction.Domain;
using Dona.Transaction.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dona.Transaction.Infra.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            Database.SetInitializer(new Initialization());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<ProductStorage> ProductStorages { get; set; }
        public DbSet<ProductStorageLog> ProductStorageLogs { get; set; }
    }

    public class Initialization : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            #region Products & Storages
            context.Products.Add(new Product { Name = "Bola de Futebol", Price = 10.50M });
            context.Products.Add(new Product { Name = "Camiseta Esportiva", Price = 35.00M });
            context.Products.Add(new Product { Name = "Tênis de Corrida", Price = 85.70M });

            context.Storages.Add(new Storage { Name = "Armazém do Zé" });
            context.Storages.Add(new Storage { Name = "Armazém Arnildo" }); 
            #endregion

            context.SaveChanges();

            #region ProductStorageLogs
            context.ProductStorageLogs.Add(new ProductStorageLog
                {
                    ProductId = 1,
                    QuantityIn = 10,
                    StorageId = 1,
                    Type = EnumLogType.Entrada
                });

            context.ProductStorageLogs.Add(new ProductStorageLog
            {
                ProductId = 2,
                QuantityIn = 7,
                StorageId = 1,
                Type = EnumLogType.Entrada
            });

            context.ProductStorageLogs.Add(new ProductStorageLog
            {
                ProductId = 2,
                QuantityIn = 5,
                StorageId = 2,
                Type = EnumLogType.Entrada
            }); 
            #endregion

            #region ProductStorage
            context.ProductStorages.Add(new ProductStorage { ProductId = 1, StorageId = 1, Quantity = 10 });
            context.ProductStorages.Add(new ProductStorage { ProductId = 2, StorageId = 1, Quantity = 7 });
            context.ProductStorages.Add(new ProductStorage { ProductId = 2, StorageId = 2, Quantity = 5 }); 
            #endregion

            base.Seed(context);
        }
    }
}
