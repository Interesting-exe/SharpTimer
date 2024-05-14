using CounterStrikeSharp.API.Core;

namespace SharpTimerAPI.Events;

public record StopTimerEvent(CCSPlayerController? player) : ISharpTimerPlayerEvent;