namespace Models
{
    public class ImplicitObjetoResponse
    {
        // 1 - Nome Informado
        public string CodigoConcatenadoNome { get; set; }
        public int AnoNascimento { get; set; }
        public int MesNascimento { get; set; }

        public static implicit operator ImplicitObjetoResponse(ImplicitObjetoRequest model)
        {
            return new ImplicitObjetoResponse
            {
                CodigoConcatenadoNome = $"{model.Codigo} - {model.Nome}",
                AnoNascimento = model.DataNascimento.Year,
                MesNascimento = model.DataNascimento.Month
            };
        }
    }
}
