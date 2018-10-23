using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib60870;
using lib60870.CS101;
using lib60870.CS104;
using System.Collections;
using System.Reflection;

namespace MikroSRZ104
{

    public enum SensorSPadr
    {
        IsBatteryDischarging = 66534,
        IsNoVoltage = 66781,
        IsCalculationImpossible = 67275,     
        IsHighNoiseLevel = 69014,
        IsCommunicationError = 69509
    }

    public enum SensorMEadr
    {
        Current = 851975,
        Resistance = 852222,
    }
    
    public class Sensor
    {
        public event SensorDataChangedDelegate DataChanged;

        public int Number { get; set; }

        public string Name { get; set; }

        public string FactoryNumber { get; set; }

        // отдельный класс для токового?????
        public bool IsCurrentSensor { get; set; } = false;

        public double Current { get; set; }

        public double ThresholdMinCurrent { get; set; }

        public double ThresholdMaxCurrent { get; set; }

        public double Resistance { get; set; }

        public double ThresholdMinResistance { get; set; }

        public double ThresholdMaxResistance { get; set; }

        public bool IsCalculationImpossible { get; set; }

        public bool IsBatteryDischarging { get; set; }

        public bool IsNoVoltage { get; set; }

        public bool IsHighNoiseLevel { get; set; }

        public bool IsCommunicationError { get; set; }

        public Sensor(string factorynum, string name, int number, double thresholdMinResistance, 
                                                                          double thresholdMaxResistance)
        {
            FactoryNumber = factorynum;
            Name = name;
            Number = number;
            ThresholdMinResistance = thresholdMinResistance;
            ThresholdMaxResistance = thresholdMaxResistance;                            
        }

        public object GetValueByName(object aParent, string aPropertyName)
        {
            PropertyInfo property = aParent.GetType().GetProperty(aPropertyName);
            if (property != null)
                return property.GetValue(aParent, null);

            return null;                        
        }

        public void SetValueByName(object aParent, string aPropertyName, object aValue)
        {
            PropertyInfo property = aParent.GetType().GetProperty(aPropertyName);
            if (property != null)
            {
                property.SetValue(aParent, aValue, null);
                DataChanged(Number, aPropertyName, aValue);
            }                
        }
    }
}
