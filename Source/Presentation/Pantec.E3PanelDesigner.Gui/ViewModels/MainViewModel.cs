using Pantec.E3PanelDesigner.Extensions;
using Pantec.E3PanelDesigner.Views;
using Pantec.E3Wrapper.ApplicationSelection.Gui;
using Pantec.E3Wrapper.ApplicationSelection.Gui.Commands;
using Pantec.E3Wrapper.ApplicationSelection.Gui.Models;
using Pantec.E3Wrapper.ApplicationSelection.Gui.ViewModels.Base;
using Pantec.E3Wrapper.Core.Application.Entities;
using Pantec.E3Wrapper.Core.Application.Entities.Extensions;
using Pantec.E3Wrapper.Core.Application.Interfaces;
using Pantec.E3Wrapper.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace Pantec.E3PanelDesigner.ViewModels
{
    public class MainViewModel : ViewModelBase<MainWindow>
    {
        private readonly IConnector _connector = new E3ApplicationConnector();
        private readonly string[] _appChangedPropertiesNames = { nameof(IsConnected), nameof(IsProjectOpened) };
        private IApplication _app;
        private string _projectName;
        private ObservableCollection<string> _allDevicesInProject = new();
        private Collection<DeviceAggregate> _attributedDevices = new();


        public bool IsConnected => _app?.IsApplicationRunning() ?? false;
        public bool IsProjectOpened => _app?.IsProjectOpened() ?? false;
        //public bool IsDeviceSelected => SelectedDeviceName.Length() > 0 ?? false;

        public string ProjectName
        {
            get => _projectName;
            set
            {
                _projectName = value;
                RaisePropertyChanged(nameof(ProjectName));
            }
        }
        public Collection<DeviceAggregate> AttributedDevices
        {
            get => _attributedDevices;
            set
            {
                _attributedDevices = value;
                RaisePropertyChanged(nameof(AttributedDevices));
            }
        }



        public ObservableCollection<string> AllDevicesInProject
        {
            get => _allDevicesInProject;
            set
            {
                _allDevicesInProject = value;
                RaisePropertyChanged(nameof(AllDevicesInProject));
            }
        }

        public ICommand ConnectApplicationCommand { get; private set; }
        public ICommand DisconnectApplicationCommand { get; private set; }
        public ICommand GetJobInfoCommand { get; private set; }
        public ICommand UpdateModelPlacementCommand { get; private set; }

        public MainViewModel()
            : base(new MainWindow())
        {
            CreateCommands();
        }

        private void CreateCommands()
        {
            ConnectApplicationCommand = new RelayCommand(OnConnectApplication,
                () => _app == null);
            DisconnectApplicationCommand = new RelayCommand(OnDisconnectApplication,
                () => _app != null);

            GetJobInfoCommand = new RelayCommand(OnGetJobInfo,
                () => _app != null && IsProjectOpened);

            UpdateModelPlacementCommand = new RelayCommand(OnUpdateModelPlacement,
                () => _app != null && IsProjectOpened);
        }

        private void OnUpdateModelPlacement()
        {
           GetDeviceAggregatesAttributed("pan_ModelPlacedByScript");

        }

        #region Update panel placement private methods
        
        /// <summary>
        /// Create aggregates for all devices in the project attributed with the parameter.
        /// </summary>
        /// <param name="attributeName"></param>
        /// <returns>IEnumerable with DeviceAggregates</returns>
        private void GetDeviceAggregatesAttributed(string attributeName)
        {
            AttributedDevices.Clear();

            using (var job = _app.CreateJobObject())
            {
                object ids = null;
                var allDeviceIds = job.Proxy.GetAllDeviceIds(ref ids);
                var allDeviceIdsEnumerable = ids.ToIEnumerable();

                using (var device = job.CreateDeviceObject())
                {
                    foreach (var id in allDeviceIdsEnumerable)
                    {
                        device.Id = id;

                        if (device.HasAttribute(attributeName))
                        {
                            DeviceAggregate attributedDevice = new DeviceAggregate(device.Id, device.Name);
                            AttributedDevices.Add(attributedDevice);
                        }
                    }
                }
            }
        }



        #endregion

        private void OnGetJobInfo()
        {
            using (var job = _app.CreateJobObject())
            {
                ProjectName = job.Proxy.GetName();
                // Sample working with arrays (use proxy object)
                object ids = null;

                var allCount = job.Proxy.GetAllDeviceIds(ref ids);
                Console.WriteLine(allCount);
                var idsEnumerable = ids.ToIEnumerable(); // using E3Series.Wrapper.Entities.Extensions;
                using (var device = job.CreateDeviceObject())
                {
                    foreach (var id in idsEnumerable)
                    {
                        device.Id = id;
                        AllDevicesInProject.Add(device.Name);
                    }
                }
            }
        }


        private void OnConnectApplication()
        {
            _app = _connector.Connect();
            _appChangedPropertiesNames.ForEach(RaisePropertyChanged);

            if (_app == null)
                MessageBox.Show("Unable to connect to E3series COM", "Error");
            else
                _app.Proxy.PutInfo(0, "Successfully connected to E3.series");
        }

        private void OnDisconnectApplication()
        {
            _app.Dispose();
            _app = null;
            _appChangedPropertiesNames.ForEach(RaisePropertyChanged);
            ProjectName = null;

        }
    }
}
