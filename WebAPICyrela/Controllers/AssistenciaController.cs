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
    public class AssistenciaController : ControllerBase 
    {
        [HttpGet]
        public IActionResult Get()
        {
            var lista = new AssistenciaRepository().Listar();
            return Ok(lista);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Assistencia Assistencia)
        {
            try
            {
       
                AssistenciaRepository repository = new AssistenciaRepository(); 
                repository.Inserir(Assistencia);

            }
            catch (Exception)
            {
                return BadRequest();
            }

            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                AssistenciaRepository dal = new AssistenciaRepository();
                Assistencia assistencia = dal.Consultar(id);
                return Ok(assistencia);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Assistencia Assistencia)
        {
            try
            {
                AssistenciaRepository dal = new AssistenciaRepository();
                dal.Alterar(Assistencia);
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
                AssistenciaRepository repository = new AssistenciaRepository();
                repository.Excluir(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
