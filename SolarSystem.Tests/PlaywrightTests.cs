using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolarSystem.Tests
{
    [TestClass]
    public class PlaywrightTests
    {
        [TestMethod]
        public async Task RecorderGeneratedMSTest()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions {
                Headless = false,
                Channel = "msedge",
            });
            var context = await browser.NewContextAsync();

            // Open new page
            var page = await context.NewPageAsync();

            // Go to https://playwright.dev/
            await page.GotoAsync("https://playwright.dev/");

            // Click text=Docs
            await page.ClickAsync("text=Docs");
            Assert.AreEqual("https://playwright.dev/docs/intro", page.Url);

            // Click text=Supported languages
            await page.ClickAsync("text=Supported languages");
            Assert.AreEqual("https://playwright.dev/docs/languages", page.Url);

            // Click article >> text=.NET
            await page.ClickAsync("article >> text=.NET");
            Assert.AreEqual("https://playwright.dev/docs/languages#net", page.Url);
        }

        [TestMethod]
        public Task NewRecordedWebUITest()
        {
            return Task.CompletedTask;
        }
    }
}
