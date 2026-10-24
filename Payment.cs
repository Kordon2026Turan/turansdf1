using System;

namespace Turansdf1
{
    public class Payment
    {
        public string Title { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Payment(string title, double amount)
        {
            Title = title;
            Amount = amount;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - {Title}: {Amount} AZN";
        }
    }
}