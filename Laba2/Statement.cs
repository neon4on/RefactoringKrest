using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    interface IStatement
    {
        string Value(Customer customer);
    }

    class TextStatement : IStatement
    {
        public string Value(Customer customer)
        {
            StringBuilder result = new StringBuilder($"Учет аренды для {customer.GetName()}:\n");

            foreach (Rental rental in customer.GetRentals())
            {
                result.AppendLine($"\t{rental.GetMovie().GetTitle()}\t{rental.GetCharge()}");
            }

            result.AppendLine($"Сумма составляет {customer.GetTotalCharge()}");
            result.AppendLine($"Вы заработали {customer.GetTotalFrequentRenterPoints()} очков за активность");

            return result.ToString();
        }
    }
}