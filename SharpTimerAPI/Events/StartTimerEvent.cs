using CounterStrikeSharp.API.Core;

namespace SharpTimerAPI.Events;

public record StartTimerEvent(CCSPlayerController? player) : ISharpTimerPlayerEvent;