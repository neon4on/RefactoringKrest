using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    abstract class Movie
    {
        public const int Childrens = 2;
        public const int Regular = 0;
        public const int NewRelease = 1;

        private string title;

        public Movie(string title)
        {
            this.title = title;
        }

        public abstract int GetPriceCode();

        public abstract double GetCharge(int daysRented);

        public int GetFrequentRenterPoints(int daysRented)
        {
            return (GetPriceCode() == NewRelease && daysRented > 1) ? 2 : 1;
        }

        public string GetTitle()
        {
            return title;
        }
    }

    class ChildrensMovie : Movie
    {
        public ChildrensMovie(string title) : base(title)
        {
        }

        public override int GetPriceCode()
        {
            return Childrens;
        }

        public override double GetCharge(int daysRented)
        {
            return (daysRented > 3) ? (daysRented - 3) * 1.5 : 1.5;
        }
    }

    class NewReleaseMovie : Movie
    {
        public NewReleaseMovie(string title) : base(title)
        {
        }

        public override int GetPriceCode()
        {
            return NewRelease;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }
    }

    class RegularMovie : Movie
    {
        public RegularMovie(string title) : base(title)
        {
        }

        public override int GetPriceCode()
        {
            return Regular;
        }

        public override double GetCharge(int daysRented)
        {
            return (daysRented > 2) ? 2 + (daysRented - 2) * 1.5 : 2;
        }
    }
}