﻿namespace ScreenSound.API.Request
{
    public record ArtistaRequestEdit(int Id, string nome, string bio)
    : ArtistaRequest(nome, bio);

}
