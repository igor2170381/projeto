namespace Projecto_Desenvolvimento_Aplicaçoes
{
    public partial class Venda
    {
        public override string ToString()
        {
            return string.Concat(this.CasaVendavel.Localidade + "("+CasaVendavel.IdCasa+")" + " a " + DataVenda.ToShortDateString());
        }
    }
}