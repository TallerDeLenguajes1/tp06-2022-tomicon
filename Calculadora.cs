public class Calculadora{
    private double resultado;

    public double Resultado { get => resultado; set => resultado = value; }

    public void Sumar(double termino){
        Resultado += termino;
    }

    public void Restar(double termino){
        resultado -= termino; 
    }

    public void Multiplicar(double termino){
        resultado *= termino;
    }

    public void Dividir(double termino){
        resultado = resultado / termino;
    }

    public void limpiar(){
        resultado = 0;
    }

    public Calculadora(double termino){
        resultado= termino;
    }

}

