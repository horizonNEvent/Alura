// Avaliacao avaliacao = new Avaliacao("Carla Silva");
// avaliacao.AtribuirNota(11);   // inválido
// avaliacao.AtribuirNota(8.5);  // válido

// Paciente paciente = new Paciente("Luiz Costa", 42);
// HistoricoMedico historico = new HistoricoMedico("XPT-9987");
// historico.ExibirCodigo();

Projeto projeto = new Projeto("Sistema de Inventário");
projeto.AdicionarTarefa("Criar tela de login");
projeto.AdicionarTarefa("Implementar banco de dados");
projeto.ExibirTarefas();