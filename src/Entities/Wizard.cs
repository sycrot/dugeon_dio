namespace dugeon_dio.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType, int LifePoints, int MagicPoints)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
            this.LifePoints = LifePoints;
            this.MagicPoints = MagicPoints;
        }

        public override string Attack() {
            return $"{this.Name} Atacou com magia!";
        }
    }
}