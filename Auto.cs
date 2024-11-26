using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VlaamiAuto
{
    internal class Auto
    {
        private List<Szemely> tulajdonosok = [];

        public string Rendszam { get; set; }
        public string Gyarto { get; set; }
        public string Modell { get; set; }
        public int Terfogat { get; set; }
        public int Teljesitmeny { get; set; }
        public float Fogyasztas { get; set; }

        public string TulajdonosokLekerdezese() =>
            string.Join("\n", tulajdonosok);

        public void UjTulajokRogzitese(params string[] nevek)
        {
            foreach(var nev in nevek) tulajdonosok.Add(new(nev));
        }

        public override string ToString() =>
            $"[{Rendszam}] {Gyarto} {Modell} ({Teljesitmeny}HP, {Terfogat}cm^3 {Fogyasztas}L/100km)";

        public Auto(string rendszam) : this(rendszam, "Peugeot", "206", 1124, 60, 5.7f)
        {
            tulajdonosok.Add(new("a cégem"));
        }

        public Auto(string rendszam, string gyarto, string modell, int terfogat, int teljesitmeny, float fogyasztas, params string[] nevek)
        {
            tulajdonosok = [];

            Rendszam = rendszam;
            Gyarto = gyarto;
            Modell = modell;
            Terfogat = terfogat;
            Teljesitmeny = teljesitmeny;
            Fogyasztas = fogyasztas;

            foreach (var nev in nevek) tulajdonosok.Add(new(nev));
        }
    }
}
