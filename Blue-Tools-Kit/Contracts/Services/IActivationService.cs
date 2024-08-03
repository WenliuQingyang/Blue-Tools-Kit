namespace Blue_Tools_Kit.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
