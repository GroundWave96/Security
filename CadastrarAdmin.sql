USE [db_security]
GO

INSERT INTO [dbo].[tb_cadastro]
           ([Nome], [Email], [Cpf]
           ,[Senha]
           ,[Cep]
           ,[Uf]
           ,[Cidade]
           ,[Bairro]
           ,[Rua]
           ,[Celular]
           ,[Num_comp]
           ,[modo])
     VALUES
    ('ADMIN', 'ADMIN@EMAIL.COM', '000.000.000-00', 'admin', '00000-000', 'AA', 'ADMIN', 'ADMIN', 'ADMIN', '(00) 0 0000-0000', '00', '0');

GO
