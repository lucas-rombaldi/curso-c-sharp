namespace Curso.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine1 = new Machine1();
            var machine2 = new Machine2();
            var machine3 = new Machine3();
            machine1.Start();
            machine2.Start();
            machine3.Start();
        }
    }
}
