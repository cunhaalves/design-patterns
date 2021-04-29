using Observer.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Observer.ConcreteSubjects
{
    public class WeatherData : ISubject
    {
        private ArrayList _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new ArrayList();
        }
        public void NotifyObservers()
        {
            foreach (var item in _observers)
            {
                var observer = (IObserver)item;
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int i = _observers.IndexOf(observer);
            if (i >= 0)
                _observers.RemoveAt(i);
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _pressure = pressure;
            _humidity = humidity;
            MeasurementsChanged();
        }
    }
}
