using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;
using System.Web.Http;

public class AdvogadosController : ApiController
{
    private readonly AdvogadoService _service = new AdvogadoService();
    [EnableCors("*")]
    [HttpGet]
    public IEnumerable<Advogado> Get()
    {
        return _service.GetAllAdvogados();
    }

    [EnableCors("*")]
    [HttpGet]
    public IHttpActionResult Get(int id)
    {
        var advogado = _service.GetAdvogadoById(id);
        if (advogado == null)
        {
            return NotFound();
        }
        return Ok(advogado);
    }

    [EnableCors("*")]
    [HttpPost]
    public IHttpActionResult Post([FromBody] Advogado advogado)
    {
        _service.AddAdvogado(advogado);
        return Ok(advogado);
    }

    [EnableCors("*")]
    [HttpPut]
    public IHttpActionResult Put(int id, [FromBody] Advogado advogado)
    {
        if (_service.GetAdvogadoById(id) == null)
            return NotFound();

        _service.UpdateAdvogado(advogado);
        return Ok(advogado);
    }
    [EnableCors("*")]
    [HttpDelete]
    public IHttpActionResult Delete(int id)
    {
        if (_service.GetAdvogadoById(id) == null)
            return NotFound();

        _service.DeleteAdvogado(id);
        return Ok();
    }
}
