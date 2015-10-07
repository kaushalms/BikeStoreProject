using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BikeStore.Models
{
    
        public class BikeStoreEntities : DbContext
        {
            public DbSet<Inventory> StoreInventory { get; set; }
            //public DbSet<Employee> Employees { get; set; }
            public DbSet<Store> Stores { get; set; }
        }
    }
