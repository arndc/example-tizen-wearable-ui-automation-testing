using NUnit.Framework;

namespace Me.Arnedc.Example.Tizen.Wearable.UITest
{
    [TestFixture]
    public class CheckTest : TestTemplate
    {

        [Test]
        public void TestOnAndOffToggleCheckComponent()
        {
            Driver.Click("onOff");

            var isToggled = Driver.GetAttribute<bool>("onOff", "IsToggled");
            Assert.True(isToggled, "Check(onOff).IsToggled should be true, but got " + isToggled);

            Driver.Click("onOff");

            isToggled = Driver.GetAttribute<bool>("onOff", "IsToggled");
            Assert.False(isToggled, "Check(onOff).IsToggled should be false, but got " + isToggled);
        }
    }
}
