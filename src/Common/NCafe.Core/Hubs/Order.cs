﻿namespace NCafe.Core.Hubs;

public sealed record Order(Guid Id, Guid ProductId, int Quantity);
