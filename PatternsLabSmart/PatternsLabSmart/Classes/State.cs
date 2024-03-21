using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLabSmart.Classes
{
    public abstract class State
    {
        protected Smartphone _smartphone;
        public Smartphone Smartphone { set { _smartphone = value; } }
        public abstract void VolumeUpClick();
        public abstract void VolumeDownClick();
        public abstract void PowerButtonClick();
        public abstract void PowerButtonClamp();
    }
}
