using System;
namespace Labb2
{
    public class Account
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string type { get; set; }

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
