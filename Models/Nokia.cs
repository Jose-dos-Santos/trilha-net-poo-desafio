namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, int memoria, string modelo) : base(numero, imei, memoria, modelo)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Smartphone Nokia");
        }
    }
}