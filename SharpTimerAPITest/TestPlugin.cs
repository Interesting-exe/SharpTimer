using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Core.Capabilities;
using SharpTimerAPI;
using SharpTimerAPI.Events;

namespace SharpTimerAPITest
{
    [MinimumApiVersion(228)]
    public class SharpTimerTest : BasePlugin
    {
        public override string ModuleName => "Test plugin";
        public override string ModuleVersion => "1.0.0";
        public override string ModuleAuthor => "Interesting";

        public override void Load(bool hotReload)
        {
            var sender = new PluginCapability<ISharpTimerEventSender>("sharptimer:event_sender").Get();
            if(sender == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Test plugin] Failed to get ISharpTimerEventSender");
            }

            AddTimer(0.5f, () => sender.STEventSender += OnTimer);
            
        }
        
        public void OnTimer(object? _, ISharpTimerPlayerEvent @event) 
        {
            var manager = new PluginCapability<ISharpTimerManager>("sharptimer:manager").Get();
            if(manager == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Test plugin] Failed to get ISharpTimerManager");
                return;
            }
            if (@event is StartTimerEvent)
            {
                Console.WriteLine("Timer started");
            }
            else if (@event is StopTimerEvent)
            {
                Console.WriteLine("Timer stopped");
                manager.RestartTimer(player: @event.Player!);
            }
            else
            {
                Console.WriteLine("wtf?");
            }
        }
        
        public override void Unload(bool hotReload)
        {
            var sender = new PluginCapability<ISharpTimerEventSender>("sharptimer:event_sender").Get();
            if(sender == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[Test plugin] Failed to get ISharpTimerEventSender");
            }
            
            sender.STEventSender -= OnTimer;
            Console.WriteLine("Unloaded");
        }
    }
}

