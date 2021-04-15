using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICyrela.Models;
using WebAPICyrela.Repository;

namespace WebAPICyrela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OcorrenciaController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var lista = new OcorrenciaRepository().Listar();
                return Ok(lista);

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                OcorrenciaRepository repo = new OcorrenciaRepository();
                Ocorrencia ocorrencia = repo.Consultar(id);
                return Ok(ocorrencia);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Ocorrencia ocorrencia)
        {
            try
            {
                OcorrenciaRepository repo = new OcorrenciaRepository();
                repo.Inserir(ocorrencia);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Ocorrencia ocorrencia)
        {
            try
            {
                OcorrenciaRepository repo = new OcorrenciaRepository();
                repo.Alterar(ocorrencia);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                OcorrenciaRepository repo = new OcorrenciaRepository();
                repo.Excluir(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
