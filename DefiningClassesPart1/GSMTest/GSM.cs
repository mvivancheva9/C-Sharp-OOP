using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMTest
{
    class GSM
    {
        private string gsmModel;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        //constructors
        public GSM(string gsmModel, string manufacturer)
        {
            this.GsmModel = gsmModel;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Battery = new Battery();
            this.Display = new Display();
        }
        public GSM(string gsmModel, string manufacturer, double price) : this(gsmModel, manufacturer)
        {
            this.Price = price;
            this.Owner = null;
            this.Battery = new Battery();
            this.Display = new Display();
        }
        public GSM (string gsmModel, string manufacturer, double price, string owner, string batteryModel, int hoursIdle, int hoursTalk, double displaySize, int displayNumColors) : this(gsmModel, manufacturer, price)
        {
            this.Owner = owner;
            this.Battery = new Battery(batteryModel, hoursIdle, hoursTalk);
            this.Display = new Display(displaySize, displayNumColors);
        }

        public static GSM IPhone4S
        {
            get
            {
                return new GSM("IPhone4S", "apple", 450.0, "MTel", "", 200, 14, 3.5, 16000000);
            }
        }

        //encapsulation
        public string GsmModel
        {
            get { return this.gsmModel; }
            set { this.gsmModel = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public double? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        //methods
        public override string ToString()
        {
            return string.Format("MODEL: {0}, manufacturer: {1}, price: {2}, owner: {3}, \nBATTERY: {4}, , \nDISPLAY: {5}\n", gsmModel, manufacturer, price, owner, battery, display);
        }
        public void AddCall(string date, string time, string dialedPhone, int duration)
        {
            Call newCall = new Call(date, time, dialedPhone, duration);
            callHistory.Add(newCall);
        }
        public void DeleteCall(Call callToDelete)
        {
            callHistory.Remove(callToDelete);
        }
        public void ClearCallHistory()
        {
            callHistory.Clear();
        }
        public string CalculateTotalPrice(double PRICE_PER_MIN)
        {
            double totalPrice = 0;
            foreach (Call call in this.callHistory)
            {
                totalPrice = totalPrice + call.Duration * PRICE_PER_MIN;
            }
            return String.Format("{0:F2}", totalPrice);
        }


    }
}
