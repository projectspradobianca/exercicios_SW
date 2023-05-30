public class PessoaJuridica:Contrato
{

    private string inscricao_estadual;
    private string cnpj;
    private string empresa;

    public PessoaJuridica(string detalhes,string email, string telefone,string nome, string cnpj, string inscricao_estadual, string empresa, int prazo)
        : base(detalhes, email, telefone, nome, prazo)
        
    {
        this.inscricao_estadual = inscricao_estadual;
        this.cnpj = cnpj;
        this.empresa = empresa;
        
      



    }
    
    public override double Calcular_prestacao()
    {
        double prestacao = base.Calcular_prestacao();
        return prestacao + 3.0;
    }

    public override void exibir()
    {
        base.exibir();
        Console.WriteLine("Inscrição Estadual : " + inscricao_estadual);
        Console.WriteLine("CNPJ : " + cnpj);
        Console.WriteLine("Nome da empresa : " + empresa);
        



    }
}