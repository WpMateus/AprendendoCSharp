

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