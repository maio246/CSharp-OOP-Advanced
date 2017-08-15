    using System;

public abstract class SpecialSoldier : Private, ISpecialisedSoldier
    {
        public string Corps { get; }

        protected SpecialSoldier(string id, string firstName, string lastName, double salary, string corps): base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" + Environment.NewLine + $"Corps: {this.Corps}";
        }
    }

