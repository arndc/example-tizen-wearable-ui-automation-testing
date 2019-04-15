using System.IO;

namespace Me.Arnedc.Example.Tizen.Wearable.UITest
{
    public static class DriverConfig
    {
        public const string APPIUM_SERVER_URI = "http://localhost:4723/wd/hub";

        public const string PLATFORM = "Tizen";
        public const string DEVICE_NAME = "emulator-26101";
        public const string APP_PACKAGE_NAME = "me.arnedc.example.tizen.wearable.uitest.app";
        public const string APP_NAME = "me.arnedc.example.tizen.wearable.uitest.app-1.0.0.tpk";

        public const int DEFAULT_DELAY_TIME = 1000;
        public const int SPEEDX_EMUL_40 = -45;
        public const int SPEEDY_EMUL_40 = -35;
        public const int SPEEDX_EMUL_50 = -100;
        public const int SPEEDY_EMUL_50 = -100;
        public const int SPEEDX_GALAXY_WATCH = -80;
        public const int SPEEDY_GALAXY_WATCH = -60;

        public static string GetAppLocation()
        {
            string solutionRoot = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, "..\\..\\..\\"));

            return Path.Combine(solutionRoot, "Me.Arnedc.Example.Tizen.Wearable.App", "bin", "Debug", "tizen40");
        }
    }
}
