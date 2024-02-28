using EstonianApp.Models;


namespace EstonianApp.Services
{
    internal static class FishService
    {
        private static List<Fish> fish = new()
        {
            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

           new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "",
                Subtitle = " ",
                HeroImage = "",
                Description = "",
                AccentColorStart = Color.FromArgb("#1B1A55"),
                AccentColorEnd = Color.FromArgb("#1B1A55"),
                Images = new()
                {

                }
            },
        };

        public static List<Fish> GetFeaturedFish()
        {
            var random = new Random();
            var randomizedFish = fish.OrderBy(item => random.Next());

            return randomizedFish.Take(3).ToList();
        }

        public static List<Fish> GetAllFish()
            => fish;
    }
}