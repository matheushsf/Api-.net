using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

public class AdvogadoRepository
{
    private readonly AdvogadoContext _context = new AdvogadoContext();

    public IEnumerable<Advogado> GetAll() => _context.Advogados.ToList();

    public Advogado GetById(int id) => _context.Advogados.Find(id);

    public void Add(Advogado advogado)
    {
        _context.Advogados.Add(advogado);
        _context.SaveChanges();
    }

    public void Update(Advogado advogado)
    {
        var existingEntity = _context.Advogados.Find(advogado.Id);

        if (existingEntity != null)
        {
            // Atualize os campos da entidade existente com os valores da entidade fornecida
            _context.Entry(existingEntity).CurrentValues.SetValues(advogado);
        }
        else
        {
            _context.Advogados.Add(advogado);
        }

        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var advogado = _context.Advogados.Find(id);
        if (advogado != null)
        {
            _context.Advogados.Remove(advogado);
            _context.SaveChanges();
        }
    }
}
