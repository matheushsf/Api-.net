using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

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
        _context.Entry(advogado).State = EntityState.Modified;
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
