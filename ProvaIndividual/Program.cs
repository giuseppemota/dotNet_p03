// ProvaIndividual/Program.cs
using ProvaIndividual;
using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");



Advogado giuseppe = new Advogado();
giuseppe.DataNascimento = new DateTime(13, 10, 1997);
giuseppe.Cpf = "123456789";
giuseppe.CNA = "123456789";
giuseppe.Nome = "Giuseppe";

Cliente henrique = new Cliente();
henrique.DataNascimento = new DateTime(25, 11, 1998);
henrique.Cpf = "123456733";
henrique.Nome = "Henrique";
henrique.Profissao = "Debugger";
henrique.EstadoCivil = true;


List<Advogado> advogados = new List<Advogado>();
advogados.Add(giuseppe);

List<Cliente> clientes = new List<Cliente>();
clientes.Add(henrique);
