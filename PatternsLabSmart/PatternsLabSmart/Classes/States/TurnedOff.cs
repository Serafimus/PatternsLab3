using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLabSmart.Classes.States
{
    public class TurnedOff : State
    {
        public override void PowerButtonClamp()
        {
            _smartphone.TurnOn();
        }

        public override void PowerButtonClick()
        {
            
        }

        public override void VolumeDownClick()
        {
            
        }

        public override void VolumeUpClick()
        {
            
        }
    }
}
