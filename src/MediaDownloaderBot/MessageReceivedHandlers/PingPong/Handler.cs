using MediaDownloaderBot.Commons;
using MediatR;
using Telegram.Bot.Types;

namespace MediaDownloaderBot.MessageReceivedHandlers.PingPong
{
    internal sealed class Handler : INotificationHandler<MessageReceived>
    {

        public async Task Handle(MessageReceived notification, CancellationToken cancellationToken)
        {
            if (notification.Message.Equals("bot", StringComparison.InvariantCultureIgnoreCase))
                await notification.Reply.SendMessageAsync("Im here....", cancellationToken);
            else if (notification.Message.Equals("hi", StringComparison.InvariantCultureIgnoreCase))
                await notification.Reply.SendMessageAsync("Hi 😎", cancellationToken);
            else if (notification.Message.Equals("hey", StringComparison.InvariantCultureIgnoreCase))
                await notification.Reply.SendMessageAsync("Hey 😎", cancellationToken);
            else if (notification.Message.Equals("hello", StringComparison.InvariantCultureIgnoreCase))
                await notification.Reply.SendMessageAsync("Hello there 😎", cancellationToken);
            else if(notification.Message.Equals("/start", StringComparison.InvariantCultureIgnoreCase))
                await notification.Reply.SendMessageAsync("Hi there.... Friendly Bot at your Service", cancellationToken);
            else if (notification.Message.Equals("/help", StringComparison.InvariantCultureIgnoreCase))
                await notification.Reply.SendMessageAsync("Give me a URL and ill send whatever is there. If you need more assistant you can contact the real Friendly Bot here @Chile02", cancellationToken);
            else if (notification.Message.StartsWith("http://") || notification.Message.StartsWith("https://"))
            {
                
            }
            else
            {
                await notification.Reply.SendMessageAsync("Give me a link and I'll try my best to help", cancellationToken);
            }
        }
    }
}
