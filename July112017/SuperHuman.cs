using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// this is the super human class that extends the human class
/// </summary>
namespace July112017
{
    //this is super human class
    
    public class SuperHuman : Human 
    {
        // Private instance variables
        private List<Power> _Powers;
        //public propertes
        //constructors-----------------------------------------------------
        /// <summary>
        /// this is the main constructor
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name):base (name)
        {
            this._initialize();
        }
        //private methods
        private void _initialize()
        {
            this._Powers = new List<Power>(); //this creates a empty list
        }
        //public methods
    }
}