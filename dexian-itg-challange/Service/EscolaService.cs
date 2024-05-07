using dexian_itg_challange.Model;
using dexian_itg_challange.Service.impl;

namespace dexian_itg_challange.Service
{
    public class EscolaService : IEscolaService
    {
        private static List<Escola> _escolas = new();

        public List<Escola> GetEscolas()
        {
            return _escolas;
        }

        public Escola GetEscolaById(int id)
        {
            return _escolas.FirstOrDefault(escola => escola.ICodEscola == id) ?? throw new InvalidOperationException("A escola não existe");
        }

        public void AddEscola(Escola escola)
        {
            if (escola == null)
            {
                throw new ArgumentNullException(nameof(escola), "A escola não pode ser nula.");
            }

            if (_escolas.Any(e => e.ICodEscola == escola.ICodEscola))
            {
                throw new InvalidOperationException("Já existe uma escola com o mesmo ID.");
            }

            _escolas.Add(escola);
        }

        public void UpdateEscola(int id, Escola escola)
        {
            if (escola == null)
            {
                throw new ArgumentNullException(nameof(escola), "A escola não pode ser nula.");
            }

            int index = FindEscolaIndex(id);
            if (index == -1)
            {
                throw new KeyNotFoundException($"Escola com ID {id} não encontrada.");
            }

            _escolas[index] = escola;
        }

        public void DeleteEscola(int id)
        {
            Escola escola = GetEscolaById(id);
            _escolas.Remove(escola);
        }

        private int FindEscolaIndex(int target)
        {
            return _escolas.FindIndex(escola => escola.ICodEscola == target);
        }
    }
}