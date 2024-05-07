using dexian_itg_challange.Model;

namespace dexian_itg_challange.Service.impl;

public interface IEscolaService
{
    List<Escola> GetEscolas();
    Escola GetEscolaById(int id);
    void AddEscola(Escola escola);
    void UpdateEscola(int id, Escola escola);
    void DeleteEscola(int id);
}