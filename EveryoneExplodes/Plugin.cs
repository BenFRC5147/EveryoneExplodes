using Exiled.API.Features;
using Exiled.Events.Handlers;
using System;
using Player = Exiled.Events.Handlers.Player;
using Scp079 = Exiled.Events.Handlers.Scp079;

namespace EveryoneExplodes
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override string Name { get; } = "Everyone Fucking Explodes";
        public override string Author { get; } = "Benjamin01";
        public override string Prefix { get; } = "Everyone Fucking Explodes";
        public override Version Version { get; } = new Version(1, 1, 5);
        public override Version RequiredExiledVersion { get; } = new Version(8, 8, 1);
        public Exiled.API.Features.Camera lastCamera { get; set; }

        private EventHandlers eventHandlers;
        public override void OnEnabled()
        {
            Instance = this;
            eventHandlers = new EventHandlers(this);
            Player.Dying += eventHandlers.OnPlayerDying;
            Player.Died += eventHandlers.OnPlayerDeath;
            Scp079.ChangingCamera += eventHandlers.LastCamera;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            Player.Dying -= eventHandlers.OnPlayerDying;
            Player.Died -= eventHandlers.OnPlayerDeath;
            Scp079.ChangingCamera -= eventHandlers.LastCamera;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}
