using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLabSmart.Classes.States
{
    public class ScreenLocked : State
    {
        public override void PowerButtonClamp()
        {
            _smartphone.TurnOff();
        }

        public override void PowerButtonClick()
        {
            _smartphone.TurnScreenOff();
        }

        public override void VolumeDownClick()
        {
            _smartphone.TurnVolumeDown();
        }

        public override void VolumeUpClick()
        {
            _smartphone.TurnVolumeUp();
        }
    }
}
