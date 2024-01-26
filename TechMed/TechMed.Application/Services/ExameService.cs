using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;
using TechMed.Core.Exceptions;

namespace TechMed.Application.Services;
public class ExameService : IExameService
{
  private readonly ITechMedContext _context;
  public ExameService(ITechMedContext context)
  {
    _context = context;
  }

  public int Create(NewExameInputModel exame)
  {
    var atendimentoDB = _context.AtendimentosCollection.GetById(exame.AtendimentoId);
    Exame NewExame = new Exame
    {
      DataHora = exame.Data,
      MedicoId = atendimentoDB.Medico.MedicoId,
      PacienteId = atendimentoDB.Paciente.PacienteId,
      Medico = atendimentoDB.Medico,
      Paciente = atendimentoDB.Paciente,
      AtendimentoId = exame.AtendimentoId
    };
    atendimentoDB.Exames.Add(NewExame);
    return _context.ExamesCollection.Create(NewExame);

  }


  public void Delete(int id)
  {
    _context.ExamesCollection.Delete(id);
  }

  public List<ExameViewModel> GetAll()
  {
    var exames = _context.ExamesCollection.GetAll().Select(m => new ExameViewModel
    {
      ExameId = m.ExameId,
      Nome = m.Paciente.Nome,
      DataHora = m.DataHora
    }).ToList();

    return exames;

  }

  public List<ExameViewModel>? GetByIdMed(int id)
  {
    var medico = _context.MedicosCollection.GetById(id);
    var exames = _context.ExamesCollection.GetAll().Where(m => m.MedicoId == medico.MedicoId).Select(m => new ExameViewModel {
      ExameId = m.ExameId,
      Nome = m.Paciente.Nome,
      DataHora = m.DataHora
    }).ToList();
    return exames;
  }

  public ExameViewModel? GetById(int id)
  {
    var exame = _context.ExamesCollection.GetById(id);

    if (exame is null)
      return null;

    var ExameViewModel = new ExameViewModel
    {
      ExameId = exame.ExameId,
      Nome = exame.Paciente.Nome,
      DataHora = exame.DataHora
    };
    return ExameViewModel;
  }

  public void Update(int id, NewExameInputModel exame)
  {
    throw new NotImplementedException();
  }
}
