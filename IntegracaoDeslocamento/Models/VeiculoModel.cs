namespace IntegracaoDeslocamento.Models;

public class VeiculoModel
{
    public VeiculoModel(int id, string placa, string marcaModelo, int anoFabricacao, int kmAtual)
    {
        Id = id;
        Placa = placa;
        MarcaModelo = marcaModelo;
        AnoFabricacao = anoFabricacao;
        KmAtual = kmAtual;
    }

    public int Id { get; set; }

    public string Placa { get; set; }

    public string MarcaModelo { get; set; }

    public int AnoFabricacao { get; set; }

    public int KmAtual { get; set; }
}
