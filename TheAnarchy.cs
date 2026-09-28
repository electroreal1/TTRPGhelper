using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGhelper
{
    public static class TheAnarchy
    {
        public static void ApplyJusticiarPathway(Character c)
        {
            if (c.CurrentSequence <= 9)
            {
                c.MaxHP += 7;
                c.MaxSHP += 2;
                c.MaxSpirituality += 1;
                c.Movement += 2;
                c.AC += 1;
                c.Law += 1;
                c.Persuasion += 1;
                c.ToHit += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Combat Buffs (Passive)", "Gain +3 dmg."));

                c.ActiveAbilities.Add(new PathwayAbility("Order (Passive)",
                    "An Arbiter will subconsciously maintain the current Order, unwilling to disrupt its fabric.\n" +
                    "If they bear official identities, this tendency only intensifies.\n" +
                    "While maintaining the current Order, they may get bonuses to their rolls, as chosen by the DM. If they disrupt the current Order they may get penalties."));

                c.ActiveAbilities.Add(new PathwayAbility("Authority (Extra)",
                    "Arbiters possess a convincing charm and have considerable Authority, causing people to be more likely to believe and obey their commands and words.\n" +
                    "When in conflict against an Arbiter, their enemies are often less confident about their chances and will have the feeling of wanting to give up.\n" +
                    "10+seq+presuasion\n" +
                    "• DC 10: people will more likely to believe their words and give up a fight\n" +
                    "• DC 15: people are very likely to believe their words\n" +
                    "• DC 20: People will believe their words unless they have a higher sequence"));
            }
            if (c.CurrentSequence <= 8)
            {
                c.MaxHP += 8;
                c.MaxSHP += 2;
                c.MaxSpirituality += 1;
                c.Movement += 2;
                c.AC += 1;
                c.Law += 1;
                c.Persuasion += 1;

                c.ActiveAbilities.Add(new PathwayAbility("Area of Jurisdiction (Passive)",
                    "Sheriffs are always connected to their own Area of Jurisdiction, granting them certain bonuses depending on their familiarity with their area.\n" +
                    "The more familiar a Sheriff is with their Territory, the better they are able to showcase their abilities; however, once they leave the area, they can only rely on their Beyonder abilities.\n" +
                    "• 1 Week: +2 to their rolls\n" +
                    "• 1 month: +3 to their rolls\n" +
                    "• 1 year: +4 to their rolls and advantage"));

                c.ActiveAbilities.Add(new PathwayAbility("Recognition (Passive)",
                    "As long as they have seen somebody, even though a painting or photograph, they will surely Recognize and remember that person through a supernatural sense.\n" +
                    "They possess memory, in the mystical sense, of the routes they have traversed.\n" +
                    "The DM will remind the Sheriff if they have seen an NPC before, at the player's request. They will also not get lost if they follow paths they know."));

                c.ActiveAbilities.Add(new PathwayAbility("Supernatural Intuition (Extra)",
                    "Sheriffs possess the capability to detect all sorts of strange abnormalities, even if they are hidden or just a remnant of a larger irregularity.\n" +
                    "10+seq+law\n" +
                    "• DC 10: Discern things in a radius of 10 meters allowing them to gain a basic track\n" +
                    "• DC 15: Discern things in a radius of 50 meters allowing them to gain a more intricate track\n" +
                    "• DC 20: Discern things in a radius of 150 meters allowing them to gain a detailed track\n" +
                    "• DC 25: Discern things in a 300 meter radius allowing for perfect tracking"));

                c.ActiveAbilities.Add(new PathwayAbility("Weapon Proficiency",
                    "A Sheriff has also gained proficiency in portable melee weapons and portable firearms such as pistols and shotguns.\n" +
                    "While wielding either, Shortswords, Revolvers, Shotguns, Staffs, Knives or other things considered portable, they get +2 to hitting."));
            }
            if (c.CurrentSequence <= 7)
            {
                c.MaxHP += 13;
                c.MaxSHP += 3;
                c.MaxSpirituality += 2;
                c.Movement += 2;
                c.AC += 2;
                c.Law += 1;
                c.Persuasion += 2;
                c.ToHit += 2;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +2 dmg.");

                c.ActiveAbilities.Add(new PathwayAbility("Whip of Pain (Main)",
                    "When an Interrogator uses this ability, the target will feel like electric currents are running through their spirit, connecting to form a whip of thorns that constantly beats their Soul.\n" +
                    "This creates feelings of pain and numbness that originates from the depths of their brain making them unable to resist the Interrogator's questions. It can also make them tremble and fall on their knees depending on the intensity of the Whip of Pain.\n" +
                    "10+seq+persuasion\n" +
                    "3d3 dmg, 10 stacks of charge"));

                c.ActiveAbilities.Add(new PathwayAbility("Psychic Piercing (Main)",
                    "An Interrogator can directly invade into a target's mental defenses within an effective range of 5 meters, leaving them subject to counterattack and arrest.\n" +
                    "10+seq+persuasion\n" +
                    "Enemy gets -3 to rolls for 1 turn and -5 movement"));

                c.ActiveAbilities.Add(new PathwayAbility("Brand of Restraint (Main)",
                    "They can manifest an illusory brand that can Restrain and suppress others.\n" +
                    "10+seq+persuasion\n" +
                    "halves movement"));

                c.ActiveAbilities.Add(new PathwayAbility("Psychic Lashing (Extra)",
                    "An Interrogator is able to attack by utilizing bolts of illusory lightning. Can be used alongside attacks.\n" +
                    "+1d4 dmg"));
            }
            if (c.CurrentSequence <= 6)
            {
                c.MaxHP += 10;
                c.MaxSHP += 3;
                c.Movement += 2;
                c.AC += 1;
                c.Law += 2;
                c.Persuasion += 1;

                c.ActiveAbilities.Add(new PathwayAbility("Verdict",
                    "Judges can directly issue commands, rules, and Verdicts through their words, which has varied effects on the target(s) depending on the words used.\n\n" +
                    "--- Verdict Effects ---\n" +
                    "• Confinement (Reactionary): While in a room, they can say this word to make it Sealed, preventing entry or exit. 10+seq+law.\n" +
                    "• Imprison: Say \"Imprison\" to surround a target with a transparent wall, making the target trapped in a sticky liquid hard for Spirit Bodies to go through. 10+seq+law. 30HP, reduces movement to 0.\n" +
                    "• Release: The Imprison effect can be ended early using the word \"Release\".\n" +
                    "• Death: By saying the word \"Death\", the Judge will quickly travel to the target to deliver a powerful strike so fast it leaves afterimages. 10+seq+law. 4d8 dmg + 5 charge.\n" +
                    "• Exile: By saying the word \"Exile\", they can force the selected target out at high speeds. Affects Spirit Bodies. 10+seq+law. Moves targets a max of 50 meters.\n" +
                    "• Flog: By saying the word, they can Flog targets with a shapeless whip from range which can break clothes, open flesh, and reveal bones. 10+seq+law and reduces targets AC by 5."));

                c.ActiveAbilities.Add(new PathwayAbility("Prohibition",
                    "By using it, they can formulate rules that Prohibit certain actions or states, forcing everything in a certain range to comply.\n" +
                    "For Prohibition to activate, a Judge must first describe the Prohibition in a manner similar to: \"This place Prohibits the action/use of\".\n" +
                    "With this, a Judge can restrict the use of Beyonder powers, certain actions, Flight, floating, Teleportation, etc.\n" +
                    "10+seq+law"));

                c.AddOrUpgradeAbility("Authority", "Authority",
                    "Their Authority as Arbiters has undergone a qualitative change, making them have an indescribable aura that makes people around them subconsciously avoid their gaze.");

                c.AddOrUpgradeAbility("Area of Jurisdiction", "Area of Jurisdiction (Territory)",
                    "A Judge's overall range for their Area of Jurisdiction has been enhanced, making it be at maximum the size of a city on the OCs safe haven.");
            }
            if (c.CurrentSequence <= 5)
            {
                c.MaxHP += 13;
                c.MaxSHP += 3;
                c.Movement += 2;
                c.AC += 2;
                c.Law += 2;
                c.Persuasion += 2;
                c.ToHit += 2;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +3 dmg.");

                c.ActiveAbilities.Add(new PathwayAbility("Punishment",
                    "If someone breaks the rules previously set by a Disciplinary Paladin's Prohibition, the Disciplinary Paladin will be able to Punish the offender in 3 ways:\n" +
                    "• Target Beyonder powers: Give the ability to break them.\n" +
                    "• Speed Burst: Augment themselves to travel at rapid speeds (even to flying targets) and launch a powerful attack. +10 movement, +2d10 dmg, +4 hitting for 1 turn.\n" +
                    "• Immobilize: Restrict the offender, seemingly immobilizing their target's feet with invisible shackles. 10+seq+law. Reduces targets movement to 0."));

                c.AddOrUpgradeAbility("Authority", "Master Authority",
                    "Their aura of Authority has been greatly strengthened and improved. Their Authority can induce horror in their targets, making them want to lower their heads, prostrate, and listen to the Disciplinary Paladin's every word and order.");
            }
            if (c.CurrentSequence <= 4)
            {
                c.MaxHP *= 2;
                c.MaxSHP *= 2;
                c.Movement += 3;
                c.AC += 3;
                c.Law += 3;
                c.Persuasion += 3;

                c.ActiveAbilities.Add(new PathwayAbility("Deprivation",
                    "They can directly strip certain Beyonder powers from a single target.\n" +
                    "10+seq+law\n" +
                    "Stripped Beyonder powers are made unusable for a certain period of time (2 turns).\n" +
                    "This only Deprives the target from using/accessing their powers, and does not completely strip the ability from the target."));

                c.ActiveAbilities.Add(new PathwayAbility("Power of Laws",
                    "They can utilize the Power that stems from Laws.\n" +
                    "• Teleportation: Imperative Mages are able to achieve a form of short-ranged Teleportation by utilizing the Laws to erase the distance between them and their destination. 10+seq+law. DC 10: 500 meters, DC 15: 1km, DC 20: 2km, DC 30: 5 km.\n" +
                    "• Defense (Reactionary): They can make use of the Law to defend themselves. This often manifests itself as the Laws slowing down bullets and cannonballs in an almost quagmire-like state. 10+seq+law. Halves the power of attacks."));

                c.AddOrUpgradeAbility("Supernatural Intuition", "Supernatural Intuition",
                    "As a follower of Order, they can discern Beyonders from ordinary people in their \"position\" as well as judge the Sequence level of a Beyonder based on this.");

                c.AddOrUpgradeAbility("Verdict", "Verdict",
                    "This power is not just limited to those in the Judge sequence. Any sentence they speak in mystical language like Hermes can be set as a rule for their targets to follow.\n\n" +
                    "--- New Verdict Effects ---\n" +
                    "• Weaken Mysticism, Enhance Reality: Weakens the power of supernatural abilities while enhancing the power of non-supernatural things. 10+seq+persuasion. Buffs normal things by 50% and weakens mysticism by 50%.\n" +
                    "• Exile (Advanced): Exile targets into a void to deal with enemies that cannot be resolved quickly. 10+seq+persuasion.\n" +
                    "• Execution: Directly Execute the target and kill them from afar (strengthened form of Death). 10+seq+persuasion. 10d8 dmg and +10 charge.\n" +
                    "• Confinement (Advanced): Greatly strengthened, cut off any supernatural power from the outside. 10+seq+persuasion.\n" +
                    "• Eternal Peace: By stating \"All the dead will receive their eternal peace\", make a region that induces eternal rest to the dead.");

                c.ActiveAbilities.Add(new PathwayAbility("Restriction",
                    "Rather than only Prohibiting certain actions in particular areas, they will now be able to Restrict those actions in an area.\n" +
                    "The difference between Prohibition and Restriction is that while Prohibition only suppresses the ability to do certain actions, Restriction completely prevents it."));
            }
        }

        public static void ApplyBlackEmperorPathway(Character c)
        {
            if (c.CurrentSequence <= 9)
            {
                c.MaxHP += 4;
                c.MaxSHP += 2;
                c.Movement += 1;
                c.Law += 1;
                c.Persuasion += 1;

                c.ActiveAbilities.Add(new PathwayAbility("Eloquence",
                    "Lawyers are the masters of speech and reasoning, being able to influence the judgement, thoughts, and conclusions that others are brought to via words, actions, and established processes.\n" +
                    "Through this, Lawyers are able to effectively distort a target's thinking to a certain degree, making people feel very close to them or willing to trust them.\n" +
                    "10+seq+persuasion\n" +
                    "• DC 10: Distort targets thinking to a minor degree\n" +
                    "• DC 15: Distort targets thinking to a bigger degree\n" +
                    "• DC 20: Distort targets thinking to a big degree"));

                c.ActiveAbilities.Add(new PathwayAbility("Law Proficiency",
                    "They are very good at taking advantage of the loopholes within various social rules and laws, as well as the legal weaknesses an enemy possesses.\n" +
                    "10+seq+law\n" +
                    "• DC 10: They find out minor weaknesses giving +1 on certain rolls\n" +
                    "• DC 15: They find out bigger weaknesses giving +2 on certain rolls\n" +
                    "• DC 20: They find out a big weakness giving advantage on certain rolls"));
            }
            if (c.CurrentSequence <= 8)
            {
                c.MaxHP += 10;
                c.MaxSHP += 2;
                c.Movement += 2;
                c.AC += 2;
                c.Persuasion += 1;
                c.ToHit += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Combat Buffs (Passive)", "Gain +3 dmg."));

                c.ActiveAbilities.Add(new PathwayAbility("Mental Resistance (Passive)",
                    "In addition to their Physical Enhancement, upon advancement, a Barbarian will also possess a high resistance to psychological influences.\n" +
                    "-50% sanity damage taken"));
            }
            if (c.CurrentSequence <= 7)
            {
                c.MaxHP += 6;
                c.MaxSHP += 2;
                c.Movement += 1;
                c.AC += 1;
                c.Law += 1;
                c.Persuasion += 1;

                c.ActiveAbilities.Add(new PathwayAbility("Bribery (Main/Reactionary)",
                    "The core ability of a Briber. By giving their target(s) an actual or symbolic Bribe, they would be able to achieve several domineering effects over their target(s).\n" +
                    "A Bribe can be anywhere between giving a target money to throwing an 'object' near the direction of the target; even if the target does not accept the 'object', it still counts as a Bribe.\n" +
                    "10+seq+persuasion\n\n" +
                    "--- Bribe Effects ---\n" +
                    "• Bribe-Weaken: Within a certain period of time, the target will become weakened, significantly lowering their ranged and melee attacks, defense, and control over the Briber. -30% damage dealt for 1 turn.\n" +
                    "• Bribe-Arrogance: The target would become proud and Arrogant, lowering their intelligence, and causing them to make mistakes or wrong judgements on their situation. -2 to rolls for 1 turn.\n" +
                    "• Bribe-Charm: The target will feel an intense feeling of good or would have a good perception of the Briber, making it hard to have negative intentions towards them. Sometimes the target will be completely unwilling to fight the Briber, and in the right conditions, there is a small chance that they will instead fight their allies on the spot.\n" +
                    "• Bribe-Connection: This establishes a 'relationship' between the Briber and the target, or in other words, it creates a Connection between the 2 parties."));
            }
            if (c.CurrentSequence <= 6)
            {
                c.MaxHP += 10;
                c.MaxSHP += 3;
                c.Movement += 2;
                c.AC += 1;
                c.Law += 3;

                c.ActiveAbilities.Add(new PathwayAbility("Distortion (Reactionary)",
                    "Barons of Corruption possess the Beyonder ability that allows them to warp the loopholes found within Order so as to Distort a target's words, actions, and intent.\n" +
                    "By Distorting a target's words, actions, or intent, they would be able to form a certain Order that provides them with an advantage, achieving the effect of restraint and influence.\n" +
                    "At their level, they are able to Distort a select few concepts/rules present within the actions (both direct and indirect), intent, or thoughts of a target, thus creating new rules.\n" +
                    "10+seq+law prof and weakness detection against the roll of the enemies action."));

                c.ActiveAbilities.Add(new PathwayAbility("Corrosion (Main)",
                    "They can Corrode anyone within a 10 meter range, causing them to become increasingly more 'dark' and greedy as they become more prone to do irrational actions.\n" +
                    "10+seq+persuasion\n" +
                    "Enemies get more greedy and get -2 to rolls."));

                c.ActiveAbilities.Add(new PathwayAbility("Weakness Detection",
                    "In addition, with Corrosion and Distortion, Barons of Corruption are acutely able to sense a target's weaknesses and flaws.\n" +
                    "10+seq+law\n" +
                    "• DC 20: +2 to hitting\n" +
                    "• DC 25: +3 to hitting\n" +
                    "• DC 30: +4 to hitting"));
            }
            if (c.CurrentSequence <= 5)
            {
                c.MaxHP += 13;
                c.MaxSHP += 3;
                c.Movement += 2;
                c.AC += 2;
                c.Law += 2;
                c.Persuasion += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Disorder",
                    "Mentors of Disorder are able to bring chaos within the Order of the surrounding environment, creating Disorder that grants them several advantages in a situation.\n" +
                    "At their current Sequence level, a Mentor of Disorder is only able to effect perception, and a select few concepts of distance and control with Disorder.\n\n" +
                    "--- Disorder Effects ---\n" +
                    "• Action Disorder (Reactionary): Make an enemy's actions Disordered, causing them to do things in the wrong order. 10+seq+law rolls against enemies highest stat; if they roll higher they can freely swap the order of actions taken.\n" +
                    "• Perception Disorder: A target's perception can be Disordered, such that they will make mistakes with their attacks. 10+seq+law. -5 to hitting with their attack.\n" +
                    "• Fake Version: Use Disorder to create a fake version of themselves to mislead possible attackers. 10+seq+law to set the DC for knowing if that is the real one or not.\n" +
                    "• Control Removal: Use Disorder to get rid of the control abilities of the enemy. 10+seq+law against the ability.\n" +
                    "• Distance Travel: Use Disorder to travel a vast distance in a few paces. 10+seq+law. DC 10: 50 meters, DC 20: 100 meters, DC 25: 300 meters."));

                c.ActiveAbilities.Add(new PathwayAbility("Majesty",
                    "A Mentor of Disorder is able to display a sense of great royalty, a Majesty that causes others to want to lower their bodies and obey their every command.\n" +
                    "10+seq+persuasion\n" +
                    "• DC 10: Seq9 will obey their command\n" +
                    "• DC 15: Seq8 will obey their command\n" +
                    "• DC 20: Seq7 will obey their command\n" +
                    "• DC 25: Seq6 will obey their command for 2 turns\n" +
                    "• Nat 20: Seq5 will obey their command for 1 turn"));

                c.AddOrUpgradeAbility("Distortion", "Distortion",
                    "Their ability to Distort has been slightly strengthened, allowing a Mentor of Disorder to be able to Distort their surroundings or nearby objects that are not tied to an 'entity'.");
            }
            if (c.CurrentSequence <= 4)
            {
                c.MaxHP *= 2;
                c.MaxSHP *= 2;
                c.Movement += 2;
                c.AC += 2;
                c.Law += 3;
                c.Persuasion += 3;

                c.ActiveAbilities.Add(new PathwayAbility("Exploit",
                    "Earls of the Fallen are able to directly Exploit the effects of Laws, extending certain states for longer periods of time or ending it ahead of time. This makes the rules more beneficial to themselves.\n" +
                    "For example, after jumping in mid air, an Earl of the Fallen can Exploit the state of being away from the ground, extending it and achieving the effect of floating.\n" +
                    "By Exploiting the jumping process of their jump itself while also Exploiting the state of being away from the ground, an Earl of the Fallen can achieve a form of flight.\n" +
                    "They can make any state last 2 turns longer.\n" +
                    "They can make enemy states last 2 turns longer by 10+seq+law against their ac."));

                c.ActiveAbilities.Add(new PathwayAbility("Bestowment",
                    "Within a certain range, Earls of the Fallen are able to directly Bestow all sorts of negative traits and attributes to the living beings, making them less effective and easier to manipulate.\n" +
                    "10+seq+persuasion\n" +
                    "Among these conditions include the following:\n" +
                    "• Making them only focused on money. The enemy will spend however many actions it takes to obtain it.\n" +
                    "• Turning the target eager and rash. -3 to rolls, 1 turn.\n" +
                    "• The feeling of sluggishness. +10 freeze.\n" +
                    "• Making the target anxious. -2 to rolls, 2 turns.\n" +
                    "• Losing the will to fight. lasts 1 turn."));

                c.ActiveAbilities.Add(new PathwayAbility("Magnify",
                    "They are able to Magnify the interactions that make up the surrounding Order, enhancing it's effect to a significant degree and making even the most benign of things dangerous.\n" +
                    "The interactions and effects an object are able to bring out can also be Magnified, causing said object to possess a stronger influence or effect than possible.\n" +
                    "They can add +5 to any thing they want.\n\n" +
                    "--- Magnify Applications ---\n" +
                    "• Natural Laws: They can Magnify the potency of natural laws and phenomena, turning the smallest of weather conditions into a disaster (e.g., transforming strong winds into a small Hurricane).\n" +
                    "• Gestures: Earls of the Fallen are able to Magnify the act of 'grabbing', allowing them to grab someone from nearly 100 meters away just through the appropriate gesture. 10+seq+law. They can Magnify a hug and turn it into a restriction (nullifies enemy movement). 10+seq+law (Reactionary Action).\n" +
                    "• Injuries: The injuries they have dealt to their opponents or that are just present can be Magnified, making them in some cases simply die on the spot. 10+seq+law. Make injuries +50% worse.\n" +
                    "• Attacks: An Earl of the Fallen is able to Magnify the potency of their ordinary attacks to the point where those attacks will become an execution. +1d40 dmg."));

                c.AddOrUpgradeAbility("Disorder", "Disorder (Reactionary)",
                    "Their ability to Disorder has undergone a qualitative change, effecting more aspects of Order.\n" +
                    "They can make a seemingly massive building collapse, cause a huge distance to be shortened to that of a few paces (travel distance increased by 1000 meters per dc), while also causing attacks aimed at them to miss their mark (reactionary action to make attacks miss their mark).");

                c.AddOrUpgradeAbility("Bribery", "Bribery",
                    "Their abilities of Bribing get stronger as Demigods and can also be used in tandem with Magnify.\n" +
                    "A simple rose being thrown can be Magnified to an extent that it causes a violent quake when impacting the ground while at the same time imparting the effects of Bribe—Weaken.");

                c.AddOrUpgradeAbility("Distortion", "Distortion",
                    "They can Distort the rules of Beyonder powers, as well as better Distort their actions.\n" +
                    "They can Distort the rules of the Marionette Interchange power of a Bizarro Sorcerer such that they could only swap between 2 Marionettes.\n" +
                    "They are able to directly create a Seal in thin air, effectively creating an invisible wall, through just Distorting an act of \"closing a door\".");
            }
        }
    }
}