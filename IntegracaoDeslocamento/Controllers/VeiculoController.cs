using IntegracaoDeslocamento.DTOs.VeiculoDTOs;
using IntegracaoDeslocamento.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace IntegracaoDeslocamento.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VeiculoController : ControllerBase
{
    private readonly string _urlBase = "https://api-deslocamento.herokuapp.com/";

    [HttpGet]
    public async Task<IActionResult> ConsultarVeiculosAsync()
    {
        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var response = await client.GetAsync("api/v1/Veiculo");

        var responseData = await response.Content.ReadAsStringAsync();

        var veiculos = JsonConvert.DeserializeObject<IEnumerable<VeiculoModel>>(responseData);

        return Ok(veiculos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ConsultarVeiculoIdAsync([FromRoute] int id)
    {
        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var response = await client.GetAsync($"api/v1/Veiculo/{id}");

        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        {
            return NotFound();
        }

        var responseData = await response.Content.ReadAsStringAsync();

        var veiculo = JsonConvert.DeserializeObject<VeiculoModel>(responseData);

        return Ok(veiculo);
    }

    [HttpPost]
    public async Task<IActionResult> CadastrarVeiculoAsync([FromBody] CadastrarVeiculoDTO cadastrarVeiculoDTO)
    {
        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var json = JsonConvert.SerializeObject(cadastrarVeiculoDTO);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var postAsync = await client.PostAsync("api/v1/Veiculo", content);

        var responseData = await postAsync.Content.ReadAsStringAsync();

        return Ok(responseData);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> EditarVeiculoAsync([FromRoute] int id, [FromBody] EditarVeiculoDTO editarVeiculoDTO)
    {
        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var json = JsonConvert.SerializeObject(editarVeiculoDTO);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var putAsync = await client.PutAsync($"api/v1/Veiculo/{id}", content);

        var responseData = await putAsync.Content.ReadAsStringAsync();

        return Ok(responseData);
    }
}
