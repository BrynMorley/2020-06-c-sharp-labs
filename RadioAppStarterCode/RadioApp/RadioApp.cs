using System;

namespace RadioApp
{
    public class Radio
    {
        private int _channel;
        private bool _on;

        public int Channel
        {
            get
            {
                return _channel;
            }   
            set
            {
                if (_on)
                {
                    if (value > 0 && value < 5)
                    {
                        _channel = value;
                    }
                }
                
            }
        }

        public Radio()
        {
            _channel = 1;
        }

        public string Play()
        {
            if (_on)
            {
                return $"Playing channel {_channel}";
            }
            return "Radio is off";
        }

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }

        public void ToggleOnOff()
        {
            if (_on)
            { 
                TurnOff(); 
            }
            else
            {
                TurnOn();
            }
           
        }


    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}