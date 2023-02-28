namespace Task1
{
    public class Violin : IPlayable
    {
        public int Weight { get; set; }
        public string Color { get; set; }

        public string StandMaterial { get; set; }
        public string ViolinSize { get; set; }

        public Violin(int weight, string color, string standMaterial, string violinSize)
        {
            Weight = weight;
            Color = color;
            StandMaterial = standMaterial;
            ViolinSize = violinSize;
        }

        public void Play()
        {
            Console.WriteLine($"Играет скрипка. Вес: {Weight}, цвет: {Color}, материал подставки: {StandMaterial}, размер: {ViolinSize}. ");
        }
    }
}
