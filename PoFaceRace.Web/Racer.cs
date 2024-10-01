namespace PoFaceRace.Web
{
    public class Racer
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Position { get; set; }

        public Racer(string name, string color)
        {
            Name = name;
            Color = color;
            Position = 0;
        }
    }
}