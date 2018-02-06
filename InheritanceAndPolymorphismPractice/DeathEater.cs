using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class DeathEater : Wizard
    {
        //fields 
        private bool hasDarkMark;

        //Properties
        public bool HasDarkMark
        {
            get { return this.hasDarkMark; }
            set { this.hasDarkMark = value; }
        }

        //Constructor
        public DeathEater() 
        {
            this.IsGood = false;
        }

        public override void MakeMagic()
        {
            Console.WriteLine("Crucio!");
        }
    }
}
