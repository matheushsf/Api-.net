using System.Collections.Generic;

public class AdvogadoService
{
    private readonly AdvogadoRepository _repository = new AdvogadoRepository();

    public IEnumerable<Advogado> GetAllAdvogados() => _repository.GetAll();

    public Advogado GetAdvogadoById(int id) => _repository.GetById(id);

    public void AddAdvogado(Advogado advogado) => _repository.Add(advogado);

    public void UpdateAdvogado(Advogado advogado) => _repository.Update(advogado);

    public void DeleteAdvogado(int id) => _repository.Delete(id);
}
