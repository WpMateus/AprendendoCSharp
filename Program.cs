using System;

namespace MeuApp{
  class Program{
    static void Main(string[] args){
      
var texto = "Testando";
Console.WriteLine(texto);

//números reais
float salario = 2.500f;
double salarioSemestral = 22.000;
decimal salarioAnual = 25.000m;

// boolean
bool usuarioCadastrado = false;
bool pagamentoRecebido = true;
var usuarioExpirado = false;

// char - sempre uma aspas
char primeiraLetra = 'C';
var segundaLetra = 'D';

//string - sempre aspas duplas
string primeiraLetraTesta = "C";
string meuTexto = "Meu texto";
var documento = "12345.99";

//var - sempre vai assumir o tipo ao primeiro item que está assimilado 
var idade = 25; // do tipo inteiro
// idade = "André"; - erro porque não deixa transformar inteiro em string

//object - pode ser qualquer valor ou objeto
object quantidade;
quantidade = 2.5;
quantidade = 1;
quantidade = "Teste";

//nullabel types
// void - vaziu, sem retorno, não é nada
// null - é a mesma coisa que void
int? idadeNu = 0;
Console.WriteLine(idadeNu);
idadeNu = null;
Console.WriteLine(idadeNu);
idadeNu = 25;
Console.WriteLine(idadeNu);

// Valores Padrões
//int, float e decimal - sempre vai ser 0 e para booleano false. char /0 e string ""

// convertendo tipos
int inteiro = 100;
float real = 25.5f;

//real =  inteiro;
//inteiro = (int)real;
// inteiro = int.Parse(real);  // Funciona apenas com string
//string valorReal = real.ToString();
// inteiro = int.Parse(valorReal);

inteiro = Convert.ToInt32(real);
// Console.WriteLine(valorReal);
Console.WriteLine(inteiro);
Console.WriteLine(Convert.ToBoolean(0));

double x = 2;
Console.WriteLine(x != 25);

//if 
int idadeTeste = 18;
int maioridade = 21;
int idadeMaxima = 65;

if(!(idadeTeste >= maioridade)){
  Console.WriteLine("É diferente");
} else{
  Console.WriteLine("É igual");
}
Console.WriteLine("Finalizou o programa");

//switch
string valor = "Paulo";
switch(valor){
  case "Joao": Console.WriteLine("Não é o cara!"); break;
  case "Marcelo": Console.WriteLine("Não é o cara!"); break;
  case "Mateus": Console.WriteLine("É o cara!"); break;
  default: Console.WriteLine("Não encontrei"); break;
}

//for
for (int i = 5; i >= 0; i--){
  Console.WriteLine(i);
}

//while
int valorZero = 0;
// while (valorZero <= 5){
//   valorZero++;
//   Console.WriteLine(valorZero);
// }

//do/while
do{
  Console.WriteLine(valorZero);
  valorZero++;
}while(valorZero <= 5);
 

  MeuMetodo();
  string nome = RetornaNome("Mateus", "Wenzler");
  Console.WriteLine(nome);


// Tipos de valor, você cria uma cópia do item na memória.
  int x1 = 25;
  int y1 = x1;

  Console.WriteLine(x1);
  Console.WriteLine(y1);

  x1 = 32;
  Console.WriteLine(x1);
  Console.WriteLine(y1);


//tipo de valor com array, aqui só tem a referencia da onde está a informação na memória, assim alterando quando solicitado. Tudo que faz em um, replica no outro

  var arr = new string[2];
  arr[0] = "Item 1";

  var arr2 = arr;

  Console.WriteLine(arr[0]);
  Console.WriteLine(arr2[0]);

  arr[0] = "Item 2";
  Console.WriteLine(arr[0]);
  Console.WriteLine(arr2[0]);

//instaciar o método contrutor, se criar sem nenhum parametro ele não vai passar pelo método abaixo e não vai atribuir valores
//Se não informar parametros vem 0, vaziu e 0
// Se colocar valor, vai sair os valores abaixo informado
  Product mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);

var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);

//se quiser iniciar vaziu e depois passar as propriedades pode
//Ex: mouse.Id = 55;

  Console.WriteLine(mouse.Id);
  Console.WriteLine(mouse.Name);
  Console.WriteLine(mouse.Price);
  Console.WriteLine((int)mouse.Type);

      }

//Método só da pra ser feito fora da Main, porém para que ele funcione tem que chamar ele dentro da Main
     static void MeuMetodo(){
   Console.WriteLine("C# é legal");
 }


static string RetornaNome(
  string nome, 
  string sobrenome,
  int idade = 20,
// parametro opcional tem que ir por último
  bool teste = false,
  double novo = 35.9
  )
{  

return nome +" "+ sobrenome + " tem " + idade.ToString();

}

  }

// struct tem que estar fora da class, pois competem com ela
  struct Product

  {

//pode ter um método com o mesmo nome do struct, método contrutor
    public Product(int id, string name, double price, EProductType type){
      Id = id;
      Name = name;
      Price = price;
      Type = type;
    }
    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public double PriceInDolar(double dolar){
      return Price * dolar;
    }
  }

enum EProductType 
{
  Product = 1,
  Service = 2
}

}

