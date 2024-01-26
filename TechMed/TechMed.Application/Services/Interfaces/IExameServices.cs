namespace TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
public interface IExameService
{
    public List<ExameViewModel> GetAll();
    public ExameViewModel? GetById(int id);
    public List<ExameViewModel>? GetByIdMed(int id);
    public int Create(NewExameInputModel medico);
    public void Update(int id, NewExameInputModel medico);
    public void Delete(int id);
}
