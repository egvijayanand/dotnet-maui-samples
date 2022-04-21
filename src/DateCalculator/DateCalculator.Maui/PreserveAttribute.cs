using System;

namespace DateCalculator.Core
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class PreserveAttribute : Attribute
    {
        // Keep all members
        public bool AllMembers { get; set; }

        // Keep member only if the type itself is kept
        public bool Conditional { get; set; }
    }
}
