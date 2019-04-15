# Example Tizen wearable UI automation testing

This example shows the basic setup of UI automation testing for Tizen wearable applications and is based on the guide [Creating UI automation test for Tizen .NET Application](https://samsung.github.io/Tizen.CircularUI/guide/CreatingTestAutomation.html).

## Prerequisites

**Set environment variables**

1. Add `TIZEN_HOME` as system variable pointing to the Tizen root SDK path
2. Add the subdirectory `tools` from the Tizen root SDK to the path system variable

## Appium server

Follow the steps below to run the Appium server. This example is tested using Appium version **1.15.1**.

1. Clone or download the [Appium GitHub repository](https://github.com/appium/appium)
2. Open the _package.json_ file from the Appium repository and change the version of the `tizen-appium-driver` dependency to `arndc/appium-tizen-driver#feature/add-tpk-location-to-install-tpk`
3. Run `npm run build`
4. Run `node .`

> The use of the fork [arndc/appium-tizen-driver#feature/add-tpk-location-to-install-tpk](https://github.com/arndc/appium-tizen-driver/tree/feature/add-tpk-location-to-install-tpk) makes it possible to define the tpk location as the Appium option `appLocation`. The tpk location is required for the eventual installation of the application on the test device.

## UI test driver

The UI test driver communicates with the Appium server.

### Configuration

The configuration of the driver is located in [DriverConfig.cs](Me.Arnedc.Example.Tizen.Wearable.UITest/DriverConfig.cs) and contains all the required capabilities for the Tizen Appium driver, the speed of actions on the device and the remote address of the Appium server.

#### Capabilities

Since this example uses a fork of the Tizen Appium driver, an extra capability `appLocation` can be used to define the tpk location of the wearable application. Below all the capabilities for the Tizen Appium driver are listed.

| Capablities  | Description                                                                                                                   |
|--------------|-------------------------------------------------------------------------------------------------------------------------------|
| platformName | The name of the platform, in this case `Tizen`.                                                                               |
| deviceName   | The name of the test device. Run command `sdb devices` to find the device name.                                               |
| appPackage   | The package of the application under test.                                                                                    |
| app          | The application installable.                                                                                                  |
| appLocation  | The location of the application installable. This is a custom capability and is not part of the standard appium-tizen-driver. |
