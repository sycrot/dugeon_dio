namespace dugeon_dio.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int level, string HeroType, int LifePoints, int MagicPoints) {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
            this.LifePoints = LifePoints;
            this.MagicPoints = MagicPoints;
        }
        public Hero() {

        }

        public string Name;
        public int level;
        public string HeroType;
        public int LifePoints;
        public int MagicPoints;

        public override string ToString() {
            return $"\n------- Heroi ------\n"+
                $"Nome: {this.Name}\n"+
                $"Level: {this.level}\n"+
                $"Tipo: {this.HeroType}\n"+
                $"HP: {this.LifePoints}\n"+
                $"MP: {this.MagicPoints}\n";
        }

        public virtual string Attack() {
            return $"{this.Name} Atacou com uma espada!";
        }
    }
}