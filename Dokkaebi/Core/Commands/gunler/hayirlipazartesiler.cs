using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;
namespace Dokkaebi.Core.Commands
{
    public class HayirliPazartesiler : ModuleBase<SocketCommandContext>
    {
        [Command("hpazartesi"), Summary("ricardo abim <3")]
        public async Task hayirlipazartesiler()
        {
            await Context.Channel.SendFileAsync(@"C:\Users\Starosti\source\repos\Dokkaebi\Dokkaebi\Data\PAZARTESİ.png", "HAYIRLI PAZARTESİLER @everyone");
        }
    }
}