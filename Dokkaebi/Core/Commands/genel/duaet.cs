using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;
namespace Dokkaebi.Core.Commands
{
    public class Duaet : ModuleBase<SocketCommandContext>
    {
        [Command("duaet"), Summary("dua et."),Alias("haciol")]
        public async Task duaet()
        {
            var otherField = new EmbedFieldBuilder()
                    .WithName(":pray:")
                    .WithValue($"ALLAH'ım sen @{Context.User} 'e hacı olmayı nasip eyle. Amin :pray:");
            var embed = new EmbedBuilder()
                .WithAuthor(Context.Client.CurrentUser)
                .AddField(otherField)
                .WithColor(Color.Gold)
                .Build();
            await Context.Channel.SendMessageAsync("", false, embed);
        }
    }
}