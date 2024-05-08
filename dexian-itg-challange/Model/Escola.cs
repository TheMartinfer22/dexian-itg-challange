using System.ComponentModel.DataAnnotations;

namespace dexian_itg_challange.Model;

public class Escola
{
    [Required(ErrorMessage = "O campo de código da escola é obrigatório.")]
    public int ICodEscola { get; set; } 

    [Required(ErrorMessage = "O campo descrição é obrigatório.")]
    public string SDescricao { get; set; }
}