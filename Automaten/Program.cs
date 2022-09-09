namespace Automaten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GUI gui = new GUI();
            VendingMachine machine = new VendingMachine();
            Console.Clear();
            gui.Menu(machine.snacks);
            Thread.Sleep(1000);
        }
    }
}