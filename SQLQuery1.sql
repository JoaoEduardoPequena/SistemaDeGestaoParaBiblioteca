SELECT tbReservaLivro.id_reserva,tbLeitor.nome, tbLivro.titulo,tbReservaLivro.data_reserva, tbReservaLivro.data_limite,tbReservaLivro.estado_reserva FROM tbReservaLivro INNER JOIN tbLeitor ON tbReservaLivro.id_leitor = tbLeitor.id_leitor INNER JOIN tbLivro ON tbReservaLivro.id_livro = tbLivro.id_livro

