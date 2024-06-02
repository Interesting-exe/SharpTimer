using CounterStrikeSharp.API.Core;

namespace SharpTimerAPI.Events;

public record StopTimerEvent(CCSPlayerController? Player, bool IsSr, bool IsPb, int Tier) : ISharpTimerPlayerEvent;