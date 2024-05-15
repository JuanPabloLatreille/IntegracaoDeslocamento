namespace IntegracaoDeslocamento.DTOs.CondutorDTOs;

public class CadastrarCondutorDTO
{
    public CadastrarCondutorDTO(string nome, string numeroHabilitacao, string categoriaHabilitacao, DateTime vencimentoHabilitacao)
    {
        Nome = nome;
        NumeroHabilitacao = numeroHabilitacao;
        CategoriaHabilitacao = categoriaHabilitacao;
        VencimentoHabilitacao = vencimentoHabilitacao;
    }

    public string Nome { get; set; }

    public string NumeroHabilitacao { get; set; }

    public string CategoriaHabilitacao { get; set; }

    public DateTime VencimentoHabilitacao { get; set; }
}
