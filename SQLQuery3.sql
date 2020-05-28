CREATE PROCEDURE SP_CONSULTAR_LIVRO_PELO_CODIGO
@CodigoLivro int
AS
(
SELECT tbLivro.id_livro,tbLivro.titulo,tbAutor.id_autor,tbEditora.id_editora,
tbLivro.edicao,tbLivro.estante,tbLivro.exemplar,tbLivro.foto 
FROM tbLivro INNER JOIN tbAutor ON tbLivro.id_autor = tbAutor.id_autor 
JOIN tbEditora ON tbLivro.id_editora=tbEditora.id_editora WHERE tbLivro.id_livro=@CodigoLivro
)



