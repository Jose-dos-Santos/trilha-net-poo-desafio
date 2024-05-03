namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, int memoria, string modelo) : base(numero, imei, memoria, modelo)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Smartphone Iphone");
        }
    }
}