using CounterStrikeSharp.API.Core;

namespace SharpTimerAPI.Events;

public record StopTimerEvent(CCSPlayerController? player, bool IsSr, bool IsPb, int Tier) : ISharpTimerPlayerEvent
{
    public bool IsSr { get; set; } = IsSr;
    public bool IsPb { get; set; } = IsPb;
    public int Tier { get; set; } = Tier;
};