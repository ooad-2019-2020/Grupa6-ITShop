﻿namespace ITShop.Models
{
    public class Memorija : Proizvod, ITip
    {
        public int Kolicina { get; set; }
        public string Tip;

        public void setTip(string Tip)
        {
            this.Tip = Tip;
        } 

        public string getTip()
        {
            return Tip;
        }
    }
}