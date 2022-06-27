﻿using Telegram.Contracts.DTOs;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.DTOs.Files;
using Telegram.Contracts.Events.Files;
using Telegram.Contracts.Events.Files.Animations;
using Telegram.Contracts.Events.Files.Audio;
using Telegram.Contracts.Events.Files.Photos;
using Telegram.Contracts.Events.Files.Video;
using Telegram.Contracts.Events.Messages;

namespace Telegram.Contracts.ApiClients.Interfaces;

/// <summary>
/// Клиент Telegram API.
/// </summary>
public interface ITelegramClient
{
    /// <summary>
    /// Возвращает информацию о боте.
    /// </summary>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Информация о боте.</returns>
    Task<TelegramResponse<User>?> GetBotInfoAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет сообщение. В случае успеха возвращается отправленное <see cref="Message"/>.
    /// </summary>
    /// <param name="sendMessage">Отправляемое сообщение.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное сообщение.</returns>
    Task<TelegramResponse<Message>?> SendMessageAsync(SendMessage sendMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Пересылает сообщение. В случае успеха возвращается отправленное <see cref="Message"/>.
    /// </summary>
    /// <param name="forwardMessage">Пересылаемое сообщение.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное сообщение.</returns>
    Task<TelegramResponse<Message>?> ForwardMessageAsync(ForwardMessage forwardMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Копирует сообщение. В случае успеха возвращает идентификатор отправленного сообщения.
    /// </summary>
    /// <param name="copyMessage">Копируемое сообщение.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Идентификатор отправленного сообщения.</returns>
    Task<TelegramResponse<MessageIdentifier>?> CopyMessageAsync(CopyMessage copyMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет фотографию. В случае успеха возвращает отправленное <see cref="Message"/>.
    /// </summary>
    /// <param name="sendPhoto">Отправляемая фотография.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное сообщение.</returns>
    Task<TelegramResponse<Message>?> SendPhotoAsync(SendPhoto sendPhoto, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет аудиофайл. В случае успеха возвращает отправленное <see cref="Message"/>.<br />
    /// Файл должен быть в формате .MP3 или .M4A.<br />
    /// <b>Для отправки голосовых сообщений используется метод <see cref="SendVoiceAsync"/>.</b>
    /// </summary>
    /// <param name="sendAudio">Отправляемый аудиофайл.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное сообщение.</returns>
    Task<TelegramResponse<Message>?> SendAudioAsync(SendAudio sendAudio, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет общий файл. В случае успеха возвращает отправленное <see cref="Message"/>.
    /// </summary>
    /// <param name="sendFile">Отправляемый файл.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное сообщение.</returns>
    Task<TelegramResponse<Message>?> SendFileAsync(SendFile sendFile, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет видео в формате MPEG4(другие форматы могут быть отправлены с помощью <see cref="SendFile"/>). В случае успеха возвращает отправленное <see cref="Message"/>.
    /// </summary>
    /// <param name="sendVideo">Отправляемое видео.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное сообщение.</returns>
    Task<TelegramResponse<Message>?> SendVideoAsync(SendVideo sendVideo, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет анимации(GIF или H.264/MPEG-4 AVC без звука). В случае успеха возвращает отправленное <see cref="Message"/>.
    /// </summary>
    /// <param name="sendAnimation">Отправляемая анимация.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное сообщение.</returns>
    Task<TelegramResponse<Message>?> SendAnimationAsync(SendAnimation sendAnimation, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет голосовое сообщение(в формате .OGG, закодированном с помощью OPUS). В случае успеха возвращает отправленное <see cref="Message"/>.<br />
    /// Другие форматы могут быть отправлены с помощью <see cref="SendAudio"/> или <see cref="SendFile"/>. 
    /// </summary>
    /// <param name="sendVoice">Отправляемое голосовое сообщение.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное сообщение.</returns>
    Task<TelegramResponse<Message>?> SendVoiceAsync(SendVoice sendVoice, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет видеосообщение(в формате .MPEG4). В случае успеха возвращает отправленное <see cref="Message"/>.
    /// </summary>
    /// <param name="sendVideoNote">Отправляемое видеосообщение.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное сообщение.</returns>
    Task<TelegramResponse<Message>?> SendVideoNoteAsync(SendVideoNote sendVideoNote, CancellationToken cancellationToken = default);
}