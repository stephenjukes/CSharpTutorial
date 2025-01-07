using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Tyranid
    {
        public Tyranid(string name)
        {
            Name = name;
            Health = 100;
            Power = 10;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public int Experience { get; set; }

        public int Power { get; set; }

        public void ReceiveDamage(int damage)
        {
            Health -= damage;
        }

        public void Attack(Tyranid tyranid)
        {
            Experience++;
            tyranid.ReceiveDamage(this.Power);
        }

        public string Summary()
        {
            return $"{Name.ToUpper()} " +
                $"\nHealth: {Health} " +
                $"\nExperience: {Experience}" +
                $"\n";
        }
    }
}
