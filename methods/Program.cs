
Console.WriteLine("");
/* 01 - Comece digitando o nome da classe -> Console
   02 - Adicione o operador de acesso ao membro -> . 
   03 - Adicione o nome do método -> WriteLine
   04 - Adicione o operador de chamada do método -> ()
   05 - Finalmente, informe os parametros(dentro dos parenteses), se houver -> ("Hello World!")
*/

Random dice = new Random();
int roll = dice.Next(1, 7);
// O método Next() inclui uma assinatura de método que aceita dois parâmetros do tipo int.
Console.WriteLine(roll);

/* METODOS COM ESTADO VS METODO SEM ESTADO
    O termo estado é usado para descrever a condição do ambiente
    de execução em um momento específico no tempo.

    Métodos sem estado são implementados para que possam funcionar
    sem referenciar ou alterar os valores já armazenados na memória.
*/
Console.WriteLine("Console.WriteLine eh um xemplo de metodo estático");

/* métodos com estado são construídos de maneira que os torna dependentes
   de valores armazenados na memória por linhas de código anteriores já executadas
   conhecidos como metodos de instancia
   
   Os métodos com estado (instância) controlam seu estado em campos, 
   que são variáveis definidas na classe. Cada nova instância da classe 
   tem sua própria cópia desses campos nos quais o estado é armazenado.

    quando você precisa chamar métodos com estado, deve primeiro criar 
    uma instância da classe para que o método possa acessar o estado.

    Uma instância de uma classe é chamada de um objeto. 
    Para criar uma instância de uma classe, use o operador new.

    Random dice = new Random();

*/

int num1 = 10;
int num2 = 5;
int largest = Math.Max(num1, num2);
Console.WriteLine(largest);


