using Cepedi.Domain;
using Cepedi.Domain.Entities;
using Cepedi.Domain.Handlers;
using Cepedi.Shareable.Requests;
using NSubstitute;

namespace Cepedi.Domain.Tests;
public class AlteraCursoHandlerTests
{
    private readonly ICursoRepository _cursoRepository = Substitute.For<ICursoRepository>();

    private readonly AlteraCursoHandler _sut;

    public AlteraCursoHandlerTests()
    {
        _sut = new AlteraCursoHandler(_cursoRepository);
    }

    [Fact]
    public async Task AlteraCursoAsync_QuandoAlterado_DeveRetornarSucesso()
    {
        // Arrange
        var curso = new AlteraCursoRequest(
            1,
            "Teste",
            "Descricao",
            DateTime.Now,
            DateTime.Now,
            1
            );
        var cursoMock = new CursoEntity { Nome = "teste" };
        _cursoRepository.ObtemCursoPorIdAsync(curso.idCurso).Returns(cursoMock);
        _cursoRepository.AlterarCursoAsync(cursoMock).Returns(cursoMock);

        // Act
        var result = await _sut.AlterarCursoAsync(curso);


        // Assert 
        Assert.Equal(result.Nome, curso.Nome);
    }
}
