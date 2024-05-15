using AutoMapper;
using IntegracaoDeslocamento.DTOs.CondutorDTOs;
using IntegracaoDeslocamento.Models;

namespace IntegracaoDeslocamento.Mappers;

public class CondutorMapping : Profile
{
    public CondutorMapping()
    {
        CreateMap<CondutorModel, CadastrarCondutorDTO>().ReverseMap();
    }
}
