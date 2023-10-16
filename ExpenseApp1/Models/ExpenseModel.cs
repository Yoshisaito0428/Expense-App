using System.Data;

namespace ExpenseApp1.Models
{
    public class ExpenseModel
    {
        //実施予定日
        public DateTime Date {  get; set; }
        //総人数
        public int TotalPeople { get; set; }
        //総額　税込
        public decimal TotalPricesWithTax {  get; set; }
        //一人あたり　税抜き
        public decimal PerPersonPricesWithoutTax {  get; set; }

        public decimal CalculatePerPersonWithoutTax() { 
            decimal taxRate = 0.10m;
            decimal totalWithoutTax = TotalPricesWithTax / (1 + taxRate);
            decimal PerPersonPricesWithoutTax = Math.Round(totalWithoutTax / TotalPeople,2);
            return PerPersonPricesWithoutTax;
        }


    }
}
