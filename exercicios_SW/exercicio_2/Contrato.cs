public class Contrato
{
   

    protected string detalhes;
    protected int prazo;
    protected string email;
    protected string telefone;
    protected string nome;

    public Contrato(string detalhes, string email, string telefone, string nome)
    {
      this.detalhes = detalhes;
      this.email = email;
      this.telefone = telefone;
      this.nome = nome;
      this.prazo = prazo;
    

    }
  
    public virtual double CalcularPrestacao()
    {
        return valor / prazo;
    }
    public virtual void exibir()
    {
        Console.WriteLine("Nome : " + nome);
        Console.WriteLine("Detalhes : " + detalhes);
        Console.WriteLine("Email : " + email);
        Console.WriteLine("Telefone : " + telefone);
        Console.WriteLine("Prazo: " + prazo);
       
    }
}