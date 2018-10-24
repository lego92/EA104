using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib60870;
using lib60870.CS101;
using lib60870.CS104;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using MikroSRZ104.Controls;


namespace MikroSRZ104
{
    public enum SPadr
    {
        IsPrelimAlarm = 66525,
        IsWarningAlarm = 66526,
        IsAlarm = 66527,
        IsOvervoltage = 66528,
        IsBatteryAssymmetry = 66530,
        IsPulsation = 66531,
        IsResistanceCalculationStopped = 69013,
        IsSensorsCommunicationError = 69508,
        IsActiveMode = 70004,
        IsPassiveMode = 70005
    }

    public enum MEadr
    {
        VoltageOnMainBuses = 851968,
        VoltageOnPositivePole = 851969,
        VoltageOnNegativePole = 851970,
        VoltagePulsation = 851971,
        VoltageAssymmetry = 852470,
        ResistanceOfMainBusesAndBattery = 852469,
        ResistanceOfPositivePole = 851972,
        ResistanceOfNegativePole = 851973,
        ResistanceOfNetwork = 851971,
        CapacityOfNetwork = 851974
    }

    public class MikroSRZ
    {
        public event MikroSRZDataChangedDelegate DataChanged;

        private struct SinglePoint
        {
            public int address;
            public bool value;
        }

        private struct MeasuredFloat
        {
            public int address;
            public double value;
        }

        SinglePoint[,] SParray247 = new SinglePoint[14, 247];

        SinglePoint[] SParray1 = new SinglePoint[12];

        MeasuredFloat[,] MEarray247 = new MeasuredFloat[2, 247];

        MeasuredFloat[] MEarray1 = new MeasuredFloat[10];


        int[] BaseSPAddresses247 = { 65537, 65784, 66031, 66278,  66534, 66781, 67028, 67275, 68025, 68272, 69014, 69261,
                                   69509, 69756 };

        int[] BaseSPAddresses1 = { 66525, 66526, 66527, 66528, 66529, 66530, 66531, 69013, 69508, 70003, 70004, 70005 };

        int[] BaseMEAddresses247 = { 851975, 852222 };

        int[] BaseMEAddresses1 = { 851968, 851969, 851970, 851971, 851972, 851973, 851974, 852469, 852470, 852471 };

        ////////////////

        public string Name { get; set; }

        public string IPAddress { get; set; }

        public Connection Con { get; set; }

        public bool ConnectionStatus { get; set; } = false;

        public bool IsDataRecieved { get; set; } = false;

        public bool DeviceError { get; set; } = false;        

        public Sensor[] Sensors;

        public double VoltageOnMainBuses { get; set; }

        public double ThresholdMinVoltageOnMainBuses { get; set; }

        public double ThresholdMaxVoltageOnMainBuses { get; set; }

        public double VoltageOnPositivePole { get; set; }

        public double ThresholdMinVoltageOnPositivePole { get; set; }

        public double ThresholdMaxVoltageOnPositivePole { get; set; }

        public double VoltageOnNegativePole { get; set; }

        public double ThresholdMinVoltageOnNegativePole { get; set; }

        public double ThresholdMaxVoltageOnNegativePole { get; set; }

        public double VoltagePulsation { get; set; }

        public double ThresholdMinVoltagePulsation { get; set; }

        public double ThresholdMaxVoltagePulsation { get; set; }

        public double VoltageAssymmetry { get; set; }

        public double ThresholdMinVoltageAssymetry { get; set; }

        public double ThresholdMaxVoltageAssymetry { get; set; }

        public double ResistanceOfMainBusesAndBattery { get; set; }

        public double ThresholdMinResistanceOfMainBusesAndBattery { get; set; }

        public double ThresholdMaxResistanceOfMainBusesAndBattery { get; set; }

        public double ResistanceOfPositivePole { get; set; }

        public double ThresholdMinResistanceOfPositivePole { get; set; }

