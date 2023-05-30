namespace exercicio_2;
class Program
{
    static void Main(string[] args)
    {

        PessoaJuridica Contrato_pessoa_juridica = new PessoaJuridica("contrato de pessoa jurídica","juridico@gmail.com","(11) 4002-8922","Bianaa","66.666.666/6666-66", "123456789", "Biana imoveis");
        PessoaJuridica.exibir();

  Console.WriteLine("-------------------------------------------");

        PessoaFisica Contrato_pessoa_fisica = new PessoaFisica("contrato de pessoa física","fisico@gmail.com","(11) 93505-8972","Silvia", "111.222.333-44", 12);
        PessoaFisica.exibir();
        Console.WriteLine();


    }
        
    
}

