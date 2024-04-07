using Norbit.CalculateBMI.Models;

namespace Norbit.CalculateBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = 0.0;
            var height = 0.0;
            
            var isSuceessParsedWeight = false;
            while (!isSuceessParsedWeight)
            {
                Console.WriteLine("Введите свой вес в кг.:");
                isSuceessParsedWeight = double.TryParse(Console.ReadLine(), out weight);

                if (!isSuceessParsedWeight)
                    Console.WriteLine("Введено некорректное значение веса");
                
                if (weight > 600) // Максимальный вес человека на планете - Урибе Мануэль из Мексики 597 кг.
                {
                    Console.WriteLine("Невозможный вес");
                    isSuceessParsedWeight = false;
                }

            }

            var isSuceessParsedHeight = false;
            while (!isSuceessParsedHeight)
            {
                Console.WriteLine("Введите свой рост в метрах:");
                isSuceessParsedHeight = double.TryParse(Console.ReadLine(), out height);

                if (!isSuceessParsedHeight)
                    Console.WriteLine("Введено некорректное значение роста");

                if (height > 2.60) // Максимальный рост человека на планете - Кёсен Султан из Турции 2.51 м. 
                {
                    Console.WriteLine("Невозможный рост");
                    isSuceessParsedHeight = false;
                }
            }
            
            var person = new Person(weight, height);
            var bmi = person.CalculateBMI();
            var result = string.Empty;
            
            if (bmi < 18)
            {
                result = "Ниже нормального";
            }
            else if (bmi >= 18 && bmi < 25)
            {
                result = "Нормальный";
            }
            else
            {
                result = "Выше нормального";
            }
            
            Console.WriteLine($"ИМТ = {Math.Round(bmi, 2)} - {result}");
            Console.ReadKey();

        }
    }
}