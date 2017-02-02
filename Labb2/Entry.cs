using System;
namespace Labb2
{
	public class Entry
	{
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Account AccountType { get; set; }
        public Account MoneyAccount { get; set; }
        public double Ammount { get; set; }
        public TaxRate Tax { get; set; }

		public Entry(DateTime date, string description, Account accountType, Account moneyAccount, double ammount, TaxRate tax)
		{
            Date = date;
            Description = description;
            AccountType = accountType;
            MoneyAccount = moneyAccount;
            Ammount = ammount;
            Tax = tax;
		}

	}
}
