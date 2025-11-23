using System;

namespace RemoteSystem
{
    // Basic remote functions
    interface IRemote
    {
        void PowerOn();
        void PowerOff();
        void IncreaseVolume();
        void ChangeChannel(int channelNumber);
    }

    // Extra feature: Price
    interface IRemotePrice
    {
        string GetPrice();
    }

    // Extra feature: Location
    interface IRemoteLocation
    {
        string GetLocation();
    }

    // Sony implements IRemote + IRemotePrice
    class SonyRemote : IRemote, IRemotePrice
    {
        public void PowerOn() => Console.WriteLine("Sony TV ON");
        public void PowerOff() => Console.WriteLine("Sony TV OFF");
        public void IncreaseVolume() => Console.WriteLine("Sony Volume Increased");
        public void ChangeChannel(int ch) => Console.WriteLine($"Sony changed to channel {ch}");
        public string GetPrice() => "Price: 500 Rupees";
    }

    // LG implements IRemote + IRemoteLocation
    class LGRemote : IRemote, IRemoteLocation
    {
        public void PowerOn() => Console.WriteLine("LG TV ON");
        public void PowerOff() => Console.WriteLine("LG TV OFF");
        public void IncreaseVolume() => Console.WriteLine("LG Volume Increased");
        public void ChangeChannel(int ch) => Console.WriteLine($"LG changed to channel {ch}");
        public string GetLocation() => "Location: Bangalore";
    }

    class Program
    {
        static void Main()
        {
            IRemote sony = new SonyRemote();
            sony.PowerOn();
            sony.ChangeChannel(5);

            IRemotePrice sonyPrice = new SonyRemote();
            Console.WriteLine(sonyPrice.GetPrice());

            IRemote lg = new LGRemote();
            lg.PowerOn();
            lg.ChangeChannel(10);

            IRemoteLocation lgLocation = new LGRemote();
            Console.WriteLine(lgLocation.GetLocation());
        }
    }
}
