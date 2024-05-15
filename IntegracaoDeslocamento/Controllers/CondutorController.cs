using IntegracaoDeslocamento.DTOs.CondutorDTOs;
using IntegracaoDeslocamento.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace IntegracaoDeslocamento.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CondutorController : ControllerBase
{
    private readonly string _urlBase = "https://api-deslocamento.herokuapp.com/";

    [HttpGet]
    public async Task<IActionResult> ConsultarCondutoresAsync()
    {
        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var response = await client.GetAsync("api/v1/Condutor");

        var responseData = await response.Content.ReadAsStringAsync();

        var condutores = JsonConvert.DeserializeObject<IEnumerable<CondutorModel>>(responseData);

        return Ok(condutores);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ConsultarCondutorIdAsync([FromRoute] int id)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var response = await client.GetAsync($"api/v1/Condutor/{id}");

        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        {
            return NotFound();
        }

        var responseData = await response.Content.ReadAsStringAsync();

        var condutor = JsonConvert.DeserializeObject<CondutorModel>(responseData);

        return Ok(condutor);
    }

    [HttpPost]
    public async Task<IActionResult> CadastrarCondutorAsync([FromBody] CadastrarCondutorDTO cadastrarCondutorDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var json = JsonConvert.SerializeObject(cadastrarCondutorDTO);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var postAsync = await client.PostAsync("api/v1/Condutor", content);

        var responseData = postAsync.Content.ReadAsStringAsync();

        return Ok(responseData.Result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> EditarCondutorAsync([FromRoute] int id, [FromBody] EditarCondutorDTO editarCondutorDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var json = JsonConvert.SerializeObject(editarCondutorDTO);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var putAsync = await client.PutAsync($"api/v1/Condutor/{id}", content);

        var responseData = putAsync.Content.ReadAsStringAsync();

        return Ok(responseData.Result);
    }
}
