using CounterStrikeSharp.API.Core;

namespace SharpTimerAPI;

public interface ISharpTimerManager
{
    void RestartTimer(CCSPlayerController player);
}