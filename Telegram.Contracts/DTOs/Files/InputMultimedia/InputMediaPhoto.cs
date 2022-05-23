﻿using System.Collections.Generic;
using Telegram.Contracts.DTOs.Messages;

namespace Telegram.Contracts.DTOs.Files.InputMultimedia;

/// <summary>
/// Фото для отправки.
/// </summary>
/// <param name="Media">Файл для отправки.</param>
/// <param name="Caption">Заголовок отправляемой фотографии(от 0 до 1024 символов).</param>
/// <param name="ParseMode">?????????Режим разбора сущностей в подписи к фото?????????</param>
/// <param name="CaptionEntities">Список специальных сущностей в заголовке, которые можно указать вместо ParseMode.</param>
public record InputMediaPhoto(
    string Media,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities)
    : InputMedia(Media, Caption, ParseMode, CaptionEntities)
{
    public override string Type => "photo";
}