using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using EstonianApp.Models;

namespace Services
{
    internal static class FishServices
    {
        private static List<Fish> fish = new()
        {
            new()
            {
                Name = " Kalastus",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis ultrices risus vel est congue, ac facilisis arcu tincidunt." +
                " Suspendisse a nibh auctor, imperdiet metus vitae, mollis dolor. Curabitur tellus lectus, aliquam in ornare sed, pretium in augue. " +
                "Phasellus feugiat fringilla consectetur. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos." +
                " Curabitur finibus ut risus quis imperdiet. Curabitur dictum pellentesque mauris vitae consectetur. "
            },
        };
    }
}
