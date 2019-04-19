using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;
namespace Dokkaebi.Core.Commands
{
    public class HayirliPAZARLAR : ModuleBase<SocketCommandContext>
    {
        [Command("hpazar"), Summary("ricardo abim <3")]
        public async Task hayirlipazarlar()
        {
            await Context.Channel.SendFileAsync(@"C:\Users\Starosti\source\repos\Dokkaebi\Dokkaebi\Data\PAZAR.png", "HAYIRLI PAZARLAR @everyone");
        }
    }
}