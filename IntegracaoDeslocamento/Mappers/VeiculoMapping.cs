using AutoMapper;
using IntegracaoDeslocamento.DTOs.VeiculoDTOs;
using IntegracaoDeslocamento.Models;

namespace IntegracaoDeslocamento.Mappers;

public class VeiculoMapping : Profile
{
    public VeiculoMapping()
    {
        CreateMap<VeiculoModel, CadastrarVeiculoDTO>().ReverseMap();
        CreateMap<VeiculoModel, EditarVeiculoDTO>().ReverseMap();
    }
}
