using Exiled.API.Interfaces;
using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace EveryoneExplodes
{
    public class Config : IConfig
    {
        [Description("Is the plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Enable/Disable debug printouts")]
        public bool Debug { get; set; } = false;

        [Description("Fuse time for the grenade before it explodes after the player dies")]
        public Dictionary<RoleTypeId, float> FuseTime { get; set; } = new Dictionary<RoleTypeId, float>
        {
            { RoleTypeId.Scp173, 0.5f },
            { RoleTypeId.ClassD, 0.5f },
            { RoleTypeId.Scp106, 0.5f },
            { RoleTypeId.NtfSpecialist, 0.5f },
            { RoleTypeId.Scp049, 0.5f },
            { RoleTypeId.Scientist, 0.5f },
            { RoleTypeId.Scp079, 0.5f },
            { RoleTypeId.ChaosConscript, 0.5f },
            { RoleTypeId.Scp096, 0.5f },
            { RoleTypeId.Scp0492, 0.5f },
            { RoleTypeId.NtfSergeant, 0.5f },
            { RoleTypeId.NtfCaptain, 0.5f },
            { RoleTypeId.NtfPrivate, 0.5f },
            { RoleTypeId.Tutorial, 0.5f },
            { RoleTypeId.FacilityGuard, 0.5f },
            { RoleTypeId.Scp939, 0.5f },
            { RoleTypeId.CustomRole, 0.5f },
            { RoleTypeId.ChaosRifleman, 0.5f },
            { RoleTypeId.ChaosMarauder, 0.5f },
            { RoleTypeId.ChaosRepressor, 0.5f }
        };
        [Description("Magnitude of explosions (number of explosions that will occur. The higher the number the lower the frame rate.)")]
        public Dictionary<RoleTypeId, int> Magnitude { get; set; } = new Dictionary<RoleTypeId, int>
        {
            { RoleTypeId.Scp173, 1 },
            { RoleTypeId.ClassD, 1 },
            { RoleTypeId.Scp106, 1 },
            { RoleTypeId.NtfSpecialist, 1 },
            { RoleTypeId.Scp049, 1 },
            { RoleTypeId.Scientist, 1 },
            { RoleTypeId.Scp079, 1 },
            { RoleTypeId.ChaosConscript, 1 },
            { RoleTypeId.Scp096, 1 },
            { RoleTypeId.Scp0492, 1 },
            { RoleTypeId.NtfSergeant, 1 },
            { RoleTypeId.NtfCaptain, 1 },
            { RoleTypeId.NtfPrivate, 1 },
            { RoleTypeId.Tutorial, 1 },
            { RoleTypeId.FacilityGuard, 1 },
            { RoleTypeId.Scp939, 1 },
            { RoleTypeId.CustomRole, 1 },
            { RoleTypeId.ChaosRifleman, 1 },
            { RoleTypeId.ChaosMarauder, 1 },
            { RoleTypeId.ChaosRepressor, 1 }
        };
        [Description("Friendly Fire Damage done to the teammates of the exploded")]
        public Dictionary<RoleTypeId, float> FriendlyFireDamage { get; set; } = new Dictionary<RoleTypeId, float>
        {
            { RoleTypeId.Scp173, 0.5f },
            { RoleTypeId.ClassD, 0.5f },
            { RoleTypeId.Scp106, 0.5f },
            { RoleTypeId.NtfSpecialist, 0.5f },
            { RoleTypeId.Scp049, 0.5f },
            { RoleTypeId.Scientist, 0.5f },
            { RoleTypeId.Scp079, 0.5f },
            { RoleTypeId.ChaosConscript, 0.5f },
            { RoleTypeId.Scp096, 0.5f },
            { RoleTypeId.Scp0492, 0.5f },
            { RoleTypeId.NtfSergeant, 0.5f },
            { RoleTypeId.NtfCaptain, 0.5f },
            { RoleTypeId.NtfPrivate, 0.5f },
            { RoleTypeId.Tutorial, 0.5f },
            { RoleTypeId.FacilityGuard, 0.5f },
            { RoleTypeId.Scp939, 0.5f },
            { RoleTypeId.CustomRole, 0.5f },
            { RoleTypeId.ChaosRifleman, 0.5f },
            { RoleTypeId.ChaosMarauder, 0.5f },
            { RoleTypeId.ChaosRepressor, 0.5f }
        };
        [Description("The odds that a given role will explode, 0 being off, 1 being 100%")]
        public Dictionary<RoleTypeId, float> ChancesOfExploding { get; set; } = new Dictionary<RoleTypeId, float>
        {
            { RoleTypeId.Scp173, 0f },
            { RoleTypeId.ClassD, 0f },
            { RoleTypeId.Scp106, 0f },
            { RoleTypeId.NtfSpecialist, 0f },
            { RoleTypeId.Scp049, 0f },
            { RoleTypeId.Scientist, 0f },
            { RoleTypeId.Scp079, 0f },
            { RoleTypeId.ChaosConscript, 0f },
            { RoleTypeId.Scp096, 0f },
            { RoleTypeId.Scp0492, 0f },
            { RoleTypeId.NtfSergeant, 0f },
            { RoleTypeId.NtfCaptain, 0f },
            { RoleTypeId.NtfPrivate, 0f },
            { RoleTypeId.Tutorial, 0f },
            { RoleTypeId.FacilityGuard, 0f },
            { RoleTypeId.Scp939, 0f },
            { RoleTypeId.CustomRole, 0f },
            { RoleTypeId.ChaosRifleman, 0f },
            { RoleTypeId.ChaosMarauder, 0f },
            { RoleTypeId.ChaosRepressor, 0f }
        };
    }
}
