namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class Casa
    {
        public override string ToString()
        {
            if (this.GetType().BaseType == typeof(Casa))
            {
                return "Base: " + IdCasa + " - " + Localidade;
            }
            else if (this.GetType().BaseType == typeof(CasaArrendavel))
            {
                return "Casa Arrendavel: " + IdCasa + " - " + Localidade;
            }
            else
            {
                return "Casa Vendavel: " + IdCasa + " - " + Localidade;
            }

        }
    }
}