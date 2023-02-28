namespace Task2
{
    internal class Magazine : IPrintable
    {
        public string Name { get; set; }
        public string ReleaseFrequency { get; set; }
        public string TargetAudience { get; set; }

        public Magazine(string name, string releaseFrequency, string targetAudience)
        {
            Name = name;
            ReleaseFrequency = releaseFrequency;
            TargetAudience = targetAudience;
        }

        public void Print()
        {
            Console.WriteLine($"Это журнал. Название: {Name}, периодичность выхода: {ReleaseFrequency}, целевая аудитория: {TargetAudience}.");
        }

        public static void PrintMagazines(IPrintable[] printable)
        {
            foreach(var item in printable)
            {
                if (item is Magazine)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
