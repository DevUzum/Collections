/*
 
A classe List<T> é uma coleção genérica em C# que faz parte do namespace System.Collections.Generic. Ela é uma das 
coleções mais comuns e amplamente utilizadas no C# para armazenar uma lista de elementos de um tipo específico.
 
1º Tipo Genérico: A classe List<T> é genérica, o que significa que você precisa especificar o tipo de dados dos elementos que serão armazenados na lista quando a cria.

2º Tamanho Dinâmico: A List<T> tem um tamanho dinâmico, o que significa que você pode adicionar ou remover elementos conforme necessário. O tamanho da lista é ajustado automaticamente à medida que você adiciona ou remove elementos.

3º Acesso por Índice: Os elementos em uma List<T> são acessados por meio de um índice inteiro, que começa em 0. Isso permite um acesso rápido aos elementos.

4º Tipo de Dados Homogêneo: Uma List<T> contém elementos do mesmo tipo de dados, pois é uma coleção genérica.

5º Eficiência: As operações de acesso, adição, remoção e pesquisa em uma List<T> têm um bom desempenho devido à sua estrutura de array redimensionável.

6º Métodos e Propriedades Úteis: A classe List<T> oferece muitos métodos úteis para manipular a lista, como Add, Remove, Clear, Contains, IndexOf, Sort e muito mais.

 */

namespace Collections.List
{
    public class Lista
    {
        public Lista()
        {
            ListaDeNumeros = new List<int> { 1, 2, 3 };

            ListaDeNumeros.Add(4);
            ListaDeNumeros.Add(5);
            ListaDeNumeros.Add(6);
        }

        public List<int> ListaDeNumeros { get; set; } = new List<int>();

        public void SolicitarPrimeiroNumero()
        {
            Console.WriteLine($"Primeiro Número: {ListaDeNumeros[0]}");
        }

        public void SolicitarTodosNumeros()
        {
            Console.WriteLine("Contagem Egressão:");

            foreach (var numero in ListaDeNumeros)
            {
                Console.Write($"{numero}, ");
            }
        }
    }
}
