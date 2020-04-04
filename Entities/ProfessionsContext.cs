using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WarhammerProfessionApp.Entities.Models;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.Entities.Models.ManyToMany;
using WarhammerProfessionApp.Entities.Models.Utility;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Entities
{
    public class ProfessionsContext : DbContext
    {
        public ProfessionsContext(DbContextOptions<ProfessionsContext> options) : base(options)
        {
        }

        public DbSet<Ability> Abilities { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Profession> Professions { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Statistic> Statistics { get; set; }

        public DbSet<User> Users { get; set; }

        public static void SeedData(ModelBuilder modelBuilder)
        {
            #region items

            var halabarda = new Item
            {
                Name = "Halabarda",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 175,
                ItemType = ItemType.WhiteWeapon
            };
            var kij = new Item
            {
                Name = "Kij",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.High,
                Weigth = 50,
                ItemType = ItemType.WhiteWeapon
            };
            var kopia = new Item
            {
                Name = "Kopia",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 100,
                ItemType = ItemType.WhiteWeapon
            };
            var korbacz = new Item
            {
                Name = "Korbacz",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 95,
                ItemType = ItemType.WhiteWeapon
            };
            var lanca = new Item
            {
                Name = "Lanca",
                Price = MoneyCalculator.GetUserMoney(20, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 75,
                ItemType = ItemType.WhiteWeapon
            };
            var lewak = new Item
            {
                Name = "Lewak",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 10,
                ItemType = ItemType.WhiteWeapon
            };
            var lamaczMieczy = new Item
            {
                Name = "Łamacz mieczy",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 40,
                ItemType = ItemType.WhiteWeapon
            };
            var morgensztern = new Item
            {
                Name = "Morgensztern",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 60,
                ItemType = ItemType.WhiteWeapon
            };
            var puklerz = new Item
            {
                Name = "Puklerz",
                Price = MoneyCalculator.GetUserMoney(4, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 15,
                ItemType = ItemType.WhiteWeapon
            };
            var rapier = new Item
            {
                Name = "Rapier",
                Price = MoneyCalculator.GetUserMoney(18, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 40,
                ItemType = ItemType.WhiteWeapon
            };
            var kastet = new Item
            {
                Name = "Rękawica/kastet",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 1,
                ItemType = ItemType.WhiteWeapon
            };
            var szpada = new Item
            {
                Name = "Szpada",
                Price = MoneyCalculator.GetUserMoney(18, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 40,
                ItemType = ItemType.WhiteWeapon
            };
            var sztylet = new Item
            {
                Name = "Sztylet",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 10,
                ItemType = ItemType.WhiteWeapon
            };
            var tarcza = new Item
            {
                Name = "Tarcza",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 50,
                ItemType = ItemType.WhiteWeapon
            };
            var wlocznia = new Item
            {
                Name = "Włócznia",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 50,
                ItemType = ItemType.WhiteWeapon
            };
            var bronDwureczna = new Item
            {
                Name = "Bron dwureczna",
                Price = MoneyCalculator.GetUserMoney(0, 0, 0),
                Rarity = ItemRarity.Common,
                Weigth = 0,
                ItemType = ItemType.WhiteWeapon
            };
            var arkan = new Item
            {
                Name = "Arkan",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 10,
                ItemType = ItemType.RangedWeapon
            };
            var bicz = new Item
            {
                Name = "Bicz",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 40,
                ItemType = ItemType.RangedWeapon
            };
            var bolas = new Item
            {
                Name = "Bolas",
                Price = MoneyCalculator.GetUserMoney(0, 7, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 20,
                ItemType = ItemType.RangedWeapon
            };
            var dlugiLuk = new Item
            {
                Name = "Długi łuk",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 90,
                ItemType = ItemType.RangedWeapon
            };
            var elfiLuk = new Item
            {
                Name = "Elfi łuk",
                Price = MoneyCalculator.GetUserMoney(70, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 75,
                ItemType = ItemType.RangedWeapon
            };
            var garlacz = new Item
            {
                Name = "Garłacz",
                Price = MoneyCalculator.GetUserMoney(70, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 50,
                ItemType = ItemType.RangedWeapon
            };
            var krotkiLuk = new Item
            {
                Name = "Krótki łuk",
                Price = MoneyCalculator.GetUserMoney(70, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 75,
                ItemType = ItemType.RangedWeapon
            };
            var kuszaPistoletowa = new Item
            {
                Name = "Kusza pistoletowa",
                Price = MoneyCalculator.GetUserMoney(35, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 25,
                ItemType = ItemType.RangedWeapon
            };
            var kuszaSamopowtarzalna = new Item
            {
                Name = "Kusza samopowtarzalna",
                Price = MoneyCalculator.GetUserMoney(100, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 150,
                ItemType = ItemType.RangedWeapon
            };
            var kusza = new Item
            {
                Name = "Kusza",
                Price = MoneyCalculator.GetUserMoney(25, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 120,
                ItemType = ItemType.RangedWeapon
            };
            var luk = new Item
            {
                Name = "Łuk",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 80,
                ItemType = ItemType.RangedWeapon
            };
            var muszkietHochlandzki = new Item
            {
                Name = "Muszkiet hochlandzki",
                Price = MoneyCalculator.GetUserMoney(450, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 70,
                ItemType = ItemType.RangedWeapon
            };
            var nozDoRzucania = new Item
            {
                Name = "Nóź/gwiazdka do rzucania",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 10,
                ItemType = ItemType.RangedWeapon
            };
            var oszczep = new Item
            {
                Name = "Oszczep",
                Price = MoneyCalculator.GetUserMoney(0, 25, 0),
                Rarity = ItemRarity.Low,
                Weigth = 50,
                ItemType = ItemType.RangedWeapon
            };
            var pistolet = new Item
            {
                Name = "Pistolet",
                Price = MoneyCalculator.GetUserMoney(200, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 25,
                ItemType = ItemType.RangedWeapon
            };
            var pistoletWielostrzalowy = new Item
            {
                Name = "Pistolet wielostrzałowy",
                Price = MoneyCalculator.GetUserMoney(400, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 25,
                ItemType = ItemType.RangedWeapon
            };
            var proca = new Item
            {
                Name = "Proca",
                Price = MoneyCalculator.GetUserMoney(4, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 10,
                ItemType = ItemType.RangedWeapon
            };
            var procaDrzewcowa = new Item
            {
                Name = "Proca drzewcowa",
                Price = MoneyCalculator.GetUserMoney(6, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 50,
                ItemType = ItemType.RangedWeapon
            };
            var rusznica = new Item
            {
                Name = "Rusznica",
                Price = MoneyCalculator.GetUserMoney(300, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 30,
                ItemType = ItemType.RangedWeapon
            };
            var rusznicaWielostrzalowa = new Item
            {
                Name = "Rusznica wielostrzałowa",
                Price = MoneyCalculator.GetUserMoney(600, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 30,
                ItemType = ItemType.RangedWeapon
            };
            var siec = new Item
            {
                Name = "Sieć",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 60,
                ItemType = ItemType.RangedWeapon
            };
            var toporDoRzucania = new Item
            {
                Name = "Topór/młot do rzucania",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 40,
                ItemType = ItemType.RangedWeapon
            };
            var wloczniaDoRzucania = new Item
            {
                Name = "Włócznia",
                Price = MoneyCalculator.GetUserMoney(0, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 30,
                ItemType = ItemType.RangedWeapon
            };
            var strzala = new Item
            {
                Name = "Strzała",
                Price = MoneyCalculator.GetUserMoney(0, 0, 2),
                Rarity = ItemRarity.Average,
                Weigth = 10,
                ItemType = ItemType.Ammunition
            };
            var belt = new Item
            {
                Name = "Bełt",
                Price = MoneyCalculator.GetUserMoney(0, 0, 4),
                Rarity = ItemRarity.Low,
                Weigth = 10,
                ItemType = ItemType.Ammunition
            };
            var kulaDoBroni = new Item
            {
                Name = "Kula do broni palnej",
                Price = MoneyCalculator.GetUserMoney(0, 0, 1),
                Rarity = ItemRarity.Rare,
                Weigth = 10,
                ItemType = ItemType.Ammunition
            };
            var prochStrzelniczy = new Item
            {
                Name = "Proch strzelniczy (strzał)",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 1,
                ItemType = ItemType.Ammunition
            };
            var helmSkora = new Item
            {
                Name = "Hełm (Skórzany)",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 10,
                ItemType = ItemType.Armor
            };
            var kaftanSkora = new Item
            {
                Name = "Kaftan (Skórzany)",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 40,
                ItemType = ItemType.Armor
            };
            var kurtaSkora = new Item
            {
                Name = "Kurta (Skórzana)",
                Price = MoneyCalculator.GetUserMoney(12, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 50,
                ItemType = ItemType.Armor
            };
            var nogawiceSkora = new Item
            {
                Name = "Nogawice (Skórzane)",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 20,
                ItemType = ItemType.Armor
            };
            var skorznia = new Item
            {
                Name = "Skórznia",
                Price = MoneyCalculator.GetUserMoney(25, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 80,
                ItemType = ItemType.Armor
            };
            var czepiecKolczy = new Item
            {
                Name = "Czepiec (Kolczy)",
                Price = MoneyCalculator.GetUserMoney(20, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 30,
                ItemType = ItemType.Armor
            };
            var kaftanKolczy = new Item
            {
                Name = "Kaftan (Kolczy)",
                Price = MoneyCalculator.GetUserMoney(60, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 60,
                ItemType = ItemType.Armor
            };
            var koszulkaKolcza = new Item
            {
                Name = "Koszulka (Kolcza)",
                Price = MoneyCalculator.GetUserMoney(95, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 80,
                ItemType = ItemType.Armor
            };
            var kolczugaKolcza = new Item
            {
                Name = "Kolczuga",
                Price = MoneyCalculator.GetUserMoney(75, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 80,
                ItemType = ItemType.Armor
            };
            var kolczugaZRekawami = new Item
            {
                Name = "Kolczuga z rękawami",
                Price = MoneyCalculator.GetUserMoney(130, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 100,
                ItemType = ItemType.Armor
            };
            var nogawiceKolcze = new Item
            {
                Name = "Nogawice (Kolcze)",
                Price = MoneyCalculator.GetUserMoney(20, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 40,
                ItemType = ItemType.Armor
            };
            var zbrojaKolcza = new Item
            {
                Name = "Zbroja kolcza",
                Price = MoneyCalculator.GetUserMoney(170, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 210,
                ItemType = ItemType.Armor
            };
            var helmPlytowy = new Item
            {
                Name = "Hełm (płytowy)",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 40,
                ItemType = ItemType.Armor
            };
            var naramiennikiPlytowe = new Item
            {
                Name = "Naramienniki (płytowe)",
                Price = MoneyCalculator.GetUserMoney(70, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 75,
                ItemType = ItemType.Armor
            };
            var nogawicePlytowe = new Item
            {
                Name = "Nogawice (płytowe)",
                Price = MoneyCalculator.GetUserMoney(60, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 30,
                ItemType = ItemType.Armor
            };
            var napiersnikPlytowy = new Item
            {
                Name = "Napierśnik (płytowy)",
                Price = MoneyCalculator.GetUserMoney(70, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 40,
                ItemType = ItemType.Armor
            };
            var zbrojaPlytowa = new Item
            {
                Name = "Zbroja płytowa",
                Price = MoneyCalculator.GetUserMoney(400, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 395,
                ItemType = ItemType.Armor
            };
            var lachmany = new Item
            {
                Name = "Łachmany",
                Price = MoneyCalculator.GetUserMoney(0, 0, 1),
                Rarity = ItemRarity.Common,
                Weigth = 5,
                ItemType = ItemType.Cloth
            };
            var kiepskieOdzienie = new Item
            {
                Name = "Kiepskie odzienie",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.Common,
                Weigth = 10,
                ItemType = ItemType.Cloth
            };
            var zwykleUbranie = new Item
            {
                Name = "Zwykłe ubranie",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 15,
                ItemType = ItemType.Cloth
            };
            var dobreUbranie = new Item
            {
                Name = "Dobre ubranie",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 15,
                ItemType = ItemType.Cloth
            };
            var szykowneUbranie = new Item
            {
                Name = "Szykowne ubranie",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 20,
                ItemType = ItemType.Cloth
            };
            var szaty = new Item
            {
                Name = "Szaty",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 25,
                ItemType = ItemType.Cloth
            };
            var kostium = new Item
            {
                Name = "Kostium",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 10,
                ItemType = ItemType.Cloth
            };
            var uniform = new Item
            {
                Name = "Uniform",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 15,
                ItemType = ItemType.Cloth
            };
            var strojSzlachecki = new Item
            {
                Name = "Strój szlachecki",
                Price = MoneyCalculator.GetUserMoney(50, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 30,
                ItemType = ItemType.Cloth
            };
            var strojArystokraty = new Item
            {
                Name = "Strój arystokraty",
                Price = MoneyCalculator.GetUserMoney(100, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 50,
                ItemType = ItemType.Cloth
            };
            var peleryna = new Item
            {
                Name = "Peleryna",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 10,
                ItemType = ItemType.Cloth
            };
            var plaszcz = new Item
            {
                Name = "Płaszcz",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 15,
                ItemType = ItemType.Cloth
            };
            var kapeluszZwykly = new Item
            {
                Name = "Kapelusz zwykły",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.High,
                Weigth = 15,
                ItemType = ItemType.Cloth
            };
            var kapeluszZRondem = new Item
            {
                Name = "Kapelusz z szerokim rondlem",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 5,
                ItemType = ItemType.Cloth
            };
            var kapturMaska = new Item
            {
                Name = "Kaptur lub maska",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.Average,
                Weigth = 2,
                ItemType = ItemType.Cloth
            };
            var obrok = new Item
            {
                Name = "Obrok (porcja na 1 dzień)",
                Price = MoneyCalculator.GetUserMoney(0, 0, 5),
                Rarity = ItemRarity.High,
                Weigth = 50,
                ItemType = ItemType.Food
            };
            var bochenekChleba = new Item
            {
                Name = "Bochenek chleba",
                Price = MoneyCalculator.GetUserMoney(0, 0, 2),
                Rarity = ItemRarity.Common,
                Weigth = 2,
                ItemType = ItemType.Food
            };
            var polecMiesa = new Item
            {
                Name = "Połeć mięsa",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Low,
                Weigth = 10,
                ItemType = ItemType.Food
            };
            var kiepskieJedzenie = new Item
            {
                Name = "Kiepskie jedzenie (porcja na 1 dzień)",
                Price = MoneyCalculator.GetUserMoney(0, 0, 5),
                Rarity = ItemRarity.High,
                Weigth = 10,
                ItemType = ItemType.Food
            };
            var dobreJedzenie = new Item
            {
                Name = "Dobre jedzenie (porcja na 1 dzień)",
                Price = MoneyCalculator.GetUserMoney(0, 0, 10),
                Rarity = ItemRarity.Average,
                Weigth = 10,
                ItemType = ItemType.Food
            };
            var doskonaleJedzenie = new Item
            {
                Name = "Doskonałe jedzenie (porcja na 1 dzień)",
                Price = MoneyCalculator.GetUserMoney(0, 0, 18),
                Rarity = ItemRarity.Low,
                Weigth = 10,
                ItemType = ItemType.Food
            };
            var prowiantNaTydzien = new Item
            {
                Name = "Prowiant (porcja na 1 tydzień)",
                Price = MoneyCalculator.GetUserMoney(0, 6, 0),
                Rarity = ItemRarity.Average,
                Weigth = 50,
                ItemType = ItemType.Food
            };
            var slodycze = new Item
            {
                Name = "Słodycze",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Average,
                Weigth = 2,
                ItemType = ItemType.Food
            };
            var smakolyki = new Item
            {
                Name = "Smakołyki",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 0,
                ItemType = ItemType.Food
            };
            var ciemnePiwo = new Item
            {
                Name = "Ciemne piwo",
                Price = MoneyCalculator.GetUserMoney(0, 0, 2),
                Rarity = ItemRarity.High,
                Weigth = 2,
                ItemType = ItemType.Food
            };
            var jasnePiwo = new Item
            {
                Name = "Jasne piwo",
                Price = MoneyCalculator.GetUserMoney(0, 0, 1),
                Rarity = ItemRarity.Common,
                Weigth = 2,
                ItemType = ItemType.Food
            };
            var antalekPiwaJasnego = new Item
            {
                Name = "Antałek piwa jasnego",
                Price = MoneyCalculator.GetUserMoney(0, 0, 18),
                Rarity = ItemRarity.Common,
                Weigth = 30,
                ItemType = ItemType.Food
            };
            var antalekPiwaCiemnego = new Item
            {
                Name = "Antałek piwa ciemnego",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Common,
                Weigth = 30,
                ItemType = ItemType.Food
            };
            var butelkaGorzalki = new Item
            {
                Name = "Butelka gorzałki",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Low,
                Weigth = 5,
                ItemType = ItemType.Food
            };
            var butelkaGorzalkiDobrejJakosci = new Item
            {
                Name = "Butelka gorzałki dobrej jakości",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Low,
                Weigth = 5,
                ItemType = ItemType.Food
            };
            var winoPospolite = new Item
            {
                Name = "Wino pospolite",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Average,
                Weigth = 5,
                ItemType = ItemType.Food
            };
            var winoSzlacheckie = new Item
            {
                Name = "Wino szlacheckie",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.Low,
                Weigth = 5,
                ItemType = ItemType.Food
            };
            var buklak = new Item
            {
                Name = "Bukłak",
                Price = MoneyCalculator.GetUserMoney(0, 8, 0),
                Rarity = ItemRarity.High,
                Weigth = 1,
                ItemType = ItemType.Containers
            };
            var flaszka = new Item
            {
                Name = "Flaszka",
                Price = MoneyCalculator.GetUserMoney(0, 4, 0),
                Rarity = ItemRarity.High,
                Weigth = 10,
                ItemType = ItemType.Containers
            };
            var juki = new Item
            {
                Name = "Juki",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 5,
                ItemType = ItemType.Containers
            };
            var kuferek = new Item
            {
                Name = "Kuferek",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 40,
                ItemType = ItemType.Containers
            };
            var manierkaMetalowa = new Item
            {
                Name = "Manierka metalowa",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 15,
                ItemType = ItemType.Containers
            };
            var manierkaSkorzana = new Item
            {
                Name = "Manierska skórzana",
                Price = MoneyCalculator.GetUserMoney(0, 15, 0),
                Rarity = ItemRarity.Low,
                Weigth = 5,
                ItemType = ItemType.Containers
            };
            var mieszek = new Item
            {
                Name = "Mieszek",
                Price = MoneyCalculator.GetUserMoney(0, 2, 0),
                Rarity = ItemRarity.High,
                Weigth = 1,
                ItemType = ItemType.Containers
            };
            var plecak = new Item
            {
                Name = "Plecak",
                Price = MoneyCalculator.GetUserMoney(0, 30, 0),
                Rarity = ItemRarity.High,
                Weigth = 20,
                ItemType = ItemType.Containers
            };
            var sakiewka = new Item
            {
                Name = "Sakiewka",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.High,
                Weigth = 1,
                ItemType = ItemType.Containers
            };
            var tobolek = new Item
            {
                Name = "Tobołek",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 5,
                ItemType = ItemType.Containers
            };
            var tubaNaMapy = new Item
            {
                Name = "Tuba na mapy/pergaminy",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 2,
                ItemType = ItemType.Containers
            };
            var worek = new Item
            {
                Name = "Worek",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.High,
                Weigth = 7,
                ItemType = ItemType.Containers
            };
            var drewnoNaOpal = new Item
            {
                Name = "Drewno na opał",
                Price = MoneyCalculator.GetUserMoney(0, 2, 0),
                Rarity = ItemRarity.High,
                Weigth = 5,
                ItemType = ItemType.Light
            };
            var kaganek = new Item
            {
                Name = "Kaganek",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.High,
                Weigth = 20,
                ItemType = ItemType.Light
            };
            var latarnia = new Item
            {
                Name = "Latarnia",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 20,
                ItemType = ItemType.Light
            };
            var latarniaSztormowa = new Item
            {
                Name = "Latarnia sztormowa",
                Price = MoneyCalculator.GetUserMoney(12, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 30,
                ItemType = ItemType.Light
            };
            var olejDoLatarni = new Item
            {
                Name = "Olej do latarni",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.High,
                Weigth = 5,
                ItemType = ItemType.Light
            };
            var pochodnia = new Item
            {
                Name = "Pochodnia",
                Price = MoneyCalculator.GetUserMoney(0, 0, 5),
                Rarity = ItemRarity.High,
                Weigth = 5,
                ItemType = ItemType.Light
            };
            var swieczkaLojowa = new Item
            {
                Name = "Świeczka łojowa",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.High,
                Weigth = 5,
                ItemType = ItemType.Light
            };
            var swieczkaWoskowa = new Item
            {
                Name = "Świeczka woskowa",
                Price = MoneyCalculator.GetUserMoney(0, 6, 0),
                Rarity = ItemRarity.Low,
                Weigth = 5,
                ItemType = ItemType.Light
            };
            var zapalka = new Item
            {
                Name = "Zapałka",
                Price = MoneyCalculator.GetUserMoney(0, 0, 1),
                Rarity = ItemRarity.Low,
                Weigth = 0,
                ItemType = ItemType.Light
            };
            var zlotaKorona = new Item
            {
                Name = "Zlota korona",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 0,
                ItemType = ItemType.Utility
            };
            var pens = new Item
            {
                Name = "Pens",
                Price = MoneyCalculator.GetUserMoney(0, 0, 1),
                Rarity = ItemRarity.Common,
                Weigth = 0,
                ItemType = ItemType.Utility
            };
            var szyling = new Item
            {
                Name = "Szyling",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Utility
            };
            var drabina = new Item
            {
                Name = "Drabina",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.Average,
                Weigth = 50,
                ItemType = ItemType.Utility
            };
            var hubkaIKrzesiwo = new Item
            {
                Name = "Hubka i krzesiwo",
                Price = MoneyCalculator.GetUserMoney(0, 30, 0),
                Rarity = ItemRarity.High,
                Weigth = 5,
                ItemType = ItemType.Utility
            };
            var imbryk = new Item
            {
                Name = "Imbryk",
                Price = MoneyCalculator.GetUserMoney(0, 30, 0),
                Rarity = ItemRarity.High,
                Weigth = 10,
                ItemType = ItemType.Utility
            };
            var instrumentMuzyczny = new Item
            {
                Name = "Instrument muzyczny",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 5,
                ItemType = ItemType.Utility
            };
            var klodkaDobrejJakosci = new Item
            {
                Name = "Kłódka dobrej jakości",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 5,
                ItemType = ItemType.Utility
            };
            var klodkaZwyklejJakosci = new Item
            {
                Name = "Kłódka zwykłej jakości",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 5,
                ItemType = ItemType.Utility
            };
            var koc = new Item
            {
                Name = "Koc",
                Price = MoneyCalculator.GetUserMoney(0, 25, 0),
                Rarity = ItemRarity.High,
                Weigth = 10,
                ItemType = ItemType.Utility
            };
            var kociolek = new Item
            {
                Name = "Kociołek",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 20,
                ItemType = ItemType.Utility
            };
            var kosciDoGry = new Item
            {
                Name = "Kości do gry",
                Price = MoneyCalculator.GetUserMoney(0, 6, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Utility
            };
            var kufelDrewniany = new Item
            {
                Name = "Kufel drewniany",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.High,
                Weigth = 5,
                ItemType = ItemType.Utility
            };
            var kufelZeSzklaBarwionego = new Item
            {
                Name = "Kufel ze szkła barwionego",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 5,
                ItemType = ItemType.Utility
            };
            var lina = new Item
            {
                Name = "Lina",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 50,
                ItemType = ItemType.Utility
            };
            var luneta = new Item
            {
                Name = "Luneta",
                Price = MoneyCalculator.GetUserMoney(100, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 5,
                ItemType = ItemType.Utility
            };
            var lustro = new Item
            {
                Name = "Lustro",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 5,
                ItemType = ItemType.Utility
            };
            var namiot = new Item
            {
                Name = "Namiot",
                Price = MoneyCalculator.GetUserMoney(0, 15, 0),
                Rarity = ItemRarity.Average,
                Weigth = 20,
                ItemType = ItemType.Utility
            };
            var papier = new Item
            {
                Name = "Papier",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Utility
            };
            var perfumy = new Item
            {
                Name = "Perfumy",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 0,
                ItemType = ItemType.Utility
            };
            var pergamin = new Item
            {
                Name = "Pergamin",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 0,
                ItemType = ItemType.Utility
            };
            var symbolReligijny = new Item
            {
                Name = "Symbol religijny",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 5,
                ItemType = ItemType.Utility
            };
            var sztucceDrewniane = new Item
            {
                Name = "Sztućce drewniane",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.High,
                Weigth = 2,
                ItemType = ItemType.Utility
            };
            var sztucceMetalowe = new Item
            {
                Name = "Sztućce metalowe",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 4,
                ItemType = ItemType.Utility
            };
            var sztucceSrebrne = new Item
            {
                Name = "Sztućce srebrne",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 3,
                ItemType = ItemType.Utility
            };
            var taliaKart = new Item
            {
                Name = "Talia kart",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 1,
                ItemType = ItemType.Utility
            };
            var drag = new Item
            {
                Name = "Drąg, cena za metr",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.High,
                Weigth = 10,
                ItemType = ItemType.Tools
            };
            var drewnianyKlin = new Item
            {
                Name = "Drewniany klin",
                Price = MoneyCalculator.GetUserMoney(0, 0, 8),
                Rarity = ItemRarity.High,
                Weigth = 2,
                ItemType = ItemType.Tools
            };
            var haczykNaRyby = new Item
            {
                Name = "Haczyk na ryby i żyłka",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Average,
                Weigth = 2,
                ItemType = ItemType.Tools
            };
            var kajdany = new Item
            {
                Name = "Kajdany",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 20,
                ItemType = ItemType.Tools
            };
            var kilof = new Item
            {
                Name = "Kilof",
                Price = MoneyCalculator.GetUserMoney(0, 25, 0),
                Rarity = ItemRarity.Low,
                Weigth = 20,
                ItemType = ItemType.Tools
            };
            var kolki = new Item
            {
                Name = "Kołki",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.Average,
                Weigth = 5,
                ItemType = ItemType.Tools
            };
            var kotwiczkaDoWspinaczki = new Item
            {
                Name = "Kotwiczka do wspinaczki",
                Price = MoneyCalculator.GetUserMoney(4, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 20,
                ItemType = ItemType.Tools
            };
            var ksiazkaDrukowana = new Item
            {
                Name = "Książka drukowana",
                Price = MoneyCalculator.GetUserMoney(100, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 35,
                ItemType = ItemType.Tools
            };
            var ksiazkaIlustrowana = new Item
            {
                Name = "Książka ilustrowana",
                Price = MoneyCalculator.GetUserMoney(350, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 50,
                ItemType = ItemType.Tools
            };
            var liczydlo = new Item
            {
                Name = "Liczydło",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 5,
                ItemType = ItemType.Tools
            };
            var lancuch = new Item
            {
                Name = "Łańcuch, cena za metr",
                Price = MoneyCalculator.GetUserMoney(0, 30, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 5,
                ItemType = ItemType.Tools
            };
            var lom = new Item
            {
                Name = "Łom",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.Average,
                Weigth = 10,
                ItemType = ItemType.Tools
            };
            var lopata = new Item
            {
                Name = "Łopata",
                Price = MoneyCalculator.GetUserMoney(0, 25, 0),
                Rarity = ItemRarity.Average,
                Weigth = 20,
                ItemType = ItemType.Tools
            };
            var mlot = new Item
            {
                Name = "Młot",
                Price = MoneyCalculator.GetUserMoney(0, 20, 0),
                Rarity = ItemRarity.Average,
                Weigth = 40,
                ItemType = ItemType.Tools
            };
            var narzedzia = new Item
            {
                Name = "Narzędzia",
                Price = MoneyCalculator.GetUserMoney(50, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 50,
                ItemType = ItemType.Tools
            };
            var potrzask = new Item
            {
                Name = "Potrzask",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Average,
                Weigth = 2,
                ItemType = ItemType.Tools
            };
            var przyboryDoPisania = new Item
            {
                Name = "Przybory do pisania",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 5,
                ItemType = ItemType.Tools
            };
            var sztabkaMetalu = new Item
            {
                Name = "Sztabka metalu",
                Price = MoneyCalculator.GetUserMoney(0, 25, 0),
                Rarity = ItemRarity.Low,
                Weigth = 20,
                ItemType = ItemType.Tools
            };
            var wnyki = new Item
            {
                Name = "Wnyki",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 20,
                ItemType = ItemType.Tools
            };
            var wytrychy = new Item
            {
                Name = "Wytrychy",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 20,
                ItemType = ItemType.Tools
            };
            var zestawDoCharakteryzacji = new Item
            {
                Name = "Zestaw do charakteryzacji",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 10,
                ItemType = ItemType.Tools
            };
            var wozek = new Item
            {
                Name = "Wózek",
                Price = MoneyCalculator.GetUserMoney(50, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 0,
                ItemType = ItemType.Wehicles
            };
            var woz = new Item
            {
                Name = "Wóz",
                Price = MoneyCalculator.GetUserMoney(90, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 0,
                ItemType = ItemType.Wehicles
            };
            var powoz = new Item
            {
                Name = "Powóz",
                Price = MoneyCalculator.GetUserMoney(500, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 0,
                ItemType = ItemType.Wehicles
            };
            var lodzRzeczna = new Item
            {
                Name = "Łódź rzeczna",
                Price = MoneyCalculator.GetUserMoney(600, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 0,
                ItemType = ItemType.Wehicles
            };
            var lodzWioslowa = new Item
            {
                Name = "Łódź wiosłowa",
                Price = MoneyCalculator.GetUserMoney(90, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 900,
                ItemType = ItemType.Wehicles
            };
            var statek = new Item
            {
                Name = "Statek",
                Price = MoneyCalculator.GetUserMoney(12000, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 0,
                ItemType = ItemType.Wehicles
            };
            var rumak = new Item
            {
                Name = "Rumak",
                Price = MoneyCalculator.GetUserMoney(500, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 0,
                ItemType = ItemType.Wehicles
            };
            var lekkiKonBojowy = new Item
            {
                Name = "Lekki koń bojowy",
                Price = MoneyCalculator.GetUserMoney(300, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 0,
                ItemType = ItemType.Wehicles
            };
            var kon = new Item
            {
                Name = "Koń",
                Price = MoneyCalculator.GetUserMoney(80, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 0,
                ItemType = ItemType.Wehicles
            };
            var kuc = new Item
            {
                Name = "Kuc",
                Price = MoneyCalculator.GetUserMoney(50, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 0,
                ItemType = ItemType.Wehicles
            };
            var siodlo = new Item
            {
                Name = "Siodło",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 50,
                ItemType = ItemType.Wehicles
            };
            var uprzaz = new Item
            {
                Name = "Uprząż",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 20,
                ItemType = ItemType.Wehicles
            };
            var golabPocztowy = new Item
            {
                Name = "Gołąb pocztowy",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var jastrzab = new Item
            {
                Name = "Jastrząb",
                Price = MoneyCalculator.GetUserMoney(80, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var konJuczny = new Item
            {
                Name = "Koń juczny",
                Price = MoneyCalculator.GetUserMoney(40, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var konPociagowyLubMul = new Item
            {
                Name = "Koń pociągowy lub muł",
                Price = MoneyCalculator.GetUserMoney(25, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var kot = new Item
            {
                Name = "Kot",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var koza = new Item
            {
                Name = "Koza",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var krowa = new Item
            {
                Name = "Krowa",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var kurczak = new Item
            {
                Name = "Kurczak",
                Price = MoneyCalculator.GetUserMoney(0, 0, 5),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var owca = new Item
            {
                Name = "Owca",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var pies = new Item
            {
                Name = "Pies (rasowy)",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var piesBojowy = new Item
            {
                Name = "Pies bojowy",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var swinia = new Item
            {
                Name = "Świnia",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var wol = new Item
            {
                Name = "Wół",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.High,
                Weigth = 0,
                ItemType = ItemType.Animals
            };
            var darGrety = new Item
            {
                Name = "Dar Grety",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var miksturaLecznicza = new Item
            {
                Name = "Mikstura lecznicza",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var piwoBugmana = new Item
            {
                Name = "Piwo Bugmana",
                Price = MoneyCalculator.GetUserMoney(50, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 5,
                ItemType = ItemType.Special
            };
            var czarnyJad = new Item
            {
                Name = "Czarny Jad",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var czarnyLotos = new Item
            {
                Name = "Czarny lotos",
                Price = MoneyCalculator.GetUserMoney(20, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var grzybkiSzalonegoKapelusznika = new Item
            {
                Name = "Grzybki Szalonego Kapelusznika",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var jadMantikory = new Item
            {
                Name = "Jad mantikory",
                Price = MoneyCalculator.GetUserMoney(65, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var korzenMandragory = new Item
            {
                Name = "Korzeń mandragory",
                Price = MoneyCalculator.GetUserMoney(25, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var sercoBoj = new Item
            {
                Name = "Sercobój",
                Price = MoneyCalculator.GetUserMoney(800, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var szkarlatnyCien = new Item
            {
                Name = "Szkarłatny Cień",
                Price = MoneyCalculator.GetUserMoney(35, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var slinaChimery = new Item
            {
                Name = "Ślina chimery",
                Price = MoneyCalculator.GetUserMoney(150, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var ksiegaWiedzyTajemnej = new Item
            {
                Name = "Księga wiedzy tajemnej",
                Price = MoneyCalculator.GetUserMoney(500, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var naparKojacy = new Item
            {
                Name = "Napar kojący",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Average,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var odtrutki = new Item
            {
                Name = "Odtrutki",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var relikwia = new Item
            {
                Name = "Relikwia",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var talizmanSzczescia = new Item
            {
                Name = "Talizman szczęścia",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Low,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var wodaSwiecona = new Item
            {
                Name = "Woda święcona",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var dlonWeterana = new Item
            {
                Name = "Dłoń weterana",
                Price = MoneyCalculator.GetUserMoney(60, 0, 0),
                Rarity = ItemRarity.Rare,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var drewnianeZeby = new Item
            {
                Name = "Drewniane zęby",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Low,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var kolczyk = new Item
            {
                Name = "Kolczyk",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Average,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var opaskaNaOko = new Item
            {
                Name = "Opaska na oko",
                Price = MoneyCalculator.GetUserMoney(0, 0, 6),
                Rarity = ItemRarity.Average,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var plytkaCzaszkowa = new Item
            {
                Name = "Płytka czaszkowa",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Low,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var pozlacanyNos = new Item
            {
                Name = "Pozłacany nos",
                Price = MoneyCalculator.GetUserMoney(0, 6, 0),
                Rarity = ItemRarity.Occasional,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var szklaneOko = new Item
            {
                Name = "Szklane oko",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Low,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var sztucznaNoga = new Item
            {
                Name = "Sztuczna noga",
                Price = MoneyCalculator.GetUserMoney(0, 6, 0),
                Rarity = ItemRarity.Low,
                Weigth = 0,
                ItemType = ItemType.Special
            };
            var tatuaz = new Item
            {
                Name = "Tatuaż",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Low,
                Weigth = 0,
                ItemType = ItemType.Special
            };

            #endregion items

            #region abilities

            //Abilities
            var artylerzysta = new Ability { Name = "Artylerzysta" };
            var bardzoSilny = new Ability { Name = "Bardzo silny", HasImpactOnStatictics = true, ImpactValue = 5, ValueToAlter = StatisticType.Stamina };
            var bardzoSzybki = new Ability { Name = "Bardzo szybki", HasImpactOnStatictics = true, ImpactValue = 1, ValueToAlter = StatisticType.Speed };
            var bijatyka = new Ability { Name = "Bijatyka" };
            var blyskawicznePrzeladowanie = new Ability { Name = "Błyskawiczne przeładowanie" };
            var blyskawicznyBlok = new Ability { Name = "Błyskawiczny blok" };
            var blyskotliwosc = new Ability { Name = "Błyskotliwość", HasImpactOnStatictics = true, ImpactValue = 5, ValueToAlter = StatisticType.Inteligence };
            var brawura = new Ability { Name = "Brawura" };
            var bronNaturalna = new Ability { Name = "Broń naturalna" };
            var bronSpecjalna = new Ability { Name = "Broń specjalna (różne)", };
            var bystryWzrok = new Ability { Name = "Bystry wzrok" };
            var charyzmatyczny = new Ability
            {
                Name = "Charyzmatyczny",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Polish
            };
            var chirurgia = new Ability
            {
                Name = "Chirurgia"
            };
            var chodu = new Ability
            {
                Name = "Chodu!"
            };
            var czarnoksiestwo = new Ability
            {
                Name = "Czarnoksięstwo"
            };
            var czlowiekGuma = new Ability
            {
                Name = "Człowiek-guma"
            };
            var czulySluch = new Ability
            {
                Name = "Czuły słuch"
            };
            var dotykMocy = new Ability
            {
                Name = "Dotyk mocy"
            };
            var bardzoWytrzymaly = new Ability { Name = "Bardzo wytrzymały" };
            var odpornosc = new Ability { Name = "Odporność" };
            var etykieta = new Ability
            {
                Name = "Etykieta"
            };
            var geniuszArytmetyczny = new Ability
            {
                Name = "Geniusz arytmetyczny"
            };
            var grotolaz = new Ability
            {
                Name = "Grotołaz"
            };
            var grozny = new Ability
            {
                Name = "Groźny"
            };
            var gusla = new Ability
            {
                Name = "Gusła"
            };
            var intrygant = new Ability
            {
                Name = "Intrygant"
            };
            var krasnoludzkiFach = new Ability
            {
                Name = "Krasnoludzki fach"
            };
            var krasomostwo = new Ability
            {
                Name = "Krasomóstwo"
            };
            var krzepki = new Ability
            {
                Name = "Krzepki"
            };
            var latanie = new Ability
            {
                Name = "Latanie"
            };
            var lewitacja = new Ability
            {
                Name = "Lewitacja"
            };
            var lotrzyk = new Ability
            {
                Name = "Łotrzyk"
            };
            var magiaCzarnoksieska = new Ability
            {
                Name = "Magia czarnoksięska"
            };
            var magiaKaplanska = new Ability
            {
                Name = "Magia kapłańska"
            };
            var magiaPowszechna = new Ability
            {
                Name = "Magia powszechna"
            };
            var magiaProsta = new Ability
            {
                Name = "Magia prosta"
            };
            var magiaTajemna = new Ability
            {
                Name = "Magia tajemna"
            };
            var medytacja = new Ability
            {
                Name = "Medytacja"
            };
            var morderczyAtak = new Ability
            {
                Name = "Morderczy atak"
            };
            var morderczyPocisk = new Ability
            {
                Name = "Morderczy pocisk"
            };
            var nasladowca = new Ability
            {
                Name = "Naśladowca"
            };
            var niepokojacy = new Ability
            {
                Name = "Niepokojący"
            };
            var nieustraszony = new Ability
            {
                Name = "Nieustraszony"
            };
            var niezwykleOdporny = new Ability
            {
                Name = "Niezwykle odporny",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Resistance
            };
            var obiezyswiat = new Ability
            {
                Name = "Obieżyświat"
            };
            var oburecznosc = new Ability
            {
                Name = "Oburęczność"
            };
            var odpornoscNaChaos = new Ability
            {
                Name = "odpornosc na Chaos"
            };
            var odpornoscNaChoroby = new Ability
            {
                Name = "odpornosc na choroby"
            };
            var odpornoscNaMagie = new Ability
            {
                Name = "odpornosc na magię"
            };
            var odpornoscNaTrucizny = new Ability
            {
                Name = "odpornosc na trucizny"
            };
            var odpornoscPsychiczna = new Ability
            {
                Name = "odpornosc psychiczna"
            };
            var odwaga = new Ability
            {
                Name = "Odwaga"
            };
            var ogluszanie = new Ability
            {
                Name = "Ogłuszanie"
            };
            var opanowanie = new Ability
            {
                Name = "Opanowanie",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Willpower
            };
            var ozywieniec = new Ability
            {
                Name = "Ożywieniec"
            };
            var pancerzWiary = new Ability
            {
                Name = "Pancerz wiary"
            };
            var poliglota = new Ability
            {
                Name = "Poliglota"
            };
            var przemawianie = new Ability
            {
                Name = "Przemawianie"
            };
            var przerazajacy = new Ability
            {
                Name = "Przerażajacy"
            };
            var rozbrojenie = new Ability
            {
                Name = "rozbrojenie"
            };
            var silnyCios = new Ability
            {
                Name = "Silny cios"
            };
            var straszny = new Ability
            {
                Name = "Straszny"
            };
            var strzalMierzony = new Ability
            {
                Name = "Strzał mierzony"
            };
            var strzalPrecyzyjny = new Ability
            {
                Name = "Strzał precyzyjny"
            };
            var strzalPrzebijajacy = new Ability
            {
                Name = "Strzał przebijający"
            };
            var strzelecWyborowy = new Ability
            {
                Name = "Strzelec wyborowy",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Shooting
            };
            var szalBojowy = new Ability
            {
                Name = "Szał bojowy"
            };
            var szczescie = new Ability
            {
                Name = "Szczęście"
            };
            var szostyZmysl = new Ability
            {
                Name = "Szósty zmysł"
            };
            var szybkiRefleks = new Ability
            {
                Name = "Szybki refleks",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Agility
            };
            var szybkieWyciagniecie = new Ability
            {
                Name = "Szybkie wyciągnięcie"
            };
            var talentArtystyczny = new Ability
            {
                Name = "Talent artystyczny"
            };
            var twardziel = new Ability
            {
                Name = "Twardziel",
                HasImpactOnStatictics = true,
                ImpactValue = 1,
                ValueToAlter = StatisticType.Hitpoints
            };
            var ulicznik = new Ability
            {
                Name = "Ulicznik"
            };
            var urodzonyWojownik = new Ability
            {
                Name = "Urodzony wojownik",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.CloseCombat
            };
            var wedrowiec = new Ability
            {
                Name = "Wędrowiec"
            };
            var widzenieWCiemnosci = new Ability
            {
                Name = "Widzenie w ciemności"
            };
            var woltyzerka = new Ability
            {
                Name = "Woltyżerka"
            };
            var wyczucieKierunku = new Ability
            {
                Name = "Wyczucie kierunku"
            };
            var wykrywaniePulapek = new Ability
            {
                Name = "Wykrywanie pułapek"
            };
            var wyostrzoneZmysly = new Ability
            {
                Name = "Wyostrzone zmysły"
            };
            var zapasy = new Ability
            {
                Name = "Zapasy"
            };
            var zapieklaNienawisc = new Ability
            {
                Name = "Zapiekła nienawiść"
            };
            var zmyslMagii = new Ability
            {
                Name = "Zmysł magii"
            };
            var zylkaHandlowa = new Ability
            {
                Name = "Żyłka handlowa"
            };

            #endregion abilities

            #region skills

            //Skills
            var charakteryzacja = new Skill
            {
                Name = "Charakteryzacja",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Polish
            };
            var dowodzenie = new Skill
            {
                Name = "Dowodzenie",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Polish
            };
            var hazard = new Skill
            {
                Name = "Hazard",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Inteligence
            };
            var jezdziectwo = new Skill
            {
                Name = "Jeździectwo",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Agility
            };
            var mocnaGlowa = new Skill
            {
                Name = "Mocna głowa",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Resistance
            };
            var opieka = new Skill
            {
                Name = "Opieka nad zwierzętami",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Inteligence
            };
            var plotkowanie = new Skill
            {
                Name = "Plotkowanie",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Polish
            };
            var plywanie = new Skill
            {
                Name = "Pływanie",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Stamina
            };
            var powozenie = new Skill
            {
                Name = "Powożenie",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Stamina
            };
            var przekonywanie = new Skill
            {
                Name = "Przekonywanie",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Polish
            };
            var przeszukiwanie = new Skill
            {
                Name = "Przeszukiwanie",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Inteligence
            };
            var skradanie = new Skill
            {
                Name = "Skradanie się",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Agility
            };
            var spostrzegawczosc = new Skill
            {
                Name = "Spostrzegawczość",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Inteligence
            };
            var sztukaPrzetrwania = new Skill
            {
                Name = "Sztuka przetrwania",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Inteligence
            };
            var targowanie = new Skill
            {
                Name = "Targowanie",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Polish
            };
            var ukrywanieSie = new Skill
            {
                Name = "Ukrywanie się",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Agility
            };
            var wioslarstwo = new Skill
            {
                Name = "Wioślarstwo",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Stamina
            };
            var wspinaczka = new Skill
            {
                Name = "Wspinaczka",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Stamina
            };
            var wycena = new Skill
            {
                Name = "Wycena",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Inteligence
            };
            var zastraszanie = new Skill
            {
                Name = "Zastraszanie",
                SkillLevel = SkillLevel.Basic,
                Trait = StatisticType.Stamina
            };
            var brzuchomostwo = new Skill
            {
                Name = "Brzuchomówstwo",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Polish
            };
            var czytaniePisanie = new Skill
            {
                Name = "Czytanie i pisanie",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var czytanieZWarg = new Skill
            {
                Name = "Czytanie z warg",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var gadanina = new Skill
            {
                Name = "Gadanina",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Polish
            };
            var hipnoza = new Skill
            {
                Name = "Hipnoza",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Willpower
            };
            var jezykTajemny = new Skill
            {
                Name = "Język tajemny",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var kuglarstwo = new Skill
            {
                Name = "Kuglarstwo",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Polish
            };
            var leczenie = new Skill
            {
                Name = "Leczenie",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var nauka = new Skill
            {
                Name = "Nauka (różne)",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var nawigacja = new Skill
            {
                Name = "Nawigacja",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var oswajanie = new Skill
            {
                Name = "Oswajanie",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Polish
            };
            var otwieranieZamkow = new Skill
            {
                Name = "Otwieranie zamków",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Agility
            };
            var rzemioslo = new Skill
            {
                Name = "Rzemiosło (różne)",
                SkillLevel = SkillLevel.Advanced
            };
            var sekretneZnaki = new Skill
            {
                Name = "Sekretne znaki (różne)",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var sekretnyJezyk = new Skill
            {
                Name = "Sekretny język (różne)",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var splatanieMagii = new Skill
            {
                Name = "Splatanie magii",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Stamina
            };
            var sledzenie = new Skill
            {
                Name = "Śledzenie",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Agility
            };
            var torturowanie = new Skill
            {
                Name = "Torturowanie",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Polish
            };
            var tresura = new Skill
            {
                Name = "Tresura",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Polish
            };
            var tropienie = new Skill
            {
                Name = "Tropienie",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var unik = new Skill
            {
                Name = "Unik",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Agility
            };
            var warzenieTrucizn = new Skill
            {
                Name = "Warzenie trucizn",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var wiedza = new Skill
            {
                Name = "Wiedza (różne)",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var wykrywanieMagii = new Skill
            {
                Name = "Wykrywanie magii",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Willpower
            };
            var zastawianiePulapek = new Skill
            {
                Name = "Zastawianie pułapek",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Agility
            };
            var jezyk = new Skill
            {
                Name = "Znajomość języka (różne)",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Inteligence
            };
            var zwinnePalce = new Skill
            {
                Name = "Zwinne palce",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Agility
            };
            var zelgarstwo = new Skill
            {
                Name = "Żeglarstwo",
                SkillLevel = SkillLevel.Advanced,
                Trait = StatisticType.Agility
            };

            #endregion skills

            #region professions

            var akolita = new ProfessionBuilder()
                .SetBasicValues("Akolita", ProfessionLevel.Basic, 0, null, "Bohater musi wybrać boga i świątynię. Wybór ten zapewnia dodatkową cechę lub zdolność, wymienioną w opisie kultu")
                .SetStatistics(5, 5, 0, 5, 0, 10, 10, 10, 0, 2, 0, 0);
            var banita = new ProfessionBuilder()
                .SetBasicValues("Banita", ProfessionLevel.Basic)
                .SetStatistics(10, 10, 0, 0, 10, 5, 0, 0, 1, 2, 0, 0);
            var berserker = new ProfessionBuilder()
                .SetBasicValues("Berserker z norski", ProfessionLevel.Basic)
                .SetStatistics(15, 0, 10, 10, 0, 0, 10, 0, 0, 2, 0, 0);
            var chlop = new ProfessionBuilder()
                .SetBasicValues("Chłop", ProfessionLevel.Basic)
                .SetStatistics(5, 5, 5, 10, 5, 0, 5, 0, 0, 2, 0, 0);
            var ciura = new ProfessionBuilder()
                .SetBasicValues("Ciura obozowa", ProfessionLevel.Basic)
                .SetStatistics(0, 0, 0, 5, 10, 5, 5, 10, 0, 2, 0, 0);
            var cyrkowiec = new ProfessionBuilder()
                .SetBasicValues("Cyrkowiec", ProfessionLevel.Basic)
                .SetStatistics(5, 10, 0, 0, 10, 0, 5, 10, 0, 2, 0, 0);
            var cyrulik = new ProfessionBuilder()
                .SetBasicValues("Cyrulik", ProfessionLevel.Basic)
                .SetStatistics(5, 0, 0, 0, 10, 10, 10, 5, 0, 2, 0, 0);
            var fanatyk = new ProfessionBuilder()
                .SetBasicValues("Fanatyk", ProfessionLevel.Basic)
                .SetStatistics(10, 0, 5, 10, 0, 0, 10, 5, 0, 2, 0, 0);
            var flisak = new ProfessionBuilder()
                .SetBasicValues("Flisak", ProfessionLevel.Basic)
                .SetStatistics(10, 5, 5, 5, 10, 5, 0, 0, 0, 2, 0, 0);
            var giermek = new ProfessionBuilder()
                .SetBasicValues("Giermek", ProfessionLevel.Basic)
                .SetStatistics(10, 5, 5, 5, 5, 0, 0, 5, 1, 2, 0, 0);
            var gladiator = new ProfessionBuilder()
                .SetBasicValues("Gladiator", ProfessionLevel.Basic)
                .SetStatistics(15, 0, 0, 10, 10, 0, 10, 0, 0, 2, 0, 0);
            var goniec = new ProfessionBuilder()
                .SetBasicValues("Goniec", ProfessionLevel.Basic)
                .SetStatistics(10, 0, 5, 5, 10, 5, 5, 0, 0, 2, 0, 1);
            var gornik = new ProfessionBuilder()
                .SetBasicValues("Górnik", ProfessionLevel.Basic)
                .SetStatistics(5, 5, 10, 5, 0, 5, 5, 0, 0, 2, 0, 0);
            var guslarz = new ProfessionBuilder()
                .SetBasicValues("Guślarz", ProfessionLevel.Basic)
                .SetStatistics(0, 0, 0, 5, 5, 5, 10, 10, 0, 2, 1, 0);
            var hiena = new ProfessionBuilder()
                .SetBasicValues("Hiena cmentarna", ProfessionLevel.Basic)
                .SetStatistics(10, 0, 0, 0, 10, 10, 10, 5, 0, 2, 0, 0);
            var kanciarz = new ProfessionBuilder()
                .SetBasicValues("Kanciarz", ProfessionLevel.Basic)
                .SetStatistics(5, 5, 0, 0, 10, 5, 5, 10, 0, 2, 0, 0);
            var kozak = new ProfessionBuilder()
                .SetBasicValues("Kozak kislevski", ProfessionLevel.Basic)
                .SetStatistics(10, 10, 0, 10, 0, 0, 10, 0, 0, 2, 0, 0);
            var lesnik = new ProfessionBuilder()
                .SetBasicValues("Leśnik", ProfessionLevel.Basic)
                .SetStatistics(10, 0, 10, 0, 5, 0, 10, 0, 0, 3, 0, 0);
            var lowca = new ProfessionBuilder()
                .SetBasicValues("Łowca", ProfessionLevel.Basic)
                .SetStatistics(0, 15, 0, 5, 10, 5, 0, 0, 0, 3, 0, 0);
            var lowcanagrod = new ProfessionBuilder()
                .SetBasicValues("Łowca nagród", ProfessionLevel.Basic)
                .SetStatistics(5, 10, 5, 0, 10, 0, 5, 0, 0, 2, 0, 0);
            var mieszczanin = new ProfessionBuilder()
                .SetBasicValues("Mieszczanin", ProfessionLevel.Basic)
                .SetStatistics(5, 0, 0, 0, 5, 10, 5, 5, 0, 2, 0, 0);
            var mytnik = new ProfessionBuilder()
                .SetBasicValues("Mytnik", ProfessionLevel.Basic)
                .SetStatistics(10, 5, 5, 10, 5, 0, 5, 0, 0, 2, 0, 0);
            var najemnik = new ProfessionBuilder()
                .SetBasicValues("Najemnik", ProfessionLevel.Basic)
                .SetStatistics(10, 10, 5, 5, 5, 0, 5, 0, 1, 2, 0, 0);
            var ochotnik = new ProfessionBuilder()
                .SetBasicValues("Ochotnik", ProfessionLevel.Basic)
                .SetStatistics(10, 5, 5, 5, 10, 0, 0, 0, 0, 2, 0, 0);
            var ochroniarz = new ProfessionBuilder()
                .SetBasicValues("Ochroniarz", ProfessionLevel.Basic)
                .SetStatistics(10, 0, 5, 5, 5, 0, 0, 0, 1, 3, 0, 0);
            var oprych = new ProfessionBuilder()
                .SetBasicValues("Oprych", ProfessionLevel.Basic)
                .SetStatistics(10, 0, 5, 5, 0, 0, 5, 5, 1, 2, 0, 0);
            var paz = new ProfessionBuilder()
                .SetBasicValues("Paź", ProfessionLevel.Basic)
                .SetStatistics(0, 0, 0, 0, 10, 10, 5, 10, 0, 2, 0, 0);
            var podzegacz = new ProfessionBuilder()
                .SetBasicValues("Podżegacz", ProfessionLevel.Basic)
                .SetStatistics(5, 5, 0, 0, 5, 10, 0, 10, 0, 2, 0, 0);
            var porywacz = new ProfessionBuilder()
                .SetBasicValues("Porywacz zwłok", ProfessionLevel.Basic)
                .SetStatistics(5, 5, 5, 0, 10, 0, 10, 0, 0, 2, 0, 0);
            var poslaniec = new ProfessionBuilder()
                .SetBasicValues("Posłaniec", ProfessionLevel.Basic)
                .SetStatistics(5, 5, 0, 5, 10, 5, 5, 0, 0, 2, 0, 0);
            var przemytnik = new ProfessionBuilder()
                .SetBasicValues("Przemytnik", ProfessionLevel.Basic)
                .SetStatistics(5, 5, 0, 0, 10, 10, 0, 10, 0, 2, 0, 0);
            var przepatrywacz = new ProfessionBuilder()
                .SetBasicValues("Przepatrywacz", ProfessionLevel.Basic)
                .SetStatistics(5, 10, 0, 0, 10, 10, 5, 0, 0, 2, 0, 0);
            var przewoznik = new ProfessionBuilder()
                .SetBasicValues("Przewoźnik", ProfessionLevel.Basic)
                .SetStatistics(5, 5, 10, 5, 5, 5, 0, 0, 0, 2, 0, 0);
            var rybak = new ProfessionBuilder()
                .SetBasicValues("Rybak", ProfessionLevel.Basic)
                .SetStatistics(0, 5, 10, 5, 10, 5, 0, 0, 0, 2, 0, 0);
            var rzecznik = new ProfessionBuilder()
                .SetBasicValues("Rzecznik rodu", ProfessionLevel.Basic, Race.Human | Race.Dwarf | Race.Halfing)
                .SetStatistics(5, 5, 0, 0, 5, 10, 5, 10, 0, 2, 0, 0);
            var rzemieslnik = new ProfessionBuilder()
                .SetBasicValues("Rzemieślnik", ProfessionLevel.Basic)
                .SetStatistics(0, 0, 5, 5, 10, 5, 10, 0, 0, 2, 0, 0);
            var rzezimieszek = new ProfessionBuilder()
                .SetBasicValues("Rzezimieszek", ProfessionLevel.Basic)
                .SetStatistics(10, 0, 10, 0, 10, 0, 10, 0, 1, 2, 0, 0);
            var skryba = new ProfessionBuilder()
                .SetBasicValues("Skryba", ProfessionLevel.Basic)
                .SetStatistics(0, 0, 0, 0, 10, 10, 10, 5, 0, 2, 0, 0);
            var sluga = new ProfessionBuilder()
                .SetBasicValues("Sługa", ProfessionLevel.Basic)
                .SetStatistics(5, 0, 5, 0, 10, 5, 10, 5, 0, 2, 0, 0);
            var straznik = new ProfessionBuilder()
                .SetBasicValues("Strażnik", ProfessionLevel.Basic)
                .SetStatistics(10, 5, 5, 0, 5, 10, 0, 5, 0, 2, 0, 0);
            var straznikDrog = new ProfessionBuilder()
                .SetBasicValues("Strażnik dróg", ProfessionLevel.Basic)
                .SetStatistics(10, 10, 5, 0, 10, 5, 5, 0, 0, 2, 0, 0);
            var straznikPol = new ProfessionBuilder()
                .SetBasicValues("Strażnik pól", ProfessionLevel.Basic, Race.Human | Race.Dwarf | Race.Elf)
                .SetStatistics(5, 10, 0, 5, 10, 0, 10, 0, 0, 2, 0, 0);
            var straznikWiezienny = new ProfessionBuilder()
                .SetBasicValues("Strażnik więzienny", ProfessionLevel.Basic)
                .SetStatistics(10, 0, 10, 10, 0, 0, 5, 0, 0, 3, 0, 0);
            var szczurolap = new ProfessionBuilder()
                .SetBasicValues("Szczurołap", ProfessionLevel.Basic)
                .SetStatistics(5, 10, 0, 5, 10, 0, 10, 0, 0, 2, 0, 0);
            var szermierz = new ProfessionBuilder()
                .SetBasicValues("Szermierz estalijski", ProfessionLevel.Basic)
                .SetStatistics(15, 0, 5, 5, 10, 5, 0, 0, 1, 2, 0, 0);
            var szlachcic = new ProfessionBuilder()
                .SetBasicValues("Szlachcic", ProfessionLevel.Basic)
                .SetStatistics(10, 5, 0, 0, 5, 5, 5, 10, 0, 2, 0, 0);
            var smieciarz = new ProfessionBuilder()
                .SetBasicValues("Śmieciarz", ProfessionLevel.Basic)
                .SetStatistics(5, 0, 5, 10, 5, 0, 5, 5, 0, 2, 0, 0);
            var tarczownik = new ProfessionBuilder()
                .SetBasicValues("Tarczownik", ProfessionLevel.Basic, Race.Human | Race.Halfing | Race.Elf)
                .SetStatistics(10, 0, 5, 5, 10, 0, 5, 0, 1, 2, 0, 0);
            var uczen = new ProfessionBuilder()
                .SetBasicValues("Uczeń czarodzieja", ProfessionLevel.Basic, Race.Dwarf | Race.Halfing)
                .SetStatistics(0, 0, 0, 0, 5, 10, 15, 5, 0, 2, 1, 0);
            var weglarz = new ProfessionBuilder()
                .SetBasicValues("Węglarz", ProfessionLevel.Basic)
                .SetStatistics(5, 0, 5, 5, 5, 5, 5, 5, 0, 2, 0, 0);
            var wloczykij = new ProfessionBuilder()
                .SetBasicValues("Włóczykij", ProfessionLevel.Basic)
                .SetStatistics(5, 10, 0, 0, 10, 5, 0, 5, 0, 2, 0, 0);
            var wojownik = new ProfessionBuilder()
                .SetBasicValues("Wojownik klanowy", ProfessionLevel.Basic, Race.Human | Race.Halfing | Race.Dwarf)
                .SetStatistics(5, 5, 0, 0, 10, 10, 5, 0, 0, 2, 0, 0);
            var woznica = new ProfessionBuilder()
                .SetBasicValues("Woźnica", ProfessionLevel.Basic)
                .SetStatistics(5, 10, 0, 0, 10, 0, 5, 5, 0, 2, 0, 0);
            var zabojcaTroli = new ProfessionBuilder()
                .SetBasicValues("Zabójca trolli", ProfessionLevel.Basic, Race.Human | Race.Halfing | Race.Elf)
                .SetStatistics(10, 0, 5, 5, 5, 0, 10, 0, 1, 3, 0, 0);
            var zarzadca = new ProfessionBuilder()
                .SetBasicValues("Zarządca", ProfessionLevel.Basic)
                .SetStatistics(5, 5, 5, 0, 0, 10, 5, 10, 0, 2, 0, 0);
            var zlodziej = new ProfessionBuilder()
                .SetBasicValues("Złodziej", ProfessionLevel.Basic)
                .SetStatistics(5, 5, 0, 0, 15, 5, 0, 10, 0, 2, 0, 0);
            var zak = new ProfessionBuilder()
                .SetBasicValues("Żak", ProfessionLevel.Basic)
                .SetStatistics(0, 0, 0, 0, 10, 10, 5, 10, 0, 2, 0, 0);
            var zeglarz = new ProfessionBuilder()
                .SetBasicValues("Żeglarz", ProfessionLevel.Basic)
                .SetStatistics(10, 5, 10, 0, 10, 0, 0, 0, 1, 2, 0, 0);
            var zolnierz = new ProfessionBuilder()
                .SetBasicValues("Żołnierz", ProfessionLevel.Basic)
                .SetStatistics(10, 10, 0, 0, 10, 0, 5, 0, 1, 2, 0, 0);
            var zolnierzOkretowy = new ProfessionBuilder()
                .SetBasicValues("Żołnierz okrętowy", ProfessionLevel.Basic)
                .SetStatistics(10, 10, 10, 0, 5, 0, 5, 0, 1, 3, 0, 0);
            var arcykaplan = new ProfessionBuilder()
                .SetBasicValues("Arcykapłan", ProfessionLevel.Advanced)
                .SetStatistics(20, 20, 15, 15, 15, 20, 30, 25, 1, 6, 3, 0);
            var arcymag = new ProfessionBuilder()
                .SetBasicValues("Arcymag", ProfessionLevel.Advanced)
                .SetStatistics(15, 15, 5, 15, 20, 35, 40, 20, 0, 5, 4, 0);
            var arystokrata = new ProfessionBuilder()
                .SetBasicValues("Arystokrata", ProfessionLevel.Advanced)
                .SetStatistics(25, 15, 10, 10, 10, 20, 20, 30, 1, 6, 0, 0);
            var bard = new ProfessionBuilder()
                .SetBasicValues("Bard", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 0, 0, 15, 10, 5, 25, 0, 4, 0, 0);
            var biczownik = new ProfessionBuilder()
                .SetBasicValues("Biczownik", ProfessionLevel.Advanced, 0, null, "Bohater musi posiadać przynajmniej jedną chorobę umysłową")
                .SetStatistics(15, 0, 10, 15, 5, 0, 20, 10, 1, 6, 0, 0);
            var bosman = new ProfessionBuilder()
                .SetBasicValues("Bosman", ProfessionLevel.Advanced)
                .SetStatistics(15, 15, 10, 15, 10, 10, 10, 10, 1, 4, 0, 0);
            var demagog = new ProfessionBuilder()
                .SetBasicValues("Demagog", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 0, 10, 15, 20, 15, 30, 1, 4, 0, 0);
            var dworzanin = new ProfessionBuilder()
                .SetBasicValues("Dworzanin", ProfessionLevel.Advanced)
                .SetStatistics(5, 5, 0, 0, 10, 20, 20, 20, 0, 4, 0, 0);
            var fechmistrz = new ProfessionBuilder()
                .SetBasicValues("Fechmistrz", ProfessionLevel.Advanced)
                .SetStatistics(40, 40, 25, 25, 30, 0, 20, 0, 2, 8, 0, 0);
            var herold = new ProfessionBuilder()
                .SetBasicValues("Herold", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 5, 5, 15, 15, 10, 20, 0, 4, 0, 0);
            var herszt = new ProfessionBuilder()
                .SetBasicValues("Herszt banitów", ProfessionLevel.Advanced)
                .SetStatistics(20, 30, 10, 20, 10, 10, 10, 20, 2, 6, 0, 0);
            var inzynier = new ProfessionBuilder()
                .SetBasicValues("Inżynier", ProfessionLevel.Advanced)
                .SetStatistics(10, 15, 5, 5, 10, 20, 10, 0, 0, 4, 0, 0);
            var kapitan = new ProfessionBuilder()
                .SetBasicValues("Kapitan", ProfessionLevel.Advanced)
                .SetStatistics(25, 20, 15, 20, 20, 20, 25, 30, 2, 6, 0, 0);
            var kaplan = new ProfessionBuilder()
                .SetBasicValues("Kapłan", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 5, 10, 5, 10, 20, 15, 0, 4, 0, 0);
            var karczmarz = new ProfessionBuilder()
                .SetBasicValues("Karczmarz", ProfessionLevel.Advanced)
                .SetStatistics(10, 5, 5, 10, 20, 10, 10, 20, 0, 4, 0, 0);
            var ksiaze = new ProfessionBuilder()
                .SetBasicValues("Książe złodzieji", ProfessionLevel.Advanced)
                .SetStatistics(20, 20, 15, 15, 20, 25, 20, 30, 1, 6, 0, 0);
            var kupiec = new ProfessionBuilder()
                .SetBasicValues("Kupiec", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 5, 5, 10, 25, 20, 20, 0, 4, 0, 0);
            var lesnyDuch = new ProfessionBuilder()
                .SetBasicValues("Leśny duch", ProfessionLevel.Advanced, Race.Human | Race.Halfing | Race.Dwarf)
                .SetStatistics(20, 30, 15, 15, 25, 20, 20, 0, 2, 6, 0, 0);
            var lowcaCzarownic = new ProfessionBuilder()
                .SetBasicValues("Łowca czarownic", ProfessionLevel.Advanced)
                .SetStatistics(30, 30, 15, 15, 15, 15, 35, 20, 2, 6, 0, 0);
            var lowcaWampirow = new ProfessionBuilder()
                .SetBasicValues("Łowca wampirów", ProfessionLevel.Advanced)
                .SetStatistics(20, 20, 10, 20, 15, 15, 20, 0, 1, 4, 0, 0);
            var majordomus = new ProfessionBuilder()
                .SetBasicValues("Majordomus", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 10, 10, 0, 30, 20, 25, 0, 4, 0, 0);
            var medyk = new ProfessionBuilder()
                .SetBasicValues("Medyk", ProfessionLevel.Advanced)
                .SetStatistics(0, 0, 10, 10, 15, 30, 20, 15, 0, 4, 0, 0);
            var mistrzCieni = new ProfessionBuilder()
                .SetBasicValues("Mistrz cieni", ProfessionLevel.Advanced)
                .SetStatistics(20, 20, 10, 10, 40, 25, 20, 25, 1, 6, 0, 0);
            var mistrzGildii = new ProfessionBuilder()
                .SetBasicValues("Mistrz gildii", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 0, 10, 15, 30, 20, 35, 1, 5, 0, 0);
            var mistrzMagii = new ProfessionBuilder()
                .SetBasicValues("Mistrz magii", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 0, 10, 15, 30, 35, 15, 0, 4, 3, 0);
            var mistrzRzemiosla = new ProfessionBuilder()
                .SetBasicValues("Mistrz rzemiosła", ProfessionLevel.Advanced)
                .SetStatistics(0, 0, 10, 10, 20, 10, 10, 10, 0, 3, 0, 0);
            var mistrzZakonny = new ProfessionBuilder()
                .SetBasicValues("Mistrz zakonny", ProfessionLevel.Advanced)
                .SetStatistics(35, 10, 20, 20, 20, 15, 25, 15, 2, 8, 0, 0);
            var nawigator = new ProfessionBuilder()
                .SetBasicValues("Nawigator", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 5, 5, 10, 25, 10, 0, 0, 4, 0, 0);
            var odkrywca = new ProfessionBuilder()
                .SetBasicValues("Odkrywca", ProfessionLevel.Advanced)
                .SetStatistics(20, 20, 10, 15, 15, 25, 20, 15, 1, 6, 0, 0);
            var oficer = new ProfessionBuilder()
                .SetBasicValues("Oficer", ProfessionLevel.Advanced)
                .SetStatistics(30, 20, 20, 20, 20, 15, 15, 25, 2, 7, 0, 0);
            var oprawca = new ProfessionBuilder()
                .SetBasicValues("Oprawca", ProfessionLevel.Advanced)
                .SetStatistics(15, 0, 20, 10, 10, 10, 20, 15, 0, 4, 0, 0);
            var paser = new ProfessionBuilder()
                .SetBasicValues("Paser", ProfessionLevel.Advanced)
                .SetStatistics(15, 10, 10, 5, 10, 5, 10, 10, 1, 4, 0, 0);
            var rajtar = new ProfessionBuilder()
                .SetBasicValues("Rajtar", ProfessionLevel.Advanced)
                .SetStatistics(20, 20, 10, 10, 15, 0, 15, 15, 1, 4, 0, 0);
            var reketer = new ProfessionBuilder()
                .SetBasicValues("Reketer", ProfessionLevel.Advanced)
                .SetStatistics(20, 15, 15, 10, 10, 0, 15, 10, 1, 5, 0, 0);
            var rozbojnik = new ProfessionBuilder()
                .SetBasicValues("Rozbójnik", ProfessionLevel.Advanced)
                .SetStatistics(20, 20, 10, 10, 30, 20, 15, 25, 1, 4, 0, 0);
            var rycerz = new ProfessionBuilder()
                .SetBasicValues("Rycerz", ProfessionLevel.Advanced)
                .SetStatistics(25, 0, 15, 15, 15, 5, 15, 5, 1, 4, 0, 0);
            var sierzant = new ProfessionBuilder()
                .SetBasicValues("Sierżant", ProfessionLevel.Advanced)
                .SetStatistics(20, 15, 10, 10, 10, 10, 10, 20, 1, 4, 0, 0);
            var skrytobojca = new ProfessionBuilder()
                .SetBasicValues("Skrytobójca", ProfessionLevel.Advanced)
                .SetStatistics(25, 25, 10, 10, 30, 20, 10, 20, 2, 4, 0, 0);
            var strzelec = new ProfessionBuilder()
                .SetBasicValues("Strzelec", ProfessionLevel.Advanced)
                .SetStatistics(0, 35, 10, 10, 25, 10, 20, 15, 1, 4, 0, 0);
            var szampierz = new ProfessionBuilder()
                .SetBasicValues("Szampierz", ProfessionLevel.Advanced)
                .SetStatistics(35, 0, 15, 15, 20, 10, 15, 0, 2, 6, 0, 0);
            var szarlatan = new ProfessionBuilder()
                .SetBasicValues("Szarlatan", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 5, 10, 15, 15, 15, 25, 0, 4, 0, 0);
            var szpieg = new ProfessionBuilder()
                .SetBasicValues("Szpieg", ProfessionLevel.Advanced)
                .SetStatistics(15, 15, 5, 10, 20, 20, 35, 20, 1, 4, 0, 0);
            var uczony = new ProfessionBuilder()
                .SetBasicValues("Uczony", ProfessionLevel.Advanced)
                .SetStatistics(5, 5, 5, 5, 10, 30, 15, 15, 0, 4, 0, 0);
            var urzednik = new ProfessionBuilder()
                .SetBasicValues("Urzędnik", ProfessionLevel.Advanced)
                .SetStatistics(5, 5, 5, 10, 0, 20, 10, 20, 0, 4, 0, 0);
            var weteran = new ProfessionBuilder()
                .SetBasicValues("Weteran", ProfessionLevel.Advanced)
                .SetStatistics(20, 20, 10, 10, 15, 0, 15, 0, 1, 6, 0, 0);
            var wedrownyCzarodziej = new ProfessionBuilder()
                .SetBasicValues("Wędrowny czarodziej", ProfessionLevel.Advanced)
                .SetStatistics(5, 5, 0, 5, 10, 20, 25, 10, 0, 3, 2, 0);
            var wlamywacz = new ProfessionBuilder()
                .SetBasicValues("Włamywacz", ProfessionLevel.Advanced)
                .SetStatistics(10, 10, 5, 5, 25, 10, 10, 0, 0, 4, 0, 0);
            var wybraniecBozy = new ProfessionBuilder()
                .SetBasicValues("Wybraniec boży", ProfessionLevel.Advanced)
                .SetStatistics(15, 15, 10, 10, 10, 15, 25, 20, 1, 5, 2, 0);
            var zabojcaDemonow = new ProfessionBuilder()
                .SetBasicValues("Zabójca demonów", ProfessionLevel.Advanced, Race.Elf | Race.Halfing | Race.Human)
                .SetStatistics(40, 0, 30, 30, 20, 0, 30, 0, 2, 8, 0, 0);
            var zabojcaOlbrzymow = new ProfessionBuilder()
                .SetBasicValues("Zabójca olbrzymów", ProfessionLevel.Advanced, Race.Elf | Race.Halfing | Race.Human, null,
                "Bohater musi wcześniej zabić olbrzyma")
                .SetStatistics(25, 0, 15, 15, 10, 0, 20, 0, 1, 6, 0, 0);
            var zakonnik = new ProfessionBuilder()
                .SetBasicValues("Zakonnik", ProfessionLevel.Advanced)
                .SetStatistics(10, 0, 5, 10, 0, 15, 15, 15, 0, 4, 0, 0);
            var zwadzca = new ProfessionBuilder()
                .SetBasicValues("Zwadźca", ProfessionLevel.Advanced)
                .SetStatistics(20, 20, 10, 20, 20, 15, 15, 10, 1, 4, 0, 0);
            var zwiadowca = new ProfessionBuilder()
                .SetBasicValues("Zwiadowca", ProfessionLevel.Advanced)
                .SetStatistics(20, 20, 10, 10, 15, 20, 15, 0, 1, 6, 0, 0);

            #endregion professions

            #region profession items

            akolita.SetEquipment(new ProfessionBuilderItemModel(szaty));
            akolita.SetEquipment(new ProfessionBuilderItemModel(symbolReligijny));

            banita.SetEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            banita.SetEquipment(new ProfessionBuilderItemModel(luk));
            banita.SetEquipment(new ProfessionBuilderItemModel(tarcza));

            berserker.SetEquipment(new ProfessionBuilderItemModel(bronDwureczna), new ProfessionBuilderItemModel(tarcza));
            berserker.SetEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            berserker.SetEquipment(new ProfessionBuilderItemModel(butelkaGorzalki));

            chlop.SetEquipment(new ProfessionBuilderItemModel(proca), new ProfessionBuilderItemModel(kij));
            chlop.SetEquipment(new ProfessionBuilderItemModel(buklak));

            ciura.SetEquipment(new ProfessionBuilderItemModel(talizmanSzczescia), new ProfessionBuilderItemModel(narzedzia));
            ciura.SetEquipment(new ProfessionBuilderItemModel(sakiewka));
            ciura.SetEquipment(new ProfessionBuilderItemModel(namiot));

            cyrkowiec.SetEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            cyrkowiec.SetEquipment(new ProfessionBuilderItemModel(nozDoRzucania, 3), new ProfessionBuilderItemModel(toporDoRzucania, 2));
            cyrkowiec.SetEquipment(new ProfessionBuilderItemModel(instrumentMuzyczny));
            cyrkowiec.SetEquipment(new ProfessionBuilderItemModel(narzedzia));
            cyrkowiec.SetEquipment(new ProfessionBuilderItemModel(kostium), new ProfessionBuilderItemModel(dobreUbranie));

            cyrulik.SetEquipment(new ProfessionBuilderItemModel(narzedzia));

            fanatyk.SetEquipment(new ProfessionBuilderItemModel(korbacz), new ProfessionBuilderItemModel(morgensztern));
            fanatyk.SetEquipment(new ProfessionBuilderItemModel(butelkaGorzalkiDobrejJakosci));
            fanatyk.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));

            flisak.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            flisak.SetEquipment(new ProfessionBuilderItemModel(lodzWioslowa));

            giermek.SetEquipment(new ProfessionBuilderItemModel(lanca));
            giermek.SetEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            giermek.SetEquipment(new ProfessionBuilderItemModel(czepiecKolczy));
            giermek.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            giermek.SetEquipment(new ProfessionBuilderItemModel(kon));
            giermek.SetEquipment(new ProfessionBuilderItemModel(siodlo));
            giermek.SetEquipment(new ProfessionBuilderItemModel(uprzaz));

            gladiator.SetEquipment(new ProfessionBuilderItemModel(korbacz), new ProfessionBuilderItemModel(bronDwureczna));
            gladiator.SetEquipment(new ProfessionBuilderItemModel(kastet));
            gladiator.SetEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            gladiator.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            gladiator.SetEquipment(new ProfessionBuilderItemModel(tarcza), new ProfessionBuilderItemModel(puklerz));

            goniec.SetEquipment(new ProfessionBuilderItemModel(kusza));
            goniec.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            goniec.SetEquipment(new ProfessionBuilderItemModel(miksturaLecznicza));
            goniec.SetEquipment(new ProfessionBuilderItemModel(talizmanSzczescia));

            gornik.SetEquipment(new ProfessionBuilderItemModel(bronDwureczna));
            gornik.SetEquipment(new ProfessionBuilderItemModel(kilof));
            gornik.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            gornik.SetEquipment(new ProfessionBuilderItemModel(lopata));
            gornik.SetEquipment(new ProfessionBuilderItemModel(latarniaSztormowa));
            gornik.SetEquipment(new ProfessionBuilderItemModel(olejDoLatarni));

            guslarz.SetEquipment(new ProfessionBuilderItemModel(miksturaLecznicza));
            guslarz.SetEquipment(new ProfessionBuilderItemModel(plaszcz));
            guslarz.SetEquipment(new ProfessionBuilderItemModel(kapturMaska));

            hiena.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            hiena.SetEquipment(new ProfessionBuilderItemModel(lom));
            hiena.SetEquipment(new ProfessionBuilderItemModel(latarnia));
            hiena.SetEquipment(new ProfessionBuilderItemModel(olejDoLatarni));
            hiena.SetEquipment(new ProfessionBuilderItemModel(lina));
            hiena.SetEquipment(new ProfessionBuilderItemModel(worek, 2));

            kanciarz.SetEquipment(new ProfessionBuilderItemModel(szykowneUbranie), new ProfessionBuilderItemModel(taliaKart));
            kanciarz.SetEquipment(new ProfessionBuilderItemModel(zlotaKorona, 50));

            kozak.SetEquipment(new ProfessionBuilderItemModel(luk));
            lowca.SetEquipment(new ProfessionBuilderItemModel(strzala, 10));
            kozak.SetEquipment(new ProfessionBuilderItemModel(bronDwureczna));
            kozak.SetEquipment(new ProfessionBuilderItemModel(kolczugaKolcza));
            kozak.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            kozak.SetEquipment(new ProfessionBuilderItemModel(nogawiceSkora));

            lesnik.SetEquipment(new ProfessionBuilderItemModel(bronDwureczna));
            lesnik.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            lesnik.SetEquipment(new ProfessionBuilderItemModel(odtrutki));

            lowca.SetEquipment(new ProfessionBuilderItemModel(dlugiLuk));
            lowca.SetEquipment(new ProfessionBuilderItemModel(strzala, 10));
            lowca.SetEquipment(new ProfessionBuilderItemModel(potrzask, 2), new ProfessionBuilderItemModel(wnyki));
            lowca.SetEquipment(new ProfessionBuilderItemModel(odtrutki));

            lowcanagrod.SetEquipment(new ProfessionBuilderItemModel(kusza));
            lowcanagrod.SetEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            lowcanagrod.SetEquipment(new ProfessionBuilderItemModel(helmSkora));
            lowcanagrod.SetEquipment(new ProfessionBuilderItemModel(kajdany));
            lowcanagrod.SetEquipment(new ProfessionBuilderItemModel(lina));
            lowcanagrod.SetEquipment(new ProfessionBuilderItemModel(kajdany));

            mieszczanin.SetEquipment(new ProfessionBuilderItemModel(dobreUbranie));
            mieszczanin.SetEquipment(new ProfessionBuilderItemModel(liczydlo));
            mieszczanin.SetEquipment(new ProfessionBuilderItemModel(latarnia));

            mytnik.SetEquipment(new ProfessionBuilderItemModel(kusza));
            lowca.SetEquipment(new ProfessionBuilderItemModel(belt, 10));
            mytnik.SetEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            mytnik.SetEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            mytnik.SetEquipment(new ProfessionBuilderItemModel(tarcza));
            mytnik.SetEquipment(new ProfessionBuilderItemModel(zlotaKorona, 50));

            najemnik.SetEquipment(new ProfessionBuilderItemModel(kusza));
            najemnik.SetEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            najemnik.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            najemnik.SetEquipment(new ProfessionBuilderItemModel(tarcza));
            najemnik.SetEquipment(new ProfessionBuilderItemModel(miksturaLecznicza));

            ochotnik.SetEquipment(new ProfessionBuilderItemModel(halabarda), new ProfessionBuilderItemModel(luk));
            ochotnik.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            ochotnik.SetEquipment(new ProfessionBuilderItemModel(helmSkora));

            ochroniarz.SetEquipment(new ProfessionBuilderItemModel(toporDoRzucania, 2), new ProfessionBuilderItemModel(nozDoRzucania, 2));
            ochroniarz.SetEquipment(new ProfessionBuilderItemModel(kastet));
            ochroniarz.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            ochroniarz.SetEquipment(new ProfessionBuilderItemModel(puklerz));

            oprych.SetEquipment(new ProfessionBuilderItemModel(kastet));
            oprych.SetEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            oprych.SetEquipment(new ProfessionBuilderItemModel(kaftanSkora));

            paz.SetEquipment(new ProfessionBuilderItemModel(szykowneUbranie, 2));
            paz.SetEquipment(new ProfessionBuilderItemModel(perfumy));
            paz.SetEquipment(new ProfessionBuilderItemModel(mieszek));

            podzegacz.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            podzegacz.SetEquipment(new ProfessionBuilderItemModel(dobreUbranie));

            porywacz.SetEquipment(new ProfessionBuilderItemModel(latarnia));
            porywacz.SetEquipment(new ProfessionBuilderItemModel(olejDoLatarni));
            porywacz.SetEquipment(new ProfessionBuilderItemModel(kilof));
            porywacz.SetEquipment(new ProfessionBuilderItemModel(lopata));
            porywacz.SetEquipment(new ProfessionBuilderItemModel(worek));

            poslaniec.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            poslaniec.SetEquipment(new ProfessionBuilderItemModel(tarcza));
            poslaniec.SetEquipment(new ProfessionBuilderItemModel(kon));
            poslaniec.SetEquipment(new ProfessionBuilderItemModel(siodlo));
            poslaniec.SetEquipment(new ProfessionBuilderItemModel(uprzaz));
            poslaniec.SetEquipment(new ProfessionBuilderItemModel(tubaNaMapy));

            przemytnik.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            przemytnik.SetEquipment(new ProfessionBuilderItemModel(konPociagowyLubMul));
            przemytnik.SetEquipment(new ProfessionBuilderItemModel(woz), new ProfessionBuilderItemModel(lodzWioslowa));
            przemytnik.SetEquipment(new ProfessionBuilderItemModel(woz), new ProfessionBuilderItemModel(pochodnia, 2));

            przepatrywacz.SetEquipment(new ProfessionBuilderItemModel(luk), new ProfessionBuilderItemModel(kusza));
            przepatrywacz.SetEquipment(new ProfessionBuilderItemModel(bicz), new ProfessionBuilderItemModel(arkan));
            przepatrywacz.SetEquipment(new ProfessionBuilderItemModel(siec));
            przepatrywacz.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            przepatrywacz.SetEquipment(new ProfessionBuilderItemModel(tarcza));
            przepatrywacz.SetEquipment(new ProfessionBuilderItemModel(kon));
            przepatrywacz.SetEquipment(new ProfessionBuilderItemModel(siodlo));
            przepatrywacz.SetEquipment(new ProfessionBuilderItemModel(uprzaz));
            przepatrywacz.SetEquipment(new ProfessionBuilderItemModel(lina));

            przewoznik.SetEquipment(new ProfessionBuilderItemModel(kusza), new ProfessionBuilderItemModel(garlacz));
            przewoznik.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));

            rybak.SetEquipment(new ProfessionBuilderItemModel(wlocznia));
            rybak.SetEquipment(new ProfessionBuilderItemModel(siec));
            rybak.SetEquipment(new ProfessionBuilderItemModel(kotwiczkaDoWspinaczki));
            rybak.SetEquipment(new ProfessionBuilderItemModel(lina));

            rzecznik.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            rzecznik.SetEquipment(new ProfessionBuilderItemModel(szykowneUbranie, 2));
            rzecznik.SetEquipment(new ProfessionBuilderItemModel(przyboryDoPisania));

            rzemieslnik.SetEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            rzemieslnik.SetEquipment(new ProfessionBuilderItemModel(zlotaKorona, 50));

            rzezimieszek.SetEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            rzezimieszek.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            rzezimieszek.SetEquipment(new ProfessionBuilderItemModel(tarcza));
            rzezimieszek.SetEquipment(new ProfessionBuilderItemModel(kon));
            rzezimieszek.SetEquipment(new ProfessionBuilderItemModel(siodlo));
            rzezimieszek.SetEquipment(new ProfessionBuilderItemModel(uprzaz));

            skryba.SetEquipment(new ProfessionBuilderItemModel(swieczkaWoskowa, 2));
            skryba.SetEquipment(new ProfessionBuilderItemModel(zapalka, 5));
            skryba.SetEquipment(new ProfessionBuilderItemModel(ksiazkaIlustrowana));
            skryba.SetEquipment(new ProfessionBuilderItemModel(przyboryDoPisania));

            sluga.SetEquipment(new ProfessionBuilderItemModel(dobreUbranie));
            sluga.SetEquipment(new ProfessionBuilderItemModel(manierkaSkorzana));
            sluga.SetEquipment(new ProfessionBuilderItemModel(hubkaIKrzesiwo));
            sluga.SetEquipment(new ProfessionBuilderItemModel(latarniaSztormowa));
            sluga.SetEquipment(new ProfessionBuilderItemModel(olejDoLatarni));

            straznik.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            straznik.SetEquipment(new ProfessionBuilderItemModel(olejDoLatarni));

            straznikDrog.SetEquipment(new ProfessionBuilderItemModel(pistolet));
            straznikDrog.SetEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            straznikDrog.SetEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            straznikDrog.SetEquipment(new ProfessionBuilderItemModel(tarcza));
            straznikDrog.SetEquipment(new ProfessionBuilderItemModel(lekkiKonBojowy));
            straznikDrog.SetEquipment(new ProfessionBuilderItemModel(siodlo));
            straznikDrog.SetEquipment(new ProfessionBuilderItemModel(uprzaz));
            straznikDrog.SetEquipment(new ProfessionBuilderItemModel(lina));

            straznikPol.SetEquipment(new ProfessionBuilderItemModel(proca));
            straznikPol.SetEquipment(new ProfessionBuilderItemModel(kuc));
            straznikPol.SetEquipment(new ProfessionBuilderItemModel(siodlo));
            straznikPol.SetEquipment(new ProfessionBuilderItemModel(uprzaz));
            straznikPol.SetEquipment(new ProfessionBuilderItemModel(latarnia));
            straznikPol.SetEquipment(new ProfessionBuilderItemModel(olejDoLatarni));
            straznikPol.SetEquipment(new ProfessionBuilderItemModel(lopata));

            #endregion profession items

            #region profession skills

            akolita.SetSkills(czytaniePisanie);
            akolita.SetSkills(leczenie);
            akolita.SetSkills(nauka);
            akolita.SetSkills(nauka);
            akolita.SetSkills(przekonywanie);
            akolita.SetSkills(spostrzegawczosc);
            akolita.SetSkills(jezyk);
            akolita.SetSkills(jezyk);
            banita.SetSkills(opieka, wiedza);
            banita.SetSkills(plotkowanie, sekretneZnaki);
            banita.SetSkills(powozenie, jezdziectwo);
            banita.SetSkills(skradanie);
            banita.SetSkills(spostrzegawczosc);
            banita.SetSkills(ukrywanieSie);
            banita.SetSkills(unik);
            banita.SetSkills(wspinaczka);
            banita.SetSkills(zastawianiePulapek, plywanie);
            berserker.SetSkills(kuglarstwo);
            berserker.SetSkills(mocnaGlowa);
            berserker.SetSkills(plywanie);
            berserker.SetSkills(wiedza);
            berserker.SetSkills(zastraszanie);
            berserker.SetSkills(jezyk);
            chlop.SetSkills(hazard, kuglarstwo);
            chlop.SetSkills(opieka, przekonywanie);
            chlop.SetSkills(oswajanie, rzemioslo);
            chlop.SetSkills(powozenie, rzemioslo);
            chlop.SetSkills(sztukaPrzetrwania, rzemioslo);
            chlop.SetSkills(tresura, plywanie);
            chlop.SetSkills(ukrywanieSie);
            chlop.SetSkills(wioslarstwo, zastawianiePulapek);
            chlop.SetSkills(wspinaczka, skradanie);
            ciura.SetSkills(opieka, powozenie);
            ciura.SetSkills(plotkowanie);
            ciura.SetSkills(przekonywanie, wycena);
            ciura.SetSkills(przeszukiwanie);
            ciura.SetSkills(rzemioslo);
            ciura.SetSkills(spostrzegawczosc);
            ciura.SetSkills(targowanie);
            ciura.SetSkills(jezyk);
            ciura.SetSkills(zwinnePalce);
            cyrkowiec.SetSkills(kuglarstwo);
            cyrkowiec.SetSkills(opieka, plywanie);
            cyrkowiec.SetSkills(przekonywanie);
            cyrkowiec.SetSkills(spostrzegawczosc);
            cyrkowiec.SetSkills(wiedza);
            cyrkowiec.SetSkills(wycena, plotkowanie);
            cyrkowiec.SetSkills(jezyk);
            cyrkowiec.SetSkills(2, brzuchomostwo, gadanina, hipnoza, jezdziectwo, oswajanie, tresura, wspinaczka, zwinnePalce);
            cyrulik.SetSkills(czytaniePisanie);
            cyrulik.SetSkills(leczenie);
            cyrulik.SetSkills(powozenie, plywanie);
            cyrulik.SetSkills(przekonywanie);
            cyrulik.SetSkills(rzemioslo);
            cyrulik.SetSkills(spostrzegawczosc);
            cyrulik.SetSkills(targowanie);
            cyrulik.SetSkills(jezyk);
            fanatyk.SetSkills(czytaniePisanie);
            fanatyk.SetSkills(nauka);
            fanatyk.SetSkills(przekonywanie);
            fanatyk.SetSkills(wiedza);
            fanatyk.SetSkills(zastraszanie);
            flisak.SetSkills(mocnaGlowa, plotkowanie);
            flisak.SetSkills(nawigacja);
            flisak.SetSkills(plywanie);
            flisak.SetSkills(sekretnyJezyk, jezyk);
            flisak.SetSkills(spostrzegawczosc);
            flisak.SetSkills(sztukaPrzetrwania);
            flisak.SetSkills(wiedza);
            flisak.SetSkills(wioslarstwo);
            flisak.SetSkills(zelgarstwo);
            giermek.SetSkills(jezdziectwo);
            giermek.SetSkills(nauka, wiedza);
            giermek.SetSkills(opieka);
            giermek.SetSkills(przekonywanie, plotkowanie);
            giermek.SetSkills(tresura);
            giermek.SetSkills(unik);
            giermek.SetSkills(jezyk);
            gladiator.SetSkills(unik);
            gladiator.SetSkills(zastraszanie);
            goniec.SetSkills(nawigacja);
            goniec.SetSkills(plywanie);
            goniec.SetSkills(sekretneZnaki);
            goniec.SetSkills(spostrzegawczosc);
            goniec.SetSkills(sztukaPrzetrwania);
            goniec.SetSkills(unik);
            gornik.SetSkills(nawigacja);
            gornik.SetSkills(opieka);
            gornik.SetSkills(rzemioslo);
            gornik.SetSkills(spostrzegawczosc);
            gornik.SetSkills(ukrywanieSie, powozenie);
            gornik.SetSkills(wspinaczka);
            gornik.SetSkills(wycena, sztukaPrzetrwania);
            guslarz.SetSkills(leczenie, hipnoza);
            guslarz.SetSkills(opieka, targowanie);
            guslarz.SetSkills(oswajanie, rzemioslo);
            guslarz.SetSkills(przekonywanie, zastraszanie);
            guslarz.SetSkills(przeszukiwanie);
            guslarz.SetSkills(splatanieMagii);
            guslarz.SetSkills(spostrzegawczosc);
            guslarz.SetSkills(wykrywanieMagii);
            hiena.SetSkills(czytaniePisanie);
            hiena.SetSkills(otwieranieZamkow, skradanie);
            hiena.SetSkills(przeszukiwanie);
            hiena.SetSkills(spostrzegawczosc);
            hiena.SetSkills(ukrywanieSie, sztukaPrzetrwania);
            hiena.SetSkills(wiedza, sekretneZnaki);
            hiena.SetSkills(wspinaczka);
            hiena.SetSkills(wycena);
            hiena.SetSkills(jezyk);
            kanciarz.SetSkills(gadanina);
            kanciarz.SetSkills(hazard, sekretneZnaki);
            kanciarz.SetSkills(kuglarstwo);
            kanciarz.SetSkills(plotkowanie, targowanie);
            kanciarz.SetSkills(przekonywanie);
            kanciarz.SetSkills(przeszukiwanie, sekretnyJezyk);
            kanciarz.SetSkills(spostrzegawczosc);
            kanciarz.SetSkills(wycena);
            kanciarz.SetSkills(jezyk);
            kozak.SetSkills(hazard, targowanie);
            kozak.SetSkills(mocnaGlowa);
            kozak.SetSkills(przeszukiwanie);
            kozak.SetSkills(spostrzegawczosc);
            kozak.SetSkills(sztukaPrzetrwania);
            kozak.SetSkills(unik);
            kozak.SetSkills(wiedza);
            kozak.SetSkills(jezyk);
            lesnik.SetSkills(sekretneZnaki);
            lesnik.SetSkills(sekretnyJezyk);
            lesnik.SetSkills(skradanie);
            lesnik.SetSkills(spostrzegawczosc);
            lesnik.SetSkills(tropienie, zastawianiePulapek);
            lesnik.SetSkills(ukrywanieSie);
            lesnik.SetSkills(wspinaczka);
            lowca.SetSkills(przeszukiwanie, plywanie);
            lowca.SetSkills(sekretneZnaki);
            lowca.SetSkills(skradanie, zastawianiePulapek);
            lowca.SetSkills(spostrzegawczosc);
            lowca.SetSkills(sztukaPrzetrwania);
            lowca.SetSkills(tropienie);
            lowca.SetSkills(ukrywanieSie);
            lowcanagrod.SetSkills(przeszukiwanie);
            lowcanagrod.SetSkills(skradanie);
            lowcanagrod.SetSkills(spostrzegawczosc);
            lowcanagrod.SetSkills(sztukaPrzetrwania);
            lowcanagrod.SetSkills(sledzenie);
            lowcanagrod.SetSkills(tropienie);
            lowcanagrod.SetSkills(zastraszanie);
            mieszczanin.SetSkills(plotkowanie, czytaniePisanie);
            mieszczanin.SetSkills(powozenie);
            mieszczanin.SetSkills(przeszukiwanie);
            mieszczanin.SetSkills(spostrzegawczosc);
            mieszczanin.SetSkills(targowanie);
            mieszczanin.SetSkills(wiedza, mocnaGlowa);
            mieszczanin.SetSkills(wycena);
            mieszczanin.SetSkills(jezyk);
            mieszczanin.SetSkills(jezyk);
            mytnik.SetSkills(czytaniePisanie);
            mytnik.SetSkills(plotkowanie, targowanie);
            mytnik.SetSkills(przeszukiwanie);
            mytnik.SetSkills(spostrzegawczosc);
            mytnik.SetSkills(unik);
            mytnik.SetSkills(wycena);
            mytnik.SetSkills(jezyk);
            najemnik.SetSkills(opieka, hazard);
            najemnik.SetSkills(plotkowanie, targowanie);
            najemnik.SetSkills(powozenie, jezdziectwo);
            najemnik.SetSkills(sekretnyJezyk);
            najemnik.SetSkills(spostrzegawczosc, przeszukiwanie);
            najemnik.SetSkills(unik);
            najemnik.SetSkills(wiedza);
            najemnik.SetSkills(jezyk, plywanie);
            ochotnik.SetSkills(hazard, plotkowanie);
            ochotnik.SetSkills(opieka);
            ochotnik.SetSkills(powozenie, plywanie);
            ochotnik.SetSkills(przeszukiwanie);
            ochotnik.SetSkills(rzemioslo);
            ochotnik.SetSkills(spostrzegawczosc);
            ochotnik.SetSkills(sztukaPrzetrwania);
            ochotnik.SetSkills(unik);
            ochroniarz.SetSkills(leczenie);
            ochroniarz.SetSkills(spostrzegawczosc);
            ochroniarz.SetSkills(unik);
            ochroniarz.SetSkills(zastraszanie);
            oprych.SetSkills(hazard);
            oprych.SetSkills(mocnaGlowa);
            oprych.SetSkills(sekretnyJezyk);
            oprych.SetSkills(unik);
            oprych.SetSkills(zastraszanie);
            paz.SetSkills(czytaniePisanie);
            paz.SetSkills(gadanina);
            paz.SetSkills(nauka);
            paz.SetSkills(plotkowanie, jezyk);
            paz.SetSkills(przeszukiwanie);
            paz.SetSkills(spostrzegawczosc);
            paz.SetSkills(targowanie);
            paz.SetSkills(wycena);
            podzegacz.SetSkills(czytaniePisanie);
            podzegacz.SetSkills(nauka, plotkowanie);
            podzegacz.SetSkills(nauka, wiedza);
            podzegacz.SetSkills(przekonywanie);
            podzegacz.SetSkills(spostrzegawczosc);
            podzegacz.SetSkills(ukrywanieSie);
            podzegacz.SetSkills(jezyk);
            podzegacz.SetSkills(jezyk);
            porywacz.SetSkills(plotkowanie, targowanie);
            porywacz.SetSkills(powozenie);
            porywacz.SetSkills(przeszukiwanie);
            porywacz.SetSkills(sekretneZnaki);
            porywacz.SetSkills(skradanie);
            porywacz.SetSkills(spostrzegawczosc);
            porywacz.SetSkills(wspinaczka);
            poslaniec.SetSkills(jezdziectwo);
            poslaniec.SetSkills(nawigacja);
            poslaniec.SetSkills(opieka);
            poslaniec.SetSkills(plywanie);
            poslaniec.SetSkills(sekretneZnaki);
            poslaniec.SetSkills(spostrzegawczosc);
            poslaniec.SetSkills(sztukaPrzetrwania);
            poslaniec.SetSkills(wiedza, plotkowanie);
            poslaniec.SetSkills(jezyk);
            przemytnik.SetSkills(plotkowanie, sekretnyJezyk);
            przemytnik.SetSkills(plywanie);
            przemytnik.SetSkills(powozenie);
            przemytnik.SetSkills(przeszukiwanie);
            przemytnik.SetSkills(skradanie);
            przemytnik.SetSkills(spostrzegawczosc);
            przemytnik.SetSkills(targowanie);
            przemytnik.SetSkills(wioslarstwo);
            przemytnik.SetSkills(wycena);
            przemytnik.SetSkills(jezyk, sekretneZnaki);
            przepatrywacz.SetSkills(jezdziectwo);
            przepatrywacz.SetSkills(nawigacja);
            przepatrywacz.SetSkills(opieka);
            przepatrywacz.SetSkills(przeszukiwanie);
            przepatrywacz.SetSkills(skradanie);
            przepatrywacz.SetSkills(spostrzegawczosc);
            przepatrywacz.SetSkills(sztukaPrzetrwania);
            przepatrywacz.SetSkills(tropienie);
            przewoznik.SetSkills(plotkowanie, zastraszanie);
            przewoznik.SetSkills(plywanie);
            przewoznik.SetSkills(przekonywanie);
            przewoznik.SetSkills(spostrzegawczosc);
            przewoznik.SetSkills(targowanie);
            przewoznik.SetSkills(wiedza);
            przewoznik.SetSkills(wioslarstwo);
            przewoznik.SetSkills(wycena, sekretnyJezyk);
            rybak.SetSkills(mocnaGlowa, targowanie);
            rybak.SetSkills(nawigacja, rzemioslo);
            rybak.SetSkills(plywanie);
            rybak.SetSkills(spostrzegawczosc);
            rybak.SetSkills(sztukaPrzetrwania);
            rybak.SetSkills(wiedza);
            rybak.SetSkills(wioslarstwo);
            rybak.SetSkills(jezyk);
            rybak.SetSkills(zelgarstwo);
            rzecznik.SetSkills(czytaniePisanie);
            rzecznik.SetSkills(plotkowanie);
            rzecznik.SetSkills(plywanie);
            rzecznik.SetSkills(przekonywanie);
            rzecznik.SetSkills(rzemioslo);
            rzecznik.SetSkills(sekretnyJezyk);
            rzecznik.SetSkills(spostrzegawczosc);
            rzecznik.SetSkills(targowanie);
            rzecznik.SetSkills(wiedza);
            rzecznik.SetSkills(wycena);
            rzemieslnik.SetSkills(czytaniePisanie);
            rzemieslnik.SetSkills(opieka, plotkowanie);
            rzemieslnik.SetSkills(powozenie);
            rzemieslnik.SetSkills(rzemioslo);
            rzemieslnik.SetSkills(sekretnyJezyk);
            rzemieslnik.SetSkills(spostrzegawczosc);
            rzemieslnik.SetSkills(targowanie);
            rzemieslnik.SetSkills(wycena);
            rzezimieszek.SetSkills(jezdziectwo);
            rzezimieszek.SetSkills(plotkowanie, targowanie);
            rzezimieszek.SetSkills(unik);
            rzezimieszek.SetSkills(zastraszanie);
            skryba.SetSkills(czytaniePisanie);
            skryba.SetSkills(nauka);
            skryba.SetSkills(rzemioslo);
            skryba.SetSkills(sekretnyJezyk);
            skryba.SetSkills(spostrzegawczosc);
            skryba.SetSkills(wiedza, plotkowanie);
            skryba.SetSkills(jezyk);
            skryba.SetSkills(jezyk);
            skryba.SetSkills(jezyk);
            sluga.SetSkills(czytaniePisanie, zwinnePalce);
            sluga.SetSkills(gadanina);
            sluga.SetSkills(opieka, rzemioslo);
            sluga.SetSkills(plotkowanie);
            sluga.SetSkills(powozenie, przeszukiwanie);
            sluga.SetSkills(spostrzegawczosc);
            sluga.SetSkills(targowanie, wycena);
            sluga.SetSkills(unik);
            straznik.SetSkills(nauka);
            straznik.SetSkills(plotkowanie);
            straznik.SetSkills(przeszukiwanie);
            straznik.SetSkills(spostrzegawczosc);
            straznik.SetSkills(tropienie);
            straznik.SetSkills(unik);
            straznik.SetSkills(zastraszanie);
            straznikDrog.SetSkills(jezdziectwo);
            straznikDrog.SetSkills(nawigacja);
            straznikDrog.SetSkills(opieka);
            straznikDrog.SetSkills(powozenie);
            straznikDrog.SetSkills(przeszukiwanie);
            straznikDrog.SetSkills(spostrzegawczosc);
            straznikDrog.SetSkills(sztukaPrzetrwania);
            straznikDrog.SetSkills(tropienie, sekretneZnaki);
            straznikDrog.SetSkills(wiedza, plotkowanie);
            straznikPol.SetSkills(nauka, wiedza);
            straznikPol.SetSkills(przeszukiwanie);
            straznikPol.SetSkills(skradanie);
            straznikPol.SetSkills(spostrzegawczosc);
            straznikPol.SetSkills(sztukaPrzetrwania);
            straznikPol.SetSkills(tropienie);
            straznikPol.SetSkills(ukrywanieSie);
            straznikWiezienny.SetSkills(dowodzenie);
            straznikWiezienny.SetSkills(leczenie, zwinnePalce);
            straznikWiezienny.SetSkills(mocnaGlowa);
            straznikWiezienny.SetSkills(przeszukiwanie);
            straznikWiezienny.SetSkills(spostrzegawczosc);
            straznikWiezienny.SetSkills(unik);
            straznikWiezienny.SetSkills(zastraszanie);
            szczurolap.SetSkills(opieka);
            szczurolap.SetSkills(przeszukiwanie);
            szczurolap.SetSkills(skradanie);
            szczurolap.SetSkills(spostrzegawczosc);
            szczurolap.SetSkills(tresura);
            szczurolap.SetSkills(ukrywanieSie);
            szczurolap.SetSkills(zastawianiePulapek);
            szermierz.SetSkills(czytaniePisanie);
            szermierz.SetSkills(nauka);
            szermierz.SetSkills(unik);
            szermierz.SetSkills(wiedza);
            szermierz.SetSkills(jezyk);
            szlachcic.SetSkills(czytaniePisanie);
            szlachcic.SetSkills(gadanina, dowodzenie);
            szlachcic.SetSkills(hazard, plotkowanie);
            szlachcic.SetSkills(jezdziectwo);
            szlachcic.SetSkills(mocnaGlowa, kuglarstwo);
            szlachcic.SetSkills(przekonywanie);
            szlachcic.SetSkills(wiedza);
            szlachcic.SetSkills(jezyk);
            smieciarz.SetSkills(opieka);
            smieciarz.SetSkills(powozenie);
            smieciarz.SetSkills(przekonywanie, plotkowanie);
            smieciarz.SetSkills(przeszukiwanie);
            smieciarz.SetSkills(spostrzegawczosc);
            smieciarz.SetSkills(targowanie);
            smieciarz.SetSkills(wiedza);
            smieciarz.SetSkills(wycena);
            tarczownik.SetSkills(nawigacja);
            tarczownik.SetSkills(spostrzegawczosc);
            tarczownik.SetSkills(sledzenie);
            tarczownik.SetSkills(unik);
            tarczownik.SetSkills(wspinaczka);
            uczen.SetSkills(czytaniePisanie);
            uczen.SetSkills(jezyk);
            uczen.SetSkills(nauka);
            uczen.SetSkills(przeszukiwanie);
            uczen.SetSkills(splatanieMagii);
            uczen.SetSkills(spostrzegawczosc);
            uczen.SetSkills(wykrywanieMagii);
            uczen.SetSkills(jezyk);
            weglarz.SetSkills(powozenie, plotkowanie);
            weglarz.SetSkills(przeszukiwanie);
            weglarz.SetSkills(sekretneZnaki);
            weglarz.SetSkills(spostrzegawczosc);
            weglarz.SetSkills(sztukaPrzetrwania);
            weglarz.SetSkills(targowanie);
            weglarz.SetSkills(wiedza, ukrywanieSie);
            weglarz.SetSkills(wspinaczka);
            wloczykij.SetSkills(kuglarstwo, sekretneZnaki);
            wloczykij.SetSkills(leczenie, spostrzegawczosc);
            wloczykij.SetSkills(nawigacja);
            wloczykij.SetSkills(plotkowanie, sekretnyJezyk);
            wloczykij.SetSkills(skradanie);
            wloczykij.SetSkills(sztukaPrzetrwania);
            wloczykij.SetSkills(targowanie, plywanie);
            wloczykij.SetSkills(wiedza);
            wojownik.SetSkills(leczenie, przeszukiwanie);
            wojownik.SetSkills(skradanie);
            wojownik.SetSkills(spostrzegawczosc);
            wojownik.SetSkills(sztukaPrzetrwania);
            wojownik.SetSkills(tropienie);
            wojownik.SetSkills(ukrywanieSie);
            wojownik.SetSkills(unik);
            wojownik.SetSkills(wspinaczka);
            woznica.SetSkills(leczenie, jezdziectwo);
            woznica.SetSkills(nawigacja);
            woznica.SetSkills(opieka);
            woznica.SetSkills(plotkowanie, targowanie);
            woznica.SetSkills(powozenie);
            woznica.SetSkills(sekretneZnaki);
            woznica.SetSkills(spostrzegawczosc);
            woznica.SetSkills(jezyk);
            zabojcaTroli.SetSkills(mocnaGlowa);
            zabojcaTroli.SetSkills(unik);
            zabojcaTroli.SetSkills(zastraszanie);
            zarzadca.SetSkills(czytaniePisanie);
            zarzadca.SetSkills(dowodzenie, nawigacja);
            zarzadca.SetSkills(jezdziectwo);
            zarzadca.SetSkills(nauka);
            zarzadca.SetSkills(opieka, plotkowanie);
            zarzadca.SetSkills(przekonywanie);
            zarzadca.SetSkills(spostrzegawczosc);
            zarzadca.SetSkills(zastraszanie, wiedza);
            zlodziej.SetSkills(czytaniePisanie, zwinnePalce);
            zlodziej.SetSkills(hazard, otwieranieZamkow);
            zlodziej.SetSkills(przekonywanie, wspinaczka);
            zlodziej.SetSkills(przeszukiwanie);
            zlodziej.SetSkills(sekretnyJezyk, sekretneZnaki);
            zlodziej.SetSkills(skradanie);
            zlodziej.SetSkills(spostrzegawczosc);
            zlodziej.SetSkills(ukrywanieSie);
            zlodziej.SetSkills(wycena, charakteryzacja);
            zak.SetSkills(czytaniePisanie);
            zak.SetSkills(leczenie, przeszukiwanie);
            zak.SetSkills(nauka);
            zak.SetSkills(nauka, plotkowanie);
            zak.SetSkills(przekonywanie, mocnaGlowa);
            zak.SetSkills(spostrzegawczosc);
            zak.SetSkills(jezyk);
            zak.SetSkills(jezyk);
            zeglarz.SetSkills(mocnaGlowa, spostrzegawczosc);
            zeglarz.SetSkills(plywanie);
            zeglarz.SetSkills(unik);
            zeglarz.SetSkills(wiedza);
            zeglarz.SetSkills(wioslarstwo);
            zeglarz.SetSkills(wspinaczka);
            zeglarz.SetSkills(jezyk);
            zeglarz.SetSkills(zelgarstwo);
            zolnierz.SetSkills(hazard, plotkowanie);
            zolnierz.SetSkills(opieka, leczenie);
            zolnierz.SetSkills(powozenie, jezdziectwo);
            zolnierz.SetSkills(unik);
            zolnierz.SetSkills(wiedza, spostrzegawczosc);
            zolnierz.SetSkills(zastraszanie);
            zolnierzOkretowy.SetSkills(mocnaGlowa);
            zolnierzOkretowy.SetSkills(plotkowanie, sekretnyJezyk);
            zolnierzOkretowy.SetSkills(plywanie);
            zolnierzOkretowy.SetSkills(unik);
            zolnierzOkretowy.SetSkills(wiedza, hazard);
            zolnierzOkretowy.SetSkills(wioslarstwo);
            zolnierzOkretowy.SetSkills(zastraszanie);
            arcykaplan.SetSkills(jezdziectwo, plywanie);
            arcykaplan.SetSkills(jezyk);
            arcykaplan.SetSkills(leczenie);
            arcykaplan.SetSkills(nauka);
            arcykaplan.SetSkills(nauka);
            arcykaplan.SetSkills(plotkowanie);
            arcykaplan.SetSkills(przekonywanie);
            arcykaplan.SetSkills(splatanieMagii);
            arcykaplan.SetSkills(wiedza);
            arcykaplan.SetSkills(wykrywanieMagii);
            arcykaplan.SetSkills(zastraszanie);
            arcykaplan.SetSkills(jezyk);
            arcymag.SetSkills(czytaniePisanie);
            arcymag.SetSkills(jezyk);
            arcymag.SetSkills(jezyk);
            arcymag.SetSkills(nauka);
            arcymag.SetSkills(nauka);
            arcymag.SetSkills(nauka);
            arcymag.SetSkills(nauka);
            arcymag.SetSkills(przekonywanie, zastraszanie);
            arcymag.SetSkills(splatanieMagii);
            arcymag.SetSkills(wiedza);
            arcymag.SetSkills(wiedza);
            arcymag.SetSkills(wiedza);
            arcymag.SetSkills(wykrywanieMagii);
            arcymag.SetSkills(jezyk);
            arystokrata.SetSkills(czytaniePisanie);
            arystokrata.SetSkills(dowodzenie);
            arystokrata.SetSkills(jezdziectwo);
            arystokrata.SetSkills(nauka);
            arystokrata.SetSkills(nauka);
            arystokrata.SetSkills(plotkowanie);
            arystokrata.SetSkills(przekonywanie);
            arystokrata.SetSkills(spostrzegawczosc);
            arystokrata.SetSkills(wiedza);
            arystokrata.SetSkills(wycena);
            arystokrata.SetSkills(jezyk);
            arystokrata.SetSkills(jezyk);
            bard.SetSkills(czytaniePisanie);
            bard.SetSkills(kuglarstwo);
            bard.SetSkills(kuglarstwo);
            bard.SetSkills(plotkowanie);
            bard.SetSkills(przekonywanie);
            bard.SetSkills(spostrzegawczosc);
            bard.SetSkills(wiedza);
            bard.SetSkills(wiedza);
            bard.SetSkills(jezyk);
            biczownik.SetSkills(leczenie);
            biczownik.SetSkills(nauka);
            biczownik.SetSkills(przekonywanie);
            biczownik.SetSkills(zastraszanie);
            biczownik.SetSkills(jezyk);
            bosman.SetSkills(dowodzenie);
            bosman.SetSkills(hazard);
            bosman.SetSkills(mocnaGlowa);
            bosman.SetSkills(plotkowanie);
            bosman.SetSkills(plywanie);
            bosman.SetSkills(rzemioslo);
            bosman.SetSkills(unik);
            bosman.SetSkills(wiedza);
            bosman.SetSkills(wiedza);
            bosman.SetSkills(wioslarstwo);
            bosman.SetSkills(zastraszanie);
            bosman.SetSkills(jezyk);
            bosman.SetSkills(zelgarstwo);
            demagog.SetSkills(charakteryzacja);
            demagog.SetSkills(dowodzenie);
            demagog.SetSkills(gadanina);
            demagog.SetSkills(nauka);
            demagog.SetSkills(nauka);
            demagog.SetSkills(plotkowanie);
            demagog.SetSkills(przekonywanie);
            demagog.SetSkills(spostrzegawczosc);
            demagog.SetSkills(ukrywanieSie);
            demagog.SetSkills(unik);
            demagog.SetSkills(wiedza);
            demagog.SetSkills(zastraszanie);
            demagog.SetSkills(jezyk);
            dworzanin.SetSkills(czytaniePisanie);
            dworzanin.SetSkills(dowodzenie, kuglarstwo);
            dworzanin.SetSkills(gadanina);
            dworzanin.SetSkills(jezdziectwo);
            dworzanin.SetSkills(nauka, hazard);
            dworzanin.SetSkills(plotkowanie);
            dworzanin.SetSkills(przekonywanie);
            dworzanin.SetSkills(spostrzegawczosc);
            dworzanin.SetSkills(wiedza);
            dworzanin.SetSkills(wycena);
            dworzanin.SetSkills(jezyk);
            dworzanin.SetSkills(jezyk);
            fechmistrz.SetSkills(spostrzegawczosc);
            fechmistrz.SetSkills(unik);
            fechmistrz.SetSkills(wycena);
            fechmistrz.SetSkills(zastraszanie);
            herold.SetSkills(czytaniePisanie);
            herold.SetSkills(gadanina);
            herold.SetSkills(jezdziectwo);
            herold.SetSkills(nauka);
            herold.SetSkills(nauka);
            herold.SetSkills(plotkowanie);
            herold.SetSkills(przekonywanie);
            herold.SetSkills(spostrzegawczosc);
            herold.SetSkills(targowanie);
            herold.SetSkills(wiedza);
            herold.SetSkills(wiedza);
            herold.SetSkills(wycena);
            herold.SetSkills(jezyk);
            herold.SetSkills(jezyk);
            herszt.SetSkills(dowodzenie);
            herszt.SetSkills(jezdziectwo);
            herszt.SetSkills(nauka);
            herszt.SetSkills(sekretneZnaki);
            herszt.SetSkills(sekretnyJezyk);
            herszt.SetSkills(skradanie);
            herszt.SetSkills(spostrzegawczosc);
            herszt.SetSkills(tropienie);
            herszt.SetSkills(ukrywanieSie);
            herszt.SetSkills(wiedza);
            herszt.SetSkills(wspinaczka);
            inzynier.SetSkills(czytaniePisanie);
            inzynier.SetSkills(nauka);
            inzynier.SetSkills(nauka);
            inzynier.SetSkills(powozenie, jezdziectwo);
            inzynier.SetSkills(rzemioslo);
            inzynier.SetSkills(spostrzegawczosc);
            inzynier.SetSkills(wiedza);
            inzynier.SetSkills(jezyk);
            kapitan.SetSkills(dowodzenie);
            kapitan.SetSkills(nauka);
            kapitan.SetSkills(plywanie);
            kapitan.SetSkills(rzemioslo);
            kapitan.SetSkills(spostrzegawczosc);
            kapitan.SetSkills(tresura);
            kapitan.SetSkills(unik);
            kapitan.SetSkills(wiedza);
            kapitan.SetSkills(wiedza);
            kapitan.SetSkills(wiedza);
            kapitan.SetSkills(jezyk);
            kapitan.SetSkills(jezyk);
            kapitan.SetSkills(jezyk);
            kapitan.SetSkills(zelgarstwo);
            kaplan.SetSkills(czytaniePisanie);
            kaplan.SetSkills(jezdziectwo, plywanie);
            kaplan.SetSkills(jezykTajemny);
            kaplan.SetSkills(leczenie);
            kaplan.SetSkills(nauka);
            kaplan.SetSkills(nauka);
            kaplan.SetSkills(plotkowanie);
            kaplan.SetSkills(przekonywanie);
            kaplan.SetSkills(splatanieMagii);
            kaplan.SetSkills(spostrzegawczosc);
            kaplan.SetSkills(wiedza);
            kaplan.SetSkills(wiedza);
            kaplan.SetSkills(wykrywanieMagii);
            kaplan.SetSkills(jezyk);
            kaplan.SetSkills(jezyk);
            karczmarz.SetSkills(czytaniePisanie, zwinnePalce);
            karczmarz.SetSkills(gadanina, czytanieZWarg);
            karczmarz.SetSkills(mocnaGlowa);
            karczmarz.SetSkills(plotkowanie);
            karczmarz.SetSkills(przekonywanie);
            karczmarz.SetSkills(rzemioslo);
            karczmarz.SetSkills(spostrzegawczosc);
            karczmarz.SetSkills(targowanie);
            karczmarz.SetSkills(wiedza);
            karczmarz.SetSkills(wycena);
            karczmarz.SetSkills(jezyk);
            ksiaze.SetSkills(dowodzenie);
            ksiaze.SetSkills(plotkowanie);
            ksiaze.SetSkills(przekonywanie);
            ksiaze.SetSkills(sekretneZnaki);
            ksiaze.SetSkills(sekretnyJezyk);
            ksiaze.SetSkills(spostrzegawczosc);
            ksiaze.SetSkills(targowanie);
            ksiaze.SetSkills(torturowanie);
            ksiaze.SetSkills(unik);
            ksiaze.SetSkills(wiedza);
            ksiaze.SetSkills(wycena);
            ksiaze.SetSkills(zastraszanie);
            kupiec.SetSkills(czytaniePisanie);
            kupiec.SetSkills(jezdziectwo);
            kupiec.SetSkills(plotkowanie);
            kupiec.SetSkills(powozenie);
            kupiec.SetSkills(przekonywanie);
            kupiec.SetSkills(rzemioslo);
            kupiec.SetSkills(sekretnyJezyk);
            kupiec.SetSkills(targowanie);
            kupiec.SetSkills(wiedza);
            kupiec.SetSkills(wiedza);
            kupiec.SetSkills(wycena);
            kupiec.SetSkills(jezyk);
            kupiec.SetSkills(jezyk);
            lesnyDuch.SetSkills(czytanieZWarg);
            lesnyDuch.SetSkills(nawigacja);
            lesnyDuch.SetSkills(sekretneZnaki);
            lesnyDuch.SetSkills(sekretnyJezyk);
            lesnyDuch.SetSkills(skradanie);
            lesnyDuch.SetSkills(spostrzegawczosc);
            lesnyDuch.SetSkills(sztukaPrzetrwania);
            lesnyDuch.SetSkills(sledzenie);
            lesnyDuch.SetSkills(tropienie);
            lesnyDuch.SetSkills(ukrywanieSie);
            lesnyDuch.SetSkills(unik);
            lesnyDuch.SetSkills(zastawianiePulapek);
            lesnyDuch.SetSkills(zastraszanie);
            lowcaCzarownic.SetSkills(dowodzenie);
            lowcaCzarownic.SetSkills(jezdziectwo);
            lowcaCzarownic.SetSkills(nauka);
            lowcaCzarownic.SetSkills(nauka);
            lowcaCzarownic.SetSkills(nauka);
            lowcaCzarownic.SetSkills(plotkowanie);
            lowcaCzarownic.SetSkills(przekonywanie);
            lowcaCzarownic.SetSkills(przeszukiwanie);
            lowcaCzarownic.SetSkills(skradanie);
            lowcaCzarownic.SetSkills(spostrzegawczosc);
            lowcaCzarownic.SetSkills(wiedza);
            lowcaCzarownic.SetSkills(zastraszanie);
            lowcaCzarownic.SetSkills(jezyk);
            lowcaWampirow.SetSkills(nauka);
            lowcaWampirow.SetSkills(przeszukiwanie);
            lowcaWampirow.SetSkills(skradanie);
            lowcaWampirow.SetSkills(spostrzegawczosc);
            lowcaWampirow.SetSkills(sledzenie);
            lowcaWampirow.SetSkills(tropienie);
            lowcaWampirow.SetSkills(ukrywanieSie);
            lowcaWampirow.SetSkills(unik);
            lowcaWampirow.SetSkills(wiedza);
            lowcaWampirow.SetSkills(wspinaczka);
            lowcaWampirow.SetSkills(jezyk);
            majordomus.SetSkills(czytaniePisanie);
            majordomus.SetSkills(dowodzenie);
            majordomus.SetSkills(jezdziectwo);
            majordomus.SetSkills(nauka);
            majordomus.SetSkills(plotkowanie);
            majordomus.SetSkills(przekonywanie);
            majordomus.SetSkills(przeszukiwanie);
            majordomus.SetSkills(rzemioslo);
            majordomus.SetSkills(spostrzegawczosc);
            majordomus.SetSkills(targowanie);
            majordomus.SetSkills(wiedza);
            majordomus.SetSkills(wycena);
            majordomus.SetSkills(zastraszanie);
            majordomus.SetSkills(jezyk);
            medyk.SetSkills(czytaniePisanie);
            medyk.SetSkills(leczenie);
            medyk.SetSkills(nauka);
            medyk.SetSkills(plotkowanie);
            medyk.SetSkills(rzemioslo);
            medyk.SetSkills(spostrzegawczosc);
            medyk.SetSkills(warzenieTrucizn);
            medyk.SetSkills(jezyk);
            mistrzCieni.SetSkills(charakteryzacja);
            mistrzCieni.SetSkills(czytaniePisanie);
            mistrzCieni.SetSkills(hazard, czytanieZWarg);
            mistrzCieni.SetSkills(otwieranieZamkow);
            mistrzCieni.SetSkills(plotkowanie);
            mistrzCieni.SetSkills(plywanie);
            mistrzCieni.SetSkills(przekonywanie);
            mistrzCieni.SetSkills(przeszukiwanie);
            mistrzCieni.SetSkills(sekretneZnaki);
            mistrzCieni.SetSkills(sekretnyJezyk);
            mistrzCieni.SetSkills(skradanie);
            mistrzCieni.SetSkills(spostrzegawczosc);
            mistrzCieni.SetSkills(ukrywanieSie);
            mistrzCieni.SetSkills(unik);
            mistrzCieni.SetSkills(wspinaczka);
            mistrzCieni.SetSkills(wycena);
            mistrzCieni.SetSkills(zwinnePalce);
            mistrzGildii.SetSkills(dowodzenie);
            mistrzGildii.SetSkills(nauka);
            mistrzGildii.SetSkills(plotkowanie);
            mistrzGildii.SetSkills(przekonywanie);
            mistrzGildii.SetSkills(rzemioslo);
            mistrzGildii.SetSkills(rzemioslo);
            mistrzGildii.SetSkills(sekretnyJezyk);
            mistrzGildii.SetSkills(spostrzegawczosc);
            mistrzGildii.SetSkills(targowanie);
            mistrzGildii.SetSkills(wiedza);
            mistrzGildii.SetSkills(wycena);
            mistrzGildii.SetSkills(jezyk);
            mistrzGildii.SetSkills(jezyk);
            mistrzMagii.SetSkills(czytaniePisanie);
            mistrzMagii.SetSkills(jezykTajemny);
            mistrzMagii.SetSkills(jezykTajemny);
            mistrzMagii.SetSkills(nauka);
            mistrzMagii.SetSkills(nauka);
            mistrzMagii.SetSkills(plotkowanie, jezdziectwo);
            mistrzMagii.SetSkills(przekonywanie, zastraszanie);
            mistrzMagii.SetSkills(splatanieMagii);
            mistrzMagii.SetSkills(wiedza);
            mistrzMagii.SetSkills(wiedza);
            mistrzMagii.SetSkills(wykrywanieMagii);
            mistrzMagii.SetSkills(jezyk);
            mistrzMagii.SetSkills(jezyk);
            mistrzMagii.SetSkills(jezyk);
            mistrzRzemiosla.SetSkills(plotkowanie);
            mistrzRzemiosla.SetSkills(powozenie);
            mistrzRzemiosla.SetSkills(rzemioslo);
            mistrzRzemiosla.SetSkills(rzemioslo);
            mistrzRzemiosla.SetSkills(rzemioslo);
            mistrzRzemiosla.SetSkills(sekretnyJezyk);
            mistrzRzemiosla.SetSkills(spostrzegawczosc);
            mistrzRzemiosla.SetSkills(targowanie);
            mistrzRzemiosla.SetSkills(wycena);
            mistrzRzemiosla.SetSkills(jezyk);
            mistrzZakonny.SetSkills(czytaniePisanie);
            mistrzZakonny.SetSkills(dowodzenie);
            mistrzZakonny.SetSkills(jezdziectwo);
            mistrzZakonny.SetSkills(nauka);
            mistrzZakonny.SetSkills(nauka);
            mistrzZakonny.SetSkills(przekonywanie);
            mistrzZakonny.SetSkills(sekretneZnaki);
            mistrzZakonny.SetSkills(sekretnyJezyk);
            mistrzZakonny.SetSkills(spostrzegawczosc);
            mistrzZakonny.SetSkills(tresura);
            mistrzZakonny.SetSkills(unik);
            mistrzZakonny.SetSkills(wiedza);
            mistrzZakonny.SetSkills(wiedza);
            mistrzZakonny.SetSkills(wiedza);
            mistrzZakonny.SetSkills(jezyk);
            nawigator.SetSkills(czytaniePisanie);
            nawigator.SetSkills(nauka);
            nawigator.SetSkills(nawigacja);
            nawigator.SetSkills(plywanie);
            nawigator.SetSkills(rzemioslo);
            nawigator.SetSkills(spostrzegawczosc);
            nawigator.SetSkills(wiedza);
            nawigator.SetSkills(wiedza);
            nawigator.SetSkills(jezyk);
            odkrywca.SetSkills(czytaniePisanie);
            odkrywca.SetSkills(dowodzenie);
            odkrywca.SetSkills(jezdziectwo);
            odkrywca.SetSkills(nauka);
            odkrywca.SetSkills(nawigacja);
            odkrywca.SetSkills(plywanie);
            odkrywca.SetSkills(powozenie);
            odkrywca.SetSkills(rzemioslo);
            odkrywca.SetSkills(sekretneZnaki);
            odkrywca.SetSkills(sekretnyJezyk);
            odkrywca.SetSkills(spostrzegawczosc);
            odkrywca.SetSkills(sztukaPrzetrwania);
            odkrywca.SetSkills(tropienie);
            odkrywca.SetSkills(wiedza);
            odkrywca.SetSkills(wiedza);
            odkrywca.SetSkills(wiedza);
            odkrywca.SetSkills(wspinaczka);
            odkrywca.SetSkills(wycena);
            odkrywca.SetSkills(jezyk);
            odkrywca.SetSkills(jezyk);
            odkrywca.SetSkills(jezyk);
            oficer.SetSkills(czytaniePisanie);
            oficer.SetSkills(dowodzenie);
            oficer.SetSkills(jezdziectwo);
            oficer.SetSkills(nauka);
            oficer.SetSkills(opieka);
            oficer.SetSkills(plotkowanie);
            oficer.SetSkills(sekretnyJezyk);
            oficer.SetSkills(unik);
            oficer.SetSkills(wiedza);
            oficer.SetSkills(wiedza);
            oficer.SetSkills(wiedza);
            oficer.SetSkills(jezyk);
            oprawca.SetSkills(leczenie);
            oprawca.SetSkills(przekonywanie);
            oprawca.SetSkills(spostrzegawczosc);
            oprawca.SetSkills(torturowanie);
            oprawca.SetSkills(zastraszanie);
            paser.SetSkills(hazard);
            paser.SetSkills(plotkowanie);
            paser.SetSkills(spostrzegawczosc);
            paser.SetSkills(targowanie);
            paser.SetSkills(wycena);
            paser.SetSkills(zastraszanie);
            paser.SetSkills(zwinnePalce);
            rajtar.SetSkills(jezdziectwo);
            rajtar.SetSkills(opieka);
            rajtar.SetSkills(sekretneZnaki);
            rajtar.SetSkills(spostrzegawczosc);
            rajtar.SetSkills(unik);
            rajtar.SetSkills(wycena, plotkowanie);
            reketer.SetSkills(dowodzenie);
            reketer.SetSkills(plotkowanie);
            reketer.SetSkills(spostrzegawczosc);
            reketer.SetSkills(sledzenie);
            reketer.SetSkills(targowanie);
            reketer.SetSkills(unik);
            reketer.SetSkills(wiedza);
            reketer.SetSkills(wycena);
            reketer.SetSkills(zastraszanie);
            rozbojnik.SetSkills(jezdziectwo);
            rozbojnik.SetSkills(opieka);
            rozbojnik.SetSkills(plotkowanie);
            rozbojnik.SetSkills(przekonywanie);
            rozbojnik.SetSkills(skradanie);
            rozbojnik.SetSkills(tresura);
            rozbojnik.SetSkills(wiedza);
            rozbojnik.SetSkills(wycena);
            rycerz.SetSkills(jezdziectwo);
            rycerz.SetSkills(nauka);
            rycerz.SetSkills(nauka);
            rycerz.SetSkills(sekretnyJezyk);
            rycerz.SetSkills(spostrzegawczosc);
            rycerz.SetSkills(unik);
            rycerz.SetSkills(jezyk);
            rycerz.SetSkills(jezyk);
            sierzant.SetSkills(dowodzenie);
            sierzant.SetSkills(jezdziectwo, plywanie);
            sierzant.SetSkills(nauka);
            sierzant.SetSkills(plotkowanie);
            sierzant.SetSkills(sekretnyJezyk);
            sierzant.SetSkills(spostrzegawczosc);
            sierzant.SetSkills(unik);
            sierzant.SetSkills(wiedza);
            sierzant.SetSkills(wiedza);
            sierzant.SetSkills(zastraszanie);
            sierzant.SetSkills(jezyk);
            skrytobojca.SetSkills(charakteryzacja);
            skrytobojca.SetSkills(plotkowanie);
            skrytobojca.SetSkills(sekretneZnaki);
            skrytobojca.SetSkills(skradanie);
            skrytobojca.SetSkills(spostrzegawczosc);
            skrytobojca.SetSkills(sledzenie);
            skrytobojca.SetSkills(ukrywanieSie);
            skrytobojca.SetSkills(warzenieTrucizn);
            skrytobojca.SetSkills(wspinaczka);
            strzelec.SetSkills(plotkowanie);
            strzelec.SetSkills(przeszukiwanie);
            strzelec.SetSkills(spostrzegawczosc);
            strzelec.SetSkills(sztukaPrzetrwania);
            strzelec.SetSkills(wiedza);
            strzelec.SetSkills(zwinnePalce);
            szampierz.SetSkills(spostrzegawczosc);
            szampierz.SetSkills(unik);
            szarlatan.SetSkills(charakteryzacja);
            szarlatan.SetSkills(gadanina);
            szarlatan.SetSkills(hazard);
            szarlatan.SetSkills(plotkowanie);
            szarlatan.SetSkills(przekonywanie);
            szarlatan.SetSkills(sekretnyJezyk);
            szarlatan.SetSkills(spostrzegawczosc);
            szarlatan.SetSkills(targowanie);
            szarlatan.SetSkills(wiedza);
            szarlatan.SetSkills(wycena);
            szarlatan.SetSkills(jezyk);
            szarlatan.SetSkills(jezyk);
            szarlatan.SetSkills(zwinnePalce);
            szpieg.SetSkills(charakteryzacja);
            szpieg.SetSkills(czytanieZWarg);
            szpieg.SetSkills(kuglarstwo);
            szpieg.SetSkills(otwieranieZamkow);
            szpieg.SetSkills(plotkowanie);
            szpieg.SetSkills(przekonywanie);
            szpieg.SetSkills(sekretnyJezyk);
            szpieg.SetSkills(skradanie);
            szpieg.SetSkills(sledzenie);
            szpieg.SetSkills(ukrywanieSie);
            szpieg.SetSkills(wiedza);
            szpieg.SetSkills(wiedza);
            szpieg.SetSkills(jezyk);
            szpieg.SetSkills(jezyk);
            szpieg.SetSkills(jezyk);
            szpieg.SetSkills(zwinnePalce);
            uczony.SetSkills(czytaniePisanie);
            uczony.SetSkills(nauka);
            uczony.SetSkills(nauka);
            uczony.SetSkills(nauka);
            uczony.SetSkills(spostrzegawczosc);
            uczony.SetSkills(wiedza);
            uczony.SetSkills(wiedza);
            uczony.SetSkills(wiedza);
            uczony.SetSkills(wycena, rzemioslo);
            uczony.SetSkills(jezyk);
            uczony.SetSkills(jezyk);
            uczony.SetSkills(jezyk);
            uczony.SetSkills(jezyk);
            urzednik.SetSkills(czytaniePisanie);
            urzednik.SetSkills(dowodzenie);
            urzednik.SetSkills(gadanina);
            urzednik.SetSkills(kuglarstwo);
            urzednik.SetSkills(nauka);
            urzednik.SetSkills(nauka);
            urzednik.SetSkills(plotkowanie);
            urzednik.SetSkills(przekonywanie);
            urzednik.SetSkills(spostrzegawczosc);
            urzednik.SetSkills(targowanie);
            urzednik.SetSkills(wiedza);
            urzednik.SetSkills(wycena);
            urzednik.SetSkills(jezyk);
            weteran.SetSkills(hazard);
            weteran.SetSkills(mocnaGlowa);
            weteran.SetSkills(plotkowanie);
            weteran.SetSkills(sekretnyJezyk);
            weteran.SetSkills(spostrzegawczosc);
            weteran.SetSkills(unik);
            weteran.SetSkills(wiedza);
            weteran.SetSkills(zastraszanie);
            wedrownyCzarodziej.SetSkills(czytaniePisanie);
            wedrownyCzarodziej.SetSkills(jezdziectwo, plywanie);
            wedrownyCzarodziej.SetSkills(jezykTajemny);
            wedrownyCzarodziej.SetSkills(nauka);
            wedrownyCzarodziej.SetSkills(nauka);
            wedrownyCzarodziej.SetSkills(plotkowanie);
            wedrownyCzarodziej.SetSkills(przekonywanie, zastraszanie);
            wedrownyCzarodziej.SetSkills(splatanieMagii);
            wedrownyCzarodziej.SetSkills(wiedza);
            wedrownyCzarodziej.SetSkills(wiedza);
            wedrownyCzarodziej.SetSkills(wykrywanieMagii);
            wedrownyCzarodziej.SetSkills(jezyk);
            wedrownyCzarodziej.SetSkills(jezyk);
            wlamywacz.SetSkills(otwieranieZamkow);
            wlamywacz.SetSkills(plotkowanie);
            wlamywacz.SetSkills(przeszukiwanie);
            wlamywacz.SetSkills(sekretneZnaki);
            wlamywacz.SetSkills(sekretnyJezyk);
            wlamywacz.SetSkills(skradanie);
            wlamywacz.SetSkills(spostrzegawczosc);
            wlamywacz.SetSkills(targowanie);
            wlamywacz.SetSkills(ukrywanieSie);
            wlamywacz.SetSkills(wspinaczka);
            wlamywacz.SetSkills(wycena);
            wybraniecBozy.SetSkills(jezdziectwo, plywanie);
            wybraniecBozy.SetSkills(jezykTajemny);
            wybraniecBozy.SetSkills(leczenie);
            wybraniecBozy.SetSkills(nauka);
            wybraniecBozy.SetSkills(nauka);
            wybraniecBozy.SetSkills(nauka);
            wybraniecBozy.SetSkills(plotkowanie);
            wybraniecBozy.SetSkills(przekonywanie);
            wybraniecBozy.SetSkills(splatanieMagii);
            wybraniecBozy.SetSkills(wiedza);
            wybraniecBozy.SetSkills(wiedza);
            wybraniecBozy.SetSkills(wykrywanieMagii);
            wybraniecBozy.SetSkills(jezyk);
            wybraniecBozy.SetSkills(jezyk);
            zabojcaDemonow.SetSkills(mocnaGlowa);
            zabojcaDemonow.SetSkills(unik);
            zabojcaDemonow.SetSkills(wiedza);
            zabojcaDemonow.SetSkills(wiedza);
            zabojcaDemonow.SetSkills(wspinaczka);
            zabojcaDemonow.SetSkills(zastraszanie);
            zabojcaOlbrzymow.SetSkills(mocnaGlowa);
            zabojcaOlbrzymow.SetSkills(spostrzegawczosc);
            zabojcaOlbrzymow.SetSkills(unik);
            zabojcaOlbrzymow.SetSkills(wiedza);
            zabojcaOlbrzymow.SetSkills(zastraszanie);
            zakonnik.SetSkills(leczenie);
            zakonnik.SetSkills(nauka);
            zakonnik.SetSkills(opieka);
            zakonnik.SetSkills(spostrzegawczosc);
            zakonnik.SetSkills(sztukaPrzetrwania);
            zakonnik.SetSkills(wiedza);
            zakonnik.SetSkills(wiedza);
            zakonnik.SetSkills(jezyk);
            zakonnik.SetSkills(jezyk);
            zakonnik.SetSkills(jezyk);
            zwadzca.SetSkills(hazard);
            zwadzca.SetSkills(plotkowanie);
            zwadzca.SetSkills(przekonywanie);
            zwadzca.SetSkills(spostrzegawczosc);
            zwadzca.SetSkills(unik);
            zwadzca.SetSkills(zastraszanie);
            zwadzca.SetSkills(zwinnePalce);
            zwiadowca.SetSkills(jezdziectwo);
            zwiadowca.SetSkills(nawigacja);
            zwiadowca.SetSkills(opieka);
            zwiadowca.SetSkills(oswajanie);
            zwiadowca.SetSkills(sekretneZnaki);
            zwiadowca.SetSkills(sekretnyJezyk);
            zwiadowca.SetSkills(skradanie);
            zwiadowca.SetSkills(spostrzegawczosc);
            zwiadowca.SetSkills(tropienie);
            zwiadowca.SetSkills(ukrywanieSie);
            zwiadowca.SetSkills(unik);
            zwiadowca.SetSkills(wiedza);
            zwiadowca.SetSkills(wiedza);
            zwiadowca.SetSkills(jezyk);
            zwiadowca.SetSkills(jezyk);

            #endregion profession skills

            #region profession abilities

            akolita.SetAbilities(bardzoSilny, szybkiRefleks);
            akolita.SetAbilities(charyzmatyczny, urodzonyWojownik);
            akolita.SetAbilities(przemawianie);
            banita.SetAbilities(strzalMierzony, ogluszanie);
            banita.SetAbilities(wedrowiec, lotrzyk);
            berserker.SetAbilities(bronSpecjalna);
            berserker.SetAbilities(grozny);
            berserker.SetAbilities(szalBojowy);
            berserker.SetAbilities(szybkieWyciagniecie);
            chlop.SetAbilities(chodu, bronSpecjalna);
            chlop.SetAbilities(twardziel, wedrowiec);
            ciura.SetAbilities(chodu);
            ciura.SetAbilities(odpornoscNaChoroby, obiezyswiat);
            ciura.SetAbilities(twardziel, charyzmatyczny);
            ciura.SetAbilities(zylkaHandlowa, bijatyka);
            cyrkowiec.SetAbilities(2, bardzoSilny, bronSpecjalna, nasladowca, przemawianie, strzalMierzony, szybkiRefleks, szybkieWyciagniecie, woltyzerka, zapasy);
            cyrulik.SetAbilities(charyzmatyczny, niezwykleOdporny);
            cyrulik.SetAbilities(chirurgia);
            cyrulik.SetAbilities(odpornoscNaChoroby, blyskotliwosc);
            fanatyk.SetAbilities(bronSpecjalna);
            fanatyk.SetAbilities(opanowanie, bardzoSilny);
            fanatyk.SetAbilities(przemawianie);
            fanatyk.SetAbilities(twardziel, charyzmatyczny);
            flisak.SetAbilities(obiezyswiat);
            flisak.SetAbilities(wyczucieKierunku);
            giermek.SetAbilities(bronSpecjalna);
            giermek.SetAbilities(etykieta);
            giermek.SetAbilities(silnyCios);
            gladiator.SetAbilities(bardzoSilny, odpornoscPsychiczna);
            gladiator.SetAbilities(bronSpecjalna);
            gladiator.SetAbilities(bronSpecjalna);
            gladiator.SetAbilities(bronSpecjalna);
            gladiator.SetAbilities(rozbrojenie, zapasy);
            gladiator.SetAbilities(silnyCios);
            gladiator.SetAbilities(szybkieWyciagniecie, morderczyAtak);
            goniec.SetAbilities(bardzoSzybki, szostyZmysl);
            goniec.SetAbilities(bardzoWytrzymaly, bardzoSilny);
            goniec.SetAbilities(blyskawicznePrzeladowanie);
            goniec.SetAbilities(chodu);
            goniec.SetAbilities(wyczucieKierunku);
            gornik.SetAbilities(bardzoWytrzymaly, urodzonyWojownik);
            gornik.SetAbilities(bronSpecjalna);
            gornik.SetAbilities(wyczucieKierunku);
            guslarz.SetAbilities(gusla);
            guslarz.SetAbilities(magiaProsta);
            hiena.SetAbilities(szczescie, szostyZmysl);
            hiena.SetAbilities(wykrywaniePulapek, grotolaz);
            kanciarz.SetAbilities(chodu, lotrzyk);
            kanciarz.SetAbilities(przemawianie);
            kanciarz.SetAbilities(szczescie, szostyZmysl);
            kozak.SetAbilities(bronSpecjalna);
            kozak.SetAbilities(morderczyAtak);
            lesnik.SetAbilities(bardzoSzybki, niezwykleOdporny);
            lesnik.SetAbilities(bronSpecjalna);
            lesnik.SetAbilities(wedrowiec);
            lowca.SetAbilities(blyskawicznePrzeladowanie);
            lowca.SetAbilities(strzelecWyborowy, wedrowiec);
            lowca.SetAbilities(szybkiRefleks, niezwykleOdporny);
            lowca.SetAbilities(twardziel, bronSpecjalna);
            lowcanagrod.SetAbilities(bronSpecjalna);
            lowcanagrod.SetAbilities(strzalMierzony, silnyCios);
            lowcanagrod.SetAbilities(strzelecWyborowy, ogluszanie);
            lowcanagrod.SetAbilities(wedrowiec);
            mieszczanin.SetAbilities(blyskotliwosc, charyzmatyczny);
            mieszczanin.SetAbilities(zylkaHandlowa);
            mytnik.SetAbilities(szybkiRefleks, strzelecWyborowy);
            najemnik.SetAbilities(blyskawicznePrzeladowanie, silnyCios);
            najemnik.SetAbilities(rozbrojenie, szybkieWyciagniecie);
            najemnik.SetAbilities(strzalMierzony, ogluszanie);
            ochotnik.SetAbilities(bronSpecjalna, blyskawicznePrzeladowanie);
            ochotnik.SetAbilities(silnyCios);
            ochroniarz.SetAbilities(bardzoSilny, niezwykleOdporny);
            ochroniarz.SetAbilities(bijatyka);
            ochroniarz.SetAbilities(bronSpecjalna);
            ochroniarz.SetAbilities(bronSpecjalna);
            ochroniarz.SetAbilities(ogluszanie);
            ochroniarz.SetAbilities(rozbrojenie, szybkieWyciagniecie);
            oprych.SetAbilities(morderczyAtak, zapasy);
            oprych.SetAbilities(odpornoscNaTrucizny, szybkieWyciagniecie);
            oprych.SetAbilities(ogluszanie);
            oprych.SetAbilities(opanowanie, szybkiRefleks);
            oprych.SetAbilities(rozbrojenie);
            paz.SetAbilities(etykieta);
            paz.SetAbilities(opanowanie, charyzmatyczny);
            paz.SetAbilities(zylkaHandlowa, obiezyswiat);
            podzegacz.SetAbilities(chodu);
            podzegacz.SetAbilities(opanowanie, bijatyka);
            podzegacz.SetAbilities(przemawianie);
            porywacz.SetAbilities(chodu);
            porywacz.SetAbilities(lotrzyk, odpornoscPsychiczna);
            porywacz.SetAbilities(odpornoscNaChoroby);
            poslaniec.SetAbilities(obiezyswiat);
            poslaniec.SetAbilities(wyczucieKierunku);
            przemytnik.SetAbilities(zylkaHandlowa, lotrzyk);
            przepatrywacz.SetAbilities(bronSpecjalna);
            przepatrywacz.SetAbilities(opanowanie, bardzoSilny);
            przepatrywacz.SetAbilities(wyczucieKierunku);
            przewoznik.SetAbilities(bronSpecjalna, bijatyka);
            przewoznik.SetAbilities(strzelecWyborowy, charyzmatyczny);
            rybak.SetAbilities(twardziel, blyskotliwosc);
            rybak.SetAbilities(wyczucieKierunku, bijatyka);
            rzecznik.SetAbilities(obiezyswiat, zylkaHandlowa);
            rzemieslnik.SetAbilities(zylkaHandlowa, blyskotliwosc);
            rzezimieszek.SetAbilities(bijatyka);
            rzezimieszek.SetAbilities(grozny, charyzmatyczny);
            rzezimieszek.SetAbilities(morderczyAtak);
            rzezimieszek.SetAbilities(ogluszanie);
            rzezimieszek.SetAbilities(rozbrojenie, szybkieWyciagniecie);
            rzezimieszek.SetAbilities(silnyCios);
            skryba.SetAbilities(poliglota);
            sluga.SetAbilities(bardzoWytrzymaly, szybkiRefleks);
            sluga.SetAbilities(czulySluch, chodu);
            sluga.SetAbilities(etykieta, twardziel);
            straznik.SetAbilities(ogluszanie);
            straznik.SetAbilities(opanowanie, blyskotliwosc);
            straznik.SetAbilities(rozbrojenie, bijatyka);
            straznik.SetAbilities(silnyCios);
            straznikDrog.SetAbilities(bronSpecjalna);
            straznikDrog.SetAbilities(szybkieWyciagniecie, blyskawicznePrzeladowanie);
            straznikPol.SetAbilities(bardzoSzybki, blyskotliwosc);
            straznikPol.SetAbilities(strzalPrecyzyjny, blyskawicznePrzeladowanie);
            straznikPol.SetAbilities(wedrowiec, szybkieWyciagniecie);
            straznikWiezienny.SetAbilities(bronSpecjalna);
            straznikWiezienny.SetAbilities(odpornoscNaChoroby);
            straznikWiezienny.SetAbilities(odpornoscNaTrucizny);
            straznikWiezienny.SetAbilities(zapasy);
            szczurolap.SetAbilities(bronSpecjalna);
            szczurolap.SetAbilities(grotolaz);
            szczurolap.SetAbilities(odpornoscNaChoroby);
            szczurolap.SetAbilities(odpornoscNaTrucizny);
            szermierz.SetAbilities(brawura, szybkiRefleks);
            szermierz.SetAbilities(bronSpecjalna);
            szermierz.SetAbilities(silnyCios);
            szermierz.SetAbilities(szybkieWyciagniecie, morderczyAtak);
            szlachcic.SetAbilities(blyskotliwosc, bronSpecjalna);
            szlachcic.SetAbilities(bronSpecjalna, intrygant);
            szlachcic.SetAbilities(etykieta);
            szlachcic.SetAbilities(szczescie, przemawianie);
            smieciarz.SetAbilities(opanowanie, lotrzyk);
            smieciarz.SetAbilities(twardziel, odpornoscNaChoroby);
            tarczownik.SetAbilities(czulySluch, opanowanie);
            tarczownik.SetAbilities(morderczyAtak);
            tarczownik.SetAbilities(ogluszanie);
            tarczownik.SetAbilities(silnyCios);
            tarczownik.SetAbilities(wyczucieKierunku);
            uczen.SetAbilities(blyskotliwosc, niezwykleOdporny);
            uczen.SetAbilities(magiaProsta);
            uczen.SetAbilities(zmyslMagii, dotykMocy);
            weglarz.SetAbilities(blyskotliwosc, bardzoSilny);
            weglarz.SetAbilities(chodu);
            wloczykij.SetAbilities(bardzoSilny, wedrowiec);
            wloczykij.SetAbilities(obiezyswiat);
            wloczykij.SetAbilities(strzelecWyborowy, wyczucieKierunku);
            wojownik.SetAbilities(blyskawicznePrzeladowanie, urodzonyWojownik);
            wojownik.SetAbilities(strzelecWyborowy, wedrowiec);
            woznica.SetAbilities(bronSpecjalna);
            woznica.SetAbilities(szybkieWyciagniecie, obiezyswiat);
            zabojcaTroli.SetAbilities(bijatyka);
            zabojcaTroli.SetAbilities(bronSpecjalna);
            zabojcaTroli.SetAbilities(rozbrojenie, szybkieWyciagniecie);
            zabojcaTroli.SetAbilities(silnyCios);
            zabojcaTroli.SetAbilities(szybkiRefleks, niezwykleOdporny);
            zabojcaTroli.SetAbilities(twardziel);
            zarzadca.SetAbilities(etykieta, geniuszArytmetyczny);
            zarzadca.SetAbilities(przemawianie);
            zlodziej.SetAbilities(geniuszArytmetyczny, wykrywaniePulapek);
            zlodziej.SetAbilities(ulicznik, lotrzyk);
            zak.SetAbilities(blyskotliwosc, charyzmatyczny);
            zak.SetAbilities(etykieta, poliglota);
            zak.SetAbilities(obiezyswiat, geniuszArytmetyczny);
            zeglarz.SetAbilities(obiezyswiat);
            zeglarz.SetAbilities(silnyCios, brawura);
            zeglarz.SetAbilities(twardziel, bijatyka);
            zolnierz.SetAbilities(bronSpecjalna);
            zolnierz.SetAbilities(morderczyAtak, blyskawicznePrzeladowanie);
            zolnierz.SetAbilities(ogluszanie, strzalPrecyzyjny);
            zolnierz.SetAbilities(rozbrojenie, szybkieWyciagniecie);
            zolnierz.SetAbilities(strzalMierzony, silnyCios);
            zolnierzOkretowy.SetAbilities(ogluszanie);
            zolnierzOkretowy.SetAbilities(rozbrojenie, szybkieWyciagniecie);
            zolnierzOkretowy.SetAbilities(silnyCios);
            arcykaplan.SetAbilities(dotykMocy, odpornosc);
            arcykaplan.SetAbilities(etykieta);
            arcykaplan.SetAbilities(magiaPowszechna);
            arcykaplan.SetAbilities(magiaPowszechna);
            arcykaplan.SetAbilities(pancerzWiary, morderczyPocisk);
            arcykaplan.SetAbilities(zmyslMagii, medytacja);
            arcymag.SetAbilities(czarnoksiestwo, medytacja);
            arcymag.SetAbilities(dotykMocy, twardziel);
            arcymag.SetAbilities(magiaPowszechna);
            arcymag.SetAbilities(magiaPowszechna);
            arcymag.SetAbilities(zmyslMagii, morderczyPocisk);
            arystokrata.SetAbilities(bronSpecjalna);
            arystokrata.SetAbilities(krasomostwo);
            arystokrata.SetAbilities(przemawianie);
            bard.SetAbilities(etykieta);
            bard.SetAbilities(przemawianie);
            biczownik.SetAbilities(bronSpecjalna);
            biczownik.SetAbilities(nieustraszony);
            biczownik.SetAbilities(silnyCios);
            bosman.SetAbilities(bijatyka);
            bosman.SetAbilities(obiezyswiat);
            bosman.SetAbilities(odpornoscNaChoroby);
            demagog.SetAbilities(bijatyka);
            demagog.SetAbilities(etykieta, lotrzyk);
            demagog.SetAbilities(krasomostwo);
            demagog.SetAbilities(przemawianie);
            dworzanin.SetAbilities(blyskotliwosc, charyzmatyczny);
            dworzanin.SetAbilities(intrygant, bronSpecjalna);
            dworzanin.SetAbilities(przemawianie);
            dworzanin.SetAbilities(zylkaHandlowa, etykieta);
            fechmistrz.SetAbilities(artylerzysta);
            fechmistrz.SetAbilities(bardzoSzybki, szybkiRefleks);
            fechmistrz.SetAbilities(blyskawicznePrzeladowanie);
            fechmistrz.SetAbilities(blyskawicznyBlok);
            fechmistrz.SetAbilities(bronSpecjalna);
            fechmistrz.SetAbilities(bronSpecjalna);
            fechmistrz.SetAbilities(bronSpecjalna);
            fechmistrz.SetAbilities(strzalPrecyzyjny);
            fechmistrz.SetAbilities(szybkieWyciagniecie);
            fechmistrz.SetAbilities(zapasy);
            herold.SetAbilities(etykieta);
            herold.SetAbilities(krasomostwo);
            herold.SetAbilities(przemawianie);
            herszt.SetAbilities(blyskawicznePrzeladowanie);
            herszt.SetAbilities(blyskawicznyBlok);
            herszt.SetAbilities(strzalPrecyzyjny);
            herszt.SetAbilities(strzalPrzebijajacy);
            herszt.SetAbilities(szybkieWyciagniecie);
            inzynier.SetAbilities(artylerzysta);
            inzynier.SetAbilities(bronSpecjalna);
            kapitan.SetAbilities(blyskawicznyBlok, brawura);
            kapitan.SetAbilities(bronSpecjalna);
            kapitan.SetAbilities(obiezyswiat);
            kapitan.SetAbilities(rozbrojenie);
            kapitan.SetAbilities(silnyCios);
            kaplan.SetAbilities(magiaProsta);
            kaplan.SetAbilities(morderczyAtak, ogluszanie);
            kaplan.SetAbilities(pancerzWiary, krasomostwo);
            karczmarz.SetAbilities(etykieta, lotrzyk);
            karczmarz.SetAbilities(ogluszanie);
            karczmarz.SetAbilities(zylkaHandlowa, bijatyka);
            ksiaze.SetAbilities(bronSpecjalna);
            ksiaze.SetAbilities(grozny);
            ksiaze.SetAbilities(lotrzyk);
            ksiaze.SetAbilities(odpornoscNaTrucizny);
            ksiaze.SetAbilities(przemawianie);
            ksiaze.SetAbilities(szostyZmysl);
            ksiaze.SetAbilities(zylkaHandlowa, intrygant);
            kupiec.SetAbilities(geniuszArytmetyczny);
            kupiec.SetAbilities(zylkaHandlowa, lotrzyk);
            lesnyDuch.SetAbilities(blyskawicznePrzeladowanie);
            lesnyDuch.SetAbilities(blyskawicznyBlok);
            lesnyDuch.SetAbilities(blyskawicznyBlok);
            lesnyDuch.SetAbilities(strzalPrecyzyjny);
            lesnyDuch.SetAbilities(strzalPrzebijajacy);
            lesnyDuch.SetAbilities(szybkieWyciagniecie);
            lesnyDuch.SetAbilities(twardziel, bardzoSzybki);
            lowcaCzarownic.SetAbilities(blyskawicznyBlok);
            lowcaCzarownic.SetAbilities(bronSpecjalna);
            lowcaCzarownic.SetAbilities(bronSpecjalna);
            lowcaCzarownic.SetAbilities(bronSpecjalna);
            lowcaCzarownic.SetAbilities(grozny);
            lowcaCzarownic.SetAbilities(odwaga);
            lowcaCzarownic.SetAbilities(przemawianie);
            lowcaCzarownic.SetAbilities(silnyCios);
            lowcaCzarownic.SetAbilities(szostyZmysl);
            lowcaCzarownic.SetAbilities(szybkiRefleks, strzelecWyborowy);
            lowcaWampirow.SetAbilities(bronSpecjalna);
            lowcaWampirow.SetAbilities(grotolaz);
            lowcaWampirow.SetAbilities(morderczyAtak);
            lowcaWampirow.SetAbilities(odwaga);
            lowcaWampirow.SetAbilities(silnyCios);
            lowcaWampirow.SetAbilities(strzalPrecyzyjny, blyskawicznePrzeladowanie);
            majordomus.SetAbilities(geniuszArytmetyczny);
            majordomus.SetAbilities(przemawianie);
            medyk.SetAbilities(chirurgia);
            medyk.SetAbilities(odpornoscNaChoroby);
            medyk.SetAbilities(ogluszanie);
            mistrzCieni.SetAbilities(bijatyka, brawura);
            mistrzCieni.SetAbilities(bronSpecjalna);
            mistrzCieni.SetAbilities(bronSpecjalna);
            mistrzCieni.SetAbilities(lotrzyk);
            mistrzCieni.SetAbilities(wykrywaniePulapek);
            mistrzGildii.SetAbilities(etykieta);
            mistrzGildii.SetAbilities(poliglota);
            mistrzGildii.SetAbilities(zylkaHandlowa);
            mistrzMagii.SetAbilities(czarnoksiestwo, odpornoscPsychiczna);
            mistrzMagii.SetAbilities(dotykMocy, morderczyPocisk);
            mistrzMagii.SetAbilities(magiaPowszechna);
            mistrzMagii.SetAbilities(magiaPowszechna);
            mistrzMagii.SetAbilities(zmyslMagii, medytacja);
            mistrzRzemiosla.SetAbilities(talentArtystyczny, etykieta);
            mistrzZakonny.SetAbilities(blyskawicznyBlok);
            mistrzZakonny.SetAbilities(bronSpecjalna);
            mistrzZakonny.SetAbilities(bronSpecjalna);
            mistrzZakonny.SetAbilities(etykieta);
            mistrzZakonny.SetAbilities(morderczyAtak);
            mistrzZakonny.SetAbilities(obiezyswiat);
            mistrzZakonny.SetAbilities(odwaga);
            mistrzZakonny.SetAbilities(ogluszanie);
            nawigator.SetAbilities(wyczucieKierunku);
            odkrywca.SetAbilities(obiezyswiat);
            odkrywca.SetAbilities(wyczucieKierunku, poliglota);
            oficer.SetAbilities(blyskawicznyBlok);
            oficer.SetAbilities(bronSpecjalna);
            oficer.SetAbilities(bronSpecjalna);
            oficer.SetAbilities(rozbrojenie, szybkieWyciagniecie);
            oprawca.SetAbilities(bronSpecjalna);
            oprawca.SetAbilities(grozny);
            oprawca.SetAbilities(zapasy);
            paser.SetAbilities(geniuszArytmetyczny);
            paser.SetAbilities(ogluszanie);
            paser.SetAbilities(zylkaHandlowa, lotrzyk);
            rajtar.SetAbilities(artylerzysta);
            rajtar.SetAbilities(blyskawicznePrzeladowanie);
            rajtar.SetAbilities(bronSpecjalna);
            rajtar.SetAbilities(silnyCios);
            rajtar.SetAbilities(strzalMierzony);
            rajtar.SetAbilities(strzalPrzebijajacy);
            rajtar.SetAbilities(szybkieWyciagniecie);
            reketer.SetAbilities(bijatyka);
            reketer.SetAbilities(grozny);
            reketer.SetAbilities(lotrzyk);
            reketer.SetAbilities(ogluszanie);
            reketer.SetAbilities(silnyCios);
            rozbojnik.SetAbilities(artylerzysta);
            rozbojnik.SetAbilities(brawura);
            rozbojnik.SetAbilities(bronSpecjalna);
            rozbojnik.SetAbilities(bronSpecjalna);
            rozbojnik.SetAbilities(etykieta);
            rozbojnik.SetAbilities(oburecznosc);
            rozbojnik.SetAbilities(strzalMierzony);
            rozbojnik.SetAbilities(strzalPrecyzyjny);
            rozbojnik.SetAbilities(woltyzerka);
            rycerz.SetAbilities(bronSpecjalna);
            rycerz.SetAbilities(bronSpecjalna);
            rycerz.SetAbilities(bronSpecjalna);
            rycerz.SetAbilities(silnyCios);
            sierzant.SetAbilities(bijatyka, zapasy);
            sierzant.SetAbilities(grozny, obiezyswiat);
            sierzant.SetAbilities(ogluszanie);
            sierzant.SetAbilities(silnyCios);
            skrytobojca.SetAbilities(bijatyka);
            skrytobojca.SetAbilities(blyskawicznyBlok);
            skrytobojca.SetAbilities(brawura);
            skrytobojca.SetAbilities(bronSpecjalna);
            skrytobojca.SetAbilities(bronSpecjalna);
            skrytobojca.SetAbilities(bronSpecjalna);
            skrytobojca.SetAbilities(lotrzyk);
            skrytobojca.SetAbilities(strzalMierzony);
            skrytobojca.SetAbilities(szybkieWyciagniecie);
            strzelec.SetAbilities(blyskawicznePrzeladowanie);
            strzelec.SetAbilities(bronSpecjalna);
            strzelec.SetAbilities(bronSpecjalna);
            strzelec.SetAbilities(strzalMierzony);
            strzelec.SetAbilities(strzalPrecyzyjny);
            strzelec.SetAbilities(strzalPrzebijajacy);
            szampierz.SetAbilities(blyskawicznyBlok);
            szampierz.SetAbilities(bronSpecjalna);
            szampierz.SetAbilities(bronSpecjalna);
            szampierz.SetAbilities(bronSpecjalna);
            szampierz.SetAbilities(bronSpecjalna);
            szarlatan.SetAbilities(chodu);
            szarlatan.SetAbilities(intrygant, lotrzyk);
            szarlatan.SetAbilities(nasladowca);
            szarlatan.SetAbilities(obiezyswiat);
            szarlatan.SetAbilities(przemawianie);
            szpieg.SetAbilities(charyzmatyczny, szostyZmysl);
            szpieg.SetAbilities(chodu);
            szpieg.SetAbilities(intrygant);
            szpieg.SetAbilities(poliglota);
            uczony.SetAbilities(poliglota);
            urzednik.SetAbilities(etykieta, lotrzyk);
            urzednik.SetAbilities(krasomostwo);
            urzednik.SetAbilities(przemawianie);
            urzednik.SetAbilities(zylkaHandlowa, intrygant);
            weteran.SetAbilities(blyskawicznePrzeladowanie, morderczyAtak);
            weteran.SetAbilities(bronSpecjalna);
            weteran.SetAbilities(bronSpecjalna);
            weteran.SetAbilities(niezwykleOdporny, bardzoSilny);
            weteran.SetAbilities(strzalPrecyzyjny, silnyCios);
            wedrownyCzarodziej.SetAbilities(dotykMocy, niezwykleOdporny);
            wedrownyCzarodziej.SetAbilities(magiaTajemna, magiaCzarnoksieska);
            wedrownyCzarodziej.SetAbilities(magiaPowszechna);
            wedrownyCzarodziej.SetAbilities(magiaPowszechna);
            wedrownyCzarodziej.SetAbilities(medytacja, morderczyPocisk);
            wedrownyCzarodziej.SetAbilities(zmyslMagii, czarnoksiestwo);
            wlamywacz.SetAbilities(bijatyka);
            wlamywacz.SetAbilities(lotrzyk);
            wlamywacz.SetAbilities(ulicznik);
            wlamywacz.SetAbilities(wykrywaniePulapek);
            wybraniecBozy.SetAbilities(magiaKaplanska);
            wybraniecBozy.SetAbilities(magiaPowszechna);
            wybraniecBozy.SetAbilities(magiaPowszechna);
            wybraniecBozy.SetAbilities(obiezyswiat, silnyCios);
            wybraniecBozy.SetAbilities(pancerzWiary, dotykMocy);
            wybraniecBozy.SetAbilities(zmyslMagii, medytacja);
            zabojcaDemonow.SetAbilities(blyskawicznyBlok);
            zabojcaDemonow.SetAbilities(niepokojacy);
            zabojcaOlbrzymow.SetAbilities(bronSpecjalna);
            zabojcaOlbrzymow.SetAbilities(morderczyAtak);
            zabojcaOlbrzymow.SetAbilities(nieustraszony);
            zabojcaOlbrzymow.SetAbilities(odpornoscNaTrucizny);
            zakonnik.SetAbilities(obiezyswiat);
            zwadzca.SetAbilities(artylerzysta);
            zwadzca.SetAbilities(brawura);
            zwadzca.SetAbilities(bronSpecjalna);
            zwadzca.SetAbilities(bronSpecjalna);
            zwadzca.SetAbilities(bronSpecjalna);
            zwadzca.SetAbilities(etykieta);
            zwadzca.SetAbilities(morderczyAtak);
            zwadzca.SetAbilities(oburecznosc, rozbrojenie);
            zwadzca.SetAbilities(silnyCios);
            zwadzca.SetAbilities(strzalMierzony);
            zwadzca.SetAbilities(strzalPrecyzyjny);
            zwadzca.SetAbilities(szybkieWyciagniecie);
            zwiadowca.SetAbilities(blyskawicznePrzeladowanie);
            zwiadowca.SetAbilities(bronSpecjalna);
            zwiadowca.SetAbilities(strzalPrecyzyjny, strzalPrzebijajacy);
            zwiadowca.SetAbilities(wyczucieKierunku);

            #endregion profession abilities

            var statisticsDataSet = new List<Statistic>
            {
                new Statistic{ Type = StatisticType.CloseCombat, IsBasicValue = true, IsReadOnly = false, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Shooting, IsBasicValue = true, IsReadOnly = false, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Stamina, IsBasicValue = true, IsReadOnly = false, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Resistance, IsBasicValue = true, IsReadOnly = false, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Agility, IsBasicValue = true, IsReadOnly = false, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Inteligence, IsBasicValue = true, IsReadOnly = false, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Willpower, IsBasicValue = true, IsReadOnly = false, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Polish, IsBasicValue = true, IsReadOnly = false, IsCalculatedValue = false },

                new Statistic{ Type = StatisticType.Attacks, IsBasicValue = false, IsReadOnly = false, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Hitpoints, IsBasicValue = false, IsReadOnly = false, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Strength, IsBasicValue = false, IsReadOnly = true, IsCalculatedValue = true },
                new Statistic{ Type = StatisticType.Hardness, IsBasicValue = false, IsReadOnly = true, IsCalculatedValue = true },
                new Statistic{ Type = StatisticType.Speed, IsBasicValue = false, IsReadOnly = true, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Magic, IsBasicValue = false, IsReadOnly = true, IsCalculatedValue = false },
                new Statistic{ Type = StatisticType.Insanity, IsBasicValue = false, IsReadOnly = false, IsCalculatedValue = true },
                new Statistic{ Type = StatisticType.Destiny, IsBasicValue = false, IsReadOnly = false, IsCalculatedValue = true },
            };

            var professionBuildersResult = new List<ProfessionBuilder>
            {
                akolita,
                banita,
                berserker,
                chlop,
                ciura,
                cyrkowiec,
                cyrulik,
                fanatyk,
                flisak,
                giermek,
                gladiator,
                goniec,
                gornik,
                guslarz,
                hiena,
                kanciarz,
                kozak,
                lesnik,
                lowca,
                lowcanagrod,
                mieszczanin,
                mytnik,
                najemnik,
                ochotnik,
                ochroniarz,
                oprych,
                paz,
                podzegacz,
                porywacz,
                poslaniec,
                przemytnik,
                przepatrywacz,
                przewoznik,
                rybak,
                rzecznik,
                rzemieslnik,
                rzezimieszek,
                skryba,
                sluga,
                straznik,
                straznikDrog,
                straznikPol,
                straznikWiezienny,
                szczurolap,
                szermierz,
                szlachcic,
                smieciarz,
                tarczownik,
                uczen,
                weglarz,
                wloczykij,
                wojownik,
                woznica,
                zabojcaTroli,
                zarzadca,
                zlodziej,
                zak,
                zeglarz,
                zolnierz,
                zolnierzOkretowy,
                arcykaplan,
                arcymag,
                arystokrata,
                bard,
                biczownik,
                bosman,
                demagog,
                dworzanin,
                fechmistrz,
                herold,
                herszt,
                inzynier,
                kapitan,
                kaplan,
                karczmarz,
                ksiaze,
                kupiec,
                lesnyDuch,
                lowcaCzarownic,
                lowcaWampirow,
                majordomus,
                medyk,
                mistrzCieni,
                mistrzGildii,
                mistrzMagii,
                mistrzRzemiosla,
                mistrzZakonny,
                nawigator,
                odkrywca,
                oficer,
                oprawca,
                paser,
                rajtar,
                reketer,
                rozbojnik,
                rycerz,
                sierzant,
                skrytobojca,
                strzelec,
                szampierz,
                szarlatan,
                szpieg,
                uczony,
                urzednik,
                weteran,
                wedrownyCzarodziej,
                wlamywacz,
                wybraniecBozy,
                zabojcaDemonow,
                zabojcaOlbrzymow,
                zakonnik,
                zwadzca,
                zwiadowca
            };
            var skillResult = new List<Skill>
            {
                charakteryzacja,
                dowodzenie,
                hazard,
                jezdziectwo,
                mocnaGlowa,
                opieka,
                plotkowanie,
                plywanie,
                powozenie,
                przekonywanie,
                przeszukiwanie,
                skradanie,
                spostrzegawczosc,
                sztukaPrzetrwania,
                targowanie,
                ukrywanieSie,
                wioslarstwo,
                wspinaczka,
                wycena,
                zastraszanie,
                brzuchomostwo,
                czytaniePisanie,
                czytanieZWarg,
                gadanina,
                hipnoza,
                jezykTajemny,
                kuglarstwo,
                leczenie,
                nauka,
                nawigacja,
                oswajanie,
                otwieranieZamkow,
                rzemioslo,
                sekretneZnaki,
                sekretnyJezyk,
                splatanieMagii,
                sledzenie,
                torturowanie,
                tresura,
                tropienie,
                unik,
                warzenieTrucizn,
                wiedza,
                wykrywanieMagii,
                zastawianiePulapek,
                jezyk,
                zwinnePalce,
                zelgarstwo
            };
            var abilityResult = new List<Ability>
            {
                artylerzysta,
                bardzoSilny,
                bardzoSzybki,
                bardzoWytrzymaly,
                bijatyka,
                blyskawicznePrzeladowanie,
                blyskawicznyBlok,
                blyskotliwosc,
                brawura,
                bronNaturalna,
                bronSpecjalna,
                bystryWzrok,
                charyzmatyczny,
                chirurgia,
                chodu,
                czarnoksiestwo,
                czlowiekGuma,
                czulySluch,
                dotykMocy,
                etykieta,
                geniuszArytmetyczny,
                grotolaz,
                grozny,
                gusla,
                intrygant,
                krasnoludzkiFach,
                krasomostwo,
                krzepki,
                latanie,
                lewitacja,
                lotrzyk,
                magiaCzarnoksieska,
                magiaKaplanska,
                magiaPowszechna,
                magiaProsta,
                magiaTajemna,
                medytacja,
                morderczyAtak,
                morderczyPocisk,
                nasladowca,
                niepokojacy,
                nieustraszony,
                niezwykleOdporny,
                obiezyswiat,
                oburecznosc,
                odpornosc,
                odpornoscNaChaos,
                odpornoscNaChoroby,
                odpornoscNaMagie,
                odpornoscNaTrucizny,
                odpornoscPsychiczna,
                odwaga,
                ogluszanie,
                opanowanie,
                ozywieniec,
                pancerzWiary,
                poliglota,
                przemawianie,
                przerazajacy,
                rozbrojenie,
                silnyCios,
                straszny,
                strzalMierzony,
                strzalPrecyzyjny,
                strzalPrzebijajacy,
                strzelecWyborowy,
                szalBojowy,
                szczescie,
                szostyZmysl,
                szybkiRefleks,
                szybkieWyciagniecie,
                talentArtystyczny,
                twardziel,
                ulicznik,
                urodzonyWojownik,
                wedrowiec,
                widzenieWCiemnosci,
                woltyzerka,
                wyczucieKierunku,
                wykrywaniePulapek,
                wyostrzoneZmysly,
                zapasy,
                zapieklaNienawisc,
                zmyslMagii,
                zylkaHandlowa
            };
            var itemResult = new List<Item>
            {
                halabarda,
                kij,
                kopia,
                korbacz,
                lanca,
                lewak,
                lamaczMieczy,
                morgensztern,
                puklerz,
                rapier,
                kastet,
                szpada,
                sztylet,
                tarcza,
                wlocznia,
                bronDwureczna,
                arkan,
                bicz,
                bolas,
                dlugiLuk,
                elfiLuk,
                garlacz,
                krotkiLuk,
                kuszaPistoletowa,
                kuszaSamopowtarzalna,
                kusza,
                luk,
                muszkietHochlandzki,
                nozDoRzucania,
                oszczep,
                pistolet,
                pistoletWielostrzalowy,
                proca,
                procaDrzewcowa,
                rusznica,
                rusznicaWielostrzalowa,
                siec,
                toporDoRzucania,
                wloczniaDoRzucania,
                strzala,
                belt,
                kulaDoBroni,
                prochStrzelniczy,
                helmSkora,
                kaftanSkora,
                kurtaSkora,
                nogawiceSkora,
                skorznia,
                czepiecKolczy,
                kaftanKolczy,
                koszulkaKolcza,
                kolczugaKolcza,
                kolczugaZRekawami,
                nogawiceKolcze,
                zbrojaKolcza,
                helmPlytowy,
                naramiennikiPlytowe,
                nogawicePlytowe,
                napiersnikPlytowy,
                zbrojaPlytowa,
                lachmany,
                kiepskieOdzienie,
                zwykleUbranie,
                dobreUbranie,
                szykowneUbranie,
                szaty,
                kostium,
                uniform,
                strojSzlachecki,
                strojArystokraty,
                peleryna,
                plaszcz,
                kapeluszZwykly,
                kapeluszZRondem,
                kapturMaska,
                obrok,
                bochenekChleba,
                polecMiesa,
                kiepskieJedzenie,
                dobreJedzenie,
                doskonaleJedzenie,
                prowiantNaTydzien,
                slodycze,
                smakolyki,
                ciemnePiwo,
                jasnePiwo,
                antalekPiwaJasnego,
                antalekPiwaCiemnego,
                butelkaGorzalki,
                butelkaGorzalkiDobrejJakosci,
                winoPospolite,
                winoSzlacheckie,
                buklak,
                flaszka,
                juki,
                kuferek,
                manierkaMetalowa,
                manierkaSkorzana,
                mieszek,
                plecak,
                sakiewka,
                tobolek,
                tubaNaMapy,
                worek,
                drewnoNaOpal,
                kaganek,
                latarnia,
                latarniaSztormowa,
                olejDoLatarni,
                pochodnia,
                swieczkaLojowa,
                swieczkaWoskowa,
                zapalka,
                zlotaKorona,
                pens,
                szyling,
                drabina,
                hubkaIKrzesiwo,
                imbryk,
                instrumentMuzyczny,
                klodkaDobrejJakosci,
                klodkaZwyklejJakosci,
                koc,
                kociolek,
                kosciDoGry,
                kufelDrewniany,
                kufelZeSzklaBarwionego,
                lina,
                luneta,
                lustro,
                namiot,
                papier,
                perfumy,
                pergamin,
                symbolReligijny,
                sztucceDrewniane,
                sztucceMetalowe,
                sztucceSrebrne,
                taliaKart,
                drag,
                drewnianyKlin,
                haczykNaRyby,
                kajdany,
                kilof,
                kolki,
                kotwiczkaDoWspinaczki,
                ksiazkaDrukowana,
                ksiazkaIlustrowana,
                liczydlo,
                lancuch,
                lom,
                lopata,
                mlot,
                narzedzia,
                potrzask,
                przyboryDoPisania,
                sztabkaMetalu,
                wnyki,
                wytrychy,
                zestawDoCharakteryzacji,
                wozek,
                woz,
                powoz,
                lodzRzeczna,
                lodzWioslowa,
                statek,
                rumak,
                lekkiKonBojowy,
                kon,
                kuc,
                siodlo,
                uprzaz,
                golabPocztowy,
                jastrzab,
                konJuczny,
                konPociagowyLubMul,
                kot,
                koza,
                krowa,
                kurczak,
                owca,
                pies,
                piesBojowy,
                swinia,
                wol,
                darGrety,
                miksturaLecznicza,
                piwoBugmana,
                czarnyJad,
                czarnyLotos,
                grzybkiSzalonegoKapelusznika,
                jadMantikory,
                korzenMandragory,
                sercoBoj,
                szkarlatnyCien,
                slinaChimery,
                ksiegaWiedzyTajemnej,
                naparKojacy,
                odtrutki,
                relikwia,
                talizmanSzczescia,
                wodaSwiecona,
                dlonWeterana,
                drewnianeZeby,
                kolczyk,
                opaskaNaOko,
                plytkaCzaszkowa,
                pozlacanyNos,
                szklaneOko,
                sztucznaNoga,
                tatuaz
            };

            var professionItemsDataSet = new List<ProfessionItems>();
            var professionItemDataSet = new List<ProfessionItem>();
            var professionSkillsDataSet = new List<ProfessionSkills>();
            var professionSkillDataSet = new List<ProfessionSkill>();
            var professionAbilitiesDataSet = new List<ProfessionAbilities>();
            var professionAbilityDataSet = new List<ProfessionAbility>();

            foreach (var professionBuilder in professionBuildersResult)
                foreach (var dictionary in professionBuilder.GetAllRelations())
                    if (dictionary.Key == typeof(ProfessionAbilities)) professionAbilitiesDataSet.AddRange(dictionary.Value as IEnumerable<ProfessionAbilities>);
                    else if (dictionary.Key == typeof(ProfessionAbility)) professionAbilityDataSet.AddRange(dictionary.Value as IEnumerable<ProfessionAbility>);
                    else if (dictionary.Key == typeof(ProfessionSkills)) professionSkillsDataSet.AddRange(dictionary.Value as IEnumerable<ProfessionSkills>);
                    else if (dictionary.Key == typeof(ProfessionSkill)) professionSkillDataSet.AddRange(dictionary.Value as IEnumerable<ProfessionSkill>);
                    else if (dictionary.Key == typeof(ProfessionItems)) professionItemsDataSet.AddRange(dictionary.Value as IEnumerable<ProfessionItems>);
                    else if (dictionary.Key == typeof(ProfessionItem)) professionItemDataSet.AddRange(dictionary.Value as IEnumerable<ProfessionItem>);

            int i = 0;

            professionBuildersResult.ForEach(a => a.GetResult().Id = ++i);

            i = 0; abilityResult.ForEach(a => a.Id = ++i);
            i = 0; skillResult.ForEach(a => a.Id = ++i);
            i = 0; itemResult.ForEach(a => a.Id = ++i);
            i = 0; professionItemsDataSet.ForEach(a => a.Id = ++i);
            i = 0; professionSkillsDataSet.ForEach(a => a.Id = ++i);
            i = 0; professionAbilitiesDataSet.ForEach(a => a.Id = ++i);
            i = 0; statisticsDataSet.ForEach(a => a.Id = (byte)++i);

            professionItemsDataSet.ForEach(a => { a.ProfessionId = a.Profession.Id; a.Profession = null; });
            professionItemDataSet.ForEach(a => { a.ProfessionsItemId = a.ProfessionItems.Id; a.ProfessionItems = null; a.ItemId = a.Item.Id; a.Item = null; });
            professionSkillsDataSet.ForEach(a => { a.ProfessionId = a.Profession.Id; a.Profession = null; });
            professionSkillDataSet.ForEach(a => { a.ProfessionSkillsId = a.ProfessionSkills.Id; a.ProfessionSkills = null; a.SkillId = a.Skill.Id; a.Skill = null; });
            professionAbilitiesDataSet.ForEach(a => { a.ProfessionId = a.Profession.Id; a.Profession = null; });
            professionAbilityDataSet.ForEach(a => { a.ProfessionAbilitiesId = a.ProfessionAbilities.Id; a.ProfessionAbilities = null; a.AbilityId = a.Ability.Id; a.Ability = null; });

            professionBuildersResult.ForEach(a =>
            {
                var profession = a.GetResult();

                profession.Abilities = null;
                profession.Skills = null;
                profession.Equipment = null;
                profession.OutputProfessions = null;
                profession.EntranceProfessions = null;
            });

            #region profession connections

            var profesionsConnectionsResult = new List<ProfessionProfession>
            {
                new ProfessionProfession { EntranceProfessionId = akolita.GetResult().Id, OutputProfessionId = cyrulik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = akolita.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = akolita.GetResult().Id, OutputProfessionId = fanatyk.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = akolita.GetResult().Id, OutputProfessionId = kaplan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = akolita.GetResult().Id, OutputProfessionId = skryba.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = akolita.GetResult().Id, OutputProfessionId = zakonnik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = banita.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = banita.GetResult().Id, OutputProfessionId = rozbojnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = banita.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = banita.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = banita.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = berserker.GetResult().Id, OutputProfessionId = gladiator.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = berserker.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = berserker.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = berserker.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = berserker.GetResult().Id, OutputProfessionId = zeglarz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = chlop.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = chlop.GetResult().Id, OutputProfessionId = fanatyk.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = chlop.GetResult().Id, OutputProfessionId = ochotnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = chlop.GetResult().Id, OutputProfessionId = rybak.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = chlop.GetResult().Id, OutputProfessionId = rzemieslnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = chlop.GetResult().Id, OutputProfessionId = sluga.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = chlop.GetResult().Id, OutputProfessionId = smieciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = chlop.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = chlop.GetResult().Id, OutputProfessionId = weglarz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = ciura.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ciura.GetResult().Id, OutputProfessionId = rzemieslnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ciura.GetResult().Id, OutputProfessionId = sluga.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ciura.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ciura.GetResult().Id, OutputProfessionId = szpieg.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ciura.GetResult().Id, OutputProfessionId = weglarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ciura.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = cyrkowiec.GetResult().Id, OutputProfessionId = bard.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = cyrkowiec.GetResult().Id, OutputProfessionId = kanciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = cyrkowiec.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = cyrkowiec.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = cyrkowiec.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = cyrulik.GetResult().Id, OutputProfessionId = medyk.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = cyrulik.GetResult().Id, OutputProfessionId = oprawca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = cyrulik.GetResult().Id, OutputProfessionId = porywacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = cyrulik.GetResult().Id, OutputProfessionId = rzemieslnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = cyrulik.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = fanatyk.GetResult().Id, OutputProfessionId = akolita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = fanatyk.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = fanatyk.GetResult().Id, OutputProfessionId = biczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = fanatyk.GetResult().Id, OutputProfessionId = podzegacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = fanatyk.GetResult().Id, OutputProfessionId = zakonnik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = flisak.GetResult().Id, OutputProfessionId = nawigator.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = flisak.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = flisak.GetResult().Id, OutputProfessionId = rybak.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = flisak.GetResult().Id, OutputProfessionId = zeglarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = flisak.GetResult().Id, OutputProfessionId = zolnierzOkretowy.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = giermek.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = giermek.GetResult().Id, OutputProfessionId = rycerz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = giermek.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = giermek.GetResult().Id, OutputProfessionId = szlachcic.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = giermek.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = gladiator.GetResult().Id, OutputProfessionId = lowcanagrod.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = gladiator.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = gladiator.GetResult().Id, OutputProfessionId = rzezimieszek.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = gladiator.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = gladiator.GetResult().Id, OutputProfessionId = zabojcaTroli.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = goniec.GetResult().Id, OutputProfessionId = hiena.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = goniec.GetResult().Id, OutputProfessionId = szczurolap.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = goniec.GetResult().Id, OutputProfessionId = tarczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = goniec.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = goniec.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = gornik.GetResult().Id, OutputProfessionId = inzynier.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = gornik.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = gornik.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = gornik.GetResult().Id, OutputProfessionId = tarczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = gornik.GetResult().Id, OutputProfessionId = weglarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = gornik.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = guslarz.GetResult().Id, OutputProfessionId = akolita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = guslarz.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = guslarz.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = guslarz.GetResult().Id, OutputProfessionId = uczen.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = guslarz.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = hiena.GetResult().Id, OutputProfessionId = lowcaWampirow.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = hiena.GetResult().Id, OutputProfessionId = paser.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = hiena.GetResult().Id, OutputProfessionId = szczurolap.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = hiena.GetResult().Id, OutputProfessionId = tarczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = hiena.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = kanciarz.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kanciarz.GetResult().Id, OutputProfessionId = cyrkowiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kanciarz.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kanciarz.GetResult().Id, OutputProfessionId = sluga.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kanciarz.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kanciarz.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = kozak.GetResult().Id, OutputProfessionId = lowcanagrod.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kozak.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kozak.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kozak.GetResult().Id, OutputProfessionId = tarczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kozak.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = lesnik.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lesnik.GetResult().Id, OutputProfessionId = lowca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lesnik.GetResult().Id, OutputProfessionId = ochotnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lesnik.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lesnik.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = lowca.GetResult().Id, OutputProfessionId = gornik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowca.GetResult().Id, OutputProfessionId = lowcanagrod.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowca.GetResult().Id, OutputProfessionId = straznikPol.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowca.GetResult().Id, OutputProfessionId = strzelec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowca.GetResult().Id, OutputProfessionId = weglarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowca.GetResult().Id, OutputProfessionId = wojownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowca.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowca.GetResult().Id, OutputProfessionId = zolnierz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = lowcanagrod.GetResult().Id, OutputProfessionId = lowcaWampirow.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcanagrod.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcanagrod.GetResult().Id, OutputProfessionId = rzezimieszek.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcanagrod.GetResult().Id, OutputProfessionId = strzelec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcanagrod.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = mieszczanin.GetResult().Id, OutputProfessionId = karczmarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mieszczanin.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mieszczanin.GetResult().Id, OutputProfessionId = ochotnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mieszczanin.GetResult().Id, OutputProfessionId = paser.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mieszczanin.GetResult().Id, OutputProfessionId = paz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mieszczanin.GetResult().Id, OutputProfessionId = podzegacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mieszczanin.GetResult().Id, OutputProfessionId = rzemieslnik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = mytnik.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mytnik.GetResult().Id, OutputProfessionId = przewoznik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mytnik.GetResult().Id, OutputProfessionId = rozbojnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mytnik.GetResult().Id, OutputProfessionId = straznikPol.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mytnik.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mytnik.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mytnik.GetResult().Id, OutputProfessionId = zolnierz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = najemnik.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = najemnik.GetResult().Id, OutputProfessionId = lowcanagrod.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = najemnik.GetResult().Id, OutputProfessionId = ochroniarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = najemnik.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = najemnik.GetResult().Id, OutputProfessionId = tarczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = najemnik.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = ochotnik.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochotnik.GetResult().Id, OutputProfessionId = mistrzRzemiosla.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochotnik.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochotnik.GetResult().Id, OutputProfessionId = poslaniec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochotnik.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochotnik.GetResult().Id, OutputProfessionId = straznikPol.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochotnik.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = ochroniarz.GetResult().Id, OutputProfessionId = lowcanagrod.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochroniarz.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochroniarz.GetResult().Id, OutputProfessionId = oprawca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochroniarz.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochroniarz.GetResult().Id, OutputProfessionId = rzezimieszek.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochroniarz.GetResult().Id, OutputProfessionId = straznikWiezienny.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ochroniarz.GetResult().Id, OutputProfessionId = zarzadca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = oprych.GetResult().Id, OutputProfessionId = gladiator.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = oprych.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = oprych.GetResult().Id, OutputProfessionId = ochroniarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = oprych.GetResult().Id, OutputProfessionId = oprawca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = oprych.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = paz.GetResult().Id, OutputProfessionId = giermek.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = paz.GetResult().Id, OutputProfessionId = herold.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = paz.GetResult().Id, OutputProfessionId = kanciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = paz.GetResult().Id, OutputProfessionId = majordomus.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = paz.GetResult().Id, OutputProfessionId = zak.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = podzegacz.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = podzegacz.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = podzegacz.GetResult().Id, OutputProfessionId = fanatyk.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = podzegacz.GetResult().Id, OutputProfessionId = kanciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = podzegacz.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = podzegacz.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = porywacz.GetResult().Id, OutputProfessionId = paser.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = porywacz.GetResult().Id, OutputProfessionId = szczurolap.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = porywacz.GetResult().Id, OutputProfessionId = wlamywacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = porywacz.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = porywacz.GetResult().Id, OutputProfessionId = zak.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = poslaniec.GetResult().Id, OutputProfessionId = herold.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = poslaniec.GetResult().Id, OutputProfessionId = straznikDrog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = poslaniec.GetResult().Id, OutputProfessionId = wojownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = poslaniec.GetResult().Id, OutputProfessionId = woznica.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = poslaniec.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = poslaniec.GetResult().Id, OutputProfessionId = zolnierz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = przemytnik.GetResult().Id, OutputProfessionId = flisak.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przemytnik.GetResult().Id, OutputProfessionId = paser.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przemytnik.GetResult().Id, OutputProfessionId = przewoznik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przemytnik.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przemytnik.GetResult().Id, OutputProfessionId = tarczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przemytnik.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przemytnik.GetResult().Id, OutputProfessionId = zeglarz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = przepatrywacz.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przepatrywacz.GetResult().Id, OutputProfessionId = rozbojnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przepatrywacz.GetResult().Id, OutputProfessionId = straznikDrog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przepatrywacz.GetResult().Id, OutputProfessionId = woznica.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przepatrywacz.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = przewoznik.GetResult().Id, OutputProfessionId = flisak.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przewoznik.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przewoznik.GetResult().Id, OutputProfessionId = rozbojnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przewoznik.GetResult().Id, OutputProfessionId = straznikDrog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = przewoznik.GetResult().Id, OutputProfessionId = zeglarz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = rybak.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rybak.GetResult().Id, OutputProfessionId = nawigator.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rybak.GetResult().Id, OutputProfessionId = ochotnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rybak.GetResult().Id, OutputProfessionId = zeglarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rybak.GetResult().Id, OutputProfessionId = zolnierzOkretowy.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = rzecznik.GetResult().Id, OutputProfessionId = kanciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzecznik.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzecznik.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzecznik.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzecznik.GetResult().Id, OutputProfessionId = zeglarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzecznik.GetResult().Id, OutputProfessionId = zak.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = rzemieslnik.GetResult().Id, OutputProfessionId = fanatyk.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzemieslnik.GetResult().Id, OutputProfessionId = inzynier.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzemieslnik.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzemieslnik.GetResult().Id, OutputProfessionId = mistrzRzemiosla.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzemieslnik.GetResult().Id, OutputProfessionId = ochotnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzemieslnik.GetResult().Id, OutputProfessionId = rzecznik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = rzezimieszek.GetResult().Id, OutputProfessionId = gladiator.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzezimieszek.GetResult().Id, OutputProfessionId = oprych.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzezimieszek.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzezimieszek.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rzezimieszek.GetResult().Id, OutputProfessionId = zwadzca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = skryba.GetResult().Id, OutputProfessionId = akolita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = skryba.GetResult().Id, OutputProfessionId = nawigator.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = skryba.GetResult().Id, OutputProfessionId = podzegacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = skryba.GetResult().Id, OutputProfessionId = uczen.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = skryba.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = sluga.GetResult().Id, OutputProfessionId = ciura.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = sluga.GetResult().Id, OutputProfessionId = karczmarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = sluga.GetResult().Id, OutputProfessionId = mieszczanin.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = sluga.GetResult().Id, OutputProfessionId = paz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = sluga.GetResult().Id, OutputProfessionId = podzegacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = sluga.GetResult().Id, OutputProfessionId = poslaniec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = sluga.GetResult().Id, OutputProfessionId = szpieg.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = sluga.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = straznik.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznik.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznik.GetResult().Id, OutputProfessionId = rzemieslnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznik.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznik.GetResult().Id, OutputProfessionId = straznikDrog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznik.GetResult().Id, OutputProfessionId = zolnierz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = straznikDrog.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikDrog.GetResult().Id, OutputProfessionId = mytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikDrog.GetResult().Id, OutputProfessionId = poslaniec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikDrog.GetResult().Id, OutputProfessionId = przepatrywacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikDrog.GetResult().Id, OutputProfessionId = rozbojnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikDrog.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikDrog.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = straznikPol.GetResult().Id, OutputProfessionId = lowcanagrod.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikPol.GetResult().Id, OutputProfessionId = lowcaWampirow.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikPol.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikPol.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikPol.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = straznikWiezienny.GetResult().Id, OutputProfessionId = ochroniarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikWiezienny.GetResult().Id, OutputProfessionId = oprawca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikWiezienny.GetResult().Id, OutputProfessionId = straznik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikWiezienny.GetResult().Id, OutputProfessionId = szczurolap.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = straznikWiezienny.GetResult().Id, OutputProfessionId = zarzadca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = szczurolap.GetResult().Id, OutputProfessionId = porywacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szczurolap.GetResult().Id, OutputProfessionId = straznikWiezienny.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szczurolap.GetResult().Id, OutputProfessionId = smieciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szczurolap.GetResult().Id, OutputProfessionId = tarczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szczurolap.GetResult().Id, OutputProfessionId = wlamywacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szczurolap.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = szermierz.GetResult().Id, OutputProfessionId = kanciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szermierz.GetResult().Id, OutputProfessionId = ochroniarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szermierz.GetResult().Id, OutputProfessionId = rozbojnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szermierz.GetResult().Id, OutputProfessionId = rzezimieszek.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szermierz.GetResult().Id, OutputProfessionId = zwadzca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = szlachcic.GetResult().Id, OutputProfessionId = dworzanin.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szlachcic.GetResult().Id, OutputProfessionId = giermek.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szlachcic.GetResult().Id, OutputProfessionId = kanciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szlachcic.GetResult().Id, OutputProfessionId = rajtar.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szlachcic.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szlachcic.GetResult().Id, OutputProfessionId = zak.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = smieciarz.GetResult().Id, OutputProfessionId = ciura.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = smieciarz.GetResult().Id, OutputProfessionId = paser.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = smieciarz.GetResult().Id, OutputProfessionId = porywacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = smieciarz.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = smieciarz.GetResult().Id, OutputProfessionId = wlamywacz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = tarczownik.GetResult().Id, OutputProfessionId = gladiator.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = tarczownik.GetResult().Id, OutputProfessionId = goniec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = tarczownik.GetResult().Id, OutputProfessionId = hiena.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = tarczownik.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = tarczownik.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = tarczownik.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = uczen.GetResult().Id, OutputProfessionId = skryba.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = uczen.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = uczen.GetResult().Id, OutputProfessionId = wedrownyCzarodziej.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = weglarz.GetResult().Id, OutputProfessionId = gornik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = weglarz.GetResult().Id, OutputProfessionId = lesnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = weglarz.GetResult().Id, OutputProfessionId = lowca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = weglarz.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = weglarz.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = wloczykij.GetResult().Id, OutputProfessionId = cyrkowiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wloczykij.GetResult().Id, OutputProfessionId = lesnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wloczykij.GetResult().Id, OutputProfessionId = smieciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wloczykij.GetResult().Id, OutputProfessionId = zakonnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wloczykij.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wloczykij.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = wojownik.GetResult().Id, OutputProfessionId = lowca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wojownik.GetResult().Id, OutputProfessionId = przepatrywacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wojownik.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wojownik.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wojownik.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = woznica.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = woznica.GetResult().Id, OutputProfessionId = mytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = woznica.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = woznica.GetResult().Id, OutputProfessionId = przewoznik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = woznica.GetResult().Id, OutputProfessionId = rozbojnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = woznica.GetResult().Id, OutputProfessionId = straznikDrog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = woznica.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zabojcaTroli.GetResult().Id, OutputProfessionId = zabojcaOlbrzymow.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zarzadca.GetResult().Id, OutputProfessionId = mytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zarzadca.GetResult().Id, OutputProfessionId = ochotnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zarzadca.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zarzadca.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zarzadca.GetResult().Id, OutputProfessionId = rzezimieszek.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zarzadca.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zlodziej.GetResult().Id, OutputProfessionId = cyrkowiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zlodziej.GetResult().Id, OutputProfessionId = hiena.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zlodziej.GetResult().Id, OutputProfessionId = kanciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zlodziej.GetResult().Id, OutputProfessionId = paser.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zlodziej.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zlodziej.GetResult().Id, OutputProfessionId = wlamywacz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zak.GetResult().Id, OutputProfessionId = akolita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zak.GetResult().Id, OutputProfessionId = cyrulik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zak.GetResult().Id, OutputProfessionId = inzynier.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zak.GetResult().Id, OutputProfessionId = medyk.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zak.GetResult().Id, OutputProfessionId = podzegacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zak.GetResult().Id, OutputProfessionId = rzecznik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zak.GetResult().Id, OutputProfessionId = uczen.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zak.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zeglarz.GetResult().Id, OutputProfessionId = bosman.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zeglarz.GetResult().Id, OutputProfessionId = kanciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zeglarz.GetResult().Id, OutputProfessionId = nawigator.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zeglarz.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zeglarz.GetResult().Id, OutputProfessionId = zolnierzOkretowy.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zolnierz.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zolnierz.GetResult().Id, OutputProfessionId = przepatrywacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zolnierz.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zolnierz.GetResult().Id, OutputProfessionId = straznik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zolnierz.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zolnierz.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zolnierzOkretowy.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zolnierzOkretowy.GetResult().Id, OutputProfessionId = bosman.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zolnierzOkretowy.GetResult().Id, OutputProfessionId = oprych.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zolnierzOkretowy.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zolnierzOkretowy.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = arcykaplan.GetResult().Id, OutputProfessionId = lowcaCzarownic.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = arcykaplan.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = arcykaplan.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = arcymag.GetResult().Id, OutputProfessionId = mistrzGildii.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = arcymag.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = arystokrata.GetResult().Id, OutputProfessionId = kapitan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = arystokrata.GetResult().Id, OutputProfessionId = oficer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = arystokrata.GetResult().Id, OutputProfessionId = rycerz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = arystokrata.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = bard.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = bard.GetResult().Id, OutputProfessionId = rozbojnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = bard.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = bard.GetResult().Id, OutputProfessionId = szpieg.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = bard.GetResult().Id, OutputProfessionId = zak.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = biczownik.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = biczownik.GetResult().Id, OutputProfessionId = kaplan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = biczownik.GetResult().Id, OutputProfessionId = oprawca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = biczownik.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = biczownik.GetResult().Id, OutputProfessionId = zolnierz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = bosman.GetResult().Id, OutputProfessionId = kapitan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = bosman.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = bosman.GetResult().Id, OutputProfessionId = nawigator.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = bosman.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = demagog.GetResult().Id, OutputProfessionId = herszt.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = demagog.GetResult().Id, OutputProfessionId = ksiaze.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = demagog.GetResult().Id, OutputProfessionId = najemnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = demagog.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = demagog.GetResult().Id, OutputProfessionId = zakonnik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = dworzanin.GetResult().Id, OutputProfessionId = arystokrata.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = dworzanin.GetResult().Id, OutputProfessionId = majordomus.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = dworzanin.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = dworzanin.GetResult().Id, OutputProfessionId = szpieg.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = dworzanin.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = dworzanin.GetResult().Id, OutputProfessionId = zwadzca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = fechmistrz.GetResult().Id, OutputProfessionId = lowcaCzarownic.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = fechmistrz.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = fechmistrz.GetResult().Id, OutputProfessionId = skrytobojca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = fechmistrz.GetResult().Id, OutputProfessionId = zwiadowca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = herold.GetResult().Id, OutputProfessionId = cyrkowiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = herold.GetResult().Id, OutputProfessionId = dworzanin.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = herold.GetResult().Id, OutputProfessionId = giermek.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = herold.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = herold.GetResult().Id, OutputProfessionId = podzegacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = herold.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = herszt.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = herszt.GetResult().Id, OutputProfessionId = ksiaze.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = herszt.GetResult().Id, OutputProfessionId = oficer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = herszt.GetResult().Id, OutputProfessionId = skrytobojca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = inzynier.GetResult().Id, OutputProfessionId = mistrzGildii.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = inzynier.GetResult().Id, OutputProfessionId = mistrzRzemiosla.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = inzynier.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = inzynier.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = inzynier.GetResult().Id, OutputProfessionId = rajtar.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = kapitan.GetResult().Id, OutputProfessionId = arystokrata.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kapitan.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kapitan.GetResult().Id, OutputProfessionId = szpieg.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kapitan.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = kaplan.GetResult().Id, OutputProfessionId = biczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kaplan.GetResult().Id, OutputProfessionId = majordomus.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kaplan.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kaplan.GetResult().Id, OutputProfessionId = wybraniecBozy.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = karczmarz.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = karczmarz.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = karczmarz.GetResult().Id, OutputProfessionId = mieszczanin.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = karczmarz.GetResult().Id, OutputProfessionId = paser.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = karczmarz.GetResult().Id, OutputProfessionId = przemytnik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = ksiaze.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ksiaze.GetResult().Id, OutputProfessionId = herszt.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ksiaze.GetResult().Id, OutputProfessionId = mistrzCieni.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = ksiaze.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = kupiec.GetResult().Id, OutputProfessionId = mistrzGildii.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kupiec.GetResult().Id, OutputProfessionId = ochotnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kupiec.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kupiec.GetResult().Id, OutputProfessionId = szpieg.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = kupiec.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = lesnyDuch.GetResult().Id, OutputProfessionId = herszt.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lesnyDuch.GetResult().Id, OutputProfessionId = lowcaWampirow.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lesnyDuch.GetResult().Id, OutputProfessionId = oficer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lesnyDuch.GetResult().Id, OutputProfessionId = strzelec.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = lowcaCzarownic.GetResult().Id, OutputProfessionId = akolita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcaCzarownic.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcaCzarownic.GetResult().Id, OutputProfessionId = fechmistrz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcaCzarownic.GetResult().Id, OutputProfessionId = mistrzZakonny.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcaCzarownic.GetResult().Id, OutputProfessionId = oficer.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = lowcaWampirow.GetResult().Id, OutputProfessionId = akolita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcaWampirow.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcaWampirow.GetResult().Id, OutputProfessionId = lowcaCzarownic.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcaWampirow.GetResult().Id, OutputProfessionId = rycerz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = lowcaWampirow.GetResult().Id, OutputProfessionId = strzelec.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = majordomus.GetResult().Id, OutputProfessionId = ksiaze.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = majordomus.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = majordomus.GetResult().Id, OutputProfessionId = paser.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = majordomus.GetResult().Id, OutputProfessionId = szlachcic.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = medyk.GetResult().Id, OutputProfessionId = mistrzGildii.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = medyk.GetResult().Id, OutputProfessionId = szpieg.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = medyk.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = medyk.GetResult().Id, OutputProfessionId = zakonnik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = mistrzCieni.GetResult().Id, OutputProfessionId = herszt.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzCieni.GetResult().Id, OutputProfessionId = ksiaze.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzCieni.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzCieni.GetResult().Id, OutputProfessionId = strzelec.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = mistrzGildii.GetResult().Id, OutputProfessionId = ksiaze.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzGildii.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzGildii.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = mistrzMagii.GetResult().Id, OutputProfessionId = arcymag.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzMagii.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzMagii.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = mistrzRzemiosla.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzRzemiosla.GetResult().Id, OutputProfessionId = inzynier.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzRzemiosla.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzRzemiosla.GetResult().Id, OutputProfessionId = mistrzGildii.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzRzemiosla.GetResult().Id, OutputProfessionId = ochotnik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = mistrzZakonny.GetResult().Id, OutputProfessionId = arystokrata.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzZakonny.GetResult().Id, OutputProfessionId = fechmistrz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzZakonny.GetResult().Id, OutputProfessionId = lowcaCzarownic.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = mistrzZakonny.GetResult().Id, OutputProfessionId = oficer.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = nawigator.GetResult().Id, OutputProfessionId = kapitan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = nawigator.GetResult().Id, OutputProfessionId = mistrzRzemiosla.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = nawigator.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = nawigator.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = odkrywca.GetResult().Id, OutputProfessionId = kapitan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = odkrywca.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = odkrywca.GetResult().Id, OutputProfessionId = oficer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = odkrywca.GetResult().Id, OutputProfessionId = szpieg.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = oficer.GetResult().Id, OutputProfessionId = herszt.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = oficer.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = oficer.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = oficer.GetResult().Id, OutputProfessionId = podzegacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = oficer.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = oprawca.GetResult().Id, OutputProfessionId = medyk.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = oprawca.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = oprawca.GetResult().Id, OutputProfessionId = zlodziej.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = paser.GetResult().Id, OutputProfessionId = ksiaze.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = paser.GetResult().Id, OutputProfessionId = mistrzCieni.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = paser.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = paser.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = rajtar.GetResult().Id, OutputProfessionId = dworzanin.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rajtar.GetResult().Id, OutputProfessionId = rycerz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rajtar.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rajtar.GetResult().Id, OutputProfessionId = weteran.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rajtar.GetResult().Id, OutputProfessionId = zwadzca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = reketer.GetResult().Id, OutputProfessionId = herold.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = reketer.GetResult().Id, OutputProfessionId = mistrzCieni.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = reketer.GetResult().Id, OutputProfessionId = paser.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = reketer.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = rozbojnik.GetResult().Id, OutputProfessionId = herszt.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rozbojnik.GetResult().Id, OutputProfessionId = mistrzCieni.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rozbojnik.GetResult().Id, OutputProfessionId = podzegacz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rozbojnik.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rozbojnik.GetResult().Id, OutputProfessionId = zwadzca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = rycerz.GetResult().Id, OutputProfessionId = akolita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rycerz.GetResult().Id, OutputProfessionId = arystokrata.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rycerz.GetResult().Id, OutputProfessionId = lowcaWampirow.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rycerz.GetResult().Id, OutputProfessionId = mistrzZakonny.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = rycerz.GetResult().Id, OutputProfessionId = oficer.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = sierzant.GetResult().Id, OutputProfessionId = oficer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = sierzant.GetResult().Id, OutputProfessionId = rycerz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = sierzant.GetResult().Id, OutputProfessionId = szampierz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = sierzant.GetResult().Id, OutputProfessionId = zwadzca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = skrytobojca.GetResult().Id, OutputProfessionId = fechmistrz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = skrytobojca.GetResult().Id, OutputProfessionId = herszt.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = skrytobojca.GetResult().Id, OutputProfessionId = lowcaCzarownic.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = skrytobojca.GetResult().Id, OutputProfessionId = kanciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = skrytobojca.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = strzelec.GetResult().Id, OutputProfessionId = fechmistrz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = strzelec.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = strzelec.GetResult().Id, OutputProfessionId = skrytobojca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = strzelec.GetResult().Id, OutputProfessionId = zwadzca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = szampierz.GetResult().Id, OutputProfessionId = fanatyk.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szampierz.GetResult().Id, OutputProfessionId = fechmistrz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szampierz.GetResult().Id, OutputProfessionId = lowcaCzarownic.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szampierz.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szampierz.GetResult().Id, OutputProfessionId = skrytobojca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = szarlatan.GetResult().Id, OutputProfessionId = banita.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szarlatan.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szarlatan.GetResult().Id, OutputProfessionId = szpieg.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szarlatan.GetResult().Id, OutputProfessionId = urzednik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szarlatan.GetResult().Id, OutputProfessionId = wlamywacz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = szpieg.GetResult().Id, OutputProfessionId = mistrzCieni.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szpieg.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szpieg.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = szpieg.GetResult().Id, OutputProfessionId = skrytobojca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = uczony.GetResult().Id, OutputProfessionId = kupiec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = uczony.GetResult().Id, OutputProfessionId = majordomus.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = uczony.GetResult().Id, OutputProfessionId = medyk.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = uczony.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = uczony.GetResult().Id, OutputProfessionId = uczen.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = uczony.GetResult().Id, OutputProfessionId = zakonnik.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = urzednik.GetResult().Id, OutputProfessionId = arystokrata.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = urzednik.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = urzednik.GetResult().Id, OutputProfessionId = dworzanin.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = urzednik.GetResult().Id, OutputProfessionId = ksiaze.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = urzednik.GetResult().Id, OutputProfessionId = majordomus.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = urzednik.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = weteran.GetResult().Id, OutputProfessionId = fechmistrz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = weteran.GetResult().Id, OutputProfessionId = herszt.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = weteran.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = weteran.GetResult().Id, OutputProfessionId = strzelec.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = weteran.GetResult().Id, OutputProfessionId = szampierz.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = wedrownyCzarodziej.GetResult().Id, OutputProfessionId = mistrzMagii.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wedrownyCzarodziej.GetResult().Id, OutputProfessionId = szarlatan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wedrownyCzarodziej.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = wlamywacz.GetResult().Id, OutputProfessionId = ksiaze.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wlamywacz.GetResult().Id, OutputProfessionId = mistrzCieni.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wlamywacz.GetResult().Id, OutputProfessionId = paser.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wlamywacz.GetResult().Id, OutputProfessionId = reketer.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wlamywacz.GetResult().Id, OutputProfessionId = wloczykij.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = wybraniecBozy.GetResult().Id, OutputProfessionId = arcykaplan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wybraniecBozy.GetResult().Id, OutputProfessionId = biczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wybraniecBozy.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wybraniecBozy.GetResult().Id, OutputProfessionId = lowcaCzarownic.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = wybraniecBozy.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zabojcaOlbrzymow.GetResult().Id, OutputProfessionId = zabojcaDemonow.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zakonnik.GetResult().Id, OutputProfessionId = biczownik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zakonnik.GetResult().Id, OutputProfessionId = demagog.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zakonnik.GetResult().Id, OutputProfessionId = kaplan.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zakonnik.GetResult().Id, OutputProfessionId = uczony.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zwadzca.GetResult().Id, OutputProfessionId = fechmistrz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zwadzca.GetResult().Id, OutputProfessionId = kanciarz.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zwadzca.GetResult().Id, OutputProfessionId = rozbojnik.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zwadzca.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zwadzca.GetResult().Id, OutputProfessionId = skrytobojca.GetResult().Id },

                new ProfessionProfession { EntranceProfessionId = zwiadowca.GetResult().Id, OutputProfessionId = herszt.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zwiadowca.GetResult().Id, OutputProfessionId = lesnyDuch.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zwiadowca.GetResult().Id, OutputProfessionId = lowcaWampirow.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zwiadowca.GetResult().Id, OutputProfessionId = odkrywca.GetResult().Id },
                new ProfessionProfession { EntranceProfessionId = zwiadowca.GetResult().Id, OutputProfessionId = sierzant.GetResult().Id}
            };

            #endregion profession connections

            modelBuilder.Entity<Profession>().HasData(professionBuildersResult.Select(a => a.GetResult()).ToList());
            modelBuilder.Entity<Item>().HasData(itemResult);
            modelBuilder.Entity<Skill>().HasData(skillResult);
            modelBuilder.Entity<Ability>().HasData(abilityResult);
            modelBuilder.Entity<Statistic>().HasData(statisticsDataSet);
            modelBuilder.Entity<ProfessionProfession>().HasData(profesionsConnectionsResult);
            modelBuilder.Entity<ProfessionItems>().HasData(professionItemsDataSet);

            modelBuilder.Entity<ProfessionItem>().HasData(professionItemDataSet);
            modelBuilder.Entity<ProfessionSkills>().HasData(professionSkillsDataSet);
            modelBuilder.Entity<ProfessionSkill>().HasData(professionSkillDataSet);
            modelBuilder.Entity<ProfessionAbilities>().HasData(professionAbilitiesDataSet);
            modelBuilder.Entity<ProfessionAbility>().HasData(professionAbilityDataSet);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProfessionProfession>().HasKey(a => new { a.EntranceProfessionId, a.OutputProfessionId });
            modelBuilder.Entity<ProfessionProfession>().HasOne(a => a.EntranceProfession).WithMany(a => a.OutputProfessions).HasForeignKey(a => a.EntranceProfessionId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ProfessionProfession>().HasOne(a => a.OutputProfession).WithMany(a => a.EntranceProfessions).HasForeignKey(a => a.OutputProfessionId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProfessionAbilities>().HasOne(a => a.Profession).WithMany(a => a.Abilities).HasForeignKey(a => a.ProfessionId);
            modelBuilder.Entity<ProfessionAbility>().HasKey(a => new { a.ProfessionAbilitiesId, a.AbilityId });
            modelBuilder.Entity<ProfessionAbility>().HasOne(a => a.Ability).WithMany(a => a.Professions).HasForeignKey(a => a.AbilityId);
            modelBuilder.Entity<ProfessionAbility>().HasOne(a => a.ProfessionAbilities).WithMany(a => a.Abilities).HasForeignKey(a => a.ProfessionAbilitiesId);

            modelBuilder.Entity<ProfessionSkills>().HasOne(a => a.Profession).WithMany(a => a.Skills).HasForeignKey(a => a.ProfessionId);
            modelBuilder.Entity<ProfessionSkill>().HasKey(a => new { a.ProfessionSkillsId, a.SkillId });
            modelBuilder.Entity<ProfessionSkill>().HasOne(a => a.Skill).WithMany(a => a.Professions).HasForeignKey(a => a.SkillId);
            modelBuilder.Entity<ProfessionSkill>().HasOne(a => a.ProfessionSkills).WithMany(a => a.Skills).HasForeignKey(a => a.ProfessionSkillsId);

            modelBuilder.Entity<ProfessionItems>().HasOne(a => a.Profession).WithMany(a => a.Equipment).HasForeignKey(a => a.ProfessionId);
            modelBuilder.Entity<ProfessionItem>().HasKey(a => new { a.ProfessionsItemId, a.ItemId });
            modelBuilder.Entity<ProfessionItem>().HasOne(a => a.Item).WithMany(a => a.Professions).HasForeignKey(a => a.ItemId);
            modelBuilder.Entity<ProfessionItem>().HasOne(a => a.ProfessionItems).WithMany(a => a.Items).HasForeignKey(a => a.ProfessionsItemId);

            modelBuilder.Entity<Statistic>().HasIndex(a => a.Type).IsUnique();

            modelBuilder.Entity<CharacterItem>().HasKey(a => new { a.CharacterId, a.ItemId });
            modelBuilder.Entity<CharacterProfession>().HasKey(a => new { a.CharacterId, a.ProfessionId });
            modelBuilder.Entity<CharacterSkill>().HasKey(a => new { a.CharacterId, a.SkillId });
            modelBuilder.Entity<CharacterAbility>().HasKey(a => new { a.CharacterId, a.AbilityId });
            modelBuilder.Entity<CharacterStatistic>().HasKey(a => new { a.CharacterId, a.StatisticId });

            SeedData(modelBuilder);
        }
    }
}