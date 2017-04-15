using DiningPhilosophers.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiningPhilosophers.Domain
{
    public class Philosopher
    {
        public Philosopher(string id)
        {
            Id = id;
        }
        public string Id { get; private set; }
        public ChopstickProvider LeftChopstick { get; set; }
        public ChopstickProvider RightChopstick { get; set; }

        public PhilosopherState State { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }

    }
}
