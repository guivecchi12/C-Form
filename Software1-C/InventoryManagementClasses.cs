using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1_C
{
    internal abstract class Part
    {
        public abstract int PartID { get; set; }
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
        public abstract int InStock { get; set; }
        public abstract int Min { get; set; }
        public abstract int Max { get; set; }
    }

    internal class Inhouse : Part
    {

        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID) : base() {
            this.PartID = partID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
            this.MachineID = machineID;
        }

        public override int PartID { get; set; }
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public override int InStock { get; set; }
        public override int Min { get; set; }
        public override int Max { get; set; }

        public int MachineID { get; set; }
    }

    internal class OutSourced : Part
    {

        public OutSourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName) : base()
        {
            this.PartID = partID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
            this.CompanyName = companyName;
        }

        public override int PartID { get; set; }
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public override int InStock { get; set; }
        public override int Min { get; set; }
        public override int Max { get; set; }

        public string CompanyName { get; set; }
    }

    internal class Product
    {
        public Product(int productId, string name, decimal price, int inStock, int min, int max) {
            this.ProductID = productId;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
        }
        public BindingList<Part> AssociatedParts { get; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part associatedPart)
        {
            this.AssociatedParts.Add(associatedPart);
        }

        public bool removeAssociatedPart(int partID)
        {
            // find part
            Part partToRemove = this.AssociatedParts[partID];

            // Returns true if part is removed
            // Returns false if failed to remove or part was not found
            return this.AssociatedParts.Remove(partToRemove);
        }

        public Part lookupAssociatedPart(int partID)
        {
            return this.AssociatedParts[partID];
        }
    }

    internal class Inventory
    {
        public BindingList<Product> Products { get; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; } = new BindingList<Part>();

        public void addProduct(Product product)
        {
            this.Products.Add(product);
        }

        public bool removeProduct(int partID)
        {
            // Find Product
            Product productToRemove =this.Products[partID];

            // Returns true if part is removed
            // Returns false if failed to remove or part was not found
            return this.Products.Remove(productToRemove);
        }

        public Product lookupProduct(int partID)
        {
            return this.Products[partID];
        }

        public void updateProduct(int productID, Product product)
        {
            this.Products[productID] = product;
        }

        public void addPart(Part part)
        {
            this.AllParts.Add(part);
        }
        public bool deletePart(Part part) { 
            return this.AllParts.Remove(part);
        }

        public Part lookupPart(int partID)
        {
            return this.AllParts[partID];
        }

        public void updatePart(int partID, Part part)
        {
            this.AllParts[partID] = part;
        }
    }


}
