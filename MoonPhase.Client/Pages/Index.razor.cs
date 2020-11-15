using MoonPhase.Client.Models;
using System;

namespace MoonPhase.Client.Pages
{
    public partial class Index
    {
        DateTime moonPhaseDate = DateTime.UtcNow;
        int hemisphere = (int)Earth.Hemispheres.Northern;
        PhaseResult result = null;
        public DateTime MoonPhaseDate 
        { 
            get => moonPhaseDate; 
            set
            {
                moonPhaseDate = value;
                Calculate();
            }
        }

        public int Hemisphere
        {
            get => hemisphere;
            set
            {
                hemisphere = value;
                Calculate();
            }
        }

        protected override void OnInitialized()
        {
            Calculate();
        }

        private void Calculate()
        {
            result = Moon.Calculate(MoonPhaseDate, (Earth.Hemispheres)Hemisphere);
        }
    }
}
