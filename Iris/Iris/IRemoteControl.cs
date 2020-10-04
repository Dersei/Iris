using System.Threading.Tasks;

namespace Iris
{
    public interface IRemoteControl
    {
        void SendMessage(int frequency, int[] pattern);
        Task SendMessageAsync(int frequency, int[] pattern);
    }
}