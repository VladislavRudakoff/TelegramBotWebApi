using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Common.Commands.Messages;

/// <summary>
/// Модель для редактирования разметки сообщений.
/// </summary>
/// <param name="ChatId">Идентификатор чата(если не указан InlineMessageId).</param>
/// <param name="MessageId">Идентификатор редактируемого сообщения(если не указан InlineMessageId).</param>
/// <param name="InlineMessageId">Идентификатор inline-сообщения(если не указаны ChatId и MessageId).</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
public record EditMessageReplyMarkup(
    ChatId? ChatId,
    int? MessageId,
    string? InlineMessageId,
    InlineKeyboardMarkup? ReplyMarkup)
    : IEventEntity;