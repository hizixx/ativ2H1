using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class CustomCodigoProdutoValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var codigoProduto = value as string;

        if (string.IsNullOrEmpty(codigoProduto))
        {
            return new ValidationResult("O código do produto é obrigatório.");
        }

        // Verificar se segue o formato "AAA-1234"
        var codigoPattern = @"^[A-Z]{3}-\d{4}$";
        if (!Regex.IsMatch(codigoProduto, codigoPattern))
        {
            return new ValidationResult("O código do produto deve seguir o formato 'AAA-1234', onde 'AAA' são letras maiúsculas e '1234' são números.");
        }

        return ValidationResult.Success;
    }
}
