using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json; 

namespace target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            Exercicio1();

            // Exercício 2
            Exercicio2(21); // Informe aqui o número desejado para verificar na sequência de Fibonacci

            // Exercício 3
            string caminhoJson = "faturamento.json";
            if (File.Exists(caminhoJson))
            {
                string jsonContent = File.ReadAllText(caminhoJson);
                List<FaturamentoDiario> faturamentoMensal = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(jsonContent);
                if (faturamentoMensal != null)
                {
                    Exercicio3(faturamentoMensal);
                }
                else
                {
                    Console.WriteLine("Erro ao processar o arquivo JSON de faturamento.");
                }
            }
            else
            {
                Console.WriteLine("Arquivo faturamento.json não encontrado.");
            }

            // Exercício 4
            Exercicio4();

            // Exercício 5
            Exercicio5("Me contrata porfavor");
        }

        static void Exercicio1()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine("Exercício 1 = " + SOMA);
        }

        static void Exercicio2(int numero)
        {
            int a = 0, b = 1;
            bool pertence = false;

            while (a <= numero)
            {
                if (a == numero)
                {
                    pertence = true;
                    break;
                }
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine($"Exercício 2 = O número {numero} {(pertence ? "pertence" : "não pertence")} à sequência de Fibonacci.");
        }

        static void Exercicio3(List<FaturamentoDiario> faturamentoMensal)
        {
            // Filtrar apenas os dias com faturamento (ignorar dias com faturamento igual a zero)
            var diasComFaturamento = faturamentoMensal.Where(f => f.Valor > 0).ToList();

            if (diasComFaturamento.Count > 0)
            {
                // Menor e maior valor
                double menorValor = diasComFaturamento.Min(f => f.Valor);
                double maiorValor = diasComFaturamento.Max(f => f.Valor);

                // Média mensal
                double mediaMensal = diasComFaturamento.Average(f => f.Valor);

                // Número de dias com faturamento acima da média
                int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > mediaMensal);

                Console.WriteLine("Exercício 3:");
                Console.WriteLine($"Menor valor de faturamento: {menorValor:C}");
                Console.WriteLine($"Maior valor de faturamento: {maiorValor:C}");
                Console.WriteLine($"Número de dias acima da média mensal: {diasAcimaDaMedia}");
            }
            else
            {
                Console.WriteLine("Não há faturamento diário válido.");
            }
        }

        static void Exercicio4()
        {
            // Dados de faturamento por estado
            var faturamentoPorEstado = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            // Calculando o faturamento total
            double faturamentoTotal = faturamentoPorEstado.Values.Sum();

            // Exibindo a representação percentual de cada estado
            Console.WriteLine("Exercício 4:");
            foreach (var estado in faturamentoPorEstado)
            {
                double percentual = (estado.Value / faturamentoTotal) * 100;
                Console.WriteLine($"Estado: {estado.Key}, Faturamento: {estado.Value:C}, Percentual: {percentual:F2}%");
            }
        }

        static void Exercicio5(string input)
        {
            // Função para inverter a string
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray); // Reversão manual da string
            string reversed = new string(charArray);

            // Exibe o resultado
            Console.WriteLine("Exercício 5:");
            Console.WriteLine($"String original: {input}");
            Console.WriteLine($"String invertida: {reversed}");
        }
    }

    public class FaturamentoDiario
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}
