using System.ComponentModel.DataAnnotations;

public class Produto
{
    [Required(ErrorMessage = "A descrição é obrigatória.")]
    [MinLength(3, ErrorMessage = "A descrição deve ter pelo menos 3 caracteres.")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O preço é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "O estoque é obrigatório.")]
    [Range(0, int.MaxValue, ErrorMessage = "O estoque deve ser um número não negativo.")]
    public int Estoque { get; set; }

    [Required(ErrorMessage = "O código do produto é obrigatório.")]
    [CustomCodigoProdutoValidation] // Aplicando a validação personalizada
    public string CodigoProduto { get; set; }
}
