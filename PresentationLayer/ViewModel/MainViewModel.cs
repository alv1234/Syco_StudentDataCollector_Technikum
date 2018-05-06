using GalaSoft.MvvmLight;
using PresentationLayer.SR_ServiceLayerWcf;
using System;
using System.Collections.ObjectModel;

namespace PresentationLayer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Student> students;
        public ObservableCollection<Student> Students
        {
            get { return students; }
            set { students = value; RaisePropertyChanged(); }
        }

        ServiceLayerWcfServiceDefinitionClient client = new ServiceLayerWcfServiceDefinitionClient();

        public MainViewModel()
        {
            Students = new ObservableCollection<Student>();
            GenerateDummyData();

        }

        private void GenerateDummyData()
        {
            foreach (var item in client.QueryStudents())
            {
                students.Add((Student)item);
            }

        }
    }
}