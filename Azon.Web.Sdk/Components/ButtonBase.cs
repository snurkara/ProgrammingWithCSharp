﻿namespace Azon.Web.Sdk.Components;

public abstract class ButtonBase(int id, string name, (double, double) position)
        : Control(id, name, position)
{
    public string? BackgroundColor { get; set; }
    public string? ForegroundColor { get; set; }
}