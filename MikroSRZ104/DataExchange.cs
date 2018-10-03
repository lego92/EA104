

namespace MikroSRZ104
{
    // класс для обмена данными между основной формой и формой датчика
    // информация о конкретном датчике записывается в соответствующие
    // поля класса и используется для отображения на форме датчика
    public class DataExchange
    {
        // событие - изменение в поле данных
        // подписка на него осуществляется в Form 2
        // происходит при записи данных в любое
        // поле (кроме sensorCount и sensorNumber) объекта данного класса
        // через соответствующее свойство
        public event MikroSRZDataChangedDelegate DataChanged;

        // событие - изменение номера датчика
        // подписка на него осуществляется в PageMikroSRZ
        // происходит при записи данных в 
        // поле sensorNumber объекта данного класса
        // через соответствующее свойство
        public event MikroSRZDataChangedDelegate SensorNumberChanged;

        private int sensorsCount = 0;

        private int sensorNumber;

        private double current;

        private double resistance;

        private bool isCurrentSensor;

        private bool isCalculationImpossible;

        private bool isBatteryDischarging;

        private bool isNoVoltage;

        private bool isHighNoiseLevel;

        private bool isCommunicationError;

        public int SensorsCount { get; set; }

        public int SensorNumber 
        {
            get
            {
                return sensorNumber;
            }

            set
            {

                sensorNumber = value;
                //SensorNumberChanged();

            }
        }

        public double Current
        {
            get
            {
                return current;
            }

            set
            {
                current = value;
                //DataChanged();
            }
        }

        public double Resistance
        {
            get
            {
                return resistance;
            }

            set
            {
                resistance = value;
                //DataChanged();
            }
        }

        public bool IsCurrentSensor
        {
            get
            {
                return isCurrentSensor;
            }
            set
            {
                isCurrentSensor = value;
                //DataChanged();
            }
        }

        public bool IsCalculaionImpossible
        {
            get
            {
                return isCalculationImpossible;
            }

            set
            {
                isCalculationImpossible = value;
                //DataChanged();
            }
        }

        public bool IsBatteryDischarging
        {
            get
            {
                return isBatteryDischarging;
            }

            set
            {
                isBatteryDischarging = value;
                //DataChanged();
            }
        }

        public bool IsNoVoltage
        {
            get
            {
                return isNoVoltage;
            }

            set
            {
                isNoVoltage = value;
                //DataChanged();
            }
        }

        public bool IsHighNoiseLevel
        {
            get
            {
                return isHighNoiseLevel;
            }

            set
            {
                isHighNoiseLevel = value;
                //DataChanged();
            }
        }

        public bool IsCommunicationError
        {
            get
            {
                return isCommunicationError;
            }

            set
            {
                isCommunicationError = value;
                //DataChanged();
            }
        }
    }
}
