using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;

namespace Dokkaebi.Core.Commands
{
    public class Deneme : ModuleBase<SocketCommandContext>
    {
        [Command("merhaba"),Summary("ilk komutum. deneme"), Alias("selam","sa")]
        public async Task deneme()
        {
            var otherField = new EmbedFieldBuilder()
                    .WithName(" :pray: :mosque: :kaaba: :100: :ok_hand: ")
                    .WithValue($"Selamın aleyküm. 100% müslüman bot.");
            var embed = new EmbedBuilder()
                .WithAuthor(Context.Client.CurrentUser)
                .AddField(otherField)
                .WithColor(Color.Gold)
                .Build();
            await Context.Channel.SendMessageAsync("", false, embed);
        }
    }
}
