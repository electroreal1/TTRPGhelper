using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGhelper
{
    public static class EternalDarkness
    {
        public static void ApplyDarknessPathway(Character c)
        {
            if (c.CurrentSequence <= 9)
            {
                c.MaxHP += 3;
                c.MaxSHP += 2;
                c.MaxSpirituality += 3;
                c.AC += 1;
                c.Secrecy += 1;
                c.Speech += 1;

                c.ActiveAbilities.Add(new PathwayAbility("Nocturnality (Passive)", "The deeper into the night, the more powerful a Sleepless will become. Gain +3 dmg, +2 movement, +1 AC, +1 to hitting, +1 Speech at night. Only need to sleep 2-4 hours a day (+1 daily action)."));
                c.ActiveAbilities.Add(new PathwayAbility("Spirituality (Passive)", "Possess high spiritual perception. +1 on using ritualistic magic."));

                c.ActiveAbilities.Add(new PathwayAbility("Divination",
                    "Divine the location of connected items or people you possess an item from (Information checks add +5 DC). Can fail/be interfered with by higher status individuals. Roll: 10+Seq+Secrecy.\n" +
                    "• DC 12: Very rough image of the location.\n" +
                    "• DC 17: General outline of the area.\n" +
                    "• DC 22: The block the target is at.\n" +
                    "• DC 27: The street the target is at.\n" +
                    "• DC 32: The house complex the target is at.\n" +
                    "• Nat 20: Exact location of the target.\n" +
                    "• Nat 1: High spirituality targets notice you. You fall into disarray and are guaranteed to see things you shouldn't."));
            }
            if (c.CurrentSequence <= 8)
            {
                c.MaxHP += 6;
                c.MaxSHP += 3;
                c.MaxSpirituality += 3;
                c.Movement += 1;
                c.AC += 1;
                c.Secrecy += 1;
                c.Speech += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Midnight Poem (Extra)",
                        "Cast spells through the recital of a poem. Targets can resist (+2 AC/DC if ears stuffed/cogitating, degrades by -1 per repeated use).\n" +
                        "• Tranquilize (2 Spirit): Roll 10+Seq+Speech. Reveal abnormal reactions (DCs 10-25).\n" +
                        "• Lullaby (3 Spirit): Roll 10+Seq+Speech. Put multiple people to sleep for 1 turn (if AC hit).\n" +
                        "• Pacify (2 Spirit): Roll 10+Seq+Speech. Turn opponents limp. DCs range from 10 (-1 to rolls) to 25 (-3 to rolls for 2 actions)."));
            }
            if (c.CurrentSequence <= 7)
            {
                c.MaxHP += 10;
                c.MaxSHP += 3;
                c.MaxSpirituality += 2;
                c.Movement += 1;
                c.AC += 1;
                c.Secrecy += 2;
                c.Speech += 2;
                c.ActiveAbilities.Add(new PathwayAbility("Nightmare State (Passive)", "Separate soul while sleeping. See what people are dreaming within a city-wide range."));
                c.ActiveAbilities.Add(new PathwayAbility("Guidance (Extra)", "Roll: 10 + Seq + Speech. Guide targets in dreams to reveal secrets (DCs 10 superficial, Nat 20 lost memories)."));
                c.ActiveAbilities.Add(new PathwayAbility("Dream Pulling (Main)", "Cost: 2 Spirit/turn (+0.5 per extra person, max 10). Roll: 10 + Seq + Speech. Forcefully drag targets into dreams."));
                c.ActiveAbilities.Add(new PathwayAbility("Nightmare Limbs (Extra)", "Cost: 2 Spirit to summon, 1/turn upkeep. Spawns two tentacles (10HP each). Grants +2 to hitting, +4 dmg. Take 5 dmg if a limb breaks."));

                c.AddOrUpgradeAbility("Midnight Poem", "Midnight Poem (Extra)", "Recite Midnight Poems without the use of throat; immune to silencing.");
            }
            if (c.CurrentSequence <= 6)
            {
                c.MaxHP += 11;
                c.MaxSHP += 3;
                c.MaxSpirituality += 3;
                c.Movement += 2;
                c.AC += 1;
                c.Secrecy += 1;
                c.Speech += 2;
                c.ActiveAbilities.Add(new PathwayAbility("Soul Soothing (Extra)", "Cost: 2 Spirit. Roll: 10 + Seq + Speech. Freezes target (-6 movement) or treats emotional states (Requiem). Heal SHP (DCs 20 to 35)."));
                c.ActiveAbilities.Add(new PathwayAbility("Soul Agitating (Extra)", "Cost: 3 Spirit. Roll: 10 + Seq + Speech. Heightens destructive urges and reveals soul problems. Can Provoke or Instigate."));

                c.AddOrUpgradeAbility("High Spirituality", "Spirituality (Passive)", "+1 to divination, +2 to ritualistic magic.");
                c.AddOrUpgradeAbility("Nocturnality", "Nocturnality (Passive)", "Only need 2 hours of rest per day. Gain an additional daily action.");
            }
            if (c.CurrentSequence <= 5)
            {
                c.MaxHP += 8;
                c.MaxSHP += 4;
                c.MaxSpirituality += 2;
                c.AC += 2;
                c.Movement += 1;
                c.Secrecy += 2;
                c.Speech += 1;

                c.ActiveAbilities.Add(new PathwayAbility("Spirit Commanding (Extra)", "Seal up to 4-5 spirits in teeth. Release to multitask. Roll: 10 + Seq + Speech vs Spirit AC + Remaining HP to Seal. Gain +1 extra action solely for commanding spirits."));
            }
            if (c.CurrentSequence <= 4)
            {
                c.MaxHP *= 2;
                c.MaxSHP *= 2;
                c.MaxSpirituality *= 2;
                c.AC += 1;
                c.Movement += 1;
                c.Secrecy += 4;
                c.Speech += 2;
                c.ActiveAbilities.Add(new PathwayAbility("Bloodline Abilities", "Gain specific abilities depending on the True Deity bloodline used for advancement (DM Discretion)."));
                c.ActiveAbilities.Add(new PathwayAbility("Night Domain (Extra)", "Cost: 4 Spirit (3/turn upkeep). Removes 2 negative stacks/turn. User/Spirits gain +3 AC. Spirits gain +4 hit, +6 dmg. Enemies get -2 to rolls and 3 stacks Corrosion."));
                c.ActiveAbilities.Add(new PathwayAbility("Serene Hair Strands (Extra)", "Cost: 4 Spirit. Roll: 10 + Seq + Secrecy. On hit: -10 movement, lose 2 extra actions, -3 ability checks."));
                c.ActiveAbilities.Add(new PathwayAbility("Concealment (Extra)", "Cost: 4 Spirit (3/turn upkeep). Roll: 10 + Seq + Secrecy. Boosts stealth, AC, and causes divinations to fail (DCs 10 to 30)."));
                c.ActiveAbilities.Add(new PathwayAbility("Curse of Misfortune (Extra)", "Cost: 6 Spirit. Roll: 10 + Seq + Secrecy. Cause disadvantaged rolls (DCs 20 to 30)."));

                c.AddOrUpgradeAbility("Nocturnality", "Nocturnality (Passive)", "Enhanced in dark: +6 Dmg, +5 Move, +4 HP Regen/turn, +2 Speech. Weaker in midday sun: -6 Dmg, -3 Move, -2 AC.");
                c.AddOrUpgradeAbility("Spirit Commanding", "Spirit Commanding (Extra)", "Can command 1 spirit per tooth (up to 32). Gain 2 more extra actions solely for commanding spirits.");
            }
        }

        public static void ApplyDeathPathway(Character c)
        {
            if (c.CurrentSequence <= 9)
            {
                c.MaxHP += 6;
                c.MaxSHP += 2;
                c.MaxSpirituality += 2;
                c.Movement += 1;
                c.Autopsy += 1;

                c.ActiveAbilities.Add(new PathwayAbility("Cold/Decay/Corrosion Resistance (Passive)", "Gain +4 damage reduction to cold, decay, and corrosion."));

                c.ActiveAbilities.Add(new PathwayAbility("Knowledge (Undead) (Passive)",
                    "Expert on autopsy and weaknesses of Undead creatures/corpses. Roll: 10+Seq+Autopsy.\n" +
                    "• DC 10: Find out meager reasons of death.\n" +
                    "• DC 15: Find out deeper reasons of death.\n" +
                    "• DC 20: Find out most death reasons."));

                c.ActiveAbilities.Add(new PathwayAbility("Gloomy Presence (Passive)", "Lower body temperature and gloomy presence prevents attacks from Undead creatures and Spirits."));

                c.ActiveAbilities.Add(new PathwayAbility("Spirit Vision", "Directly see spiritual bodies (including evil spirits and restless wraiths) without activating it. See parts of a soul, deduce health/emotions, and determine magical auras."));
            }
            if (c.CurrentSequence <= 8)
            {
                c.MaxHP += 8;
                c.MaxSHP += 3;
                c.MaxSpirituality += 2;
                c.Movement += 3;
                c.AC += 2;
                c.Intimidation += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Spirit Communication (Extra)",
                    "Communicate with nearby Spirits to scout or carry out tasks. Roll: 10+Seq+Intimidation.\n" +
                    "• DC 10: Command lesser spirits.\n" +
                    "• DC 15: Command somewhat stronger spirits.\n" +
                    "• DC 20: Command more mystical spirits.\n" +
                    "• Combat: Command spirits to immobilize (10+Seq+Intimidation to hit). If hit, target loses 1 Extra Action."));

                c.ActiveAbilities.Add(new PathwayAbility("Eye of Death (Extra)", "Cost: 2 Spirit (Start of turn). Eyes turn colourless to quickly determine weaknesses. Gain +3 to hit and +3 dmg towards Undead and Spirit Creatures."));
            }
            if (c.CurrentSequence <= 7)
            {
                c.MaxHP += 10;
                c.MaxSHP += 2;
                c.MaxSpirituality += 2;
                c.Movement += 1;
                c.AC += 1;
                c.Autopsy += 2;
                c.Intimidation += 1;

                c.ActiveAbilities.Add(new PathwayAbility("Spirit Channelling (Ritual)", "Roll: 10+Seq+Intimidation. Perform seances (requires materials like Moon Oil or blood) to command spirits up to Seq 6. Fails if you take >10 damage. Limited to 1 Spirit per seance."));

                c.ActiveAbilities.Add(new PathwayAbility("Knowledge (Mysticism)",
                    "Roll: 10+Seq+Autopsy. Gain info from spirits/living beings (Living target requires extracts and incurs -2 penalty).\n" +
                    "• DC 10: Rough image/location.\n" +
                    "• DC 15: General outline of area.\n" +
                    "• DC 20: Block the target is at.\n" +
                    "• DC 25: Street the target is at.\n" +
                    "• DC 30: House complex target is at.\n" +
                    "• Nat 20: Exact location.\n" +
                    "You also take -4 dmg from beyonder abilities while they are in your mind."));

                c.ActiveAbilities.Add(new PathwayAbility("Zombie Disguise (Extra)", "Cost: 2 Spirit (Start of turn). Disguise as a Zombie. Take -6 dmg from Decay, Cold, Death, and similar auras."));

                c.ActiveAbilities.Add(new PathwayAbility("Danger Intuition (Reactionary)",
                    "Roll: 10+Seq+Autopsy. Sense impending danger before it happens.\n" +
                    "• DC 10: Know 1 Extra Action (+1 AC against it).\n" +
                    "• DC 15: Know both Extra Actions (+1 AC against them).\n" +
                    "• DC 20: Know the Main Action (+1 AC against it).\n" +
                    "• DC 25: Know the Main & 1 Extra Action (+1 AC against them).\n" +
                    "• DC 30: Know Main or Extra Action halfway accurately (+2 AC)."));

                c.AddOrUpgradeAbility("Spirit Communication", "Advanced Spirit Communication (Extra)", "Directly communicate with natural spirits and loitering dead souls around you, acting as informants. Can directly communicate with recently deceased enemies (+2 to check) to get information.");
                c.AddOrUpgradeAbility("Eye of Death", "Advanced Eye of Death (Extra)", "Cost: 2 Spirit (Start of turn). Bonus increases to +5 to hit and +6 to damage against Undead and Spirit Creatures.");
            }
            if (c.CurrentSequence <= 6)
            {
                c.MaxHP += 8;
                c.MaxSHP += 3;
                c.MaxSpirituality += 3;
                c.Movement += 2;
                c.AC += 2;
                c.Autopsy += 2;
                c.Intimidation += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Lethal Strike (Passive)", "Gain +3 base damage."));

                c.ActiveAbilities.Add(new PathwayAbility("Necromancy (Ritual)",
                    "Cost: 4 Spirit. Roll: 10+Seq+Autopsy. Reanimate corpses into skeletons/zombies without will/vitality. Fails if you take >10 damage.\n" +
                    "• DC 10: 25% original stats/HP.\n" +
                    "• DC 15: 40% original stats/HP.\n" +
                    "• DC 20: 60% original stats/HP.\n" +
                    "• DC 25: 80% original stats/HP.\n" +
                    "• DC 30: 100% original stats/HP."));

                c.ActiveAbilities.Add(new PathwayAbility("Spirit World Communication (Extra)",
                    "Cost: 4 Spirit. Roll: 10+Seq+Intimidation. Recruit Spirit messengers for help delivering/receiving messages.\n" +
                    "• DC 20: Convince Seq 8 & below.\n" +
                    "• DC 25: Convince Seq 7 & below.\n" +
                    "• DC 30: Convince Seq 6 & below.\n" +
                    "• DC 35: Convince Seq 5 & below."));

                c.ActiveAbilities.Add(new PathwayAbility("Language of the Dead (Extra)", "Cost: 3 Spirit. Roll: 10+Seq+Intimidation (DC +5 for every sequence higher than you). Speak a mystical language urging a target's Spirit to leave their body. Target is left vulnerable, guaranteeing 2 hits."));
            }
            if (c.CurrentSequence <= 5)
            {
                c.MaxHP += 10;
                c.MaxSHP += 3;
                c.MaxSpirituality += 3;
                c.Movement += 3;
                c.AC += 2;
                c.Autopsy += 2;
                c.Intimidation += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Freezing Immunity (Passive)", "Total immunity to freezing."));

                c.ActiveAbilities.Add(new PathwayAbility("Spiritual Perception (Passive)", "Roll: 10+Seq+Autopsy vs Target Stealth. Acutely sense if an unknown creature is crossing the Spirit World near you."));

                c.ActiveAbilities.Add(new PathwayAbility("Internal Underworld (Passive)", "House numerous souls and natural spirits in a prison within your body. Gain +1 Extra Action solely for commanding spirits for every 2 Spirits housed. Grants unique abilities based on housed spirits. (Prime target for Evil Spirit possession)."));

                c.ActiveAbilities.Add(new PathwayAbility("Door to the Underworld",
                    "Sense/Create gates to the Underworld. Control dead spirits inside (+2 to spirit manipulation checks).\n" +
                    "• Vacuum Pull (Main): d20+Seq+Intimidation vs target Move. Fail = banished to random Spirit World location.\n" +
                    "• Underworld Grasp (Extra): d20+Seq+Intimidation. Bloody arms/tentacles entangle target, reducing Movement by 6.\n" +
                    "• Fog Absorption (Main): d20+Seq+Intimidation to remove airborne poisons/Fog of War (DC10 = equal seq, DC15 = +1 seq, DC20 = +2 seq)."));
            }
            if (c.CurrentSequence <= 4)
            {
                c.MaxHP *= 2;
                c.MaxSHP *= 2;
                c.MaxSpirituality *= 2;
                c.Movement += 1;
                c.AC += 2;
                c.Autopsy += 3;
                c.Intimidation += 3;

                c.ActiveAbilities.Add(new PathwayAbility("Underworld Authority (Passive)", "All checks regarding undead and spirits enjoy a +4 bonus."));

                c.ActiveAbilities.Add(new PathwayAbility("Sealing (Extra)",
                    "Roll: 10+Seq+Autopsy. Form a Seal to reduce negative effects of a Sealed Artifact via the Underworld.\n" +
                    "• DC 20: 50% reduced negatives.\n" +
                    "• DC 25: 75% reduced negatives.\n" +
                    "• DC 30: 90% reduced negatives."));

                c.ActiveAbilities.Add(new PathwayAbility("Spirit World Traversal (Extra)",
                    "Roll: 10+Seq+Intimidation. Traverse the Spirit World for long distances (Cannot Blink short distances).\n" +
                    "• DC 10: 3500 km.\n" +
                    "• DC 15: 4000 km.\n" +
                    "• DC 20: 4500 km.\n" +
                    "• DC 25: 4800 km."));

                c.ActiveAbilities.Add(new PathwayAbility("Rotting Wind (Extra)", "Roll: 10+Seq+Intimidation. Gust of cold wind silently inflicts 10 stacks of corrosion and 10 stacks of freezing per turn."));

                c.ActiveAbilities.Add(new PathwayAbility("Resurrection (Passive)", "Every 60 years or upon death, resurrect with wiped memories and reset madness. Can resurrect 20 times before your soul inevitably gets pulled into the River of Eternal Darkness."));

                c.ActiveAbilities.Add(new PathwayAbility("Spirit Body (Reactionary)", "Exist between a physical body and a Spirit Body. Physical attacks become ineffective."));

                c.ActiveAbilities.Add(new PathwayAbility("Physical Enhancement (Passive)", "Physical attacks are no longer fatal unless body is completely destroyed. Cannot be pushed below 1 HP by physical attacks unless they deal more than half your Max HP."));

                c.AddOrUpgradeAbility("Language of the Dead", "Language of the Dead Spell System", "Evolves into a Spell System related to Death, Spirits, Living Corpses, Withering, and Enslavement (Spells require DM approval).");

                c.AddOrUpgradeAbility("Door to the Underworld", "Advanced Door to the Underworld",
                    "Cost: 4 Spirit/turn. Form a favorable battlefield inflicting attraction, summoning, and ravings.\n" +
                    "• Debuffs enemies in area: -4 Move, -2 AC, 2 Corrosion per turn.\n" +
                    "• Summoning: Roll d100 each turn to summon Undead.\n" +
                    "  [1-25] 3 Seq6 Spirits | [26-50] 2 Seq5 Spirits | [51-75] 3 Seq5 Spirits\n" +
                    "  [76-90] 2 Seq4 Spirits | [91-95] 1 Styx Servant | [96-100] 2 Styx Servants.");
            }
        }

        public static void ApplyTwilightGiantPathway(Character c)
        {
            if (c.CurrentSequence <= 9)
            {
                c.MaxHP += 8;
                c.MaxSHP += 2;
                c.MaxSpirituality += 1;
                c.Movement += 2;
                c.AC += 1;
                c.Melee += 1; 
                c.ToHit += 2;  

                c.ActiveAbilities.Add(new PathwayAbility("Combat Buffs (Passive)", "Gain +3 dmg."));

                c.ActiveAbilities.Add(new PathwayAbility("Combat Proficiency",
                    "Warriors will become proficient in the 2 fields of combat upon entering this Sequence: equipment utilization and martial arts.\n" +
                    "They are proficient over various kinds of weaponry and armor to the point that they can use weapons and armor that most ordinary folk are unable to utilize\n" +
                    "Armors have the melee stat added to hp(the weapons are already being boosted by melee) in their hands\n" +
                    "They have a mastery of various martial arts. With their enhanced physique and affinity towards fighting, there are no fighting styles impossible to master\n" +
                    "They can learn martial arts twice as fast (1.5x the roll)\n" +
                    "They can perform very basic ritualistic magic"));
            }
            if (c.CurrentSequence <= 8)
            {
                c.MaxHP += 10;
                c.MaxSHP += 3;
                c.MaxSpirituality += 1;
                c.Movement += 1;
                c.AC += 1;
                c.Melee += 2;
                c.ToHit += 1;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +2 dmg.");

                c.ActiveAbilities.Add(new PathwayAbility("Supernatural Resistance (Passive)",
                    "Their body's superb physique and defensive capabilities can reduce the negative effects of certain supernatural powers.\n" +
                    "Unlike other Sequence 8's, Supernatural Resistance is their only extraordinary ability.\n" +
                    "Sequence 9-7 Powers get reduced by: Melee x 2\n" +
                    "Sequence 6-5 Powers get reduced by: Melee+3\n" +
                    "They can momentarily touch non-physical (incorporeal) existences with this ability. (Extra)\n" +
                    "They can slightly sense supernatural activities at work if they are attentive.\n" +
                    "10+seq+melee as their discerning check for stealth"));

                c.AddOrUpgradeAbility("Combat Profiency", "Combat Proficiency",
                    "They are gifted with the ability and talent to become experts of combat that specialize in close quarters battles.\n" +
                    "However, just like the Combat Proficiency of a Warrior, a Pugilist requires training time and combat experience to reach the expert level of close combat.\n" +
                    "2x martial arts learning now");
            }
            if (c.CurrentSequence <= 7)
            {
                c.MaxHP += 16;
                c.MaxSHP += 3;
                c.MaxSpirituality += 1;
                c.Movement += 3;
                c.AC += 2;
                c.Melee += 1;
                c.ToHit += 2;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +3 dmg.");

                c.ActiveAbilities.Add(new PathwayAbility("Weapon Mastery",
                    "As long as it can be used as a \"weapon\" in the Weapon Master's hands, it can be used in tandem with their Physical Enhancement to instantly grant them a grandmaster's level of familiarity and effectiveness when using that \"weapon\" in combat.\n" +
                    "This includes but is not limited to their body, Beyonder weapons, any forms of swords, firearms, other types of weaponry, etc, Mystical Items or Sealed Artifacts\n" +
                    "The melee stat now gets added to hit with all weapons, Mystical Items and Sealed artifacts effects will be reduced by the DM.\n" +
                    "They can conduct advanced ritualistic magic and use spirit vision"));
            }
            if (c.CurrentSequence <= 6)
            {
                c.MaxHP += 15;
                c.MaxSHP += 4;
                c.MaxSpirituality += 3;
                c.Movement += 2;
                c.AC += 1;
                c.Melee += 2;
                c.ToHit += 2;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +3 dmg.");

                c.ActiveAbilities.Add(new PathwayAbility("Giant's Physique (Strength of Giants)",
                    "Upon drinking this Sequence 6 potion, a Dawn Paladin will possess the body and strength akin to that of common Giants.\n" +
                    "By now, their bodies are muscular, well attuned to combat and their height is further increased.\n" +
                    "x1.25 taller\n" +
                    "Aside from them becoming taller, Dawn Paladins can further temporarily increase their height. (Extra)\n" +
                    "x1.5 taller for 2 turns resulting in +2 dmg and +5 HP\n" +
                    "Costs 1 Spirituality at the start of one's turn"));

                c.ActiveAbilities.Add(new PathwayAbility("Light of Dawn (Sunrise Gleam) (Extra)",
                    "Centered on oneself, they can bask a radius of up to 40 to 50 meters in the bright Dawn rays that dispel Illusions, Exorcise and even weaken Evil Spirits\n" +
                    "It can dispel powers (negative energies) of Evil, Corruption, and Degeneration, but in the Domain of the Holy and Light, the Light of Dawn is still inferior to a Light Supplicant powers\n" +
                    "A Light of Dawn can erase Shadows and nullify Concealment effects, such as Witches' Invisibility. For Wraiths and Shadow Ascetics, their peculiarities are diminished\n" +
                    "10+seq+melee\n" +
                    "If the Ac is hit normal spirits that are not beyonder forms get immediately exorcised, evil spirits get -25% to their stats"));

                c.ActiveAbilities.Add(new PathwayAbility("Dawn Armor (Extra)",
                    "They can conjure a silver Armor of Dawn around their bodies which would be equivalent to specially forged full-body armor that doesn’t weigh anything or inhibit their motion in any way.\n" +
                    "It can recover from damage, but their stamina will automatically be drained during the process\n" +
                    "A Dawn Paladin's Dawn Armor includes gauntlets, breastplates, and a helmet.\n" +
                    "creates an armor with 20+Melee HP\n" +
                    "Upon it breaking, reduce the armor's HP by 3 and regenerate armor next turn.\n" +
                    "Costs 4 Spirituality to cast and 1 at the start of ones turn as it is upheld."));

                c.ActiveAbilities.Add(new PathwayAbility("Dawn Weaponry (Extra)",
                    "They can use the Dawn to materialize different kinds of weapons, such as a massive two-handed axe, a disposable arm-thick spear, or their strongest weapon the Sword of Dawn.\n" +
                    "Each weapon deals their normal dmg with an added 2d4 and the dmg gets doubled on Evil Spirits or the Corrupted.\n" +
                    "Costs 4 Spirituality to cast and 1 at the start of ones turn as it is upheld."));

                c.ActiveAbilities.Add(new PathwayAbility("Sword of Dawn & Hurricane of Light (Main)",
                    "Sword of Dawn: A Dawn light emitting, two-handed broadsword, greatsword, or dagger that is solid and sharp. Each strike from it is imbued with a Purification effect and it is the medium that allows a Dawn Paladin to use their strongest attack - the Hurricane of Light.\n" +
                    "Hurricane of Light(Main): This is the strongest attack of a Dawn Paladin whose full power is only usable with the Sword of Dawn. They can release rays of light from their Sword of Dawn that quickly transforms into a Dawn Hurricane; it can directly destroy a person's body, eliminate Wraiths, and even heavily wound Evil Spirits. It possesses a unique strength that can more easily destroy creatures of the Evil and Undead Domain\n" +
                    "10+seq+melee\n" +
                    "Auto Hits within 10 Meters\n" +
                    "deals 10d5+melee dmg\n" +
                    "Costs 6 Spirituality.\n" +
                    "This attack is so powerful that some Dawn Paladins have difficulty controlling it to prevent implicating their allies. In addition, a Dawn Paladin would need at least more than 2 minutes of recovery before they can form another Hurricane of Light\n" +
                    "4 turn cooldown\n" +
                    "Evil creatures like Devils or Zombies would be subjected to the effects of Purification and the damage of a Fragmentary Blade. The combination of these aspects causes their Hurricane of Light to become excellent at purging Evil.\n" +
                    "1.5x dmg\n" +
                    "Purification weakens defense and inflicts harm on the Evil creature's spirit and flesh, while the Fragmentary Blade utilizes Purification to weaken defense and cut flesh. The more wounds and the deeper they were, the better the Purification effect.\n" +
                    "Hurricane of Light would be even more effective on Spirits (such as a Wraiths) leaving the target close to death\n" +
                    "2x dmg"));
            }
            if (c.CurrentSequence <= 5)
            {
                c.MaxHP += 15;
                c.MaxSHP += 3;
                c.MaxSpirituality += 3;
                c.Movement += 2;
                c.AC += 2;
                c.Melee += 3;
                c.ToHit += 2;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +4 dmg, and +5 dmg reduction.");

                c.ActiveAbilities.Add(new PathwayAbility("Protection (Extra)",
                    "For defense in an area. They can enter a defensive state by stabbing their Sword of Dawn into the ground, releasing Dawn-like light that blooms into illusory walls. This creates an invisible barrier that can defend not only themselves but also their comrades within a limited range.\n" +
                    "Protection can isolate certain supernatural powers, preventing them from getting inside the barrier. This state leaves them passive and unable to attack, when they attack, their corresponding defense will decrease significantly, but it will still be stronger than full-body armor.\n" +
                    "Few can break through their defenses below that of the High-Sequences, regardless of the types of damage they can inflict and their corresponding effects.\n" +
                    "Both Protection and Dawn Armor can be used simultaneously.\n" +
                    "Reapers are one of the few non High-Sequence Beyonders that can penetrate a Guardian's defenses (Protection).\n" +
                    "While this is active all allies and they will get a 60+Melee HP shield but the TG can not move or attack unless he weakens the shield to half HP\n" +
                    "The outside barrier always has 70HP only the person barrier may vary"));

                c.AddOrUpgradeAbility("Supernatural Resistance", "Supernatural Resistance (Passive)",
                    "They are unable to be confused or misdirected by Illusions.\n" +
                    "Illusions are ineffective unless the person completely outscales them in status");

                c.ActiveAbilities.Add(new PathwayAbility("Spirituality (Passive)",
                    "Their Spirituality enhances to a degree to fortify their Cogitation.\n" +
                    "-2 SHP dmg taken"));
            }
            if (c.CurrentSequence <= 4)
            {
                c.MaxHP *= 3;
                c.MaxSHP *= 2;
                c.MaxSpirituality *= 2;
                c.Movement += 3;
                c.AC += 2;
                c.Melee += 4;
                c.ToHit += 4;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +5 dmg.");

                c.ActiveAbilities.Add(new PathwayAbility("Eye of Demon Hunting (Passive)",
                    "Demon Hunters can make complex dark green symbols appear in their eyes, allowing them to identify targets' characteristics, weaknesses, and current status.\n" +
                    "They become sensitive to any traces of Evil, Degeneration, and Corruption. They can also rely on their sixth sense, Spiritual Intuition, and life experiences to judge the situation.\n" +
                    "Veteran Demon Hunters can use the Eye of Demon Hunting to judge whether a target is lying.\n" +
                    "This isn't just a Beyonder power enhancing their perception, but a generalized term to describe a Demon Hunter's terrifying prowess in observation and judgement.\n" +
                    "This makes Demon Hunters good at discovering the weaknesses of different enemies.\n" +
                    "10+seq+melee (Extra) Needs to be rolled before hit\n" +
                    "dc25: They discover weaknesses → next attack deals 1.2x dmg\n" +
                    "dc30: They discover a greater weakness → next attack deals 1.5x dmg\n" +
                    "dc35: They discover a very important weakness → 1.75x dmg for the next attack"));

                c.ActiveAbilities.Add(new PathwayAbility("Alchemy",
                    "Every Demon Hunter is an expert at making supernatural medicines. They can enter a unique Cogitation state to create concoctions corresponding to their enemies' weakness.\n" +
                    "Demon Hunters innately possess knowledge on the efficient utilization of different monster parts and herbs. By utilizing different combinations, they can create powerful ointments, holy paste, mystic smears, glyphs, and herbal potions or drugs with many effects.\n" +
                    "They can rely on these mixtures to obtain Beyonder effects of different kinds that can be used as a coating on weapons. This allows Demon Hunters to take advantage of their target's weakness with pinpoint accuracy and achieve effective targeted suppression.\n" +
                    "Some effects include Lightning Strike, Freeze, Purification, Burning, Decay, and Exorcism.\n" +
                    "Requires one Extra to apply the coating.\n" +
                    "10+seq+melee Requires one Main and the needed ingredients to create the coatings while in combat.\n" +
                    "Lightning Strike: dc20: 5d5 dmg + 10 charge\n" +
                    "Freeze: dc25: 5d5 dmg + 10 freezing\n" +
                    "Purification: dc30: 5d5 dmg, 3x against spirits as well as +20 burn\n" +
                    "Burning: dc35: 5d5 dmg +30 burning stacks\n" +
                    "Decay: dc35: 15 corrosion stacks and -5 to movement and hitting\n" +
                    "Exorcism: dc35: One shots spirits below seq4 and deals 50% max HP dmg against those at seq4"));

                c.ActiveAbilities.Add(new PathwayAbility("Mind Concealment (Passive)",
                    "Demon Hunters are able to Conceal their desires and intentions, preventing others from reading their actions and guiding their thoughts down an ordered path.\n" +
                    "This effectively makes them the nemesis of Devils, Desire Apostles and Demons; as well as helps interfere with any form of Divination and Prophecy.\n" +
                    "divination and prophecy will require +15+Melee dc against them\n" +
                    "desire apostles can’t foresee their danger"));

                c.ActiveAbilities.Add(new PathwayAbility("Tracking",
                    "They are good at tracking targets across various landscapes.\n" +
                    "10+seq+melee+2 for tracking (Extra)\n" +
                    "dc20: They find a trail of their target in 10km radius\n" +
                    "dc25: they find a very accurate trail in 100km radius\n" +
                    "dc30: They find a perfect trail in 300km radius"));

                c.AddOrUpgradeAbility("Spirituality", "Spirituality",
                    "A Demon Hunter's Spirituality will be enhanced significantly.\n" +
                    "They will possess a strong Spiritual Intuition\n" +
                    "10+seq+melee (Extra)\n" +
                    "dc10: Know the extra action the enemy will take roughly (+2AC against that)\n" +
                    "dc15: Know both the extra actions the enemy will take roughly (+3 AC against them)\n" +
                    "dc20: Know the main action the enemy will take roughly (+4 AC against that)\n" +
                    "dc25: Know the main and one extra action roughly (+5AC)\n" +
                    "dc30: Know the main action or an extra action halfway accurately (+6AC)");
            }
        }
    }
}