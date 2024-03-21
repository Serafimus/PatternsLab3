using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLabSmart.Classes.States
{
    public class ScreenOff : State
    {
        public override void PowerButtonClamp()
        {
            _smartphone.TurnScreenOn();
        }

        public override void PowerButtonClick()
        {
            _smartphone.TurnScreenOn();
        }

        public override void VolumeDownClick()
        {
            _smartphone.TurnScreenOn();
        }

        public override void VolumeUpClick()
        {
            _smartphone.TurnScreenOn();
        }
    }
}
