namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class Arrendamento
    {
        public string Gere()
        {
            if (Renovavel == false)
            {
                string falso = "Não";
                return falso;
            }
            else
            {
                string verdade = "Sim";
                return verdade;
            }
        }

        public override string ToString()
        {
            return string.Concat("Inicio: " + InicioContrato.ToShortDateString() + " " + DuracaoMeses + " meses" + " Renovável:" + Gere() + " a " + Arrendatario.Nome + "(" + Arrendatario.NIF + ")");
        }
    }
}