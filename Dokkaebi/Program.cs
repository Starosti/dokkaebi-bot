using System;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;

using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Dokkaebi
{
    class Program
    {
        private DiscordSocketClient Client;
        private CommandService Commands;
        private LogSeverity logSeverityLevel = LogSeverity.Debug;
        private int ArgPos = 0;

        static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();

        private bool IsDM(SocketMessage msg)
        {
            return (msg.Channel.GetType() == typeof(SocketDMChannel));
        }

        private async Task MainAsync()
        {
            Client = new DiscordSocketClient(new DiscordSocketConfig {
                LogLevel = logSeverityLevel
            });

            Commands = new CommandService(new CommandServiceConfig
            {
                CaseSensitiveCommands = true,
                DefaultRunMode = RunMode.Async,
                LogLevel = logSeverityLevel
            });

            Client.MessageReceived += Client_MessageReceived;
            await Commands.AddModulesAsync(Assembly.GetEntryAssembly(),null);

            Client.Ready += Client_Ready;
            Client.Log += Client_Log;
            #region 
            string Token = "dokkaebi is the best";
            #endregion //token
            await Client.LoginAsync(TokenType.Bot,Token);
            await Client.StartAsync();
            await Task.Delay(-1);
        }

        private async Task Client_Log(LogMessage Message)
        {
            Console.WriteLine($"[{DateTime.Now} at {Message.Source}] {Message.Message}");
        }

        private async Task Client_Ready()
        {
            await Client.SetGameAsync("Starosti#2679'nin saçlarıyla",null, ActivityType.Playing);
        }

        private async Task Client_MessageReceived(SocketMessage MessageParam)
        {
            var Message = MessageParam as SocketUserMessage;
            var Context = new SocketCommandContext(Client, Message);
            
            if (Context.Message == null || Context.Message.Content == "") return;
            if (Context.User.IsBot) return;
            if (IsDM(Context.Message) == true) {
                DM(Context);
                return;
            }            
            if (!(Message.HasStringPrefix("d!", ref ArgPos) || Message.HasMentionPrefix(Client.CurrentUser, ref ArgPos))) return;
            var Result = await Commands.ExecuteAsync(Context, ArgPos, null);
            if (!Result.IsSuccess)
                Console.WriteLine($"[{DateTime.Now}at Commands] Samting vent vırong plis çek it aut. Yazı:\"{Context.Message.Content}\" | Sıkıntı: {Result.ErrorReason}");
        }
        public async Task DM(SocketCommandContext Context)
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
