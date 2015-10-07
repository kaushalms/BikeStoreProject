using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BikeStore.Models
{
    public class SampleData : DropCreateDatabaseAlways<BikeStoreEntities>
    {
        protected override void Seed(BikeStoreEntities context)
        {
            var stores = new List<Store>
            {
                new Store { Name = "Store 1"},      
                new Store { Name = "Store 2"},
                new Store { Name = "Store 3"},
            };

           

            new List<Inventory>
            {
                new Inventory { InventorySize = Inventory.Size.Sm, InventoryType = Inventory.Type.BMX, InventoryStatus = Inventory.Status.Available, SerialNumber="A1234", Brand="Trek", Model = "Trail Blazer", Description="The most powerful bike of 2014", InventoryCost=20.00m,RecSellPrice=30.00m, StoreName = stores.Single(s => s.Name == "Store 1")},
                new Inventory { InventorySize = Inventory.Size.Md, InventoryType = Inventory.Type.MountainBike, InventoryStatus = Inventory.Status.Available, SerialNumber="A2345", Brand="Salsa", Model = "Model 2", Description="The most sturdy bike of 2014", InventoryCost=15.00m,RecSellPrice=30.00m, StoreName = stores.Single(s => s.Name == "Store 1")},
                new Inventory { InventorySize = Inventory.Size.Lg, InventoryType = Inventory.Type.Hybrid, InventoryStatus = Inventory.Status.Available, SerialNumber="A3456", Brand="Jamis", Model = "Model 3", Description="The most preffered bike of 2014", InventoryCost=30.00m,RecSellPrice=35.00m, StoreName = stores.Single(s => s.Name == "Store 1")},
                new Inventory { InventorySize = Inventory.Size.XtraLg, InventoryType = Inventory.Type.Hybrid, InventoryStatus = Inventory.Status.Available, SerialNumber="A4567", Brand="Specialised", Model = "Model 4", Description="Features 6 levels of gears! Zoooommmm!", InventoryCost=25.00m,RecSellPrice=35.00m, StoreName = stores.Single(s => s.Name == "Store 2")},
                new Inventory { InventorySize = Inventory.Size.Sm, InventoryType = Inventory.Type.Children, InventoryStatus = Inventory.Status.Available, SerialNumber="A5678", Brand="Surly", Model = "Model 5", Description="Features height adjustable seat!Wow!", InventoryCost=30.00m,RecSellPrice=40.00m, StoreName = stores.Single(s => s.Name == "Store 2")},
                new Inventory { InventorySize = Inventory.Size.Md, InventoryType = Inventory.Type.Road, InventoryStatus = Inventory.Status.Available, SerialNumber="A6789", Brand="Giant", Model = "Model 6", Description="The fastest bike of 2014", InventoryCost=37.00m,RecSellPrice=44.00m, StoreName = stores.Single(s => s.Name == "Store 2")},
                new Inventory { InventorySize = Inventory.Size.Md, InventoryType = Inventory.Type.BMX, InventoryStatus = Inventory.Status.Available, SerialNumber="A7890", Brand="Bianchi", Model = "Model 7", Description="Blah Blah Blah", InventoryCost=25.00m,RecSellPrice=30.00m, StoreName = stores.Single(s => s.Name == "Store 3")},
                new Inventory { InventorySize = Inventory.Size.XtraLg, InventoryType = Inventory.Type.Hybrid, InventoryStatus = Inventory.Status.Available, SerialNumber="A8901", Brand="Cannondale", Model = "Model 8", Description="I have no description left", InventoryCost=40.00m,RecSellPrice=45.00m, StoreName = stores.Single(s => s.Name == "Store 3")},
                new Inventory { InventorySize = Inventory.Size.Md, InventoryType = Inventory.Type.MountainBike, InventoryStatus = Inventory.Status.Available, SerialNumber="A9012", Brand="Cervelo", Model = "Model 9", Description="Shittiest bike of the year", InventoryCost=10.00m,RecSellPrice=15.00m, StoreName = stores.Single(s => s.Name == "Store 3")}

            }.ForEach(a => context.StoreInventory.Add(a));
        }
    }

}