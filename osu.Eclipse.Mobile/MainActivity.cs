using Android.App;
using Android.OS;
using osu.Framework.Android;
using osu.Eclipse.Game;

namespace osu.Eclipse.Mobile
{
    [Activity(Label = "osu! eclipse", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/MainTheme", ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation)]
    public class MainActivity : AndroidGameActivity
    {
        protected override osu.Framework.Game CreateGame() => new EclipseGame();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Perform additional mobile setup here if needed (e.g., permissions, orientation lock).
        }
    }
}
