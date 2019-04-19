using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;
namespace Dokkaebi.Core.Commands
{
    public class HayirliCumartesiler : ModuleBase<SocketCommandContext>
    {
        [Command("hcumartesi"), Summary("ricardo abim <3")]
        public async Task hayirlicumartesiler()
        {
            await Context.Channel.SendFileAsync(@"C:\Users\Starosti\source\repos\Dokkaebi\Dokkaebi\Data\CUMARTESİ.png", "HAYIRLI CUMARTESİLER @everyone");
        }
    }
}