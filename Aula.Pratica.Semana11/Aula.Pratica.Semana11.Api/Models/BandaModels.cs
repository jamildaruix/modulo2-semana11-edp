namespace Aula.Pratica.Semana11.Api.Models
{
    public class BandaModels
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Album { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativa { get; set; }
        public List<BandaPessoaModels> BandaPessoaModels { get; set; }
    }

    public class BandaPessoaModels
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Instrumento { get; set; }
        public bool Vocal { get; set; }
    }
}
