using GalaSoft.MvvmLight;
using PresentationLayer.SR_ServiceLayerWcf;
using System;
using System.Collections.ObjectModel;

namespace PresentationLayer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<PeopleModel> people;
        public ObservableCollection<PeopleModel> People
        {
            get { return people; }
            set { people = value; RaisePropertyChanged(); }
        }

        ServiceLayerWcfServiceDefinitionClient client = new ServiceLayerWcfServiceDefinitionClient();

        public MainViewModel()
        {
            People = new ObservableCollection<PeopleModel>();
            GenerateDummyData();

        }

        private void GenerateDummyData()
        {
            foreach (var item in client.QueryAll())
            {
                people.Add((PeopleModel)item);
            }

        }
    }
}