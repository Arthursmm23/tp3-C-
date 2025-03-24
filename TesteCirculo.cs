namespace Circulo
{
    internal class Program
    {//EX12
        static void Main(string[] args)
        {
            Console.WriteLine("=== TESTE DE FIGURAS GEOMÉTRICAS ===");

            double raioCirculo = 3.0;
            double raioEsfera = 5.0;

            Circuloo circ = new Circuloo();
            circ.Raio = raioCirculo;

            double areaCalculada = circ.CalcularArea();
            double areaEsperadaCirculo = Math.PI * (raioCirculo * raioCirculo);

            Console.WriteLine("\n[TESTE CÍRCULO]");
            Console.WriteLine($"Raio definido: {raioCirculo}");
            Console.WriteLine($"Área calculada: {areaCalculada:F4}");
            Console.WriteLine($"Área esperada: {areaEsperadaCirculo:F4}");
            Console.WriteLine($"Resultado válido? {Math.Abs(areaCalculada - areaEsperadaCirculo) < 0.0001}");

          
            Esfera esf = new Esfera();
            esf.Raio = raioEsfera;

            double volumeCalculado = esf.CalcularVolume();
            double volumeEsperado = (4.0 / 3.0) * Math.PI * (raioEsfera * raioEsfera * raioEsfera);

            Console.WriteLine("\n[TESTE ESFERA]");
            Console.WriteLine($"Raio definido: {raioEsfera}");
            Console.WriteLine($"Volume calculado: {volumeCalculado:F4}");
            Console.WriteLine($"Volume esperado: {volumeEsperado:F4}");
            Console.WriteLine($"Resultado válido? {Math.Abs(volumeCalculado - volumeEsperado) < 0.0001}");
        }
    }
}
