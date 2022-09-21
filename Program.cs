using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

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
            });

      central.SelecionarEExecutar();
    }
  }
}
