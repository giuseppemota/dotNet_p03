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

Cliente pedro = new Cliente();
pedro.DataNascimento = new DateTime(15, 05, 1993);
pedro.Cpf = "1234565342";
pedro.Nome = "Pedro";
pedro.Profissao = "Developer";
pedro.EstadoCivil = true;

EscritorioAdvocacia escritorio = new EscritorioAdvocacia();
escritorio.AdicionarAdvogado(giuseppe);
escritorio.AdicionarCliente(henrique);
escritorio.AdicionarCliente(pedro);
escritorio.RemoverAdvogado(giuseppe);
escritorio.RemoverCliente(henrique);

Relatorio.AdvogadoIdadeEntre(escritorio.Advogados, 18, 30);
Relatorio.ClienteIdadeEntre(escritorio.Clientes, 18, 30);
Relatorio.ClienteComProfissao(escritorio.Clientes, "Developer");
Relatorio.ClienteEstadoCivil(escritorio.Clientes);
Relatorio.ClienteOrdemAlfabetica(escritorio.Clientes);
Relatorio.PessoasAniversariantes(escritorio.Advogados, escritorio.Clientes, 12);


