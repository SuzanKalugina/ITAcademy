namespace Task1
{
    public class Guitar : IPlayable
    {
        public int Weight { get; set; }
        public string Color { get; set; }
        public int NumberOfStrings { get; set; }

        public string GuitarPerformance { get; set; }

        public Guitar(int weight, string color, int numberOfStrings, string guitarPerformance)
        {
            Weight = weight;
            Color = color;
            NumberOfStrings = numberOfStrings;
            GuitarPerformance = guitarPerformance;
        }

        public void Play()
        {
            Console.WriteLine($"Играет гитара. Вес: {Weight}, цвет: {Color}, количество струн: {NumberOfStrings},  исполнение гитары: {GuitarPerformance}. ");
        }
    }
}
