/*
===============================================
APLICAÇÃO DAS HEURÍSTICAS DE NIELSEN NO CÓDIGO
===============================================

Heurística #1 - Visibilidade do Status do Sistema:
- Implementada através das mensagens que indicam o progresso do usuário no sistema.
- Exemplo:
  [Passo 1 de 3] - Seleção de Produto
  [Passo 2 de 3] - Quantidade
  [Passo 3 de 3] - Confirmação
- Isso permite que o usuário saiba exatamente em qual etapa do pedido ele está.

------------------------------------------------

Heurística #3 - Controle e Liberdade do Usuário:
- O usuário pode digitar comandos especiais em qualquer etapa:
  "voltar" → retorna para a etapa anterior
  "cancelar" → encerra o pedido imediatamente
- Implementado com verificações dentro dos loops (while).
- Isso evita que o usuário fique preso no fluxo sem opção de corrigir ou sair.

------------------------------------------------

Heurística #9 - Ajuda aos Usuários a Reconhecer, Diagnosticar e Corrigir Erros:
- O sistema trata entradas inválidas e fornece mensagens claras e específicas.
- Exemplos:
  "Entrada inválida! Digite apenas números."
  "Código 99 não encontrado. Nossos códigos vão de 1 a 10."
  "A quantidade deve ser maior que zero."
- Isso ajuda o usuário a entender o erro e como corrigi-lo.

===============================================
*/


