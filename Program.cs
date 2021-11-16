using Microsoft.Playwright;
using System.Threading.Tasks;
using System.Threading;

class Program
{   
    public static async Task Main()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync();
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://discord.com/");
        await page.ClickAsync("#app-mount > div > div > div.grid-3Ykf_K.heroBackground-3m0TRU > div.row-3wW-Fx.heroContainer-3j1eQg > div > div.ctaContainer-3vWJHU > button");
        await Thread.Sleep(1000);
        await page.TypeAsync("input.username-27KRPU", "SlashToken");
        await page.WaitForSelectorAsync("iframe");
        await Thread.Sleep(3000);
        await page.ClickAsync("iframe")
        
    }
}