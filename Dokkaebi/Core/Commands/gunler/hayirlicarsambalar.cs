using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;
namespace Dokkaebi.Core.Commands
{
    public class Hayirlicarsambalar : ModuleBase<SocketCommandContext>
    {
        [Command("hcarsamba"), Summary("ricardo abim <3")]
        public async Task hayirlicarsambalar()
        {
            await Context.Channel.SendFileAsync(@"C:\Users\Starosti\source\repos\Dokkaebi\Dokkaebi\Data\ÇARŞAMBA.png", "HAYIRLI ÇARŞAMBALAR @everyone");
        }
    }
}