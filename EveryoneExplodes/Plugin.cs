﻿using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;

namespace EveryoneExplodes
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override string Name { get; } = "Everyone Fucking Explodes";
        public override string Author { get; } = "Benjamin01";
        public override string Prefix { get; } = "Everyone Fucking Explodes";
        public override Version Version { get; } = new Version(1, 1, 3);
        public override Version RequiredExiledVersion { get; } = new Version(8, 8, 1);

        private EventHandlers eventHandlers;
        public override void OnEnabled()
        {
            Instance = this;
            eventHandlers = new EventHandlers(this);
            Player.Dying += eventHandlers.OnPlayerDying;
            Player.Died += eventHandlers.OnPlayerDeath;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            Player.Dying -= eventHandlers.OnPlayerDying;
            Player.Died -= eventHandlers.OnPlayerDeath;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}