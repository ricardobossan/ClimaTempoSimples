# Clima Tempo Simples

## Como executar

1. Abra o arquivo de solução _(.\ClimaTempoSimples.sln)_ no Visual Studio. Aguarde carregar os projetos.
2. Se quiser rodar banco de dados com informações geradas para teste, abra o console do gerenciador de pacotes NuGet _(Visual Studio > Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes)_, selecione `DAL` no dropdown de _Projeto Padrão_ e execute o comando `update-database`.
   1. ATENÇÃO: esta ação gerará dados no banco de dados. Se quiser apenas gerar o banco sem preenchê-lo com dados para teste, comente ou apague o corpo do método `.\DAL\Migrations\Configuration.cs.Configuration.Seed()`. Só após realizada esta etapa execute o comando `update-database` para gerar o banco sem gerar dados de teste.
3. Execute a aplicação apertando a tela `F5`
4. Selecione a cidade no dropdown do site, a fim de visualizar a previsão de 7 dias para ela.
5. Para interromper a execução do código, aperte a combinação de teclas `shift` + `F5`, no Visual Studio.

## Desenvolvimento

- Design pattern: Hexagonal (Ports and adapters)
- Fontes: https://www.c-sharpcorner.com/UploadFile/3d39b4/rendering-a-partial-view-and-json-data-using-ajax-in-Asp-Net/