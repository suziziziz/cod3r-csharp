using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;

namespace CursoCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Cometarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadore Ternário - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IF ELSE - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF ELSE IF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura DoWhile - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Break - Estruturas de Controle", Break.Executar},
                {"Continue - Estruturas de Controle", Continue.Executar},

                // Classes E Métodos
                {"Membros - Classes E Métodos", Membros.Executar},
                {"Construtores - Classes E Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes E Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes E Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes E Métodos", AtributosEstaticos.Executar},
                {"Desafio Acessar Atributo - Classes E Métodos", DesafioAcessarAtributo.Executar},
                {"Parâmetros Variáveis - Classes E Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes E Métodos", ParametrosNomeados.Executar},
                {"Get e Set - Classes E Métodos", GetSet.Executar},
                {"Props - Classes E Métodos", Props.Executar},
                {"Readonly - Classes E Métodos", Readonly.Executar},
                {"Enum - Classes E Métodos", ExEnum.Executar},
                {"Struct - Classes E Métodos", Struct.Executar},
                {"Struct VS Classe - Classes E Métodos", StructVSClasse.Executar},
                {"Valor VS Referencia - Classes E Métodos", ValorVsReferencia.Executar},
                {"Parâmetros Por Referência - Classes E Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetros Com Valor Padrão - Classes E Métodos", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", Colecoes.List.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecaoStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar},
                {"Prolimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed - Orientação a Objetos", Sealed.Executar},

                // Métodos e Funções
                {"Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambda Delegate - Métodos e Funções", DelegateLambda.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegate com Funções Anônimas - Métodos e Funções", DelegateFuncaoAnonima.Executar},
                {"Delegate com Parâmetros - Métodos e Funções", ParamDelegate.Executar},
                {"Método de Extensão - Métodos e Funções", ExtensaoMetodo.Executar},

                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceção Personalizada - Exceções", ExcecoesPersonalizadas.Executar},

                // API
                {"Primeiro Arquivo - API", PrimeiroArquivo.Executar},
                {"Lendo Arquivo - API", LendoArquivo.Executar},
                {"File Info - API", ExemploFileInfo.Executar},
                {"Directory - API", Diretorios.Executar},
                {"Directory Info - API", ExemploDirectoryInfo.Executar},
                {"Usando Path - API", UsandoPath.Executar},
                {"Usando DateTime - API", UsandoDateTime.Executar},
                {"Usando TimeSpan - API", UsandoTimeSpan.Executar},
            });

      central.SelecionarEExecutar();
    }
  }
}
