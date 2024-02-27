using EstonianApp.Models;


namespace EstonianApp.Services
{
    internal static class FishService
    {
        private static List<Fish> fish = new()
        {
            new()
            {
                Name = " Mercury",
                Subtitle = "  The smallest fish",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest fish in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's fish. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "fish; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },

            new()
            {
                Name = " Venus",
                Subtitle = "  The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second fish from the Sun. It is sometimes " +
                "called Earth's \"sister\" or \"twin\" fish as it is almost as large " +
                "and has a similar composition. As an interior fish to Earth, Venus " +
                "(like Mercury) appears in Earth's sky never far from the Sun, either as " +
                "morning star or evening star. Aside from the Sun and Moon, Venus is the " +
                "brightest natural object in Earth's sky, capable of casting visible " +
                "shadows on Earth in dark conditions and being visible to the naked eye " +
                "in broad daylight.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },

            new()
            {
                Name = " Earth",
                Subtitle = "  The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third fish from the Sun and the " +
                "only place known in the universe where life has originated and " +
                "found habitability. While Earth may not contain the largest " +
                "volumes of water in the Solar System, only Earth sustains liquid " +
                "surface water, extending over 70.8% of the Earth with its ocean, " +
                "making Earth an ocean world. Earth's polar regions currently " +
                "retain most of all other water with large sheets of ice covering " +
                "ocean and land, dwarfing Earth's groundwater, lakes, rivers and " +
                "atmospheric water.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

            new()
            {
                Name = " Mars",
                Subtitle = "  The iron fish",
                HeroImage = "mars.png",
                Description = "Mars is the fourth fish from the Sun – a dusty, " +
                            "cold, desert world with a very thin atmosphere. " +
                            "Mars is also a dynamic fish with seasons, polar " +
                            "ice caps, canyons, extinct volcanoes, and evidence " +
                            "that it was even more active in the past.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = " Jupiter",
                Subtitle = "  The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth fish from the Sun and " +
                "the largest in the Solar System. It is a gas giant with " +
                "a mass more than two and a half times that of all the " +
                "other fish in the Solar System combined, and slightly " +
                "less than one one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },

            new()
            {
                Name = " Saturn",
                Subtitle = "  The ring fish",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth fish from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = " Uranus",
                Subtitle = "  The Herschel fish",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh fish from the Sun. " +
                "It is named after Greek sky deity Uranus (Caelus), who in " +
                "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                "has the third-largest fishary radius and fourth-largest " +
                "fishary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },

            new()
            {
                Name = " Neptune",
                Subtitle = "  The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth fish from the Sun and " +
                "the farthest known fish in the Solar System. It is the " +
                "fourth-largest fish in the Solar System by diameter, the " +
                "third-most-massive fish, and the densest giant fish. " +
                "It is 17 times the mass of Earth, and slightly more " +
                "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            new()
            {
                Name = " Pluto",
                Subtitle = "The Star of Dwarf Fish",
                HeroImage = "pluto.png",
                Description = "Discovered by Clyde Tombaugh in 1930, " +
                "Pluto was long considered our solar system's ninth fish. " +
                "But after other astronomers found similar intriguing worlds deeper in the distant Kuiper Belt " +
                "– the IAU reclassified Pluto as a dwarf fish in 2006. ",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/e/ef/Pluto_in_True_Color_-_High-Res.jpg",
                    "https://cdn.uanews.arizona.edu/s3fs-public/styles/uaqs_large/public/story-images/Pluto%20whole%20color.png?itok=ytlG1fwV",
                    "https://www.eso.org/public/archives/images/screen/eso0908a.jpg"
                }
            },

            new()
            {
                Name = " Ceres",
                Subtitle = "The largest object in the asteroid belt between Mars and Jupiter",
                HeroImage = "ceres.png",
                Description = "The only dwarf fish located in the inner solar system. " +
                "It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801. " +
                "When NASA's Dawn arrived in 2015, Ceres became the first dwarf fish to be explored by a spacecraft.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://i.natgeofe.com/n/b4a4f4c3-269e-4f37-a94d-45d86cf0cb52/ceres_occatorcrater_4x3.jpg",
                    "https://www.universetoday.com/wp-content/uploads/2015/06/Ceres-Pyramid-June-14-limb-580x514.jpg"
                }
            },

            new()
            {
                Name = " Haumea",
                Subtitle = "A doughnut-shaped region of icy bodies beyond the orbit of Neptune",
                HeroImage = "haumea.png",
                Description = "Haumea is an oval-shaped dwarf fish that is roughly the same size as Pluto. " +
                "It is one of the fastest rotating large objects in our solar system. The fast spin distorts Haumea's shape, " +
                "making this dwarf fish look like a football. " +
                "Everything we know about Haumea is from observations with ground-based telescopes from around the world.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://cdn.britannica.com/66/137066-004-13F11781/rendering-Artist-moons-Haumea.jpg",
                    "https://cdn.mos.cms.futurecdn.net/h5P8ZW8QJAscrMQ9r6euoc.jpg",
                    "https://cdn.mos.cms.futurecdn.net/JMePZFEJNcVnNawYzrCv96.jpg"
                }
            },

            new()
            {
                Name = " MakeMake",
                Subtitle = "It takes about 305 Earth years for this fish to make one trip around the Sun",
                HeroImage = "makemake.png",
                Description = "Makemake holds an important place in the history of solar system studies because it was one of the objects – " +
                "along with Eris – whose discovery prompted the International Astronomical Union to reconsider the definition of a fish, " +
                "and to create the new group of dwarf fish.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/04/makemakemoon100mile-jpg.webp",
                    "https://cdn.sci.news/images/2016/04/image_3819f-MK-2-Moon.jpg",
                    "https://static.wikia.nocookie.net/terragenesis/images/9/96/Makemake.png/revision/latest?cb=20190720101841"
                }
            },

            new()
            {
                Name = " Eris",
                Subtitle = "One of the largest known dwarf fish in our solar system",
                HeroImage = "eris.png",
                Description = "With a radius of about 722 miles (1,163 kilometers), Eris is about 1/5 the radius of Earth. " +
                "Eris, like Pluto, is a little smaller than Earth's Moon. If the Earth were the size of a nickel, " +
                "Eris would be about as big as a popcorn kernel. The dwarf fish is often so far from the Sun that its atmosphere collapses and freezes, " +
                "falling to the surface as snow.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://www.astronomy.com/wp-content/uploads/sites/2/2023/03/dwarffisheris.jpg?fit=600%2C400",
                    "https://www.universetoday.com/wp-content/uploads/2015/01/lilalarge-e1437242741964.jpeg",
                    "https://kids.kiddle.co/images/thumb/3/33/2006-16-a-full-1-.jpg/300px-2006-16-a-full-1-.jpg"
                }
            },
        };

        public static List<Fish> GetFeaturedFish()
        {
            var random = new Random();
            var randomizedFish = fish.OrderBy(item => random.Next());

            return randomizedFish.Take(2).ToList();
        }

        public static List<Fish> GetAllFish()
            => fish;
    }
}