namespace Me.Arnedc.Example.Tizen.Wearable.App
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();

            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            global::Tizen.Wearable.CircularUI.Forms.Renderer.FormsCircularUI.Init();
            global::Tizen.Appium.TizenAppium.StartService(app);
            app.Run(args);
        }

        protected override void OnTerminate()
        {
            base.OnTerminate();
            global::Tizen.Appium.TizenAppium.StopService();
        }
    }
}
