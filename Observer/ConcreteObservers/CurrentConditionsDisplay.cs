using Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ConcreteObservers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private ISubject _subject;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public CurrentConditionsDisplay(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine(string.Concat("Current Conditions: ", _temperature, " F degrees and ", _humidity, " % humidity"));
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _pressure = pressure;
            _humidity = humidity;
            Display();
        }
    }
}
