namespace dugeon_dio.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int level, string HeroType, int LifePoints, int MagicPoints)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
            this.LifePoints = LifePoints;
            this.MagicPoints = MagicPoints;
        }

        public override string Attack() {
            return $"{this.Name} Atacou com shuriken!";
        }

        public string Attack(int dano) {
            if (dano > 80) {
                return $"{this.Name} Atacou com uma shuriken. Causou um dano de {dano} e critico de {dano*2}!";
            } else {
                return $"{this.Name} Atacou com uma shuriken. Causou um dano de {dano}!";
            }
        }
    }
}