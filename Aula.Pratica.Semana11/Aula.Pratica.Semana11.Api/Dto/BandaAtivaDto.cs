namespace Aula.Pratica.Semana11.Api.Dto
{
    public class BandaAtivaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AnoBanda { get; set; }
        public List<BandaPessoaVocalDto> BandaPessoaVocalDtos { get; set; }
    }

    public class BandaPessoaVocalDto
    {
        public int Id { get; set; }
        public string NomeDaPessoa { get; set; }
        public string? Instrumento { get; set; }

    }
}
