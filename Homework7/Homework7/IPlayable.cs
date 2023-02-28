namespace Task1
{
    interface IPlayable
    {
        int Weight { get; set; }
        string Color { get; set; }
        void Play();
    }
}
