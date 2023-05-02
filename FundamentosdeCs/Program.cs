using System;

//Tipos de datos primitivos en c#
int i = 2;
long l = 355665655765;
double d = 12.34;
decimal de = 12.87456456m; // este es para decimales mas precisos
char c = 'c';
string s = "hi";
bool ok = true;

// invocaciones 
int sum = Calculations(10,20);
Console.WriteLine(sum);



bool greater = IsItGreaterThan(20);
Console.WriteLine(greater);


Console.WriteLine("Hello World! - > "+ l);

//Console.ReadKey(); se usa para detectar una tecla


// el if incluso se vé mas sencillo xd
if (i<10) 
{
    Console.WriteLine("i es menor a 10");
}

// el switch es como en java aun ASI sigue siendo usar ifs anidados
switch(i)
{

    case 0:
        Console.WriteLine("i vale 0");
        break;
    case 1:
        Console.WriteLine("i vale 1");
        break;
    case 2:
        Console.WriteLine("i vale 2");
        break;

    default: Console.WriteLine("i vale xd");
        break;

}

//Colecciones
//el array es mas o menos lo mismo que java 
int[] array = new int[10]; //aca se inicia vacio
int[] array2 = new int[] { 1, 2, 3 }; // aca lo inicio con valores 

//leroooooy jenkinnnssss, aparecieron las listas

List<int> list = new List<int>(); // las puedo declarar vacias y gracias a dios son dinamicas
List<int> list2 = new List<int>() { 1,2,3}; // sino tambien puedo pasarle elementos como parámetro

list2.Add(10); //tuki agrego un elemento a la lista
list2.Remove(4); //asi elimino

//recorrido , se me hace rari ver el "in" pero bueno aca no existen stream creo :( . pd : tengo que averiguar
foreach (int item in list2) 
{
    Console.WriteLine(item);
}

//ahora si , me siento como en casa . aunque los colores AHHHH entraño intelliJ :( 
for (int iteration =  0; iteration<list2.Count; iteration++)
{
    Console.WriteLine("index: "+iteration+", item: " + list2[iteration]);
}


//el while y el do while es lo mismo basicamente nomas que al reves .

while (i<10) 
{
    Console.WriteLine("entre al while ");
    i++;
}



//funciones igual que java , solo que empieza con mayuscula
int  Calculations(int a , int b) {

    return a+b;
}

bool IsItGreaterThan(int a) {

    return a > 0;
}