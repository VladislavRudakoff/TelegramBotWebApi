using Telegram.Contracts.DTOs;
using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Commands;
using Telegram.Contracts.DTOs.Menu;
using Telegram.Contracts.Events.BotCommands.Commands;
using Telegram.Contracts.Events.BotCommands.Queries;
using Telegram.Contracts.Events.Chats.Commands;
using Telegram.Contracts.Events.Chats.Commands.Buttons;
using Telegram.Contracts.Events.Chats.Queries.Buttons;

namespace Telegram.Contracts.ApiClients.Interfaces;

/// <summary>
/// Клиент Telegram Api с методами для бота.
/// </summary>
public interface IBotTelegramClient
{
    /// <summary>
    /// Возвращает информацию о боте.
    /// </summary>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Информация о боте.</returns>
    Task<TelegramResponse<User>?> GetBotInfoAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Устанавливает список команд бота.
    /// </summary>
    /// <param name="setMyCommands"><see cref="SetMyCommands"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetCommandsAsync(SetMyCommands setMyCommands, CancellationToken cancellationToken = default);

    /// <summary>
    /// Удаляет список команд бота для данной области и языка пользователя. После удаления, затронутым пользователям будут показаны команды более высокого уровня.
    /// </summary>
    /// <param name="deleteMyCommands"><see cref="DeleteMyCommands"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> DeleteCommandsAsync(DeleteMyCommands deleteMyCommands, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает коллекцию команд бота.
    /// </summary>
    /// <param name="getMyCommands"><see cref="GetMyCommands"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>Коллекция <see cref="BotCommand"/>.</b></returns>
    Task<TelegramResponse<IEnumerable<BotCommand>>?> GetCommandsAsync(GetMyCommands getMyCommands, CancellationToken cancellationToken = default);

    /// <summary>
    /// Изменяет кнопку меню бота в приватном чате или кнопку меню по умолчанию.
    /// </summary>
    /// <param name="setChatMenuButton"><see cref="SetChatMenuButton"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetChatMenuButtonAsync(SetChatMenuButton setChatMenuButton, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает текущее значение кнопки меню бота в приватном чате или кнопку меню по умолчанию.
    /// </summary>
    /// <param name="getChatMenuButton"><see cref="GetChatMenuButton"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="MenuButton"/>.</b></returns>
    Task<TelegramResponse<MenuButton>?> GetChatMenuButtonAsync(GetChatMenuButton getChatMenuButton, CancellationToken cancellationToken = default);

    /// <summary>
    /// Заставляет бота покинуть группу, супергруппу или канал.
    /// </summary>
    /// <param name="leaveChat"><see cref="LeaveChat"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> LeaveChatAsync(LeaveChat leaveChat, CancellationToken cancellationToken = default);

    /// <summary>
    /// Изменяет права администратора по умолчанию для бота. Будут использоваться при добавлении бота в какую-либо группу, либо канал.
    /// </summary>
    /// <remarks>Права можно изменить перед добавлением бота. <br />
    /// Если требуется удалить права по умолчанию параметр setDefaultAdministratorRights не указывается.</remarks>
    /// <param name="setDefaultAdministratorRights"><see cref="SetMyDefaultAdministratorRights"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetDefaultAdministratorRightsAsync(
        SetMyDefaultAdministratorRights setDefaultAdministratorRights, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает текущие права администратора по умолчанию для бота.
    /// </summary>
    /// <param name="getDefaultAdministratorRights"><see cref="GetMyDefaultAdministratorRights"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="ChatAdministratorRights"/>.</b></returns>
    Task<TelegramResponse<ChatAdministratorRights>?> GetDefaultAdministratorRightsAsync(
        GetMyDefaultAdministratorRights getDefaultAdministratorRights, 
        CancellationToken cancellationToken = default);
}