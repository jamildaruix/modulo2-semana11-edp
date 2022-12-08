namespace Models
{
    public class ExplicitObjetoResponse
    {
        // 1 - Nome Informado
        public string CodigoConcatenadoNome { get; set; }
        public int AnoNascimento { get; set; }
        public int MesNascimento { get; set; }


        public static explicit operator ExplicitObjetoResponse(ExplicitObjetoRequest model)
        {
            return new ExplicitObjetoResponse
            {
                CodigoConcatenadoNome = $"{model.Codigo} - {model.Nome}",
                AnoNascimento = model.DataNascimento.Year,
                MesNascimento = model.DataNascimento.Month
            };
        }
    }
}
