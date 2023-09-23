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
    ('Maria do Carmo', 'mariadocarmo@gmail.com', '785.461.371-32', '5741', '09380-540', 'SP', 'MAUÁ', 'JARDIM ORATÓRIO', 'TRAVESSA BALSAS', '(11) 4 5454-1111', '12, casa 5', '0'),
    ('Fulano de Tal', 'fulano@gmail.com', '123.456.789-10', '1234', '12345-678', 'SP', 'SÃO PAULO', 'CENTRO', 'RUA A', '(11) 9 8765-4321', '10', '1'),
    ('Beltrano da Silva', 'beltrano@gmail.com', '987.654.321-00', '5678', '54321-098', 'RJ', 'RIO DE JANEIRO', 'IPANEMA', 'AVENIDA B', '(21) 98765-4321', '20', '2'),
    ('José da Silva', 'jose@gmail.com', '456.789.123-45', '9012', '98765-432', 'SP', 'SANTOS', 'BOQUEIRÃO', 'AVENIDA C', '(13) 1234-5678', '5', '1'),
    ('Ana Souza', 'ana.souza@gmail.com', '321.654.987-00', '3456', '87654-321', 'MG', 'BELO HORIZONTE', 'SAVASSI', 'RUA D', '(31) 98765-4321', '15', '2'),
    ('Carlos Ferreira', 'carlosferreira@gmail.com', '555.444.333-22', '6789', '56789-012', 'RJ', 'NITERÓI', 'ICARAÍ', 'RUA E', '(21) 98765-4321', '25', '0'),
    ('Mariana Oliveira', 'mariana.oliveira@gmail.com', '111.222.333-44', '2345', '54321-678', 'SP', 'SÃO PAULO', 'MOEMA', 'AVENIDA F', '(11) 98765-4321', '8', '1'),
    ('Roberto Santos', 'robertosantos@gmail.com', '999.888.777-66', '5678', '09876-543', 'RJ', 'RIO DE JANEIRO', 'COPACABANA', 'RUA G', '(21) 1234-5678', '18', '2'),
    ('Amanda Costa', 'amanda.costa@gmail.com', '777.666.555-44', '8901', '76543-210', 'SP', 'SANTOS', 'POMPÉIA', 'RUA H', '(13) 98765-4321', '7', '0'),
    ('Ricardo Mendes', 'ricardo.mendes@gmail.com', '444.555.666-88', '2345', '01234-567', 'MG', 'BELO HORIZONTE', 'FUNCIONÁRIOS', 'AVENIDA I', '(31) 1234-5678', '17', '1'),
    ('Luisa Fernandes', 'luisa.fernandes@gmail.com', '222.333.444-77', '6789', '54321-012', 'RJ', 'NITERÓI', 'SÃO FRANCISCO', 'RUA J', '(21) 98765-4321', '27', '2'),
    ('Paulo Rodrigues', 'paulo.rodrigues@gmail.com', '666.777.888-99', '0123', '21098-765', 'SP', 'SÃO PAULO', 'VILA MADALENA', 'RUA K', '(11) 1234-5678', '6', '0'),
    ('Renata Lima', 'renata.lima@gmail.com', '888.999.000-11', '4567', '98765-432', 'RJ', 'RIO DE JANEIRO', 'IPANEMA', 'AVENIDA L', '(21) 98765-4321', '16', '1'),
    ('Camila Santos', 'camila.santos@gmail.com', '555.444.333-22', '8901', '43210-987', 'SP', 'SANTOS', 'BOQUEIRÃO', 'RUA M', '(13) 98765-4321', '26', '2'),
    ('Fernando Almeida', 'fernando.almeida@gmail.com', '111.222.333-44', '2345', '67890-123', 'SP', 'SÃO PAULO', 'MOEMA', 'AVENIDA N', '(11) 98765-4321', '9', '0'),
    ('Juliana Gonçalves', 'juliana.goncalves@gmail.com', '999.888.777-66', '5678', '54321-012', 'RJ', 'RIO DE JANEIRO', 'COPACABANA', 'RUA O', '(21) 1234-5678', '19', '1'),
    ('Rafaela Silva', 'rafaela.silva@gmail.com', '777.666.555-44', '8901', '21098-765', 'SP', 'SANTOS', 'POMPÉIA', 'RUA P', '(13) 98765-4321', '28', '2'),
    ('Daniel Souza', 'daniel.souza@gmail.com', '444.555.666-88', '2345', '43210-987', 'MG', 'BELO HORIZONTE', 'FUNCIONÁRIOS', 'AVENIDA Q', '(31) 1234-5678', '8', '0'),
    ('Vitória Lima', 'vitoria.lima@gmail.com', '222.333.444-77', '6789', '67890-123', 'RJ', 'NITERÓI', 'SÃO FRANCISCO', 'RUA R', '(21) 98765-4321', '18', '1'),
    ('Pedro Rodrigues', 'pedro.rodrigues@gmail.com', '666.777.888-99', '0123', '54321-012', 'SP', 'SÃO PAULO', 'VILA MADALENA', 'RUA S', '(11) 1234-5678', '7', '2'),
    ('Mariana Pereira', 'mariana.pereira@gmail.com', '888.999.000-11', '4567', '09876-543', 'RJ', 'RIO DE JANEIRO', 'IPANEMA', 'AVENIDA T', '(21) 98765-4321', '17', '0'),
    ('Lucas Santos', 'lucas.santos@gmail.com', '555.444.333-22', '8901', '43210-987', 'SP', 'SANTOS', 'BOQUEIRÃO', 'RUA U', '(13) 98765-4321', '27', '1'),
    ('Marina Almeida', 'marina.almeida@gmail.com', '111.222.333-44', '2345', '21098-765', 'SP', 'SÃO PAULO', 'MOEMA', 'AVENIDA V', '(11) 98765-4321', '10', '2'),
    ('Rafael Gonçalves', 'rafael.goncalves@gmail.com', '999.888.777-66', '5678', '54321-012', 'RJ', 'RIO DE JANEIRO', 'COPACABANA', 'RUA X', '(21) 1234-5678', '20', '0');

GO
