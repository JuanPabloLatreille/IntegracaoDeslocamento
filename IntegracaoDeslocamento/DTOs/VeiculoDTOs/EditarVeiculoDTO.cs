namespace IntegracaoDeslocamento.DTOs.VeiculoDTOs;

public class EditarVeiculoDTO
{
    public EditarVeiculoDTO(int id, string marcaModelo, int anoFabricacao, int kmAtual)
    {
        Id = id;
        MarcaModelo = marcaModelo;
        AnoFabricacao = anoFabricacao;
        KmAtual = kmAtual;
    }

    public int Id { get; set; }

    public string MarcaModelo { get; set; }

    public int AnoFabricacao { get; set; }

    public int KmAtual { get; set; }
}
