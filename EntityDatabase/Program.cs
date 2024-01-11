using EntityDatabase.Models;

var context = new TechMedContext();



Console.WriteLine($"Criar um médico no banco de dados");

var medico = new Medico
{
    Nome = "Dr. Dexter",
    CPF = "123.456.789-00",
    CRM = "123456",
    Especialidade = "Clínico Geral",
    Salario = 10000
};

var medico2 = new Medico
{
    Nome = "Dr. Xavier",
    CPF = "987.654.321-00",
    CRM = "654321",
    Especialidade = "Pediatria",
    Salario = 20000
};
context.Medicos.Add(medico);

context.Medicos.Add(medico2);

Console.WriteLine($"Criar um paciente no banco de dados");
var paciente = new Paciente
{
    Nome = "Valber",
    CPF = "101.202.303-00",
    Endereco = "Rua A, 0",
    Telefone = "1234-5678"
};
var paciente2 = new Paciente
{
    Nome = "João",
    CPF = "101.202.353-00",
    Endereco = "Rua b, 0",
    Telefone = "1234-5670"
};

context.Pacientes.Add(paciente);

context.Pacientes.Add(paciente2);

var atendimento1 = new Atendimento
{
    DataHora = DateTime.Now,
    Medico = medico2,
    Paciente = paciente2
};

var atendimento2 = new Atendimento
{
    DataHora = DateTime.Now,
    Medico = medico2,
    Paciente = paciente
};

var atendimento3 = new Atendimento
{
    DataHora = DateTime.Now,
    Medico = medico,
    Paciente = paciente
};

var atendimento4 = new Atendimento
{
    DataHora = DateTime.Now,
    Medico = medico,
    Paciente = paciente
};

context.Atendimentos.Add(atendimento1);
context.Atendimentos.Add(atendimento2);
context.Atendimentos.Add(atendimento3);
context.Atendimentos.Add(atendimento4);

var exame1 = new Exame
{
    DataHora = DateTime.Now,
    Atendimento = atendimento1,
    Local = "Clinica"
};

var exame2 = new Exame
{
    DataHora = DateTime.Now,
    Atendimento = atendimento1,
    Local = "Hemocentro"
};

var exame3 = new Exame
{
    DataHora = DateTime.Now,
    Atendimento = atendimento2,
    Local = "Pediatria"
};

var exame4 = new Exame
{
    DataHora = DateTime.Now,
    Atendimento = atendimento2,
    Local = "Oncologia"
};

var exame5 = new Exame
{
    DataHora = DateTime.Now,
    Atendimento = atendimento3,
    Local = "Obistetria"
};

var exame6 = new Exame
{
    DataHora = DateTime.Now,
    Atendimento = atendimento4,
    Local = "Ginecologia"
};

context.Exames.Add(exame1);
context.Exames.Add(exame2);
context.Exames.Add(exame3);
context.Exames.Add(exame4);
context.Exames.Add(exame5);
context.Exames.Add(exame6);

context.SaveChanges();

Console.WriteLine($"Lendo todos os médicos no banco de dados");
foreach (var med in context.Medicos.OrderBy(m => m.Nome))
{
    Console.WriteLine($"Id: {med.MedicoId} - Nome: {med.Nome} - CRM: {med.CRM}");
}

Console.WriteLine($"Lendo todos os pacientes no banco de dados");
foreach (var pac in context.Pacientes.OrderBy(m => m.Nome))
{
    Console.WriteLine($"Id: {pac.PacienteId} - Nome: {pac.Nome} - CRM: {pac.CPF}");
}

Console.WriteLine($"Lendo todos os atendimentos no banco de dados");
foreach (var atd in context.Atendimentos)
{
    Console.WriteLine($"Id: {atd.AtendimentoId} - Data: {atd.DataHora}");
}

// Console.WriteLine($"Lendo todos os exames no banco de dados");
// foreach (var ex in context.Exames)
// {
//     Console.WriteLine($"Nome: {ex.Atendimento.Paciente.Nome} Local: {ex.Local}  - Data: {ex.DataHora}");
// }

paciente.Atendimentos.ToList().ForEach(atd => Console.WriteLine($"Paciente: {paciente.Nome} - Atendimento: {atd.DataHora}"));

Console.WriteLine($"Finalizando o programa");
