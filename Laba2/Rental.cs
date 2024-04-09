using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class Rental
    {
        private Movie movie;
        private int daysRented;

        public Rental(Movie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        public int GetDaysRented()
        {
            return daysRented;
        }

        public Movie GetMovie()
        {
            return movie;
        }

        public double GetCharge()
        {
            return movie.GetCharge(daysRented);
        }

        public int GetFrequentRenterPoints()
        {
            return movie.GetFrequentRenterPoints(daysRented);
        }
    }
}