using System.Collections.Generic;
using PowderTracker.Models;

namespace PowderTracker.Data
{
    public interface IPowderTrackerRepo
    {
        IEnumerable<Trail> GetAppTrails();
        Trail GetTrailById(int id);
    }
}