using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favoriteFood) : base(name, favoriteFood) { }

        public override string ExplainSelf()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{base.ToString()}");
            stringBuilder.AppendLine("DJAAF");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
