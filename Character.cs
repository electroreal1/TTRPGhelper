using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TTRPGhelper
{
    public class Character : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string name = "New Character";
        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(); }
        }

        private string selectedPathway = "None-Beyonder";
        public string SelectedPathway
        {
            get => selectedPathway;
            set { selectedPathway = value; OnPropertyChanged(); }
        }

        private string imagePath = "";
        public string ImagePath
        {
            get => imagePath;
            set { imagePath = value; OnPropertyChanged(); }
        }

        private int currentSequence = 9;
        public int CurrentSequence
        {
            get => currentSequence;
            set
            {
                currentSequence = value;
                OnPropertyChanged();
                ApplyPathwayStats();
            }
        }

        private bool applyOnTop = false;
        public bool ApplyOnTop
        {
            get { return applyOnTop; }
            set { applyOnTop = value; OnPropertyChanged(); }
        }

        private string notes = "";
        public string Notes
        {
            get => notes;
            set { notes = value; OnPropertyChanged(); }
        }

        private string backstory = "";
        public string Backstory
        {
            get => backstory;
            set { backstory = value; OnPropertyChanged(); }
        }

        private string personality = "";
        public string Personality
        {
            get => personality;
            set { personality = value; OnPropertyChanged(); }
        }

        private int maxhp = 10;
        public int MaxHP
        {
            get => maxhp;
            set { maxhp = value; OnPropertyChanged(); }
        }

        private int currenthp = 10;
        public int CurrentHP
        {
            get => currenthp;
            set { currenthp = value; OnPropertyChanged(); }
        }

        private int maxshp = 4;
        public int MaxSHP
        {
            get => maxshp;
            set { maxshp = value; OnPropertyChanged(); }
        }

        private int currentshp = 4;
        public int CurrentSHP
        {
            get => currentshp;
            set { currentshp = value; OnPropertyChanged(); }
        }

        private int ac = 10;
        public int AC
        {
            get => ac;
            set { ac = value; OnPropertyChanged(); }
        }

        private int maxspirituality = 0;
        public int MaxSpirituality
        {
            get => maxspirituality;
            set { maxspirituality = value; OnPropertyChanged(); }
        }

        private int currentspirituality = 0;
        public int CurrentSpirituality
        {
            get => currentspirituality;
            set { currentspirituality = value; OnPropertyChanged(); }
        }

        private int movement = 0;
        public int Movement
        {
            get => movement;
            set { movement = value; OnPropertyChanged(); }
        }

        private int constitutionXP;
        public int ConstitutionXP
        {
            get => constitutionXP;
            set { constitutionXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(ConLevel)); }
        }
        public int ConLevel => GetLevel(ConstitutionXP);

        private int exerciseXP;
        public int ExerciseXP
        {
            get => exerciseXP;
            set { exerciseXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(ExerciseLevel)); }
        }
        public int ExerciseLevel => GetLevel(ExerciseXP);

        private int strengthXP;
        public int StrengthXP
        {
            get => strengthXP;
            set { strengthXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(StrLevel)); }
        }
        public int StrLevel => GetLevel(StrengthXP);

        private int dexterityXP;
        public int DexterityXP
        {
            get => dexterityXP;
            set { dexterityXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(DexLevel)); }
        }
        public int DexLevel => GetLevel(DexterityXP);

        private int movementXP;
        public int MovementXP
        {
            get => movementXP;
            set { movementXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(MoveLevel)); }
        }
        public int MoveLevel => GetLevel(MovementXP);

        private int secrecy = 0;
        public int Secrecy
        {
            get => secrecy;
            set { secrecy = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalSecrecy)); }
        }
        private int secrecyXP;
        public int SecrecyXP
        {
            get => secrecyXP;
            set { secrecyXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(SecrecyLevel)); OnPropertyChanged(nameof(TotalSecrecy)); }
        }
        public int SecrecyLevel => GetLevel(SecrecyXP);
        public int TotalSecrecy => Secrecy + SecrecyLevel;

        private int speech = 0;
        public int Speech
        {
            get => speech;
            set { speech = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalSpeech)); }
        }
        private int speechXP;
        public int SpeechXP
        {
            get => speechXP;
            set { speechXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(SpeechLevel)); OnPropertyChanged(nameof(TotalSpeech)); }
        }
        public int SpeechLevel => GetLevel(SpeechXP);
        public int TotalSpeech => Speech + SpeechLevel;

        private int autopsy = 0;
        public int Autopsy
        {
            get => autopsy;
            set { autopsy = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalAutopsy)); }
        }
        private int autopsyXP;
        public int AutopsyXP
        {
            get => autopsyXP;
            set { autopsyXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(AutopsyLevel)); OnPropertyChanged(nameof(TotalAutopsy)); }
        }
        public int AutopsyLevel => GetLevel(AutopsyXP);
        public int TotalAutopsy => Autopsy + AutopsyLevel;

        private int intimidation = 0;
        public int Intimidation
        {
            get => intimidation;
            set { intimidation = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalIntimidation)); }
        }
        private int intimidationXP;
        public int IntimidationXP
        {
            get => intimidationXP;
            set { intimidationXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(IntimidationLevel)); OnPropertyChanged(nameof(TotalIntimidation)); }
        }
        public int IntimidationLevel => GetLevel(IntimidationXP);
        public int TotalIntimidation => Intimidation + IntimidationLevel;

        private List<PathwayAbility> activeAbilities = new List<PathwayAbility>();
        public List<PathwayAbility> ActiveAbilities
        {
            get => activeAbilities;
            set { activeAbilities = value; OnPropertyChanged(); }
        }

        private int GetLevel(int xp)
        {
            if (xp >= 4000) return 4;
            if (xp >= 800) return 3;
            if (xp >= 350) return 2;
            if (xp >= 200) return 1;
            return 0;
        }

        public void ApplyPathwayStats()
        {
            if (!ApplyOnTop)
            {
                MaxHP = 10;
                MaxSHP = 4;
                AC = 10;
                MaxSpirituality = 0;
                Movement = 0;
                Secrecy = 0;
                Speech = 0;
                Autopsy = 0;
                Intimidation = 0;
            }

            ActiveAbilities.Clear();

            if (SelectedPathway == "Darkness")
            {
                ApplyDarknessPathway();
            }
            else if (SelectedPathway == "Death")
            {
                ApplyDeathPathway();
            }

            CurrentHP = MaxHP;
            CurrentSHP = MaxSHP;
            CurrentSpirituality = MaxSpirituality;

            OnPropertyChanged(nameof(ActiveAbilities));
        }

        private void AddOrUpgradeAbility(string keyword, string newName, string descriptionAddition)
        {
            var existingAbility = activeAbilities.Find(a => a.Name.Contains(keyword));

            if (existingAbility != null)
            {
                existingAbility.Name = newName;
                existingAbility.Description += $"\n\n[Upgraded]: {descriptionAddition}";
            }
            else
            {
                activeAbilities.Add(new PathwayAbility(newName, descriptionAddition));
            }
        }

        private void ApplyDarknessPathway()
        {
            if (CurrentSequence <= 9)
            {
                MaxHP += 3;
                MaxSHP += 2;
                MaxSpirituality += 3;
                AC += 1;
                Secrecy += 1;
                Speech += 1;

                ActiveAbilities.Add(new PathwayAbility("Nocturnality (Passive)", "The deeper into the night, the more powerful a Sleepless will become. Gain +3 dmg, +2 movement, +1 AC, +1 to hitting, +1 Speech at night. Only need to sleep 2-4 hours a day (+1 daily action)."));
                ActiveAbilities.Add(new PathwayAbility("High Spirituality (Passive)", "Possess high spiritual perception. +1 on using ritualistic magic."));
                ActiveAbilities.Add(new PathwayAbility("Divination", "Divine the location of things/people with a connection. Roll: 10 + Seq + Secrecy. DCs range from 12 (rough image) to 32 (exact house). Nat 1 results in target noticing you."));
            }
            if (CurrentSequence <= 8)
            {
                MaxHP += 6;
                MaxSHP += 3;
                MaxSpirituality += 3;
                Movement += 1;
                AC += 1;
                Secrecy += 1;
                Speech += 2;

                ActiveAbilities.Add(new PathwayAbility("Midnight Poem (Extra)",
                        "Cast spells through the recital of a poem. Targets can resist (+2 AC/DC if ears stuffed/cogitating, degrades by -1 per repeated use).\n" +
                        "• Tranquilize (2 Spirit): Roll 10+Seq+Speech. Reveal abnormal reactions (DCs 10-25).\n" +
                        "• Lullaby (3 Spirit): Roll 10+Seq+Speech. Put multiple people to sleep for 1 turn (if AC hit).\n" +
                        "• Pacify (2 Spirit): Roll 10+Seq+Speech. Turn opponents limp. DCs range from 10 (-1 to rolls) to 25 (-3 to rolls for 2 actions)."));
            }
            if (CurrentSequence <= 7)
            {
                MaxHP += 10;
                MaxSHP += 3;
                MaxSpirituality += 2;
                Movement += 1;
                AC += 1;
                Secrecy += 2;
                Speech += 2;
                ActiveAbilities.Add(new PathwayAbility("Nightmare State (Passive)", "Separate soul while sleeping. See what people are dreaming within a city-wide range."));
                ActiveAbilities.Add(new PathwayAbility("Guidance (Extra)", "Roll: 10 + Seq + Speech. Guide targets in dreams to reveal secrets (DCs 10 superficial, Nat 20 lost memories)."));
                ActiveAbilities.Add(new PathwayAbility("Dream Pulling (Main)", "Cost: 2 Spirit/turn (+0.5 per extra person, max 10). Roll: 10 + Seq + Speech. Forcefully drag targets into dreams."));
                ActiveAbilities.Add(new PathwayAbility("Nightmare Limbs (Extra)", "Cost: 2 Spirit to summon, 1/turn upkeep. Spawns two tentacles (10HP each). Grants +2 to hitting, +4 dmg. Take 5 dmg if a limb breaks."));

                AddOrUpgradeAbility("Midnight Poem", "Silent Midnight Poem (Extra)", "Recite Midnight Poems without the use of throat; immune to silencing.");
            }
            if (CurrentSequence <= 6)
            {
                MaxHP += 11;
                MaxSHP += 3;
                MaxSpirituality += 3;
                Movement += 2;
                AC += 1;
                Secrecy += 1;
                Speech += 2;
                ActiveAbilities.Add(new PathwayAbility("Soul Soothing (Extra)", "Cost: 2 Spirit. Roll: 10 + Seq + Speech. Freezes target (-6 movement) or treats emotional states (Requiem). Heal SHP (DCs 20 to 35)."));
                ActiveAbilities.Add(new PathwayAbility("Soul Agitating (Extra)", "Cost: 3 Spirit. Roll: 10 + Seq + Speech. Heightens destructive urges and reveals soul problems. Can Provoke or Instigate."));

                AddOrUpgradeAbility("High Spirituality", "Spirituality (Passive)", "+1 to divination, +2 to ritualistic magic.");
                AddOrUpgradeAbility("Nocturnality", "Nocturnality (Passive)", "Only need 2 hours of rest per day. Gain an additional daily action.");
            }
            if (CurrentSequence <= 5)
            {
                MaxHP += 8;
                MaxSHP += 4;
                MaxSpirituality += 2;
                AC += 2;
                Movement += 1;
                Secrecy += 2;
                Speech += 1;

                ActiveAbilities.Add(new PathwayAbility("Spirit Commanding (Extra)", "Seal up to 4-5 spirits in teeth. Release to multitask. Roll: 10 + Seq + Speech vs Spirit AC + Remaining HP to Seal. Gain +1 extra action solely for commanding spirits."));
            }
            if (CurrentSequence <= 4)
            {
                MaxHP *= 2;
                MaxSHP *= 2;
                MaxSpirituality *= 2;
                AC += 1;
                Movement += 1;
                Secrecy += 4;
                Speech += 2;
                ActiveAbilities.Add(new PathwayAbility("Bloodline Abilities", "Gain specific abilities depending on the True Deity bloodline used for advancement (DM Discretion)."));
                ActiveAbilities.Add(new PathwayAbility("Night Domain (Extra)", "Cost: 4 Spirit (3/turn upkeep). Removes 2 negative stacks/turn. User/Spirits gain +3 AC. Spirits gain +4 hit, +6 dmg. Enemies get -2 to rolls and 3 stacks Corrosion."));
                ActiveAbilities.Add(new PathwayAbility("Serene Hair Strands (Extra)", "Cost: 4 Spirit. Roll: 10 + Seq + Secrecy. On hit: -10 movement, lose 2 extra actions, -3 ability checks."));
                ActiveAbilities.Add(new PathwayAbility("Concealment (Extra)", "Cost: 4 Spirit (3/turn upkeep). Roll: 10 + Seq + Secrecy. Boosts stealth, AC, and causes divinations to fail (DCs 10 to 30)."));
                ActiveAbilities.Add(new PathwayAbility("Curse of Misfortune (Extra)", "Cost: 6 Spirit. Roll: 10 + Seq + Secrecy. Cause disadvantaged rolls (DCs 20 to 30)."));

                AddOrUpgradeAbility("Nocturnality", "Nocturnality (Passive)", "Enhanced in dark: +6 Dmg, +5 Move, +4 HP Regen/turn, +2 Speech. Weaker in midday sun: -6 Dmg, -3 Move, -2 AC.");
                AddOrUpgradeAbility("Spirit Commanding", "Spirit Commanding (Extra)", "Can command 1 spirit per tooth (up to 32). Gain 2 more extra actions solely for commanding spirits.");
            }
        }

        private void ApplyDeathPathway()
        {
            if (CurrentSequence <= 9)
            {
                MaxHP += 6;
                MaxSHP += 2;
                MaxSpirituality += 2;
                Movement += 1;
                Autopsy += 1;

                ActiveAbilities.Add(new PathwayAbility("Cold/Decay/Corrosion Resistance (Passive)", "Gain +4 damage reduction to cold, decay, and corrosion."));

                ActiveAbilities.Add(new PathwayAbility("Knowledge (Undead) (Passive)",
                    "Expert on autopsy and weaknesses of Undead creatures/corpses. Roll: 10+Seq+Autopsy.\n" +
                    "• DC 10: Find out meager reasons of death.\n" +
                    "• DC 15: Find out deeper reasons of death.\n" +
                    "• DC 20: Find out most death reasons."));

                ActiveAbilities.Add(new PathwayAbility("Gloomy Presence (Passive)", "Lower body temperature and gloomy presence prevents attacks from Undead creatures and Spirits."));

                ActiveAbilities.Add(new PathwayAbility("Spirit Vision", "Directly see spiritual bodies (including evil spirits and restless wraiths) without activating it. See parts of a soul, deduce health/emotions, and determine magical auras."));
            }
            if (CurrentSequence <= 8)
            {
                MaxHP += 8;
                MaxSHP += 3;
                MaxSpirituality += 2;
                Movement += 3;
                AC += 2;
                Intimidation += 2;

                ActiveAbilities.Add(new PathwayAbility("Spirit Communication (Extra)",
                    "Communicate with nearby Spirits to scout or carry out tasks. Roll: 10+Seq+Intimidation.\n" +
                    "• DC 10: Command lesser spirits.\n" +
                    "• DC 15: Command somewhat stronger spirits.\n" +
                    "• DC 20: Command more mystical spirits.\n" +
                    "• Combat: Command spirits to immobilize (10+Seq+Intimidation to hit). If hit, target loses 1 Extra Action."));

                ActiveAbilities.Add(new PathwayAbility("Eye of Death (Extra)", "Cost: 2 Spirit (Start of turn). Eyes turn colourless to quickly determine weaknesses. Gain +3 to hit and +3 dmg towards Undead and Spirit Creatures."));
            }
            if (CurrentSequence <= 7)
            {
                MaxHP += 10;
                MaxSHP += 2;
                MaxSpirituality += 2;
                Movement += 1;
                AC += 1;
                Autopsy += 2;
                Intimidation += 1;

                ActiveAbilities.Add(new PathwayAbility("Spirit Channelling (Ritual)", "Roll: 10+Seq+Intimidation. Perform seances (requires materials like Moon Oil or blood) to command spirits up to Seq 6. Fails if you take >10 damage. Limited to 1 Spirit per seance."));

                ActiveAbilities.Add(new PathwayAbility("Knowledge (Mysticism)",
                    "Roll: 10+Seq+Autopsy. Gain info from spirits/living beings (Living target requires extracts and incurs -2 penalty).\n" +
                    "• DC 10: Rough image/location.\n" +
                    "• DC 15: General outline of area.\n" +
                    "• DC 20: Block the target is at.\n" +
                    "• DC 25: Street the target is at.\n" +
                    "• DC 30: House complex target is at.\n" +
                    "• Nat 20: Exact location.\n" +
                    "You also take -4 dmg from beyonder abilities while they are in your mind."));

                ActiveAbilities.Add(new PathwayAbility("Zombie Disguise (Extra)", "Cost: 2 Spirit (Start of turn). Disguise as a Zombie. Take -6 dmg from Decay, Cold, Death, and similar auras."));

                ActiveAbilities.Add(new PathwayAbility("Danger Intuition (Reactionary)",
                    "Roll: 10+Seq+Autopsy. Sense impending danger before it happens.\n" +
                    "• DC 10: Know 1 Extra Action (+1 AC against it).\n" +
                    "• DC 15: Know both Extra Actions (+1 AC against them).\n" +
                    "• DC 20: Know the Main Action (+1 AC against it).\n" +
                    "• DC 25: Know the Main & 1 Extra Action (+1 AC against them).\n" +
                    "• DC 30: Know Main or Extra Action halfway accurately (+2 AC)."));

                AddOrUpgradeAbility("Spirit Communication", "Advanced Spirit Communication (Extra)", "Directly communicate with natural spirits and loitering dead souls around you, acting as informants. Can directly communicate with recently deceased enemies (+2 to check) to get information.");
                AddOrUpgradeAbility("Eye of Death", "Advanced Eye of Death (Extra)", "Cost: 2 Spirit (Start of turn). Bonus increases to +5 to hit and +6 to damage against Undead and Spirit Creatures.");
            }
            if (CurrentSequence <= 6)
            {
                MaxHP += 8;
                MaxSHP += 3;
                MaxSpirituality += 3;
                Movement += 2;
                AC += 2;
                Autopsy += 2;
                Intimidation += 2;

                ActiveAbilities.Add(new PathwayAbility("Lethal Strike (Passive)", "Gain +3 base damage."));

                ActiveAbilities.Add(new PathwayAbility("Necromancy (Ritual)",
                    "Cost: 4 Spirit. Roll: 10+Seq+Autopsy. Reanimate corpses into skeletons/zombies without will/vitality. Fails if you take >10 damage.\n" +
                    "• DC 10: 25% original stats/HP.\n" +
                    "• DC 15: 40% original stats/HP.\n" +
                    "• DC 20: 60% original stats/HP.\n" +
                    "• DC 25: 80% original stats/HP.\n" +
                    "• DC 30: 100% original stats/HP."));

                ActiveAbilities.Add(new PathwayAbility("Spirit World Communication (Extra)",
                    "Cost: 4 Spirit. Roll: 10+Seq+Intimidation. Recruit Spirit messengers for help delivering/receiving messages.\n" +
                    "• DC 20: Convince Seq 8 & below.\n" +
                    "• DC 25: Convince Seq 7 & below.\n" +
                    "• DC 30: Convince Seq 6 & below.\n" +
                    "• DC 35: Convince Seq 5 & below."));

                ActiveAbilities.Add(new PathwayAbility("Language of the Dead (Extra)", "Cost: 3 Spirit. Roll: 10+Seq+Intimidation (DC +5 for every sequence higher than you). Speak a mystical language urging a target's Spirit to leave their body. Target is left vulnerable, guaranteeing 2 hits."));
            }
            if (CurrentSequence <= 5)
            {
                MaxHP += 10;
                MaxSHP += 3;
                MaxSpirituality += 3;
                Movement += 3;
                AC += 2;
                Autopsy += 2;
                Intimidation += 2;

                ActiveAbilities.Add(new PathwayAbility("Freezing Immunity (Passive)", "Total immunity to freezing."));

                ActiveAbilities.Add(new PathwayAbility("Spiritual Perception (Passive)", "Roll: 10+Seq+Autopsy vs Target Stealth. Acutely sense if an unknown creature is crossing the Spirit World near you."));

                ActiveAbilities.Add(new PathwayAbility("Internal Underworld (Passive)", "House numerous souls and natural spirits in a prison within your body. Gain +1 Extra Action solely for commanding spirits for every 2 Spirits housed. Grants unique abilities based on housed spirits. (Prime target for Evil Spirit possession)."));

                ActiveAbilities.Add(new PathwayAbility("Door to the Underworld",
                    "Sense/Create gates to the Underworld. Control dead spirits inside (+2 to spirit manipulation checks).\n" +
                    "• Vacuum Pull (Main): d20+Seq+Intimidation vs target Move. Fail = banished to random Spirit World location.\n" +
                    "• Underworld Grasp (Extra): d20+Seq+Intimidation. Bloody arms/tentacles entangle target, reducing Movement by 6.\n" +
                    "• Fog Absorption (Main): d20+Seq+Intimidation to remove airborne poisons/Fog of War (DC10 = equal seq, DC15 = +1 seq, DC20 = +2 seq)."));
            }
            if (CurrentSequence <= 4)
            {
                MaxHP *= 2;
                MaxSHP *= 2;
                MaxSpirituality *= 2;
                Movement += 1;
                AC += 2;
                Autopsy += 3;
                Intimidation += 3;

                ActiveAbilities.Add(new PathwayAbility("Underworld Authority (Passive)", "All checks regarding undead and spirits enjoy a +4 bonus."));

                ActiveAbilities.Add(new PathwayAbility("Sealing (Extra)",
                    "Roll: 10+Seq+Autopsy. Form a Seal to reduce negative effects of a Sealed Artifact via the Underworld.\n" +
                    "• DC 20: 50% reduced negatives.\n" +
                    "• DC 25: 75% reduced negatives.\n" +
                    "• DC 30: 90% reduced negatives."));

                ActiveAbilities.Add(new PathwayAbility("Spirit World Traversal (Extra)",
                    "Roll: 10+Seq+Intimidation. Traverse the Spirit World for long distances (Cannot Blink short distances).\n" +
                    "• DC 10: 3500 km.\n" +
                    "• DC 15: 4000 km.\n" +
                    "• DC 20: 4500 km.\n" +
                    "• DC 25: 4800 km."));

                ActiveAbilities.Add(new PathwayAbility("Rotting Wind (Extra)", "Roll: 10+Seq+Intimidation. Gust of cold wind silently inflicts 10 stacks of corrosion and 10 stacks of freezing per turn."));

                ActiveAbilities.Add(new PathwayAbility("Resurrection (Passive)", "Every 60 years or upon death, resurrect with wiped memories and reset madness. Can resurrect 20 times before your soul inevitably gets pulled into the River of Eternal Darkness."));

                ActiveAbilities.Add(new PathwayAbility("Spirit Body (Reactionary)", "Exist between a physical body and a Spirit Body. Physical attacks become ineffective."));

                ActiveAbilities.Add(new PathwayAbility("Physical Enhancement (Passive)", "Physical attacks are no longer fatal unless body is completely destroyed. Cannot be pushed below 1 HP by physical attacks unless they deal more than half your Max HP."));

                AddOrUpgradeAbility("Language of the Dead", "Language of the Dead Spell System", "Evolves into a Spell System related to Death, Spirits, Living Corpses, Withering, and Enslavement (Spells require DM approval).");

                AddOrUpgradeAbility("Door to the Underworld", "Advanced Door to the Underworld",
                    "Cost: 4 Spirit/turn. Form a favorable battlefield inflicting attraction, summoning, and ravings.\n" +
                    "• Debuffs enemies in area: -4 Move, -2 AC, 2 Corrosion per turn.\n" +
                    "• Summoning: Roll d100 each turn to summon Undead.\n" +
                    "  [1-25] 3 Seq6 Spirits | [26-50] 2 Seq5 Spirits | [51-75] 3 Seq5 Spirits\n" +
                    "  [76-90] 2 Seq4 Spirits | [91-95] 1 Styx Servant | [96-100] 2 Styx Servants.");
            }
        }

        public class PathwayAbility
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public PathwayAbility(string name, string description)
            {
                Name = name;
                Description = description;
            }
        }
    }
}