namespace exercicio_1;
class Program
{
    static void Main(string[] args)
    {
        Cao Mel = new Cao();
        Gato Nina = new Gato();
        Homem Robson = new Homem();


        Console.WriteLine("Olá cachorro! " + Mel.Fala());
        Console.WriteLine("Olá gato! " + Nina.Fala());
        Console.WriteLine("Olá Robson! " + Robson.Fala());

    }
}
