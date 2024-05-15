using AutoMapper;
using IntegracaoDeslocamento.DTOs.ClienteDTOs;
using IntegracaoDeslocamento.Models;

namespace IntegracaoDeslocamento.Mappers;

public class ClienteMapping : Profile
{
    public ClienteMapping()
    {
        CreateMap<ClienteModel, CadastrarClienteDTO>().ReverseMap();
        CreateMap<ClienteModel, EditarClienteDTO>().ReverseMap();
    }
}