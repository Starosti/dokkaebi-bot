using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;
namespace Dokkaebi.Core.Commands
{
    public class Yardim : ModuleBase<SocketCommandContext>
    {
        [Command("yardim"), Alias("help"), Summary("ricardo abim <3")]
        public async Task yardim()
        {
            var exampleAuthor = new EmbedAuthorBuilder()
        .WithName("Dokkaebi Bot v1.2")
        .WithIconUrl("https://cdn.discordapp.com/attachments/553634371903684613/568835556553785344/tumblr_p0v3ko4w5o1w5um5jo5_1280.png");
            var exampleField = new EmbedFieldBuilder()
                    .WithName("Genel")
                    .WithValue(@"d!yardim
d!merhaba(selam,sa)
d!kutsa
d!duaet(haciol)
");
            var otherField = new EmbedFieldBuilder()
                    .WithName("Günler")
                    .WithValue(@"d!hpazartesi
d!hsali
d!hcarsamba
d!hpersembe
d!hcuma
d!hcumartesi
d!hpazar");
            var footer = new EmbedFooterBuilder()
        .WithText("Destek:Starosti#2679");
            var embed = new EmbedBuilder()
                    .WithAuthor(Context.Client.CurrentUser)
                    .AddField(exampleField)
                    .AddField(otherField)
                    .WithAuthor(exampleAuthor)
                    .WithFooter(footer)
                    .WithCurrentTimestamp()
                    .WithColor(Color.Gold)
                    .Build();
            await Context.Channel.SendMessageAsync("", false, embed);
        }
    }
}