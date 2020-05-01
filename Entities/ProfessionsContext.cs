using Microsoft.EntityFrameworkCore;
using System;
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
            Database.Migrate();

            SeedData();
        }

        public DbSet<Ability> Abilities { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<DictionaryDefinition> Dictionaries { get; set; }

        public DbSet<DictionaryValue> DictionaryValues { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Profession> Professions { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Statistic> Statistics { get; set; }

        public DbSet<User> Users { get; set; }

        public void SeedData()
        {
            if (Database.EnsureCreated() && Professions.Any())
                return;

            #region Dictionaries

            var dictValNauka = new DictionaryDefinition
            {
                Name = "Nauka",
                Type = BuiltInDictionaries.Science,
                Values = new List<DictionaryValue>
                    {
                        new DictionaryValue { Value = "Astronomia" , Type = BuiltInDictionaryValues.ScienceAstronomy },
                        new DictionaryValue { Value = "Historia" , Type = BuiltInDictionaryValues.ScienceHistory },
                        new DictionaryValue { Value = "Teologia" , Type = BuiltInDictionaryValues.ScienceTeology },
                        new DictionaryValue { Value = "Genealogia/heraldyka" , Type = BuiltInDictionaryValues.ScienceGenealogy },
                        new DictionaryValue { Value = "Prawo" , Type = BuiltInDictionaryValues.ScienceLaw },
                        new DictionaryValue { Value = "Nekromancja" , Type = BuiltInDictionaryValues.ScienceNecromancy },
                        new DictionaryValue { Value = "Anatomia" , Type = BuiltInDictionaryValues.ScienceAnatomy },
                        new DictionaryValue { Value = "Magia" , Type = BuiltInDictionaryValues.ScienceMagic },
                        new DictionaryValue { Value = "Strategia/taktyka" , Type = BuiltInDictionaryValues.ScienceStrategy },
                        new DictionaryValue { Value = "Sztuka" , Type = BuiltInDictionaryValues.ScienceArt },
                        new DictionaryValue { Value = "Inżynieria" , Type = BuiltInDictionaryValues.ScienceEngineering },
                        new DictionaryValue { Value = "Mechanika", Type = BuiltInDictionaryValues.ScienceMechanics }
                    }
            };

            var dictValJezyk = new DictionaryDefinition
            {
                Name = "Język",
                Type = BuiltInDictionaries.Language,
                Values = new List<DictionaryValue>
                    {
                        new DictionaryValue { Value = "Klasyczny", Type = BuiltInDictionaryValues.LanguageClassic },
                        new DictionaryValue { Value = "Staroświatowy", Type = BuiltInDictionaryValues.LanguageOldWorld },
                        new DictionaryValue { Value = "Norski", Type = BuiltInDictionaryValues.LanguageNorsca },
                        new DictionaryValue { Value = "Bretoński", Type = BuiltInDictionaryValues.LanguageBrittany },
                        new DictionaryValue { Value = "Kislevski", Type = BuiltInDictionaryValues.LanguageKislev },
                        new DictionaryValue { Value = "Tileański", Type = BuiltInDictionaryValues.LanguageTileanian },
                        new DictionaryValue { Value = "Eltharian", Type = BuiltInDictionaryValues.LanguageEltharin },
                        new DictionaryValue { Value = "Khazalid", Type = BuiltInDictionaryValues.LanguageKhazalid },
                        new DictionaryValue { Value = "Estalijski", Type = BuiltInDictionaryValues.LanguageEstalian },
                        new DictionaryValue { Value = "Niziołków", Type = BuiltInDictionaryValues.LanguageHalfings }
                    }
            };

            var dictValSekretneZnaki = new DictionaryDefinition
            {
                Name = "Sekretne znaki",
                Type = BuiltInDictionaries.SecretMarks,
                Values = new List<DictionaryValue>
                    {
                        new DictionaryValue { Value = "Złodziei", Type = BuiltInDictionaryValues.SecretMarksThiefs },
                        new DictionaryValue { Value = "Zwiadowców", Type = BuiltInDictionaryValues.SecretMarksScouts },
                        new DictionaryValue { Value = "Łowców", Type = BuiltInDictionaryValues.SecretMarksHunters },
                        new DictionaryValue { Value = "Rycerzy zakonnych", Type = BuiltInDictionaryValues.SecretMarksHolyOrderSoldiers }
                    }
            };

            var dictValSekretnyJezyk = new DictionaryDefinition
            {
                Name = "Sekretny język",
                Type = BuiltInDictionaries.SecretLanguage,
                Values = new List<DictionaryValue>
                    {
                        new DictionaryValue { Value = "Łowców", Type = BuiltInDictionaryValues.SecretLanguageHunters },
                        new DictionaryValue { Value = "Bitewny", Type = BuiltInDictionaryValues.SecretLanguageBattle },
                        new DictionaryValue { Value = "Złodziei", Type = BuiltInDictionaryValues.SecretLanguageThiefs },
                        new DictionaryValue { Value = "Gildii", Type = BuiltInDictionaryValues.SecretLanguageGuild }
                    }
            };

            var dictValKuglarstwo = new DictionaryDefinition
            {
                Name = "Kuglarstwo",
                Type = BuiltInDictionaries.Prestidigitation,
                Values = new List<DictionaryValue>
                    {
                        new DictionaryValue { Value = "Gawędziarstwo", Type = BuiltInDictionaryValues.PrestidigitationStoryTelling },
                        new DictionaryValue { Value = "Taniec", Type = BuiltInDictionaryValues.PrestidigitationDancing },
                        new DictionaryValue { Value = "Śpiew", Type = BuiltInDictionaryValues.PrestidigitationSinging },
                        new DictionaryValue { Value = "Aktorstwo", Type = BuiltInDictionaryValues.PrestidigitationTheatricalArt },
                        new DictionaryValue { Value = "Muzykalność", Type = BuiltInDictionaryValues.PrestidigitationMusicality }
                    }
            };

            var dictValRzemioslo = new DictionaryDefinition
            {
                Name = "Rzemiosło",
                Type = BuiltInDictionaries.Craft,
                Values = new List<DictionaryValue>
                    {
                        new DictionaryValue { Value = "Gotowanie" , Type = BuiltInDictionaryValues.CraftCooking },
                        new DictionaryValue { Value = "Wyrób łuków" , Type = BuiltInDictionaryValues.CraftBowMaking },
                        new DictionaryValue { Value = "Uprawa ziemii" , Type = BuiltInDictionaryValues.CraftTillage },
                        new DictionaryValue { Value = "Handel" , Type = BuiltInDictionaryValues.CraftTrading },
                        new DictionaryValue { Value = "Kartografia" , Type = BuiltInDictionaryValues.CraftCartography },
                        new DictionaryValue { Value = "Kowalstwo" , Type = BuiltInDictionaryValues.CraftBlacksmithing },
                        new DictionaryValue { Value = "Krawiectwo" , Type = BuiltInDictionaryValues.CraftTailoring },
                        new DictionaryValue { Value = "Kaligrafia" , Type = BuiltInDictionaryValues.CraftCalligraphy },
                        new DictionaryValue { Value = "Płatnerstwo" , Type = BuiltInDictionaryValues.CraftArmouring },
                        new DictionaryValue { Value = "Rusznikarstwo" , Type = BuiltInDictionaryValues.CraftGunsmithing },
                        new DictionaryValue { Value = "Zielarstwo" , Type = BuiltInDictionaryValues.CraftHerbology },
                        new DictionaryValue { Value = "Aptekarstwo" , Type = BuiltInDictionaryValues.CraftPharmacy },
                        new DictionaryValue { Value = "Górnictwo" , Type = BuiltInDictionaryValues.CraftMining },
                        new DictionaryValue { Value = "Górnictwo odkrywkowe" , Type = BuiltInDictionaryValues.CraftOpencastMining },
                        new DictionaryValue { Value = "Szkutnictwo", Type = BuiltInDictionaryValues.CraftBoatbuilding },
                        new DictionaryValue { Value = "Kamieniarstwo", Type = BuiltInDictionaryValues.CraftMasonry }
                    }
            };

            var dictValWiedza = new DictionaryDefinition
            {
                Name = "Wiedza",
                Type = BuiltInDictionaries.Knowledge,
                Values = new List<DictionaryValue>
                    {
                        new DictionaryValue { Value = "Imperium" , Type = BuiltInDictionaryValues.KnowledgeEmpire },
                        new DictionaryValue { Value = "Norska" , Type = BuiltInDictionaryValues.KnowledgeNorsca },
                        new DictionaryValue { Value = "Kislev" , Type = BuiltInDictionaryValues.KnowledgeKislev },
                        new DictionaryValue { Value = "Bretonia" , Type = BuiltInDictionaryValues.KnowledgeBrittany },
                        new DictionaryValue { Value = "Tilea" , Type = BuiltInDictionaryValues.KnowledgeTilea },
                        new DictionaryValue { Value = "Jałowa kraina" , Type = BuiltInDictionaryValues.KnowledgeBarrenLand },
                        new DictionaryValue { Value = "Estalia" , Type = BuiltInDictionaryValues.KnowledgeEstalia },
                        new DictionaryValue { Value = "Krasnoludy", Type = BuiltInDictionaryValues.KnowledgeDwarves },
                        new DictionaryValue { Value = "Elfy", Type = BuiltInDictionaryValues.KnowledgeElves },
                        new DictionaryValue { Value = "Niziołki", Type = BuiltInDictionaryValues.KnowledgeHalfings }
                    }
            };

            var dictValJezykTajemny = new DictionaryDefinition
            {
                Name = "Język tajemny",
                Type = BuiltInDictionaries.MisticLanguage,
                Values = new List<DictionaryValue>
                    {
                        new DictionaryValue { Value = "Magiczny" , Type = BuiltInDictionaryValues.MisticLanguageMagic },
                        new DictionaryValue { Value = "Demoniczny" , Type = BuiltInDictionaryValues.MisticLanguageDemonic },
                        new DictionaryValue { Value = "Elfi", Type = BuiltInDictionaryValues.MisticLanguageElven }
                    }
            };

            var dictValBronSpecjalna = new DictionaryDefinition
            {
                Name = "Broń specjalna",
                Type = BuiltInDictionaries.SpecialWeapon,
                Values = new List<DictionaryValue>
                    {
                        new DictionaryValue { Value = "Długi łuk", Type = BuiltInDictionaryValues.SpecialWeaponLongBow },
                        new DictionaryValue { Value = "Proca", Type = BuiltInDictionaryValues.SpecialWeaponSlingShot }
                    }
            };

            var dictionaries = new List<DictionaryDefinition>
            {
                dictValNauka,
                dictValJezyk,
                dictValSekretneZnaki,
                dictValSekretnyJezyk,
                dictValKuglarstwo,
                dictValRzemioslo,
                dictValWiedza,
                dictValJezykTajemny,
                dictValBronSpecjalna
            };

            #endregion Dictionaries

            #region items

            var halabarda = new Item
            {
                Name = "Halabarda",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 175,
                ItemType = ItemType.WhiteWeapon
            };
            var kij = new Item
            {
                Name = "Kij",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.High,
                Weight = 50,
                ItemType = ItemType.WhiteWeapon
            };
            var kopia = new Item
            {
                Name = "Kopia",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 100,
                ItemType = ItemType.WhiteWeapon
            };
            var korbacz = new Item
            {
                Name = "Korbacz",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 95,
                ItemType = ItemType.WhiteWeapon
            };
            var lanca = new Item
            {
                Name = "Lanca",
                Price = MoneyCalculator.GetUserMoney(20, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 75,
                ItemType = ItemType.WhiteWeapon
            };
            var lewak = new Item
            {
                Name = "Lewak",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 10,
                ItemType = ItemType.WhiteWeapon
            };
            var lamaczMieczy = new Item
            {
                Name = "Łamacz mieczy",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 40,
                ItemType = ItemType.WhiteWeapon
            };
            var morgensztern = new Item
            {
                Name = "Morgensztern",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 60,
                ItemType = ItemType.WhiteWeapon
            };
            var puklerz = new Item
            {
                Name = "Puklerz",
                Price = MoneyCalculator.GetUserMoney(4, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 15,
                ItemType = ItemType.WhiteWeapon
            };
            var rapier = new Item
            {
                Name = "Rapier",
                Price = MoneyCalculator.GetUserMoney(18, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 40,
                ItemType = ItemType.WhiteWeapon
            };
            var kastet = new Item
            {
                Name = "Rękawica/kastet",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 1,
                ItemType = ItemType.WhiteWeapon
            };
            var szpada = new Item
            {
                Name = "Szpada",
                Price = MoneyCalculator.GetUserMoney(18, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 40,
                ItemType = ItemType.WhiteWeapon
            };
            var sztylet = new Item
            {
                Name = "Sztylet",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 10,
                ItemType = ItemType.WhiteWeapon
            };
            var tarcza = new Item
            {
                Name = "Tarcza",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 50,
                ItemType = ItemType.WhiteWeapon
            };
            var wlocznia = new Item
            {
                Name = "Włócznia",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 50,
                ItemType = ItemType.WhiteWeapon
            };
            var bronDwureczna = new Item
            {
                Name = "Bron dwureczna",
                Price = MoneyCalculator.GetUserMoney(0, 0, 0),
                Rarity = ItemRarity.Common,
                Weight = 0,
                ItemType = ItemType.WhiteWeapon
            };
            var arkan = new Item
            {
                Name = "Arkan",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 10,
                ItemType = ItemType.RangedWeapon
            };
            var bicz = new Item
            {
                Name = "Bicz",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 40,
                ItemType = ItemType.RangedWeapon
            };
            var bolas = new Item
            {
                Name = "Bolas",
                Price = MoneyCalculator.GetUserMoney(0, 7, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 20,
                ItemType = ItemType.RangedWeapon
            };
            var dlugiLuk = new Item
            {
                Name = "Długi łuk",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 90,
                ItemType = ItemType.RangedWeapon
            };
            var elfiLuk = new Item
            {
                Name = "Elfi łuk",
                Price = MoneyCalculator.GetUserMoney(70, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 75,
                ItemType = ItemType.RangedWeapon
            };
            var garlacz = new Item
            {
                Name = "Garłacz",
                Price = MoneyCalculator.GetUserMoney(70, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 50,
                ItemType = ItemType.RangedWeapon
            };
            var krotkiLuk = new Item
            {
                Name = "Krótki łuk",
                Price = MoneyCalculator.GetUserMoney(70, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 75,
                ItemType = ItemType.RangedWeapon
            };
            var kuszaPistoletowa = new Item
            {
                Name = "Kusza pistoletowa",
                Price = MoneyCalculator.GetUserMoney(35, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 25,
                ItemType = ItemType.RangedWeapon
            };
            var kuszaSamopowtarzalna = new Item
            {
                Name = "Kusza samopowtarzalna",
                Price = MoneyCalculator.GetUserMoney(100, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 150,
                ItemType = ItemType.RangedWeapon
            };
            var kusza = new Item
            {
                Name = "Kusza",
                Price = MoneyCalculator.GetUserMoney(25, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 120,
                ItemType = ItemType.RangedWeapon
            };
            var luk = new Item
            {
                Name = "Łuk",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 80,
                ItemType = ItemType.RangedWeapon
            };
            var muszkietHochlandzki = new Item
            {
                Name = "Muszkiet hochlandzki",
                Price = MoneyCalculator.GetUserMoney(450, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 70,
                ItemType = ItemType.RangedWeapon
            };
            var nozDoRzucania = new Item
            {
                Name = "Nóź/gwiazdka do rzucania",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 10,
                ItemType = ItemType.RangedWeapon
            };
            var oszczep = new Item
            {
                Name = "Oszczep",
                Price = MoneyCalculator.GetUserMoney(0, 25, 0),
                Rarity = ItemRarity.Low,
                Weight = 50,
                ItemType = ItemType.RangedWeapon
            };
            var pistolet = new Item
            {
                Name = "Pistolet",
                Price = MoneyCalculator.GetUserMoney(200, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 25,
                ItemType = ItemType.RangedWeapon
            };
            var pistoletWielostrzalowy = new Item
            {
                Name = "Pistolet wielostrzałowy",
                Price = MoneyCalculator.GetUserMoney(400, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 25,
                ItemType = ItemType.RangedWeapon
            };
            var proca = new Item
            {
                Name = "Proca",
                Price = MoneyCalculator.GetUserMoney(4, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 10,
                ItemType = ItemType.RangedWeapon
            };
            var procaDrzewcowa = new Item
            {
                Name = "Proca drzewcowa",
                Price = MoneyCalculator.GetUserMoney(6, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 50,
                ItemType = ItemType.RangedWeapon
            };
            var rusznica = new Item
            {
                Name = "Rusznica",
                Price = MoneyCalculator.GetUserMoney(300, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 30,
                ItemType = ItemType.RangedWeapon
            };
            var rusznicaWielostrzalowa = new Item
            {
                Name = "Rusznica wielostrzałowa",
                Price = MoneyCalculator.GetUserMoney(600, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 30,
                ItemType = ItemType.RangedWeapon
            };
            var siec = new Item
            {
                Name = "Sieć",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 60,
                ItemType = ItemType.RangedWeapon
            };
            var toporDoRzucania = new Item
            {
                Name = "Topór/młot do rzucania",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 40,
                ItemType = ItemType.RangedWeapon
            };
            var wloczniaDoRzucania = new Item
            {
                Name = "Włócznia",
                Price = MoneyCalculator.GetUserMoney(0, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 30,
                ItemType = ItemType.RangedWeapon
            };
            var strzala = new Item
            {
                Name = "Strzała",
                Price = MoneyCalculator.GetUserMoney(0, 0, 2),
                Rarity = ItemRarity.Average,
                Weight = 10,
                ItemType = ItemType.Ammunition
            };
            var belt = new Item
            {
                Name = "Bełt",
                Price = MoneyCalculator.GetUserMoney(0, 0, 4),
                Rarity = ItemRarity.Low,
                Weight = 10,
                ItemType = ItemType.Ammunition
            };
            var kulaDoBroni = new Item
            {
                Name = "Kula do broni palnej",
                Price = MoneyCalculator.GetUserMoney(0, 0, 1),
                Rarity = ItemRarity.Rare,
                Weight = 10,
                ItemType = ItemType.Ammunition
            };
            var prochStrzelniczy = new Item
            {
                Name = "Proch strzelniczy (strzał)",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 1,
                ItemType = ItemType.Ammunition
            };
            var helmSkora = new Item
            {
                Name = "Hełm (Skórzany)",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 10,
                ItemType = ItemType.Armor
            };
            var kaftanSkora = new Item
            {
                Name = "Kaftan (Skórzany)",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 40,
                ItemType = ItemType.Armor
            };
            var kurtaSkora = new Item
            {
                Name = "Kurta (Skórzana)",
                Price = MoneyCalculator.GetUserMoney(12, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 50,
                ItemType = ItemType.Armor
            };
            var nogawiceSkora = new Item
            {
                Name = "Nogawice (Skórzane)",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 20,
                ItemType = ItemType.Armor
            };
            var skorznia = new Item
            {
                Name = "Skórznia",
                Price = MoneyCalculator.GetUserMoney(25, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 80,
                ItemType = ItemType.Armor
            };
            var czepiecKolczy = new Item
            {
                Name = "Czepiec (Kolczy)",
                Price = MoneyCalculator.GetUserMoney(20, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 30,
                ItemType = ItemType.Armor
            };
            var kaftanKolczy = new Item
            {
                Name = "Kaftan (Kolczy)",
                Price = MoneyCalculator.GetUserMoney(60, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 60,
                ItemType = ItemType.Armor
            };
            var koszulkaKolcza = new Item
            {
                Name = "Koszulka (Kolcza)",
                Price = MoneyCalculator.GetUserMoney(95, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 80,
                ItemType = ItemType.Armor
            };
            var kolczugaKolcza = new Item
            {
                Name = "Kolczuga",
                Price = MoneyCalculator.GetUserMoney(75, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 80,
                ItemType = ItemType.Armor
            };
            var kolczugaZRekawami = new Item
            {
                Name = "Kolczuga z rękawami",
                Price = MoneyCalculator.GetUserMoney(130, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 100,
                ItemType = ItemType.Armor
            };
            var nogawiceKolcze = new Item
            {
                Name = "Nogawice (Kolcze)",
                Price = MoneyCalculator.GetUserMoney(20, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 40,
                ItemType = ItemType.Armor
            };
            var zbrojaKolcza = new Item
            {
                Name = "Zbroja kolcza",
                Price = MoneyCalculator.GetUserMoney(170, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 210,
                ItemType = ItemType.Armor
            };
            var helmPlytowy = new Item
            {
                Name = "Hełm (płytowy)",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 40,
                ItemType = ItemType.Armor
            };
            var naramiennikiPlytowe = new Item
            {
                Name = "Naramienniki (płytowe)",
                Price = MoneyCalculator.GetUserMoney(70, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 75,
                ItemType = ItemType.Armor
            };
            var nogawicePlytowe = new Item
            {
                Name = "Nogawice (płytowe)",
                Price = MoneyCalculator.GetUserMoney(60, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 30,
                ItemType = ItemType.Armor
            };
            var napiersnikPlytowy = new Item
            {
                Name = "Napierśnik (płytowy)",
                Price = MoneyCalculator.GetUserMoney(70, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 40,
                ItemType = ItemType.Armor
            };
            var zbrojaPlytowa = new Item
            {
                Name = "Zbroja płytowa",
                Price = MoneyCalculator.GetUserMoney(400, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 395,
                ItemType = ItemType.Armor
            };
            var lachmany = new Item
            {
                Name = "Łachmany",
                Price = MoneyCalculator.GetUserMoney(0, 0, 1),
                Rarity = ItemRarity.Common,
                Weight = 5,
                ItemType = ItemType.Cloth
            };
            var kiepskieOdzienie = new Item
            {
                Name = "Kiepskie odzienie",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.Common,
                Weight = 10,
                ItemType = ItemType.Cloth
            };
            var zwykleUbranie = new Item
            {
                Name = "Zwykłe ubranie",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 15,
                ItemType = ItemType.Cloth
            };
            var dobreUbranie = new Item
            {
                Name = "Dobre ubranie",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 15,
                ItemType = ItemType.Cloth
            };
            var szykowneUbranie = new Item
            {
                Name = "Szykowne ubranie",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 20,
                ItemType = ItemType.Cloth
            };
            var szaty = new Item
            {
                Name = "Szaty",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 25,
                ItemType = ItemType.Cloth
            };
            var kostium = new Item
            {
                Name = "Kostium",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 10,
                ItemType = ItemType.Cloth
            };
            var uniform = new Item
            {
                Name = "Uniform",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 15,
                ItemType = ItemType.Cloth
            };
            var strojSzlachecki = new Item
            {
                Name = "Strój szlachecki",
                Price = MoneyCalculator.GetUserMoney(50, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 30,
                ItemType = ItemType.Cloth
            };
            var strojArystokraty = new Item
            {
                Name = "Strój arystokraty",
                Price = MoneyCalculator.GetUserMoney(100, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 50,
                ItemType = ItemType.Cloth
            };
            var peleryna = new Item
            {
                Name = "Peleryna",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 10,
                ItemType = ItemType.Cloth
            };
            var plaszcz = new Item
            {
                Name = "Płaszcz",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 15,
                ItemType = ItemType.Cloth
            };
            var kapeluszZwykly = new Item
            {
                Name = "Kapelusz zwykły",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.High,
                Weight = 15,
                ItemType = ItemType.Cloth
            };
            var kapeluszZRondem = new Item
            {
                Name = "Kapelusz z szerokim rondlem",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 5,
                ItemType = ItemType.Cloth
            };
            var kapturMaska = new Item
            {
                Name = "Kaptur lub maska",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.Average,
                Weight = 2,
                ItemType = ItemType.Cloth
            };
            var obrok = new Item
            {
                Name = "Obrok (porcja na 1 dzień)",
                Price = MoneyCalculator.GetUserMoney(0, 0, 5),
                Rarity = ItemRarity.High,
                Weight = 50,
                ItemType = ItemType.Food
            };
            var bochenekChleba = new Item
            {
                Name = "Bochenek chleba",
                Price = MoneyCalculator.GetUserMoney(0, 0, 2),
                Rarity = ItemRarity.Common,
                Weight = 2,
                ItemType = ItemType.Food
            };
            var polecMiesa = new Item
            {
                Name = "Połeć mięsa",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Low,
                Weight = 10,
                ItemType = ItemType.Food
            };
            var kiepskieJedzenie = new Item
            {
                Name = "Kiepskie jedzenie (porcja na 1 dzień)",
                Price = MoneyCalculator.GetUserMoney(0, 0, 5),
                Rarity = ItemRarity.High,
                Weight = 10,
                ItemType = ItemType.Food
            };
            var dobreJedzenie = new Item
            {
                Name = "Dobre jedzenie (porcja na 1 dzień)",
                Price = MoneyCalculator.GetUserMoney(0, 0, 10),
                Rarity = ItemRarity.Average,
                Weight = 10,
                ItemType = ItemType.Food
            };
            var doskonaleJedzenie = new Item
            {
                Name = "Doskonałe jedzenie (porcja na 1 dzień)",
                Price = MoneyCalculator.GetUserMoney(0, 0, 18),
                Rarity = ItemRarity.Low,
                Weight = 10,
                ItemType = ItemType.Food
            };
            var prowiantNaTydzien = new Item
            {
                Name = "Prowiant (porcja na 1 tydzień)",
                Price = MoneyCalculator.GetUserMoney(0, 6, 0),
                Rarity = ItemRarity.Average,
                Weight = 50,
                ItemType = ItemType.Food
            };
            var slodycze = new Item
            {
                Name = "Słodycze",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Average,
                Weight = 2,
                ItemType = ItemType.Food
            };
            var smakolyki = new Item
            {
                Name = "Smakołyki",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 0,
                ItemType = ItemType.Food
            };
            var ciemnePiwo = new Item
            {
                Name = "Ciemne piwo",
                Price = MoneyCalculator.GetUserMoney(0, 0, 2),
                Rarity = ItemRarity.High,
                Weight = 2,
                ItemType = ItemType.Food
            };
            var jasnePiwo = new Item
            {
                Name = "Jasne piwo",
                Price = MoneyCalculator.GetUserMoney(0, 0, 1),
                Rarity = ItemRarity.Common,
                Weight = 2,
                ItemType = ItemType.Food
            };
            var antalekPiwaJasnego = new Item
            {
                Name = "Antałek piwa jasnego",
                Price = MoneyCalculator.GetUserMoney(0, 0, 18),
                Rarity = ItemRarity.Common,
                Weight = 30,
                ItemType = ItemType.Food
            };
            var antalekPiwaCiemnego = new Item
            {
                Name = "Antałek piwa ciemnego",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Common,
                Weight = 30,
                ItemType = ItemType.Food
            };
            var butelkaGorzalki = new Item
            {
                Name = "Butelka gorzałki",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Low,
                Weight = 5,
                ItemType = ItemType.Food
            };
            var butelkaGorzalkiDobrejJakosci = new Item
            {
                Name = "Butelka gorzałki dobrej jakości",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Low,
                Weight = 5,
                ItemType = ItemType.Food
            };
            var winoPospolite = new Item
            {
                Name = "Wino pospolite",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Average,
                Weight = 5,
                ItemType = ItemType.Food
            };
            var winoSzlacheckie = new Item
            {
                Name = "Wino szlacheckie",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.Low,
                Weight = 5,
                ItemType = ItemType.Food
            };
            var buklak = new Item
            {
                Name = "Bukłak",
                Price = MoneyCalculator.GetUserMoney(0, 8, 0),
                Rarity = ItemRarity.High,
                Weight = 1,
                ItemType = ItemType.Containers
            };
            var flaszka = new Item
            {
                Name = "Flaszka",
                Price = MoneyCalculator.GetUserMoney(0, 4, 0),
                Rarity = ItemRarity.High,
                Weight = 10,
                ItemType = ItemType.Containers
            };
            var juki = new Item
            {
                Name = "Juki",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 5,
                ItemType = ItemType.Containers
            };
            var kuferek = new Item
            {
                Name = "Kuferek",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 40,
                ItemType = ItemType.Containers
            };
            var manierkaMetalowa = new Item
            {
                Name = "Manierka metalowa",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 15,
                ItemType = ItemType.Containers
            };
            var manierkaSkorzana = new Item
            {
                Name = "Manierska skórzana",
                Price = MoneyCalculator.GetUserMoney(0, 15, 0),
                Rarity = ItemRarity.Low,
                Weight = 5,
                ItemType = ItemType.Containers
            };
            var mieszek = new Item
            {
                Name = "Mieszek",
                Price = MoneyCalculator.GetUserMoney(0, 2, 0),
                Rarity = ItemRarity.High,
                Weight = 1,
                ItemType = ItemType.Containers
            };
            var plecak = new Item
            {
                Name = "Plecak",
                Price = MoneyCalculator.GetUserMoney(0, 30, 0),
                Rarity = ItemRarity.High,
                Weight = 20,
                ItemType = ItemType.Containers
            };
            var sakiewka = new Item
            {
                Name = "Sakiewka",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.High,
                Weight = 1,
                ItemType = ItemType.Containers
            };
            var tobolek = new Item
            {
                Name = "Tobołek",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 5,
                ItemType = ItemType.Containers
            };
            var tubaNaMapy = new Item
            {
                Name = "Tuba na mapy/pergaminy",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 2,
                ItemType = ItemType.Containers
            };
            var worek = new Item
            {
                Name = "Worek",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.High,
                Weight = 7,
                ItemType = ItemType.Containers
            };
            var drewnoNaOpal = new Item
            {
                Name = "Drewno na opał",
                Price = MoneyCalculator.GetUserMoney(0, 2, 0),
                Rarity = ItemRarity.High,
                Weight = 5,
                ItemType = ItemType.Light
            };
            var kaganek = new Item
            {
                Name = "Kaganek",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.High,
                Weight = 20,
                ItemType = ItemType.Light
            };
            var latarnia = new Item
            {
                Name = "Latarnia",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 20,
                ItemType = ItemType.Light
            };
            var latarniaSztormowa = new Item
            {
                Name = "Latarnia sztormowa",
                Price = MoneyCalculator.GetUserMoney(12, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 30,
                ItemType = ItemType.Light
            };
            var olejDoLatarni = new Item
            {
                Name = "Olej do latarni",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.High,
                Weight = 5,
                ItemType = ItemType.Light
            };
            var pochodnia = new Item
            {
                Name = "Pochodnia",
                Price = MoneyCalculator.GetUserMoney(0, 0, 5),
                Rarity = ItemRarity.High,
                Weight = 5,
                ItemType = ItemType.Light
            };
            var swieczkaLojowa = new Item
            {
                Name = "Świeczka łojowa",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.High,
                Weight = 5,
                ItemType = ItemType.Light
            };
            var swieczkaWoskowa = new Item
            {
                Name = "Świeczka woskowa",
                Price = MoneyCalculator.GetUserMoney(0, 6, 0),
                Rarity = ItemRarity.Low,
                Weight = 5,
                ItemType = ItemType.Light
            };
            var zapalka = new Item
            {
                Name = "Zapałka",
                Price = MoneyCalculator.GetUserMoney(0, 0, 1),
                Rarity = ItemRarity.Low,
                Weight = 0,
                ItemType = ItemType.Light
            };
            var zlotaKorona = new Item
            {
                Name = "Zlota korona",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 0,
                ItemType = ItemType.Utility
            };
            var pens = new Item
            {
                Name = "Pens",
                Price = MoneyCalculator.GetUserMoney(0, 0, 1),
                Rarity = ItemRarity.Common,
                Weight = 0,
                ItemType = ItemType.Utility
            };
            var szyling = new Item
            {
                Name = "Szyling",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Utility
            };
            var drabina = new Item
            {
                Name = "Drabina",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.Average,
                Weight = 50,
                ItemType = ItemType.Utility
            };
            var hubkaIKrzesiwo = new Item
            {
                Name = "Hubka i krzesiwo",
                Price = MoneyCalculator.GetUserMoney(0, 30, 0),
                Rarity = ItemRarity.High,
                Weight = 5,
                ItemType = ItemType.Utility
            };
            var imbryk = new Item
            {
                Name = "Imbryk",
                Price = MoneyCalculator.GetUserMoney(0, 30, 0),
                Rarity = ItemRarity.High,
                Weight = 10,
                ItemType = ItemType.Utility
            };
            var instrumentMuzyczny = new Item
            {
                Name = "Instrument muzyczny",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 5,
                ItemType = ItemType.Utility
            };
            var klodkaDobrejJakosci = new Item
            {
                Name = "Kłódka dobrej jakości",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 5,
                ItemType = ItemType.Utility
            };
            var klodkaZwyklejJakosci = new Item
            {
                Name = "Kłódka zwykłej jakości",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 5,
                ItemType = ItemType.Utility
            };
            var koc = new Item
            {
                Name = "Koc",
                Price = MoneyCalculator.GetUserMoney(0, 25, 0),
                Rarity = ItemRarity.High,
                Weight = 10,
                ItemType = ItemType.Utility
            };
            var kociolek = new Item
            {
                Name = "Kociołek",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 20,
                ItemType = ItemType.Utility
            };
            var kosciDoGry = new Item
            {
                Name = "Kości do gry",
                Price = MoneyCalculator.GetUserMoney(0, 6, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Utility
            };
            var kufelDrewniany = new Item
            {
                Name = "Kufel drewniany",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.High,
                Weight = 5,
                ItemType = ItemType.Utility
            };
            var kufelZeSzklaBarwionego = new Item
            {
                Name = "Kufel ze szkła barwionego",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 5,
                ItemType = ItemType.Utility
            };
            var lina = new Item
            {
                Name = "Lina",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 50,
                ItemType = ItemType.Utility
            };
            var luneta = new Item
            {
                Name = "Luneta",
                Price = MoneyCalculator.GetUserMoney(100, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 5,
                ItemType = ItemType.Utility
            };
            var lustro = new Item
            {
                Name = "Lustro",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 5,
                ItemType = ItemType.Utility
            };
            var namiot = new Item
            {
                Name = "Namiot",
                Price = MoneyCalculator.GetUserMoney(0, 15, 0),
                Rarity = ItemRarity.Average,
                Weight = 20,
                ItemType = ItemType.Utility
            };
            var papier = new Item
            {
                Name = "Papier",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Utility
            };
            var perfumy = new Item
            {
                Name = "Perfumy",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 0,
                ItemType = ItemType.Utility
            };
            var pergamin = new Item
            {
                Name = "Pergamin",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.Rare,
                Weight = 0,
                ItemType = ItemType.Utility
            };
            var symbolReligijny = new Item
            {
                Name = "Symbol religijny",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 5,
                ItemType = ItemType.Utility
            };
            var sztucceDrewniane = new Item
            {
                Name = "Sztućce drewniane",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.High,
                Weight = 2,
                ItemType = ItemType.Utility
            };
            var sztucceMetalowe = new Item
            {
                Name = "Sztućce metalowe",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 4,
                ItemType = ItemType.Utility
            };
            var sztucceSrebrne = new Item
            {
                Name = "Sztućce srebrne",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 3,
                ItemType = ItemType.Utility
            };
            var taliaKart = new Item
            {
                Name = "Talia kart",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 1,
                ItemType = ItemType.Utility
            };
            var drag = new Item
            {
                Name = "Drąg, cena za metr",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.High,
                Weight = 10,
                ItemType = ItemType.Tools
            };
            var drewnianyKlin = new Item
            {
                Name = "Drewniany klin",
                Price = MoneyCalculator.GetUserMoney(0, 0, 8),
                Rarity = ItemRarity.High,
                Weight = 2,
                ItemType = ItemType.Tools
            };
            var haczykNaRyby = new Item
            {
                Name = "Haczyk na ryby i żyłka",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Average,
                Weight = 2,
                ItemType = ItemType.Tools
            };
            var kajdany = new Item
            {
                Name = "Kajdany",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 20,
                ItemType = ItemType.Tools
            };
            var kilof = new Item
            {
                Name = "Kilof",
                Price = MoneyCalculator.GetUserMoney(0, 25, 0),
                Rarity = ItemRarity.Low,
                Weight = 20,
                ItemType = ItemType.Tools
            };
            var kolki = new Item
            {
                Name = "Kołki",
                Price = MoneyCalculator.GetUserMoney(0, 5, 0),
                Rarity = ItemRarity.Average,
                Weight = 5,
                ItemType = ItemType.Tools
            };
            var kotwiczkaDoWspinaczki = new Item
            {
                Name = "Kotwiczka do wspinaczki",
                Price = MoneyCalculator.GetUserMoney(4, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 20,
                ItemType = ItemType.Tools
            };
            var ksiazkaDrukowana = new Item
            {
                Name = "Książka drukowana",
                Price = MoneyCalculator.GetUserMoney(100, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 35,
                ItemType = ItemType.Tools
            };
            var ksiazkaIlustrowana = new Item
            {
                Name = "Książka ilustrowana",
                Price = MoneyCalculator.GetUserMoney(350, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 50,
                ItemType = ItemType.Tools
            };
            var liczydlo = new Item
            {
                Name = "Liczydło",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 5,
                ItemType = ItemType.Tools
            };
            var lancuch = new Item
            {
                Name = "Łańcuch, cena za metr",
                Price = MoneyCalculator.GetUserMoney(0, 30, 0),
                Rarity = ItemRarity.Rare,
                Weight = 5,
                ItemType = ItemType.Tools
            };
            var lom = new Item
            {
                Name = "Łom",
                Price = MoneyCalculator.GetUserMoney(0, 10, 0),
                Rarity = ItemRarity.Average,
                Weight = 10,
                ItemType = ItemType.Tools
            };
            var lopata = new Item
            {
                Name = "Łopata",
                Price = MoneyCalculator.GetUserMoney(0, 25, 0),
                Rarity = ItemRarity.Average,
                Weight = 20,
                ItemType = ItemType.Tools
            };
            var mlot = new Item
            {
                Name = "Młot",
                Price = MoneyCalculator.GetUserMoney(0, 20, 0),
                Rarity = ItemRarity.Average,
                Weight = 40,
                ItemType = ItemType.Tools
            };
            var narzedzia = new Item
            {
                Name = "Narzędzia",
                Price = MoneyCalculator.GetUserMoney(50, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 50,
                ItemType = ItemType.Tools
            };
            var potrzask = new Item
            {
                Name = "Potrzask",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Average,
                Weight = 2,
                ItemType = ItemType.Tools
            };
            var przyboryDoPisania = new Item
            {
                Name = "Przybory do pisania",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 5,
                ItemType = ItemType.Tools
            };
            var sztabkaMetalu = new Item
            {
                Name = "Sztabka metalu",
                Price = MoneyCalculator.GetUserMoney(0, 25, 0),
                Rarity = ItemRarity.Low,
                Weight = 20,
                ItemType = ItemType.Tools
            };
            var wnyki = new Item
            {
                Name = "Wnyki",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 20,
                ItemType = ItemType.Tools
            };
            var wytrychy = new Item
            {
                Name = "Wytrychy",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 20,
                ItemType = ItemType.Tools
            };
            var zestawDoCharakteryzacji = new Item
            {
                Name = "Zestaw do charakteryzacji",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 10,
                ItemType = ItemType.Tools
            };
            var wozek = new Item
            {
                Name = "Wózek",
                Price = MoneyCalculator.GetUserMoney(50, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 0,
                ItemType = ItemType.Wehicles
            };
            var woz = new Item
            {
                Name = "Wóz",
                Price = MoneyCalculator.GetUserMoney(90, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 0,
                ItemType = ItemType.Wehicles
            };
            var powoz = new Item
            {
                Name = "Powóz",
                Price = MoneyCalculator.GetUserMoney(500, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 0,
                ItemType = ItemType.Wehicles
            };
            var lodzRzeczna = new Item
            {
                Name = "Łódź rzeczna",
                Price = MoneyCalculator.GetUserMoney(600, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 0,
                ItemType = ItemType.Wehicles
            };
            var lodzWioslowa = new Item
            {
                Name = "Łódź wiosłowa",
                Price = MoneyCalculator.GetUserMoney(90, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 900,
                ItemType = ItemType.Wehicles
            };
            var statek = new Item
            {
                Name = "Statek",
                Price = MoneyCalculator.GetUserMoney(12000, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 0,
                ItemType = ItemType.Wehicles
            };
            var rumak = new Item
            {
                Name = "Rumak",
                Price = MoneyCalculator.GetUserMoney(500, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 0,
                ItemType = ItemType.Wehicles
            };
            var lekkiKonBojowy = new Item
            {
                Name = "Lekki koń bojowy",
                Price = MoneyCalculator.GetUserMoney(300, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 0,
                ItemType = ItemType.Wehicles
            };
            var kon = new Item
            {
                Name = "Koń",
                Price = MoneyCalculator.GetUserMoney(80, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 0,
                ItemType = ItemType.Wehicles
            };
            var kuc = new Item
            {
                Name = "Kuc",
                Price = MoneyCalculator.GetUserMoney(50, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 0,
                ItemType = ItemType.Wehicles
            };
            var siodlo = new Item
            {
                Name = "Siodło",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 50,
                ItemType = ItemType.Wehicles
            };
            var uprzaz = new Item
            {
                Name = "Uprząż",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 20,
                ItemType = ItemType.Wehicles
            };
            var golabPocztowy = new Item
            {
                Name = "Gołąb pocztowy",
                Price = MoneyCalculator.GetUserMoney(1, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var jastrzab = new Item
            {
                Name = "Jastrząb",
                Price = MoneyCalculator.GetUserMoney(80, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var konJuczny = new Item
            {
                Name = "Koń juczny",
                Price = MoneyCalculator.GetUserMoney(40, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var konPociagowyLubMul = new Item
            {
                Name = "Koń pociągowy lub muł",
                Price = MoneyCalculator.GetUserMoney(25, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var kot = new Item
            {
                Name = "Kot",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var koza = new Item
            {
                Name = "Koza",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var krowa = new Item
            {
                Name = "Krowa",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var kurczak = new Item
            {
                Name = "Kurczak",
                Price = MoneyCalculator.GetUserMoney(0, 0, 5),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var owca = new Item
            {
                Name = "Owca",
                Price = MoneyCalculator.GetUserMoney(2, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var pies = new Item
            {
                Name = "Pies (rasowy)",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var piesBojowy = new Item
            {
                Name = "Pies bojowy",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var swinia = new Item
            {
                Name = "Świnia",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var wol = new Item
            {
                Name = "Wół",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.High,
                Weight = 0,
                ItemType = ItemType.Animals
            };
            var darGrety = new Item
            {
                Name = "Dar Grety",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var miksturaLecznicza = new Item
            {
                Name = "Mikstura lecznicza",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var piwoBugmana = new Item
            {
                Name = "Piwo Bugmana",
                Price = MoneyCalculator.GetUserMoney(50, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 5,
                ItemType = ItemType.Special
            };
            var czarnyJad = new Item
            {
                Name = "Czarny Jad",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var czarnyLotos = new Item
            {
                Name = "Czarny lotos",
                Price = MoneyCalculator.GetUserMoney(20, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var grzybkiSzalonegoKapelusznika = new Item
            {
                Name = "Grzybki Szalonego Kapelusznika",
                Price = MoneyCalculator.GetUserMoney(30, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var jadMantikory = new Item
            {
                Name = "Jad mantikory",
                Price = MoneyCalculator.GetUserMoney(65, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var korzenMandragory = new Item
            {
                Name = "Korzeń mandragory",
                Price = MoneyCalculator.GetUserMoney(25, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var sercoBoj = new Item
            {
                Name = "Sercobój",
                Price = MoneyCalculator.GetUserMoney(800, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var szkarlatnyCien = new Item
            {
                Name = "Szkarłatny Cień",
                Price = MoneyCalculator.GetUserMoney(35, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var slinaChimery = new Item
            {
                Name = "Ślina chimery",
                Price = MoneyCalculator.GetUserMoney(150, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var ksiegaWiedzyTajemnej = new Item
            {
                Name = "Księga wiedzy tajemnej",
                Price = MoneyCalculator.GetUserMoney(500, 0, 0),
                Rarity = ItemRarity.Insignificant,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var naparKojacy = new Item
            {
                Name = "Napar kojący",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Average,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var odtrutki = new Item
            {
                Name = "Odtrutki",
                Price = MoneyCalculator.GetUserMoney(3, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var relikwia = new Item
            {
                Name = "Relikwia",
                Price = MoneyCalculator.GetUserMoney(5, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var talizmanSzczescia = new Item
            {
                Name = "Talizman szczęścia",
                Price = MoneyCalculator.GetUserMoney(15, 0, 0),
                Rarity = ItemRarity.Low,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var wodaSwiecona = new Item
            {
                Name = "Woda święcona",
                Price = MoneyCalculator.GetUserMoney(10, 0, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var dlonWeterana = new Item
            {
                Name = "Dłoń weterana",
                Price = MoneyCalculator.GetUserMoney(60, 0, 0),
                Rarity = ItemRarity.Rare,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var drewnianeZeby = new Item
            {
                Name = "Drewniane zęby",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Low,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var kolczyk = new Item
            {
                Name = "Kolczyk",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Average,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var opaskaNaOko = new Item
            {
                Name = "Opaska na oko",
                Price = MoneyCalculator.GetUserMoney(0, 0, 6),
                Rarity = ItemRarity.Average,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var plytkaCzaszkowa = new Item
            {
                Name = "Płytka czaszkowa",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Low,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var pozlacanyNos = new Item
            {
                Name = "Pozłacany nos",
                Price = MoneyCalculator.GetUserMoney(0, 6, 0),
                Rarity = ItemRarity.Occasional,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var szklaneOko = new Item
            {
                Name = "Szklane oko",
                Price = MoneyCalculator.GetUserMoney(0, 1, 0),
                Rarity = ItemRarity.Low,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var sztucznaNoga = new Item
            {
                Name = "Sztuczna noga",
                Price = MoneyCalculator.GetUserMoney(0, 6, 0),
                Rarity = ItemRarity.Low,
                Weight = 0,
                ItemType = ItemType.Special
            };
            var tatuaz = new Item
            {
                Name = "Tatuaż",
                Price = MoneyCalculator.GetUserMoney(0, 3, 0),
                Rarity = ItemRarity.Low,
                Weight = 0,
                ItemType = ItemType.Special
            };

            #endregion items

            #region abilities

            //Abilities
            var artylerzysta = new Ability
            {
                Name = "Artylerzysta",
                Type = BuiltInAbilities.Gunner
            };
            var bardzoSilny = new Ability
            {
                Name = "Bardzo silny",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Stamina,
                IsStartingValue = true,
                Type = BuiltInAbilities.Strong
            };
            var bardzoSzybki = new Ability
            {
                Name = "Bardzo szybki",
                HasImpactOnStatictics = true,
                ImpactValue = 1,
                ValueToAlter = StatisticType.Speed,
                IsStartingValue = true,
                Type = BuiltInAbilities.Fast
            };
            var bijatyka = new Ability
            {
                Name = "Bijatyka",
                Type = BuiltInAbilities.Fight
            };
            var blyskawicznePrzeladowanie = new Ability
            {
                Name = "Błyskawiczne przeładowanie",
                Type = BuiltInAbilities.InstantReload
            };
            var blyskawicznyBlok = new Ability
            {
                Name = "Błyskawiczny blok",
                Type = BuiltInAbilities.InstantBlock
            };
            var blyskotliwosc = new Ability
            {
                Name = "Błyskotliwość",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Inteligence,
                IsStartingValue = true,
                Type = BuiltInAbilities.Brilliance
            };
            var brawura = new Ability
            {
                Name = "Brawura",
                Type = BuiltInAbilities.Recklessness
            };
            var bronNaturalna = new Ability
            {
                Name = "Broń naturalna",
                Type = BuiltInAbilities.NaturalWeapon
            };
            var bronSpecjalna = new Ability
            {
                Name = "Broń specjalna",
                Type = BuiltInAbilities.SpecialWeapon
            };
            var bystryWzrok = new Ability
            {
                Name = "Bystry wzrok",
                IsStartingValue = true,
                Type = BuiltInAbilities.SharpEyesight
            };
            var charyzmatyczny = new Ability
            {
                Name = "Charyzmatyczny",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Polish,
                IsStartingValue = true,
                Type = BuiltInAbilities.Charismatic
            };
            var chirurgia = new Ability
            {
                Name = "Chirurgia",
                Type = BuiltInAbilities.Surgery
            };
            var chodu = new Ability
            {
                Name = "Chodu!",
                Type = BuiltInAbilities.Gait
            };
            var czarnoksiestwo = new Ability
            {
                Name = "Czarnoksięstwo",
                Type = BuiltInAbilities.Sorcery
            };
            var czlowiekGuma = new Ability
            {
                Name = "Człowiek-guma",
                Type = BuiltInAbilities.Rubberman
            };
            var czulySluch = new Ability
            {
                Name = "Czuły słuch",
                IsStartingValue = true,
                Type = BuiltInAbilities.SensitiveHearing
            };
            var dotykMocy = new Ability
            {
                Name = "Dotyk mocy",
                Type = BuiltInAbilities.TouchOfPower
            };
            var bardzoWytrzymaly = new Ability
            {
                Name = "Bardzo wytrzymały",
                Type = BuiltInAbilities.Durable
            };
            var odpornosc = new Ability
            {
                Name = "Odporność",
                Type = BuiltInAbilities.Resistance
            };
            var etykieta = new Ability
            {
                Name = "Etykieta",
                Type = BuiltInAbilities.Etiquette
            };
            var geniuszArytmetyczny = new Ability
            {
                Name = "Geniusz arytmetyczny",
                IsStartingValue = true,
                Type = BuiltInAbilities.ArithmeticGenius
            };
            var grotolaz = new Ability
            {
                Name = "Grotołaz",
                Type = BuiltInAbilities.Speleologist
            };
            var grozny = new Ability
            {
                Name = "Groźny",
                Type = BuiltInAbilities.Dangerous
            };
            var gusla = new Ability
            {
                Name = "Gusła",
                Type = BuiltInAbilities.Witchcraft
            };
            var intrygant = new Ability
            {
                Name = "Intrygant",
                Type = BuiltInAbilities.Schemer
            };
            var krasnoludzkiFach = new Ability
            {
                Name = "Krasnoludzki fach",
                Type = BuiltInAbilities.DwarvenExpert
            };
            var krasomostwo = new Ability
            {
                Name = "Krasomówstwo",
                Type = BuiltInAbilities.Oratory
            };
            var krzepki = new Ability
            {
                Name = "Krzepki",
                IsStartingValue = true,
                Type = BuiltInAbilities.Robust
            };
            var latanie = new Ability
            {
                Name = "Latanie",
                Type = BuiltInAbilities.Flying
            };
            var lewitacja = new Ability
            {
                Name = "Lewitacja",
                Type = BuiltInAbilities.Levitation
            };
            var lotrzyk = new Ability
            {
                Name = "Łotrzyk",
                Type = BuiltInAbilities.Rogue
            };
            var magiaCzarnoksieska = new Ability
            {
                Name = "Magia czarnoksięska",
                Type = BuiltInAbilities.SorcerersMagic
            };
            var magiaKaplanska = new Ability
            {
                Name = "Magia kapłańska",
                Type = BuiltInAbilities.PriesthoodMagic
            };
            var magiaPowszechna = new Ability
            {
                Name = "Magia powszechna",
                Type = BuiltInAbilities.UniversalMagic
            };
            var magiaProsta = new Ability
            {
                Name = "Magia prosta",
                Type = BuiltInAbilities.SimpleMagic
            };
            var magiaTajemna = new Ability
            {
                Name = "Magia tajemna",
                Type = BuiltInAbilities.ArcaneMagic
            };
            var medytacja = new Ability
            {
                Name = "Medytacja",
                Type = BuiltInAbilities.Meditation
            };
            var morderczyAtak = new Ability
            {
                Name = "Morderczy atak",
                Type = BuiltInAbilities.MurderousAttack
            };
            var morderczyPocisk = new Ability
            {
                Name = "Morderczy pocisk",
                Type = BuiltInAbilities.DeadlyBullet
            };
            var nasladowca = new Ability
            {
                Name = "Naśladowca",
                IsStartingValue = true,
                Type = BuiltInAbilities.Imitator
            };
            var niepokojacy = new Ability
            {
                Name = "Niepokojący",
                Type = BuiltInAbilities.Worriesome
            };
            var nieustraszony = new Ability
            {
                Name = "Nieustraszony",
                Type = BuiltInAbilities.Fearless
            };
            var niezwykleOdporny = new Ability
            {
                Name = "Niezwykle odporny",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Resistance,
                IsStartingValue = true,
                Type = BuiltInAbilities.ExtremelyResistant
            };
            var obiezyswiat = new Ability
            {
                Name = "Obieżyświat",
                Type = BuiltInAbilities.Globetrotter
            };
            var oburecznosc = new Ability
            {
                Name = "Oburęczność",
                IsStartingValue = true,
                Type = BuiltInAbilities.Ambidexterity
            };
            var odpornoscNaChaos = new Ability
            {
                Name = "Odpornosc na Chaos",
                Type = BuiltInAbilities.ChaosResistance
            };
            var odpornoscNaChoroby = new Ability
            {
                Name = "Odpornosc na choroby",
                IsStartingValue = true,
                Type = BuiltInAbilities.DiseaseResistance
            };
            var odpornoscNaMagie = new Ability
            {
                Name = "Odpornosc na magię",
                IsStartingValue = true,
                Type = BuiltInAbilities.MagicResistance
            };
            var odpornoscNaTrucizny = new Ability
            {
                Name = "Odpornosc na trucizny",
                IsStartingValue = true,
                Type = BuiltInAbilities.PoisionResistance
            };
            var odpornoscPsychiczna = new Ability
            {
                Name = "Odpornosc psychiczna",
                IsStartingValue = true,
                Type = BuiltInAbilities.MentalResistance
            };
            var odwaga = new Ability
            {
                Name = "Odwaga",
                Type = BuiltInAbilities.Courage
            };
            var ogluszanie = new Ability
            {
                Name = "Ogłuszanie",
                Type = BuiltInAbilities.Stunning
            };
            var opanowanie = new Ability
            {
                Name = "Opanowanie",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Willpower,
                IsStartingValue = true,
                Type = BuiltInAbilities.SelfControl
            };
            var ozywieniec = new Ability
            {
                Name = "Ożywieniec",
                Type = BuiltInAbilities.Undead
            };
            var pancerzWiary = new Ability
            {
                Name = "Pancerz wiary",
                Type = BuiltInAbilities.ArmorOfFaith
            };
            var poliglota = new Ability
            {
                Name = "Poliglota",
                Type = BuiltInAbilities.Polyglot
            };
            var przemawianie = new Ability
            {
                Name = "Przemawianie",
                Type = BuiltInAbilities.Speaking
            };
            var przerazajacy = new Ability
            {
                Name = "Przerażajacy",
                Type = BuiltInAbilities.Frightening
            };
            var rozbrojenie = new Ability
            {
                Name = "rozbrojenie",
                Type = BuiltInAbilities.Disarmament
            };
            var silnyCios = new Ability
            {
                Name = "Silny cios",
                Type = BuiltInAbilities.StrongBlow
            };
            var straszny = new Ability
            {
                Name = "Straszny",
                Type = BuiltInAbilities.Horrible
            };
            var strzalMierzony = new Ability
            {
                Name = "Strzał mierzony",
                Type = BuiltInAbilities.MeasuredShot
            };
            var strzalPrecyzyjny = new Ability
            {
                Name = "Strzał precyzyjny",
                Type = BuiltInAbilities.PrecisionShot
            };
            var strzalPrzebijajacy = new Ability
            {
                Name = "Strzał przebijający",
                Type = BuiltInAbilities.PiercingShot
            };
            var strzelecWyborowy = new Ability
            {
                Name = "Strzelec wyborowy",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Shooting,
                IsStartingValue = true,
                Type = BuiltInAbilities.Sharpshooter
            };
            var szalBojowy = new Ability
            {
                Name = "Szał bojowy",
                Type = BuiltInAbilities.BattleFrenzy
            };
            var szczescie = new Ability
            {
                Name = "Szczęście",
                IsStartingValue = true,
                Type = BuiltInAbilities.Luck
            };
            var szostyZmysl = new Ability
            {
                Name = "Szósty zmysł",
                IsStartingValue = true,
                Type = BuiltInAbilities.SixthSense
            };
            var szybkiRefleks = new Ability
            {
                Name = "Szybki refleks",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.Agility,
                IsStartingValue = true,
                Type = BuiltInAbilities.QuickReflexes
            };
            var szybkieWyciagniecie = new Ability
            {
                Name = "Szybkie wyciągnięcie",
                Type = BuiltInAbilities.QucikPullout
            };
            var talentArtystyczny = new Ability
            {
                Name = "Talent artystyczny",
                Type = BuiltInAbilities.ArtisticTalent
            };
            var twardziel = new Ability
            {
                Name = "Twardziel",
                HasImpactOnStatictics = true,
                ImpactValue = 1,
                ValueToAlter = StatisticType.Hitpoints,
                IsStartingValue = true,
                Type = BuiltInAbilities.Tough
            };
            var ulicznik = new Ability
            {
                Name = "Ulicznik",
                Type = BuiltInAbilities.Nipper
            };
            var urodzonyWojownik = new Ability
            {
                Name = "Urodzony wojownik",
                HasImpactOnStatictics = true,
                ImpactValue = 5,
                ValueToAlter = StatisticType.CloseCombat,
                IsStartingValue = true,
                Type = BuiltInAbilities.BornWarrior
            };
            var wedrowiec = new Ability
            {
                Name = "Wędrowiec",
                Type = BuiltInAbilities.Wanderer
            };
            var widzenieWCiemnosci = new Ability
            {
                Name = "Widzenie w ciemności",
                IsStartingValue = true,
                Type = BuiltInAbilities.SeeingInTheDark
            };
            var woltyzerka = new Ability
            {
                Name = "Woltyżerka",
                Type = BuiltInAbilities.EquestrianVaulting
            };
            var wyczucieKierunku = new Ability
            {
                Name = "Wyczucie kierunku",
                Type = BuiltInAbilities.SenseOfDirection
            };
            var wykrywaniePulapek = new Ability
            {
                Name = "Wykrywanie pułapek",
                Type = BuiltInAbilities.TrapDetection
            };
            var wyostrzoneZmysly = new Ability
            {
                Name = "Wyostrzone zmysły",
                Type = BuiltInAbilities.SharpSenses
            };
            var zapasy = new Ability
            {
                Name = "Zapasy",
                Type = BuiltInAbilities.Wrestling
            };
            var zapieklaNienawisc = new Ability
            {
                Name = "Zapiekła nienawiść",
                Type = BuiltInAbilities.Hatred
            };
            var zmyslMagii = new Ability
            {
                Name = "Zmysł magii",
                Type = BuiltInAbilities.SenseOfMagic
            };
            var zylkaHandlowa = new Ability
            {
                Name = "Żyłka handlowa",
                Type = BuiltInAbilities.CommercialFishingLine
            };

            #endregion abilities

            #region skills

            //Skills
            var charakteryzacja = new Skill
            {
                Name = "Charakteryzacja",
                IsBasicLevel = true,
                Trait = StatisticType.Polish,
                Type = BuiltInSkills.Makeup
            };
            var dowodzenie = new Skill
            {
                Name = "Dowodzenie",
                IsBasicLevel = true,
                Trait = StatisticType.Polish,
                Type = BuiltInSkills.Commanding
            };
            var hazard = new Skill
            {
                Name = "Hazard",
                IsBasicLevel = true,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.Gambling
            };
            var jezdziectwo = new Skill
            {
                Name = "Jeździectwo",
                IsBasicLevel = true,
                Trait = StatisticType.Agility,
                Type = BuiltInSkills.Horsemanship
            };
            var mocnaGlowa = new Skill
            {
                Name = "Mocna głowa",
                IsBasicLevel = true,
                Trait = StatisticType.Resistance,
                Type = BuiltInSkills.StrongHead
            };
            var opieka = new Skill
            {
                Name = "Opieka nad zwierzętami",
                IsBasicLevel = true,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.AnimalCare
            };
            var plotkowanie = new Skill
            {
                Name = "Plotkowanie",
                IsBasicLevel = true,
                Trait = StatisticType.Polish,
                Type = BuiltInSkills.Gossip
            };
            var plywanie = new Skill
            {
                Name = "Pływanie",
                IsBasicLevel = true,
                Trait = StatisticType.Stamina,
                Type = BuiltInSkills.Swimming
            };
            var powozenie = new Skill
            {
                Name = "Powożenie",
                IsBasicLevel = true,
                Trait = StatisticType.Stamina,
                Type = BuiltInSkills.Carriage
            };
            var przekonywanie = new Skill
            {
                Name = "Przekonywanie",
                IsBasicLevel = true,
                Trait = StatisticType.Polish,
                Type = BuiltInSkills.Convincing
            };
            var przeszukiwanie = new Skill
            {
                Name = "Przeszukiwanie",
                IsBasicLevel = true,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.Searching
            };
            var skradanie = new Skill
            {
                Name = "Skradanie się",
                IsBasicLevel = true,
                Trait = StatisticType.Agility,
                Type = BuiltInSkills.Sneaking
            };
            var spostrzegawczosc = new Skill
            {
                Name = "Spostrzegawczość",
                IsBasicLevel = true,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.Observation
            };
            var sztukaPrzetrwania = new Skill
            {
                Name = "Sztuka przetrwania",
                IsBasicLevel = true,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.TheArtOfSurvival
            };
            var targowanie = new Skill
            {
                Name = "Targowanie",
                IsBasicLevel = true,
                Trait = StatisticType.Polish,
                Type = BuiltInSkills.Bargaining
            };
            var ukrywanieSie = new Skill
            {
                Name = "Ukrywanie się",
                IsBasicLevel = true,
                Trait = StatisticType.Agility,
                Type = BuiltInSkills.Hiding
            };
            var wioslarstwo = new Skill
            {
                Name = "Wioślarstwo",
                IsBasicLevel = true,
                Trait = StatisticType.Stamina,
                Type = BuiltInSkills.Rowing
            };
            var wspinaczka = new Skill
            {
                Name = "Wspinaczka",
                IsBasicLevel = true,
                Trait = StatisticType.Stamina,
                Type = BuiltInSkills.Climbing
            };
            var wycena = new Skill
            {
                Name = "Wycena",
                IsBasicLevel = true,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.Valuation
            };
            var zastraszanie = new Skill
            {
                Name = "Zastraszanie",
                IsBasicLevel = true,
                Trait = StatisticType.Stamina,
                Type = BuiltInSkills.Intimidation
            };
            var brzuchomostwo = new Skill
            {
                Name = "Brzuchomówstwo",
                IsBasicLevel = false,
                Trait = StatisticType.Polish,
                Type = BuiltInSkills.Ventriloquism
            };
            var czytaniePisanie = new Skill
            {
                Name = "Czytanie i pisanie",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.ReadingAndWriting
            };
            var czytanieZWarg = new Skill
            {
                Name = "Czytanie z warg",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.LipReading
            };
            var gadanina = new Skill
            {
                Name = "Gadanina",
                IsBasicLevel = false,
                Trait = StatisticType.Polish,
                Type = BuiltInSkills.Talk
            };
            var hipnoza = new Skill
            {
                Name = "Hipnoza",
                IsBasicLevel = false,
                Trait = StatisticType.Willpower,
                Type = BuiltInSkills.Hypnosis
            };
            var leczenie = new Skill
            {
                Name = "Leczenie",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.Treatment
            };
            var nawigacja = new Skill
            {
                Name = "Nawigacja",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.Navigation
            };
            var oswajanie = new Skill
            {
                Name = "Oswajanie",
                IsBasicLevel = false,
                Trait = StatisticType.Polish,
                Type = BuiltInSkills.Taming
            };
            var otwieranieZamkow = new Skill
            {
                Name = "Otwieranie zamków",
                IsBasicLevel = false,
                Trait = StatisticType.Agility,
                Type = BuiltInSkills.OpeningLocks
            };
            var splatanieMagii = new Skill
            {
                Name = "Splatanie magii",
                IsBasicLevel = false,
                Trait = StatisticType.Stamina,
                Type = BuiltInSkills.MagicEntwining
            };
            var sledzenie = new Skill
            {
                Name = "Śledzenie",
                IsBasicLevel = false,
                Trait = StatisticType.Agility,
                Type = BuiltInSkills.Tracking
            };
            var torturowanie = new Skill
            {
                Name = "Torturowanie",
                IsBasicLevel = false,
                Trait = StatisticType.Polish,
                Type = BuiltInSkills.Torture
            };
            var tresura = new Skill
            {
                Name = "Tresura",
                IsBasicLevel = false,
                Trait = StatisticType.Polish,
                Type = BuiltInSkills.Training
            };
            var tropienie = new Skill
            {
                Name = "Tropienie",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.TracesTracking
            };
            var unik = new Skill
            {
                Name = "Unik",
                IsBasicLevel = false,
                Trait = StatisticType.Agility,
                Type = BuiltInSkills.Dodge
            };
            var warzenieTrucizn = new Skill
            {
                Name = "Warzenie trucizn",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Type = BuiltInSkills.PoisionBrewing
            };
            var wykrywanieMagii = new Skill
            {
                Name = "Wykrywanie magii",
                IsBasicLevel = false,
                Trait = StatisticType.Willpower,
                Type = BuiltInSkills.MagicDetection
            };
            var zastawianiePulapek = new Skill
            {
                Name = "Zastawianie pułapek",
                IsBasicLevel = false,
                Trait = StatisticType.Agility,
                Type = BuiltInSkills.SettingTraps
            };
            var zwinnePalce = new Skill
            {
                Name = "Zwinne palce",
                IsBasicLevel = false,
                Trait = StatisticType.Agility,
                Type = BuiltInSkills.NimbleFingers
            };
            var zelgarstwo = new Skill
            {
                Name = "Żeglarstwo",
                IsBasicLevel = false,
                Trait = StatisticType.Agility,
                Type = BuiltInSkills.Sailing
            };
            var jezyk = new Skill
            {
                Name = "Znajomość języka",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Dictionary = dictValJezyk,
                Type = BuiltInSkills.Language
            };
            var wiedza = new Skill
            {
                Name = "Wiedza",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Dictionary = dictValWiedza,
                Type = BuiltInSkills.Knowledge
            };
            var jezykTajemny = new Skill
            {
                Name = "Język tajemny",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Dictionary = dictValJezykTajemny,
                Type = BuiltInSkills.MisticLanguage
            };
            var kuglarstwo = new Skill
            {
                Name = "Kuglarstwo",
                IsBasicLevel = false,
                Trait = StatisticType.Polish,
                Dictionary = dictValKuglarstwo,
                Type = BuiltInSkills.Prestidigitation
            };
            var nauka = new Skill
            {
                Name = "Nauka",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Dictionary = dictValNauka,
                Type = BuiltInSkills.Science
            };
            var rzemioslo = new Skill
            {
                Name = "Rzemiosło",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Dictionary = dictValRzemioslo,
                Type = BuiltInSkills.Craft
            };
            var sekretneZnaki = new Skill
            {
                Name = "Sekretne znaki",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Dictionary = dictValSekretneZnaki,
                Type = BuiltInSkills.SecretMarks
            };
            var sekretnyJezyk = new Skill
            {
                Name = "Sekretny język",
                IsBasicLevel = false,
                Trait = StatisticType.Inteligence,
                Dictionary = dictValSekretnyJezyk,
                Type = BuiltInSkills.SecretLanguage
            };

            #endregion skills

            #region statistics

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

            #endregion statistics

            #region professions

            var akolita = new ProfessionBuilder()
                .SetBasicValues("Akolita", true, 0, null, "Bohater musi wybrać boga i świątynię. Wybór ten zapewnia dodatkową cechę lub zdolność, wymienioną w opisie kultu")
                .SetStatistics(5, 5, 0, 5, 0, 10, 10, 10, 0, 2, 0, 0, statisticsDataSet);
            var banita = new ProfessionBuilder()
                .SetBasicValues("Banita", true)
                .SetStatistics(10, 10, 0, 0, 10, 5, 0, 0, 1, 2, 0, 0, statisticsDataSet);
            var berserker = new ProfessionBuilder()
                .SetBasicValues("Berserker z norski", true)
                .SetStatistics(15, 0, 10, 10, 0, 0, 10, 0, 0, 2, 0, 0, statisticsDataSet);
            var chlop = new ProfessionBuilder()
                .SetBasicValues("Chłop", true)
                .SetStatistics(5, 5, 5, 10, 5, 0, 5, 0, 0, 2, 0, 0, statisticsDataSet);
            var ciura = new ProfessionBuilder()
                .SetBasicValues("Ciura obozowa", true)
                .SetStatistics(0, 0, 0, 5, 10, 5, 5, 10, 0, 2, 0, 0, statisticsDataSet);
            var cyrkowiec = new ProfessionBuilder()
                .SetBasicValues("Cyrkowiec", true)
                .SetStatistics(5, 10, 0, 0, 10, 0, 5, 10, 0, 2, 0, 0, statisticsDataSet);
            var cyrulik = new ProfessionBuilder()
                .SetBasicValues("Cyrulik", true)
                .SetStatistics(5, 0, 0, 0, 10, 10, 10, 5, 0, 2, 0, 0, statisticsDataSet);
            var fanatyk = new ProfessionBuilder()
                .SetBasicValues("Fanatyk", true)
                .SetStatistics(10, 0, 5, 10, 0, 0, 10, 5, 0, 2, 0, 0, statisticsDataSet);
            var flisak = new ProfessionBuilder()
                .SetBasicValues("Flisak", true)
                .SetStatistics(10, 5, 5, 5, 10, 5, 0, 0, 0, 2, 0, 0, statisticsDataSet);
            var giermek = new ProfessionBuilder()
                .SetBasicValues("Giermek", true)
                .SetStatistics(10, 5, 5, 5, 5, 0, 0, 5, 1, 2, 0, 0, statisticsDataSet);
            var gladiator = new ProfessionBuilder()
                .SetBasicValues("Gladiator", true)
                .SetStatistics(15, 0, 0, 10, 10, 0, 10, 0, 0, 2, 0, 0, statisticsDataSet);
            var goniec = new ProfessionBuilder()
                .SetBasicValues("Goniec", true)
                .SetStatistics(10, 0, 5, 5, 10, 5, 5, 0, 0, 2, 0, 1, statisticsDataSet);
            var gornik = new ProfessionBuilder()
                .SetBasicValues("Górnik", true)
                .SetStatistics(5, 5, 10, 5, 0, 5, 5, 0, 0, 2, 0, 0, statisticsDataSet);
            var guslarz = new ProfessionBuilder()
                .SetBasicValues("Guślarz", true)
                .SetStatistics(0, 0, 0, 5, 5, 5, 10, 10, 0, 2, 1, 0, statisticsDataSet);
            var hiena = new ProfessionBuilder()
                .SetBasicValues("Hiena cmentarna", true)
                .SetStatistics(10, 0, 0, 0, 10, 10, 10, 5, 0, 2, 0, 0, statisticsDataSet);
            var kanciarz = new ProfessionBuilder()
                .SetBasicValues("Kanciarz", true)
                .SetStatistics(5, 5, 0, 0, 10, 5, 5, 10, 0, 2, 0, 0, statisticsDataSet);
            var kozak = new ProfessionBuilder()
                .SetBasicValues("Kozak kislevski", true)
                .SetStatistics(10, 10, 0, 10, 0, 0, 10, 0, 0, 2, 0, 0, statisticsDataSet);
            var lesnik = new ProfessionBuilder()
                .SetBasicValues("Leśnik", true)
                .SetStatistics(10, 0, 10, 0, 5, 0, 10, 0, 0, 3, 0, 0, statisticsDataSet);
            var lowca = new ProfessionBuilder()
                .SetBasicValues("Łowca", true)
                .SetStatistics(0, 15, 0, 5, 10, 5, 0, 0, 0, 3, 0, 0, statisticsDataSet);
            var lowcanagrod = new ProfessionBuilder()
                .SetBasicValues("Łowca nagród", true)
                .SetStatistics(5, 10, 5, 0, 10, 0, 5, 0, 0, 2, 0, 0, statisticsDataSet);
            var mieszczanin = new ProfessionBuilder()
                .SetBasicValues("Mieszczanin", true)
                .SetStatistics(5, 0, 0, 0, 5, 10, 5, 5, 0, 2, 0, 0, statisticsDataSet);
            var mytnik = new ProfessionBuilder()
                .SetBasicValues("Mytnik", true)
                .SetStatistics(10, 5, 5, 10, 5, 0, 5, 0, 0, 2, 0, 0, statisticsDataSet);
            var najemnik = new ProfessionBuilder()
                .SetBasicValues("Najemnik", true)
                .SetStatistics(10, 10, 5, 5, 5, 0, 5, 0, 1, 2, 0, 0, statisticsDataSet);
            var ochotnik = new ProfessionBuilder()
                .SetBasicValues("Ochotnik", true)
                .SetStatistics(10, 5, 5, 5, 10, 0, 0, 0, 0, 2, 0, 0, statisticsDataSet);
            var ochroniarz = new ProfessionBuilder()
                .SetBasicValues("Ochroniarz", true)
                .SetStatistics(10, 0, 5, 5, 5, 0, 0, 0, 1, 3, 0, 0, statisticsDataSet);
            var oprych = new ProfessionBuilder()
                .SetBasicValues("Oprych", true)
                .SetStatistics(10, 0, 5, 5, 0, 0, 5, 5, 1, 2, 0, 0, statisticsDataSet);
            var paz = new ProfessionBuilder()
                .SetBasicValues("Paź", true)
                .SetStatistics(0, 0, 0, 0, 10, 10, 5, 10, 0, 2, 0, 0, statisticsDataSet);
            var podzegacz = new ProfessionBuilder()
                .SetBasicValues("Podżegacz", true)
                .SetStatistics(5, 5, 0, 0, 5, 10, 0, 10, 0, 2, 0, 0, statisticsDataSet);
            var porywacz = new ProfessionBuilder()
                .SetBasicValues("Porywacz zwłok", true)
                .SetStatistics(5, 5, 5, 0, 10, 0, 10, 0, 0, 2, 0, 0, statisticsDataSet);
            var poslaniec = new ProfessionBuilder()
                .SetBasicValues("Posłaniec", true)
                .SetStatistics(5, 5, 0, 5, 10, 5, 5, 0, 0, 2, 0, 0, statisticsDataSet);
            var przemytnik = new ProfessionBuilder()
                .SetBasicValues("Przemytnik", true)
                .SetStatistics(5, 5, 0, 0, 10, 10, 0, 10, 0, 2, 0, 0, statisticsDataSet);
            var przepatrywacz = new ProfessionBuilder()
                .SetBasicValues("Przepatrywacz", true)
                .SetStatistics(5, 10, 0, 0, 10, 10, 5, 0, 0, 2, 0, 0, statisticsDataSet);
            var przewoznik = new ProfessionBuilder()
                .SetBasicValues("Przewoźnik", true)
                .SetStatistics(5, 5, 10, 5, 5, 5, 0, 0, 0, 2, 0, 0, statisticsDataSet);
            var rybak = new ProfessionBuilder()
                .SetBasicValues("Rybak", true)
                .SetStatistics(0, 5, 10, 5, 10, 5, 0, 0, 0, 2, 0, 0, statisticsDataSet);
            var rzecznik = new ProfessionBuilder()
                .SetBasicValues("Rzecznik rodu", true, Race.Human | Race.Dwarf | Race.Halfing)
                .SetStatistics(5, 5, 0, 0, 5, 10, 5, 10, 0, 2, 0, 0, statisticsDataSet);
            var rzemieslnik = new ProfessionBuilder()
                .SetBasicValues("Rzemieślnik", true)
                .SetStatistics(0, 0, 5, 5, 10, 5, 10, 0, 0, 2, 0, 0, statisticsDataSet);
            var rzezimieszek = new ProfessionBuilder()
                .SetBasicValues("Rzezimieszek", true)
                .SetStatistics(10, 0, 10, 0, 10, 0, 10, 0, 1, 2, 0, 0, statisticsDataSet);
            var skryba = new ProfessionBuilder()
                .SetBasicValues("Skryba", true)
                .SetStatistics(0, 0, 0, 0, 10, 10, 10, 5, 0, 2, 0, 0, statisticsDataSet);
            var sluga = new ProfessionBuilder()
                .SetBasicValues("Sługa", true)
                .SetStatistics(5, 0, 5, 0, 10, 5, 10, 5, 0, 2, 0, 0, statisticsDataSet);
            var straznik = new ProfessionBuilder()
                .SetBasicValues("Strażnik", true)
                .SetStatistics(10, 5, 5, 0, 5, 10, 0, 5, 0, 2, 0, 0, statisticsDataSet);
            var straznikDrog = new ProfessionBuilder()
                .SetBasicValues("Strażnik dróg", true)
                .SetStatistics(10, 10, 5, 0, 10, 5, 5, 0, 0, 2, 0, 0, statisticsDataSet);
            var straznikPol = new ProfessionBuilder()
                .SetBasicValues("Strażnik pól", true, Race.Human | Race.Dwarf | Race.Elf)
                .SetStatistics(5, 10, 0, 5, 10, 0, 10, 0, 0, 2, 0, 0, statisticsDataSet);
            var straznikWiezienny = new ProfessionBuilder()
                .SetBasicValues("Strażnik więzienny", true)
                .SetStatistics(10, 0, 10, 10, 0, 0, 5, 0, 0, 3, 0, 0, statisticsDataSet);
            var szczurolap = new ProfessionBuilder()
                .SetBasicValues("Szczurołap", true)
                .SetStatistics(5, 10, 0, 5, 10, 0, 10, 0, 0, 2, 0, 0, statisticsDataSet);
            var szermierz = new ProfessionBuilder()
                .SetBasicValues("Szermierz estalijski", true)
                .SetStatistics(15, 0, 5, 5, 10, 5, 0, 0, 1, 2, 0, 0, statisticsDataSet);
            var szlachcic = new ProfessionBuilder()
                .SetBasicValues("Szlachcic", true)
                .SetStatistics(10, 5, 0, 0, 5, 5, 5, 10, 0, 2, 0, 0, statisticsDataSet);
            var smieciarz = new ProfessionBuilder()
                .SetBasicValues("Śmieciarz", true)
                .SetStatistics(5, 0, 5, 10, 5, 0, 5, 5, 0, 2, 0, 0, statisticsDataSet);
            var tarczownik = new ProfessionBuilder()
                .SetBasicValues("Tarczownik", true, Race.Human | Race.Halfing | Race.Elf)
                .SetStatistics(10, 0, 5, 5, 10, 0, 5, 0, 1, 2, 0, 0, statisticsDataSet);
            var uczen = new ProfessionBuilder()
                .SetBasicValues("Uczeń czarodzieja", true, Race.Dwarf | Race.Halfing)
                .SetStatistics(0, 0, 0, 0, 5, 10, 15, 5, 0, 2, 1, 0, statisticsDataSet);
            var weglarz = new ProfessionBuilder()
                .SetBasicValues("Węglarz", true)
                .SetStatistics(5, 0, 5, 5, 5, 5, 5, 5, 0, 2, 0, 0, statisticsDataSet);
            var wloczykij = new ProfessionBuilder()
                .SetBasicValues("Włóczykij", true)
                .SetStatistics(5, 10, 0, 0, 10, 5, 0, 5, 0, 2, 0, 0, statisticsDataSet);
            var wojownik = new ProfessionBuilder()
                .SetBasicValues("Wojownik klanowy", true, Race.Human | Race.Halfing | Race.Dwarf)
                .SetStatistics(5, 5, 0, 0, 10, 10, 5, 0, 0, 2, 0, 0, statisticsDataSet);
            var woznica = new ProfessionBuilder()
                .SetBasicValues("Woźnica", true)
                .SetStatistics(5, 10, 0, 0, 10, 0, 5, 5, 0, 2, 0, 0, statisticsDataSet);
            var zabojcaTroli = new ProfessionBuilder()
                .SetBasicValues("Zabójca trolli", true, Race.Human | Race.Halfing | Race.Elf)
                .SetStatistics(10, 0, 5, 5, 5, 0, 10, 0, 1, 3, 0, 0, statisticsDataSet);
            var zarzadca = new ProfessionBuilder()
                .SetBasicValues("Zarządca", true)
                .SetStatistics(5, 5, 5, 0, 0, 10, 5, 10, 0, 2, 0, 0, statisticsDataSet);
            var zlodziej = new ProfessionBuilder()
                .SetBasicValues("Złodziej", true)
                .SetStatistics(5, 5, 0, 0, 15, 5, 0, 10, 0, 2, 0, 0, statisticsDataSet);
            var zak = new ProfessionBuilder()
                .SetBasicValues("Żak", true)
                .SetStatistics(0, 0, 0, 0, 10, 10, 5, 10, 0, 2, 0, 0, statisticsDataSet);
            var zeglarz = new ProfessionBuilder()
                .SetBasicValues("Żeglarz", true)
                .SetStatistics(10, 5, 10, 0, 10, 0, 0, 0, 1, 2, 0, 0, statisticsDataSet);
            var zolnierz = new ProfessionBuilder()
                .SetBasicValues("Żołnierz", true)
                .SetStatistics(10, 10, 0, 0, 10, 0, 5, 0, 1, 2, 0, 0, statisticsDataSet);
            var zolnierzOkretowy = new ProfessionBuilder()
                .SetBasicValues("Żołnierz okrętowy", true)
                .SetStatistics(10, 10, 10, 0, 5, 0, 5, 0, 1, 3, 0, 0, statisticsDataSet);
            var arcykaplan = new ProfessionBuilder()
                .SetBasicValues("Arcykapłan", false)
                .SetStatistics(20, 20, 15, 15, 15, 20, 30, 25, 1, 6, 3, 0, statisticsDataSet);
            var arcymag = new ProfessionBuilder()
                .SetBasicValues("Arcymag", false)
                .SetStatistics(15, 15, 5, 15, 20, 35, 40, 20, 0, 5, 4, 0, statisticsDataSet);
            var arystokrata = new ProfessionBuilder()
                .SetBasicValues("Arystokrata", false)
                .SetStatistics(25, 15, 10, 10, 10, 20, 20, 30, 1, 6, 0, 0, statisticsDataSet);
            var bard = new ProfessionBuilder()
                .SetBasicValues("Bard", false)
                .SetStatistics(10, 10, 0, 0, 15, 10, 5, 25, 0, 4, 0, 0, statisticsDataSet);
            var biczownik = new ProfessionBuilder()
                .SetBasicValues("Biczownik", false, 0, null, "Bohater musi posiadać przynajmniej jedną chorobę umysłową")
                .SetStatistics(15, 0, 10, 15, 5, 0, 20, 10, 1, 6, 0, 0, statisticsDataSet);
            var bosman = new ProfessionBuilder()
                .SetBasicValues("Bosman", false)
                .SetStatistics(15, 15, 10, 15, 10, 10, 10, 10, 1, 4, 0, 0, statisticsDataSet);
            var demagog = new ProfessionBuilder()
                .SetBasicValues("Demagog", false)
                .SetStatistics(10, 10, 0, 10, 15, 20, 15, 30, 1, 4, 0, 0, statisticsDataSet);
            var dworzanin = new ProfessionBuilder()
                .SetBasicValues("Dworzanin", false)
                .SetStatistics(5, 5, 0, 0, 10, 20, 20, 20, 0, 4, 0, 0, statisticsDataSet);
            var fechmistrz = new ProfessionBuilder()
                .SetBasicValues("Fechmistrz", false)
                .SetStatistics(40, 40, 25, 25, 30, 0, 20, 0, 2, 8, 0, 0, statisticsDataSet);
            var herold = new ProfessionBuilder()
                .SetBasicValues("Herold", false)
                .SetStatistics(10, 10, 5, 5, 15, 15, 10, 20, 0, 4, 0, 0, statisticsDataSet);
            var herszt = new ProfessionBuilder()
                .SetBasicValues("Herszt banitów", false)
                .SetStatistics(20, 30, 10, 20, 10, 10, 10, 20, 2, 6, 0, 0, statisticsDataSet);
            var inzynier = new ProfessionBuilder()
                .SetBasicValues("Inżynier", false)
                .SetStatistics(10, 15, 5, 5, 10, 20, 10, 0, 0, 4, 0, 0, statisticsDataSet);
            var kapitan = new ProfessionBuilder()
                .SetBasicValues("Kapitan", false)
                .SetStatistics(25, 20, 15, 20, 20, 20, 25, 30, 2, 6, 0, 0, statisticsDataSet);
            var kaplan = new ProfessionBuilder()
                .SetBasicValues("Kapłan", false)
                .SetStatistics(10, 10, 5, 10, 5, 10, 20, 15, 0, 4, 0, 0, statisticsDataSet);
            var karczmarz = new ProfessionBuilder()
                .SetBasicValues("Karczmarz", false)
                .SetStatistics(10, 5, 5, 10, 20, 10, 10, 20, 0, 4, 0, 0, statisticsDataSet);
            var ksiaze = new ProfessionBuilder()
                .SetBasicValues("Książe złodzieji", false)
                .SetStatistics(20, 20, 15, 15, 20, 25, 20, 30, 1, 6, 0, 0, statisticsDataSet);
            var kupiec = new ProfessionBuilder()
                .SetBasicValues("Kupiec", false)
                .SetStatistics(10, 10, 5, 5, 10, 25, 20, 20, 0, 4, 0, 0, statisticsDataSet);
            var lesnyDuch = new ProfessionBuilder()
                .SetBasicValues("Leśny duch", false, Race.Human | Race.Halfing | Race.Dwarf)
                .SetStatistics(20, 30, 15, 15, 25, 20, 20, 0, 2, 6, 0, 0, statisticsDataSet);
            var lowcaCzarownic = new ProfessionBuilder()
                .SetBasicValues("Łowca czarownic", false)
                .SetStatistics(30, 30, 15, 15, 15, 15, 35, 20, 2, 6, 0, 0, statisticsDataSet);
            var lowcaWampirow = new ProfessionBuilder()
                .SetBasicValues("Łowca wampirów", false)
                .SetStatistics(20, 20, 10, 20, 15, 15, 20, 0, 1, 4, 0, 0, statisticsDataSet);
            var majordomus = new ProfessionBuilder()
                .SetBasicValues("Majordomus", false)
                .SetStatistics(10, 10, 10, 10, 0, 30, 20, 25, 0, 4, 0, 0, statisticsDataSet);
            var medyk = new ProfessionBuilder()
                .SetBasicValues("Medyk", false)
                .SetStatistics(0, 0, 10, 10, 15, 30, 20, 15, 0, 4, 0, 0, statisticsDataSet);
            var mistrzCieni = new ProfessionBuilder()
                .SetBasicValues("Mistrz cieni", false)
                .SetStatistics(20, 20, 10, 10, 40, 25, 20, 25, 1, 6, 0, 0, statisticsDataSet);
            var mistrzGildii = new ProfessionBuilder()
                .SetBasicValues("Mistrz gildii", false)
                .SetStatistics(10, 10, 0, 10, 15, 30, 20, 35, 1, 5, 0, 0, statisticsDataSet);
            var mistrzMagii = new ProfessionBuilder()
                .SetBasicValues("Mistrz magii", false)
                .SetStatistics(10, 10, 0, 10, 15, 30, 35, 15, 0, 4, 3, 0, statisticsDataSet);
            var mistrzRzemiosla = new ProfessionBuilder()
                .SetBasicValues("Mistrz rzemiosła", false)
                .SetStatistics(0, 0, 10, 10, 20, 10, 10, 10, 0, 3, 0, 0, statisticsDataSet);
            var mistrzZakonny = new ProfessionBuilder()
                .SetBasicValues("Mistrz zakonny", false)
                .SetStatistics(35, 10, 20, 20, 20, 15, 25, 15, 2, 8, 0, 0, statisticsDataSet);
            var nawigator = new ProfessionBuilder()
                .SetBasicValues("Nawigator", false)
                .SetStatistics(10, 10, 5, 5, 10, 25, 10, 0, 0, 4, 0, 0, statisticsDataSet);
            var odkrywca = new ProfessionBuilder()
                .SetBasicValues("Odkrywca", false)
                .SetStatistics(20, 20, 10, 15, 15, 25, 20, 15, 1, 6, 0, 0, statisticsDataSet);
            var oficer = new ProfessionBuilder()
                .SetBasicValues("Oficer", false)
                .SetStatistics(30, 20, 20, 20, 20, 15, 15, 25, 2, 7, 0, 0, statisticsDataSet);
            var oprawca = new ProfessionBuilder()
                .SetBasicValues("Oprawca", false)
                .SetStatistics(15, 0, 20, 10, 10, 10, 20, 15, 0, 4, 0, 0, statisticsDataSet);
            var paser = new ProfessionBuilder()
                .SetBasicValues("Paser", false)
                .SetStatistics(15, 10, 10, 5, 10, 5, 10, 10, 1, 4, 0, 0, statisticsDataSet);
            var rajtar = new ProfessionBuilder()
                .SetBasicValues("Rajtar", false)
                .SetStatistics(20, 20, 10, 10, 15, 0, 15, 15, 1, 4, 0, 0, statisticsDataSet);
            var reketer = new ProfessionBuilder()
                .SetBasicValues("Reketer", false)
                .SetStatistics(20, 15, 15, 10, 10, 0, 15, 10, 1, 5, 0, 0, statisticsDataSet);
            var rozbojnik = new ProfessionBuilder()
                .SetBasicValues("Rozbójnik", false)
                .SetStatistics(20, 20, 10, 10, 30, 20, 15, 25, 1, 4, 0, 0, statisticsDataSet);
            var rycerz = new ProfessionBuilder()
                .SetBasicValues("Rycerz", false)
                .SetStatistics(25, 0, 15, 15, 15, 5, 15, 5, 1, 4, 0, 0, statisticsDataSet);
            var sierzant = new ProfessionBuilder()
                .SetBasicValues("Sierżant", false)
                .SetStatistics(20, 15, 10, 10, 10, 10, 10, 20, 1, 4, 0, 0, statisticsDataSet);
            var skrytobojca = new ProfessionBuilder()
                .SetBasicValues("Skrytobójca", false)
                .SetStatistics(25, 25, 10, 10, 30, 20, 10, 20, 2, 4, 0, 0, statisticsDataSet);
            var strzelec = new ProfessionBuilder()
                .SetBasicValues("Strzelec", false)
                .SetStatistics(0, 35, 10, 10, 25, 10, 20, 15, 1, 4, 0, 0, statisticsDataSet);
            var szampierz = new ProfessionBuilder()
                .SetBasicValues("Szampierz", false)
                .SetStatistics(35, 0, 15, 15, 20, 10, 15, 0, 2, 6, 0, 0, statisticsDataSet);
            var szarlatan = new ProfessionBuilder()
                .SetBasicValues("Szarlatan", false)
                .SetStatistics(10, 10, 5, 10, 15, 15, 15, 25, 0, 4, 0, 0, statisticsDataSet);
            var szpieg = new ProfessionBuilder()
                .SetBasicValues("Szpieg", false)
                .SetStatistics(15, 15, 5, 10, 20, 20, 35, 20, 1, 4, 0, 0, statisticsDataSet);
            var uczony = new ProfessionBuilder()
                .SetBasicValues("Uczony", false)
                .SetStatistics(5, 5, 5, 5, 10, 30, 15, 15, 0, 4, 0, 0, statisticsDataSet);
            var urzednik = new ProfessionBuilder()
                .SetBasicValues("Urzędnik", false)
                .SetStatistics(5, 5, 5, 10, 0, 20, 10, 20, 0, 4, 0, 0, statisticsDataSet);
            var weteran = new ProfessionBuilder()
                .SetBasicValues("Weteran", false)
                .SetStatistics(20, 20, 10, 10, 15, 0, 15, 0, 1, 6, 0, 0, statisticsDataSet);
            var wedrownyCzarodziej = new ProfessionBuilder()
                .SetBasicValues("Wędrowny czarodziej", false)
                .SetStatistics(5, 5, 0, 5, 10, 20, 25, 10, 0, 3, 2, 0, statisticsDataSet);
            var wlamywacz = new ProfessionBuilder()
                .SetBasicValues("Włamywacz", false)
                .SetStatistics(10, 10, 5, 5, 25, 10, 10, 0, 0, 4, 0, 0, statisticsDataSet);
            var wybraniecBozy = new ProfessionBuilder()
                .SetBasicValues("Wybraniec boży", false)
                .SetStatistics(15, 15, 10, 10, 10, 15, 25, 20, 1, 5, 2, 0, statisticsDataSet);
            var zabojcaDemonow = new ProfessionBuilder()
                .SetBasicValues("Zabójca demonów", false, Race.Elf | Race.Halfing | Race.Human)
                .SetStatistics(40, 0, 30, 30, 20, 0, 30, 0, 2, 8, 0, 0, statisticsDataSet);
            var zabojcaOlbrzymow = new ProfessionBuilder()
                .SetBasicValues("Zabójca olbrzymów", false, Race.Elf | Race.Halfing | Race.Human, null,
                "Bohater musi wcześniej zabić olbrzyma")
                .SetStatistics(25, 0, 15, 15, 10, 0, 20, 0, 1, 6, 0, 0, statisticsDataSet);
            var zakonnik = new ProfessionBuilder()
                .SetBasicValues("Zakonnik", false)
                .SetStatistics(10, 0, 5, 10, 0, 15, 15, 15, 0, 4, 0, 0, statisticsDataSet);
            var zwadzca = new ProfessionBuilder()
                .SetBasicValues("Zwadźca", false)
                .SetStatistics(20, 20, 10, 20, 20, 15, 15, 10, 1, 4, 0, 0, statisticsDataSet);
            var zwiadowca = new ProfessionBuilder()
                .SetBasicValues("Zwiadowca", false)
                .SetStatistics(20, 20, 10, 10, 15, 20, 15, 0, 1, 6, 0, 0, statisticsDataSet);

            #endregion professions

            #region profession items

            akolita.AddEquipment(new ProfessionBuilderItemModel(szaty));
            akolita.AddEquipment(new ProfessionBuilderItemModel(symbolReligijny));

            banita.AddEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            banita.AddEquipment(new ProfessionBuilderItemModel(luk));
            banita.AddEquipment(new ProfessionBuilderItemModel(tarcza));

            berserker.AddEquipment(new ProfessionBuilderItemModel(bronDwureczna), new ProfessionBuilderItemModel(tarcza));
            berserker.AddEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            berserker.AddEquipment(new ProfessionBuilderItemModel(butelkaGorzalki));

            chlop.AddEquipment(new ProfessionBuilderItemModel(proca), new ProfessionBuilderItemModel(kij));
            chlop.AddEquipment(new ProfessionBuilderItemModel(buklak));

            ciura.AddEquipment(new ProfessionBuilderItemModel(talizmanSzczescia), new ProfessionBuilderItemModel(narzedzia));
            ciura.AddEquipment(new ProfessionBuilderItemModel(sakiewka));
            ciura.AddEquipment(new ProfessionBuilderItemModel(namiot));

            cyrkowiec.AddEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            cyrkowiec.AddEquipment(new ProfessionBuilderItemModel(nozDoRzucania, 3), new ProfessionBuilderItemModel(toporDoRzucania, 2));
            cyrkowiec.AddEquipment(new ProfessionBuilderItemModel(instrumentMuzyczny));
            cyrkowiec.AddEquipment(new ProfessionBuilderItemModel(narzedzia));
            cyrkowiec.AddEquipment(new ProfessionBuilderItemModel(kostium), new ProfessionBuilderItemModel(dobreUbranie));

            cyrulik.AddEquipment(new ProfessionBuilderItemModel(narzedzia));

            fanatyk.AddEquipment(new ProfessionBuilderItemModel(korbacz), new ProfessionBuilderItemModel(morgensztern));
            fanatyk.AddEquipment(new ProfessionBuilderItemModel(butelkaGorzalkiDobrejJakosci));
            fanatyk.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));

            flisak.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            flisak.AddEquipment(new ProfessionBuilderItemModel(lodzWioslowa));

            giermek.AddEquipment(new ProfessionBuilderItemModel(lanca));
            giermek.AddEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            giermek.AddEquipment(new ProfessionBuilderItemModel(czepiecKolczy));
            giermek.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            giermek.AddEquipment(new ProfessionBuilderItemModel(kon));
            giermek.AddEquipment(new ProfessionBuilderItemModel(siodlo));
            giermek.AddEquipment(new ProfessionBuilderItemModel(uprzaz));

            gladiator.AddEquipment(new ProfessionBuilderItemModel(korbacz), new ProfessionBuilderItemModel(bronDwureczna));
            gladiator.AddEquipment(new ProfessionBuilderItemModel(kastet));
            gladiator.AddEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            gladiator.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            gladiator.AddEquipment(new ProfessionBuilderItemModel(tarcza), new ProfessionBuilderItemModel(puklerz));

            goniec.AddEquipment(new ProfessionBuilderItemModel(kusza));
            goniec.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            goniec.AddEquipment(new ProfessionBuilderItemModel(miksturaLecznicza));
            goniec.AddEquipment(new ProfessionBuilderItemModel(talizmanSzczescia));

            gornik.AddEquipment(new ProfessionBuilderItemModel(bronDwureczna));
            gornik.AddEquipment(new ProfessionBuilderItemModel(kilof));
            gornik.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            gornik.AddEquipment(new ProfessionBuilderItemModel(lopata));
            gornik.AddEquipment(new ProfessionBuilderItemModel(latarniaSztormowa));
            gornik.AddEquipment(new ProfessionBuilderItemModel(olejDoLatarni));

            guslarz.AddEquipment(new ProfessionBuilderItemModel(miksturaLecznicza));
            guslarz.AddEquipment(new ProfessionBuilderItemModel(plaszcz));
            guslarz.AddEquipment(new ProfessionBuilderItemModel(kapturMaska));

            hiena.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            hiena.AddEquipment(new ProfessionBuilderItemModel(lom));
            hiena.AddEquipment(new ProfessionBuilderItemModel(latarnia));
            hiena.AddEquipment(new ProfessionBuilderItemModel(olejDoLatarni));
            hiena.AddEquipment(new ProfessionBuilderItemModel(lina));
            hiena.AddEquipment(new ProfessionBuilderItemModel(worek, 2));

            kanciarz.AddEquipment(new ProfessionBuilderItemModel(szykowneUbranie), new ProfessionBuilderItemModel(taliaKart));
            kanciarz.AddEquipment(new ProfessionBuilderItemModel(zlotaKorona, 50));

            kozak.AddEquipment(new ProfessionBuilderItemModel(luk));
            lowca.AddEquipment(new ProfessionBuilderItemModel(strzala, 10));
            kozak.AddEquipment(new ProfessionBuilderItemModel(bronDwureczna));
            kozak.AddEquipment(new ProfessionBuilderItemModel(kolczugaKolcza));
            kozak.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            kozak.AddEquipment(new ProfessionBuilderItemModel(nogawiceSkora));

            lesnik.AddEquipment(new ProfessionBuilderItemModel(bronDwureczna));
            lesnik.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            lesnik.AddEquipment(new ProfessionBuilderItemModel(odtrutki));

            lowca.AddEquipment(new ProfessionBuilderItemModel(dlugiLuk));
            lowca.AddEquipment(new ProfessionBuilderItemModel(strzala, 10));
            lowca.AddEquipment(new ProfessionBuilderItemModel(potrzask, 2), new ProfessionBuilderItemModel(wnyki));
            lowca.AddEquipment(new ProfessionBuilderItemModel(odtrutki));

            lowcanagrod.AddEquipment(new ProfessionBuilderItemModel(kusza));
            lowcanagrod.AddEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            lowcanagrod.AddEquipment(new ProfessionBuilderItemModel(helmSkora));
            lowcanagrod.AddEquipment(new ProfessionBuilderItemModel(kajdany));
            lowcanagrod.AddEquipment(new ProfessionBuilderItemModel(lina));
            lowcanagrod.AddEquipment(new ProfessionBuilderItemModel(kajdany));

            mieszczanin.AddEquipment(new ProfessionBuilderItemModel(dobreUbranie));
            mieszczanin.AddEquipment(new ProfessionBuilderItemModel(liczydlo));
            mieszczanin.AddEquipment(new ProfessionBuilderItemModel(latarnia));

            mytnik.AddEquipment(new ProfessionBuilderItemModel(kusza));
            lowca.AddEquipment(new ProfessionBuilderItemModel(belt, 10));
            mytnik.AddEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            mytnik.AddEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            mytnik.AddEquipment(new ProfessionBuilderItemModel(tarcza));
            mytnik.AddEquipment(new ProfessionBuilderItemModel(zlotaKorona, 50));

            najemnik.AddEquipment(new ProfessionBuilderItemModel(kusza));
            najemnik.AddEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            najemnik.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            najemnik.AddEquipment(new ProfessionBuilderItemModel(tarcza));
            najemnik.AddEquipment(new ProfessionBuilderItemModel(miksturaLecznicza));

            ochotnik.AddEquipment(new ProfessionBuilderItemModel(halabarda), new ProfessionBuilderItemModel(luk));
            ochotnik.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            ochotnik.AddEquipment(new ProfessionBuilderItemModel(helmSkora));

            ochroniarz.AddEquipment(new ProfessionBuilderItemModel(toporDoRzucania, 2), new ProfessionBuilderItemModel(nozDoRzucania, 2));
            ochroniarz.AddEquipment(new ProfessionBuilderItemModel(kastet));
            ochroniarz.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            ochroniarz.AddEquipment(new ProfessionBuilderItemModel(puklerz));

            oprych.AddEquipment(new ProfessionBuilderItemModel(kastet));
            oprych.AddEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            oprych.AddEquipment(new ProfessionBuilderItemModel(kaftanSkora));

            paz.AddEquipment(new ProfessionBuilderItemModel(szykowneUbranie, 2));
            paz.AddEquipment(new ProfessionBuilderItemModel(perfumy));
            paz.AddEquipment(new ProfessionBuilderItemModel(mieszek));

            podzegacz.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            podzegacz.AddEquipment(new ProfessionBuilderItemModel(dobreUbranie));

            porywacz.AddEquipment(new ProfessionBuilderItemModel(latarnia));
            porywacz.AddEquipment(new ProfessionBuilderItemModel(olejDoLatarni));
            porywacz.AddEquipment(new ProfessionBuilderItemModel(kilof));
            porywacz.AddEquipment(new ProfessionBuilderItemModel(lopata));
            porywacz.AddEquipment(new ProfessionBuilderItemModel(worek));

            poslaniec.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            poslaniec.AddEquipment(new ProfessionBuilderItemModel(tarcza));
            poslaniec.AddEquipment(new ProfessionBuilderItemModel(kon));
            poslaniec.AddEquipment(new ProfessionBuilderItemModel(siodlo));
            poslaniec.AddEquipment(new ProfessionBuilderItemModel(uprzaz));
            poslaniec.AddEquipment(new ProfessionBuilderItemModel(tubaNaMapy));

            przemytnik.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            przemytnik.AddEquipment(new ProfessionBuilderItemModel(konPociagowyLubMul));
            przemytnik.AddEquipment(new ProfessionBuilderItemModel(woz), new ProfessionBuilderItemModel(lodzWioslowa));
            przemytnik.AddEquipment(new ProfessionBuilderItemModel(woz), new ProfessionBuilderItemModel(pochodnia, 2));

            przepatrywacz.AddEquipment(new ProfessionBuilderItemModel(luk), new ProfessionBuilderItemModel(kusza));
            przepatrywacz.AddEquipment(new ProfessionBuilderItemModel(bicz), new ProfessionBuilderItemModel(arkan));
            przepatrywacz.AddEquipment(new ProfessionBuilderItemModel(siec));
            przepatrywacz.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            przepatrywacz.AddEquipment(new ProfessionBuilderItemModel(tarcza));
            przepatrywacz.AddEquipment(new ProfessionBuilderItemModel(kon));
            przepatrywacz.AddEquipment(new ProfessionBuilderItemModel(siodlo));
            przepatrywacz.AddEquipment(new ProfessionBuilderItemModel(uprzaz));
            przepatrywacz.AddEquipment(new ProfessionBuilderItemModel(lina));

            przewoznik.AddEquipment(new ProfessionBuilderItemModel(kusza), new ProfessionBuilderItemModel(garlacz));
            przewoznik.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));

            rybak.AddEquipment(new ProfessionBuilderItemModel(wlocznia));
            rybak.AddEquipment(new ProfessionBuilderItemModel(siec));
            rybak.AddEquipment(new ProfessionBuilderItemModel(kotwiczkaDoWspinaczki));
            rybak.AddEquipment(new ProfessionBuilderItemModel(lina));

            rzecznik.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            rzecznik.AddEquipment(new ProfessionBuilderItemModel(szykowneUbranie, 2));
            rzecznik.AddEquipment(new ProfessionBuilderItemModel(przyboryDoPisania));

            rzemieslnik.AddEquipment(new ProfessionBuilderItemModel(kaftanSkora));
            rzemieslnik.AddEquipment(new ProfessionBuilderItemModel(zlotaKorona, 50));

            rzezimieszek.AddEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            rzezimieszek.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            rzezimieszek.AddEquipment(new ProfessionBuilderItemModel(tarcza));
            rzezimieszek.AddEquipment(new ProfessionBuilderItemModel(kon));
            rzezimieszek.AddEquipment(new ProfessionBuilderItemModel(siodlo));
            rzezimieszek.AddEquipment(new ProfessionBuilderItemModel(uprzaz));

            skryba.AddEquipment(new ProfessionBuilderItemModel(swieczkaWoskowa, 2));
            skryba.AddEquipment(new ProfessionBuilderItemModel(zapalka, 5));
            skryba.AddEquipment(new ProfessionBuilderItemModel(ksiazkaIlustrowana));
            skryba.AddEquipment(new ProfessionBuilderItemModel(przyboryDoPisania));

            sluga.AddEquipment(new ProfessionBuilderItemModel(dobreUbranie));
            sluga.AddEquipment(new ProfessionBuilderItemModel(manierkaSkorzana));
            sluga.AddEquipment(new ProfessionBuilderItemModel(hubkaIKrzesiwo));
            sluga.AddEquipment(new ProfessionBuilderItemModel(latarniaSztormowa));
            sluga.AddEquipment(new ProfessionBuilderItemModel(olejDoLatarni));

            straznik.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            straznik.AddEquipment(new ProfessionBuilderItemModel(olejDoLatarni));

            straznikDrog.AddEquipment(new ProfessionBuilderItemModel(pistolet));
            straznikDrog.AddEquipment(new ProfessionBuilderItemModel(kaftanKolczy));
            straznikDrog.AddEquipment(new ProfessionBuilderItemModel(kurtaSkora));
            straznikDrog.AddEquipment(new ProfessionBuilderItemModel(tarcza));
            straznikDrog.AddEquipment(new ProfessionBuilderItemModel(lekkiKonBojowy));
            straznikDrog.AddEquipment(new ProfessionBuilderItemModel(siodlo));
            straznikDrog.AddEquipment(new ProfessionBuilderItemModel(uprzaz));
            straznikDrog.AddEquipment(new ProfessionBuilderItemModel(lina));

            straznikPol.AddEquipment(new ProfessionBuilderItemModel(proca));
            straznikPol.AddEquipment(new ProfessionBuilderItemModel(kuc));
            straznikPol.AddEquipment(new ProfessionBuilderItemModel(siodlo));
            straznikPol.AddEquipment(new ProfessionBuilderItemModel(uprzaz));
            straznikPol.AddEquipment(new ProfessionBuilderItemModel(latarnia));
            straznikPol.AddEquipment(new ProfessionBuilderItemModel(olejDoLatarni));
            straznikPol.AddEquipment(new ProfessionBuilderItemModel(lopata));

            #endregion profession items

            #region profession skills

            akolita.AddSkills(czytaniePisanie);
            akolita.AddSkills(leczenie);
            akolita.AddDictionarySkills(nauka, BuiltInDictionaryValues.ScienceAstronomy, BuiltInDictionaryValues.ScienceHistory);
            akolita.AddDictionarySkills(nauka, BuiltInDictionaryValues.ScienceTeology);
            akolita.AddSkills(przekonywanie);
            akolita.AddSkills(spostrzegawczosc);
            akolita.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageClassic);
            akolita.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageOldWorld);
            banita.AddDictionarySkills(opieka, wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            banita.AddDictionarySkills(plotkowanie, sekretneZnaki, BuiltInDictionaryValues.SecretMarksThiefs);
            banita.AddSkills(powozenie, jezdziectwo);
            banita.AddSkills(skradanie);
            banita.AddSkills(spostrzegawczosc);
            banita.AddSkills(ukrywanieSie);
            banita.AddSkills(unik);
            banita.AddSkills(wspinaczka);
            banita.AddSkills(zastawianiePulapek, plywanie);
            berserker.AddDictionarySkills(kuglarstwo, BuiltInDictionaryValues.PrestidigitationStoryTelling);
            berserker.AddSkills(mocnaGlowa);
            berserker.AddSkills(plywanie);
            berserker.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeNorsca);
            berserker.AddSkills(zastraszanie);
            berserker.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageNorsca);
            chlop.AddDictionarySkills(hazard, kuglarstwo, BuiltInDictionaryValues.PrestidigitationDancing, BuiltInDictionaryValues.PrestidigitationSinging);
            chlop.AddSkills(opieka, przekonywanie);
            chlop.AddDictionarySkills(oswajanie, rzemioslo, BuiltInDictionaryValues.CraftCooking);
            chlop.AddDictionarySkills(powozenie, rzemioslo, BuiltInDictionaryValues.CraftBowMaking);
            chlop.AddDictionarySkills(sztukaPrzetrwania, rzemioslo, BuiltInDictionaryValues.CraftTillage);
            chlop.AddSkills(tresura, plywanie);
            chlop.AddSkills(ukrywanieSie);
            chlop.AddSkills(wioslarstwo, zastawianiePulapek);
            chlop.AddSkills(wspinaczka, skradanie);
            ciura.AddSkills(opieka, powozenie);
            ciura.AddSkills(plotkowanie);
            ciura.AddSkills(przekonywanie, wycena);
            ciura.AddSkills(przeszukiwanie);
            ciura.AddDictionarySkills(rzemioslo, BuiltInDictionaryValues.CraftCooking, BuiltInDictionaryValues.CraftTrading, BuiltInDictionaryValues.CraftCartography,
                BuiltInDictionaryValues.CraftBlacksmithing, BuiltInDictionaryValues.CraftTailoring, BuiltInDictionaryValues.CraftArmouring,
                BuiltInDictionaryValues.CraftGunsmithing, BuiltInDictionaryValues.CraftBowMaking, BuiltInDictionaryValues.CraftHerbology);
            ciura.AddSkills(spostrzegawczosc);
            ciura.AddSkills(targowanie);
            ciura.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageBrittany, BuiltInDictionaryValues.LanguageKislev, BuiltInDictionaryValues.LanguageTileanian);
            ciura.AddSkills(zwinnePalce);
            cyrkowiec.AddSkills(kuglarstwo);
            cyrkowiec.AddSkills(opieka, plywanie);
            cyrkowiec.AddSkills(przekonywanie);
            cyrkowiec.AddSkills(spostrzegawczosc);
            cyrkowiec.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            cyrkowiec.AddSkills(wycena, plotkowanie);
            cyrkowiec.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageOldWorld);
            cyrkowiec.AddSkills(brzuchomostwo, gadanina, hipnoza, jezdziectwo, oswajanie, tresura, wspinaczka, zwinnePalce);
            cyrulik.AddSkills(czytaniePisanie);
            cyrulik.AddSkills(leczenie);
            cyrulik.AddSkills(powozenie, plywanie);
            cyrulik.AddSkills(przekonywanie);
            cyrulik.AddDictionarySkills(rzemioslo, BuiltInDictionaryValues.CraftPharmacy);
            cyrulik.AddSkills(spostrzegawczosc);
            cyrulik.AddSkills(targowanie);
            cyrulik.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageBrittany, BuiltInDictionaryValues.LanguageOldWorld, BuiltInDictionaryValues.LanguageTileanian);
            fanatyk.AddSkills(czytaniePisanie);
            fanatyk.AddDictionarySkills(nauka, BuiltInDictionaryValues.ScienceTeology);
            fanatyk.AddSkills(przekonywanie);
            fanatyk.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            fanatyk.AddSkills(zastraszanie);
            flisak.AddSkills(mocnaGlowa, plotkowanie);
            flisak.AddSkills(nawigacja);
            flisak.AddSkills(plywanie);
            flisak.AddDictionarySkills(
                new Tuple<Skill, BuiltInDictionaryValues[]>(sekretnyJezyk, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.SecretLanguageHunters }),
                new Tuple<Skill, BuiltInDictionaryValues[]>(jezyk, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.LanguageKislev }));
            flisak.AddSkills(spostrzegawczosc);
            flisak.AddSkills(sztukaPrzetrwania);
            flisak.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeEmpire, BuiltInDictionaryValues.KnowledgeKislev);
            flisak.AddSkills(wioslarstwo);
            flisak.AddSkills(zelgarstwo);
            giermek.AddSkills(jezdziectwo);
            giermek.AddDictionarySkills(
                new Tuple<Skill, BuiltInDictionaryValues[]>(nauka, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.ScienceGenealogy }),
                new Tuple<Skill, BuiltInDictionaryValues[]>(wiedza, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.KnowledgeBrittany }));
            giermek.AddSkills(opieka);
            giermek.AddSkills(przekonywanie, plotkowanie);
            giermek.AddSkills(tresura);
            giermek.AddSkills(unik);
            giermek.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageBrittany, BuiltInDictionaryValues.LanguageOldWorld);
            gladiator.AddSkills(unik);
            gladiator.AddSkills(zastraszanie);
            goniec.AddSkills(nawigacja);
            goniec.AddSkills(plywanie);
            goniec.AddDictionarySkills(sekretneZnaki, BuiltInDictionaryValues.SecretMarksScouts);
            goniec.AddSkills(spostrzegawczosc);
            goniec.AddSkills(sztukaPrzetrwania);
            goniec.AddSkills(unik);
            gornik.AddSkills(nawigacja);
            gornik.AddSkills(opieka);
            gornik.AddDictionarySkills(rzemioslo, BuiltInDictionaryValues.CraftMining, BuiltInDictionaryValues.CraftOpencastMining);
            gornik.AddSkills(spostrzegawczosc);
            gornik.AddSkills(ukrywanieSie, powozenie);
            gornik.AddSkills(wspinaczka);
            gornik.AddSkills(wycena, sztukaPrzetrwania);
            guslarz.AddSkills(leczenie, hipnoza);
            guslarz.AddSkills(opieka, targowanie);
            guslarz.AddDictionarySkills(oswajanie, rzemioslo, BuiltInDictionaryValues.CraftPharmacy);
            guslarz.AddSkills(przekonywanie, zastraszanie);
            guslarz.AddSkills(przeszukiwanie);
            guslarz.AddSkills(splatanieMagii);
            guslarz.AddSkills(spostrzegawczosc);
            guslarz.AddSkills(wykrywanieMagii);
            hiena.AddSkills(czytaniePisanie);
            hiena.AddSkills(otwieranieZamkow, skradanie);
            hiena.AddSkills(przeszukiwanie);
            hiena.AddSkills(spostrzegawczosc);
            hiena.AddSkills(ukrywanieSie, sztukaPrzetrwania);
            hiena.AddDictionarySkills(
                new Tuple<Skill, BuiltInDictionaryValues[]>(wiedza, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.KnowledgeEmpire }),
                new Tuple<Skill, BuiltInDictionaryValues[]>(sekretneZnaki, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.SecretMarksThiefs }));
            hiena.AddSkills(wspinaczka);
            hiena.AddSkills(wycena);
            hiena.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageEltharin, BuiltInDictionaryValues.LanguageKhazalid, BuiltInDictionaryValues.LanguageClassic);
            kanciarz.AddSkills(gadanina);
            kanciarz.AddDictionarySkills(hazard, sekretneZnaki, BuiltInDictionaryValues.SecretMarksThiefs);
            kanciarz.AddDictionarySkills(kuglarstwo, BuiltInDictionaryValues.PrestidigitationTheatricalArt, BuiltInDictionaryValues.PrestidigitationStoryTelling);
            kanciarz.AddSkills(plotkowanie, targowanie);
            kanciarz.AddSkills(przekonywanie);
            kanciarz.AddDictionarySkills(przeszukiwanie, sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageThiefs);
            kanciarz.AddSkills(spostrzegawczosc);
            kanciarz.AddSkills(wycena);
            kanciarz.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageOldWorld);
            kozak.AddSkills(hazard, targowanie);
            kozak.AddSkills(mocnaGlowa);
            kozak.AddSkills(przeszukiwanie);
            kozak.AddSkills(spostrzegawczosc);
            kozak.AddSkills(sztukaPrzetrwania);
            kozak.AddSkills(unik);
            kozak.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeKislev);
            kozak.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageKislev);
            lesnik.AddDictionarySkills(sekretneZnaki, BuiltInDictionaryValues.SecretMarksHunters);
            lesnik.AddDictionarySkills(sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageHunters);
            lesnik.AddSkills(skradanie);
            lesnik.AddSkills(spostrzegawczosc);
            lesnik.AddSkills(tropienie, zastawianiePulapek);
            lesnik.AddSkills(ukrywanieSie);
            lesnik.AddSkills(wspinaczka);
            lowca.AddSkills(przeszukiwanie, plywanie);
            lowca.AddDictionarySkills(sekretneZnaki, BuiltInDictionaryValues.SecretMarksHunters);
            lowca.AddSkills(skradanie, zastawianiePulapek);
            lowca.AddSkills(spostrzegawczosc);
            lowca.AddSkills(sztukaPrzetrwania);
            lowca.AddSkills(tropienie);
            lowca.AddSkills(ukrywanieSie);
            lowcanagrod.AddSkills(przeszukiwanie);
            lowcanagrod.AddSkills(skradanie);
            lowcanagrod.AddSkills(spostrzegawczosc);
            lowcanagrod.AddSkills(sztukaPrzetrwania);
            lowcanagrod.AddSkills(sledzenie);
            lowcanagrod.AddSkills(tropienie);
            lowcanagrod.AddSkills(zastraszanie);
            mieszczanin.AddSkills(plotkowanie, czytaniePisanie);
            mieszczanin.AddSkills(powozenie);
            mieszczanin.AddSkills(przeszukiwanie);
            mieszczanin.AddSkills(spostrzegawczosc);
            mieszczanin.AddSkills(targowanie);
            mieszczanin.AddDictionarySkills(mocnaGlowa, wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            mieszczanin.AddSkills(wycena);
            mieszczanin.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageBrittany, BuiltInDictionaryValues.LanguageKislev, BuiltInDictionaryValues.LanguageTileanian);
            mieszczanin.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageOldWorld);
            mytnik.AddSkills(czytaniePisanie);
            mytnik.AddSkills(plotkowanie, targowanie);
            mytnik.AddSkills(przeszukiwanie);
            mytnik.AddSkills(spostrzegawczosc);
            mytnik.AddSkills(unik);
            mytnik.AddSkills(wycena);
            mytnik.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageBrittany, BuiltInDictionaryValues.LanguageKislev, BuiltInDictionaryValues.LanguageTileanian);
            najemnik.AddSkills(opieka, hazard);
            najemnik.AddSkills(plotkowanie, targowanie);
            najemnik.AddSkills(powozenie, jezdziectwo);
            najemnik.AddDictionarySkills(sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageBattle);
            najemnik.AddSkills(spostrzegawczosc, przeszukiwanie);
            najemnik.AddSkills(unik);
            najemnik.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeBrittany, BuiltInDictionaryValues.KnowledgeKislev, BuiltInDictionaryValues.KnowledgeTilea);
            najemnik.AddDictionarySkills(plywanie, jezyk, BuiltInDictionaryValues.LanguageTileanian);
            ochotnik.AddSkills(hazard, plotkowanie);
            ochotnik.AddSkills(opieka);
            ochotnik.AddSkills(powozenie, plywanie);
            ochotnik.AddSkills(przeszukiwanie);
            ochotnik.AddDictionarySkills(rzemioslo);
            ochotnik.AddSkills(spostrzegawczosc);
            ochotnik.AddSkills(sztukaPrzetrwania);
            ochotnik.AddSkills(unik);
            ochroniarz.AddSkills(leczenie);
            ochroniarz.AddSkills(spostrzegawczosc);
            ochroniarz.AddSkills(unik);
            ochroniarz.AddSkills(zastraszanie);
            oprych.AddSkills(hazard);
            oprych.AddSkills(mocnaGlowa);
            oprych.AddDictionarySkills(sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageThiefs);
            oprych.AddSkills(unik);
            oprych.AddSkills(zastraszanie);
            paz.AddSkills(czytaniePisanie);
            paz.AddSkills(gadanina);
            paz.AddDictionarySkills(nauka, BuiltInDictionaryValues.ScienceGenealogy);
            paz.AddDictionarySkills(plotkowanie, jezyk, BuiltInDictionaryValues.LanguageBrittany, BuiltInDictionaryValues.LanguageOldWorld);
            paz.AddSkills(przeszukiwanie);
            paz.AddSkills(spostrzegawczosc);
            paz.AddSkills(targowanie);
            paz.AddSkills(wycena);
            podzegacz.AddSkills(czytaniePisanie);
            podzegacz.AddDictionarySkills(plotkowanie, nauka, BuiltInDictionaryValues.ScienceHistory);
            podzegacz.AddDictionarySkills(
                new Tuple<Skill, BuiltInDictionaryValues[]>(nauka, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.ScienceLaw }),
                new Tuple<Skill, BuiltInDictionaryValues[]>(wiedza, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.KnowledgeEmpire }));
            podzegacz.AddSkills(przekonywanie);
            podzegacz.AddSkills(spostrzegawczosc);
            podzegacz.AddSkills(ukrywanieSie);
            podzegacz.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageBrittany, BuiltInDictionaryValues.LanguageTileanian);
            podzegacz.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageOldWorld);
            porywacz.AddSkills(plotkowanie, targowanie);
            porywacz.AddSkills(powozenie);
            porywacz.AddSkills(przeszukiwanie);
            porywacz.AddDictionarySkills(sekretneZnaki, BuiltInDictionaryValues.SecretMarksThiefs);
            porywacz.AddSkills(skradanie);
            porywacz.AddSkills(spostrzegawczosc);
            porywacz.AddSkills(wspinaczka);
            poslaniec.AddSkills(jezdziectwo);
            poslaniec.AddSkills(nawigacja);
            poslaniec.AddSkills(opieka);
            poslaniec.AddSkills(plywanie);
            poslaniec.AddDictionarySkills(sekretneZnaki, BuiltInDictionaryValues.SecretMarksScouts);
            poslaniec.AddSkills(spostrzegawczosc);
            poslaniec.AddSkills(sztukaPrzetrwania);
            poslaniec.AddDictionarySkills(plotkowanie, wiedza, BuiltInDictionaryValues.KnowledgeEmpire, BuiltInDictionaryValues.KnowledgeBarrenLand);
            poslaniec.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageOldWorld);
            przemytnik.AddDictionarySkills(plotkowanie, sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageThiefs);
            przemytnik.AddSkills(plywanie);
            przemytnik.AddSkills(powozenie);
            przemytnik.AddSkills(przeszukiwanie);
            przemytnik.AddSkills(skradanie);
            przemytnik.AddSkills(spostrzegawczosc);
            przemytnik.AddSkills(targowanie);
            przemytnik.AddSkills(wioslarstwo);
            przemytnik.AddSkills(wycena);
            przemytnik.AddDictionarySkills(
                new Tuple<Skill, BuiltInDictionaryValues[]>(jezyk, new BuiltInDictionaryValues[]
                {
                    BuiltInDictionaryValues.LanguageBrittany,
                    BuiltInDictionaryValues.LanguageKislev
                }),
                new Tuple<Skill, BuiltInDictionaryValues[]>(sekretneZnaki, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.SecretMarksThiefs }));
            przepatrywacz.AddSkills(jezdziectwo);
            przepatrywacz.AddSkills(nawigacja);
            przepatrywacz.AddSkills(opieka);
            przepatrywacz.AddSkills(przeszukiwanie);
            przepatrywacz.AddSkills(skradanie);
            przepatrywacz.AddSkills(spostrzegawczosc);
            przepatrywacz.AddSkills(sztukaPrzetrwania);
            przepatrywacz.AddSkills(tropienie);
            przewoznik.AddSkills(plotkowanie, zastraszanie);
            przewoznik.AddSkills(plywanie);
            przewoznik.AddSkills(przekonywanie);
            przewoznik.AddSkills(spostrzegawczosc);
            przewoznik.AddSkills(targowanie);
            przewoznik.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            przewoznik.AddSkills(wioslarstwo);
            przewoznik.AddDictionarySkills(wycena, sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageHunters);
            rybak.AddSkills(mocnaGlowa, targowanie);
            rybak.AddSkills(nawigacja, rzemioslo);
            rybak.AddSkills(plywanie);
            rybak.AddSkills(spostrzegawczosc);
            rybak.AddSkills(sztukaPrzetrwania);
            rybak.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeEmpire, BuiltInDictionaryValues.KnowledgeBarrenLand);
            rybak.AddSkills(wioslarstwo);
            rybak.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageOldWorld, BuiltInDictionaryValues.LanguageNorsca);
            rybak.AddSkills(zelgarstwo);
            rzecznik.AddSkills(czytaniePisanie);
            rzecznik.AddSkills(plotkowanie);
            rzecznik.AddSkills(plywanie);
            rzecznik.AddSkills(przekonywanie);
            rzecznik.AddDictionarySkills(rzemioslo, BuiltInDictionaryValues.CraftTrading);
            rzecznik.AddDictionarySkills(sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageGuild);
            rzecznik.AddSkills(spostrzegawczosc);
            rzecznik.AddSkills(targowanie);
            rzecznik.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeEmpire, BuiltInDictionaryValues.KnowledgeBarrenLand);
            rzecznik.AddSkills(wycena);
            rzemieslnik.AddSkills(czytaniePisanie);
            rzemieslnik.AddSkills(opieka, plotkowanie);
            rzemieslnik.AddSkills(powozenie);
            rzemieslnik.AddDictionarySkills(rzemioslo);
            rzemieslnik.AddDictionarySkills(rzemioslo);
            rzemieslnik.AddDictionarySkills(sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageGuild);
            rzemieslnik.AddSkills(spostrzegawczosc);
            rzemieslnik.AddSkills(targowanie);
            rzemieslnik.AddSkills(wycena);
            rzezimieszek.AddSkills(jezdziectwo);
            rzezimieszek.AddSkills(plotkowanie, targowanie);
            rzezimieszek.AddSkills(unik);
            rzezimieszek.AddSkills(zastraszanie);
            skryba.AddSkills(czytaniePisanie);
            skryba.AddDictionarySkills(nauka);
            skryba.AddDictionarySkills(rzemioslo, BuiltInDictionaryValues.CraftCalligraphy);
            skryba.AddDictionarySkills(sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageGuild);
            skryba.AddSkills(spostrzegawczosc);
            skryba.AddDictionarySkills(plotkowanie, wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            skryba.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageBrittany);
            skryba.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageClassic);
            skryba.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageOldWorld, BuiltInDictionaryValues.LanguageTileanian);
            sluga.AddSkills(czytaniePisanie, zwinnePalce);
            sluga.AddSkills(gadanina);
            sluga.AddDictionarySkills(opieka, rzemioslo, BuiltInDictionaryValues.CraftCooking);
            sluga.AddSkills(plotkowanie);
            sluga.AddSkills(powozenie, przeszukiwanie);
            sluga.AddSkills(spostrzegawczosc);
            sluga.AddSkills(targowanie, wycena);
            sluga.AddSkills(unik);
            straznik.AddDictionarySkills(nauka, BuiltInDictionaryValues.ScienceLaw);
            straznik.AddSkills(plotkowanie);
            straznik.AddSkills(przeszukiwanie);
            straznik.AddSkills(spostrzegawczosc);
            straznik.AddSkills(tropienie);
            straznik.AddSkills(unik);
            straznik.AddSkills(zastraszanie);
            straznikDrog.AddSkills(jezdziectwo);
            straznikDrog.AddSkills(nawigacja);
            straznikDrog.AddSkills(opieka);
            straznikDrog.AddSkills(powozenie);
            straznikDrog.AddSkills(przeszukiwanie);
            straznikDrog.AddSkills(spostrzegawczosc);
            straznikDrog.AddSkills(sztukaPrzetrwania);
            straznikDrog.AddDictionarySkills(tropienie, sekretneZnaki, BuiltInDictionaryValues.SecretMarksScouts);
            straznikDrog.AddDictionarySkills(plotkowanie, wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            straznikPol.AddDictionarySkills(
                new Tuple<Skill, BuiltInDictionaryValues[]>(nauka, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.ScienceNecromancy }),
                new Tuple<Skill, BuiltInDictionaryValues[]>(wiedza, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.KnowledgeEmpire }));
            straznikPol.AddSkills(przeszukiwanie);
            straznikPol.AddSkills(skradanie);
            straznikPol.AddSkills(spostrzegawczosc);
            straznikPol.AddSkills(sztukaPrzetrwania);
            straznikPol.AddSkills(tropienie);
            straznikPol.AddSkills(ukrywanieSie);
            straznikWiezienny.AddSkills(dowodzenie);
            straznikWiezienny.AddSkills(leczenie, zwinnePalce);
            straznikWiezienny.AddSkills(mocnaGlowa);
            straznikWiezienny.AddSkills(przeszukiwanie);
            straznikWiezienny.AddSkills(spostrzegawczosc);
            straznikWiezienny.AddSkills(unik);
            straznikWiezienny.AddSkills(zastraszanie);
            szczurolap.AddSkills(opieka);
            szczurolap.AddSkills(przeszukiwanie);
            szczurolap.AddSkills(skradanie);
            szczurolap.AddSkills(spostrzegawczosc);
            szczurolap.AddSkills(tresura);
            szczurolap.AddSkills(ukrywanieSie);
            szczurolap.AddSkills(zastawianiePulapek);
            szermierz.AddSkills(czytaniePisanie);
            szermierz.AddDictionarySkills(nauka, BuiltInDictionaryValues.ScienceAnatomy);
            szermierz.AddSkills(unik);
            szermierz.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeEstalia);
            szermierz.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageEstalian);
            szlachcic.AddSkills(czytaniePisanie);
            szlachcic.AddSkills(gadanina, dowodzenie);
            szlachcic.AddSkills(hazard, plotkowanie);
            szlachcic.AddSkills(jezdziectwo);
            szlachcic.AddDictionarySkills(mocnaGlowa, kuglarstwo, BuiltInDictionaryValues.PrestidigitationMusicality);
            szlachcic.AddSkills(przekonywanie);
            szlachcic.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            szlachcic.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageOldWorld);
            smieciarz.AddSkills(opieka);
            smieciarz.AddSkills(powozenie);
            smieciarz.AddSkills(przekonywanie, plotkowanie);
            smieciarz.AddSkills(przeszukiwanie);
            smieciarz.AddSkills(spostrzegawczosc);
            smieciarz.AddSkills(targowanie);
            smieciarz.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            smieciarz.AddSkills(wycena);
            tarczownik.AddSkills(nawigacja);
            tarczownik.AddSkills(spostrzegawczosc);
            tarczownik.AddSkills(sledzenie);
            tarczownik.AddSkills(unik);
            tarczownik.AddSkills(wspinaczka);
            uczen.AddSkills(czytaniePisanie);
            uczen.AddDictionarySkills(jezykTajemny, BuiltInDictionaryValues.MisticLanguageMagic);
            uczen.AddDictionarySkills(nauka, BuiltInDictionaryValues.ScienceMagic);
            uczen.AddSkills(przeszukiwanie);
            uczen.AddSkills(splatanieMagii);
            uczen.AddSkills(spostrzegawczosc);
            uczen.AddSkills(wykrywanieMagii);
            uczen.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageClassic);
            weglarz.AddSkills(powozenie, plotkowanie);
            weglarz.AddSkills(przeszukiwanie);
            weglarz.AddDictionarySkills(sekretneZnaki, BuiltInDictionaryValues.SecretMarksHunters);
            weglarz.AddSkills(spostrzegawczosc);
            weglarz.AddSkills(sztukaPrzetrwania);
            weglarz.AddSkills(targowanie);
            weglarz.AddDictionarySkills(ukrywanieSie, wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            weglarz.AddSkills(wspinaczka);
            wloczykij.AddDictionarySkills(
                new Tuple<Skill, BuiltInDictionaryValues[]>(kuglarstwo, new BuiltInDictionaryValues[]
                {
                    BuiltInDictionaryValues.PrestidigitationStoryTelling,
                    BuiltInDictionaryValues.PrestidigitationSinging,
                    BuiltInDictionaryValues.PrestidigitationDancing
                }),
                new Tuple<Skill, BuiltInDictionaryValues[]>(sekretneZnaki, new BuiltInDictionaryValues[]
                {
                    BuiltInDictionaryValues.SecretMarksHunters,
                    BuiltInDictionaryValues.SecretMarksThiefs
                }));
            wloczykij.AddSkills(leczenie, spostrzegawczosc);
            wloczykij.AddSkills(nawigacja);
            wloczykij.AddDictionarySkills(plotkowanie, sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageHunters, BuiltInDictionaryValues.SecretLanguageThiefs);
            wloczykij.AddSkills(skradanie);
            wloczykij.AddSkills(sztukaPrzetrwania);
            wloczykij.AddSkills(targowanie, plywanie);
            wloczykij.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeBrittany, BuiltInDictionaryValues.KnowledgeEstalia, BuiltInDictionaryValues.KnowledgeKislev, BuiltInDictionaryValues.KnowledgeTilea);
            wojownik.AddSkills(leczenie, przeszukiwanie);
            wojownik.AddSkills(skradanie);
            wojownik.AddSkills(spostrzegawczosc);
            wojownik.AddSkills(sztukaPrzetrwania);
            wojownik.AddSkills(tropienie);
            wojownik.AddSkills(ukrywanieSie);
            wojownik.AddSkills(unik);
            wojownik.AddSkills(wspinaczka);
            woznica.AddSkills(leczenie, jezdziectwo);
            woznica.AddSkills(nawigacja);
            woznica.AddSkills(opieka);
            woznica.AddSkills(plotkowanie, targowanie);
            woznica.AddSkills(powozenie);
            woznica.AddDictionarySkills(sekretneZnaki, BuiltInDictionaryValues.SecretMarksHunters);
            woznica.AddSkills(spostrzegawczosc);
            woznica.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageBrittany, BuiltInDictionaryValues.LanguageKislev, BuiltInDictionaryValues.LanguageTileanian);
            zabojcaTroli.AddSkills(mocnaGlowa);
            zabojcaTroli.AddSkills(unik);
            zabojcaTroli.AddSkills(zastraszanie);
            zarzadca.AddSkills(czytaniePisanie);
            zarzadca.AddSkills(dowodzenie, nawigacja);
            zarzadca.AddSkills(jezdziectwo);
            zarzadca.AddDictionarySkills(nauka, BuiltInDictionaryValues.ScienceLaw);
            zarzadca.AddSkills(opieka, plotkowanie);
            zarzadca.AddSkills(przekonywanie);
            zarzadca.AddSkills(spostrzegawczosc);
            zarzadca.AddDictionarySkills(zastraszanie, wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            zlodziej.AddSkills(czytaniePisanie, zwinnePalce);
            zlodziej.AddSkills(hazard, otwieranieZamkow);
            zlodziej.AddSkills(przekonywanie, wspinaczka);
            zlodziej.AddSkills(przeszukiwanie);
            zlodziej.AddDictionarySkills(
                new Tuple<Skill, BuiltInDictionaryValues[]>(sekretnyJezyk, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.SecretLanguageThiefs }),
                new Tuple<Skill, BuiltInDictionaryValues[]>(sekretneZnaki, new BuiltInDictionaryValues[] { BuiltInDictionaryValues.SecretMarksThiefs }));
            zlodziej.AddSkills(skradanie);
            zlodziej.AddSkills(spostrzegawczosc);
            zlodziej.AddSkills(ukrywanieSie);
            zlodziej.AddSkills(wycena, charakteryzacja);
            zak.AddSkills(czytaniePisanie);
            zak.AddSkills(leczenie, przeszukiwanie);
            zak.AddDictionarySkills(nauka);
            zak.AddDictionarySkills(plotkowanie, nauka);
            zak.AddSkills(przekonywanie, mocnaGlowa);
            zak.AddSkills(spostrzegawczosc);
            zak.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageClassic);
            zak.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageOldWorld);
            zeglarz.AddSkills(mocnaGlowa, spostrzegawczosc);
            zeglarz.AddSkills(plywanie);
            zeglarz.AddSkills(unik);
            zeglarz.AddDictionarySkills(wiedza, BuiltInDictionaryValues.KnowledgeBrittany, BuiltInDictionaryValues.KnowledgeNorsca, BuiltInDictionaryValues.KnowledgeTilea, BuiltInDictionaryValues.KnowledgeBarrenLand);
            zeglarz.AddSkills(wioslarstwo);
            zeglarz.AddSkills(wspinaczka);
            zeglarz.AddDictionarySkills(jezyk, BuiltInDictionaryValues.LanguageBrittany, BuiltInDictionaryValues.LanguageNorsca, BuiltInDictionaryValues.LanguageTileanian);
            zeglarz.AddSkills(zelgarstwo);
            zolnierz.AddSkills(hazard, plotkowanie);
            zolnierz.AddSkills(opieka, leczenie);
            zolnierz.AddSkills(powozenie, jezdziectwo);
            zolnierz.AddSkills(unik);
            zolnierz.AddDictionarySkills(spostrzegawczosc, wiedza, BuiltInDictionaryValues.KnowledgeEmpire);
            zolnierz.AddSkills(zastraszanie);
            zolnierzOkretowy.AddSkills(mocnaGlowa);
            zolnierzOkretowy.AddDictionarySkills(plotkowanie, sekretnyJezyk, BuiltInDictionaryValues.SecretLanguageBattle);
            zolnierzOkretowy.AddSkills(plywanie);
            zolnierzOkretowy.AddSkills(unik);
            zolnierzOkretowy.AddDictionarySkills(hazard, wiedza, BuiltInDictionaryValues.KnowledgeBarrenLand);
            zolnierzOkretowy.AddSkills(wioslarstwo);
            zolnierzOkretowy.AddSkills(zastraszanie);///////////////////////////////////////////////////////////////////////////
            arcykaplan.AddSkills(jezdziectwo, plywanie);
            arcykaplan.AddSkills(jezyk);
            arcykaplan.AddSkills(leczenie);
            arcykaplan.AddSkills(nauka);
            arcykaplan.AddSkills(nauka);
            arcykaplan.AddSkills(plotkowanie);
            arcykaplan.AddSkills(przekonywanie);
            arcykaplan.AddSkills(splatanieMagii);
            arcykaplan.AddSkills(wiedza);
            arcykaplan.AddSkills(wykrywanieMagii);
            arcykaplan.AddSkills(zastraszanie);
            arcykaplan.AddSkills(jezyk);
            arcymag.AddSkills(czytaniePisanie);
            arcymag.AddSkills(jezyk);
            arcymag.AddSkills(jezyk);
            arcymag.AddSkills(nauka);
            arcymag.AddSkills(nauka);
            arcymag.AddSkills(nauka);
            arcymag.AddSkills(nauka);
            arcymag.AddSkills(przekonywanie, zastraszanie);
            arcymag.AddSkills(splatanieMagii);
            arcymag.AddSkills(wiedza);
            arcymag.AddSkills(wiedza);
            arcymag.AddSkills(wiedza);
            arcymag.AddSkills(wykrywanieMagii);
            arcymag.AddSkills(jezyk);
            arystokrata.AddSkills(czytaniePisanie);
            arystokrata.AddSkills(dowodzenie);
            arystokrata.AddSkills(jezdziectwo);
            arystokrata.AddSkills(nauka);
            arystokrata.AddSkills(nauka);
            arystokrata.AddSkills(plotkowanie);
            arystokrata.AddSkills(przekonywanie);
            arystokrata.AddSkills(spostrzegawczosc);
            arystokrata.AddSkills(wiedza);
            arystokrata.AddSkills(wycena);
            arystokrata.AddSkills(jezyk);
            arystokrata.AddSkills(jezyk);
            bard.AddSkills(czytaniePisanie);
            bard.AddSkills(kuglarstwo);
            bard.AddSkills(kuglarstwo);
            bard.AddSkills(plotkowanie);
            bard.AddSkills(przekonywanie);
            bard.AddSkills(spostrzegawczosc);
            bard.AddSkills(wiedza);
            bard.AddSkills(wiedza);
            bard.AddSkills(jezyk);
            biczownik.AddSkills(leczenie);
            biczownik.AddSkills(nauka);
            biczownik.AddSkills(przekonywanie);
            biczownik.AddSkills(zastraszanie);
            biczownik.AddSkills(jezyk);
            bosman.AddSkills(dowodzenie);
            bosman.AddSkills(hazard);
            bosman.AddSkills(mocnaGlowa);
            bosman.AddSkills(plotkowanie);
            bosman.AddSkills(plywanie);
            bosman.AddSkills(rzemioslo);
            bosman.AddSkills(unik);
            bosman.AddSkills(wiedza);
            bosman.AddSkills(wiedza);
            bosman.AddSkills(wioslarstwo);
            bosman.AddSkills(zastraszanie);
            bosman.AddSkills(jezyk);
            bosman.AddSkills(zelgarstwo);
            demagog.AddSkills(charakteryzacja);
            demagog.AddSkills(dowodzenie);
            demagog.AddSkills(gadanina);
            demagog.AddSkills(nauka);
            demagog.AddSkills(nauka);
            demagog.AddSkills(plotkowanie);
            demagog.AddSkills(przekonywanie);
            demagog.AddSkills(spostrzegawczosc);
            demagog.AddSkills(ukrywanieSie);
            demagog.AddSkills(unik);
            demagog.AddSkills(wiedza);
            demagog.AddSkills(zastraszanie);
            demagog.AddSkills(jezyk);
            dworzanin.AddSkills(czytaniePisanie);
            dworzanin.AddSkills(dowodzenie, kuglarstwo);
            dworzanin.AddSkills(gadanina);
            dworzanin.AddSkills(jezdziectwo);
            dworzanin.AddSkills(nauka, hazard);
            dworzanin.AddSkills(plotkowanie);
            dworzanin.AddSkills(przekonywanie);
            dworzanin.AddSkills(spostrzegawczosc);
            dworzanin.AddSkills(wiedza);
            dworzanin.AddSkills(wycena);
            dworzanin.AddSkills(jezyk);
            dworzanin.AddSkills(jezyk);
            fechmistrz.AddSkills(spostrzegawczosc);
            fechmistrz.AddSkills(unik);
            fechmistrz.AddSkills(wycena);
            fechmistrz.AddSkills(zastraszanie);
            herold.AddSkills(czytaniePisanie);
            herold.AddSkills(gadanina);
            herold.AddSkills(jezdziectwo);
            herold.AddSkills(nauka);
            herold.AddSkills(nauka);
            herold.AddSkills(plotkowanie);
            herold.AddSkills(przekonywanie);
            herold.AddSkills(spostrzegawczosc);
            herold.AddSkills(targowanie);
            herold.AddSkills(wiedza);
            herold.AddSkills(wiedza);
            herold.AddSkills(wycena);
            herold.AddSkills(jezyk);
            herold.AddSkills(jezyk);
            herszt.AddSkills(dowodzenie);
            herszt.AddSkills(jezdziectwo);
            herszt.AddSkills(nauka);
            herszt.AddSkills(sekretneZnaki);
            herszt.AddSkills(sekretnyJezyk);
            herszt.AddSkills(skradanie);
            herszt.AddSkills(spostrzegawczosc);
            herszt.AddSkills(tropienie);
            herszt.AddSkills(ukrywanieSie);
            herszt.AddSkills(wiedza);
            herszt.AddSkills(wspinaczka);
            inzynier.AddSkills(czytaniePisanie);
            inzynier.AddSkills(nauka);
            inzynier.AddSkills(nauka);
            inzynier.AddSkills(powozenie, jezdziectwo);
            inzynier.AddSkills(rzemioslo);
            inzynier.AddSkills(spostrzegawczosc);
            inzynier.AddSkills(wiedza);
            inzynier.AddSkills(jezyk);
            kapitan.AddSkills(dowodzenie);
            kapitan.AddSkills(nauka);
            kapitan.AddSkills(plywanie);
            kapitan.AddSkills(rzemioslo);
            kapitan.AddSkills(spostrzegawczosc);
            kapitan.AddSkills(tresura);
            kapitan.AddSkills(unik);
            kapitan.AddSkills(wiedza);
            kapitan.AddSkills(wiedza);
            kapitan.AddSkills(wiedza);
            kapitan.AddSkills(jezyk);
            kapitan.AddSkills(jezyk);
            kapitan.AddSkills(jezyk);
            kapitan.AddSkills(zelgarstwo);
            kaplan.AddSkills(czytaniePisanie);
            kaplan.AddSkills(jezdziectwo, plywanie);
            kaplan.AddSkills(jezykTajemny);
            kaplan.AddSkills(leczenie);
            kaplan.AddSkills(nauka);
            kaplan.AddSkills(nauka);
            kaplan.AddSkills(plotkowanie);
            kaplan.AddSkills(przekonywanie);
            kaplan.AddSkills(splatanieMagii);
            kaplan.AddSkills(spostrzegawczosc);
            kaplan.AddSkills(wiedza);
            kaplan.AddSkills(wiedza);
            kaplan.AddSkills(wykrywanieMagii);
            kaplan.AddSkills(jezyk);
            kaplan.AddSkills(jezyk);
            karczmarz.AddSkills(czytaniePisanie, zwinnePalce);
            karczmarz.AddSkills(gadanina, czytanieZWarg);
            karczmarz.AddSkills(mocnaGlowa);
            karczmarz.AddSkills(plotkowanie);
            karczmarz.AddSkills(przekonywanie);
            karczmarz.AddSkills(rzemioslo);
            karczmarz.AddSkills(spostrzegawczosc);
            karczmarz.AddSkills(targowanie);
            karczmarz.AddSkills(wiedza);
            karczmarz.AddSkills(wycena);
            karczmarz.AddSkills(jezyk);
            ksiaze.AddSkills(dowodzenie);
            ksiaze.AddSkills(plotkowanie);
            ksiaze.AddSkills(przekonywanie);
            ksiaze.AddSkills(sekretneZnaki);
            ksiaze.AddSkills(sekretnyJezyk);
            ksiaze.AddSkills(spostrzegawczosc);
            ksiaze.AddSkills(targowanie);
            ksiaze.AddSkills(torturowanie);
            ksiaze.AddSkills(unik);
            ksiaze.AddSkills(wiedza);
            ksiaze.AddSkills(wycena);
            ksiaze.AddSkills(zastraszanie);
            kupiec.AddSkills(czytaniePisanie);
            kupiec.AddSkills(jezdziectwo);
            kupiec.AddSkills(plotkowanie);
            kupiec.AddSkills(powozenie);
            kupiec.AddSkills(przekonywanie);
            kupiec.AddSkills(rzemioslo);
            kupiec.AddSkills(sekretnyJezyk);
            kupiec.AddSkills(targowanie);
            kupiec.AddSkills(wiedza);
            kupiec.AddSkills(wiedza);
            kupiec.AddSkills(wycena);
            kupiec.AddSkills(jezyk);
            kupiec.AddSkills(jezyk);
            lesnyDuch.AddSkills(czytanieZWarg);
            lesnyDuch.AddSkills(nawigacja);
            lesnyDuch.AddSkills(sekretneZnaki);
            lesnyDuch.AddSkills(sekretnyJezyk);
            lesnyDuch.AddSkills(skradanie);
            lesnyDuch.AddSkills(spostrzegawczosc);
            lesnyDuch.AddSkills(sztukaPrzetrwania);
            lesnyDuch.AddSkills(sledzenie);
            lesnyDuch.AddSkills(tropienie);
            lesnyDuch.AddSkills(ukrywanieSie);
            lesnyDuch.AddSkills(unik);
            lesnyDuch.AddSkills(zastawianiePulapek);
            lesnyDuch.AddSkills(zastraszanie);
            lowcaCzarownic.AddSkills(dowodzenie);
            lowcaCzarownic.AddSkills(jezdziectwo);
            lowcaCzarownic.AddSkills(nauka);
            lowcaCzarownic.AddSkills(nauka);
            lowcaCzarownic.AddSkills(nauka);
            lowcaCzarownic.AddSkills(plotkowanie);
            lowcaCzarownic.AddSkills(przekonywanie);
            lowcaCzarownic.AddSkills(przeszukiwanie);
            lowcaCzarownic.AddSkills(skradanie);
            lowcaCzarownic.AddSkills(spostrzegawczosc);
            lowcaCzarownic.AddSkills(wiedza);
            lowcaCzarownic.AddSkills(zastraszanie);
            lowcaCzarownic.AddSkills(jezyk);
            lowcaWampirow.AddSkills(nauka);
            lowcaWampirow.AddSkills(przeszukiwanie);
            lowcaWampirow.AddSkills(skradanie);
            lowcaWampirow.AddSkills(spostrzegawczosc);
            lowcaWampirow.AddSkills(sledzenie);
            lowcaWampirow.AddSkills(tropienie);
            lowcaWampirow.AddSkills(ukrywanieSie);
            lowcaWampirow.AddSkills(unik);
            lowcaWampirow.AddSkills(wiedza);
            lowcaWampirow.AddSkills(wspinaczka);
            lowcaWampirow.AddSkills(jezyk);
            majordomus.AddSkills(czytaniePisanie);
            majordomus.AddSkills(dowodzenie);
            majordomus.AddSkills(jezdziectwo);
            majordomus.AddSkills(nauka);
            majordomus.AddSkills(plotkowanie);
            majordomus.AddSkills(przekonywanie);
            majordomus.AddSkills(przeszukiwanie);
            majordomus.AddSkills(rzemioslo);
            majordomus.AddSkills(spostrzegawczosc);
            majordomus.AddSkills(targowanie);
            majordomus.AddSkills(wiedza);
            majordomus.AddSkills(wycena);
            majordomus.AddSkills(zastraszanie);
            majordomus.AddSkills(jezyk);
            medyk.AddSkills(czytaniePisanie);
            medyk.AddSkills(leczenie);
            medyk.AddSkills(nauka);
            medyk.AddSkills(plotkowanie);
            medyk.AddSkills(rzemioslo);
            medyk.AddSkills(spostrzegawczosc);
            medyk.AddSkills(warzenieTrucizn);
            medyk.AddSkills(jezyk);
            mistrzCieni.AddSkills(charakteryzacja);
            mistrzCieni.AddSkills(czytaniePisanie);
            mistrzCieni.AddSkills(hazard, czytanieZWarg);
            mistrzCieni.AddSkills(otwieranieZamkow);
            mistrzCieni.AddSkills(plotkowanie);
            mistrzCieni.AddSkills(plywanie);
            mistrzCieni.AddSkills(przekonywanie);
            mistrzCieni.AddSkills(przeszukiwanie);
            mistrzCieni.AddSkills(sekretneZnaki);
            mistrzCieni.AddSkills(sekretnyJezyk);
            mistrzCieni.AddSkills(skradanie);
            mistrzCieni.AddSkills(spostrzegawczosc);
            mistrzCieni.AddSkills(ukrywanieSie);
            mistrzCieni.AddSkills(unik);
            mistrzCieni.AddSkills(wspinaczka);
            mistrzCieni.AddSkills(wycena);
            mistrzCieni.AddSkills(zwinnePalce);
            mistrzGildii.AddSkills(dowodzenie);
            mistrzGildii.AddSkills(nauka);
            mistrzGildii.AddSkills(plotkowanie);
            mistrzGildii.AddSkills(przekonywanie);
            mistrzGildii.AddSkills(rzemioslo);
            mistrzGildii.AddSkills(rzemioslo);
            mistrzGildii.AddSkills(sekretnyJezyk);
            mistrzGildii.AddSkills(spostrzegawczosc);
            mistrzGildii.AddSkills(targowanie);
            mistrzGildii.AddSkills(wiedza);
            mistrzGildii.AddSkills(wycena);
            mistrzGildii.AddSkills(jezyk);
            mistrzGildii.AddSkills(jezyk);
            mistrzMagii.AddSkills(czytaniePisanie);
            mistrzMagii.AddSkills(jezykTajemny);
            mistrzMagii.AddSkills(jezykTajemny);
            mistrzMagii.AddSkills(nauka);
            mistrzMagii.AddSkills(nauka);
            mistrzMagii.AddSkills(plotkowanie, jezdziectwo);
            mistrzMagii.AddSkills(przekonywanie, zastraszanie);
            mistrzMagii.AddSkills(splatanieMagii);
            mistrzMagii.AddSkills(wiedza);
            mistrzMagii.AddSkills(wiedza);
            mistrzMagii.AddSkills(wykrywanieMagii);
            mistrzMagii.AddSkills(jezyk);
            mistrzMagii.AddSkills(jezyk);
            mistrzMagii.AddSkills(jezyk);
            mistrzRzemiosla.AddSkills(plotkowanie);
            mistrzRzemiosla.AddSkills(powozenie);
            mistrzRzemiosla.AddSkills(rzemioslo);
            mistrzRzemiosla.AddSkills(rzemioslo);
            mistrzRzemiosla.AddSkills(rzemioslo);
            mistrzRzemiosla.AddSkills(sekretnyJezyk);
            mistrzRzemiosla.AddSkills(spostrzegawczosc);
            mistrzRzemiosla.AddSkills(targowanie);
            mistrzRzemiosla.AddSkills(wycena);
            mistrzRzemiosla.AddSkills(jezyk);
            mistrzZakonny.AddSkills(czytaniePisanie);
            mistrzZakonny.AddSkills(dowodzenie);
            mistrzZakonny.AddSkills(jezdziectwo);
            mistrzZakonny.AddSkills(nauka);
            mistrzZakonny.AddSkills(nauka);
            mistrzZakonny.AddSkills(przekonywanie);
            mistrzZakonny.AddSkills(sekretneZnaki);
            mistrzZakonny.AddSkills(sekretnyJezyk);
            mistrzZakonny.AddSkills(spostrzegawczosc);
            mistrzZakonny.AddSkills(tresura);
            mistrzZakonny.AddSkills(unik);
            mistrzZakonny.AddSkills(wiedza);
            mistrzZakonny.AddSkills(wiedza);
            mistrzZakonny.AddSkills(wiedza);
            mistrzZakonny.AddSkills(jezyk);
            nawigator.AddSkills(czytaniePisanie);
            nawigator.AddSkills(nauka);
            nawigator.AddSkills(nawigacja);
            nawigator.AddSkills(plywanie);
            nawigator.AddSkills(rzemioslo);
            nawigator.AddSkills(spostrzegawczosc);
            nawigator.AddSkills(wiedza);
            nawigator.AddSkills(wiedza);
            nawigator.AddSkills(jezyk);
            odkrywca.AddSkills(czytaniePisanie);
            odkrywca.AddSkills(dowodzenie);
            odkrywca.AddSkills(jezdziectwo);
            odkrywca.AddSkills(nauka);
            odkrywca.AddSkills(nawigacja);
            odkrywca.AddSkills(plywanie);
            odkrywca.AddSkills(powozenie);
            odkrywca.AddSkills(rzemioslo);
            odkrywca.AddSkills(sekretneZnaki);
            odkrywca.AddSkills(sekretnyJezyk);
            odkrywca.AddSkills(spostrzegawczosc);
            odkrywca.AddSkills(sztukaPrzetrwania);
            odkrywca.AddSkills(tropienie);
            odkrywca.AddSkills(wiedza);
            odkrywca.AddSkills(wiedza);
            odkrywca.AddSkills(wiedza);
            odkrywca.AddSkills(wspinaczka);
            odkrywca.AddSkills(wycena);
            odkrywca.AddSkills(jezyk);
            odkrywca.AddSkills(jezyk);
            odkrywca.AddSkills(jezyk);
            oficer.AddSkills(czytaniePisanie);
            oficer.AddSkills(dowodzenie);
            oficer.AddSkills(jezdziectwo);
            oficer.AddSkills(nauka);
            oficer.AddSkills(opieka);
            oficer.AddSkills(plotkowanie);
            oficer.AddSkills(sekretnyJezyk);
            oficer.AddSkills(unik);
            oficer.AddSkills(wiedza);
            oficer.AddSkills(wiedza);
            oficer.AddSkills(wiedza);
            oficer.AddSkills(jezyk);
            oprawca.AddSkills(leczenie);
            oprawca.AddSkills(przekonywanie);
            oprawca.AddSkills(spostrzegawczosc);
            oprawca.AddSkills(torturowanie);
            oprawca.AddSkills(zastraszanie);
            paser.AddSkills(hazard);
            paser.AddSkills(plotkowanie);
            paser.AddSkills(spostrzegawczosc);
            paser.AddSkills(targowanie);
            paser.AddSkills(wycena);
            paser.AddSkills(zastraszanie);
            paser.AddSkills(zwinnePalce);
            rajtar.AddSkills(jezdziectwo);
            rajtar.AddSkills(opieka);
            rajtar.AddSkills(sekretneZnaki);
            rajtar.AddSkills(spostrzegawczosc);
            rajtar.AddSkills(unik);
            rajtar.AddSkills(wycena, plotkowanie);
            reketer.AddSkills(dowodzenie);
            reketer.AddSkills(plotkowanie);
            reketer.AddSkills(spostrzegawczosc);
            reketer.AddSkills(sledzenie);
            reketer.AddSkills(targowanie);
            reketer.AddSkills(unik);
            reketer.AddSkills(wiedza);
            reketer.AddSkills(wycena);
            reketer.AddSkills(zastraszanie);
            rozbojnik.AddSkills(jezdziectwo);
            rozbojnik.AddSkills(opieka);
            rozbojnik.AddSkills(plotkowanie);
            rozbojnik.AddSkills(przekonywanie);
            rozbojnik.AddSkills(skradanie);
            rozbojnik.AddSkills(tresura);
            rozbojnik.AddSkills(wiedza);
            rozbojnik.AddSkills(wycena);
            rycerz.AddSkills(jezdziectwo);
            rycerz.AddSkills(nauka);
            rycerz.AddSkills(nauka);
            rycerz.AddSkills(sekretnyJezyk);
            rycerz.AddSkills(spostrzegawczosc);
            rycerz.AddSkills(unik);
            rycerz.AddSkills(jezyk);
            rycerz.AddSkills(jezyk);
            sierzant.AddSkills(dowodzenie);
            sierzant.AddSkills(jezdziectwo, plywanie);
            sierzant.AddSkills(nauka);
            sierzant.AddSkills(plotkowanie);
            sierzant.AddSkills(sekretnyJezyk);
            sierzant.AddSkills(spostrzegawczosc);
            sierzant.AddSkills(unik);
            sierzant.AddSkills(wiedza);
            sierzant.AddSkills(wiedza);
            sierzant.AddSkills(zastraszanie);
            sierzant.AddSkills(jezyk);
            skrytobojca.AddSkills(charakteryzacja);
            skrytobojca.AddSkills(plotkowanie);
            skrytobojca.AddSkills(sekretneZnaki);
            skrytobojca.AddSkills(skradanie);
            skrytobojca.AddSkills(spostrzegawczosc);
            skrytobojca.AddSkills(sledzenie);
            skrytobojca.AddSkills(ukrywanieSie);
            skrytobojca.AddSkills(warzenieTrucizn);
            skrytobojca.AddSkills(wspinaczka);
            strzelec.AddSkills(plotkowanie);
            strzelec.AddSkills(przeszukiwanie);
            strzelec.AddSkills(spostrzegawczosc);
            strzelec.AddSkills(sztukaPrzetrwania);
            strzelec.AddSkills(wiedza);
            strzelec.AddSkills(zwinnePalce);
            szampierz.AddSkills(spostrzegawczosc);
            szampierz.AddSkills(unik);
            szarlatan.AddSkills(charakteryzacja);
            szarlatan.AddSkills(gadanina);
            szarlatan.AddSkills(hazard);
            szarlatan.AddSkills(plotkowanie);
            szarlatan.AddSkills(przekonywanie);
            szarlatan.AddSkills(sekretnyJezyk);
            szarlatan.AddSkills(spostrzegawczosc);
            szarlatan.AddSkills(targowanie);
            szarlatan.AddSkills(wiedza);
            szarlatan.AddSkills(wycena);
            szarlatan.AddSkills(jezyk);
            szarlatan.AddSkills(jezyk);
            szarlatan.AddSkills(zwinnePalce);
            szpieg.AddSkills(charakteryzacja);
            szpieg.AddSkills(czytanieZWarg);
            szpieg.AddSkills(kuglarstwo);
            szpieg.AddSkills(otwieranieZamkow);
            szpieg.AddSkills(plotkowanie);
            szpieg.AddSkills(przekonywanie);
            szpieg.AddSkills(sekretnyJezyk);
            szpieg.AddSkills(skradanie);
            szpieg.AddSkills(sledzenie);
            szpieg.AddSkills(ukrywanieSie);
            szpieg.AddSkills(wiedza);
            szpieg.AddSkills(wiedza);
            szpieg.AddSkills(jezyk);
            szpieg.AddSkills(jezyk);
            szpieg.AddSkills(jezyk);
            szpieg.AddSkills(zwinnePalce);
            uczony.AddSkills(czytaniePisanie);
            uczony.AddSkills(nauka);
            uczony.AddSkills(nauka);
            uczony.AddSkills(nauka);
            uczony.AddSkills(spostrzegawczosc);
            uczony.AddSkills(wiedza);
            uczony.AddSkills(wiedza);
            uczony.AddSkills(wiedza);
            uczony.AddSkills(wycena, rzemioslo);
            uczony.AddSkills(jezyk);
            uczony.AddSkills(jezyk);
            uczony.AddSkills(jezyk);
            uczony.AddSkills(jezyk);
            urzednik.AddSkills(czytaniePisanie);
            urzednik.AddSkills(dowodzenie);
            urzednik.AddSkills(gadanina);
            urzednik.AddSkills(kuglarstwo);
            urzednik.AddSkills(nauka);
            urzednik.AddSkills(nauka);
            urzednik.AddSkills(plotkowanie);
            urzednik.AddSkills(przekonywanie);
            urzednik.AddSkills(spostrzegawczosc);
            urzednik.AddSkills(targowanie);
            urzednik.AddSkills(wiedza);
            urzednik.AddSkills(wycena);
            urzednik.AddSkills(jezyk);
            weteran.AddSkills(hazard);
            weteran.AddSkills(mocnaGlowa);
            weteran.AddSkills(plotkowanie);
            weteran.AddSkills(sekretnyJezyk);
            weteran.AddSkills(spostrzegawczosc);
            weteran.AddSkills(unik);
            weteran.AddSkills(wiedza);
            weteran.AddSkills(zastraszanie);
            wedrownyCzarodziej.AddSkills(czytaniePisanie);
            wedrownyCzarodziej.AddSkills(jezdziectwo, plywanie);
            wedrownyCzarodziej.AddSkills(jezykTajemny);
            wedrownyCzarodziej.AddSkills(nauka);
            wedrownyCzarodziej.AddSkills(nauka);
            wedrownyCzarodziej.AddSkills(plotkowanie);
            wedrownyCzarodziej.AddSkills(przekonywanie, zastraszanie);
            wedrownyCzarodziej.AddSkills(splatanieMagii);
            wedrownyCzarodziej.AddSkills(wiedza);
            wedrownyCzarodziej.AddSkills(wiedza);
            wedrownyCzarodziej.AddSkills(wykrywanieMagii);
            wedrownyCzarodziej.AddSkills(jezyk);
            wedrownyCzarodziej.AddSkills(jezyk);
            wlamywacz.AddSkills(otwieranieZamkow);
            wlamywacz.AddSkills(plotkowanie);
            wlamywacz.AddSkills(przeszukiwanie);
            wlamywacz.AddSkills(sekretneZnaki);
            wlamywacz.AddSkills(sekretnyJezyk);
            wlamywacz.AddSkills(skradanie);
            wlamywacz.AddSkills(spostrzegawczosc);
            wlamywacz.AddSkills(targowanie);
            wlamywacz.AddSkills(ukrywanieSie);
            wlamywacz.AddSkills(wspinaczka);
            wlamywacz.AddSkills(wycena);
            wybraniecBozy.AddSkills(jezdziectwo, plywanie);
            wybraniecBozy.AddSkills(jezykTajemny);
            wybraniecBozy.AddSkills(leczenie);
            wybraniecBozy.AddSkills(nauka);
            wybraniecBozy.AddSkills(nauka);
            wybraniecBozy.AddSkills(nauka);
            wybraniecBozy.AddSkills(plotkowanie);
            wybraniecBozy.AddSkills(przekonywanie);
            wybraniecBozy.AddSkills(splatanieMagii);
            wybraniecBozy.AddSkills(wiedza);
            wybraniecBozy.AddSkills(wiedza);
            wybraniecBozy.AddSkills(wykrywanieMagii);
            wybraniecBozy.AddSkills(jezyk);
            wybraniecBozy.AddSkills(jezyk);
            zabojcaDemonow.AddSkills(mocnaGlowa);
            zabojcaDemonow.AddSkills(unik);
            zabojcaDemonow.AddSkills(wiedza);
            zabojcaDemonow.AddSkills(wiedza);
            zabojcaDemonow.AddSkills(wspinaczka);
            zabojcaDemonow.AddSkills(zastraszanie);
            zabojcaOlbrzymow.AddSkills(mocnaGlowa);
            zabojcaOlbrzymow.AddSkills(spostrzegawczosc);
            zabojcaOlbrzymow.AddSkills(unik);
            zabojcaOlbrzymow.AddSkills(wiedza);
            zabojcaOlbrzymow.AddSkills(zastraszanie);
            zakonnik.AddSkills(leczenie);
            zakonnik.AddSkills(nauka);
            zakonnik.AddSkills(opieka);
            zakonnik.AddSkills(spostrzegawczosc);
            zakonnik.AddSkills(sztukaPrzetrwania);
            zakonnik.AddSkills(wiedza);
            zakonnik.AddSkills(wiedza);
            zakonnik.AddSkills(jezyk);
            zakonnik.AddSkills(jezyk);
            zakonnik.AddSkills(jezyk);
            zwadzca.AddSkills(hazard);
            zwadzca.AddSkills(plotkowanie);
            zwadzca.AddSkills(przekonywanie);
            zwadzca.AddSkills(spostrzegawczosc);
            zwadzca.AddSkills(unik);
            zwadzca.AddSkills(zastraszanie);
            zwadzca.AddSkills(zwinnePalce);
            zwiadowca.AddSkills(jezdziectwo);
            zwiadowca.AddSkills(nawigacja);
            zwiadowca.AddSkills(opieka);
            zwiadowca.AddSkills(oswajanie);
            zwiadowca.AddSkills(sekretneZnaki);
            zwiadowca.AddSkills(sekretnyJezyk);
            zwiadowca.AddSkills(skradanie);
            zwiadowca.AddSkills(spostrzegawczosc);
            zwiadowca.AddSkills(tropienie);
            zwiadowca.AddSkills(ukrywanieSie);
            zwiadowca.AddSkills(unik);
            zwiadowca.AddSkills(wiedza);
            zwiadowca.AddSkills(wiedza);
            zwiadowca.AddSkills(jezyk);
            zwiadowca.AddSkills(jezyk);

            #endregion profession skills

            #region profession abilities

            akolita.AddAbilities(bardzoSilny, szybkiRefleks);
            akolita.AddAbilities(charyzmatyczny, urodzonyWojownik);
            akolita.AddAbilities(przemawianie);
            banita.AddAbilities(strzalMierzony, ogluszanie);
            banita.AddAbilities(wedrowiec, lotrzyk);
            berserker.AddAbilities(bronSpecjalna);
            berserker.AddAbilities(grozny);
            berserker.AddAbilities(szalBojowy);
            berserker.AddAbilities(szybkieWyciagniecie);
            chlop.AddAbilities(chodu, bronSpecjalna);
            chlop.AddAbilities(twardziel, wedrowiec);
            ciura.AddAbilities(chodu);
            ciura.AddAbilities(odpornoscNaChoroby, obiezyswiat);
            ciura.AddAbilities(twardziel, charyzmatyczny);
            ciura.AddAbilities(zylkaHandlowa, bijatyka);
            cyrkowiec.AddAbilities(bardzoSilny, bronSpecjalna, nasladowca, przemawianie, strzalMierzony, szybkiRefleks, szybkieWyciagniecie, woltyzerka, zapasy);
            cyrkowiec.AddAbilities(bardzoSilny, bronSpecjalna, nasladowca, przemawianie, strzalMierzony, szybkiRefleks, szybkieWyciagniecie, woltyzerka, zapasy);
            cyrulik.AddAbilities(charyzmatyczny, niezwykleOdporny);
            cyrulik.AddAbilities(chirurgia);
            cyrulik.AddAbilities(odpornoscNaChoroby, blyskotliwosc);
            fanatyk.AddAbilities(bronSpecjalna);
            fanatyk.AddAbilities(opanowanie, bardzoSilny);
            fanatyk.AddAbilities(przemawianie);
            fanatyk.AddAbilities(twardziel, charyzmatyczny);
            flisak.AddAbilities(obiezyswiat);
            flisak.AddAbilities(wyczucieKierunku);
            giermek.AddAbilities(bronSpecjalna);
            giermek.AddAbilities(etykieta);
            giermek.AddAbilities(silnyCios);
            gladiator.AddAbilities(bardzoSilny, odpornoscPsychiczna);
            gladiator.AddAbilities(bronSpecjalna);
            gladiator.AddAbilities(bronSpecjalna);
            gladiator.AddAbilities(bronSpecjalna);
            gladiator.AddAbilities(rozbrojenie, zapasy);
            gladiator.AddAbilities(silnyCios);
            gladiator.AddAbilities(szybkieWyciagniecie, morderczyAtak);
            goniec.AddAbilities(bardzoSzybki, szostyZmysl);
            goniec.AddAbilities(bardzoWytrzymaly, bardzoSilny);
            goniec.AddAbilities(blyskawicznePrzeladowanie);
            goniec.AddAbilities(chodu);
            goniec.AddAbilities(wyczucieKierunku);
            gornik.AddAbilities(bardzoWytrzymaly, urodzonyWojownik);
            gornik.AddAbilities(bronSpecjalna);
            gornik.AddAbilities(wyczucieKierunku);
            guslarz.AddAbilities(gusla);
            guslarz.AddAbilities(magiaProsta);
            hiena.AddAbilities(szczescie, szostyZmysl);
            hiena.AddAbilities(wykrywaniePulapek, grotolaz);
            kanciarz.AddAbilities(chodu, lotrzyk);
            kanciarz.AddAbilities(przemawianie);
            kanciarz.AddAbilities(szczescie, szostyZmysl);
            kozak.AddAbilities(bronSpecjalna);
            kozak.AddAbilities(morderczyAtak);
            lesnik.AddAbilities(bardzoSzybki, niezwykleOdporny);
            lesnik.AddAbilities(bronSpecjalna);
            lesnik.AddAbilities(wedrowiec);
            lowca.AddAbilities(blyskawicznePrzeladowanie);
            lowca.AddAbilities(strzelecWyborowy, wedrowiec);
            lowca.AddAbilities(szybkiRefleks, niezwykleOdporny);
            lowca.AddAbilities(twardziel, bronSpecjalna);
            lowcanagrod.AddAbilities(bronSpecjalna);
            lowcanagrod.AddAbilities(strzalMierzony, silnyCios);
            lowcanagrod.AddAbilities(strzelecWyborowy, ogluszanie);
            lowcanagrod.AddAbilities(wedrowiec);
            mieszczanin.AddAbilities(blyskotliwosc, charyzmatyczny);
            mieszczanin.AddAbilities(zylkaHandlowa);
            mytnik.AddAbilities(szybkiRefleks, strzelecWyborowy);
            najemnik.AddAbilities(blyskawicznePrzeladowanie, silnyCios);
            najemnik.AddAbilities(rozbrojenie, szybkieWyciagniecie);
            najemnik.AddAbilities(strzalMierzony, ogluszanie);
            ochotnik.AddAbilities(bronSpecjalna, blyskawicznePrzeladowanie);
            ochotnik.AddAbilities(silnyCios);
            ochroniarz.AddAbilities(bardzoSilny, niezwykleOdporny);
            ochroniarz.AddAbilities(bijatyka);
            ochroniarz.AddAbilities(bronSpecjalna);
            ochroniarz.AddAbilities(bronSpecjalna);
            ochroniarz.AddAbilities(ogluszanie);
            ochroniarz.AddAbilities(rozbrojenie, szybkieWyciagniecie);
            oprych.AddAbilities(morderczyAtak, zapasy);
            oprych.AddAbilities(odpornoscNaTrucizny, szybkieWyciagniecie);
            oprych.AddAbilities(ogluszanie);
            oprych.AddAbilities(opanowanie, szybkiRefleks);
            oprych.AddAbilities(rozbrojenie);
            paz.AddAbilities(etykieta);
            paz.AddAbilities(opanowanie, charyzmatyczny);
            paz.AddAbilities(zylkaHandlowa, obiezyswiat);
            podzegacz.AddAbilities(chodu);
            podzegacz.AddAbilities(opanowanie, bijatyka);
            podzegacz.AddAbilities(przemawianie);
            porywacz.AddAbilities(chodu);
            porywacz.AddAbilities(lotrzyk, odpornoscPsychiczna);
            porywacz.AddAbilities(odpornoscNaChoroby);
            poslaniec.AddAbilities(obiezyswiat);
            poslaniec.AddAbilities(wyczucieKierunku);
            przemytnik.AddAbilities(zylkaHandlowa, lotrzyk);
            przepatrywacz.AddAbilities(bronSpecjalna);
            przepatrywacz.AddAbilities(opanowanie, bardzoSilny);
            przepatrywacz.AddAbilities(wyczucieKierunku);
            przewoznik.AddAbilities(bronSpecjalna, bijatyka);
            przewoznik.AddAbilities(strzelecWyborowy, charyzmatyczny);
            rybak.AddAbilities(twardziel, blyskotliwosc);
            rybak.AddAbilities(wyczucieKierunku, bijatyka);
            rzecznik.AddAbilities(obiezyswiat, zylkaHandlowa);
            rzemieslnik.AddAbilities(zylkaHandlowa, blyskotliwosc);
            rzezimieszek.AddAbilities(bijatyka);
            rzezimieszek.AddAbilities(grozny, charyzmatyczny);
            rzezimieszek.AddAbilities(morderczyAtak);
            rzezimieszek.AddAbilities(ogluszanie);
            rzezimieszek.AddAbilities(rozbrojenie, szybkieWyciagniecie);
            rzezimieszek.AddAbilities(silnyCios);
            skryba.AddAbilities(poliglota);
            sluga.AddAbilities(bardzoWytrzymaly, szybkiRefleks);
            sluga.AddAbilities(czulySluch, chodu);
            sluga.AddAbilities(etykieta, twardziel);
            straznik.AddAbilities(ogluszanie);
            straznik.AddAbilities(opanowanie, blyskotliwosc);
            straznik.AddAbilities(rozbrojenie, bijatyka);
            straznik.AddAbilities(silnyCios);
            straznikDrog.AddAbilities(bronSpecjalna);
            straznikDrog.AddAbilities(szybkieWyciagniecie, blyskawicznePrzeladowanie);
            straznikPol.AddAbilities(bardzoSzybki, blyskotliwosc);
            straznikPol.AddAbilities(strzalPrecyzyjny, blyskawicznePrzeladowanie);
            straznikPol.AddAbilities(wedrowiec, szybkieWyciagniecie);
            straznikWiezienny.AddAbilities(bronSpecjalna);
            straznikWiezienny.AddAbilities(odpornoscNaChoroby);
            straznikWiezienny.AddAbilities(odpornoscNaTrucizny);
            straznikWiezienny.AddAbilities(zapasy);
            szczurolap.AddAbilities(bronSpecjalna);
            szczurolap.AddAbilities(grotolaz);
            szczurolap.AddAbilities(odpornoscNaChoroby);
            szczurolap.AddAbilities(odpornoscNaTrucizny);
            szermierz.AddAbilities(brawura, szybkiRefleks);
            szermierz.AddAbilities(bronSpecjalna);
            szermierz.AddAbilities(silnyCios);
            szermierz.AddAbilities(szybkieWyciagniecie, morderczyAtak);
            szlachcic.AddAbilities(blyskotliwosc, bronSpecjalna);
            szlachcic.AddAbilities(bronSpecjalna, intrygant);
            szlachcic.AddAbilities(etykieta);
            szlachcic.AddAbilities(szczescie, przemawianie);
            smieciarz.AddAbilities(opanowanie, lotrzyk);
            smieciarz.AddAbilities(twardziel, odpornoscNaChoroby);
            tarczownik.AddAbilities(czulySluch, opanowanie);
            tarczownik.AddAbilities(morderczyAtak);
            tarczownik.AddAbilities(ogluszanie);
            tarczownik.AddAbilities(silnyCios);
            tarczownik.AddAbilities(wyczucieKierunku);
            uczen.AddAbilities(blyskotliwosc, niezwykleOdporny);
            uczen.AddAbilities(magiaProsta);
            uczen.AddAbilities(zmyslMagii, dotykMocy);
            weglarz.AddAbilities(blyskotliwosc, bardzoSilny);
            weglarz.AddAbilities(chodu);
            wloczykij.AddAbilities(bardzoSilny, wedrowiec);
            wloczykij.AddAbilities(obiezyswiat);
            wloczykij.AddAbilities(strzelecWyborowy, wyczucieKierunku);
            wojownik.AddAbilities(blyskawicznePrzeladowanie, urodzonyWojownik);
            wojownik.AddAbilities(strzelecWyborowy, wedrowiec);
            woznica.AddAbilities(bronSpecjalna);
            woznica.AddAbilities(szybkieWyciagniecie, obiezyswiat);
            zabojcaTroli.AddAbilities(bijatyka);
            zabojcaTroli.AddAbilities(bronSpecjalna);
            zabojcaTroli.AddAbilities(rozbrojenie, szybkieWyciagniecie);
            zabojcaTroli.AddAbilities(silnyCios);
            zabojcaTroli.AddAbilities(szybkiRefleks, niezwykleOdporny);
            zabojcaTroli.AddAbilities(twardziel);
            zarzadca.AddAbilities(etykieta, geniuszArytmetyczny);
            zarzadca.AddAbilities(przemawianie);
            zlodziej.AddAbilities(geniuszArytmetyczny, wykrywaniePulapek);
            zlodziej.AddAbilities(ulicznik, lotrzyk);
            zak.AddAbilities(blyskotliwosc, charyzmatyczny);
            zak.AddAbilities(etykieta, poliglota);
            zak.AddAbilities(obiezyswiat, geniuszArytmetyczny);
            zeglarz.AddAbilities(obiezyswiat);
            zeglarz.AddAbilities(silnyCios, brawura);
            zeglarz.AddAbilities(twardziel, bijatyka);
            zolnierz.AddAbilities(bronSpecjalna);
            zolnierz.AddAbilities(morderczyAtak, blyskawicznePrzeladowanie);
            zolnierz.AddAbilities(ogluszanie, strzalPrecyzyjny);
            zolnierz.AddAbilities(rozbrojenie, szybkieWyciagniecie);
            zolnierz.AddAbilities(strzalMierzony, silnyCios);
            zolnierzOkretowy.AddAbilities(ogluszanie);
            zolnierzOkretowy.AddAbilities(rozbrojenie, szybkieWyciagniecie);
            zolnierzOkretowy.AddAbilities(silnyCios);
            arcykaplan.AddAbilities(dotykMocy, odpornosc);
            arcykaplan.AddAbilities(etykieta);
            arcykaplan.AddAbilities(magiaPowszechna);
            arcykaplan.AddAbilities(magiaPowszechna);
            arcykaplan.AddAbilities(pancerzWiary, morderczyPocisk);
            arcykaplan.AddAbilities(zmyslMagii, medytacja);
            arcymag.AddAbilities(czarnoksiestwo, medytacja);
            arcymag.AddAbilities(dotykMocy, twardziel);
            arcymag.AddAbilities(magiaPowszechna);
            arcymag.AddAbilities(magiaPowszechna);
            arcymag.AddAbilities(zmyslMagii, morderczyPocisk);
            arystokrata.AddAbilities(bronSpecjalna);
            arystokrata.AddAbilities(krasomostwo);
            arystokrata.AddAbilities(przemawianie);
            bard.AddAbilities(etykieta);
            bard.AddAbilities(przemawianie);
            biczownik.AddAbilities(bronSpecjalna);
            biczownik.AddAbilities(nieustraszony);
            biczownik.AddAbilities(silnyCios);
            bosman.AddAbilities(bijatyka);
            bosman.AddAbilities(obiezyswiat);
            bosman.AddAbilities(odpornoscNaChoroby);
            demagog.AddAbilities(bijatyka);
            demagog.AddAbilities(etykieta, lotrzyk);
            demagog.AddAbilities(krasomostwo);
            demagog.AddAbilities(przemawianie);
            dworzanin.AddAbilities(blyskotliwosc, charyzmatyczny);
            dworzanin.AddAbilities(intrygant, bronSpecjalna);
            dworzanin.AddAbilities(przemawianie);
            dworzanin.AddAbilities(zylkaHandlowa, etykieta);
            fechmistrz.AddAbilities(artylerzysta);
            fechmistrz.AddAbilities(bardzoSzybki, szybkiRefleks);
            fechmistrz.AddAbilities(blyskawicznePrzeladowanie);
            fechmistrz.AddAbilities(blyskawicznyBlok);
            fechmistrz.AddAbilities(bronSpecjalna);
            fechmistrz.AddAbilities(bronSpecjalna);
            fechmistrz.AddAbilities(bronSpecjalna);
            fechmistrz.AddAbilities(strzalPrecyzyjny);
            fechmistrz.AddAbilities(szybkieWyciagniecie);
            fechmistrz.AddAbilities(zapasy);
            herold.AddAbilities(etykieta);
            herold.AddAbilities(krasomostwo);
            herold.AddAbilities(przemawianie);
            herszt.AddAbilities(blyskawicznePrzeladowanie);
            herszt.AddAbilities(blyskawicznyBlok);
            herszt.AddAbilities(strzalPrecyzyjny);
            herszt.AddAbilities(strzalPrzebijajacy);
            herszt.AddAbilities(szybkieWyciagniecie);
            inzynier.AddAbilities(artylerzysta);
            inzynier.AddAbilities(bronSpecjalna);
            kapitan.AddAbilities(blyskawicznyBlok, brawura);
            kapitan.AddAbilities(bronSpecjalna);
            kapitan.AddAbilities(obiezyswiat);
            kapitan.AddAbilities(rozbrojenie);
            kapitan.AddAbilities(silnyCios);
            kaplan.AddAbilities(magiaProsta);
            kaplan.AddAbilities(morderczyAtak, ogluszanie);
            kaplan.AddAbilities(pancerzWiary, krasomostwo);
            karczmarz.AddAbilities(etykieta, lotrzyk);
            karczmarz.AddAbilities(ogluszanie);
            karczmarz.AddAbilities(zylkaHandlowa, bijatyka);
            ksiaze.AddAbilities(bronSpecjalna);
            ksiaze.AddAbilities(grozny);
            ksiaze.AddAbilities(lotrzyk);
            ksiaze.AddAbilities(odpornoscNaTrucizny);
            ksiaze.AddAbilities(przemawianie);
            ksiaze.AddAbilities(szostyZmysl);
            ksiaze.AddAbilities(zylkaHandlowa, intrygant);
            kupiec.AddAbilities(geniuszArytmetyczny);
            kupiec.AddAbilities(zylkaHandlowa, lotrzyk);
            lesnyDuch.AddAbilities(blyskawicznePrzeladowanie);
            lesnyDuch.AddAbilities(blyskawicznyBlok);
            lesnyDuch.AddAbilities(blyskawicznyBlok);
            lesnyDuch.AddAbilities(strzalPrecyzyjny);
            lesnyDuch.AddAbilities(strzalPrzebijajacy);
            lesnyDuch.AddAbilities(szybkieWyciagniecie);
            lesnyDuch.AddAbilities(twardziel, bardzoSzybki);
            lowcaCzarownic.AddAbilities(blyskawicznyBlok);
            lowcaCzarownic.AddAbilities(bronSpecjalna);
            lowcaCzarownic.AddAbilities(bronSpecjalna);
            lowcaCzarownic.AddAbilities(bronSpecjalna);
            lowcaCzarownic.AddAbilities(grozny);
            lowcaCzarownic.AddAbilities(odwaga);
            lowcaCzarownic.AddAbilities(przemawianie);
            lowcaCzarownic.AddAbilities(silnyCios);
            lowcaCzarownic.AddAbilities(szostyZmysl);
            lowcaCzarownic.AddAbilities(szybkiRefleks, strzelecWyborowy);
            lowcaWampirow.AddAbilities(bronSpecjalna);
            lowcaWampirow.AddAbilities(grotolaz);
            lowcaWampirow.AddAbilities(morderczyAtak);
            lowcaWampirow.AddAbilities(odwaga);
            lowcaWampirow.AddAbilities(silnyCios);
            lowcaWampirow.AddAbilities(strzalPrecyzyjny, blyskawicznePrzeladowanie);
            majordomus.AddAbilities(geniuszArytmetyczny);
            majordomus.AddAbilities(przemawianie);
            medyk.AddAbilities(chirurgia);
            medyk.AddAbilities(odpornoscNaChoroby);
            medyk.AddAbilities(ogluszanie);
            mistrzCieni.AddAbilities(bijatyka, brawura);
            mistrzCieni.AddAbilities(bronSpecjalna);
            mistrzCieni.AddAbilities(bronSpecjalna);
            mistrzCieni.AddAbilities(lotrzyk);
            mistrzCieni.AddAbilities(wykrywaniePulapek);
            mistrzGildii.AddAbilities(etykieta);
            mistrzGildii.AddAbilities(poliglota);
            mistrzGildii.AddAbilities(zylkaHandlowa);
            mistrzMagii.AddAbilities(czarnoksiestwo, odpornoscPsychiczna);
            mistrzMagii.AddAbilities(dotykMocy, morderczyPocisk);
            mistrzMagii.AddAbilities(magiaPowszechna);
            mistrzMagii.AddAbilities(magiaPowszechna);
            mistrzMagii.AddAbilities(zmyslMagii, medytacja);
            mistrzRzemiosla.AddAbilities(talentArtystyczny, etykieta);
            mistrzZakonny.AddAbilities(blyskawicznyBlok);
            mistrzZakonny.AddAbilities(bronSpecjalna);
            mistrzZakonny.AddAbilities(bronSpecjalna);
            mistrzZakonny.AddAbilities(etykieta);
            mistrzZakonny.AddAbilities(morderczyAtak);
            mistrzZakonny.AddAbilities(obiezyswiat);
            mistrzZakonny.AddAbilities(odwaga);
            mistrzZakonny.AddAbilities(ogluszanie);
            nawigator.AddAbilities(wyczucieKierunku);
            odkrywca.AddAbilities(obiezyswiat);
            odkrywca.AddAbilities(wyczucieKierunku, poliglota);
            oficer.AddAbilities(blyskawicznyBlok);
            oficer.AddAbilities(bronSpecjalna);
            oficer.AddAbilities(bronSpecjalna);
            oficer.AddAbilities(rozbrojenie, szybkieWyciagniecie);
            oprawca.AddAbilities(bronSpecjalna);
            oprawca.AddAbilities(grozny);
            oprawca.AddAbilities(zapasy);
            paser.AddAbilities(geniuszArytmetyczny);
            paser.AddAbilities(ogluszanie);
            paser.AddAbilities(zylkaHandlowa, lotrzyk);
            rajtar.AddAbilities(artylerzysta);
            rajtar.AddAbilities(blyskawicznePrzeladowanie);
            rajtar.AddAbilities(bronSpecjalna);
            rajtar.AddAbilities(silnyCios);
            rajtar.AddAbilities(strzalMierzony);
            rajtar.AddAbilities(strzalPrzebijajacy);
            rajtar.AddAbilities(szybkieWyciagniecie);
            reketer.AddAbilities(bijatyka);
            reketer.AddAbilities(grozny);
            reketer.AddAbilities(lotrzyk);
            reketer.AddAbilities(ogluszanie);
            reketer.AddAbilities(silnyCios);
            rozbojnik.AddAbilities(artylerzysta);
            rozbojnik.AddAbilities(brawura);
            rozbojnik.AddAbilities(bronSpecjalna);
            rozbojnik.AddAbilities(bronSpecjalna);
            rozbojnik.AddAbilities(etykieta);
            rozbojnik.AddAbilities(oburecznosc);
            rozbojnik.AddAbilities(strzalMierzony);
            rozbojnik.AddAbilities(strzalPrecyzyjny);
            rozbojnik.AddAbilities(woltyzerka);
            rycerz.AddAbilities(bronSpecjalna);
            rycerz.AddAbilities(bronSpecjalna);
            rycerz.AddAbilities(bronSpecjalna);
            rycerz.AddAbilities(silnyCios);
            sierzant.AddAbilities(bijatyka, zapasy);
            sierzant.AddAbilities(grozny, obiezyswiat);
            sierzant.AddAbilities(ogluszanie);
            sierzant.AddAbilities(silnyCios);
            skrytobojca.AddAbilities(bijatyka);
            skrytobojca.AddAbilities(blyskawicznyBlok);
            skrytobojca.AddAbilities(brawura);
            skrytobojca.AddAbilities(bronSpecjalna);
            skrytobojca.AddAbilities(bronSpecjalna);
            skrytobojca.AddAbilities(bronSpecjalna);
            skrytobojca.AddAbilities(lotrzyk);
            skrytobojca.AddAbilities(strzalMierzony);
            skrytobojca.AddAbilities(szybkieWyciagniecie);
            strzelec.AddAbilities(blyskawicznePrzeladowanie);
            strzelec.AddAbilities(bronSpecjalna);
            strzelec.AddAbilities(bronSpecjalna);
            strzelec.AddAbilities(strzalMierzony);
            strzelec.AddAbilities(strzalPrecyzyjny);
            strzelec.AddAbilities(strzalPrzebijajacy);
            szampierz.AddAbilities(blyskawicznyBlok);
            szampierz.AddAbilities(bronSpecjalna);
            szampierz.AddAbilities(bronSpecjalna);
            szampierz.AddAbilities(bronSpecjalna);
            szampierz.AddAbilities(bronSpecjalna);
            szarlatan.AddAbilities(chodu);
            szarlatan.AddAbilities(intrygant, lotrzyk);
            szarlatan.AddAbilities(nasladowca);
            szarlatan.AddAbilities(obiezyswiat);
            szarlatan.AddAbilities(przemawianie);
            szpieg.AddAbilities(charyzmatyczny, szostyZmysl);
            szpieg.AddAbilities(chodu);
            szpieg.AddAbilities(intrygant);
            szpieg.AddAbilities(poliglota);
            uczony.AddAbilities(poliglota);
            urzednik.AddAbilities(etykieta, lotrzyk);
            urzednik.AddAbilities(krasomostwo);
            urzednik.AddAbilities(przemawianie);
            urzednik.AddAbilities(zylkaHandlowa, intrygant);
            weteran.AddAbilities(blyskawicznePrzeladowanie, morderczyAtak);
            weteran.AddAbilities(bronSpecjalna);
            weteran.AddAbilities(bronSpecjalna);
            weteran.AddAbilities(niezwykleOdporny, bardzoSilny);
            weteran.AddAbilities(strzalPrecyzyjny, silnyCios);
            wedrownyCzarodziej.AddAbilities(dotykMocy, niezwykleOdporny);
            wedrownyCzarodziej.AddAbilities(magiaTajemna, magiaCzarnoksieska);
            wedrownyCzarodziej.AddAbilities(magiaPowszechna);
            wedrownyCzarodziej.AddAbilities(magiaPowszechna);
            wedrownyCzarodziej.AddAbilities(medytacja, morderczyPocisk);
            wedrownyCzarodziej.AddAbilities(zmyslMagii, czarnoksiestwo);
            wlamywacz.AddAbilities(bijatyka);
            wlamywacz.AddAbilities(lotrzyk);
            wlamywacz.AddAbilities(ulicznik);
            wlamywacz.AddAbilities(wykrywaniePulapek);
            wybraniecBozy.AddAbilities(magiaKaplanska);
            wybraniecBozy.AddAbilities(magiaPowszechna);
            wybraniecBozy.AddAbilities(magiaPowszechna);
            wybraniecBozy.AddAbilities(obiezyswiat, silnyCios);
            wybraniecBozy.AddAbilities(pancerzWiary, dotykMocy);
            wybraniecBozy.AddAbilities(zmyslMagii, medytacja);
            zabojcaDemonow.AddAbilities(blyskawicznyBlok);
            zabojcaDemonow.AddAbilities(niepokojacy);
            zabojcaOlbrzymow.AddAbilities(bronSpecjalna);
            zabojcaOlbrzymow.AddAbilities(morderczyAtak);
            zabojcaOlbrzymow.AddAbilities(nieustraszony);
            zabojcaOlbrzymow.AddAbilities(odpornoscNaTrucizny);
            zakonnik.AddAbilities(obiezyswiat);
            zwadzca.AddAbilities(artylerzysta);
            zwadzca.AddAbilities(brawura);
            zwadzca.AddAbilities(bronSpecjalna);
            zwadzca.AddAbilities(bronSpecjalna);
            zwadzca.AddAbilities(bronSpecjalna);
            zwadzca.AddAbilities(etykieta);
            zwadzca.AddAbilities(morderczyAtak);
            zwadzca.AddAbilities(oburecznosc, rozbrojenie);
            zwadzca.AddAbilities(silnyCios);
            zwadzca.AddAbilities(strzalMierzony);
            zwadzca.AddAbilities(strzalPrecyzyjny);
            zwadzca.AddAbilities(szybkieWyciagniecie);
            zwiadowca.AddAbilities(blyskawicznePrzeladowanie);
            zwiadowca.AddAbilities(bronSpecjalna);
            zwiadowca.AddAbilities(strzalPrecyzyjny, strzalPrzebijajacy);
            zwiadowca.AddAbilities(wyczucieKierunku);

            #endregion profession abilities

            #region profession connections

            akolita.AddOutputProfession(cyrulik.GetResult());
            akolita.AddOutputProfession(demagog.GetResult());
            akolita.AddOutputProfession(fanatyk.GetResult());
            akolita.AddOutputProfession(kaplan.GetResult());
            akolita.AddOutputProfession(skryba.GetResult());
            akolita.AddOutputProfession(zakonnik.GetResult());

            banita.AddOutputProfession(demagog.GetResult());
            banita.AddOutputProfession(rozbojnik.GetResult());
            banita.AddOutputProfession(weteran.GetResult());
            banita.AddOutputProfession(wloczykij.GetResult());
            banita.AddOutputProfession(zlodziej.GetResult());

            berserker.AddOutputProfession(gladiator.GetResult());
            berserker.AddOutputProfession(najemnik.GetResult());
            berserker.AddOutputProfession(sierzant.GetResult());
            berserker.AddOutputProfession(weteran.GetResult());
            berserker.AddOutputProfession(zeglarz.GetResult());

            chlop.AddOutputProfession(banita.GetResult());
            chlop.AddOutputProfession(fanatyk.GetResult());
            chlop.AddOutputProfession(ochotnik.GetResult());
            chlop.AddOutputProfession(rybak.GetResult());
            chlop.AddOutputProfession(rzemieslnik.GetResult());
            chlop.AddOutputProfession(sluga.GetResult());
            chlop.AddOutputProfession(smieciarz.GetResult());
            chlop.AddOutputProfession(urzednik.GetResult());
            chlop.AddOutputProfession(weglarz.GetResult());

            ciura.AddOutputProfession(przemytnik.GetResult());
            ciura.AddOutputProfession(rzemieslnik.GetResult());
            ciura.AddOutputProfession(sluga.GetResult());
            ciura.AddOutputProfession(szarlatan.GetResult());
            ciura.AddOutputProfession(szpieg.GetResult());
            ciura.AddOutputProfession(weglarz.GetResult());
            ciura.AddOutputProfession(wloczykij.GetResult());

            cyrkowiec.AddOutputProfession(bard.GetResult());
            cyrkowiec.AddOutputProfession(kanciarz.GetResult());
            cyrkowiec.AddOutputProfession(szarlatan.GetResult());
            cyrkowiec.AddOutputProfession(wloczykij.GetResult());
            cyrkowiec.AddOutputProfession(zlodziej.GetResult());

            cyrulik.AddOutputProfession(medyk.GetResult());
            cyrulik.AddOutputProfession(oprawca.GetResult());
            cyrulik.AddOutputProfession(porywacz.GetResult());
            cyrulik.AddOutputProfession(rzemieslnik.GetResult());
            cyrulik.AddOutputProfession(wloczykij.GetResult());

            fanatyk.AddOutputProfession(akolita.GetResult());
            fanatyk.AddOutputProfession(banita.GetResult());
            fanatyk.AddOutputProfession(biczownik.GetResult());
            fanatyk.AddOutputProfession(podzegacz.GetResult());
            fanatyk.AddOutputProfession(zakonnik.GetResult());

            flisak.AddOutputProfession(nawigator.GetResult());
            flisak.AddOutputProfession(przemytnik.GetResult());
            flisak.AddOutputProfession(rybak.GetResult());
            flisak.AddOutputProfession(zeglarz.GetResult());
            flisak.AddOutputProfession(zolnierzOkretowy.GetResult());

            giermek.AddOutputProfession(banita.GetResult());
            giermek.AddOutputProfession(rycerz.GetResult());
            giermek.AddOutputProfession(sierzant.GetResult());
            giermek.AddOutputProfession(szlachcic.GetResult());
            giermek.AddOutputProfession(weteran.GetResult());

            gladiator.AddOutputProfession(lowcanagrod.GetResult());
            gladiator.AddOutputProfession(najemnik.GetResult());
            gladiator.AddOutputProfession(rzezimieszek.GetResult());
            gladiator.AddOutputProfession(weteran.GetResult());
            gladiator.AddOutputProfession(zabojcaTroli.GetResult());

            goniec.AddOutputProfession(hiena.GetResult());
            goniec.AddOutputProfession(szczurolap.GetResult());
            goniec.AddOutputProfession(tarczownik.GetResult());
            goniec.AddOutputProfession(weteran.GetResult());
            goniec.AddOutputProfession(zwiadowca.GetResult());

            gornik.AddOutputProfession(inzynier.GetResult());
            gornik.AddOutputProfession(najemnik.GetResult());
            gornik.AddOutputProfession(przemytnik.GetResult());
            gornik.AddOutputProfession(tarczownik.GetResult());
            gornik.AddOutputProfession(weglarz.GetResult());
            gornik.AddOutputProfession(zwiadowca.GetResult());

            guslarz.AddOutputProfession(akolita.GetResult());
            guslarz.AddOutputProfession(banita.GetResult());
            guslarz.AddOutputProfession(szarlatan.GetResult());
            guslarz.AddOutputProfession(uczen.GetResult());
            guslarz.AddOutputProfession(wloczykij.GetResult());

            hiena.AddOutputProfession(lowcaWampirow.GetResult());
            hiena.AddOutputProfession(paser.GetResult());
            hiena.AddOutputProfession(szczurolap.GetResult());
            hiena.AddOutputProfession(tarczownik.GetResult());
            hiena.AddOutputProfession(zlodziej.GetResult());

            kanciarz.AddOutputProfession(banita.GetResult());
            kanciarz.AddOutputProfession(cyrkowiec.GetResult());
            kanciarz.AddOutputProfession(demagog.GetResult());
            kanciarz.AddOutputProfession(sluga.GetResult());
            kanciarz.AddOutputProfession(szarlatan.GetResult());
            kanciarz.AddOutputProfession(zlodziej.GetResult());

            kozak.AddOutputProfession(lowcanagrod.GetResult());
            kozak.AddOutputProfession(najemnik.GetResult());
            kozak.AddOutputProfession(sierzant.GetResult());
            kozak.AddOutputProfession(tarczownik.GetResult());
            kozak.AddOutputProfession(weteran.GetResult());

            lesnik.AddOutputProfession(banita.GetResult());
            lesnik.AddOutputProfession(lowca.GetResult());
            lesnik.AddOutputProfession(ochotnik.GetResult());
            lesnik.AddOutputProfession(wloczykij.GetResult());
            lesnik.AddOutputProfession(zwiadowca.GetResult());

            lowca.AddOutputProfession(gornik.GetResult());
            lowca.AddOutputProfession(lowcanagrod.GetResult());
            lowca.AddOutputProfession(straznikPol.GetResult());
            lowca.AddOutputProfession(strzelec.GetResult());
            lowca.AddOutputProfession(weglarz.GetResult());
            lowca.AddOutputProfession(wojownik.GetResult());
            lowca.AddOutputProfession(zwiadowca.GetResult());
            lowca.AddOutputProfession(zolnierz.GetResult());

            lowcanagrod.AddOutputProfession(lowcaWampirow.GetResult());
            lowcanagrod.AddOutputProfession(najemnik.GetResult());
            lowcanagrod.AddOutputProfession(rzezimieszek.GetResult());
            lowcanagrod.AddOutputProfession(strzelec.GetResult());
            lowcanagrod.AddOutputProfession(zwiadowca.GetResult());

            mieszczanin.AddOutputProfession(karczmarz.GetResult());
            mieszczanin.AddOutputProfession(kupiec.GetResult());
            mieszczanin.AddOutputProfession(ochotnik.GetResult());
            mieszczanin.AddOutputProfession(paser.GetResult());
            mieszczanin.AddOutputProfession(paz.GetResult());
            mieszczanin.AddOutputProfession(podzegacz.GetResult());
            mieszczanin.AddOutputProfession(rzemieslnik.GetResult());

            mytnik.AddOutputProfession(banita.GetResult());
            mytnik.AddOutputProfession(przewoznik.GetResult());
            mytnik.AddOutputProfession(rozbojnik.GetResult());
            mytnik.AddOutputProfession(straznikPol.GetResult());
            mytnik.AddOutputProfession(urzednik.GetResult());
            mytnik.AddOutputProfession(zlodziej.GetResult());
            mytnik.AddOutputProfession(zolnierz.GetResult());

            najemnik.AddOutputProfession(banita.GetResult());
            najemnik.AddOutputProfession(lowcanagrod.GetResult());
            najemnik.AddOutputProfession(ochroniarz.GetResult());
            najemnik.AddOutputProfession(sierzant.GetResult());
            najemnik.AddOutputProfession(tarczownik.GetResult());
            najemnik.AddOutputProfession(weteran.GetResult());

            ochotnik.AddOutputProfession(banita.GetResult());
            ochotnik.AddOutputProfession(mistrzRzemiosla.GetResult());
            ochotnik.AddOutputProfession(najemnik.GetResult());
            ochotnik.AddOutputProfession(poslaniec.GetResult());
            ochotnik.AddOutputProfession(sierzant.GetResult());
            ochotnik.AddOutputProfession(straznikPol.GetResult());
            ochotnik.AddOutputProfession(zlodziej.GetResult());

            ochroniarz.AddOutputProfession(lowcanagrod.GetResult());
            ochroniarz.AddOutputProfession(najemnik.GetResult());
            ochroniarz.AddOutputProfession(oprawca.GetResult());
            ochroniarz.AddOutputProfession(reketer.GetResult());
            ochroniarz.AddOutputProfession(rzezimieszek.GetResult());
            ochroniarz.AddOutputProfession(straznikWiezienny.GetResult());
            ochroniarz.AddOutputProfession(zarzadca.GetResult());

            oprych.AddOutputProfession(gladiator.GetResult());
            oprych.AddOutputProfession(najemnik.GetResult());
            oprych.AddOutputProfession(ochroniarz.GetResult());
            oprych.AddOutputProfession(oprawca.GetResult());
            oprych.AddOutputProfession(reketer.GetResult());

            paz.AddOutputProfession(giermek.GetResult());
            paz.AddOutputProfession(herold.GetResult());
            paz.AddOutputProfession(kanciarz.GetResult());
            paz.AddOutputProfession(majordomus.GetResult());
            paz.AddOutputProfession(zak.GetResult());

            podzegacz.AddOutputProfession(banita.GetResult());
            podzegacz.AddOutputProfession(demagog.GetResult());
            podzegacz.AddOutputProfession(fanatyk.GetResult());
            podzegacz.AddOutputProfession(kanciarz.GetResult());
            podzegacz.AddOutputProfession(szarlatan.GetResult());
            podzegacz.AddOutputProfession(urzednik.GetResult());

            porywacz.AddOutputProfession(paser.GetResult());
            porywacz.AddOutputProfession(szczurolap.GetResult());
            porywacz.AddOutputProfession(wlamywacz.GetResult());
            porywacz.AddOutputProfession(zlodziej.GetResult());
            porywacz.AddOutputProfession(zak.GetResult());

            poslaniec.AddOutputProfession(herold.GetResult());
            poslaniec.AddOutputProfession(straznikDrog.GetResult());
            poslaniec.AddOutputProfession(wojownik.GetResult());
            poslaniec.AddOutputProfession(woznica.GetResult());
            poslaniec.AddOutputProfession(zwiadowca.GetResult());
            poslaniec.AddOutputProfession(zolnierz.GetResult());

            przemytnik.AddOutputProfession(flisak.GetResult());
            przemytnik.AddOutputProfession(paser.GetResult());
            przemytnik.AddOutputProfession(przewoznik.GetResult());
            przemytnik.AddOutputProfession(szarlatan.GetResult());
            przemytnik.AddOutputProfession(tarczownik.GetResult());
            przemytnik.AddOutputProfession(zlodziej.GetResult());
            przemytnik.AddOutputProfession(zeglarz.GetResult());

            przepatrywacz.AddOutputProfession(najemnik.GetResult());
            przepatrywacz.AddOutputProfession(rozbojnik.GetResult());
            przepatrywacz.AddOutputProfession(straznikDrog.GetResult());
            przepatrywacz.AddOutputProfession(woznica.GetResult());
            przepatrywacz.AddOutputProfession(zwiadowca.GetResult());

            przewoznik.AddOutputProfession(flisak.GetResult());
            przewoznik.AddOutputProfession(przemytnik.GetResult());
            przewoznik.AddOutputProfession(rozbojnik.GetResult());
            przewoznik.AddOutputProfession(straznikDrog.GetResult());
            przewoznik.AddOutputProfession(zeglarz.GetResult());

            rybak.AddOutputProfession(kupiec.GetResult());
            rybak.AddOutputProfession(nawigator.GetResult());
            rybak.AddOutputProfession(ochotnik.GetResult());
            rybak.AddOutputProfession(zeglarz.GetResult());
            rybak.AddOutputProfession(zolnierzOkretowy.GetResult());

            rzecznik.AddOutputProfession(kanciarz.GetResult());
            rzecznik.AddOutputProfession(kupiec.GetResult());
            rzecznik.AddOutputProfession(szarlatan.GetResult());
            rzecznik.AddOutputProfession(wloczykij.GetResult());
            rzecznik.AddOutputProfession(zeglarz.GetResult());
            rzecznik.AddOutputProfession(zak.GetResult());

            rzemieslnik.AddOutputProfession(fanatyk.GetResult());
            rzemieslnik.AddOutputProfession(inzynier.GetResult());
            rzemieslnik.AddOutputProfession(kupiec.GetResult());
            rzemieslnik.AddOutputProfession(mistrzRzemiosla.GetResult());
            rzemieslnik.AddOutputProfession(ochotnik.GetResult());
            rzemieslnik.AddOutputProfession(rzecznik.GetResult());

            rzezimieszek.AddOutputProfession(gladiator.GetResult());
            rzezimieszek.AddOutputProfession(oprych.GetResult());
            rzezimieszek.AddOutputProfession(reketer.GetResult());
            rzezimieszek.AddOutputProfession(zlodziej.GetResult());
            rzezimieszek.AddOutputProfession(zwadzca.GetResult());

            skryba.AddOutputProfession(akolita.GetResult());
            skryba.AddOutputProfession(nawigator.GetResult());
            skryba.AddOutputProfession(podzegacz.GetResult());
            skryba.AddOutputProfession(uczen.GetResult());
            skryba.AddOutputProfession(uczony.GetResult());

            sluga.AddOutputProfession(ciura.GetResult());
            sluga.AddOutputProfession(karczmarz.GetResult());
            sluga.AddOutputProfession(mieszczanin.GetResult());
            sluga.AddOutputProfession(paz.GetResult());
            sluga.AddOutputProfession(podzegacz.GetResult());
            sluga.AddOutputProfession(poslaniec.GetResult());
            sluga.AddOutputProfession(szpieg.GetResult());
            sluga.AddOutputProfession(zlodziej.GetResult());

            straznik.AddOutputProfession(najemnik.GetResult());
            straznik.AddOutputProfession(reketer.GetResult());
            straznik.AddOutputProfession(rzemieslnik.GetResult());
            straznik.AddOutputProfession(sierzant.GetResult());
            straznik.AddOutputProfession(straznikDrog.GetResult());
            straznik.AddOutputProfession(zolnierz.GetResult());

            straznikDrog.AddOutputProfession(banita.GetResult());
            straznikDrog.AddOutputProfession(mytnik.GetResult());
            straznikDrog.AddOutputProfession(poslaniec.GetResult());
            straznikDrog.AddOutputProfession(przepatrywacz.GetResult());
            straznikDrog.AddOutputProfession(rozbojnik.GetResult());
            straznikDrog.AddOutputProfession(sierzant.GetResult());
            straznikDrog.AddOutputProfession(zwiadowca.GetResult());

            straznikPol.AddOutputProfession(lowcanagrod.GetResult());
            straznikPol.AddOutputProfession(lowcaWampirow.GetResult());
            straznikPol.AddOutputProfession(najemnik.GetResult());
            straznikPol.AddOutputProfession(wloczykij.GetResult());
            straznikPol.AddOutputProfession(zwiadowca.GetResult());

            straznikWiezienny.AddOutputProfession(ochroniarz.GetResult());
            straznikWiezienny.AddOutputProfession(oprawca.GetResult());
            straznikWiezienny.AddOutputProfession(straznik.GetResult());
            straznikWiezienny.AddOutputProfession(szczurolap.GetResult());
            straznikWiezienny.AddOutputProfession(zarzadca.GetResult());

            szczurolap.AddOutputProfession(porywacz.GetResult());
            szczurolap.AddOutputProfession(straznikWiezienny.GetResult());
            szczurolap.AddOutputProfession(smieciarz.GetResult());
            szczurolap.AddOutputProfession(tarczownik.GetResult());
            szczurolap.AddOutputProfession(wlamywacz.GetResult());
            szczurolap.AddOutputProfession(zlodziej.GetResult());

            szermierz.AddOutputProfession(kanciarz.GetResult());
            szermierz.AddOutputProfession(ochroniarz.GetResult());
            szermierz.AddOutputProfession(rozbojnik.GetResult());
            szermierz.AddOutputProfession(rzezimieszek.GetResult());
            szermierz.AddOutputProfession(zwadzca.GetResult());

            szlachcic.AddOutputProfession(dworzanin.GetResult());
            szlachcic.AddOutputProfession(giermek.GetResult());
            szlachcic.AddOutputProfession(kanciarz.GetResult());
            szlachcic.AddOutputProfession(rajtar.GetResult());
            szlachcic.AddOutputProfession(urzednik.GetResult());
            szlachcic.AddOutputProfession(zak.GetResult());

            smieciarz.AddOutputProfession(ciura.GetResult());
            smieciarz.AddOutputProfession(paser.GetResult());
            smieciarz.AddOutputProfession(porywacz.GetResult());
            smieciarz.AddOutputProfession(przemytnik.GetResult());
            smieciarz.AddOutputProfession(wlamywacz.GetResult());

            tarczownik.AddOutputProfession(gladiator.GetResult());
            tarczownik.AddOutputProfession(goniec.GetResult());
            tarczownik.AddOutputProfession(hiena.GetResult());
            tarczownik.AddOutputProfession(przemytnik.GetResult());
            tarczownik.AddOutputProfession(sierzant.GetResult());
            tarczownik.AddOutputProfession(weteran.GetResult());

            uczen.AddOutputProfession(skryba.GetResult());
            uczen.AddOutputProfession(uczony.GetResult());
            uczen.AddOutputProfession(wedrownyCzarodziej.GetResult());

            weglarz.AddOutputProfession(gornik.GetResult());
            weglarz.AddOutputProfession(lesnik.GetResult());
            weglarz.AddOutputProfession(lowca.GetResult());
            weglarz.AddOutputProfession(wloczykij.GetResult());
            weglarz.AddOutputProfession(zwiadowca.GetResult());

            wloczykij.AddOutputProfession(cyrkowiec.GetResult());
            wloczykij.AddOutputProfession(lesnik.GetResult());
            wloczykij.AddOutputProfession(smieciarz.GetResult());
            wloczykij.AddOutputProfession(zakonnik.GetResult());
            wloczykij.AddOutputProfession(zlodziej.GetResult());
            wloczykij.AddOutputProfession(zwiadowca.GetResult());

            wojownik.AddOutputProfession(lowca.GetResult());
            wojownik.AddOutputProfession(przepatrywacz.GetResult());
            wojownik.AddOutputProfession(weteran.GetResult());
            wojownik.AddOutputProfession(wloczykij.GetResult());
            wojownik.AddOutputProfession(zwiadowca.GetResult());

            woznica.AddOutputProfession(banita.GetResult());
            woznica.AddOutputProfession(mytnik.GetResult());
            woznica.AddOutputProfession(przemytnik.GetResult());
            woznica.AddOutputProfession(przewoznik.GetResult());
            woznica.AddOutputProfession(rozbojnik.GetResult());
            woznica.AddOutputProfession(straznikDrog.GetResult());
            woznica.AddOutputProfession(zwiadowca.GetResult());

            zabojcaTroli.AddOutputProfession(zabojcaOlbrzymow.GetResult());

            zarzadca.AddOutputProfession(mytnik.GetResult());
            zarzadca.AddOutputProfession(ochotnik.GetResult());
            zarzadca.AddOutputProfession(przemytnik.GetResult());
            zarzadca.AddOutputProfession(reketer.GetResult());
            zarzadca.AddOutputProfession(rzezimieszek.GetResult());
            zarzadca.AddOutputProfession(urzednik.GetResult());

            zlodziej.AddOutputProfession(cyrkowiec.GetResult());
            zlodziej.AddOutputProfession(hiena.GetResult());
            zlodziej.AddOutputProfession(kanciarz.GetResult());
            zlodziej.AddOutputProfession(paser.GetResult());
            zlodziej.AddOutputProfession(szarlatan.GetResult());
            zlodziej.AddOutputProfession(wlamywacz.GetResult());

            zak.AddOutputProfession(akolita.GetResult());
            zak.AddOutputProfession(cyrulik.GetResult());
            zak.AddOutputProfession(inzynier.GetResult());
            zak.AddOutputProfession(medyk.GetResult());
            zak.AddOutputProfession(podzegacz.GetResult());
            zak.AddOutputProfession(rzecznik.GetResult());
            zak.AddOutputProfession(uczen.GetResult());
            zak.AddOutputProfession(uczony.GetResult());

            zeglarz.AddOutputProfession(bosman.GetResult());
            zeglarz.AddOutputProfession(kanciarz.GetResult());
            zeglarz.AddOutputProfession(nawigator.GetResult());
            zeglarz.AddOutputProfession(przemytnik.GetResult());
            zeglarz.AddOutputProfession(zolnierzOkretowy.GetResult());

            zolnierz.AddOutputProfession(najemnik.GetResult());
            zolnierz.AddOutputProfession(przepatrywacz.GetResult());
            zolnierz.AddOutputProfession(sierzant.GetResult());
            zolnierz.AddOutputProfession(straznik.GetResult());
            zolnierz.AddOutputProfession(weteran.GetResult());
            zolnierz.AddOutputProfession(wloczykij.GetResult());

            zolnierzOkretowy.AddOutputProfession(banita.GetResult());
            zolnierzOkretowy.AddOutputProfession(bosman.GetResult());
            zolnierzOkretowy.AddOutputProfession(oprych.GetResult());
            zolnierzOkretowy.AddOutputProfession(przemytnik.GetResult());
            zolnierzOkretowy.AddOutputProfession(sierzant.GetResult());

            arcykaplan.AddOutputProfession(lowcaCzarownic.GetResult());
            arcykaplan.AddOutputProfession(uczony.GetResult());
            arcykaplan.AddOutputProfession(urzednik.GetResult());

            arcymag.AddOutputProfession(mistrzGildii.GetResult());
            arcymag.AddOutputProfession(odkrywca.GetResult());

            arystokrata.AddOutputProfession(kapitan.GetResult());
            arystokrata.AddOutputProfession(oficer.GetResult());
            arystokrata.AddOutputProfession(rycerz.GetResult());
            arystokrata.AddOutputProfession(uczony.GetResult());

            bard.AddOutputProfession(demagog.GetResult());
            bard.AddOutputProfession(rozbojnik.GetResult());
            bard.AddOutputProfession(szarlatan.GetResult());
            bard.AddOutputProfession(szpieg.GetResult());
            bard.AddOutputProfession(zak.GetResult());

            biczownik.AddOutputProfession(demagog.GetResult());
            biczownik.AddOutputProfession(kaplan.GetResult());
            biczownik.AddOutputProfession(oprawca.GetResult());
            biczownik.AddOutputProfession(weteran.GetResult());
            biczownik.AddOutputProfession(zolnierz.GetResult());

            bosman.AddOutputProfession(kapitan.GetResult());
            bosman.AddOutputProfession(kupiec.GetResult());
            bosman.AddOutputProfession(nawigator.GetResult());
            bosman.AddOutputProfession(odkrywca.GetResult());

            demagog.AddOutputProfession(herszt.GetResult());
            demagog.AddOutputProfession(ksiaze.GetResult());
            demagog.AddOutputProfession(najemnik.GetResult());
            demagog.AddOutputProfession(urzednik.GetResult());
            demagog.AddOutputProfession(zakonnik.GetResult());

            dworzanin.AddOutputProfession(arystokrata.GetResult());
            dworzanin.AddOutputProfession(majordomus.GetResult());
            dworzanin.AddOutputProfession(szarlatan.GetResult());
            dworzanin.AddOutputProfession(szpieg.GetResult());
            dworzanin.AddOutputProfession(urzednik.GetResult());
            dworzanin.AddOutputProfession(zwadzca.GetResult());

            fechmistrz.AddOutputProfession(lowcaCzarownic.GetResult());
            fechmistrz.AddOutputProfession(sierzant.GetResult());
            fechmistrz.AddOutputProfession(skrytobojca.GetResult());
            fechmistrz.AddOutputProfession(zwiadowca.GetResult());

            herold.AddOutputProfession(cyrkowiec.GetResult());
            herold.AddOutputProfession(dworzanin.GetResult());
            herold.AddOutputProfession(giermek.GetResult());
            herold.AddOutputProfession(odkrywca.GetResult());
            herold.AddOutputProfession(podzegacz.GetResult());
            herold.AddOutputProfession(urzednik.GetResult());

            herszt.AddOutputProfession(demagog.GetResult());
            herszt.AddOutputProfession(ksiaze.GetResult());
            herszt.AddOutputProfession(oficer.GetResult());
            herszt.AddOutputProfession(skrytobojca.GetResult());

            inzynier.AddOutputProfession(mistrzGildii.GetResult());
            inzynier.AddOutputProfession(mistrzRzemiosla.GetResult());
            inzynier.AddOutputProfession(odkrywca.GetResult());
            inzynier.AddOutputProfession(przemytnik.GetResult());
            inzynier.AddOutputProfession(rajtar.GetResult());

            kapitan.AddOutputProfession(arystokrata.GetResult());
            kapitan.AddOutputProfession(odkrywca.GetResult());
            kapitan.AddOutputProfession(szpieg.GetResult());
            kapitan.AddOutputProfession(uczony.GetResult());

            kaplan.AddOutputProfession(biczownik.GetResult());
            kaplan.AddOutputProfession(majordomus.GetResult());
            kaplan.AddOutputProfession(uczony.GetResult());
            kaplan.AddOutputProfession(wybraniecBozy.GetResult());

            karczmarz.AddOutputProfession(banita.GetResult());
            karczmarz.AddOutputProfession(kupiec.GetResult());
            karczmarz.AddOutputProfession(mieszczanin.GetResult());
            karczmarz.AddOutputProfession(paser.GetResult());
            karczmarz.AddOutputProfession(przemytnik.GetResult());

            ksiaze.AddOutputProfession(demagog.GetResult());
            ksiaze.AddOutputProfession(herszt.GetResult());
            ksiaze.AddOutputProfession(mistrzCieni.GetResult());
            ksiaze.AddOutputProfession(urzednik.GetResult());

            kupiec.AddOutputProfession(mistrzGildii.GetResult());
            kupiec.AddOutputProfession(ochotnik.GetResult());
            kupiec.AddOutputProfession(reketer.GetResult());
            kupiec.AddOutputProfession(szpieg.GetResult());
            kupiec.AddOutputProfession(urzednik.GetResult());

            lesnyDuch.AddOutputProfession(herszt.GetResult());
            lesnyDuch.AddOutputProfession(lowcaWampirow.GetResult());
            lesnyDuch.AddOutputProfession(oficer.GetResult());
            lesnyDuch.AddOutputProfession(strzelec.GetResult());

            lowcaCzarownic.AddOutputProfession(akolita.GetResult());
            lowcaCzarownic.AddOutputProfession(demagog.GetResult());
            lowcaCzarownic.AddOutputProfession(fechmistrz.GetResult());
            lowcaCzarownic.AddOutputProfession(mistrzZakonny.GetResult());
            lowcaCzarownic.AddOutputProfession(oficer.GetResult());

            lowcaWampirow.AddOutputProfession(akolita.GetResult());
            lowcaWampirow.AddOutputProfession(demagog.GetResult());
            lowcaWampirow.AddOutputProfession(lowcaCzarownic.GetResult());
            lowcaWampirow.AddOutputProfession(rycerz.GetResult());
            lowcaWampirow.AddOutputProfession(strzelec.GetResult());

            majordomus.AddOutputProfession(ksiaze.GetResult());
            majordomus.AddOutputProfession(kupiec.GetResult());
            majordomus.AddOutputProfession(paser.GetResult());
            majordomus.AddOutputProfession(szlachcic.GetResult());

            medyk.AddOutputProfession(mistrzGildii.GetResult());
            medyk.AddOutputProfession(szpieg.GetResult());
            medyk.AddOutputProfession(uczony.GetResult());
            medyk.AddOutputProfession(zakonnik.GetResult());

            mistrzCieni.AddOutputProfession(herszt.GetResult());
            mistrzCieni.AddOutputProfession(ksiaze.GetResult());
            mistrzCieni.AddOutputProfession(odkrywca.GetResult());
            mistrzCieni.AddOutputProfession(strzelec.GetResult());

            mistrzGildii.AddOutputProfession(ksiaze.GetResult());
            mistrzGildii.AddOutputProfession(reketer.GetResult());
            mistrzGildii.AddOutputProfession(urzednik.GetResult());

            mistrzMagii.AddOutputProfession(arcymag.GetResult());
            mistrzMagii.AddOutputProfession(odkrywca.GetResult());
            mistrzMagii.AddOutputProfession(uczony.GetResult());

            mistrzRzemiosla.AddOutputProfession(demagog.GetResult());
            mistrzRzemiosla.AddOutputProfession(inzynier.GetResult());
            mistrzRzemiosla.AddOutputProfession(kupiec.GetResult());
            mistrzRzemiosla.AddOutputProfession(mistrzGildii.GetResult());
            mistrzRzemiosla.AddOutputProfession(ochotnik.GetResult());

            mistrzZakonny.AddOutputProfession(arystokrata.GetResult());
            mistrzZakonny.AddOutputProfession(fechmistrz.GetResult());
            mistrzZakonny.AddOutputProfession(lowcaCzarownic.GetResult());
            mistrzZakonny.AddOutputProfession(oficer.GetResult());

            nawigator.AddOutputProfession(kapitan.GetResult());
            nawigator.AddOutputProfession(mistrzRzemiosla.GetResult());
            nawigator.AddOutputProfession(odkrywca.GetResult());
            nawigator.AddOutputProfession(uczony.GetResult());

            odkrywca.AddOutputProfession(kapitan.GetResult());
            odkrywca.AddOutputProfession(kupiec.GetResult());
            odkrywca.AddOutputProfession(oficer.GetResult());
            odkrywca.AddOutputProfession(szpieg.GetResult());

            oficer.AddOutputProfession(herszt.GetResult());
            oficer.AddOutputProfession(kupiec.GetResult());
            oficer.AddOutputProfession(odkrywca.GetResult());
            oficer.AddOutputProfession(podzegacz.GetResult());
            oficer.AddOutputProfession(urzednik.GetResult());

            oprawca.AddOutputProfession(medyk.GetResult());
            oprawca.AddOutputProfession(reketer.GetResult());
            oprawca.AddOutputProfession(zlodziej.GetResult());

            paser.AddOutputProfession(ksiaze.GetResult());
            paser.AddOutputProfession(mistrzCieni.GetResult());
            paser.AddOutputProfession(reketer.GetResult());
            paser.AddOutputProfession(szarlatan.GetResult());

            rajtar.AddOutputProfession(dworzanin.GetResult());
            rajtar.AddOutputProfession(rycerz.GetResult());
            rajtar.AddOutputProfession(sierzant.GetResult());
            rajtar.AddOutputProfession(weteran.GetResult());
            rajtar.AddOutputProfession(zwadzca.GetResult());

            reketer.AddOutputProfession(herold.GetResult());
            reketer.AddOutputProfession(mistrzCieni.GetResult());
            reketer.AddOutputProfession(paser.GetResult());
            reketer.AddOutputProfession(urzednik.GetResult());

            rozbojnik.AddOutputProfession(herszt.GetResult());
            rozbojnik.AddOutputProfession(mistrzCieni.GetResult());
            rozbojnik.AddOutputProfession(podzegacz.GetResult());
            rozbojnik.AddOutputProfession(sierzant.GetResult());
            rozbojnik.AddOutputProfession(zwadzca.GetResult());

            rycerz.AddOutputProfession(akolita.GetResult());
            rycerz.AddOutputProfession(arystokrata.GetResult());
            rycerz.AddOutputProfession(lowcaWampirow.GetResult());
            rycerz.AddOutputProfession(mistrzZakonny.GetResult());
            rycerz.AddOutputProfession(oficer.GetResult());

            sierzant.AddOutputProfession(oficer.GetResult());
            sierzant.AddOutputProfession(rycerz.GetResult());
            sierzant.AddOutputProfession(szampierz.GetResult());
            sierzant.AddOutputProfession(zwadzca.GetResult());

            skrytobojca.AddOutputProfession(fechmistrz.GetResult());
            skrytobojca.AddOutputProfession(herszt.GetResult());
            skrytobojca.AddOutputProfession(lowcaCzarownic.GetResult());
            skrytobojca.AddOutputProfession(kanciarz.GetResult());
            skrytobojca.AddOutputProfession(sierzant.GetResult());

            strzelec.AddOutputProfession(fechmistrz.GetResult());
            strzelec.AddOutputProfession(sierzant.GetResult());
            strzelec.AddOutputProfession(skrytobojca.GetResult());
            strzelec.AddOutputProfession(zwadzca.GetResult());

            szampierz.AddOutputProfession(fanatyk.GetResult());
            szampierz.AddOutputProfession(fechmistrz.GetResult());
            szampierz.AddOutputProfession(lowcaCzarownic.GetResult());
            szampierz.AddOutputProfession(sierzant.GetResult());
            szampierz.AddOutputProfession(skrytobojca.GetResult());

            szarlatan.AddOutputProfession(banita.GetResult());
            szarlatan.AddOutputProfession(demagog.GetResult());
            szarlatan.AddOutputProfession(szpieg.GetResult());
            szarlatan.AddOutputProfession(urzednik.GetResult());
            szarlatan.AddOutputProfession(wlamywacz.GetResult());

            szpieg.AddOutputProfession(mistrzCieni.GetResult());
            szpieg.AddOutputProfession(odkrywca.GetResult());
            szpieg.AddOutputProfession(reketer.GetResult());
            szpieg.AddOutputProfession(skrytobojca.GetResult());

            uczony.AddOutputProfession(kupiec.GetResult());
            uczony.AddOutputProfession(majordomus.GetResult());
            uczony.AddOutputProfession(medyk.GetResult());
            uczony.AddOutputProfession(odkrywca.GetResult());
            uczony.AddOutputProfession(uczen.GetResult());
            uczony.AddOutputProfession(zakonnik.GetResult());

            urzednik.AddOutputProfession(arystokrata.GetResult());
            urzednik.AddOutputProfession(demagog.GetResult());
            urzednik.AddOutputProfession(dworzanin.GetResult());
            urzednik.AddOutputProfession(ksiaze.GetResult());
            urzednik.AddOutputProfession(majordomus.GetResult());
            urzednik.AddOutputProfession(reketer.GetResult());

            weteran.AddOutputProfession(fechmistrz.GetResult());
            weteran.AddOutputProfession(herszt.GetResult());
            weteran.AddOutputProfession(sierzant.GetResult());
            weteran.AddOutputProfession(strzelec.GetResult());
            weteran.AddOutputProfession(szampierz.GetResult());

            wedrownyCzarodziej.AddOutputProfession(mistrzMagii.GetResult());
            wedrownyCzarodziej.AddOutputProfession(szarlatan.GetResult());
            wedrownyCzarodziej.AddOutputProfession(uczony.GetResult());

            wlamywacz.AddOutputProfession(ksiaze.GetResult());
            wlamywacz.AddOutputProfession(mistrzCieni.GetResult());
            wlamywacz.AddOutputProfession(paser.GetResult());
            wlamywacz.AddOutputProfession(reketer.GetResult());
            wlamywacz.AddOutputProfession(wloczykij.GetResult());

            wybraniecBozy.AddOutputProfession(arcykaplan.GetResult());
            wybraniecBozy.AddOutputProfession(biczownik.GetResult());
            wybraniecBozy.AddOutputProfession(demagog.GetResult());
            wybraniecBozy.AddOutputProfession(lowcaCzarownic.GetResult());
            wybraniecBozy.AddOutputProfession(uczony.GetResult());

            zabojcaOlbrzymow.AddOutputProfession(zabojcaDemonow.GetResult());

            zakonnik.AddOutputProfession(biczownik.GetResult());
            zakonnik.AddOutputProfession(demagog.GetResult());
            zakonnik.AddOutputProfession(kaplan.GetResult());
            zakonnik.AddOutputProfession(uczony.GetResult());

            zwadzca.AddOutputProfession(fechmistrz.GetResult());
            zwadzca.AddOutputProfession(kanciarz.GetResult());
            zwadzca.AddOutputProfession(rozbojnik.GetResult());
            zwadzca.AddOutputProfession(sierzant.GetResult());
            zwadzca.AddOutputProfession(skrytobojca.GetResult());

            zwiadowca.AddOutputProfession(herszt.GetResult());
            zwiadowca.AddOutputProfession(lesnyDuch.GetResult());
            zwiadowca.AddOutputProfession(lowcaWampirow.GetResult());
            zwiadowca.AddOutputProfession(odkrywca.GetResult());
            zwiadowca.AddOutputProfession(sierzant.GetResult());

            #endregion profession connections

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

            using var transaction = Database.BeginTransaction();
            try
            {
                Dictionaries.AddRange(dictionaries);
                Items.AddRange(itemResult);
                Skills.AddRange(skillResult);
                Abilities.AddRange(abilityResult);
                Statistics.AddRange(statisticsDataSet);
                Professions.AddRange(professionBuildersResult.Select(a => a.GetResult()).ToList());

                SaveChanges();

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProfessionProfession>().HasKey(a => new { a.EntranceProfessionId, a.OutputProfessionId });
            modelBuilder.Entity<ProfessionProfession>().HasOne(a => a.EntranceProfession).WithMany(a => a.OutputProfessions).HasForeignKey(a => a.EntranceProfessionId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ProfessionProfession>().HasOne(a => a.OutputProfession).WithMany(a => a.EntranceProfessions).HasForeignKey(a => a.OutputProfessionId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProfessionAbilities>().HasOne(a => a.Profession).WithMany(a => a.Abilities).HasForeignKey(a => a.ProfessionId);
            modelBuilder.Entity<ProfessionAbility>().HasOne(a => a.Ability).WithMany(a => a.Professions).HasForeignKey(a => a.AbilityId);
            modelBuilder.Entity<ProfessionAbility>().HasOne(a => a.ProfessionAbilities).WithMany(a => a.Abilities).HasForeignKey(a => a.ProfessionAbilitiesId);

            modelBuilder.Entity<ProfessionSkills>().HasOne(a => a.Profession).WithMany(a => a.Skills).HasForeignKey(a => a.ProfessionId);
            modelBuilder.Entity<ProfessionSkill>().HasOne(a => a.Skill).WithMany(a => a.Professions).HasForeignKey(a => a.SkillId);
            modelBuilder.Entity<ProfessionSkill>().HasOne(a => a.ProfessionSkills).WithMany(a => a.Skills).HasForeignKey(a => a.ProfessionSkillsId);

            modelBuilder.Entity<ProfessionItems>().HasOne(a => a.Profession).WithMany(a => a.Equipment).HasForeignKey(a => a.ProfessionId);
            modelBuilder.Entity<ProfessionItem>().HasKey(a => new { a.ProfessionsItemId, a.ItemId });
            modelBuilder.Entity<ProfessionItem>().HasOne(a => a.Item).WithMany(a => a.Professions).HasForeignKey(a => a.ItemId);
            modelBuilder.Entity<ProfessionItem>().HasOne(a => a.ProfessionItems).WithMany(a => a.Items).HasForeignKey(a => a.ProfessionsItemId);

            modelBuilder.Entity<DictionaryValueProfessionSkill>().HasKey(a => new { a.DictionaryValueId, a.ProfessionSkillId });
            modelBuilder.Entity<DictionaryValueProfessionSkill>().HasOne(a => a.DictionaryValue).WithMany(a => a.Skills).HasForeignKey(a => a.DictionaryValueId);
            modelBuilder.Entity<DictionaryValueProfessionSkill>().HasOne(a => a.ProfessionSkill).WithMany(a => a.AllowedValues).HasForeignKey(a => a.ProfessionSkillId);

            modelBuilder.Entity<DictionaryValueProfessionAbility>().HasKey(a => new { a.DictionaryValueId, a.ProfessionAbilityId });
            modelBuilder.Entity<DictionaryValueProfessionAbility>().HasOne(a => a.DictionaryValue).WithMany(a => a.Abilities).HasForeignKey(a => a.DictionaryValueId);
            modelBuilder.Entity<DictionaryValueProfessionAbility>().HasOne(a => a.ProfessionAbility).WithMany(a => a.AllowedValues).HasForeignKey(a => a.ProfessionAbilityId);

            modelBuilder.Entity<Statistic>().HasIndex(a => a.Type).IsUnique();

            modelBuilder.Entity<ProfessionStatistic>().HasKey(a => new { a.ProfessionId, a.StatisticId });

            modelBuilder.Entity<CharacterItem>().HasKey(a => new { a.CharacterId, a.ItemId });
            modelBuilder.Entity<CharacterProfession>().HasKey(a => new { a.CharacterId, a.ProfessionId });
            modelBuilder.Entity<CharacterSkill>().HasKey(a => new { a.CharacterId, a.SkillId });
            modelBuilder.Entity<CharacterAbility>().HasKey(a => new { a.CharacterId, a.AbilityId });
            modelBuilder.Entity<CharacterStatistic>().HasKey(a => new { a.CharacterId, a.StatisticId });
        }
    }
}