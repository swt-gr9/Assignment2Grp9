using System;
using AirTrafficMonitoringSystem.DataFormatter;
using TransponderReceiver;

namespace AirTrafficMonitoringSystem.TransponderReceiverClient
{
    public class TransponderReceiverClient
    {
        private ITransponderReceiver receiver;

        
        public TransponderReceiverClient(ITransponderReceiver receiver)
        {
            
            this.receiver = receiver;

            
            this.receiver.TransponderDataReady += ReceiverOnTransponderDataReady;
        }

        private void ReceiverOnTransponderDataReady(object sender, RawTransponderDataEventArgs e)
        {
            Console.WriteLine("---------------");
            foreach (var data in e.TransponderData)
            {
                System.Console.WriteLine($"Transponderdata {data}");    
            }
            Console.WriteLine("------------");
        }
    }
}
