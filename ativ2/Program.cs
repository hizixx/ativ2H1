using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class CustomCodigoProdutoValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var codigoProduto = value as string;

        if (string.IsNullOrEmpty(codigoProduto))
        {
            return new ValidationResult("O c�digo do produto � obrigat�rio.");
        }

        // Verificar se segue o formato "AAA-1234"
        var codigoPattern = @"^[A-Z]{3}-\d{4}$";
        if (!Regex.IsMatch(codigoProduto, codigoPattern))
        {
            return new ValidationResult("O c�digo do produto deve seguir o formato 'AAA-1234', onde 'AAA' s�o letras mai�sculas e '1234' s�o n�meros.");
        }

        return ValidationResult.Success;
    }
}
