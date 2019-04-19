using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;
namespace Dokkaebi.Core.Commands
{
    public class HayirliCumalar : ModuleBase<SocketCommandContext>
    {
        [Command("hcuma"), Summary("ricardo abim <3")]
        public async Task hayirlicumalar()
        {
            await Context.Channel.SendFileAsync(@"C:\Users\Starosti\source\repos\Dokkaebi\Dokkaebi\Data\CUMAAA.png", "HAYIRLI CUMALAR @everyone");
        }
    }
}