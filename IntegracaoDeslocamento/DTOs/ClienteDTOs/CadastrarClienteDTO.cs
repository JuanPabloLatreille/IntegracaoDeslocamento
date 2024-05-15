﻿namespace IntegracaoDeslocamento.DTOs.ClienteDTOs;

public class CadastrarClienteDTO
{
    public CadastrarClienteDTO(string numeroDocumento, string tipoDocumento, string nome, string logradouro, string numero, string bairro, string cidade, string uf)
    {
        NumeroDocumento = numeroDocumento;
        TipoDocumento = tipoDocumento;
        Nome = nome;
        Logradouro = logradouro;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Uf = uf;
    }

    public string NumeroDocumento { get; set; }

    public string TipoDocumento { get; set; }

    public string Nome { get; set; }

    public string Logradouro { get; set; }

    public string Numero { get; set; }

    public string Bairro { get; set; }

    public string Cidade { get; set; }

    public string Uf { get; set; }
}
