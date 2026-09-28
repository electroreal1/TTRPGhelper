using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace TTRPGhelper
{
    public class StatProxy : INotifyPropertyChanged
    {
        public string Name { get; set; }
        private Func<int> getXp;
        private Action<int> setXp;    
        private Func<int> getMod;
        private Action<int> setMod;  
        private Func<int> getTotal;

        public StatProxy(string name, Func<int> getXp, Action<int> setXp, Func<int> getMod, Action<int> setMod, Func<int> getTotal)
        {
            Name = name;
            this.getXp = getXp;
            this.setXp = setXp;
            this.getMod = getMod;
            this.setMod = setMod;
            this.getTotal = getTotal; 
        }

        public int XP
        {
            get => getXp();
            set { setXp(value); OnPropertyChanged(); OnPropertyChanged(nameof(Total)); }
        }

        public int Mod
        {
            get => getMod();
            set { setMod(value); OnPropertyChanged(); OnPropertyChanged(nameof(Total)); }
        }

        public int Total => getTotal();

        public void Update()
        {
            OnPropertyChanged(nameof(XP));
            OnPropertyChanged(nameof(Mod));
            OnPropertyChanged(nameof(Total));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class CustomStat : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(); }
        }

        private int xp;
        public int XP
        {
            get => xp;
            set { xp = value; OnPropertyChanged(); OnPropertyChanged(nameof(Level)); OnPropertyChanged(nameof(Total)); }
        }

        private int mod;
        public int Mod
        {
            get => mod;
            set { mod = value; OnPropertyChanged(); OnPropertyChanged(nameof(Total)); }
        }

        public int Level
        {
            get
            {
                if (XP >= 5350) return 4;
                if (XP >= 1350) return 3;
                if (XP >= 550) return 2;
                if (XP >= 200) return 1;
                return 0;
            }
        }

        public int Total
        {
            get
            {
                int bonus = 0;
                if (Level >= 4) bonus = 5;
                else if (Level == 3) bonus = 3;
                else if (Level == 2) bonus = 2;
                else if (Level == 1) bonus = 1;
                return Mod + bonus;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class Character : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ObservableCollection<StatProxy> PathwayStatList { get; }
        public ObservableCollection<StatProxy> CoreStatList { get; }
        public ObservableCollection<CustomStat> CustomSkills { get; set; }

        public Character()
        {
            CustomSkills = new ObservableCollection<CustomStat>();

            PathwayStatList = new ObservableCollection<StatProxy>
            {
                new StatProxy("Melee XP:", () => MeleeXP, v => MeleeXP = v, () => MeleeMod, v => MeleeMod = v, () => TotalMelee),
                new StatProxy("Secrecy XP:", () => SecrecyXP, v => SecrecyXP = v, () => SecrecyMod, v => SecrecyMod = v, () => TotalSecrecy),
                new StatProxy("Speech XP:", () => SpeechXP, v => SpeechXP = v, () => SpeechMod, v => SpeechMod = v, () => TotalSpeech),
                new StatProxy("Autopsy XP:", () => AutopsyXP, v => AutopsyXP = v, () => AutopsyMod, v => AutopsyMod = v, () => TotalAutopsy),
                new StatProxy("Intimidate XP:", () => IntimidationXP, v => IntimidationXP = v, () => IntimidationMod, v => IntimidationMod = v, () => TotalIntimidation),
                new StatProxy("Pharmacy XP:", () => PharmacyXP, v => PharmacyXP = v, () => PharmacyMod, v => PharmacyMod = v, () => TotalPharmacy),
                new StatProxy("Beast Taming XP:", () => BeastTamingXP, v => BeastTamingXP = v, () => BeastTamingMod, v => BeastTamingMod = v, () => TotalBeastTaming),
                new StatProxy("Law XP:", () => LawXP, v => LawXP = v, () => LawMod, v => LawMod = v, () => TotalLaw),
                new StatProxy("Persuasion XP:", () => PersuasionXP, v => PersuasionXP = v, () => PersuasionMod, v => PersuasionMod = v, () => TotalPersuasion),
                new StatProxy("Botany XP:", () => BotanyXP, v => BotanyXP = v, () => BotanyMod, v => BotanyMod = v, () => TotalBotany),
                new StatProxy("Medicine XP:", () => MedicineXP, v => MedicineXP = v, () => MedicineMod, v => MedicineMod = v, () => TotalMedicine),
                new StatProxy("Performance XP:", () => PerformanceXP, v => PerformanceXP = v, () => PerformanceMod, v => PerformanceMod = v, () => TotalPerformance),
                new StatProxy("Astrology XP:", () => AstrologyXP, v => AstrologyXP = v, () => AstrologyMod, v => AstrologyMod = v, () => TotalAstrology),
                new StatProxy("Stealth XP:", () => StealthXP, v => StealthXP = v, () => StealthMod, v => StealthMod = v, () => TotalStealth),
                new StatProxy("Sleight Of Hand XP:", () => SleightOfHandXP, v => SleightOfHandXP = v, () => SleightOfHandMod, v => SleightOfHandMod = v, () => TotalSleightOfHand),
                new StatProxy("Acrobatics XP:", () => AcrobaticsXP, v => AcrobaticsXP = v, () => AcrobaticsMod, v => AcrobaticsMod = v, () => TotalAcrobatics),
                new StatProxy("Deception XP:", () => DeceptionXP, v => DeceptionXP = v, () => DeceptionMod, v => DeceptionMod = v, () => TotalDeception),
                new StatProxy("Disguise XP:", () => DisguiseXP, v => DisguiseXP = v, () => DisguiseMod, v => DisguiseMod = v, () => TotalDisguise)
            };

            CoreStatList = new ObservableCollection<StatProxy>
            {
                new StatProxy("Strength XP:", () => StrengthXP, v => StrengthXP = v, () => StrMod, v => StrMod = v, () => TotalStrength),
                new StatProxy("Dexterity XP:", () => DexterityXP, v => DexterityXP = v, () => DexMod, v => DexMod = v, () => TotalDexterity),
                new StatProxy("Constit. XP:", () => ConstitutionXP, v => ConstitutionXP = v, () => ConMod, v => ConMod = v, () => TotalConstitution),
                new StatProxy("Mind XP:", () => MindXP, v => MindXP = v, () => MindMod, v => MindMod = v, () => TotalMind),
                new StatProxy("Exercise XP:", () => ExerciseXP, v => ExerciseXP = v, () => ExerciseMod, v => ExerciseMod = v, () => TotalExercise),
                new StatProxy("Move XP:", () => MovementXP, v => MovementXP = v, () => MoveMod, v => MoveMod = v, () => TotalMovementXP),
                new StatProxy("Foresight XP:", () => ForesightXP, v => ForesightXP = v, () => ForesightMod, v => ForesightMod = v, () => TotalForesight),
                new StatProxy("Martial Arts XP:", () => MartialArtsXP, v => MartialArtsXP = v, () => MartialArtsMod, v => MartialArtsMod = v, () => TotalMartialArts)
            };

            this.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName != null && (e.PropertyName.StartsWith("Total") || e.PropertyName == "ApplyOnTop"))
                {
                    foreach (var proxy in PathwayStatList)
                    {
                        proxy.Update();
                    }
                    foreach (var proxy in CoreStatList)
                    {
                        proxy.Update();
                    }
                    RecalculateCoreStats();
                }
            };
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

        private string honorificName = "";
        public string HonorificName
        {
            get => honorificName;
            set { honorificName = value; OnPropertyChanged(); }
        }

        private string tamedAnimals = "";
        public string TamedAnimals
        {
            get => tamedAnimals;
            set { tamedAnimals = value; OnPropertyChanged(); }
        }

        private string notes = "";
        public string Notes
        {
            get => notes;
            set { notes = value; OnPropertyChanged(); }
        }

        private string inventory = "";
        public string Inventory
        {
            get => inventory;
            set { inventory = value; OnPropertyChanged(); }
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
        private int baseHp = 10;
        public int MaxHP
        {
            get => baseHp + GetConstitutionHpBonus() + GetExerciseHpBonus();
            set { baseHp = value; OnPropertyChanged(); OnPropertyChanged(nameof(CurrentHP)); }
        }

        private int currenthp = 10;
        public int CurrentHP
        {
            get => Math.Min(currenthp, MaxHP);
            set { currenthp = value; OnPropertyChanged(); }
        }

        private int baseShp = 4;
        public int MaxSHP
        {
            get => baseShp + GetMindShpBonus();
            set { baseShp = value; OnPropertyChanged(); OnPropertyChanged(nameof(CurrentSHP)); }
        }

        private int currentshp = 4;
        public int CurrentSHP
        {
            get => Math.Min(currentshp, MaxSHP);
            set { currentshp = value; OnPropertyChanged(); }
        }

        private int baseAc = 10;
        public int AC
        {
            get => baseAc + GetDexterityAcBonus();
            set { baseAc = value; OnPropertyChanged(); }
        }

        private int maxspirituality = 0;
        public int MaxSpirituality
        {
            get => maxspirituality;
            set
            {
                maxspirituality = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMaxSpirituality));
            }
        }

        private int currentspirituality = 0;
        public int CurrentSpirituality
        {
            get => currentspirituality;
            set
            {
                currentspirituality = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayCurrentSpirituality));
            }
        }

        public int DisplayMaxSpirituality => MaxSpirituality * 3;
        public int DisplayCurrentSpirituality => CurrentSpirituality * 3;

        private int baseMovement = 0;
        public int Movement
        {
            get => baseMovement + GetMovementBonus() + GetExerciseMovementBonus();
            set { baseMovement = value; OnPropertyChanged(); }
        }

        private int healing = 0;
        public int Healing
        {
            get => healing;
            set { healing = value; OnPropertyChanged(); }
        }

        private int instantActions = 0;
        public int InstantActions
        {
            get => instantActions;
            set { instantActions = value; OnPropertyChanged(); }
        }

        private int baseReactionary = 1;
        public int ReactionaryActions
        {
            get => baseReactionary + GetForesightReactionaryBonus();
            set { baseReactionary = value; OnPropertyChanged(); }
        }

        private int baseToHit = 0;
        public int ToHit
        {
            get => baseToHit + GetMartialArtsHitBonus();
            set { baseToHit = value; OnPropertyChanged(); }
        }

        public int DamageBonus => GetStrengthDamageBonus() + GetExerciseDamageBonus();

        private int constitutionXP;
        public int ConstitutionXP
        {
            get => constitutionXP;
            set { constitutionXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(ConLevel)); OnPropertyChanged(nameof(TotalConstitution)); }
        }
        private int conMod;
        public int ConMod
        {
            get => conMod;
            set { conMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalConstitution)); }
        }
        public int ConLevel => GetLevel(ConstitutionXP);
        public int TotalConstitution => ConLevel + ConMod;

        private int exerciseXP;
        public int ExerciseXP
        {
            get => exerciseXP;
            set { exerciseXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(ExerciseLevel)); OnPropertyChanged(nameof(TotalExercise)); }
        }
        private int exerciseMod;
        public int ExerciseMod
        {
            get => exerciseMod;
            set { exerciseMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalExercise)); }
        }
        public int ExerciseLevel => GetLevel(ExerciseXP);
        public int TotalExercise => ExerciseLevel + ExerciseMod;

        private int strengthXP;
        public int StrengthXP
        {
            get => strengthXP;
            set { strengthXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(StrLevel)); OnPropertyChanged(nameof(TotalStrength)); }
        }
        private int strMod;
        public int StrMod
        {
            get => strMod;
            set { strMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalStrength)); }
        }
        public int StrLevel => GetLevel(StrengthXP);
        public int TotalStrength => StrLevel + StrMod;

        private int dexterityXP;
        public int DexterityXP
        {
            get => dexterityXP;
            set { dexterityXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(DexLevel)); OnPropertyChanged(nameof(TotalDexterity)); }
        }
        private int dexMod;
        public int DexMod
        {
            get => dexMod;
            set { dexMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalDexterity)); }
        }
        public int DexLevel => GetLevel(DexterityXP);
        public int TotalDexterity => DexLevel + DexMod;

        private int mindXP;
        public int MindXP
        {
            get => mindXP;
            set { mindXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(MindLevel)); OnPropertyChanged(nameof(TotalMind)); }
        }
        private int mindMod;
        public int MindMod
        {
            get => mindMod;
            set { mindMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalMind)); }
        }
        public int MindLevel => GetLevel(MindXP);
        public int TotalMind => MindLevel + MindMod;

        private int movementXP;
        public int MovementXP
        {
            get => movementXP;
            set { movementXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(MoveLevel)); OnPropertyChanged(nameof(TotalMovementXP)); }
        }
        private int moveMod;
        public int MoveMod
        {
            get => moveMod;
            set { moveMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalMovementXP)); }
        }
        public int MoveLevel => GetLevel(MovementXP);
        public int TotalMovementXP => MoveLevel + MoveMod;

        private int foresightXP;
        public int ForesightXP
        {
            get => foresightXP;
            set { foresightXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(ForesightLevel)); OnPropertyChanged(nameof(TotalForesight)); }
        }
        private int foresightMod;
        public int ForesightMod
        {
            get => foresightMod;
            set { foresightMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalForesight)); }
        }
        public int ForesightLevel => GetLevel(ForesightXP);
        public int TotalForesight => ForesightLevel + ForesightMod;

        private int martialArtsXP;
        public int MartialArtsXP
        {
            get => martialArtsXP;
            set { martialArtsXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(MartialArtsLevel)); OnPropertyChanged(nameof(TotalMartialArts)); }
        }
        private int martialArtsMod;
        public int MartialArtsMod
        {
            get => martialArtsMod;
            set { martialArtsMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalMartialArts)); }
        }
        public int MartialArtsLevel => GetLevel(MartialArtsXP);
        public int TotalMartialArts => MartialArtsLevel + MartialArtsMod;

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
        private int secrecyMod;
        public int SecrecyMod
        {
            get => secrecyMod;
            set { secrecyMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalSecrecy)); }
        }
        public int SecrecyLevel => GetLevel(SecrecyXP);
        public int TotalSecrecy => Secrecy + GetSkillBonus(SecrecyLevel) + SecrecyMod;

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
        private int speechMod;
        public int SpeechMod
        {
            get => speechMod;
            set { speechMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalSpeech)); }
        }
        public int SpeechLevel => GetLevel(SpeechXP);
        public int TotalSpeech => Speech + GetSkillBonus(SpeechLevel) + SpeechMod;

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
        private int autopsyMod;
        public int AutopsyMod
        {
            get => autopsyMod;
            set { autopsyMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalAutopsy)); }
        }
        public int AutopsyLevel => GetLevel(AutopsyXP);
        public int TotalAutopsy => Autopsy + GetSkillBonus(AutopsyLevel) + AutopsyMod;

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
        private int intimidationMod;
        public int IntimidationMod
        {
            get => intimidationMod;
            set { intimidationMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalIntimidation)); }
        }
        public int IntimidationLevel => GetLevel(IntimidationXP);
        public int TotalIntimidation => Intimidation + GetSkillBonus(IntimidationLevel) + IntimidationMod;

        private int melee = 0;
        public int Melee
        {
            get => melee;
            set { melee = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalMelee)); }
        }
        private int meleeXP;
        public int MeleeXP
        {
            get => meleeXP;
            set { meleeXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(MeleeLevel)); OnPropertyChanged(nameof(TotalMelee)); }
        }
        private int meleeMod;
        public int MeleeMod
        {
            get => meleeMod;
            set { meleeMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalMelee)); }
        }
        public int MeleeLevel => GetLevel(MeleeXP);
        public int TotalMelee => Melee + GetSkillBonus(MeleeLevel) + MeleeMod;

        private int pharmacyStat = 0;
        public int PharmacyStat
        {
            get => pharmacyStat;
            set { pharmacyStat = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalPharmacy)); }
        }
        private int pharmacyXP;
        public int PharmacyXP
        {
            get => pharmacyXP;
            set { pharmacyXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(PharmacyLevel)); OnPropertyChanged(nameof(TotalPharmacy)); }
        }
        private int pharmacyMod;
        public int PharmacyMod
        {
            get => pharmacyMod;
            set { pharmacyMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalPharmacy)); }
        }
        public int PharmacyLevel => GetLevel(PharmacyXP);
        public int TotalPharmacy => PharmacyStat + GetSkillBonus(PharmacyLevel) + PharmacyMod;

        private int beastTaming = 0;
        public int BeastTaming
        {
            get => beastTaming;
            set { beastTaming = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalBeastTaming)); }
        }
        private int beastTamingXP;
        public int BeastTamingXP
        {
            get => beastTamingXP;
            set { beastTamingXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(BeastTamingLevel)); OnPropertyChanged(nameof(TotalBeastTaming)); }
        }
        private int beastTamingMod;
        public int BeastTamingMod
        {
            get => beastTamingMod;
            set { beastTamingMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalBeastTaming)); }
        }
        public int BeastTamingLevel => GetLevel(BeastTamingXP);
        public int TotalBeastTaming => BeastTaming + GetSkillBonus(BeastTamingLevel) + BeastTamingMod;

        private int law = 0;
        public int Law
        {
            get => law;
            set { law = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalLaw)); }
        }
        private int lawXP;
        public int LawXP
        {
            get => lawXP;
            set { lawXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(LawLevel)); OnPropertyChanged(nameof(TotalLaw)); }
        }
        private int lawMod;
        public int LawMod
        {
            get => lawMod;
            set { lawMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalLaw)); }
        }
        public int LawLevel => GetLevel(LawXP);
        public int TotalLaw => Law + GetSkillBonus(LawLevel) + LawMod;

        private int persuasion = 0;
        public int Persuasion
        {
            get => persuasion;
            set { persuasion = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalPersuasion)); }
        }
        private int persuasionXP;
        public int PersuasionXP
        {
            get => persuasionXP;
            set { persuasionXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(PersuasionLevel)); OnPropertyChanged(nameof(TotalPersuasion)); }
        }
        private int persuasionMod;
        public int PersuasionMod
        {
            get => persuasionMod;
            set { persuasionMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalPersuasion)); }
        }
        public int PersuasionLevel => GetLevel(PersuasionXP);
        public int TotalPersuasion => Persuasion + GetSkillBonus(PersuasionLevel) + PersuasionMod;

        private int botany = 0;
        public int Botany
        {
            get => botany;
            set { botany = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalBotany)); }
        }
        private int botanyXP;
        public int BotanyXP
        {
            get => botanyXP;
            set { botanyXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(BotanyLevel)); OnPropertyChanged(nameof(TotalBotany)); }
        }
        private int botanyMod;
        public int BotanyMod
        {
            get => botanyMod;
            set { botanyMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalBotany)); }
        }
        public int BotanyLevel => GetLevel(BotanyXP);
        public int TotalBotany => Botany + GetSkillBonus(BotanyLevel) + BotanyMod;

        private int medicine = 0;
        public int Medicine
        {
            get => medicine;
            set { medicine = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalMedicine)); }
        }
        private int medicineXP;
        public int MedicineXP
        {
            get => medicineXP;
            set { medicineXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(MedicineLevel)); OnPropertyChanged(nameof(TotalMedicine)); }
        }
        private int medicineMod;
        public int MedicineMod
        {
            get => medicineMod;
            set { medicineMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalMedicine)); }
        }
        public int MedicineLevel => GetLevel(MedicineXP);
        public int TotalMedicine => Medicine + GetSkillBonus(MedicineLevel) + MedicineMod;

        private int performance = 0;
        public int Performance
        {
            get => performance;
            set { performance = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalPerformance)); }
        }
        private int performanceXP;
        public int PerformanceXP
        {
            get => performanceXP;
            set { performanceXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(PerformanceLevel)); OnPropertyChanged(nameof(TotalPerformance)); }
        }
        private int performanceMod;
        public int PerformanceMod
        {
            get => performanceMod;
            set { performanceMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalPerformance)); }
        }
        public int PerformanceLevel => GetLevel(PerformanceXP);
        public int TotalPerformance => Performance + GetSkillBonus(PerformanceLevel) + PerformanceMod;

        private int astrology = 0;
        public int Astrology
        {
            get => astrology;
            set { astrology = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalAstrology)); }
        }
        private int astrologyXP;
        public int AstrologyXP
        {
            get => astrologyXP;
            set { astrologyXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(AstrologyLevel)); OnPropertyChanged(nameof(TotalAstrology)); }
        }
        private int astrologyMod;
        public int AstrologyMod
        {
            get => astrologyMod;
            set { astrologyMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalAstrology)); }
        }
        public int AstrologyLevel => GetLevel(AstrologyXP);
        public int TotalAstrology => Astrology + GetSkillBonus(AstrologyLevel) + AstrologyMod;

        private int stealth = 0;
        public int Stealth
        {
            get => stealth;
            set { stealth = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalStealth)); }
        }
        private int stealthXP;
        public int StealthXP
        {
            get => stealthXP;
            set { stealthXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(StealthLevel)); OnPropertyChanged(nameof(TotalStealth)); }
        }
        private int stealthMod;
        public int StealthMod
        {
            get => stealthMod;
            set { stealthMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalStealth)); }
        }
        public int StealthLevel => GetLevel(StealthXP);
        public int TotalStealth => Stealth + GetSkillBonus(StealthLevel) + StealthMod;

        private int sleightOfHand = 0;
        public int SleightOfHand
        {
            get => sleightOfHand;
            set { sleightOfHand = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalSleightOfHand)); }
        }
        private int sleightOfHandXP;
        public int SleightOfHandXP
        {
            get => sleightOfHandXP;
            set { sleightOfHandXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(SleightOfHandLevel)); OnPropertyChanged(nameof(TotalSleightOfHand)); }
        }
        private int sleightOfHandMod;
        public int SleightOfHandMod
        {
            get => sleightOfHandMod;
            set { sleightOfHandMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalSleightOfHand)); }
        }
        public int SleightOfHandLevel => GetLevel(SleightOfHandXP);
        public int TotalSleightOfHand => SleightOfHand + GetSkillBonus(SleightOfHandLevel) + SleightOfHandMod;

        private int acrobatics = 0;
        public int Acrobatics
        {
            get => acrobatics;
            set { acrobatics = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalAcrobatics)); }
        }
        private int acrobaticsXP;
        public int AcrobaticsXP
        {
            get => acrobaticsXP;
            set { acrobaticsXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(AcrobaticsLevel)); OnPropertyChanged(nameof(TotalAcrobatics)); }
        }
        private int acrobaticsMod;
        public int AcrobaticsMod
        {
            get => acrobaticsMod;
            set { acrobaticsMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalAcrobatics)); }
        }
        public int AcrobaticsLevel => GetLevel(AcrobaticsXP);
        public int TotalAcrobatics => Acrobatics + GetSkillBonus(AcrobaticsLevel) + AcrobaticsMod;

        private int deception = 0;
        public int Deception
        {
            get => deception;
            set { deception = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalDeception)); }
        }
        private int deceptionXP;
        public int DeceptionXP
        {
            get => deceptionXP;
            set { deceptionXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(DeceptionLevel)); OnPropertyChanged(nameof(TotalDeception)); }
        }
        private int deceptionMod;
        public int DeceptionMod
        {
            get => deceptionMod;
            set { deceptionMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalDeception)); }
        }
        public int DeceptionLevel => GetLevel(DeceptionXP);
        public int TotalDeception => Deception + GetSkillBonus(DeceptionLevel) + DeceptionMod;

        private int disguise = 0;
        public int Disguise
        {
            get => disguise;
            set { disguise = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalDisguise)); }
        }
        private int disguiseXP;
        public int DisguiseXP
        {
            get => disguiseXP;
            set { disguiseXP = value; OnPropertyChanged(); OnPropertyChanged(nameof(DisguiseLevel)); OnPropertyChanged(nameof(TotalDisguise)); }
        }
        private int disguiseMod;
        public int DisguiseMod
        {
            get => disguiseMod;
            set { disguiseMod = value; OnPropertyChanged(); OnPropertyChanged(nameof(TotalDisguise)); }
        }
        public int DisguiseLevel => GetLevel(DisguiseXP);
        public int TotalDisguise => Disguise + GetSkillBonus(DisguiseLevel) + DisguiseMod;

        private ObservableCollection<PathwayAbility> activeAbilities = new ObservableCollection<PathwayAbility>();
        public ObservableCollection<PathwayAbility> ActiveAbilities
        {
            get => activeAbilities;
            set { activeAbilities = value; OnPropertyChanged(); }
        }

        private int GetLevel(int xp)
        {
            if (xp >= 5350) return 4;
            if (xp >= 1350) return 3;
            if (xp >= 550) return 2;
            if (xp >= 200) return 1;
            return 0;
        }

        public int GetSkillBonus(int lvl)
        {
            if (lvl >= 4) return 5;
            if (lvl == 3) return 3;
            if (lvl == 2) return 2;
            if (lvl == 1) return 1;
            return 0;
        }

        // --- MATH FUNCTIONS FOR CORE STAT BONUSES ---

        private int GetConstitutionHpBonus()
        {
            int lvl = TotalConstitution;
            if (lvl >= 4) return 12;
            if (lvl == 3) return 8;
            if (lvl == 2) return 5;
            if (lvl == 1) return 2;
            return 0;
        }

        private int GetExerciseHpBonus()
        {
            int lvl = TotalExercise;
            if (lvl >= 4) return 5;
            if (lvl == 3) return 5;
            if (lvl == 2) return 3;
            if (lvl == 1) return 1;
            return 0;
        }

        private int GetMindShpBonus()
        {
            int lvl = TotalMind;
            if (lvl >= 4) return 14;
            if (lvl == 3) return 9;
            if (lvl == 2) return 5;
            if (lvl == 1) return 2;
            return 0;
        }

        private int GetDexterityAcBonus()
        {
            int lvl = TotalDexterity;
            if (lvl >= 4) return 6;
            if (lvl == 3) return 4;
            if (lvl == 2) return 2;
            if (lvl == 1) return 1;
            return 0;
        }

        private int GetMovementBonus()
        {
            int lvl = TotalMovementXP;
            if (lvl >= 4) return 8;
            if (lvl == 3) return 4;
            if (lvl == 2) return 2;
            if (lvl == 1) return 1;
            return 0;
        }

        private int GetExerciseMovementBonus()
        {
            int lvl = TotalExercise;
            if (lvl >= 3) return 1;
            return 0;
        }

        private int GetStrengthDamageBonus()
        {
            int lvl = TotalStrength;
            if (lvl >= 4) return 11;
            if (lvl == 3) return 8;
            if (lvl == 2) return 5;
            if (lvl == 1) return 2;
            return 0;
        }

        private int GetExerciseDamageBonus()
        {
            int lvl = TotalExercise;
            if (lvl >= 4) return 4;
            if (lvl == 3) return 4;
            if (lvl == 2) return 3;
            if (lvl == 1) return 1;
            return 0;
        }

        private int GetMartialArtsHitBonus()
        {
            int lvl = TotalMartialArts;
            if (lvl >= 4) return 5;
            if (lvl == 3) return 3;
            if (lvl == 2) return 2;
            if (lvl == 1) return 1;
            return 0;
        }

        private int GetForesightReactionaryBonus()
        {
            int lvl = TotalForesight;
            return lvl / 4;
        }

        public void RecalculateCoreStats()
        {
            OnPropertyChanged(nameof(MaxHP));
            OnPropertyChanged(nameof(MaxSHP));
            OnPropertyChanged(nameof(AC));
            OnPropertyChanged(nameof(Movement));
            OnPropertyChanged(nameof(ToHit));
            OnPropertyChanged(nameof(DamageBonus));
            OnPropertyChanged(nameof(ReactionaryActions));
        }

        public void ApplyPathwayStats()
        {
            if (!ApplyOnTop)
            {
                baseHp = 10;
                baseShp = 4;
                baseAc = 10;
                MaxSpirituality = 0;
                baseMovement = 0;
                Healing = 0;
                InstantActions = 0;
                baseReactionary = 1;
                baseToHit = 0;
                Secrecy = 0;
                Speech = 0;
                Autopsy = 0;
                Intimidation = 0;
                Melee = 0;
                PharmacyStat = 0;
                BeastTaming = 0;
                Law = 0;
                Persuasion = 0;
                Botany = 0;
                Medicine = 0;
                Performance = 0;
                Astrology = 0;
                Stealth = 0;
                SleightOfHand = 0;
                Acrobatics = 0;
                Deception = 0;
                Disguise = 0;
            }

            ActiveAbilities.Clear();

            switch (SelectedPathway)
            {
                case "Darkness":
                    EternalDarkness.ApplyDarknessPathway(this);
                    break;
                case "Death":
                    EternalDarkness.ApplyDeathPathway(this);
                    break;
                case "Twilight Giant":
                    EternalDarkness.ApplyTwilightGiantPathway(this);
                    break;
                case "Moon":
                    GoddessOfOrigin.ApplyMoonPathway(this);
                    break;
                case "Mother":
                    GoddessOfOrigin.ApplyMotherPathway(this);
                    break;
                case "Justiciar":
                    TheAnarchy.ApplyJusticiarPathway(this);
                    break;
                case "Black Emperor":
                    TheAnarchy.ApplyBlackEmperorPathway(this);
                    break;
                case "Door":
                    LordOfMysteries.ApplyDoorPathway(this);
                    break;
                case "Error":
                    LordOfMysteries.ApplyErrorPathway(this);
                    break;
            }

            RecalculateCoreStats();
            CurrentHP = MaxHP;
            CurrentSHP = MaxSHP;
            CurrentSpirituality = maxspirituality;

            OnPropertyChanged(nameof(ActiveAbilities));
        }

        public void AddCustomSkill()
        {
            CustomSkills.Add(new CustomStat { Name = "New Skill", XP = 0, Mod = 0 });
        }

        public void AddOrUpgradeAbility(string keyword, string newName, string descriptionAddition)
        {
            var existingAbility = activeAbilities.FirstOrDefault(a => a.Name.Contains(keyword));

            if (existingAbility != null)
            {
                existingAbility.Name = newName;
                existingAbility.Description += $"\n\n[Upgraded]: {descriptionAddition}";
                OnPropertyChanged(nameof(ActiveAbilities));
            }
            else
            {
                activeAbilities.Add(new PathwayAbility(newName, descriptionAddition));
            }
        }
    }
}