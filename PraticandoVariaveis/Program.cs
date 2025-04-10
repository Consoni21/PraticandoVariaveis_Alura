using System;

namespace CalcIdade
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Escreva um programa em C# que, a partir do ano de nascimento de uma pessoa,
            //calcule a idade com base no ano atual.

            int anoNascimento = 2005;
            int anoAtual = 2025;
            int idade;

            idade = anoNascimento - anoAtual;
            Console.WriteLine(idade);

            //Declare uma variável para armazenar o valor recebido da doação.
            //Declare uma variável para indicar se a doação foi anônima (true para anônima, false para não anônima).
            //Declare uma variável para indicar o tipo de conta onde o valor foi depositado

            int doacao = 100;
            bool tipoDoacao = true;
            char tipoConta = 'P';

            Console.WriteLine(doacao);
            Console.WriteLine(tipoDoacao);
            Console.WriteLine(tipoConta);

            //Declare uma variável que receba o valor das milhas.
            //Calcule a distância em quilômetros e armazene o resultado em uma nova variável.
            //Exiba o resultado no console.

            int milhas = 10;
            double km = milhas * 1.60934;

            Console.WriteLine($"10 milhas valem {km}");

            //Declare uma variável com um valor inteiro representando o total de minutos.
            //Calcule quantas horas completas existem nesse valor e quantos minutos restam.
            //Exiba o resultado no formato X horas e Y minutos.

            int minutos = 250;
            int horas = minutos / 60;
            int restantesMinutos = minutos % 60;

            Console.WriteLine(horas + minutos);

            //Declare duas variáveis para a largura e comprimento, respectivamente.
            //Aplique a fórmula mencionada para calcular a área do terreno.
            //Exiba o resultado do cálculo.

            double largura = 10.5;
            double comprimento = 20.3;
            double area = largura * comprimento;

            Console.WriteLine(area);

            //Declare três variáveis do tipo float para armazenar as notas dos alunos.
            //Foi fornecido pela escola os seguintes valores (7.2, 8.3 e 9.1)
            //Calcule a média aritmética das três.
            //Exiba a média calculada.

            float nota1 = 7.2f;
            float nota2 = 8.3f;
            float nota3 = 9.1f;

            float media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine(media);

            //Receber o peso total em toneladas (decimal)
            //Converter para inteiro descartando a parte decimal
            //Exibir a quantidade mínima de veículos necessários

            decimal peso = 18.75m;
            int pesoPena = Convert.ToInt32(peso);

            Console.WriteLine(pesoPena);

            //Declarar uma variável com o número inicial de vidas.
            //Simular uma situação em que o jogador erra.
            //Simular que o jogador acerta duas vezes.
            //Armazene o valor final das vidas em uma nova variável.

            int vidas = 5;
            vidas--;
            vidas++;
            vidas++;
            int vidasFinais = vidas;

            Console.WriteLine(vidasFinais);

            //Defina uma variável para o salário atual (decimal).
            //Defina uma variável para o percentual de aumento (decimal).
            //Calcule o novo salário e o salve em uma nova variável (decimal).
            //Por fim, exiba o novo salário.

            decimal salario = 100m;
            decimal aumento = 20;
            decimal salarioPobre = salario + (salario * aumento / 100);

            Console.WriteLine(salarioPobre);

            //Declare uma variável que receba o valor de PI (considere PI como sendo igual a 3.14159).
            //Declare uma variável que receba o valor do raio do círculo.
            //Calcule e armazene em uma variável a área do círculo utilizando a fórmula: área = pi x raio x raio.
            //Calcule e armazene em uma variável o perímetro do círculo utilizando a fórmula: 2 * pi * raio.
            //Exiba os resultados no console.

            double valorPI = 3.14159;
            double raio = 5.0;
            Math.Pow(raio, 2);
            double areaPI = valorPI * raio;
            raio = 5.0;
            double perimetroCirculo = 2 * valorPI * raio;

            Console.WriteLine(areaPI);
            Console.WriteLine(perimetroCirculo);
        }
    }
}