int[] numeros = new int[10];
int minimo, maximo;


for (int indice = 0; indice < numeros.Length; indice++)
{
    Console.WriteLine($"Qual o numero {indice+1}?");
    int numero = int.Parse(Console.ReadLine());
    numeros[indice] = numero;
   
}
minimo = numeros[0];
maximo = numeros[0];

for(int indice = 0; indice < numeros.Length; indice++)
{
   if (maximo < numeros[indice])
    
        maximo = numeros[indice];

    if (minimo > numeros[indice])

        minimo = numeros[indice];
}
Console.WriteLine($"Mínimo: {minimo}");
Console.WriteLine($"Máximo {maximo}");
