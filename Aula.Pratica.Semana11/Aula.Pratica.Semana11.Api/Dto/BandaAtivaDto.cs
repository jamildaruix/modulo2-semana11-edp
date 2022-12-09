using System.ComponentModel.DataAnnotations;

namespace Aula.Pratica.Semana11.Api.Dto
{
    public class BandaAtivaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AnoBanda { get; set; }
        public List<BandaPessoaDto> BandaPessoaDtos { get; set; }
    }

    public class BandaPessoaDto
    {
        public int Id { get; set; }
        
        public string NomeDaPessoa { get; set; }

        public string? Instrumento { get; set; }
    }


    public class BandaPessoaUpdateDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string NomeDaPessoa { get; set; }

        public string? Instrumento { get; set; }

    }
}
