namespace TesteUnitario
{
    public class Class1
    {
        public static int Soma(int primeiroNumero, int segundoNumero)
        {
            if (primeiroNumero < 0 || segundoNumero < 0)
                return -1;

            return primeiroNumero + segundoNumero;
        }
    }
}
