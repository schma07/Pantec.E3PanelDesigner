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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Pantec.E3PanelDesigner.ViewModels
{
    public class MainViewModel : ViewModelBase<MainWindow>
    {
        private readonly IConnector _connector = new E3ApplicationConnector();
        private readonly string[] _appChangedPropertiesNames = { nameof(IsConnected), nameof(IsProjectOpened) };
        private IApplication _app;
        private string _projectName;
        private ObservableCollection<DeviceAggregate> _allDevicesInProject = new();
        private ObservableCollection<DeviceAggregate> _attributedDevices = new();


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

        public ObservableCollection<DeviceAggregate> AttributedDevices
        {
            get => _attributedDevices;
            set
            {
                _attributedDevices = value;
                RaisePropertyChanged(nameof(AttributedDevices));
            }
        }

        public ObservableCollection<DeviceAggregate> AllDevicesInProject
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

        /// <summary>
        /// Places device models according to the currently selected options/variants 
        /// </summary>
        private void OnUpdateModelPlacement()
        {
            using (var job = _app.CreateJobObject())
            {
                AllDevicesInProject.Clear();
                var allDeviceCount = job.GetAllDevicesId();

                using (var device = job.CreateDeviceObject())
                {
                    foreach (var id in allDeviceCount)
                    {
                        device.Id = id;
                        if (device.ModelIsPlaced())
                        {
                            DeviceAggregate placedDevice = new(device.Id, device.Name);
                            placedDevice.SourcePanelLocation = device.PanelLocation;

                            placedDevice.ModelName = device.Proxy.GetModelName();

                            var mountedSlotIds = device.Proxy.GetMountedSlotIdsEnumerable();
                            using (var slot = job.CreateSlotObject())
                            {
                                foreach (var slotId in mountedSlotIds)
                                {
                                    slot.Id = slotId;
                                    placedDevice.SlotsOnModel.Add(new KeyValuePair<int, string>(slot.Id, slot.GetName()));
                                }
                            }
                            AllDevicesInProject.Add(placedDevice);
                        }

                    }

                }
            }
        }

        #region Update panel placement private methods

        /// <summary>
        /// Create aggregates for all devices in the project attributed with the attributename
        /// </summary>
        /// <param name="attributeName"></param>
        /// <returns>IEnumerable with DeviceAggregates</returns>
        private void CreateAttributedDeviceAggregates()
        {

        }

        #endregion

        private void OnGetJobInfo()
        {
            using (var job = _app.CreateJobObject())
            {
                ProjectName = job.GetName();
                // Sample working with arrays (use proxy object)
                object ids = null;
                var allCount = job.Proxy.GetAllDeviceIds(ref ids);
                var idsEnumerable = ids.ToIEnumerable(); // using E3Series.Wrapper.Entities.Extensions;
                using (var device = job.CreateDeviceObject())
                {
                    foreach (var id in idsEnumerable)
                    {
                        device.Id = id;
                        //AllDevicesInProject.Add(device.GetName());
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
