using System;
namespace Labb2
{
    public class Account
    {
        string Name { get; set; }
        int Number { get; set; }

		public Account(string name, int number)
		{
            Name = name;
            Number = number;
		}

        public override string ToString()
        {
            return Name + "(" + Number + ")";
        }
    }
}
