CREATE PROCEDURE SP_INSERIR_ALTERAR_EXCLUIR_EDITORAS
@Operacao int,
@Id_Ed int=NULL, 
@Nome varchar(100)=NULL
AS
BEGIN

IF(@Operacao=1) -- Operação Nº 1 INSERIR
BEGIN
INSERT INTO tbEditora(editora) VALUES(@Nome)
SELECT @@Identity
END

ELSE IF(@Operacao=2) -- Operação Nº 3 ACTUALIZAR
BEGIN
UPDATE tbEditora SET editora=@Nome WHERE id_editora=@Id_Ed
END

ELSE IF(@Operacao=3) -- Operação Nº 3 ExCLUIR
BEGIN
DELETE FROM tbEditora WHERE id_editora =@Id_Ed
END

ELSE
BEGIN
 RAISERROR('Acção ou Operação Não Foi Implementada',14,1);
END

END
