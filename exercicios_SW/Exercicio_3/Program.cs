﻿namespace Terceiro;
class Program
{
    static void Main(string[] args)
    {
        PessoaFisica n1 = new PessoaFisica();
        PessoaJuridica n2 = new PessoaJuridica();

        n1.Email = "Biana@gmail.com";
        n1.Nome = "Biana";
        n1.Telefone = "(11) 4002-8922";
        n1.cpf = "666.666.666-66";
        n1.Idade = 16;
        n1.Prazo = 10;


        n2.Email = "silvia@gmail.com";
        n2.Nome = "Silvia";
        n2.Telefone = "(11) 93505-8972";
        n2.cnpj = "22.333.444/555-66";
        n2.ie = "000.000.000.000";
        n2.NomeEmpresa = "silvinha imóveis";
        n2.Prazo = 10;
        

        Console.WriteLine("Os dados Pessoa Física são: " + n1.MostraDados());
        Console.WriteLine("Os dados Pessoa Jurídica são: " + n2.MostraDados());
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("O valor da prestação da Pessoa Física é: " + n1.calcularPrestacao());
        Console.WriteLine("O valor da prestação da Pessoa Jurídica é: " + n2.calcularPrestacao());
    }
}