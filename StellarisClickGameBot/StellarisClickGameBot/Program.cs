using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Windows.Forms;

using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace StellarisClickGameBot
{
    public enum BotMode { ClickMode, DefaultMode };

    static class Program
    {
        public static BotMode botMode = BotMode.DefaultMode;
        public static bool manualPasswordEntry = true;
        public static bool enteredPswd = false;

        private static MainWindow mainWindow;

        static Random rng;

        static Thread botThread;

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }

        public static void shutDownBot() {
            if (botThread != null) {
                botThread.Abort();
            }
        }

        public static void startBotThread() {

            rng = new Random();

            botThread = new Thread(new ThreadStart(executeClicks));
            botThread.Start();
        }

        static void executeClicks()
        {
            IWebDriver driver = new FirefoxDriver();
            Actions builder = new Actions(driver);
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2.00));

            //driver.Navigate().GoToUrl("https://launchpad.stellarisgame.com/game/"); //for absolutely no reason this doensn't work...
            driver.Navigate().GoToUrl("https://launchpad.stellarisgame.com");

            Thread.Sleep(5000);

            wait.Until(ExpectedConditions.ElementExists(By.ClassName("advisor__action__accept")));
            driver.FindElement(By.ClassName("advisor__action__accept")).Click();

            wait.Until(ExpectedConditions.ElementExists(By.Id("session_username")));

            if (!manualPasswordEntry)
            {
                driver.FindElement(By.Id("session_username")).SendKeys(mainWindow.getUsername());
                driver.FindElement(By.Id("session_password")).SendKeys(mainWindow.getPassword());

                driver.FindElement(By.Name("commit")).Click();
            }
            else {
                while (!enteredPswd) { } // wait until User has entered password and pressed the button
            }           

            for (int i = 0; i < 4; i++)
            {
                wait.Until(ExpectedConditions.ElementExists(By.ClassName("advisor__action__accept")));
                driver.FindElement(By.ClassName("advisor__action__accept")).Click();
                Thread.Sleep(3000);
            }

            wait.Until(ExpectedConditions.ElementExists(By.Id("mute")));
            driver.FindElement(By.Id("mute")).Click();

            while (true)
            {
                if (botMode == BotMode.DefaultMode) {
                    int decision = rng.Next(0, 25);
                    if (decision == 0)
                    {
                        //search for debree/blueprints:
                        for (int x = 0; x <= 3; x++)
                        {
                            for (int y = 0; y <= 2; y++)
                            {
                                builder.MoveToElement(driver.FindElement(By.ClassName("dashboard")), x * 400, y * 200).Click().Build().Perform();
                            }
                        }
                    }
                }   

                driver.FindElement(By.ClassName("button")).Click();

                //100 clicks in second
                Thread.Sleep(10);
            }
        }
    }
}
