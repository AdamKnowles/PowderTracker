using System.Collections.Generic;
using PowderTracker.Models;

namespace PowderTracker.Data
{
    public class MockPowderTrackerRepo : IPowderTrackerRepo
    {
        public IEnumerable<Trail> GetAppTrails()
        {
            var trails = new List<Trail>
            {
                new Trail{Id = 0, Name="Latte Cove", Color="Green", Lift="Avocado Express" },
                new Trail{Id = 1, Name="Espresso Canyon", Color="Blue", Lift="Avocado Express" },
                new Trail{Id = 2, Name="Cortado Bowl", Color="Black", Lift="Lime Strawberry Chair" }
            };

            return trails;
        }

        public Trail GetTrailById(int id)
        {
            return new Trail{Id = 0, Name="Latte Cove", Color="Green", Lift="Avocado Express" };
        }
    }
}