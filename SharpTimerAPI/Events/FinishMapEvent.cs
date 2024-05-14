using CounterStrikeSharp.API.Core;

namespace SharpTimerAPI.Events;

public record FinishMapPlayerEvents(CCSPlayerController? player) : ISharpTimerPlayerEvent;