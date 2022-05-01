using System;

namespace Pocruga.OOPT.CharacterSheet.Race
{
    public class Android : Race
    {
        public override string Title => nameof(Android);

        public override string Description => "Complex technological creations crafted to resemble humans, androids were originally a servitor race, but they have since broken free to form their own society. Unlike ordinary robots or ship AIs, androids do not simply respond according to their programming; rather, they have independent consciousnesses and are animated by souls - a distinction crucial to their generally accepted status as people rather than property.";

        public override int HitPoints => 4;

        public override bool HasAdditionalSelection() => false;

        public override void ApplyTo(PlayerCharacter character)
        {
            // ability adjustments - +2 DEX, +2 INT, -2 CHA
            // Flat Affect - Androids find emotions confusing and keep them bottled up. They take a �2 penalty to Sense Motive checks, but the DCs of Sense Motive checks attempted against them increase by 2.
            // Constructed - For effects targeting creatures by type, androids count as both humanoids and constructs (whichever effect is worse). They receive a +2 racial bonus to saving throws against disease, mind-affecting effects, poison, and sleep, unless those effects specifically target constructs. In addition, androids do not breathe or suffer the normal environmental effects of being in a vacuum.
            // Exceptional Vision - Androids have low-light vision and darkvision. As a result, they can see in dim light as if it were normal light, and they can see with no light source at all to a range of 60 feet in black and white only.
            // Upgrade Slot - Androids have a single armor upgrade slot in their bodies. Regardless of whether androids are wearing physical armor, they can use this slot to install any one armor upgrade that could be installed into light armor.
        }
    }
}
