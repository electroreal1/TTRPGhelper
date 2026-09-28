 namespace TTRPGhelper
{
    public static class GoddessOfOrigin
    {
        public static void ApplyMotherPathway(Character c)
        {
            if (c.CurrentSequence <= 9)
            {
                c.MaxHP += 10;
                c.MaxSHP += 2;
                c.Movement += 1;
                c.AC += 2;
                c.Botany += 1;
                c.ToHit += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Combat Buffs (Passive)", "Gain +2 dmg."));

                c.ActiveAbilities.Add(new PathwayAbility("Farming Proficiency",
                    "Planters possess a high proficiency with farming tools, distinguishing among different seeds, and nurturing them.\n" +
                    "Every crop harvest of them will give 20% more output.\n" +
                    "+1 to hitting when using farm weapons."));

                c.ActiveAbilities.Add(new PathwayAbility("Weather Forecasting",
                    "They can predict the weather to a certain extent by observing clouds, wind, and other natural phenomena.\n" +
                    "10+seq+botany\n" +
                    "• DC 10: prediction for today\n" +
                    "• DC 20: prediction for the week"));
            }

            if (c.CurrentSequence <= 8)
            {
                c.MaxHP += 6;
                c.MaxSHP += 2;
                c.Movement += 2;
                c.Botany += 1;
                c.Medicine += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Surgical Mastery",
                    "They are experts at surgery, possessing the corresponding skills in suturing severed limbs and transplanting internal organs, and having a fine control over medical tools.\n" +
                    "Takes 5 hours of time but fully restores HP."));

                c.ActiveAbilities.Add(new PathwayAbility("Treatments",
                    "Doctors possess a variety of Treatments and thus are rather good at healing a variety of different injuries/illnesses.\n" +
                    "• Evil Ailment Treatment: 10 + seq + medicine. They are able to relieve certain aliments and diseases associated with the domains of Evil and Depravity. Heals 1d5 hp and removes status effects. \n" +
                    "• Disease Treatments: 10+seq+medicine. Even if the disease is not associated with the domains of Evil and Depravity, they can still heal it. Heals 1d5 HP and removes status effects.\n" +
                    "• Trauma Treatment: 10+seq+medicine. They are able to effectively Treat and cure most forms of physical trauma through a Treatment. 1d5 healing and removes physical trauma."));

                c.ActiveAbilities.Add(new PathwayAbility("Soul Suture (Soul Sewing)",
                    "By having the patient let go of their bodies and mind, Doctors can carry out a Soul level surgery to sew up the corresponding wound.\n" +
                    "If a person were to completely open up their body and mind, leaving their Soul unprotected, a Doctor could be able to sever the person’s Soul.\n" +
                    "Soul Suture could be used by them as both a method of attack on the Soul, as well as a healing method to remove Corruption and Curses.\n" +
                    "10+seq+medicine\n" +
                    "Deals 20 dmg or Heals 20 HP.\n" +
                    "With enough practice, it is not impossible to artificially remove certain emotions and desires from a patient's Soul (DC 20).\n" +
                    "In terms of healing soul injuries, Soul Suturing is much more effective than simply doing an Evil Ailment Treatment."));

                c.ActiveAbilities.Add(new PathwayAbility("Spirituality", "Their Spirituality has become enhanced, allowing them to use Spirit Vision."));
            }

            if (c.CurrentSequence <= 7)
            {
                c.MaxHP += 12;
                c.MaxSHP += 2;
                c.Movement += 2;
                c.AC += 1;
                c.Botany += 2;
                c.Medicine += 1;
                c.ToHit += 2;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +2 dmg.");

                c.ActiveAbilities.Add(new PathwayAbility("Seed Catalyzation",
                    "Through this Beyonder power, a Harvest Priest will be able to directly Catalyze the life hidden within a seed or an already existing plant, causing it to grow faster.\n" +
                    "There are 2 methods that a Harvest Priest can employ to use this ability:\n" +
                    "• Ground Cast: If they were to put both hands on the ground, the surrounding plants and seed within a 30 meter radius from them would grow and reproduce much faster then normal. " +
                    "\nHowever, the affected plants and seeds will not instantaneously complete their life cycle from gestation to returning to the land in a few seconds or minutes.\n" +
                    "• Physical Contact: By directly holding some seeds or plants in one's hand, they could fully Catalyze the life within them, causing it to rapidly grow and reach maturity in a small amount of time.\n" +
                    "Through this, a Harvest Priest could, in a very short time, create a large amount of vines, which can be used to entangle and control enemies.\n" +
                    "10+seq+botany. Creates plants with 25 HP that stop enemy movement and can control weaker enemies physical actions.\n" +
                    "Through physical contact, it can also work on certain plant-like creatures.\n" +
                    "To a certain extent, this enables a Harvest Priest to directly Catalyze the vitality of a plant-like creature, either finishing its lifespan or causing it to more quickly mature.\r\n"));

                c.ActiveAbilities.Add(new PathwayAbility("Plant & Insect Commanding",
                    "Harvest Priests are able to directly Command plants and insects within a 30 meter radius to provide them with a certain level of support.\n" +
                    "There are 2 perquisites that need to be followed for this ability to work on a plant or insect.\n" +
                    "• The plant or insect they are attempting to Command does not possess intelligence. \n" +
                    "• The level of Commanding does not exceed the species' biological limitations.\n" +
                    "Commanded plants can do 1d10 dmg and use their hitting."));

                c.ActiveAbilities.Add(new PathwayAbility("Knowledge (Ritualistic Spells)",
                    "Upon drinking the potion, a Harvest Priest will obtain several Ritualistic Spells focused on manipulating the weather.\n" +
                    "Through the Ritualistic Spells provided by the potion, a Harvest Priest will gain the ability to clear the skies or summon rain within a certain area.\n"));

                c.ActiveAbilities.Add(new PathwayAbility("Enhanced Healing (Passive)", "Healing related abilities now heal double the amount."));
            }

            if (c.CurrentSequence <= 6)
            {
                c.MaxHP += 8;
                c.MaxSHP += 3;
                c.Movement += 2;
                c.Botany += 2;
                c.Medicine += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Crossbreeding",
                    "Biologists possess the ability to make a chimera or Crossbreed between various animals, plants, and even an object, directly leading to them creating a new species..\n" +
                    "Biologists are able to create Crossbreeds with different ordinary materials, allowing them to create unique species that possess abilities that can be directed to a certain purpose.\n" +
                    "While they can make Crossbreeds using normal materials, ingredients from Beyonders would allow them to create more magical Crossbreeds with more unique abilities.\n" +
                    "10+seq+botany/medicine\n" +
                    "The difficulty will be decided by DM and how special the crossbreed result is."));
            }

            if (c.CurrentSequence <= 5)
            {
                c.MaxHP += 12;
                c.MaxSHP += 2;
                c.Movement += 2;
                c.AC += 2;
                c.Healing += 2;
                c.Botany += 2;
                c.Medicine += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Bear Transformation",
                    "Druids are able to transform themselves into a giant bear that was twice the height of a person and that possesses great strength and endurance.\n" +
                    "-10 dmg taken, +2d6 dmg, +2 movement."));

                c.ActiveAbilities.Add(new PathwayAbility("Underground Slink",
                    "They can transform the ground below into a swamp and submerge themselves completely into it to avoid attacks or hide from enemies.\n" +
                    "10+seq+botany\n" +
                    "Sets AC and stealth until they go out."));

                c.ActiveAbilities.Add(new PathwayAbility("Poison Hair Incineration",
                    "Druids can incinerate their hair in a battle to produce a very toxic black gas with a variety of unknown poisonous effects.\n" +
                    "Every turn inflict 4 stacks of corrosion on everything in a 10 meter radius."));

                c.AddOrUpgradeAbility("Crossbreeding", "Crossbreeding",
                    "They gain abundant insight in the field of Crossbreeding and creating chimeras. This enhances their ability to Crossbreed more and diverse species.");
            }

            if (c.CurrentSequence <= 4)
            {
                c.MaxHP = (int)(c.MaxHP * 2.5);
                c.MaxSHP *= 2;
                c.Movement += 2;
                c.Botany += 3;
                c.Medicine += 3;

                c.ActiveAbilities.Add(new PathwayAbility("Mutation",
                    " is a core ability of a Classical Alchemist. With it, they are able to make each and every single one of their abilities cause Mutations to spring up in the target's body and mind.\n" +
                    "Each and every one of a Classical Alchemist's attacks carry the power to increase an enemy's madness level, therefore increasing the risk for that enemy to lose control.\n" +
                    "Each attack deals 2d3 sanity dmg.\n" +
                    "Besides causing madness to spring up, a Classical Alchemist's attacks have a chance of Mutating the target's body, producing effects such as but not limited too:\n" +
                    "• Causing a target's body to Mutate with additional organs. Such organs can prop up on the skin, and outer body, but also can sprout directly inside the target themselves.\n" +
                    "• Causing parts of their body to be replaced with various plants like watermelons, mushrooms, and wheat. that cannot be eaten as it would result in contamination \n" +
                    "• Each attack hit rolls a 1d3 to determine where the mutation happens\n" +
                    "   • 1 (Head): causes -5 to rolls and 1.5x dmg taken.\n" +
                    "   • 2 (Tummy): causes -3 to rolls and 1.2x dmg taken.\n" +
                    "   • 3 (Legs): causes -2 to rolls, -2 to movement and 1.1x dmg taken."));

                c.ActiveAbilities.Add(new PathwayAbility("Artificial Life Creation",
                    "They can use broken Souls and other materials to create various forms of life.\n" +
                    "The things they are able to create are constructs and humans. In the case of humans, they are able to create an ordinary one that can live for a very long time.\n" +
                    "They could create different dolls that could be used for battle and various kinds of things; this includes stone golems, mud golems, and steel golems.\n" +
                    "10+seq+medicine\n" +
                    "• DC 20: 25 HP, 1d6 dmg, and have their manufacturing as hitting value\n" +
                    "• DC 25: 35 HP and 1d10 dmg\n" +
                    "• DC 30: 50 HP and 1d12 dmg\n" +
                    "They can have up to 6 creations on the battlefield."));

                c.AddOrUpgradeAbility("Seed Catalyzation", "Life Aura",
                    "This is a qualitative enhancement to Seed Catalyzation. They can now directly fill their surroundings with vibrant life force, causing plants and animals to grow and reproduce rapidly.\n" +
                    "Even humans could be affected to a certain extent, causing their body to more rapidly develop and grow under the influence of a Classical Alchemist's Life Aura.\n" +
                    "10+seq+medicine\n" +
                    "• DC 20: Heals everything (apart from things they exclude) by 10 HP per turn.\n" +
                    "• DC 30: Heals 20 HP per turn.");

                c.AddOrUpgradeAbility("Plant & Insect Commanding", "Creature Commanding",
                    "This is a qualitative upgrade to Plant & Insect Commanding, allowing them to control Beyonder creatures with low intelligence for a short time period.\n" +
                    "This level of Commanding includes only Beyonder creatures that possess a shred of rationality. Human Beyonders who have lost control cannot be affected.\n" +
                    "10+seq+botany\n" +
                    "• DC 20: Control creatures up to seq5 for 5 turns.\n" +
                    "• DC 32: Control creatures up to seq4 for 3 turns.");

                c.AddOrUpgradeAbility("Enhanced Healing", " Enhanced Healing",
                    "Their abilities regarding healing, including but not limited too Surgical Mastery, Treatments, and Soul Suture have been strongly enhanced and strengthened.\n" +
                    "Using their Beyonder abilities, they can now heal anyone quickly no matter how seriously injured or damaged they are, other than those that have already lost control. +10 HP healing.\n" +
                    "Even for those who lost control, they can utilize their Soul Suture and Treatments specialized in that field to temporarily give them back rationality.\n" +
                    "This works with even Beyonder creatures with low intelligence as well.");
            }
        }

        public static void ApplyMoonPathway(Character c)
        {
            if (c.CurrentSequence <= 9)
            {
                c.MaxHP += 5;
                c.MaxSHP += 2;
                c.Movement += 1;
                c.AC += 1;
                c.MaxSpirituality += 2;
                c.PharmacyStat += 2;
                c.BeastTaming += 1;

                c.ActiveAbilities.Add(new PathwayAbility("Poison Resistance (Passive)", "Takes 2 Less Damage from Poison and Toxin related things."));

                c.ActiveAbilities.Add(new PathwayAbility("Medicinal Concoction (Main)",
                    "They excel at creating and mixing various herbs, and animal parts to create various Medicinal Concoctions. With such skills, they can easily treat most illnesses and injuries.\n" +
                    "10+seq+pharmacy\n" +
                    "These are just a few examples of the potions and concoctions Apothecaries can make:\n" +
                    "• A potion that would invoke the libido one has experienced during their teenage years\n" +
                    "  DC 10: normal potency\n" +
                    "  DC 15: +20% potency\n" +
                    "  DC 20: +30% potency\n" +
                    "• A potion that enhances one's strength, speed, and agility for a short amount of time\n" +
                    "  DC 10: +2 dmg, +1 movement, +1 AC (lasts for 2 turns)\n" +
                    "  DC 15: +2d2 dmg, +2 movement, +2 AC (lasts for 2 turns)\n" +
                    "  DC 20: +2d3 dmg, +3 movement, +3 AC (lasts for 2 turns)\n" +
                    "• A potion that effectively stop bleeding and stimulate the healing of wounds\n" +
                    "  DC 10: 1d4 healing for 2 turns\n" +
                    "  DC 15: 2d3 Healing for 2 turns\n" +
                    "  DC 20: 2d4 healing for 2 turns"));

                c.ActiveAbilities.Add(new PathwayAbility("Taming (Reaction or Extra Action)",
                    "They gain the ability to tame plants.\n" +
                    "10+seq+taming\n" +
                    "When beyonders use plant based abilities on them they can make a reaction with their roll against the targets roll to take control over these plants and make then attack the user."));

                c.ActiveAbilities.Add(new PathwayAbility("Spirituality & Spirit Vision (Passive)",
                    "Their Spirituality gets enhanced as a Beyonder. Their Spirit Vision shows them a person's overall health and wellbeing."));
            }
            if (c.CurrentSequence <= 8)
            {
                c.MaxHP += 10;
                c.MaxSHP += 2;
                c.Movement += 2;
                c.AC += 2;
                c.MaxSpirituality += 1;
                c.BeastTaming += 2;
                c.PharmacyStat += 1;
                c.ToHit += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Combat Buffs (Passive)", "Gain +2 dmg."));

                c.ActiveAbilities.Add(new PathwayAbility("Beast Taming",
                    "Beast Tamers are able to Tame, domesticate, and utilize various different and unique living animals, including Beyonder creatures, rather effectively.\n" +
                    "10+seq+beast taming\n" +
                    "• DC 10: tame normal creatures\n" +
                    "• DC 13: tame seq9 lvl creatures\n" +
                    "• DC 15: tame seq8 lvl creatures\n" +
                    "• DC 20: seq7 creatures\n" +
                    "• DC 25: seq6 creatures\n" +
                    "• DC 30: seq5 creatures"));

                c.ActiveAbilities.Add(new PathwayAbility("Intimidation",
                    "Beast Tamers are instinctively the natural enemies of animals, being able to Intimidate them into complete submission with just their gaze.\n" +
                    "10+seq+beast taming\n" +
                    "• DC 10: intimidate normal creatures\n" +
                    "• DC 13: intimidate seq9 lvl creatures\n" +
                    "• DC 15: intimidate seq8 lvl creatures\n" +
                    "• DC 20: seq7 creatures\n" +
                    "• DC 25: seq6 creatures\n" +
                    "• DC 30: seq5 creatures\n" +
                    "Intimidated creatures get -2 to taming difficulty, as well as advantage on the roll and get -3 to fighting the beast taming on their rolls."));

                c.ActiveAbilities.Add(new PathwayAbility("Animal Senses (Passive)", "Beast Tamers are able to communicate with animals, utilize those animals' senses, and read their emotions and intentions."));
            }
            if (c.CurrentSequence <= 7)
            {
                c.MaxHP += 15;
                c.MaxSHP += 3;
                c.Movement += 3;
                c.Healing += 5;
                c.AC += 3;
                c.MaxSpirituality += 4;
                c.PharmacyStat += 2;
                c.BeastTaming += 1;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +3 dmg. They take additional dmg from purification.");

                c.ActiveAbilities.Add(new PathwayAbility("Wings of Darkness (Extra)",
                    "Vampires are able to utilize the Darkness around them to form illusory bat wings that grant them an enhanced speed boost along with some limited flight capabilities.\n" +
                    "Costs 1 Spirituality per turn\n" +
                    "+2 movement, and 40 meter flight.\n\n" +
                    "--- Sub-Abilities ---\n" +
                    "Bat Swarm (Main):\n" +
                    "The Wings of Darkness can be transformed into a swarm of illusory bats to attack and pester a group of enemies.\n" +
                    "10+seq+beast taming\n" +
                    "Costs 2 Spirituality\n" +
                    "3 Targets at most designated in 15 meters range\n" +
                    "Bats have 10 HP and only deal one instance of dmg when summoned.\n" +
                    "Deals 3d4 DMG and gives the enemy disadvantage on attack rolls as long as they exist.\n\n" +
                    "Toxic Gas Release (Extra to maintain):\n" +
                    "They can emit black gases that hinder vision and cause damage.\n" +
                    "Costs 4 Spirituality\n" +
                    "Coats a visible area of 8 meters in this gas.\n" +
                    "Enemies in the Gas have their movement reduced by half and have disadvantage on attack rolls.\n" +
                    "Inflicts 2 Corrosion per turn.\n\n" +
                    "Black Flame Spreading (Extra to maintain):\n" +
                    "They can spread a quiet black flame.\n" +
                    "Costs 4 Spirituality per turn\n" +
                    "Can designate 3 enemy targets in 40 meter range.\n" +
                    "Inflicts 5 Black Flame per turn."));

                c.ActiveAbilities.Add(new PathwayAbility("Claw of Corrosion (Main)",
                    "Their nails can grow an extra section with mysterious symbols and patterns on it that make their nails able to cut through steel and give strong corrosion properties.\n" +
                    "10+seq+pharmacy\n" +
                    "Costs 4 Spirituality\n" +
                    "3d8 dmg and inflicts 3 corrosion\n" +
                    "The Claw of Corrosion a Vampire manifests is the bane of all scale, skin, and membrane-based defensive methods, able to cleave through those defenses flawlessly (dmg reduction is -5 less effective)."));

                c.ActiveAbilities.Add(new PathwayAbility("Abyss Shackles (Extra)",
                    "Use the Darkness or Shadows around them to form shackles to bind an enemy.\n" +
                    "10+seq+pharmacy\n" +
                    "30 meter range\n" +
                    "20HP shackles. Reduce movement by 12.\n" +
                    "If they succeed a check against the enemies strongest ability check they can make the enemy use an extra next turn that doesn’t need a beyonder ability."));

                c.ActiveAbilities.Add(new PathwayAbility("The Embrace / Blood Servant Conversion",
                    "The Embrace: Bestow excess Beyonder Characteristics onto a human, turning that human into one of them.\n" +
                    "Blood Servant Conversion: Convert any living creature into a Blood Servant (does not require excess characteristics).\n" +
                    "When an organism becomes a Blood Servant, their constitution will be greatly improved, and they become immune to many illnesses. Terminal illnesses disappear or become treatable.\n" +
                    "Regardless of the benefits, Blood Servants cannot disobey their master's orders and are equivalent to a puppet."));
            }
            if (c.CurrentSequence <= 6)
            {
                c.MaxHP += 10;
                c.MaxSHP += 3;
                c.Healing += 3;
                c.Movement += 2;
                c.AC += 1;
                c.MaxSpirituality += 2;
                c.PharmacyStat += 2;
                c.BeastTaming += 2;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +2 dmg. They can add their Taming to their observational rolls.");

                c.ActiveAbilities.Add(new PathwayAbility("Discerning Spiritual Materials (Passive)",
                    "An influx of knowledge regarding how to discern spiritual materials needed in various concoctions.\n" +
                    "This knowledge allows a Potion Professor to be able to treat terminal illness, as opposed to only being able to slow down its effects."));

                c.ActiveAbilities.Add(new PathwayAbility("Potion & Perfume Crafting",
                    "Mix and create Potions and Perfumes with extraordinary effects (limited by materials and knowledge).\n" +
                    "10+seq+pharmacy\n" +
                    "• Fire Breath Potion (DC 15): Spit out a Fire Breath. Deals 3d8 dmg and 10 burning.\n" +
                    "• Solar Water Potion (DC 18): Powerful against undead or vampire-type enemies. Deals 3d8 dmg 3x against mentioned types.\n" +
                    "• Invisibility Potion (DC 20): Applied to make oneself or objects completely Invisible (+10 stealth).\n" +
                    "• Anti-Smell Potion (DC 15): Eliminate the user's smell and body odor (+3 stealth).\n" +
                    "• Anti-Dream Potion (DC 25): Prevents the effects of Dream Pulling.\n" +
                    "• Shadow Potion (DC 25): Allows the user to utilize Shadow Movement."));
            }
            if (c.CurrentSequence <= 5)
            {
                c.MaxHP += 12;
                c.MaxSHP += 3;
                c.Movement += 3;
                c.AC += 3;
                c.Healing += 5;
                c.MaxSpirituality += 3;
                c.PharmacyStat += 2;
                c.BeastTaming += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Full Moon (Main)",
                    "Creates an environment advantageous for themselves (30 meter diameter, moves with user).\n" +
                    "Costs 2 Spirituality per turn\n" +
                    "• If the enemy is not good at dealing with Spirituality/Spirit World combat: Creates an environment covered by a Full Moon. Enemy beyonders take two stacks of Corrosion any time they use a spirituality based ability. Beyonder Abilities deal 6 More Damage.\n" +
                    "• If the enemy is excellent at dealing with Spirituality/Spirit World combat: Creates an environment devoid of Moonlight. Spirituality Consumption of beyonder abilities is increased by half. Beyonder Abilities deal 6 Less Damage."));

                c.ActiveAbilities.Add(new PathwayAbility("Moonlight Transformation (Extra)",
                    "Requires Moonlight (natural or via Full Moon).\n" +
                    "Transform into a condensed form of Moonlight that can move around near the Moonlit area.\n" +
                    "Costs 3 Spirituality per turn\n" +
                    "Even if hit and shattered, you can reconstruct and reform either on the spot or in another location under the Moonlight. Does not die at 1 HP but regenerates with 20HP.\n" +
                    "The only way to be injured and/or die in this form is if hit in the heart (requires 40 DMG in one instance or a nat20 on hitting)."));

                c.ActiveAbilities.Add(new PathwayAbility("Flash Teleportation (Extra or Movement)",
                    "Requires Moonlight (natural or via Full Moon).\n" +
                    "Teleport to another location within a certain radius so long as Moonlight is shining on that area.\n" +
                    "10+seq+pharmacy\n" +
                    "Costs 7 Spirituality\n" +
                    "• DC 10: 100 meter\n" +
                    "• DC 20: 300 meter\n" +
                    "• DC 25: 500 meter"));

                c.AddOrUpgradeAbility("Potion & Perfume Crafting", "Potion & Perfume Crafting", "The effectiveness of Potions and Perfumes has been enhanced by +25%.");

                c.ActiveAbilities.Add(new PathwayAbility("Darkness Domain Enhancement (Passive)", "Abilities and Spells related to the Darkness domain are strengthened. They gain an extra damage dice, 1 more stack infliction, or more range."));

                c.ActiveAbilities.Add(new PathwayAbility("Nightmare Resistance (Passive)", "Resistance to Nightmare-related influences have been reinforced. Nightmares will have to roll with 2x disadvantage against their highest ability check to pull them into a dream."));
            }
            if (c.CurrentSequence <= 4)
            {
                c.MaxHP = (int)(c.MaxHP * 2.5);
                c.MaxSHP *= 2;
                c.MaxSpirituality = (int)(c.MaxSpirituality * 2.75);
                c.Healing += 15;
                c.Movement += 4;
                c.AC += 3;
                c.PharmacyStat += 3;
                c.BeastTaming += 3;

                c.ActiveAbilities.Add(new PathwayAbility("Critical Weakness (Passive)", "Takes an additional Damage dice when being critically hit."));

                c.ActiveAbilities.Add(new PathwayAbility("Spirituality Manipulation", "Shaman Kings can simply 'interact with nature', and such interaction alone replaces all the needed preparation and materials required for Ritualistic Magic."));

                c.ActiveAbilities.Add(new PathwayAbility("Moon Strength Drawing Ritual (Extra)",
                    "Directly borrow the Moon's power on the spot, making them very terrifying opponents to deal with.\n" +
                    "Costs 5 Spirituality per turn\n" +
                    "Gives all their spells an additional hit dice, 2 more status effect infliction, and 30 meter increased range.\n" +
                    "Their healing is improved by 10 HP per turn."));

                c.ActiveAbilities.Add(new PathwayAbility("Undead Conversion Ritual (Extra)",
                    "Increase the Spirituality in a region to convert dead bodies into undead controlled by them.\n" +
                    "10+seq+beast taming\n" +
                    "Costs 5 Spirituality\n" +
                    "• DC 20: Every dead body is made into their servant\n" +
                    "• DC 30: Even enemies' undead can be controlled by them\n" +
                    "Everyone in the field regenerates 1 Spirituality per turn."));

                c.ActiveAbilities.Add(new PathwayAbility("Moon Paper Figurine (Free Action)",
                    "Transform the surrounding Moonlight into a Moon Paper Figurine to Substitute themselves with.\n" +
                    "10+seq+pharmacy\n" +
                    "Costs 6 Spirituality\n" +
                    "2 per turn\n" +
                    "They can also use it to block a fatal attack once per combat encounter for 25% of their spirituality."));

                c.ActiveAbilities.Add(new PathwayAbility("Gaze of Darkness (Main)",
                    "Gaze on someone with your eyes to form a Substitution connection that will manifest the state of the eye onto the target.\n" +
                    "10+seq+pharmacy\n" +
                    "Costs 15 Spirituality\n" +
                    "Can target everyone they see\n" +
                    "• Grab eyeball: Target is engulfed in solidified, restraining Darkness (-10 movement and -1 extra action). Lasts 3 turns.\n" +
                    "• Crush eyeball: Target is gravely injured or even destroyed (40% HP dmg).\n" +
                    "Their eyeball can regenerate once per combat encounter in 5 turns."));

                c.ActiveAbilities.Add(new PathwayAbility("Bat Swarm Transformation (Main)",
                    "Divide themselves into a swarm of vampire bats that are in a state that is both illusory and real.\n" +
                    "While in this form, unless the enemy can kill every single one of those bats, they can reconstruct and reform into their original form again without trouble.\n" +
                    "Costs 6 Spirituality\n" +
                    "Summons 100 bats each having 10HP.\n" +
                    "The Bats have to stay in a 100 Meter radius from where they were summoned."));

                c.AddOrUpgradeAbility("Abyss Shackles", "Abyss Shackles",
                    "Able to forcibly uproot and suspend in midair an entire roof with the strength of their Abyss Shackles.\n" +
                    "Now also deals d30 dmg.\n" +
                    "Costs 5 Additional Spirituality.\n" +
                    "Range increased to 200 meters.");
            }
        }
    }
}