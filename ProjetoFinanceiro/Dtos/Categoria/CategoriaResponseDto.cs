namespace ProjetoFinanceiro.Dtos.Categoria
{
    public class CategoriaResponseDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public Guid PainelId { get; set; }
    }
}
