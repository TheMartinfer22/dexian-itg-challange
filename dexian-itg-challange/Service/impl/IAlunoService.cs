
using dexian_itg_challange.Model;

namespace dexian_itg_challange.Service.impl;

public interface IAlunoService
{
    List<Aluno> GetAlunos();
    Aluno GetAlunoById(int id);
    void AddAluno(Aluno aluno);
    void UpdateAluno(int id, Aluno aluno);
    void DeleteAluno(int id);
}