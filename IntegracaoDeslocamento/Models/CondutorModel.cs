namespace IntegracaoDeslocamento.Models;

public class CondutorModel
{
    public CondutorModel(int id, string nome, string numeroHabilitacao, string categoriaHabilitacao, DateTime vencimentoHabilitacao)
    {
        Id = id;
        Nome = nome;
        NumeroHabilitacao = numeroHabilitacao;
        CategoriaHabilitacao = categoriaHabilitacao;
        VencimentoHabilitacao = vencimentoHabilitacao;
    }

    public int Id { get; set; }

    public string Nome { get; set; }

    public string NumeroHabilitacao { get; set; }

    public string CategoriaHabilitacao { get; set; }

    public DateTime VencimentoHabilitacao { get; set; }
}
