Console.WriteLine("Inicialice la calculadora en el valor que desee\n");
double inicio= Convert.ToDouble(Console.ReadLine());
Calculadora calc1= new Calculadora(inicio);
int operacion= 0;
while (operacion != 6)
{
    Console.WriteLine("Seleccione la operacion a realizar(1= suma, 2= resta, 3= multiplicacion, 4= division, 5= limpiar, 6= terminar calculadora)\n");
    operacion= Convert.ToInt32(Console.ReadLine());
    switch (operacion)
    {
    case 1:
        Console.WriteLine("Que valor quiere sumarle al resultado?\n");
        calc1.Sumar(Convert.ToDouble(Console.ReadLine()));
        break;
    case 2:
        Console.WriteLine("Que valor quiere restarle al resultado?\n");
        calc1.Restar(Convert.ToDouble(Console.ReadLine()));
        break;
    case 3:
        Console.WriteLine("Por que valor quiere multiplicar el resultado?\n");
        calc1.Multiplicar(Convert.ToDouble(Console.ReadLine()));
        break;
    case 4:
        Console.WriteLine("Por que valor quiere dividir al resultado?\n");
        calc1.Dividir(Convert.ToDouble(Console.ReadLine()));
        break;
    case 5:
        Console.WriteLine("Se ha reiniciado la calculadora a 0\n");
        calc1.limpiar();
        break;
    case 6:
        Console.WriteLine("El resultado final es: " + calc1.Resultado);
        break;
    }
}

