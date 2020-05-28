CREATE PROCEDURE SP_LISTAR_TODOS_LIVROS

AS
BEGIN

SELECT tbLivro.id_livro,tbLivro.titulo,tbAutor.nome,tbEditora.editora,
tbLivro.edicao,tbLivro.foto 
FROM tbLivro INNER JOIN tbAutor 
ON tbLivro.id_autor = tbAutor.id_autor JOIN tbEditora 
ON tbLivro.id_editora=tbEditora.id_editora

END

