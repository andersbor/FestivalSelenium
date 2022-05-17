using OpenQA.Selenium; // nuget Selenium.WebDriver
using OpenQA.Selenium.Chrome;

string driverDirectory = "C:\\webDrivers";
IWebDriver driver = new ChromeDriver(driverDirectory);

string[] names = {
    /*"amager-bryghus", "bicycle-brewing",*/ "bryggeriet-kant", "bryggeriudstyr-aps", "castle-malting",
    "charlies-pubs", "copenhagen-mead-company", "dry-bitter-brewing", "esrum-kloster",
    "flying-couch-brewing", "gamma-brewing-company", "herslev-bryghus", "husbryggeriet-jacobsen",
    "haandbryggerne", "observatoriet", "to-oel-cph", "ukrainerejser-og-thunderbrew", "aaben"
};

foreach (string name in names)
{
    string url = $"https://xn--lfestival-k8a.dk/udstillere/{name}/?oelfestival=2022";
    driver.Navigate().GoToUrl(url);

    try
    {
        IWebElement element = driver.FindElement(By.ClassName("tomliste"));
    }
    catch (NoSuchElementException) { Console.WriteLine("Found: " + name); }
}

driver.Dispose();