# Navega até a pasta raiz onde o novo projeto será criado
cd C:\Users\rnam\source\repos\fgc-message-contracts

# Cria a solution para organizar o projeto compartilhado
dotnet new sln -n Fgc.MessageContracts

# Cria o projeto Class Library targeting .NET 8
dotnet new classlib -n Fgc.MessageContracts -f net8.0

# Adiciona o projeto à solution
dotnet sln add Fgc.MessageContracts\Fgc.MessageContracts.csproj
