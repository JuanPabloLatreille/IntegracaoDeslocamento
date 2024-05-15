using IntegracaoDeslocamento.DTOs.ClienteDTOs;
using IntegracaoDeslocamento.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace IntegracaoDeslocamento.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly string _urlBase = "https://api-deslocamento.herokuapp.com/";

    [HttpGet]
    public async Task<IActionResult> ConsultarClientesAsync()
    {
        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var response = await client.GetAsync("api/v1/Cliente");

        var responseData = await response.Content.ReadAsStringAsync();

        var clientes = JsonConvert.DeserializeObject<IEnumerable<ClienteModel>>(responseData);

        return Ok(clientes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ConsultarClienteIdAsync([FromRoute] int id)
    {
        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var response = await client.GetAsync($"api/v1/Cliente/{id}");

        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        {
            return NotFound();
        }

        var responseData = await response.Content.ReadAsStringAsync();

        var cliente = JsonConvert.DeserializeObject<ClienteModel>(responseData);

        return Ok(cliente);
    }

    [HttpPost]
    public async Task<IActionResult> CadastrarClienteAsync([FromBody] CadastrarClienteDTO clienteDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var json = JsonConvert.SerializeObject(clienteDTO);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var postAsync = await client.PostAsync("api/v1/Cliente", content);

        var responseData = postAsync.Content.ReadAsStringAsync();

        return Ok(responseData.Result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> EditarClienteAsync([FromRoute] int id, [FromBody] EditarClienteDTO editarClienteDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(_urlBase);

        var json = JsonConvert.SerializeObject(editarClienteDTO);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var putAsync = await client.PutAsync($"api/v1/Cliente/{id}", content);

        var responseData = putAsync.Content.ReadAsStringAsync();

        return Ok(responseData.Result);
    }
}