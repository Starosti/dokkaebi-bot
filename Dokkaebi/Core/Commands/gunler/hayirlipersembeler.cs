using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;
namespace Dokkaebi.Core.Commands
{
    public class HayirliPersembeler : ModuleBase<SocketCommandContext>
    {
        [Command("hpersembe"), Summary("ricardo abim <3")]
        public async Task hayirlipersembeler()
        {
            await Context.Channel.SendFileAsync(@"C:\Users\Starosti\source\repos\Dokkaebi\Dokkaebi\Data\PERŞEMBE.png", "HAYIRLI PERŞEMBELER @everyone");
        }
    }
}