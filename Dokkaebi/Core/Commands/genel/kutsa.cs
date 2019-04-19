using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;

namespace Dokkaebi.Core.Commands
{
    public class kutsa : ModuleBase<SocketCommandContext>
    {
        [Command("kutsa"), Summary("kutsa.")]
        public async Task deneme()
        {
            var otherField = new EmbedFieldBuilder()
                    .WithName("")
                    .WithValue($"@{Context.User} kutsandı. :pray: :mosque: :kaaba: ");
            var embed = new EmbedBuilder()
                .WithAuthor(Context.Client.CurrentUser)
                .AddField(otherField)
                .WithColor(Color.Gold)
                .Build();
            await Context.Channel.SendMessageAsync("", false, embed);
        }
    }
}
