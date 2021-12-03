namespace DefontanaApp
{
    class Program
    {
        static int CalculaDigito(int a,int b,char digito){  /*Método que calcula la cantidad de dígitos en el rango entregado*/
           int resultado = 0;                           /*Declaración de resultado inicial*/
           if(a<b){                                        /*En caso de que el numero final sea mayor al numero inicial*/
            while(a<=b){                                 /*Se realiza mientras el valor del rango sea igual al valor máximo*/
                string aux = a.ToString();               /*Convierte el valor inicial a string*/
                int cuenta = aux.Split(digito).Length - 1;   /*Cuenta la cantidad de veces que se encuentra el caracter en el string del número*/
                resultado = resultado+cuenta;            /*añade la cantidad de veces que se encontró al resultado final*/
                a++;
            }
           }
           else if(a>b){                                    /*En caso de que el numero inicial sea mayor al numero final*/
                while(a>=b){                                 /*Se realiza mientras el valor del rango sea igual al valor máximo*/
                string aux = a.ToString();               /*Convierte el valor inicial a string*/
                int cuenta = aux.Split(digito).Length - 1;   /*Cuenta la cantidad de veces que se encuentra el caracter en el string del número*/
                resultado = resultado+cuenta;            /*añade la cantidad de veces que se encontró al resultado final*/
                a--;
                }
            }
            else{                                           /*En caso de que ambos numeros del rango sean iguales*/
                 string aux = a.ToString();               /*Convierte el valor inicial a string*/
                 int cuenta = aux.Split(digito).Length - 1;   /*Cuenta la cantidad de veces que se encuentra el caracter en el string del número*/
                 resultado = resultado+cuenta;            
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            int contador = 0;           /*inicialización de variables y constantes*/
            const char digito = '1';
            bool esNumero1;
            bool esNumero2;
            int numero_ini;
            int numero_fin;
            do{                           /*Lectura de input de consola, solamente continuará si el valor ingresado es int*/
                Console.Write("Ingrese el número inicial del rango: ");
                var string_ingresado_1 = Console.ReadLine();
                esNumero1= int.TryParse(string_ingresado_1, out numero_ini);   /*Conversión de string a int*/
            }
            while (!esNumero1);
            do{                             /*Lectura de input de consola, solamente continuará si el valor ingrsado es int*/
                Console.Write("Ingrese el número final del rango: ");
                var string_ingresado_2 = Console.ReadLine();    
                esNumero2= int.TryParse(string_ingresado_2, out numero_fin);    /*Conversión de string a int*/
            }
            while (!esNumero2);
            contador = CalculaDigito(numero_ini,numero_fin,digito);             /*llamado a método declarado antes de main*/
            Console.WriteLine("La cantidad de veces que se aparece el dígito 1 es: {0}",contador); /*Despliegue de solución*/
        }
    }
}