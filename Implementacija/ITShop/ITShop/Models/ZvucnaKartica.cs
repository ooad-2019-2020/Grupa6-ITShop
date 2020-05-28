namespace ITShop.Models
{
    public class ZvucnaKartica : Proizvod, ITip
    {
        public string Tip;

        public void setTip(string tip)
        {
            Tip = tip;
        }

        public string getTip()
        {
            return Tip;
        }
    }
}