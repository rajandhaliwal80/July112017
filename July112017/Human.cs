using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July112017
{
    public abstract class Human
    {
        //my private instyance variables
        private string _name;

        //public properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        //constructors-------------------------------------------
        /// <summary>
        /// 
        /// this is the main constructors
        /// it takes one paameter that is name(string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
        //private methods
        //public mthods
    }
}
}
