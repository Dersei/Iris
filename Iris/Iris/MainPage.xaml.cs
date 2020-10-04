using System;
using Xamarin.Forms;

namespace Iris
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            _remoteControl = DependencyService.Get<IRemoteControl>();
        }

        private IRemoteControl _remoteControl;
        
        private void ButtonTurnOn_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(38_000, IrCodes.TurnOn);
        }

        private void ButtonTurnOff_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(38_000, IrCodes.TurnOff);
        }
        
        private void ButtonBrightnessDown_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(38_000, IrCodes.BrightnessDown);
        }
        
        private void ButtonBrightnessUp_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(38_000, IrCodes.BrightnessUp);
        }
        
        private void ButtonWhite_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(38_000, IrCodes.White);
        }
        
        private void ButtonBlue_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(38_000, IrCodes.Blue);
        }
        
        private void ButtonGreen_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(38_000, IrCodes.Green);
        }
        
        private void ButtonRed_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(38_000, IrCodes.Red);
        }
    }
}