using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class SeedingBasicData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Artylerzysta" },
                    { 62, "Straszny" },
                    { 61, "Silny cios" },
                    { 60, "rozbrojenie" },
                    { 59, "Przerażajacy" },
                    { 58, "Przemawianie" },
                    { 57, "Poliglota" },
                    { 56, "Pancerz wiary" },
                    { 55, "Ożywieniec" },
                    { 54, "Opanowanie" },
                    { 53, "Ogłuszanie" },
                    { 52, "Odwaga" },
                    { 51, "odpornosc psychiczna" },
                    { 50, "odpornosc na trucizny" },
                    { 49, "odpornosc na magię" },
                    { 48, "odpornosc na choroby" },
                    { 47, "odpornosc na Chaos" },
                    { 46, "Odporność" },
                    { 63, "Strzał mierzony" },
                    { 64, "Strzał precyzyjny" },
                    { 65, "Strzał przebijający" },
                    { 66, "Strzelec wyborowy" },
                    { 85, "Żyłka handlowa" },
                    { 84, "Zmysł magii" },
                    { 83, "Zapiekła nienawiść" },
                    { 82, "Zapasy" },
                    { 81, "Wyostrzone zmysły" },
                    { 80, "Wykrywanie pułapek" },
                    { 79, "Wyczucie kierunku" },
                    { 78, "Woltyżerka" },
                    { 45, "Oburęczność" },
                    { 77, "Widzenie w ciemności" },
                    { 75, "Urodzony wojownik" },
                    { 74, "Ulicznik" },
                    { 73, "Twardziel" },
                    { 72, "Talent artystyczny" },
                    { 71, "Szybkie wyciągnięcie" },
                    { 70, "Szybki refleks" },
                    { 69, "Szósty zmysł" },
                    { 67, "Szał bojowy" },
                    { 76, "Wędrowiec" },
                    { 44, "Obieżyświat" },
                    { 68, "Szczęście" },
                    { 42, "Nieustraszony" },
                    { 19, "Dotyk mocy" },
                    { 18, "Czuły słuch" },
                    { 17, "Człowiek-guma" },
                    { 16, "Czarnoksięstwo" },
                    { 15, "Chodu!" },
                    { 14, "Chirurgia" },
                    { 13, "Charyzmatyczny" },
                    { 12, "Bystry wzrok" },
                    { 20, "Etykieta" },
                    { 10, "Broń naturalna" },
                    { 8, "Błyskotliwość" },
                    { 7, "Błyskawiczny blok" },
                    { 6, "Błyskawiczne przeładowanie" },
                    { 5, "Bijatyka" },
                    { 4, "Bardzo wytrzymały" },
                    { 3, "Bardzo szybki" },
                    { 2, "Bardzo silny" },
                    { 43, "Niezwykle odporny" },
                    { 9, "Brawura" },
                    { 21, "Geniusz arytmetyczny" },
                    { 11, "Broń specjalna (różne)" },
                    { 23, "Groźny" },
                    { 41, "Niepokojący" },
                    { 22, "Grotołaz" },
                    { 40, "Naśladowca" },
                    { 39, "Morderczy pocisk" },
                    { 38, "Morderczy atak" },
                    { 37, "Medytacja" },
                    { 35, "Magia prosta" },
                    { 34, "Magia powszechna" },
                    { 33, "Magia kapłańska" },
                    { 32, "Magia czarnoksięska" },
                    { 36, "Magia tajemna" },
                    { 31, "Łotrzyk" },
                    { 30, "Lewitacja" },
                    { 29, "Latanie" },
                    { 28, "Krzepki" },
                    { 27, "Krasomóstwo" },
                    { 26, "Krasnoludzki fach" },
                    { 25, "Intrygant" },
                    { 24, "Gusła" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ItemType", "MoneyType", "Name", "Price", "Rarity", "Weigth" },
                values: new object[,]
                {
                    { 144, (byte)10, (byte)2, "Kołki", 5, (byte)5, 5 },
                    { 142, (byte)10, (byte)1, "Kajdany", 5, (byte)4, 20 },
                    { 141, (byte)10, (byte)2, "Haczyk na ryby i żyłka", 3, (byte)5, 2 },
                    { 140, (byte)10, (byte)3, "Drewniany klin", 8, (byte)6, 2 },
                    { 135, (byte)9, (byte)2, "Sztućce drewniane", 5, (byte)6, 2 },
                    { 138, (byte)9, (byte)1, "Talia kart", 1, (byte)6, 1 },
                    { 136, (byte)9, (byte)1, "Sztućce metalowe", 3, (byte)5, 4 },
                    { 137, (byte)9, (byte)1, "Sztućce srebrne", 15, (byte)3, 3 },
                    { 145, (byte)10, (byte)1, "Kotwiczka do wspinaczki", 4, (byte)4, 20 },
                    { 139, (byte)10, (byte)2, "Drąg, cena za metr", 1, (byte)6, 10 },
                    { 146, (byte)10, (byte)1, "Książka drukowana", 100, (byte)1, 35 },
                    { 155, (byte)10, (byte)1, "Przybory do pisania", 10, (byte)4, 5 },
                    { 148, (byte)10, (byte)1, "Liczydło", 10, (byte)2, 5 },
                    { 149, (byte)10, (byte)2, "Łańcuch, cena za metr", 30, (byte)2, 5 },
                    { 150, (byte)10, (byte)2, "Łom", 10, (byte)5, 10 },
                    { 151, (byte)10, (byte)2, "Łopata", 25, (byte)5, 20 },
                    { 152, (byte)10, (byte)2, "Młot", 20, (byte)5, 40 },
                    { 153, (byte)10, (byte)1, "Narzędzia", 50, (byte)4, 50 },
                    { 154, (byte)10, (byte)2, "Potrzask", 1, (byte)5, 2 },
                    { 156, (byte)10, (byte)2, "Sztabka metalu", 25, (byte)4, 20 },
                    { 134, (byte)9, (byte)1, "Symbol religijny", 1, (byte)5, 5 },
                    { 157, (byte)10, (byte)1, "Wnyki", 2, (byte)5, 20 },
                    { 147, (byte)10, (byte)1, "Książka ilustrowana", 350, (byte)1, 50 },
                    { 133, (byte)9, (byte)2, "Pergamin", 5, (byte)2, 0 },
                    { 112, (byte)8, (byte)3, "Zapałka", 1, (byte)4, 0 },
                    { 131, (byte)9, (byte)2, "Papier", 1, (byte)1, 0 },
                    { 158, (byte)10, (byte)1, "Wytrychy", 10, (byte)4, 20 },
                    { 108, (byte)8, (byte)2, "Olej do latarni", 5, (byte)6, 5 },
                    { 109, (byte)8, (byte)3, "Pochodnia", 5, (byte)6, 5 },
                    { 110, (byte)8, (byte)2, "Świeczka łojowa", 3, (byte)6, 5 },
                    { 111, (byte)8, (byte)2, "Świeczka woskowa", 6, (byte)4, 5 },
                    { 113, (byte)9, (byte)1, "Zlota korona", 1, (byte)5, 0 },
                    { 114, (byte)9, (byte)3, "Pens", 1, (byte)7, 0 },
                    { 115, (byte)9, (byte)2, "Szyling", 1, (byte)6, 0 },
                    { 116, (byte)9, (byte)2, "Drabina", 10, (byte)5, 50 },
                    { 117, (byte)9, (byte)2, "Hubka i krzesiwo", 30, (byte)6, 5 },
                    { 118, (byte)9, (byte)2, "Imbryk", 30, (byte)6, 10 },
                    { 119, (byte)9, (byte)1, "Instrument muzyczny", 5, (byte)5, 5 },
                    { 120, (byte)9, (byte)1, "Kłódka dobrej jakości", 10, (byte)1, 5 },
                    { 121, (byte)9, (byte)1, "Kłódka zwykłej jakości", 1, (byte)5, 5 },
                    { 122, (byte)9, (byte)2, "Koc", 25, (byte)6, 10 },
                    { 123, (byte)9, (byte)1, "Kociołek", 1, (byte)6, 20 },
                    { 124, (byte)9, (byte)2, "Kości do gry", 6, (byte)6, 0 },
                    { 125, (byte)9, (byte)2, "Kufel drewniany", 10, (byte)6, 5 },
                    { 126, (byte)9, (byte)1, "Kufel ze szkła barwionego", 1, (byte)6, 5 },
                    { 127, (byte)9, (byte)1, "Lina", 1, (byte)5, 50 },
                    { 128, (byte)9, (byte)1, "Luneta", 100, (byte)2, 5 },
                    { 129, (byte)9, (byte)1, "Lustro", 10, (byte)2, 5 },
                    { 130, (byte)9, (byte)2, "Namiot", 15, (byte)5, 20 },
                    { 132, (byte)9, (byte)1, "Perfumy", 1, (byte)5, 0 },
                    { 159, (byte)10, (byte)1, "Zestaw do charakteryzacji", 5, (byte)3, 10 },
                    { 201, (byte)13, (byte)1, "Woda święcona", 10, (byte)3, 0 },
                    { 161, (byte)11, (byte)1, "Wóz", 90, (byte)5, 0 },
                    { 189, (byte)13, (byte)1, "Czarny lotos", 20, (byte)1, 0 },
                    { 190, (byte)13, (byte)1, "Grzybki Szalonego Kapelusznika", 30, (byte)1, 0 },
                    { 191, (byte)13, (byte)1, "Jad mantikory", 65, (byte)1, 0 },
                    { 192, (byte)13, (byte)1, "Korzeń mandragory", 25, (byte)1, 0 },
                    { 193, (byte)13, (byte)1, "Sercobój", 800, (byte)1, 0 },
                    { 194, (byte)13, (byte)1, "Szkarłatny Cień", 35, (byte)1, 0 },
                    { 195, (byte)13, (byte)1, "Ślina chimery", 150, (byte)1, 0 },
                    { 196, (byte)13, (byte)1, "Księga wiedzy tajemnej", 500, (byte)1, 0 },
                    { 197, (byte)13, (byte)3, "Napar kojący", 5, (byte)5, 0 },
                    { 198, (byte)13, (byte)1, "Odtrutki", 3, (byte)3, 0 },
                    { 188, (byte)13, (byte)1, "Czarny Jad", 30, (byte)1, 0 },
                    { 199, (byte)13, (byte)1, "Relikwia", 5, (byte)3, 0 },
                    { 107, (byte)8, (byte)1, "Latarnia sztormowa", 12, (byte)3, 30 },
                    { 202, (byte)13, (byte)1, "Dłoń weterana", 60, (byte)2, 0 },
                    { 203, (byte)13, (byte)2, "Drewniane zęby", 3, (byte)4, 0 },
                    { 204, (byte)13, (byte)2, "Kolczyk", 1, (byte)5, 0 },
                    { 205, (byte)13, (byte)3, "Opaska na oko", 6, (byte)5, 0 },
                    { 206, (byte)13, (byte)2, "Płytka czaszkowa", 1, (byte)4, 0 },
                    { 207, (byte)13, (byte)2, "Pozłacany nos", 6, (byte)3, 0 },
                    { 208, (byte)13, (byte)2, "Szklane oko", 1, (byte)4, 0 },
                    { 209, (byte)13, (byte)2, "Sztuczna noga", 6, (byte)4, 0 },
                    { 210, (byte)13, (byte)2, "Tatuaż", 3, (byte)4, 0 },
                    { 200, (byte)13, (byte)1, "Talizman szczęścia", 15, (byte)4, 0 },
                    { 187, (byte)13, (byte)1, "Piwo Bugmana", 50, (byte)1, 5 },
                    { 186, (byte)13, (byte)1, "Mikstura lecznicza", 5, (byte)4, 0 },
                    { 185, (byte)13, (byte)1, "Dar Grety", 30, (byte)1, 0 },
                    { 162, (byte)11, (byte)1, "Powóz", 500, (byte)2, 0 },
                    { 163, (byte)11, (byte)1, "Łódź rzeczna", 600, (byte)2, 0 },
                    { 164, (byte)11, (byte)1, "Łódź wiosłowa", 90, (byte)4, 900 },
                    { 165, (byte)11, (byte)1, "Statek", 12000, (byte)3, 0 },
                    { 166, (byte)11, (byte)1, "Rumak", 500, (byte)3, 0 },
                    { 167, (byte)11, (byte)1, "Lekki koń bojowy", 300, (byte)5, 0 },
                    { 168, (byte)11, (byte)1, "Koń", 80, (byte)5, 0 },
                    { 169, (byte)11, (byte)1, "Kuc", 50, (byte)5, 0 },
                    { 170, (byte)11, (byte)1, "Siodło", 5, (byte)5, 50 },
                    { 171, (byte)11, (byte)1, "Uprząż", 1, (byte)5, 20 },
                    { 172, (byte)12, (byte)1, "Gołąb pocztowy", 1, (byte)4, 0 },
                    { 173, (byte)12, (byte)1, "Jastrząb", 80, (byte)2, 0 },
                    { 174, (byte)12, (byte)1, "Koń juczny", 40, (byte)6, 0 },
                    { 175, (byte)12, (byte)1, "Koń pociągowy lub muł", 25, (byte)6, 0 },
                    { 176, (byte)12, (byte)2, "Kot", 1, (byte)6, 0 },
                    { 177, (byte)12, (byte)1, "Koza", 2, (byte)6, 0 },
                    { 178, (byte)12, (byte)1, "Krowa", 10, (byte)6, 0 },
                    { 179, (byte)12, (byte)3, "Kurczak", 5, (byte)6, 0 },
                    { 180, (byte)12, (byte)1, "Owca", 2, (byte)6, 0 },
                    { 181, (byte)12, (byte)1, "Pies (rasowy)", 3, (byte)6, 0 },
                    { 182, (byte)12, (byte)1, "Pies bojowy", 30, (byte)2, 0 },
                    { 183, (byte)12, (byte)1, "Świnia", 3, (byte)6, 0 },
                    { 184, (byte)12, (byte)1, "Wół", 30, (byte)6, 0 },
                    { 160, (byte)11, (byte)1, "Wózek", 50, (byte)5, 0 },
                    { 106, (byte)8, (byte)1, "Latarnia", 5, (byte)4, 20 },
                    { 143, (byte)10, (byte)2, "Kilof", 25, (byte)4, 20 },
                    { 104, (byte)8, (byte)2, "Drewno na opał", 2, (byte)6, 5 },
                    { 28, (byte)2, (byte)1, "Muszkiet hochlandzki", 450, (byte)1, 70 },
                    { 29, (byte)2, (byte)1, "Nóź/gwiazdka do rzucania", 3, (byte)5, 10 },
                    { 30, (byte)2, (byte)2, "Oszczep", 25, (byte)4, 50 },
                    { 31, (byte)2, (byte)1, "Pistolet", 200, (byte)1, 25 },
                    { 32, (byte)2, (byte)1, "Pistolet wielostrzałowy", 400, (byte)1, 25 },
                    { 33, (byte)2, (byte)1, "Proca", 4, (byte)5, 10 },
                    { 34, (byte)2, (byte)1, "Proca drzewcowa", 6, (byte)2, 50 },
                    { 35, (byte)2, (byte)1, "Rusznica", 300, (byte)1, 30 },
                    { 36, (byte)2, (byte)1, "Rusznica wielostrzałowa", 600, (byte)1, 30 },
                    { 37, (byte)2, (byte)1, "Sieć", 3, (byte)6, 60 },
                    { 38, (byte)2, (byte)1, "Topór/młot do rzucania", 5, (byte)4, 40 },
                    { 39, (byte)2, (byte)1, "Włócznia", 0, (byte)5, 30 },
                    { 40, (byte)3, (byte)2, "Strzały (5)", 1, (byte)5, 10 },
                    { 41, (byte)3, (byte)2, "Bełty (5)", 2, (byte)4, 10 },
                    { 42, (byte)3, (byte)2, "Kule do broni palnej (10)", 1, (byte)2, 10 },
                    { 43, (byte)3, (byte)2, "Proch strzelniczy (strzał)", 3, (byte)1, 1 },
                    { 44, (byte)4, (byte)1, "Hełm (Skórzana)", 3, (byte)5, 10 },
                    { 45, (byte)4, (byte)1, "Kaftan (Skórzana)", 5, (byte)5, 40 },
                    { 46, (byte)4, (byte)1, "Kurta (Skórzana)", 12, (byte)5, 50 },
                    { 47, (byte)4, (byte)1, "Nogawice (Skórzana)", 10, (byte)5, 20 },
                    { 48, (byte)4, (byte)1, "Skórznia (Skórzana)", 25, (byte)4, 80 },
                    { 49, (byte)4, (byte)1, "Czepiec (Kolcza)", 20, (byte)4, 30 },
                    { 50, (byte)4, (byte)1, "Kaftan (Kolcza)", 60, (byte)4, 60 },
                    { 27, (byte)2, (byte)1, "Łuk", 10, (byte)5, 80 },
                    { 51, (byte)4, (byte)1, "Koszulka (Kolcza)", 95, (byte)4, 80 },
                    { 26, (byte)2, (byte)1, "Kusza", 25, (byte)4, 120 },
                    { 23, (byte)2, (byte)1, "Krótki łuk", 7, (byte)5, 75 },
                    { 105, (byte)8, (byte)2, "Kaganek", 5, (byte)6, 20 },
                    { 1, (byte)1, (byte)1, "Halabarda", 15, (byte)5, 175 },
                    { 2, (byte)1, (byte)2, "Kij", 3, (byte)6, 50 },
                    { 3, (byte)1, (byte)1, "Kopia", 15, (byte)2, 100 },
                    { 4, (byte)1, (byte)1, "Korbacz", 15, (byte)3, 95 },
                    { 5, (byte)1, (byte)1, "Lanca", 20, (byte)3, 75 },
                    { 6, (byte)1, (byte)1, "Lewak", 2, (byte)3, 10 },
                    { 7, (byte)1, (byte)1, "Łamacz mieczy", 5, (byte)3, 40 },
                    { 8, (byte)1, (byte)1, "Morgensztern", 15, (byte)3, 60 },
                    { 9, (byte)1, (byte)1, "Puklerz", 4, (byte)4, 15 },
                    { 10, (byte)1, (byte)1, "Rapier", 18, (byte)3, 40 },
                    { 11, (byte)1, (byte)1, "Rękawica/kastet", 1, (byte)5, 1 },
                    { 12, (byte)1, (byte)1, "Szpada", 18, (byte)2, 40 },
                    { 13, (byte)1, (byte)1, "Sztylet", 1, (byte)5, 10 },
                    { 14, (byte)1, (byte)1, "Tarcza", 10, (byte)5, 50 },
                    { 15, (byte)1, (byte)1, "Włócznia", 10, (byte)5, 50 },
                    { 16, (byte)1, (byte)1, "Bron dwureczna", 0, (byte)7, 0 },
                    { 17, (byte)2, (byte)1, "Arkan", 1, (byte)6, 10 },
                    { 18, (byte)2, (byte)1, "Bicz", 2, (byte)4, 40 },
                    { 19, (byte)2, (byte)2, "Bolas", 7, (byte)3, 20 },
                    { 20, (byte)2, (byte)1, "Długi łuk", 15, (byte)4, 90 },
                    { 21, (byte)2, (byte)1, "Elfi łuk", 70, (byte)1, 75 },
                    { 22, (byte)2, (byte)1, "Garłacz", 70, (byte)1, 50 },
                    { 24, (byte)2, (byte)1, "Kusza pistoletowa", 35, (byte)2, 25 },
                    { 52, (byte)4, (byte)1, "Kolczuga (Kolcza)", 75, (byte)4, 80 },
                    { 25, (byte)2, (byte)1, "Kusza samopowtarzalna", 100, (byte)1, 150 },
                    { 54, (byte)4, (byte)1, "Nogawice (Kolcza)", 20, (byte)3, 40 },
                    { 81, (byte)6, (byte)3, "Doskonałe jedzenie (porcja na 1 dzień)", 18, (byte)4, 10 },
                    { 82, (byte)6, (byte)2, "Prowiant (porcja na 1 tydzień)", 6, (byte)5, 50 },
                    { 83, (byte)6, (byte)2, "Słodycze", 1, (byte)5, 2 },
                    { 84, (byte)6, (byte)2, "Smakołyki", 3, (byte)3, 0 },
                    { 85, (byte)6, (byte)3, "Ciemne piwo", 2, (byte)6, 2 },
                    { 86, (byte)6, (byte)3, "Jasne piwo", 1, (byte)7, 2 },
                    { 87, (byte)6, (byte)3, "Antałek piwa jasnego", 18, (byte)7, 30 },
                    { 88, (byte)6, (byte)2, "Antałek piwa ciemnego", 3, (byte)7, 30 },
                    { 89, (byte)6, (byte)2, "Butelka gorzałki", 1, (byte)4, 5 },
                    { 91, (byte)6, (byte)2, "Wino szlacheckie", 10, (byte)4, 5 },
                    { 80, (byte)6, (byte)3, "Dobre jedzenie (porcja na 1 dzień)", 10, (byte)5, 10 },
                    { 92, (byte)7, (byte)2, "Bukłak", 8, (byte)6, 1 },
                    { 94, (byte)7, (byte)1, "Juki", 2, (byte)4, 5 },
                    { 95, (byte)7, (byte)1, "Kuferek", 5, (byte)4, 40 },
                    { 96, (byte)7, (byte)1, "Manierka metalowa", 2, (byte)3, 15 },
                    { 97, (byte)7, (byte)2, "Manierska skórzana", 15, (byte)4, 5 },
                    { 98, (byte)7, (byte)2, "Mieszek", 2, (byte)6, 1 },
                    { 99, (byte)7, (byte)2, "Plecak", 30, (byte)6, 20 },
                    { 100, (byte)7, (byte)2, "Sakiewka", 5, (byte)6, 1 },
                    { 101, (byte)7, (byte)1, "Tobołek", 2, (byte)4, 5 },
                    { 102, (byte)7, (byte)1, "Tuba na mapy/pergaminy", 1, (byte)3, 2 },
                    { 53, (byte)4, (byte)1, "Kolczuga z rękawami (Kolcza)", 130, (byte)4, 100 },
                    { 93, (byte)7, (byte)2, "Flaszka", 4, (byte)6, 10 },
                    { 79, (byte)6, (byte)3, "Kiepskie jedzenie (porcja na 1 dzień)", 5, (byte)6, 10 },
                    { 90, (byte)6, (byte)2, "Wino pospolite", 1, (byte)5, 5 },
                    { 103, (byte)7, (byte)2, "Worek", 5, (byte)6, 7 },
                    { 55, (byte)4, (byte)1, "Zbroja kolcza (Kolcza)", 170, (byte)3, 210 },
                    { 78, (byte)6, (byte)2, "Połeć mięsa", 1, (byte)4, 10 },
                    { 56, (byte)4, (byte)1, "Hełm (płyta)", 30, (byte)3, 40 },
                    { 57, (byte)4, (byte)1, "Naramienniki (płyta)", 70, (byte)3, 75 },
                    { 58, (byte)4, (byte)1, "Nogawice (płyta)", 60, (byte)3, 30 },
                    { 59, (byte)4, (byte)1, "Napierśnik (płyta)", 70, (byte)3, 40 },
                    { 60, (byte)4, (byte)1, "Zbroja płytowa (płyta)", 400, (byte)2, 395 },
                    { 61, (byte)5, (byte)3, "Łachmany", 1, (byte)7, 5 },
                    { 63, (byte)5, (byte)1, "Zwykłe ubranie", 1, (byte)6, 15 },
                    { 64, (byte)5, (byte)1, "Dobre ubranie", 3, (byte)5, 15 },
                    { 65, (byte)5, (byte)1, "Szykowne ubranie", 10, (byte)4, 20 },
                    { 66, (byte)5, (byte)1, "Szaty", 15, (byte)4, 25 },
                    { 62, (byte)5, (byte)2, "Kiepskie odzienie", 10, (byte)7, 10 },
                    { 76, (byte)6, (byte)3, "Obrok (porcja na 1 dzień)", 5, (byte)6, 50 },
                    { 68, (byte)5, (byte)1, "Uniform", 15, (byte)3, 15 },
                    { 69, (byte)5, (byte)1, "Strój szlachecki", 50, (byte)2, 30 },
                    { 70, (byte)5, (byte)1, "Strój arystokraty", 100, (byte)1, 50 },
                    { 71, (byte)5, (byte)1, "Peleryna", 5, (byte)6, 10 },
                    { 72, (byte)5, (byte)1, "Płaszcz", 10, (byte)6, 15 },
                    { 73, (byte)5, (byte)2, "Kapelusz zwykły", 10, (byte)6, 15 },
                    { 74, (byte)5, (byte)1, "Kapelusz z szerokim rondlem", 1, (byte)6, 5 },
                    { 75, (byte)5, (byte)2, "Kaptur lub maska", 10, (byte)5, 2 },
                    { 67, (byte)5, (byte)1, "Kostium", 5, (byte)4, 10 },
                    { 77, (byte)6, (byte)3, "Bochenek chleba", 2, (byte)7, 2 }
                });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "AdditionalInformations", "Agility", "Attacks", "CloseCombat", "Description", "Hitpoints", "ImageId", "Inteligence", "Magic", "Name", "Polish", "ProfessionLevel", "ProfessionRaceAllowed", "Resistance", "Shooting", "Speed", "Stamina", "Willpower" },
                values: new object[,]
                {
                    { 75, null, (byte)20, (byte)0, (byte)10, null, (byte)4, null, (byte)10, (byte)0, "Karczmarz", (byte)20, (byte)2, (byte)15, (byte)10, (byte)5, (byte)0, (byte)5, (byte)10 },
                    { 76, null, (byte)20, (byte)1, (byte)20, null, (byte)6, null, (byte)25, (byte)0, "Książe złodzieji", (byte)30, (byte)2, (byte)15, (byte)15, (byte)20, (byte)0, (byte)15, (byte)20 },
                    { 77, null, (byte)10, (byte)0, (byte)10, null, (byte)4, null, (byte)25, (byte)0, "Kupiec", (byte)20, (byte)2, (byte)15, (byte)5, (byte)10, (byte)0, (byte)5, (byte)20 },
                    { 78, null, (byte)25, (byte)2, (byte)20, null, (byte)6, null, (byte)20, (byte)0, "Leśny duch", (byte)0, (byte)2, (byte)2, (byte)15, (byte)30, (byte)0, (byte)15, (byte)20 },
                    { 79, null, (byte)15, (byte)2, (byte)30, null, (byte)6, null, (byte)15, (byte)0, "Łowca czarownic", (byte)20, (byte)2, (byte)15, (byte)15, (byte)30, (byte)0, (byte)15, (byte)35 },
                    { 83, null, (byte)40, (byte)1, (byte)20, null, (byte)6, null, (byte)25, (byte)0, "Mistrz cieni", (byte)25, (byte)2, (byte)15, (byte)10, (byte)20, (byte)0, (byte)10, (byte)20 },
                    { 81, null, (byte)0, (byte)0, (byte)10, null, (byte)4, null, (byte)30, (byte)0, "Majordomus", (byte)25, (byte)2, (byte)15, (byte)10, (byte)10, (byte)0, (byte)10, (byte)20 },
                    { 82, null, (byte)15, (byte)0, (byte)0, null, (byte)4, null, (byte)30, (byte)0, "Medyk", (byte)15, (byte)2, (byte)15, (byte)10, (byte)0, (byte)0, (byte)10, (byte)20 },
                    { 74, null, (byte)5, (byte)0, (byte)10, null, (byte)4, null, (byte)10, (byte)0, "Kapłan", (byte)15, (byte)2, (byte)15, (byte)10, (byte)10, (byte)0, (byte)5, (byte)20 },
                    { 84, null, (byte)15, (byte)1, (byte)10, null, (byte)5, null, (byte)30, (byte)0, "Mistrz gildii", (byte)35, (byte)2, (byte)15, (byte)10, (byte)10, (byte)0, (byte)0, (byte)20 },
                    { 80, null, (byte)15, (byte)1, (byte)20, null, (byte)4, null, (byte)15, (byte)0, "Łowca wampirów", (byte)0, (byte)2, (byte)15, (byte)20, (byte)20, (byte)0, (byte)10, (byte)20 },
                    { 73, null, (byte)20, (byte)2, (byte)25, null, (byte)6, null, (byte)20, (byte)0, "Kapitan", (byte)30, (byte)2, (byte)15, (byte)20, (byte)20, (byte)0, (byte)15, (byte)25 },
                    { 62, null, (byte)20, (byte)0, (byte)15, null, (byte)5, null, (byte)35, (byte)4, "Arcymag", (byte)20, (byte)2, (byte)15, (byte)15, (byte)15, (byte)0, (byte)5, (byte)40 },
                    { 71, null, (byte)10, (byte)2, (byte)20, null, (byte)6, null, (byte)10, (byte)0, "Herszt banitów", (byte)20, (byte)2, (byte)15, (byte)20, (byte)30, (byte)0, (byte)10, (byte)10 },
                    { 70, null, (byte)15, (byte)0, (byte)10, null, (byte)4, null, (byte)15, (byte)0, "Herold", (byte)20, (byte)2, (byte)15, (byte)5, (byte)10, (byte)0, (byte)5, (byte)10 },
                    { 69, null, (byte)30, (byte)2, (byte)40, null, (byte)8, null, (byte)0, (byte)0, "Fechmistrz", (byte)0, (byte)2, (byte)15, (byte)25, (byte)40, (byte)0, (byte)25, (byte)20 },
                    { 68, null, (byte)10, (byte)0, (byte)5, null, (byte)4, null, (byte)20, (byte)0, "Dworzanin", (byte)20, (byte)2, (byte)15, (byte)0, (byte)5, (byte)0, (byte)0, (byte)20 },
                    { 67, null, (byte)15, (byte)1, (byte)10, null, (byte)4, null, (byte)20, (byte)0, "Demagog", (byte)30, (byte)2, (byte)15, (byte)10, (byte)10, (byte)0, (byte)0, (byte)15 },
                    { 66, null, (byte)10, (byte)1, (byte)15, null, (byte)4, null, (byte)10, (byte)0, "Bosman", (byte)10, (byte)2, (byte)15, (byte)15, (byte)15, (byte)0, (byte)10, (byte)10 },
                    { 65, "Bohater musi posiadać przynajmniej jedną chorobę umysłową", (byte)5, (byte)1, (byte)15, null, (byte)6, null, (byte)0, (byte)0, "Biczownik", (byte)10, (byte)2, (byte)15, (byte)15, (byte)0, (byte)0, (byte)10, (byte)20 },
                    { 64, null, (byte)15, (byte)0, (byte)10, null, (byte)4, null, (byte)10, (byte)0, "Bard", (byte)25, (byte)2, (byte)15, (byte)0, (byte)10, (byte)0, (byte)0, (byte)5 },
                    { 63, null, (byte)10, (byte)1, (byte)25, null, (byte)6, null, (byte)20, (byte)0, "Arystokrata", (byte)30, (byte)2, (byte)15, (byte)10, (byte)15, (byte)0, (byte)10, (byte)20 },
                    { 85, null, (byte)15, (byte)0, (byte)10, null, (byte)4, null, (byte)30, (byte)3, "Mistrz magii", (byte)15, (byte)2, (byte)15, (byte)10, (byte)10, (byte)0, (byte)0, (byte)35 },
                    { 60, null, (byte)5, (byte)1, (byte)10, null, (byte)3, null, (byte)0, (byte)0, "Żołnierz okrętowy", (byte)0, (byte)1, (byte)15, (byte)0, (byte)10, (byte)0, (byte)10, (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "AdditionalInformations", "Agility", "Attacks", "CloseCombat", "Description", "Hitpoints", "ImageId", "Inteligence", "Magic", "Name", "Polish", "ProfessionLevel", "ProfessionRaceAllowed", "Resistance", "Shooting", "Speed", "Stamina", "Willpower" },
                values: new object[,]
                {
                    { 72, null, (byte)10, (byte)0, (byte)10, null, (byte)4, null, (byte)20, (byte)0, "Inżynier", (byte)0, (byte)2, (byte)15, (byte)5, (byte)15, (byte)0, (byte)5, (byte)10 },
                    { 61, null, (byte)15, (byte)1, (byte)20, null, (byte)6, null, (byte)20, (byte)3, "Arcykapłan", (byte)25, (byte)2, (byte)15, (byte)15, (byte)20, (byte)0, (byte)15, (byte)30 },
                    { 110, "Bohater musi wcześniej zabić olbrzyma", (byte)10, (byte)1, (byte)25, null, (byte)6, null, (byte)0, (byte)0, "Zabójca olbrzymów", (byte)0, (byte)2, (byte)4, (byte)15, (byte)0, (byte)0, (byte)15, (byte)20 },
                    { 87, null, (byte)20, (byte)2, (byte)35, null, (byte)8, null, (byte)15, (byte)0, "Mistrz zakonny", (byte)15, (byte)2, (byte)15, (byte)20, (byte)10, (byte)0, (byte)20, (byte)25 },
                    { 113, null, (byte)15, (byte)1, (byte)20, null, (byte)6, null, (byte)20, (byte)0, "Zwiadowca", (byte)0, (byte)2, (byte)15, (byte)10, (byte)20, (byte)0, (byte)10, (byte)15 },
                    { 59, null, (byte)10, (byte)1, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Żołnierz", (byte)0, (byte)1, (byte)15, (byte)0, (byte)10, (byte)0, (byte)0, (byte)5 },
                    { 112, null, (byte)20, (byte)1, (byte)20, null, (byte)4, null, (byte)15, (byte)0, "Zwadźca", (byte)10, (byte)2, (byte)15, (byte)20, (byte)20, (byte)0, (byte)10, (byte)15 },
                    { 111, null, (byte)0, (byte)0, (byte)10, null, (byte)4, null, (byte)15, (byte)0, "Zakonnik", (byte)15, (byte)2, (byte)15, (byte)10, (byte)0, (byte)0, (byte)5, (byte)15 },
                    { 109, null, (byte)20, (byte)2, (byte)40, null, (byte)8, null, (byte)0, (byte)0, "Zabójca demonów", (byte)0, (byte)2, (byte)4, (byte)30, (byte)0, (byte)0, (byte)30, (byte)30 },
                    { 108, null, (byte)10, (byte)1, (byte)15, null, (byte)5, null, (byte)15, (byte)2, "Wybraniec boży", (byte)20, (byte)2, (byte)15, (byte)10, (byte)15, (byte)0, (byte)10, (byte)25 },
                    { 107, null, (byte)25, (byte)0, (byte)10, null, (byte)4, null, (byte)10, (byte)0, "Włamywacz", (byte)0, (byte)2, (byte)15, (byte)5, (byte)10, (byte)0, (byte)5, (byte)10 },
                    { 106, null, (byte)10, (byte)0, (byte)5, null, (byte)3, null, (byte)20, (byte)2, "Wędrowny czarodziej", (byte)10, (byte)2, (byte)15, (byte)5, (byte)5, (byte)0, (byte)0, (byte)25 },
                    { 105, null, (byte)15, (byte)1, (byte)20, null, (byte)6, null, (byte)0, (byte)0, "Weteran", (byte)0, (byte)2, (byte)15, (byte)10, (byte)20, (byte)0, (byte)10, (byte)15 },
                    { 104, null, (byte)0, (byte)0, (byte)5, null, (byte)4, null, (byte)20, (byte)0, "Urzędnik", (byte)20, (byte)2, (byte)15, (byte)10, (byte)5, (byte)0, (byte)5, (byte)10 },
                    { 103, null, (byte)10, (byte)0, (byte)5, null, (byte)4, null, (byte)30, (byte)0, "Uczony", (byte)15, (byte)2, (byte)15, (byte)5, (byte)5, (byte)0, (byte)5, (byte)15 },
                    { 102, null, (byte)20, (byte)1, (byte)15, null, (byte)4, null, (byte)20, (byte)0, "Szpieg", (byte)20, (byte)2, (byte)15, (byte)10, (byte)15, (byte)0, (byte)5, (byte)35 },
                    { 86, null, (byte)20, (byte)0, (byte)0, null, (byte)3, null, (byte)10, (byte)0, "Mistrz rzemiosła", (byte)10, (byte)2, (byte)15, (byte)10, (byte)0, (byte)0, (byte)10, (byte)10 },
                    { 101, null, (byte)15, (byte)0, (byte)10, null, (byte)4, null, (byte)15, (byte)0, "Szarlatan", (byte)25, (byte)2, (byte)15, (byte)10, (byte)10, (byte)0, (byte)5, (byte)15 },
                    { 99, null, (byte)25, (byte)1, (byte)0, null, (byte)4, null, (byte)10, (byte)0, "Strzelec", (byte)15, (byte)2, (byte)15, (byte)10, (byte)35, (byte)0, (byte)10, (byte)20 },
                    { 98, null, (byte)30, (byte)2, (byte)25, null, (byte)4, null, (byte)20, (byte)0, "Skrytobójca", (byte)20, (byte)2, (byte)15, (byte)10, (byte)25, (byte)0, (byte)10, (byte)10 },
                    { 97, null, (byte)10, (byte)1, (byte)20, null, (byte)4, null, (byte)10, (byte)0, "Sierżant", (byte)20, (byte)2, (byte)15, (byte)10, (byte)15, (byte)0, (byte)10, (byte)10 },
                    { 96, null, (byte)15, (byte)1, (byte)25, null, (byte)4, null, (byte)5, (byte)0, "Rycerz", (byte)5, (byte)2, (byte)15, (byte)15, (byte)0, (byte)0, (byte)15, (byte)15 },
                    { 95, null, (byte)30, (byte)1, (byte)20, null, (byte)4, null, (byte)20, (byte)0, "Rozbójnik", (byte)25, (byte)2, (byte)15, (byte)10, (byte)20, (byte)0, (byte)10, (byte)15 },
                    { 94, null, (byte)10, (byte)1, (byte)20, null, (byte)5, null, (byte)0, (byte)0, "Reketer", (byte)10, (byte)2, (byte)15, (byte)10, (byte)15, (byte)0, (byte)15, (byte)15 },
                    { 93, null, (byte)15, (byte)1, (byte)20, null, (byte)4, null, (byte)0, (byte)0, "Rajtar", (byte)15, (byte)2, (byte)15, (byte)10, (byte)20, (byte)0, (byte)10, (byte)15 },
                    { 92, null, (byte)10, (byte)1, (byte)15, null, (byte)4, null, (byte)5, (byte)0, "Paser", (byte)10, (byte)2, (byte)15, (byte)5, (byte)10, (byte)0, (byte)10, (byte)10 },
                    { 91, null, (byte)10, (byte)0, (byte)15, null, (byte)4, null, (byte)10, (byte)0, "Oprawca", (byte)15, (byte)2, (byte)15, (byte)10, (byte)0, (byte)0, (byte)20, (byte)20 },
                    { 90, null, (byte)20, (byte)2, (byte)30, null, (byte)7, null, (byte)15, (byte)0, "Oficer", (byte)25, (byte)2, (byte)15, (byte)20, (byte)20, (byte)0, (byte)20, (byte)15 },
                    { 89, null, (byte)15, (byte)1, (byte)20, null, (byte)6, null, (byte)25, (byte)0, "Odkrywca", (byte)15, (byte)2, (byte)15, (byte)15, (byte)20, (byte)0, (byte)10, (byte)20 },
                    { 88, null, (byte)10, (byte)0, (byte)10, null, (byte)4, null, (byte)25, (byte)0, "Nawigator", (byte)0, (byte)2, (byte)15, (byte)5, (byte)10, (byte)0, (byte)5, (byte)10 },
                    { 100, null, (byte)20, (byte)2, (byte)35, null, (byte)6, null, (byte)10, (byte)0, "Szampierz", (byte)0, (byte)2, (byte)15, (byte)15, (byte)0, (byte)0, (byte)15, (byte)15 },
                    { 58, null, (byte)10, (byte)1, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Żeglarz", (byte)0, (byte)1, (byte)15, (byte)0, (byte)5, (byte)0, (byte)10, (byte)0 },
                    { 28, null, (byte)5, (byte)0, (byte)5, null, (byte)2, null, (byte)10, (byte)0, "Podżegacz", (byte)10, (byte)1, (byte)15, (byte)0, (byte)5, (byte)0, (byte)0, (byte)0 },
                    { 56, null, (byte)15, (byte)0, (byte)5, null, (byte)2, null, (byte)5, (byte)0, "Złodziej", (byte)10, (byte)1, (byte)15, (byte)0, (byte)5, (byte)0, (byte)0, (byte)0 },
                    { 25, null, (byte)5, (byte)1, (byte)10, null, (byte)3, null, (byte)0, (byte)0, "Ochroniarz", (byte)0, (byte)1, (byte)15, (byte)5, (byte)0, (byte)0, (byte)5, (byte)0 },
                    { 24, null, (byte)10, (byte)0, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Ochotnik", (byte)0, (byte)1, (byte)15, (byte)5, (byte)5, (byte)0, (byte)5, (byte)0 },
                    { 23, null, (byte)5, (byte)1, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Najemnik", (byte)0, (byte)1, (byte)15, (byte)5, (byte)10, (byte)0, (byte)5, (byte)5 },
                    { 22, null, (byte)5, (byte)0, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Mytnik", (byte)0, (byte)1, (byte)15, (byte)10, (byte)5, (byte)0, (byte)5, (byte)5 },
                    { 21, null, (byte)5, (byte)0, (byte)5, null, (byte)2, null, (byte)10, (byte)0, "Mieszczanin", (byte)5, (byte)1, (byte)15, (byte)0, (byte)0, (byte)0, (byte)0, (byte)5 },
                    { 20, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)0, (byte)0, "Łowca nagród", (byte)0, (byte)1, (byte)15, (byte)0, (byte)10, (byte)0, (byte)5, (byte)5 },
                    { 19, null, (byte)10, (byte)0, (byte)0, null, (byte)3, null, (byte)5, (byte)0, "Łowca", (byte)0, (byte)1, (byte)15, (byte)5, (byte)15, (byte)0, (byte)0, (byte)0 },
                    { 18, null, (byte)5, (byte)0, (byte)10, null, (byte)3, null, (byte)0, (byte)0, "Leśnik", (byte)0, (byte)1, (byte)15, (byte)0, (byte)0, (byte)0, (byte)10, (byte)10 },
                    { 17, null, (byte)0, (byte)0, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Kozak kislevski", (byte)0, (byte)1, (byte)15, (byte)10, (byte)10, (byte)0, (byte)0, (byte)10 },
                    { 16, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)5, (byte)0, "Kanciarz", (byte)10, (byte)1, (byte)15, (byte)0, (byte)5, (byte)0, (byte)0, (byte)5 },
                    { 15, null, (byte)10, (byte)0, (byte)10, null, (byte)2, null, (byte)10, (byte)0, "Hiena cmentarna", (byte)5, (byte)1, (byte)15, (byte)0, (byte)0, (byte)0, (byte)0, (byte)10 },
                    { 14, null, (byte)5, (byte)0, (byte)0, null, (byte)2, null, (byte)5, (byte)1, "Guślarz", (byte)10, (byte)1, (byte)15, (byte)5, (byte)0, (byte)0, (byte)0, (byte)10 },
                    { 13, null, (byte)0, (byte)0, (byte)5, null, (byte)2, null, (byte)5, (byte)0, "Górnik", (byte)0, (byte)1, (byte)15, (byte)5, (byte)5, (byte)0, (byte)10, (byte)5 },
                    { 12, null, (byte)10, (byte)0, (byte)10, null, (byte)2, null, (byte)5, (byte)0, "Goniec", (byte)0, (byte)1, (byte)15, (byte)5, (byte)0, (byte)1, (byte)5, (byte)5 },
                    { 11, null, (byte)10, (byte)0, (byte)15, null, (byte)2, null, (byte)0, (byte)0, "Gladiator", (byte)0, (byte)1, (byte)15, (byte)10, (byte)0, (byte)0, (byte)0, (byte)10 },
                    { 10, null, (byte)5, (byte)1, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Giermek", (byte)5, (byte)1, (byte)15, (byte)5, (byte)5, (byte)0, (byte)5, (byte)0 },
                    { 9, null, (byte)10, (byte)0, (byte)10, null, (byte)2, null, (byte)5, (byte)0, "Flisak", (byte)0, (byte)1, (byte)15, (byte)5, (byte)5, (byte)0, (byte)5, (byte)0 },
                    { 8, null, (byte)0, (byte)0, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Fanatyk", (byte)5, (byte)1, (byte)15, (byte)10, (byte)0, (byte)0, (byte)5, (byte)10 },
                    { 7, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)10, (byte)0, "Cyrulik", (byte)5, (byte)1, (byte)15, (byte)0, (byte)0, (byte)0, (byte)0, (byte)10 },
                    { 6, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)0, (byte)0, "Cyrkowiec", (byte)10, (byte)1, (byte)15, (byte)0, (byte)10, (byte)0, (byte)0, (byte)5 },
                    { 5, null, (byte)10, (byte)0, (byte)0, null, (byte)2, null, (byte)5, (byte)0, "Ciura obozowa", (byte)10, (byte)1, (byte)15, (byte)5, (byte)0, (byte)0, (byte)0, (byte)5 },
                    { 57, null, (byte)10, (byte)0, (byte)0, null, (byte)2, null, (byte)10, (byte)0, "Żak", (byte)10, (byte)1, (byte)15, (byte)0, (byte)0, (byte)0, (byte)0, (byte)5 },
                    { 3, null, (byte)0, (byte)0, (byte)15, null, (byte)2, null, (byte)0, (byte)0, "Berserker z norski", (byte)0, (byte)1, (byte)15, (byte)10, (byte)0, (byte)0, (byte)10, (byte)10 },
                    { 2, null, (byte)10, (byte)1, (byte)10, null, (byte)2, null, (byte)5, (byte)0, "Banita", (byte)0, (byte)1, (byte)15, (byte)0, (byte)10, (byte)0, (byte)0, (byte)0 },
                    { 1, "Bohater musi wybrać boga i świątynię. Wybór ten zapewnia dodatkową cechę lub zdolność, wymienioną w opisie kultu", (byte)0, (byte)0, (byte)5, null, (byte)2, null, (byte)10, (byte)0, "Akolita", (byte)10, (byte)1, (byte)15, (byte)5, (byte)5, (byte)0, (byte)0, (byte)10 },
                    { 26, null, (byte)0, (byte)1, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Oprych", (byte)5, (byte)1, (byte)15, (byte)5, (byte)0, (byte)0, (byte)5, (byte)5 },
                    { 27, null, (byte)10, (byte)0, (byte)0, null, (byte)2, null, (byte)10, (byte)0, "Paź", (byte)10, (byte)1, (byte)15, (byte)0, (byte)0, (byte)0, (byte)0, (byte)5 },
                    { 4, null, (byte)5, (byte)0, (byte)5, null, (byte)2, null, (byte)0, (byte)0, "Chłop", (byte)0, (byte)1, (byte)15, (byte)10, (byte)5, (byte)0, (byte)5, (byte)5 },
                    { 30, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)5, (byte)0, "Posłaniec", (byte)0, (byte)1, (byte)15, (byte)5, (byte)5, (byte)0, (byte)0, (byte)5 },
                    { 29, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)0, (byte)0, "Porywacz zwłok", (byte)0, (byte)1, (byte)15, (byte)0, (byte)5, (byte)0, (byte)5, (byte)10 },
                    { 55, null, (byte)0, (byte)0, (byte)5, null, (byte)2, null, (byte)10, (byte)0, "Zarządca", (byte)10, (byte)1, (byte)15, (byte)0, (byte)5, (byte)0, (byte)5, (byte)5 },
                    { 53, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)0, (byte)0, "Woźnica", (byte)5, (byte)1, (byte)15, (byte)0, (byte)10, (byte)0, (byte)0, (byte)5 },
                    { 52, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)10, (byte)0, "Wojownik klanowy", (byte)0, (byte)1, (byte)2, (byte)0, (byte)5, (byte)0, (byte)0, (byte)5 },
                    { 51, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)5, (byte)0, "Włóczykij", (byte)5, (byte)1, (byte)15, (byte)0, (byte)10, (byte)0, (byte)0, (byte)0 },
                    { 50, null, (byte)5, (byte)0, (byte)5, null, (byte)2, null, (byte)5, (byte)0, "Węglarz", (byte)5, (byte)1, (byte)15, (byte)5, (byte)0, (byte)0, (byte)5, (byte)5 },
                    { 49, null, (byte)5, (byte)0, (byte)0, null, (byte)2, null, (byte)10, (byte)1, "Uczeń czarodzieja", (byte)5, (byte)1, (byte)3, (byte)0, (byte)0, (byte)0, (byte)0, (byte)15 },
                    { 48, null, (byte)10, (byte)1, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Tarczownik", (byte)0, (byte)1, (byte)4, (byte)5, (byte)0, (byte)0, (byte)5, (byte)5 },
                    { 47, null, (byte)5, (byte)0, (byte)5, null, (byte)2, null, (byte)0, (byte)0, "Śmieciarz", (byte)5, (byte)1, (byte)15, (byte)10, (byte)0, (byte)0, (byte)5, (byte)5 },
                    { 46, null, (byte)5, (byte)0, (byte)10, null, (byte)2, null, (byte)5, (byte)0, "Szlachcic", (byte)10, (byte)1, (byte)15, (byte)0, (byte)5, (byte)0, (byte)0, (byte)5 },
                    { 45, null, (byte)10, (byte)1, (byte)15, null, (byte)2, null, (byte)5, (byte)0, "Szermierz estalijski", (byte)0, (byte)1, (byte)15, (byte)5, (byte)0, (byte)0, (byte)5, (byte)0 },
                    { 44, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)0, (byte)0, "Szczurołap", (byte)0, (byte)1, (byte)15, (byte)5, (byte)10, (byte)0, (byte)0, (byte)10 },
                    { 54, null, (byte)5, (byte)1, (byte)10, null, (byte)3, null, (byte)0, (byte)0, "Zabójca trolli", (byte)0, (byte)1, (byte)4, (byte)5, (byte)0, (byte)0, (byte)5, (byte)10 },
                    { 42, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)0, (byte)0, "Strażnik pól", (byte)0, (byte)1, (byte)8, (byte)5, (byte)10, (byte)0, (byte)0, (byte)10 },
                    { 43, null, (byte)0, (byte)0, (byte)10, null, (byte)3, null, (byte)0, (byte)0, "Strażnik więzienny", (byte)0, (byte)1, (byte)15, (byte)10, (byte)0, (byte)0, (byte)10, (byte)5 },
                    { 33, null, (byte)5, (byte)0, (byte)5, null, (byte)2, null, (byte)5, (byte)0, "Przewoźnik", (byte)0, (byte)1, (byte)15, (byte)5, (byte)5, (byte)0, (byte)10, (byte)0 },
                    { 34, null, (byte)10, (byte)0, (byte)0, null, (byte)2, null, (byte)5, (byte)0, "Rybak", (byte)0, (byte)1, (byte)15, (byte)5, (byte)5, (byte)0, (byte)10, (byte)0 },
                    { 35, null, (byte)5, (byte)0, (byte)5, null, (byte)2, null, (byte)10, (byte)0, "Rzecznik rodu", (byte)10, (byte)1, (byte)2, (byte)0, (byte)5, (byte)0, (byte)0, (byte)5 },
                    { 36, null, (byte)10, (byte)0, (byte)0, null, (byte)2, null, (byte)5, (byte)0, "Rzemieślnik", (byte)0, (byte)1, (byte)15, (byte)5, (byte)0, (byte)0, (byte)5, (byte)10 },
                    { 32, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)10, (byte)0, "Przepatrywacz", (byte)0, (byte)1, (byte)15, (byte)0, (byte)10, (byte)0, (byte)0, (byte)5 },
                    { 38, null, (byte)10, (byte)0, (byte)0, null, (byte)2, null, (byte)10, (byte)0, "Skryba", (byte)5, (byte)1, (byte)15, (byte)0, (byte)0, (byte)0, (byte)0, (byte)10 },
                    { 39, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)5, (byte)0, "Sługa", (byte)5, (byte)1, (byte)15, (byte)0, (byte)0, (byte)0, (byte)5, (byte)10 },
                    { 40, null, (byte)5, (byte)0, (byte)10, null, (byte)2, null, (byte)10, (byte)0, "Strażnik", (byte)5, (byte)1, (byte)15, (byte)0, (byte)5, (byte)0, (byte)5, (byte)0 },
                    { 41, null, (byte)10, (byte)0, (byte)10, null, (byte)2, null, (byte)5, (byte)0, "Strażnik dróg", (byte)0, (byte)1, (byte)15, (byte)0, (byte)10, (byte)0, (byte)5, (byte)5 },
                    { 37, null, (byte)10, (byte)1, (byte)10, null, (byte)2, null, (byte)0, (byte)0, "Rzezimieszek", (byte)0, (byte)1, (byte)15, (byte)0, (byte)0, (byte)0, (byte)10, (byte)10 },
                    { 31, null, (byte)10, (byte)0, (byte)5, null, (byte)2, null, (byte)10, (byte)0, "Przemytnik", (byte)10, (byte)1, (byte)15, (byte)0, (byte)5, (byte)0, (byte)0, (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "SkillLevel", "Trait" },
                values: new object[,]
                {
                    { 26, "Język tajemny", (byte)2, (byte)1 },
                    { 35, "Sekretny język (różne)", (byte)2, (byte)1 },
                    { 27, "Kuglarstwo", (byte)2, (byte)4 },
                    { 28, "Leczenie", (byte)2, (byte)1 },
                    { 29, "Nauka (różne)", (byte)2, (byte)1 },
                    { 30, "Nawigacja", (byte)2, (byte)1 },
                    { 31, "Oswajanie", (byte)2, (byte)4 },
                    { 32, "Otwieranie zamków", (byte)2, (byte)2 },
                    { 33, "Rzemiosło (różne)", (byte)2, (byte)0 },
                    { 34, "Sekretne znaki (różne)", (byte)2, (byte)1 },
                    { 41, "Unik", (byte)2, (byte)2 },
                    { 37, "Śledzenie", (byte)2, (byte)2 },
                    { 38, "Torturowanie", (byte)2, (byte)4 },
                    { 39, "Tresura", (byte)2, (byte)4 },
                    { 40, "Tropienie", (byte)2, (byte)1 },
                    { 42, "Warzenie trucizn", (byte)2, (byte)1 },
                    { 43, "Wiedza (różne)", (byte)2, (byte)1 },
                    { 44, "Wykrywanie magii", (byte)2, (byte)6 },
                    { 45, "Zastawianie pułapek", (byte)2, (byte)2 },
                    { 46, "Znajomość języka (różne)", (byte)2, (byte)1 },
                    { 25, "Hipnoza", (byte)2, (byte)6 },
                    { 36, "Splatanie magii", (byte)2, (byte)5 },
                    { 24, "Gadanina", (byte)2, (byte)4 },
                    { 11, "Przeszukiwanie", (byte)1, (byte)1 },
                    { 22, "Czytanie i pisanie", (byte)2, (byte)1 },
                    { 47, "Zwinne palce", (byte)2, (byte)2 },
                    { 1, "Charakteryzacja", (byte)1, (byte)4 },
                    { 2, "Dowodzenie", (byte)1, (byte)4 },
                    { 3, "Hazard", (byte)1, (byte)1 },
                    { 4, "Jeździectwo", (byte)1, (byte)2 },
                    { 5, "Mocna głowa", (byte)1, (byte)3 },
                    { 6, "Opieka nad zwierzętami", (byte)1, (byte)1 },
                    { 7, "Plotkowanie", (byte)1, (byte)4 },
                    { 8, "Pływanie", (byte)1, (byte)5 },
                    { 9, "Powożenie", (byte)1, (byte)5 },
                    { 10, "Przekonywanie", (byte)1, (byte)4 },
                    { 12, "Skradanie się", (byte)1, (byte)2 },
                    { 13, "Spostrzegawczość", (byte)1, (byte)1 },
                    { 14, "Sztuka przetrwania", (byte)1, (byte)1 },
                    { 15, "Targowanie", (byte)1, (byte)4 },
                    { 16, "Ukrywanie się", (byte)1, (byte)2 },
                    { 17, "Wioślarstwo", (byte)1, (byte)5 },
                    { 18, "Wspinaczka", (byte)1, (byte)5 },
                    { 19, "Wycena", (byte)1, (byte)1 },
                    { 20, "Zastraszanie", (byte)1, (byte)5 },
                    { 21, "Brzuchomówstwo", (byte)2, (byte)4 },
                    { 23, "Czytanie z warg", (byte)2, (byte)1 },
                    { 48, "Żeglarstwo", (byte)2, (byte)2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48);
        }
    }
}