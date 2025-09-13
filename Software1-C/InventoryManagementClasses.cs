using System.ComponentModel;

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

    internal class Outsourced : Part
    {

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName) : base()
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
        public Product(int id)
        {
            this.ProductID = id;
            this.Name = string.Empty;
            this.Price = 0;
            this.InStock = 0;
            this.Min = 0;
            this.Max = 0;
        }
        public Product(int id, string name, decimal price, int inStock, int min, int max)
        {
            this.ProductID = id;
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
            Part? partToRemove = this.lookupAssociatedPart(partID);

            if(partToRemove == null) return false;

            // Returns true if part is removed
            // Returns false if failed to remove or part was not found
            return this.AssociatedParts.Remove(partToRemove);
        }

        public Part? lookupAssociatedPart(int partID)
        {
            return this.AssociatedParts.FirstOrDefault(part => part.PartID == partID);
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

        public bool removeProduct(int id)
        {
            // Find Product
            Product productToRemove = this.lookupProduct(id);

            // Returns true if part is removed
            // Returns false if failed to remove or part was not found
            return this.Products.Remove(productToRemove);
        }

        public Product lookupProduct(int productID)
        {
            return this.Products.First(product => product.ProductID == productID);
        }

        public void updateProduct(int productID, Product newProduct)
        {
            Product oldProduct = this.lookupProduct(productID);
            if (updateProduct != null)
            {
                int index = this.Products.IndexOf(oldProduct);
                if (index != -1)
                {
                    this.Products[index] = newProduct;
                } else
                {
                    throw new ArgumentException($"Part with ID {productID} not found.");
                }
            }
        }

        public void addPart(Part part)
        {
            this.AllParts.Add(part);
        }
        public bool deletePart(Part part) { 
            return this.AllParts.Remove(part);
        }

        private Part lookupPart(int partID)
        {
            return this.AllParts.First(part => part.PartID == partID);
        }

        public void updatePart(int partID, Part newPart)
        {
            Part oldPart = this.lookupPart(partID);

            if (oldPart != null)
            {
                int index = this.AllParts.IndexOf(oldPart);
                if (index != -1)
                {
                    this.AllParts[index] = newPart;
                   
                } else
                {
                    throw new ArgumentException($"Part with ID {partID} not found.");
                }
            }
        }


        public int nextAvailablePartID()
        {
            var largestID = 0;
            foreach (Part part in this.AllParts)
            {
                if (largestID <= part.PartID)
                {
                    largestID = part.PartID + 1;
                }
            }

            return largestID;
        }

        public int nextAvailableProductID()
        {
            var largestID = 0;
            foreach (Product product in this.Products)
            {
                if (largestID <= product.ProductID)
                {
                    largestID = product.ProductID + 1;
                }
            }

            return largestID;
        }
    }


}
