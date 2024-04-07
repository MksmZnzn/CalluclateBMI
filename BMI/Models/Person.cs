namespace Norbit.CalculateBMI.Models
{
    /// <summary>
    /// Человек.
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// Вес.
        /// </summary>
        private readonly double Weight;

        /// <summary>
        /// Рост.
        /// </summary>
        private readonly double Height;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="weight">Вес.</param>
        /// <param name="height">Рост.</param>
        public Person(double weight, double height)
        {
            Weight = weight;
            Height = height;
        }

        /// <summary>
        /// Рассчет Индекса массы тела.
        /// </summary>
        /// <returns>Значение ИМТ человека.</returns>
        public double CalculateBMI()
        {
            return Weight / (Math.Pow(Height, 2));
        }
    }
}