        public double ThresholdMaxResistanceOfPositivePole { get; set; }

        public double ResistanceOfNegativePole { get; set; }

        public double ThresholdMinResistanceOfNegativePole { get; set; }

        public double ThresholdMaxResistanceOfNegativePole { get; set; }

        public double ResistanceOfNetwork { get; set; }

        public double ThresholdMinResistanceOfNetwork { get; set; }

        public double ThresholdMaxResistanceOfNetwork { get; set; }

        public double CapacityOfNetwork { get; set; }

        public double ThresholdMinCapacityOfNetwork { get; set; }

        public double ThresholdMaxCapacityOfNetwork { get; set; }

        public bool IsPrelimAlarm { get; set; }

        public bool IsWarningAlarm { get; set; }

        public bool IsAlarm { get; set; }

        public bool IsOvervoltage { get; set; }

        public bool IsBatteryAssymmetry { get; set; }

        public bool IsPulsation { get; set; }

        public bool IsResistanceCalculationStopped { get; set; }

        public bool IsSensorsCommunicationError { get; set; }

        public bool IsActiveMode { get; set; }

        public bool IsPassiveMode { get; set; }

        public System.Timers.Timer deviceErrorTimer;

        public Thread timerThread = null;

        public MikroSRZ(string name, string ipAddress, int numberOfSensors)
        {
            Name = name;
            IPAddress = ipAddress;
            Sensors = new Sensor[numberOfSensors];


            for (int i = 0; i < SParray247.GetLength(0); i++)
            {
                for (int j = 0; j < SParray247.GetLength(1); j++)
                {
                    SParray247[i, j].address = BaseSPAddresses247[i] + j;
                }
            }

            for (int i = 0; i < SParray1.Length; i++)
            {
                SParray1[i].address = BaseSPAddresses1[i];
            }

            for (int i = 0; i < MEarray247.GetLength(0); i++)
            {
                for (int j = 0; j < MEarray247.GetLength(1); j++)
                {
                    MEarray247[i, j].address = BaseMEAddresses247[i] + j;
                }
            }

            for (int i = 0; i < MEarray1.Length; i++)
            {
                MEarray1[i].address = BaseMEAddresses1[i];
            }

            //timerThread = new Thread(timer);

            //timerThread.Start();

            deviceErrorTimer = new System.Timers.Timer(5000);

            deviceErrorTimer.Elapsed += new ElapsedEventHandler(Ticker);

            deviceErrorTimer.Enabled = true;
        }                

        public void Ticker(object sender, EventArgs e)
        {
            if(IsDataRecieved)
            {
                IsDataRecieved = false;
                if (DeviceError)
                {
                    SetValueByName(this, "DeviceError", false);                   
                }
            }
            else if (ConnectionStatus)            
            {
                SetValueByName(this, "DeviceError", true);
            }
        }


        public void CreateSensor(int index,string factorynum, string switchDev,string circuitLoad, 
                                                     double thresholdMinResistance, double thresholdMaxResistance)
        {
            Sensors[index] = new Sensor(factorynum, switchDev, circuitLoad, index + 1, thresholdMinResistance, thresholdMaxResistance);
        }

        public void Connect()
        {
            try
            {
                Con = new Connection(IPAddress);

                Con.DebugOutput = true;

                Con.SetASDUReceivedHandler(asduReceivedHandler, null);

                Con.SetConnectionHandler(ConnectionHandler, null);

                Con.Connect();

                Con.SendInterrogationCommand(CauseOfTransmission.ACTIVATION, 1, QualifierOfInterrogation.STATION);
            }
            catch (ConnectionException)
            {

            }
        }

        public void Disconnect()
        {
            try
            {
                if (Con != null && Con.IsRunning)
                {
                    Con.Close();
                }
            }
            catch(ConnectionException)
            {

            }
        }

