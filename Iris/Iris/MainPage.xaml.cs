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

        private readonly IRemoteControl _remoteControl;
        
        private void ButtonTurnOn_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.TurnOn);
        }

        private void ButtonTurnOff_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.TurnOff);
        }
        
        private void ButtonBrightnessDown_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.BrightnessDown);
        }
        
        private void ButtonBrightnessUp_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.BrightnessUp);
        }
        
        private void ButtonWhite_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.White);
        }
        
        private void ButtonBlue_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Blue);
        }
        
        private void ButtonGreen_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Green);
        }
        
        private void ButtonRed_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Red);
        }
        
        private void ButtonBlue1_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Blue1);
        }
        
        private void ButtonGreen1_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Green1);
        }
        
        private void ButtonRed1_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Red1);
        }
        
        private void ButtonBlue2_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Blue2);
        }
        
        private void ButtonGreen2_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Green2);
        }
        
        private void ButtonRed2_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Red2);
        }
        
        private void ButtonBlue3_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Blue3);
        }
        
        private void ButtonGreen3_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Green3);
        }
        
        private void ButtonRed3_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Red3);
        }
        
        private void ButtonBlue4_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Blue4);
        }
        
        private void ButtonGreen4_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Green4);
        }
        
        private void ButtonRed4_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Red4);
        }
        
        private void ButtonFlash_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Flash);
        }
        
        private void ButtonStrobe_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Strobe);
        }
        
        private void ButtonSmooth_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Smooth);
        }
        
        private void ButtonMode_OnClicked(object sender, EventArgs e)
        {
            _remoteControl.SendMessage(IrCodes.Frequency, IrCodes.Mode);
        }
    }
}