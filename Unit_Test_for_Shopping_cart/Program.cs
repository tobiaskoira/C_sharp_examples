namespace Task35
{

    public class Program
    {
     
        public class InvoiceItem
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public double Total { get { return Price * Quantity; } }
            public InvoiceItem() { }
            public InvoiceItem(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;

            }
            public override string ToString()
            {
                //return $"{Name}, {Price} euros, {Quantity} pieces, {Total} total.
                return Name;
            }
        }

        public class Invoice
        {
            public string Customer { get; set; }
            private List<InvoiceItem> _InvoiceItems = new List<InvoiceItem>();
            public List<InvoiceItem> InvoiceItems
            {
                get { return _InvoiceItems; }
            }

            public int ItemsCount { get; set; }
            public int ItemsTogether {get; set;}
            public double CountTotal { get; set; }

        }
        
        public void ShowItems()
        {
           
        }
        static void Main(string[] args)
        {


            List<Invoice> info = new List<Invoice>()
            {
                new Invoice{Customer = "Dina"}
            };

            foreach (Invoice _info in info)
            {
                Console.WriteLine($"Customer {_info.Customer}'s invoice:");
            }
            Console.WriteLine("=========================");



            List<InvoiceItem> items = new List<InvoiceItem>
            {
                new InvoiceItem{Name = "Milk", Price = 1.75, Quantity = 1},
                new InvoiceItem{Name = "Beer", Price = 5.25, Quantity = 1},
                new InvoiceItem{Name = "Butter", Price = 2.5, Quantity = 2}

            };

            foreach (InvoiceItem item in items)
            {

                Console.WriteLine($"{item.Name} {item.Price}e {item.Quantity}, pieces {item.Total}e, total");
                Console.WriteLine();
            }
            Console.WriteLine("=========================");

            double countTotalPrice = items.Count > 0 ? items.Sum(item => item.Quantity) : 0.0;
            double countTotalNumOfItems = items.Count > 0 ? items.Sum(item => item.Total) : 0.0;

            Console.WriteLine($"Total: {countTotalNumOfItems} pieces {countTotalPrice} euros");
        }
    }
}