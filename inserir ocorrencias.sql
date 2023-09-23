USE [db_security]
GO

INSERT INTO [dbo].[tb_ocorrencia]
           ([registrador]
           ,[Data]
           ,[Hora]
           ,[Tipo]
           ,[CEP]
           ,[UF]
           ,[Cidade]
           ,[Bairro]
           ,[Rua]
           ,[Num]
           ,[Info]
           ,[Solicitante])
     VALUES
    ('222.222.222-22', '19/10/2021', '23:49', 'Perda de Documento', '09550-750', 'SP', 'SÃO CAETANO DO SUL', 'PROSPERIDADE', 'RUA PERITE', '444', 'Estava passeando bêbado e quando cheguei estava sem meus documentos', '222.222.222-22'),
    ('333.333.333-33', '10/12/2021', '14:25', 'Roubo ou Furto de Veículo', '12345-678', 'RJ', 'RIO DE JANEIRO', 'COPACABANA', 'AVENIDA X', '555', 'Carro roubado durante a noite', '333.333.333-33'),
    ('444.444.444-44', '05/11/2021', '09:15', 'Furto de Documento', '56789-012', 'SP', 'SÃO PAULO', 'VILA MADALENA', 'RUA Y', '666', 'Documento furtado na estação de metrô', '444.444.444-44'),
    ('555.555.555-55', '28/09/2021', '17:30', 'Furto de Celular', '98765-432', 'RJ', 'NITERÓI', 'IPANEMA', 'AVENIDA Z', '777', 'Celular furtado em um restaurante', '555.555.555-55'),
    ('666.666.666-66', '15/07/2021', '11:55', 'Furto de Placa de Veículo', '21098-765', 'SP', 'SÃO PAULO', 'MOEMA', 'RUA A', '888', 'Placa do carro furtada durante a noite', '666.666.666-66'),
    ('777.777.777-77', '02/04/2021', '16:40', 'Furto de Bicicleta', '54321-098', 'RJ', 'RIO DE JANEIRO', 'CENTRO', 'AVENIDA B', '999', 'Bicicleta furtada na frente de casa', '777.777.777-77'),
    ('888.888.888-88', '20/01/2022', '13:20', 'Perda de Documento', '76543-210', 'SP', 'SANTOS', 'BOQUEIRÃO', 'RUA C', '111', 'Perdi minha carteira de identidade no ônibus', '888.888.888-88'),
    ('999.999.999-99', '12/08/2022', '08:10', 'Perda de Celular', '01234-567', 'MG', 'BELO HORIZONTE', 'FUNCIONÁRIOS', 'AVENIDA D', '222', 'Celular perdido no shopping', '999.999.999-99'),
    ('123.456.789-10', '03/03/2022', '21:05', 'Perda de Placa de Veículo', '76543-210', 'SP', 'SÃO PAULO', 'MOOCA', 'RUA E', '333', 'Placa do carro perdida durante uma viagem', '123.456.789-10'),
    ('987.654.321-00', '14/06/2022', '10:30', 'Roubo de Documento', '54321-098', 'RJ', 'NITERÓI', 'ICARAÍ', 'AVENIDA F', '444', 'Assalto no centro da cidade, levaram minha bolsa com documentos', '987.654.321-00'),
    ('111.222.333-44', '25/09/2022', '15:45', 'Roubo de Celulares', '21098-765', 'SP', 'SÃO PAULO', 'VILA OLÍMPIA', 'RUA G', '555', 'Fui abordado por assaltantes e roubaram meus dois celulares', '111.222.333-44'),
    ('222.333.444-55', '08/12/2022', '12:15', 'Roubo de Objetos', '01234-567', 'MG', 'BELO HORIZONTE', 'LAGOA SANTA', 'AVENIDA H', '666', 'Casa arrombada, levaram objetos de valor', '222.333.444-55'),
    ('333.444.555-66', '21/03/2023', '19:50', 'Injúria, Calúnia ou Difamação', '76543-210', 'SP', 'SÃO CAETANO DO SUL', 'BARCELONA', 'RUA I', '777', 'Sofri injúria verbal no ambiente de trabalho', '333.444.555-66'),
    ('444.555.666-77', '02/07/2023', '08:30', 'Acidente de Trânsito Sem Vítimas', '54321-098', 'RJ', 'RIO DE JANEIRO', 'JACAREPAGUÁ', 'AVENIDA J', '888', 'Colisão entre dois carros, sem feridos', '444.555.666-77'),
    ('555.666.777-88', '15/10/2023', '16:25', 'Desaparecimento de Pessoas', '21098-765', 'SP', 'SÃO PAULO', 'MOEMA', 'RUA K', '999', 'Meu parente está desaparecido há três dias', '555.666.777-88'),
    ('666.777.888-99', '28/01/2024', '13:55', 'Encontro de Pessoas', '01234-567', 'MG', 'BELO HORIZONTE', 'FUNCIONÁRIOS', 'AVENIDA L', '111', 'Marcamos um encontro e a pessoa não compareceu', '666.777.888-99'),
    ('777.888.999-00', '11/04/2024', '10:40', 'Furto de Fios/Cabos', '76543-210', 'SP', 'SANTOS', 'PONTA DA PRAIA', 'RUA M', '222', 'Furtaram os fios de energia do poste', '777.888.999-00'),
    ('888.999.000-11', '24/07/2024', '18:15', 'Violência Doméstica', '54321-098', 'RJ', 'NITERÓI', 'ICARAÍ', 'AVENIDA N', '333', 'Sofri violência doméstica por parte do meu companheiro', '888.999.000-11'),
    ('999.000.111-22', '06/11/2024', '11:35', 'Fraude e Estelionato', '21098-765', 'SP', 'SÃO PAULO', 'VILA MADALENA', 'RUA O', '444', 'Fui vítima de um golpe financeiro', '999.000.111-22'),
    ('111.222.333-44', '19/02/2025', '09:20', 'Delegacia da Diversidade Online', '01234-567', 'MG', 'BELO HORIZONTE', 'LAGOA SANTA', 'AVENIDA P', '555', 'Registro de ocorrência relacionada à diversidade online', '111.222.333-44'),
    ('222.333.444-55', '04/05/2025', '15:10', 'DEPA - Proteção Animal', '76543-210', 'SP', 'SÃO PAULO', 'MOOCA', 'RUA Q', '666', 'Denúncia de maus tratos a animais', '222.333.444-55'),
    ('333.444.555-66', '17/08/2025', '12:45', 'Outras Ocorrências', '54321-098', 'RJ', 'RIO DE JANEIRO', 'COPACABANA', 'AVENIDA R', '777', 'Ocorrência não classificada em nenhuma categoria específica', '333.444.555-66');


GO


