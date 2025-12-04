ClientePF c1 = new ClientePF();
OrdemServico os1 = new OrdemServico();
ItemServico Is1 = new ItemServico();
Servico s1 = new Servico();

Is1._quantidade = 0;

c1._telefone = "69 998078976";
c1._data_cadastro = "03/12/2025";
c1._nome = "João do Teste";
c1._data_nascimento = "22/09/1989";
c1._cpf = "023.589.756-75";

s1._descricao = "Troca de Oleo";
s1._tempoEstimado = "30 minutos";

os1.dataInicio = "03/12/2025";
os1.status = "Aberto";
os1.porcentagemDesconto = 2;
os1.cliente = c1;

Is1._valorUnd = 180;
Is1._quantidade = 2;
Is1.ordemServico = os1;
Is1.servico = s1;




