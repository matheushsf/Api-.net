public class Advogado
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public Senioridade Senioridade { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Estado { get; set; }
    public string CEP { get; set; }
    public string Numero { get; set; }
}

public enum Senioridade
{
    Junior,
    Pleno,
    Senior
}
