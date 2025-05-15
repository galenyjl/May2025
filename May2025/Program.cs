using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Open chrome driver
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Launch website
driver.Navigate().GoToUrl("https://jadcup.gradspace.org/");

// Identity username textbox and enter valid name
IWebElement usernameTextBox = driver.FindElement(By.Id("normal_login_username"));
usernameTextBox.SendKeys("superadmin");

// Identity password textbox and enter valid password
IWebElement passwordTextBox = driver.FindElement(By.Id("normal_login_password"));
passwordTextBox.SendKeys("string2");

// Click on login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"normal_login\"]/div[3]/div/div/div/div/button"));
loginButton.Click();
Thread.Sleep(2000);

// Check if user is logged in sucessfully
IWebElement ReportMenu = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[1]/div/div/div[2]/ul/li[6]/div/span[2]"));

if (ReportMenu.Text == "Report")
{
    Console.WriteLine("Logged in successfully, test passed.");
}
else
{
    Console.WriteLine("Login failed, test failed");
}