        private void ConnectionHandler(object parameter, ConnectionEvent connectionEvent)
        {
            switch (connectionEvent)
            {
                case ConnectionEvent.OPENED:
                    SetValueByName(this, "ConnectionStatus", true);                                           
                    break;
                case ConnectionEvent.CLOSED:
                    SetValueByName(this, "ConnectionStatus", false);
                    break;               
            }
        }

        private bool asduReceivedHandler(object parameter, ASDU asdu)
        {
            IsDataRecieved = true;

            if (asdu.TypeId == TypeID.M_SP_NA_1)
            {      
                for (int i = 0; i < asdu.NumberOfElements; i++)
                {
                    var val = (SinglePointInformation)asdu.GetElement(i);

                    for (int j = 0; j < BaseSPAddresses247.Length; j++)
                    {
                        int index = val.ObjectAddress - BaseSPAddresses247[j];

                        if (index >= 0 && index < 247)
                        {
                            SParray247[j, index].value = val.Value;

                            if (index < Sensors.Length && Enum.IsDefined(typeof(SensorSPadr),
                                                                     SParray247[j, index].address - index))
                            {
                                Sensors[index].SetValueByName(Sensors[index], Enum.GetName(typeof(SensorSPadr),
                                                         SParray247[j, index].address - index), SParray247[j, index].value);
                            }
                            break;
                        }
                    }

                    for (int j = 0; j < BaseSPAddresses1.Length; j++)
                    {
                        if (val.ObjectAddress == BaseSPAddresses1[j])
                        {
                            SParray1[j].value = val.Value;

                            if (Enum.IsDefined(typeof(SPadr), SParray1[j].address))
                            {
                                SetValueByName(this, Enum.GetName(typeof(SPadr), SParray1[j].address), SParray1[j].value);
                            }
                            break;
                        }
                    }

                }
            }           

            else if (asdu.TypeId == TypeID.M_ME_NC_1)
            {                
               for (int i = 0; i < asdu.NumberOfElements; i++)
                {
                    var mfv = (MeasuredValueShort)asdu.GetElement(i);

                    for (int j = 0; j < BaseMEAddresses247.Length; j++)
                    {
                        int index = mfv.ObjectAddress - BaseMEAddresses247[j];

                        if (index >= 0 && index < 247)
                        {
                            MEarray247[j, index].value = mfv.Value;

                            if (index < Sensors.Length && Enum.IsDefined(typeof(SensorMEadr),
                                                                         MEarray247[j, index].address - index))
                            {
                                Sensors[index].SetValueByName(Sensors[index], Enum.GetName(typeof(SensorMEadr),
                                                        MEarray247[j, index].address - index), MEarray247[j, index].value);
                            }
                            break;
                        }
                    }

                    for (int j = 0; j < BaseMEAddresses1.Length; j++)
                    {
                        if (mfv.ObjectAddress == BaseMEAddresses1[j])
                        {
                            MEarray1[j].value = mfv.Value;

                            if (Enum.IsDefined(typeof(MEadr), MEarray1[j].address))
                            {
                                SetValueByName(this, Enum.GetName(typeof(MEadr), MEarray1[j].address), MEarray1[j].value);
                            }
                            break;
                        }
                    }

                }
            }

            return true;
        }


        private object GetValueByName(object aParent, string aPropertyName)
        {
            PropertyInfo property = aParent.GetType().GetProperty(aPropertyName);
            if (property != null)
                return property.GetValue(aParent, null);

            return null;
        }

        private void SetValueByName(object aParent, string aPropertyName, object aValue)
        {
            PropertyInfo property = aParent.GetType().GetProperty(aPropertyName);
            if (property != null)
            {
                property.SetValue(aParent, aValue, null);
                DataChanged(aPropertyName, aValue);
            }
        }

        public void Subscribe(SensorsTablePage sensorsTablePage)
        {
            for (int i = 0; i < Sensors.Length; i++)
            {
                Sensors[i].DataChanged += sensorsTablePage.Method;
            }
        }
    }
}
