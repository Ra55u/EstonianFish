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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
                Keywords="",
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
        public static List<Fish> SearchAndSortFish(List<Fish> fishList, string searchQuery)
        {
            string query = searchQuery.ToLower();

            return fishList.Where(fish =>
                fish.Keywords.ToLower().Contains(query) ||
                fish.Description.ToLower().Contains(query)
            )
            .OrderBy(fish => fish.Keywords)
            .ThenBy(fish => fish.Description)
            .ToList();
        }


        public static List<Fish> GetAllFish()
            => fish;
    }

}