using System.Collections.Generic;
using System.Web.Http;

public class AdvogadosController : ApiController
{
    private readonly AdvogadoService _service = new AdvogadoService();

    [HttpGet]
    public IEnumerable<Advogado> Get()
    {
        return _service.GetAllAdvogados();
    }

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


    [HttpPost]
    public IHttpActionResult Post([FromBody] Advogado advogado)
    {
        _service.AddAdvogado(advogado);
        return Ok(advogado);
    }

    [HttpPut]
    public IHttpActionResult Put(int id, [FromBody] Advogado advogado)
    {
        if (_service.GetAdvogadoById(id) == null)
            return NotFound();

        _service.UpdateAdvogado(advogado);
        return Ok(advogado);
    }

    [HttpDelete]
    public IHttpActionResult Delete(int id)
    {
        if (_service.GetAdvogadoById(id) == null)
            return NotFound();

        _service.DeleteAdvogado(id);
        return Ok();
    }
}
