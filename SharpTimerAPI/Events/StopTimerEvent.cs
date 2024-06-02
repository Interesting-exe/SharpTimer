using CounterStrikeSharp.API.Core;

namespace SharpTimerAPI.Events;

public record StopTimerEvent(CCSPlayerController? player, bool isSr, bool isPb, int tier) : ISharpTimerPlayerEvent
{
    public bool IsSr { get; set; } = isSr;
    public bool IsPb { get; set; } = isPb;
    public int Tier { get; set; } = tier;
};