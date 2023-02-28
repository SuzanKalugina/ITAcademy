namespace Task1
{
    public class Synthesizer : IPlayable
    {
        public int Weight { get; set; }
        public string Color { get; set; }
        public  int NumberOfKeys { get; set; }
        public int NumberOfVoices { get; set; }

        public Synthesizer(int weight, string color, int numberOfKeys, int numberOfVoices)
        {
            Weight = weight;
            Color = color;
            NumberOfKeys = numberOfKeys;
            NumberOfVoices = numberOfVoices;
        }

        public void Play()
        {
            Console.WriteLine($"Играет синтезатор. Вес: {Weight}, цвет: {Color}, количество клавиш: {NumberOfKeys}, количество тембров: {NumberOfVoices}. ");
        }
    }
}
