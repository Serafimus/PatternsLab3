using PatternsLabSmart.Classes.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PatternsLabSmart.Classes
{
    public class Smartphone
    {
        private Label _label;

        private int _volume = 8;
        public int Volume
        {
            get => _volume;
            private set
            {
                if (value >= 0 && value <= 15)
                {
                    _volume = value;
                }
            }
        }

        private State _state;
        public Smartphone(Label label)
        {
            _label = label;
            TurnOff();
        }
        public void TransitionTo(State state)
        {
            _state = state;
            _state.Smartphone = this;
            _label.Content = _state.GetType().Name;
        }
        public void VolumeUpClick()
        {
            _state.VolumeUpClick();
        }
        public void VolumeDownClick()
        {
            _state.VolumeDownClick();
        }
        public void PowerButtonClick()
        {
            _state.PowerButtonClick();
        }
        public void PowerButtonClamp()
        {
            _state.PowerButtonClamp();
        }
        internal void TurnVolumeUp()
        {
            Volume = ++Volume;
            _label.Content = $"Громкость: {Volume}";
        }

        internal void TurnVolumeDown()
        {
            Volume = --Volume;
            _label.Content = $"Громкость: {Volume}";
        }

        internal void TurnScreenOff()
        {
            TransitionTo(new ScreenOff());
        }
        internal void TurnScreenOn()
        {
            TransitionTo(new ScreenLocked());
        }

        internal void TurnOff()
        {
            TransitionTo(new TurnedOff());
        }

        internal void TurnOn()
        {
            TransitionTo(new ScreenLocked());
        }
    }
}
