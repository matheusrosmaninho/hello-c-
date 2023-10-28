namespace Calculator;

struct Calculator
{
    private float valor1;

    private float valor2;

    private EOperador Operador;

    public Calculator(float primeiroValor, int operador, float segundoValor)
    {
        valor1 = primeiroValor;
        Operador = (EOperador)operador;
        valor2 = segundoValor;
    }

    public float Resultado()
    {
        switch(Operador) {
            case EOperador.SOMA:
                return valor1 + valor2;
            case EOperador.SUBTRACAO:
                return valor1 - valor2;
            case EOperador.MULTIPLICACAO:
                return valor1 * valor2;
            case EOperador.DIVISAO:
                return Divisao(valor1, valor2);
            default:
                return 0F;
        }
    }

    private float Divisao(float numero1, float numero2)
    {
        if (numero2 == 0) {
            return 0;
        }
        return numero1 / numero2;
    }
}