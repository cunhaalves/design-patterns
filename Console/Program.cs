using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using Observer.ConcreteObservers;
using Observer.ConcreteSubjects;
using System;

namespace ObserverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExecutaObserver();
            ExecutaDecorator();
        }

        static void ExecutaObserver()
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }

        static void ExecutaDecorator()
        {
            Beverage beverage = new Expresso();
            Console.WriteLine(beverage.GetDescription() + " $ "+ beverage.Cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);
            beverage2 = new Whip(beverage2);

            Console.WriteLine(beverage2.GetDescription() + " $ " + beverage2.Cost());
        }
    }
}
