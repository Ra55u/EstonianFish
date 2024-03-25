using EstonianApp.Models;


namespace EstonianApp.Services
{
    internal static class WaterService
    {
        private static List<Water> water = new()
        {


                new()
                {
                    Name = "Suur Emajõgi",
                    Subtitle="Emajõgi ühendab eesti kahte suurimat järve - Võrtsjärve ning Peipsit.",
                    HeroImage = "suuremajogi.jpg",
                    Description = "Kokku võib leida Emajõest 36 erinevat kalaliiki. 2008. aasta võrguga katsepüügil olid levinumad kalad särg ja nurg. Emajões käib kudemas ka Eesti Punasesse Raamatusse kantud säga.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Suur-emajogi.JPG/220px-Suur-emajogi.JPG"
                    }
                },
                new()
                {
                    Name = "Väike Emajõgi",
                    Subtitle = "Kalanduslikult väärtuslik jõgi",
                    HeroImage = "vaikeemajogi.jpg",
                    Description = "Tüübilt peamiselt särje-ahvena-haugijõgi. Oluline tähtsus Võrtsjärve kalade rändel, sigimisel ja toitumisel.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/3/3a/Vaike_Emajogi.jpg"
                    }
                },
                new()
                {
                    Name = "Võhandu jõgi",
                    Keywords="Võhandu jõgi on liigirikas jõgi.",
                    Subtitle = "Võhandu jõgi on liigirikas jõgi",
                    HeroImage = "vohandujogi.png",
                    Description = "1989-1995 katsepüükidest selgus, et Võhandu jõe eri osades on kalastiku koosseis erinev. Suur Võhandu on Vagula järvest Kääpani särje-ahvenajõgi ja Paidrast kuni Reoni turva-särje-teivijõgi. Toolamaa ümbruses särje-haugijõgi, Räpina kandis särje-ahvena-säinajõgi ja Kuuksi lähistel särje-ahvena-latika ja turvajõgi. Pühajõe ülemine ja alumine osa on särje-arhvena-haugijõgi, keskosa jõeforellijõgi.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/4/43/V%C3%B5handu_Viira_m%C3%BC%C3%BCri_juures.jpg"
                    }
                },
                new()
                {
                    Name = "Peipsi järv",
                    Subtitle = "Suur järv",
                    HeroImage = "peipsijarv.jpg",
                    Description = "Suurimas, põhjapoolses osas suurim sügavus 12,9 m (keskmine 8,3 m), Lämmijärves suurim sügavus 15,3 m (keskmine 2,5 m), Pihkva järves suurim sügavus 5,3 m (keskmine 3,8 m). Peipsi oli omal ajal esimene järv Venemaal, kus kehtestati kalapüügi eeskirjad. Kalamajanduslikult võib teda nimetada tindi-rääbise järveks, kuna need kalad annavad põhilise saagi (1977.a) . Suure osatähtsusega on ka ahven.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/2/2b/Lake_Peipsi_Landsat2000-Peipsi.jpeg"
                    }
                },
                new()
                {
                    Name = "Õhne jõgi",
                    Subtitle = "Jõgi",
                    HeroImage = "ohnejogi.jpg",
                    Description = "Katsepüükidel täheldati, et kalade ja kalaliikide arv on jões paiguti erinev. Kõige sagedamini esines haugi, seejärel lepamaimu, särge ning ahvenat. Kalanduslikult väärtuslik jõgi.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/4/4f/Taagepera_j%C3%A4rv_%28%C3%95hne_j%C3%B5gi%29.jpg"
                    }
                },
                new()
                {
                    Name = "Pedja jõgi",
                    Subtitle = "Hea jõgi",
                    HeroImage = "pedjajogi.jpg",
                    Description = "Katsepüükidest selgus, et Pedja jõe eri osades on kalastiku koosseis ja arvukus erinev. Jõe ülemjooks on haugijõgi, keskjooksu ülemine osa särje-ahvena-haugi jõgi, keskjooksu alumine osa ja alamjooks särje-säina-turva-haugijõgi",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/Pedja_Metsak%C3%BClas.jpg/1200px-Pedja_Metsak%C3%BClas.jpg"
                    }
                },
                new()
                {
                    Name = "Põltsamaa jõgi",
                    Subtitle = "Põltsamaa jõgi on kalanduslikult väärtuslik jõgi.",
                    HeroImage = "poltsamaajogi.jpg",
                    Description = "Ülemjooksu keskosa on jõeforelli tüüpi, ülemjooksu alumine osa, keskjooks ja alamjooks särje-haugijõe tüüpi.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/c/ca/Poltsamaajoki1.jpg"
                    }
                },
                new()
                {
                    Name = "Keeri järv",
                    Subtitle = "Hea kalajärv.",
                    HeroImage = "keerijarv.jpg",
                    Description = "Suurim sügavus 4,5 m , keskmine sügavus 3,0 m. Kalastiku koosseis sõltub Emajõest ja Elva jõest sisserändavatest kaladest.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/4/43/Keeri_j%C3%A4rv11.JPG"
                    }
                },
                new()
                {
                    Name = "Kalli järv",
                    Subtitle = "Hea kalajärv",
                    HeroImage = "kallijarv.jpg",
                    Description = "Järve kalastiku koosseis on muutlik ja sõltub kalade rännetest Peipsisse ja tagasi. Kevadel saadakse kõige rohkem latikat ja haugi, vähem särge, kiiska ja ahvenat. Sügisel ja talvel on rohkem säinast ja lutsu. Kalli järve suurim sügavus on 1,4 m, keskmine sügavus u 1,1 m.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://www.reisijutud.com/albums/Suursoo120305/w_emajoe_suursoo120305_12.jpg"
                    }
                },
                new()
                {
                    Name = "Käomardi laht (Pärnumaa)",
                    Subtitle = "Muutliku sügavusega järv.",
                    HeroImage = "kaomardilaht.png",
                    Description = "Madala veeseisu korral on sügavus 0,5 m, läänetormi korral sissetungiva merevee mõjul kuni 2,5 m. Kalastiku koosseis on väga muutlik ja kujuneb nähtavasti igal kevadel uuesti,sõltuvalt merest ja kraavidest sisserändavatest kaladest.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://m.psecn.photoshelter.com/img-get/I0000dzrXPk2HnBg/s/1200/I0000dzrXPk2HnBg.jpg"
                    }
                },
               new()
                {
                    Name = "Narva Veehoidla",
                    Subtitle = "Narva yikes...",
                    HeroImage = "narvaveehoidla.jpg",
                    Description = "Keskmine sügavus 1,8 m, suurim sügavus kuni 15 m (Narva jõe endise sängi kohal). Veehoidlat varustab kvaliteetse vee ja kaladega Peipsi järv.",
                   AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Narva_hydroelectric_station%2C_Apr_2009.jpg/220px-Narva_hydroelectric_station%2C_Apr_2009.jpg"
                    }
                },
                new()
                {
                    Name = "Kikkajärv",
                    Subtitle = "Järv",
                    HeroImage = "kikkajarv.jpg",
                    Description = "Kõige sügavam koht (22,5 m) on saarest loodes Eestipoolse kalda läheduses (kalale.ee kasutaja s.o.s sõnul võib olla järve sügavus ka 25 m).",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Kikka_j%C3%A4rv.jpg/264px-Kikka_j%C3%A4rv.jpg"
                    }
                },
                new()
                {
                    Name = "Ülemiste järv",
                    Subtitle = "Varustab Tallinnat veega.",
                    HeroImage = "ulemistejarv.jpg",
                    Description = "Suurim sügavus on 6 m, keskmine 2,5 m. Järv on tugevasti soostunud ja mudastunud.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/b/bf/%C3%9Clemiste.JPG"
                    }
                },
                new()
                {
                    Name = "Pühajõgi",

                    Subtitle = "Jahedaveeline forellijõe tüüpi jõgi",
                    HeroImage = "puhajogi.jpg",
                    Description = "Kaotas alates 80ndatest aastatest oma kalandusliku väärtuse tugeva reostatuse tõttu. Varem käisid seal kudemas ka lõhe ja meriforell. Viimased andmed jõe kohta puuduvad.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://upload.wikimedia.org/wikipedia/commons/e/e5/P%C3%BChaj%C3%B5e_suue.jpg"
                    }
                },
                new()
                {
                    Name = "Kunda jõgi",
                    Subtitle = "Jõgi",
                    HeroImage = "kundajogi.jpg",
                    Description = "Katsepüükidest selgus, et jõe eri osades on kalastiku koosseis ja arvukus erinev. Kalastiku koosseisult on ülemjooks on jõeforelijõe, keskjooksu alumine osa ja alamjooksu ülemine osa harjusejõe ning suudme-eelne osa forelli-lõhe jõe tüüpi. Kalanduslikult väärtuslik jõgi.",
                    AccentColorStart = Color.FromArgb("#1B1A55"),
                    AccentColorEnd = Color.FromArgb("#1B1A55"),
                    Images = new()
                    {
                        "https://samisiil.eu/wp-content/uploads/2023/09/img_8132-1030x687.jpg",
                        "https://samisiil.eu/wp-content/uploads/2023/09/img_8173-1030x687.jpg"
                    }
                }
        };

        public static List<Water> GetFeaturedWater()
        {
            var random = new Random();
            var randomizedWater = water.OrderBy(item => random.Next());

            return randomizedWater.Take(3).ToList();
        }

        public static List<Water> SearchAndSortWater(string searchQuery)
        {
            string query = searchQuery.ToLower();

            return water.Where(water =>
                water.Name.ToLower().Contains(query) ||
                water.Description.ToLower().Contains(query)
            )
            .OrderBy(water => water.Name)
            .ThenBy(water => water.Description)
            .ToList();
        }



        public static List<Water> GetAllWater()
            => water;
    }

}