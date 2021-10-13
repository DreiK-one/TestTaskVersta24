using System.Linq;


namespace TestTask.EF
{
    public static class OrderRepository
    {
        public static void Initialise(TestTaskContext db)
        {
            if (!db.Orders.Any())
            {
                db.Orders.AddRange(
                    new Order {
                        SenderCity = "New York",
                        SenderAddress = "Seven Avenue, 3/4",
                        AddresseeCity = "Los Angeles",
                        AddresseeAddress = "Backers st., 12",
                        Weight = 14,
                        Date = "15.12.2021"
                    },
                    
                    new Order {
                        SenderCity = "New Jersie",
                        SenderAddress = "St. Jorgett, 15",
                        AddresseeCity = "Arizona",
                        AddresseeAddress = "Newton st., 67",
                        Weight = 19,
                        Date = "30.01.2022"
                    });
            }
            db.SaveChanges();
        }
    }
}
