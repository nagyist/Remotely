﻿using Remotely.Shared.Enums;

namespace Remotely.Shared.ViewModels;

public class ChatHistoryItem
{
    public ChatHistoryItemOrigin Origin { get; init; }
    public string? Message { get; init; }

    public DateTimeOffset Timestamp { get; init; } = DateTime.Now;

    public string ClassName
    {
        get
        {
            switch (Origin)
            {
                case ChatHistoryItemOrigin.System:
                    return "chat-history-item-system";
                case ChatHistoryItemOrigin.Self:
                    return "chat-history-item-self";
                case ChatHistoryItemOrigin.Device:
                    return "chat-history-item-device";
                default:
                    return string.Empty;
            }
        }
    }
}
