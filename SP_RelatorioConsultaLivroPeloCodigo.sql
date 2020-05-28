CREATE PROCEDURE SP_RelatorioConsultaLivroPeloCodigo
@CODIGO_LIVRO int
AS
BEGIN
SELECT tbLivro.id_livro,tbLivro.titulo,tbAutor.nome,tbEditora.editora,
tbLivro.edicao,tbLivro.estante,tbLivro.exemplar,tbLivro.foto 
FROM tbLivro INNER JOIN tbAutor ON tbLivro.id_autor = tbAutor.id_autor 
JOIN tbEditora ON tbLivro.id_editora=tbEditora.id_editora WHERE tbLivro.id_livro=@CODIGO_LIVRO
END