using System.ComponentModel.DataAnnotations;
using dexian_itg_challange.Model;
using dexian_itg_challange.Service.impl;

namespace dexian_itg_challange.Service
{
    public class AlunoService : IAlunoService
    {
        private static List<Aluno> _alunos = new();

        public List<Aluno> GetAlunos()
        {
            return _alunos;
        }

        public Aluno GetAlunoById(int id)
        {
            return _alunos.FirstOrDefault(aluno => aluno.ICodAluno == id) ?? throw new InvalidOperationException("Aluno não encontrado.");
        }

        public void AddAluno(Aluno aluno)
        {
            if (aluno == null)
            {
                throw new ArgumentNullException(nameof(aluno), "O aluno não pode ser nulo.");
            }

            var validationContext = new ValidationContext(aluno, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(aluno, validationContext, validationResults, validateAllProperties: true))
            {
                throw new ArgumentException(string.Join("\n", validationResults.Select(r => r.ErrorMessage)));
            }
            var alunosCount = _alunos.Count;
            if (alunosCount == 0)
            {
                aluno.ICodAluno = 1;
            }
            else
            {
                aluno.ICodAluno = alunosCount + 2;
            }
            _alunos.Add(aluno);
        }

        public void UpdateAluno(int id, Aluno aluno)
        {
            if (aluno == null)
            {
                throw new ArgumentNullException(nameof(aluno), "O aluno não pode ser nulo.");
            }

            var validationContext = new ValidationContext(aluno, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(aluno, validationContext, validationResults, validateAllProperties: true))
            {
                throw new ArgumentException(string.Join("\n", validationResults.Select(r => r.ErrorMessage)));
            }

            int index = FindAlunoIndex(id);
            if (index == -1)
            {
                throw new KeyNotFoundException($"Aluno com ID {id} não encontrado.");
            }

            _alunos[index] = aluno;
        }


        public void DeleteAluno(int id)
        {
            Aluno aluno = GetAlunoById(id);
            _alunos.Remove(aluno);
        }

        private int FindAlunoIndex(int target)
        {
            return _alunos.FindIndex(aluno => aluno.ICodAluno == target);
        }
    }
}