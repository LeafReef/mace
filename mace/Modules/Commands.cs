using System;
using System.Threading.Tasks;
using Discord.Commands;
using mace.Modules;

namespace SpeckBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        SensorData sensor = new SensorData();

        [Command("temp")]
        public async Task Temperature()
        {
            string temperature = sensor.getTemperature();

            await ReplyAsync(temperature + "°C");
        }

        [Command("hum")]
        public async Task Humidity()
        {
            string humidity = sensor.getHumidity();

            await ReplyAsync(humidity + "%");
        }
    }
}