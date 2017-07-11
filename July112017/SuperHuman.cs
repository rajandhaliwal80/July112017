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
        protected List<Power> _Powers;
        //public propertes
        public List<Power> Powers()
        {
           
        }

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
        /// <summary>
        /// this method adds power to the power List
        /// it takes two arguments name and rank
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name,int rank)
        {
            this.Powers.AddPower(new Power(name, rank));
        }
        /// <summary>
        /// this method diplays each of the powers stored in the ower list
        /// </summary>
        public void DisplayPowers()
        {
            foreach(Power power in this.Powers)
            {
                Console.WriteLine("My power id"+ power.Name+"Rank:"+power.RANK);
            }
        }
    }
}