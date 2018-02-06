using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Rectangle : Shape
    {
        //Fields
        private double area;
       

        //Properties
        public double Area
        {
            get { return this.area; }
            set { this.area = value; }
        }


       
        //A derived class does not inherit constrctors of
        //the base class. However, the constructors of the
        //base class can be accessed using the "base" keyword
        
        //Constructors
        public Rectangle(double area) 
        {
            this.area = area;
        }


    }
}
