﻿namespace WinUI_1.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
