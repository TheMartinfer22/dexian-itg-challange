using System.ComponentModel.DataAnnotations;

namespace dexian_itg_challange.Model;

public class Aluno
{
    [Required(ErrorMessage = "O campo ICodAluno é obrigatório.")]
    public int ICodAluno { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    public string SNome { get; set; }

    [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "O campo CPF é obrigatório.")]
    public string SCPF { get; set; }
    
    [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
    public string SEndereco { get; set; }
    
    [Required(ErrorMessage = "O campo Celular é obrigatório.")]
    public string SCelular { get; set; }
    
    [Required(ErrorMessage = "O campo de código da escola é obrigatório.")]
    public int ICodEscola { get; set; }
}