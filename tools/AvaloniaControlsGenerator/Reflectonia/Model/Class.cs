﻿namespace AvaloniaControlsGenerator.Reflectonia.Model;

public record Class(
    string Name,
    Type Type,
    Property[] Properties,
    Event[] Events,
    bool IsSealed = false,
    bool PublicCtor = true,
    bool IsAbstract = false
);
