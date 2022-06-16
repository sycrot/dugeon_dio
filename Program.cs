using dugeon_dio.src.Entities;

namespace dugeon_dio {
    class Program {
        static void Main(string[] args) {
            Hero arus = new Hero("Arus", 40, "Knight", 469, 78);
            Ninja wedge = new Ninja("Wedge", 42, "Ninja",298, 99);
            Wizard jenica = new Wizard("Jenica", 42, "White Wizard", 310, 480);
            Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 300, 600);

            System.Console.WriteLine(arus.ToString());
            System.Console.WriteLine(wedge.ToString());

            System.Console.WriteLine(arus.Attack());
            System.Console.WriteLine(wedge.Attack());
        }
    }
}
