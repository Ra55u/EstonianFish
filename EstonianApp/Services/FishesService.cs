using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using EstonianApp.Models;

namespace Services
{
    internal static class FishesService
    {
        private static List<Fish> fishes = new()
        {
            new()
            {
                Name = " Kalastus",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°."
            },
        };
    }
}
