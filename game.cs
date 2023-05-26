namespace Ex2
{
    class GameItem
    {
        protected string Name;
        protected int Level;
        protected int Score;

        public GameItem(string name, int level, int score)
        {
            Name = name;
            Level = level;
            Score = score;
        }

        public GameItem() { }

        public String PName
        {
            get { return Name; }
            set { Name = value; }
        }

        public int PLevel
        {
            get { return Level; }
            set { Level = value; }
        }

        public int PScore
        {
            get { return Score; }
            set { Score = value; }
        }

        public virtual String ToString()
        {
            return "Name: " + PName + "  Level: " + PLevel + "  Score: " + PScore;
        }
    }

    class Weapon : GameItem
    {
        public Weapon() { }

        public override String ToString()
        {
            return "Name: " + PName + "  Level: " + PLevel + "  Score: " + PScore;
        }
    }

    class Armor : GameItem
    {
        public Armor() { }

        public override String ToString()
        {
            return "Name: " + PName + "  Level: " + PLevel + "  Score: " + PScore;
        }
    }

    class Consumable : GameItem
    {
        public Consumable() { }
        public override String ToString()
        {
            return "Name: " + PName + "  Level: " + PLevel + "  Score: " + PScore;
        }
    }
    internal class game
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();
            weapon.PName = "Garen";
            weapon.PLevel = 15;
            weapon.PScore = 500;
            Console.WriteLine(weapon.ToString());

            Armor armor = new Armor();
            armor.PName = "javan";
            armor.PLevel = 18;
            armor.PScore = 800;
            Console.WriteLine(armor.ToString());

            Consumable consumable = new Consumable();
        }
    }
}