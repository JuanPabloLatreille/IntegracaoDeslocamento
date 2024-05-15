namespace IntegracaoDeslocamento.DTOs.ClienteDTOs;

public class EditarClienteDTO
{
    public EditarClienteDTO(int id, string tipoDocumento, string nome, string logradouro, string numero, string bairro, string cidade, string uf)
    {
        Id = id;
        TipoDocumento = tipoDocumento;
        Nome = nome;
        Logradouro = logradouro;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Uf = uf;
    }

    public int Id { get; set; }

    public string TipoDocumento { get; set; }

    public string Nome { get; set; }

    public string Logradouro { get; set; }

    public string Numero { get; set; }

    public string Bairro { get; set; }

    public string Cidade { get; set; }

    public string Uf { get; set; }
}