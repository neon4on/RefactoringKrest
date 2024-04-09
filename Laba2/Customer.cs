using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class Customer
    {
        private string name;
        private List<Rental> rentals = new List<Rental>();

        public Customer(string name)
        {
            this.name = name;
        }

        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public string GetName()
        {
            return name;
        }

        public string Statement()
        {
            return new TextStatement().Value(this);
        }

        public List<Rental> GetRentals()
        {
            return rentals;
        }

        public double GetTotalCharge()
        {
            return rentals.Sum(rental => rental.GetCharge());
        }

        public int GetTotalFrequentRenterPoints()
        {
            return rentals.Sum(rental => rental.GetFrequentRenterPoints());
        }
    }
}