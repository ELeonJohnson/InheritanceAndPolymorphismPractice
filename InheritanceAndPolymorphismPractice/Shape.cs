﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Shape
    {
        //Fields
        private int sides; 
        //to acess this field from anothher class: 
        //this.Sides = sides;
        //"Sides" coming from another class
        

        //Properties

        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }


        //Constructors

        public Shape()
        {
            //default constructor
        }

        public Shape(int sides)
        {
            this.sides = sides;
        }




    }
}