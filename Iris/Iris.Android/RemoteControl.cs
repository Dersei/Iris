using System;
using System.Threading.Tasks;
using Android.Content;
using Android.Hardware;
using Iris.Android;
using Xamarin.Forms;

[assembly: Dependency(typeof(RemoteControl))]
namespace Iris.Android
{
    public class RemoteControl : IRemoteControl
    {
        private readonly ConsumerIrManager? _irManager;

        public RemoteControl()
        {
            _irManager = (ConsumerIrManager?)MainActivity.Instance.GetSystemService (Context.ConsumerIrService);
            if(_irManager is null) throw new NullReferenceException("Problem with IrManager");
        }

        public void SendMessage(int frequency, int[] pattern)
        {
            _irManager!.Transmit(frequency, pattern);
        }
        
        public Task SendMessageAsync(int frequency, int[] pattern)
        {
            return _irManager!.TransmitAsync(frequency, pattern);
        }
    }
}