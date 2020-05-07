using CoronaClient.Services;
using System;
using System.Collections.Generic;
using System.Text;

using CoronaClient.Services.API;

namespace CoronaClient.ViewModels
{
    public class MainViewModel
    {
        public CoronavirusCountriesChartViewModel CoronavirusCountriesChartViewModel { get; set; }

        public MainViewModel()
        {
            ICoronavirusCountryService coronavirusCountryService = new APICoronavirusCountryService();
            CoronavirusCountriesChartViewModel = CoronavirusCountriesChartViewModel.LoadViewModel(coronavirusCountryService);
        }

    }
}
