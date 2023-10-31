/*
1º ArrayList: Uma coleção de objetos que cresce dinamicamente, permitindo elementos de tipos diferentes.
List: Uma coleção genérica de elementos de um tipo específico. Esta é a versão genérica do ArrayList.
Dictionary: Uma coleção de pares chave-valor, onde os elementos são acessados por meio de chaves únicas.
Queue: Uma coleção de elementos onde os elementos são acessados em uma ordem específica (FIFO - First-In-First-Out).
Stack: Uma coleção de elementos onde os elementos são acessados em uma ordem específica (LIFO - Last-In-First-Out).
HashSet: Uma coleção que armazena elementos únicos, semelhante a um conjunto matemático.
LinkedList: Uma lista encadeada dupla que permite inserções e remoções eficientes em qualquer posição.
SortedSet: Um conjunto ordenado que armazena elementos únicos e os mantém em ordem.
Queue<T>: A versão genérica da coleção Queue.
Stack<T>: A versão genérica da coleção Stack.
Dictionary<TKey, TValue>: A versão genérica da coleção Dictionary.
List<T>: A versão genérica da coleção List.
LinkedList<T>: A versão genérica da coleção LinkedList.
SortedList<TKey, TValue>: Uma coleção ordenada de pares chave-valor.
BitArray: Uma coleção que armazena valores booleanos como bits.
Hashtable: Uma versão não genérica do Dictionary.
Queue: Uma versão não genérica do Queue<T>.
Stack: Uma versão não genérica do Stack<T>.
SortedList: Uma versão não genérica do SortedList<TKey, TValue>. 
 */

using Collections.List;

#region Lista

var lista = new Lista();
lista.SolicitarPrimeiroNumero();
lista.SolicitarTodosNumeros();

#endregion