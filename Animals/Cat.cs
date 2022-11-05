﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood) : base(name, favoriteFood) { }

        public override string ExplainSelf()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{base.ToString()}");
            stringBuilder.AppendLine("MEEOW");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
