using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;

namespace Dokkaebi.Core.Commands
{
    public class Hayirlisalilar : ModuleBase<SocketCommandContext>
    {
        [Command("hsali"), Summary("ricardo abim <3")]
        public async Task hayirlisalilar()
        {
            await Context.Channel.SendFileAsync(@"C:\Users\Starosti\source\repos\Dokkaebi\Dokkaebi\Data\SALI.png", "HAYIRLI SALILAR @everyone");
        }
    }
}