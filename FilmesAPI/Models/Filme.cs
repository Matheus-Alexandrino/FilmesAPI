using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Required(ErrorMessage = "O titulo do filme e obrigatorio")]
    [MaxLength(20, ErrorMessage = "O titulo nao pode exceder 20 caracteres")]
    public string Titulo { get; set; }
    
    [Required(ErrorMessage = "O genero do filme e obrigatorio")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duracao do filme e obrigatoria")]
    public int Duracao { get; set; }
    
}

