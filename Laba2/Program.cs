using System;

namespace Refactoring
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer("Alex");
            Movie movie1 = new NewReleaseMovie("Matrix");
            Movie movie2 = new ChildrensMovie("Lion King");
            Rental rental1 = new Rental(movie1, 2);
            Rental rental2 = new Rental(movie2, 4);
            customer.AddRental(rental1);
            customer.AddRental(rental2);

            Console.WriteLine(customer.Statement());
            Console.ReadKey();
        }
    }
}