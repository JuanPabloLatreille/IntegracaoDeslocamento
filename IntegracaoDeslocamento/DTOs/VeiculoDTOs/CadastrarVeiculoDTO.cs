namespace IntegracaoDeslocamento.DTOs.VeiculoDTOs;

public class CadastrarVeiculoDTO
{
    public CadastrarVeiculoDTO(string placa, string marcaModelo, int anoFabricacao, int kmAtual)
    {
        Placa = placa;
        MarcaModelo = marcaModelo;
        AnoFabricacao = anoFabricacao;
        KmAtual = kmAtual;
    }

    public string Placa { get; set; }

    public string MarcaModelo { get; set; }

    public int AnoFabricacao { get; set; }

    public int KmAtual { get; set; }
}
