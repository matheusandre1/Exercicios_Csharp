// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);
fila.Enqueue(5);
fila.Enqueue(6);
fila.Enqueue(7);
fila.Enqueue(8);
fila.Enqueue(9);
fila.Enqueue(10);
fila.Enqueue(11);
fila.Enqueue(12);
fila.Enqueue(13);

foreach (var item in fila)
{
    Console.WriteLine(item);
}



