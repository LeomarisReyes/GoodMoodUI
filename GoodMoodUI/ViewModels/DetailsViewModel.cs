using System;
using System.Collections.ObjectModel;
using GoodMoodUI.Models;

namespace GoodMoodUI.ViewModels
{
    public class DetailsViewModel
    {
        public ObservableCollection<Topics> topics { get; set; }
        public ObservableCollection<Information> information { get; set; }

        public DetailsViewModel()
        {
            topics = new ObservableCollection<Topics>
            {
                new Topics { Description = "Yoga" },
                new Topics { Description = "Lunch" },
                new Topics { Description = "Healthy"}
            };

            information = new ObservableCollection<Information>
            {
                new Information { Icon = "Wallet" , Title="When", Description="Today, 12:15 pm" },
                new Information { Icon = "Wallet" , Title="Duration", Description="45 minutes" },
                new Information { Icon = "Wallet" , Title="Availability", Description="5/20 spots" },
                new Information { Icon = "Wallet" , Title="Location", Description="Breakout area near the kitchen" }
            };
        }
    }
}
