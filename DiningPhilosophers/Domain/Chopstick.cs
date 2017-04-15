using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiningPhilosophers.Domain
{
    public class Chopstick
    {
        private string Id;

        public Chopstick(string id)
        {
            Id = id;
        }

        public string GetID() { return Id; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
