using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithNulls
{
    class PlayerCharacter
    {
        private readonly ISpecialDefense _specialDefense;

        public PlayerCharacter(ISpecialDefense specialDefense)
        {
            _specialDefense = specialDefense;
        }

        public string Name { get; set; }
        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
        //Part 1
            //int damageReduction = 0;

            //if (_specialDefense != null)
            //{
            //damageReduction = _specialDefense.CalculateDamageReduction(damage);
            //}

            //int totalDamageTaken = damage - damageReduction;
        //End part 1

        //Part 2
            int totalDamageTaken = damage - _specialDefense.CalculateDamageReduction(damage);
        //End part 2

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }



























        // Part 1
        //public string Name { get; set; }
        //public int? DaysSinceLastLogin { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        //public bool? IsNoob { get; set; }

        //public PlayerCharacter()
        //{
        //    DateOfBirth = null;
        //    DaysSinceLastLogin = null;
        //}
    }
}
