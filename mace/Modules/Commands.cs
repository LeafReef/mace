using System;
using System.Threading.Tasks;
using Discord.Commands;

namespace SpeckBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        // MarketPrices price = new MarketPrices();

        [Command("leaf")]
        public async Task Leaf()
        {
            //double bitcoinPrice = price.GetBitcoinPrice((currency));

            await ReplyAsync("Hello team");
        }
    }
}