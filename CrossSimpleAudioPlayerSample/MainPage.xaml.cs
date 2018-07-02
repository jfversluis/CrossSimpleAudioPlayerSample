using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossSimpleAudioPlayerSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		public void Handle_Clicked(object sender, EventArgs e)
		{
			Play();
		}

		private void Play()
		{
			var assembly = typeof(App).GetTypeInfo().Assembly;
			Stream audioStream = assembly.GetManifestResourceStream("CrossSimpleAudioPlayerSample.Resources.sheep.wav");
			var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
			audio.Load(audioStream);

			audio.Play();
		}
	}
}