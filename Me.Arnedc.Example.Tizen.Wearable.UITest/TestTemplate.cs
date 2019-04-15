using NUnit.Framework;

namespace Me.Arnedc.Example.Tizen.Wearable.UITest
{
    public class TestTemplate
    {
        public UITestDriver Driver;

        public int SpeedX;
        public int SpeedY;

        [OneTimeSetUp]
        public void Init()
        {
            Driver = UITestDriver.Instance;
        }

        [TearDown]
        public void TestCleanUp()
        {
            Driver.Quit();
        }
    }
}
