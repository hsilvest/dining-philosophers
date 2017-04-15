using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiningPhilosophers.Domain
{
    public class Table
    {
        public ICollection<Philosopher> Philosophers { get; set; }
        public ICollection<Chopstick> Chopsticks { get; set; }
        public ICollection<ChopstickProvider> ChopstickProviders { get; set; }

    }
}
