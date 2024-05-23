using EveryoneExplodes;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.API.Features.Roles;
using Exiled.Events;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace EveryoneExplodes
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public Vector3 PlayerDeathLocation;

        public void OnPlayerDying(DyingEventArgs ev)
        {
            PlayerDeathLocation = ev.Player.Position;
        }
        public void OnPlayerDeath(DiedEventArgs ev)
        {
            Dictionary<RoleTypeId, float> oddsConfig = Plugin.Instance.Config.ChancesOfExploding;
            Dictionary<RoleTypeId, int> magnitudeConfig = Plugin.Instance.Config.Magnitude;
            Dictionary<RoleTypeId, float> fuseTimeConfig = Plugin.Instance.Config.FuseTime;
            Dictionary<RoleTypeId, float> friendlyFireDamageConfig = Plugin.Instance.Config.FriendlyFireDamage;

            oddsConfig.TryGetValue(ev.TargetOldRole, out float odds);
            magnitudeConfig.TryGetValue(ev.TargetOldRole, out int magnitude);
            fuseTimeConfig.TryGetValue(ev.TargetOldRole, out float fuseTime);
            friendlyFireDamageConfig.TryGetValue(ev.TargetOldRole, out float friendlyFireDamage);

            Log.Debug("EFE: Checking if the event should occur based on odds");

            // Generate a random number between 0.0 and 1.0 (excluding 1.0)
            System.Random random = new System.Random();
            double chance = random.NextDouble();

            // Check if the random number is less than the odds
            if (chance < odds)
            {
                Log.Debug($"EFE: Event triggered with chance {chance * 100}%, odds {odds * 100}%.");

                Log.Debug("EFE: Getting the amount of grenades specified in the magnitude config");
                for (int i = 0; i < magnitude; i++)
                {
                    Log.Debug($"EFE: Spawning {magnitude} Grenades");
                    ExplosiveGrenade grenade = (ExplosiveGrenade)Item.Create(ItemType.GrenadeHE);
                    Log.Debug($"EFE: Setting fuse time of {fuseTime}");
                    grenade.FuseTime = fuseTime;
                    Log.Debug($"EFE: Setting the SCP Damage Multiplier (friendly fire) to {friendlyFireDamage * 3}");
                    grenade.ScpDamageMultiplier = friendlyFireDamage * 3;
                    Log.Debug($"EFE: Spawning grenade at {PlayerDeathLocation}");
                    grenade.SpawnActive(PlayerDeathLocation);
                }
            }
            else
            {
                Log.Debug($"EFE: Event did not trigger. Chance was {chance * 100}%, needed less than {odds * 100}%.");
            }
        }
    }
}
