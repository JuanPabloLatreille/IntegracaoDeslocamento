namespace IntegracaoDeslocamento.DTOs.CondutorDTOs;

public class EditarCondutorDTO
{
    public EditarCondutorDTO(int id, string categoriaHabilitacao, DateTime vencimentoHabilitacao)
    {
        Id = id;
        CategoriaHabilitacao = categoriaHabilitacao;
        VencimentoHabilitacao = vencimentoHabilitacao;
    }

    public int Id { get; set; }

    public string CategoriaHabilitacao { get; set; }

    public DateTime VencimentoHabilitacao { get; set; }
}
