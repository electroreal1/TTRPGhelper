using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGhelper
{
        public static class LordOfMysteries
        {

            public static void ApplyErrorPathway(Character c)
            {
            if (c.CurrentSequence <= 9)
            {
                c.MaxHP += 3;
                c.MaxSHP += 2;
                c.SleightOfHand += 2;
                c.MaxSpirituality += 1;
                c.Movement += 2;
                c.AC += 1;
                c.Acrobatics += 2;
                c.Stealth += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Combat Buffs (Passive)",
                    "Gain +2 dmg."));

                c.ActiveAbilities.Add(new PathwayAbility("Combat proficiency",
                    "While using short weapons or finesse weapons they enjoy a +1 to hitting"));

                c.ActiveAbilities.Add(new PathwayAbility("Superior Observation",
                    "They are capable of easily finding valuables among people and in rooms\n" +
                    "10+seq+sleight of hand\n" +
                    "Extra Action\n" +
                    "Their Superior Observation directly covers a range of sensing valuables in 10 meter distance automatically\n" +
                    "To determine their position they have to roll a check\n" +
                    "dc10+seq: They find the location of minor valuable such as pocket change\n" +
                    "dc15+seq: They directly are capable of finding the position of a wallet on someone even if it is in a pocket\n" +
                    "dc20+seq: They can immediately find the valuables people cherish to some degree (+1 to theft(stealing) roll)\n" +
                    "dc25+seq: they are capable of finding out mystical valuables on someone (+2 to theft(stealing) roll)"));

                c.ActiveAbilities.Add(new PathwayAbility("Theft (Item-Stealing)",
                    "With the help of their nimble hands they can take someone's valuables without noticing\n" +
                    "extra action\n" +
                    "10+seq+sleight of hand\n" +
                    "dc12+seq: They pickpocket someone's pocket change without them knowing\n" +
                    "dc15+seq: they pickpocket someone's wallet without them knowing\n" +
                    "dc22+seq: They pickpocket someone's cherished valuable without them knowing\n" +
                    "dc27+seq: they pickpocket someone's mystical items without them knowing\n" +
                    "Being in Stealth, Advantageous Situations for theft and the like gives Advantage on the roll"));
            }

            if (c.CurrentSequence <= 8)
            {
                c.MaxHP += 7;
                c.MaxSHP += 2;
                c.Deception += 2;
                c.SleightOfHand += 1;
                c.MaxSpirituality += 2;
                c.Movement += 2;
                c.AC += 3;
                c.Acrobatics += 2;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +2 dmg.");

                c.ActiveAbilities.Add(new PathwayAbility("Dodge",
                    "As a reaction, once per turn they can try to dodge a ranged attack or melee attack that doesn’t have the speed of a bullet. \n" +
                    "10+seq+acrobatics\n" +
                    "Usually beyonder abilities from sequence 6 onward count as speed of a bullet\n" +
                    "Depending on the amount you exceed the opponents roll by, the damage gets reduced.\n" +
                    "Exceeding by 1: d3+acrobatics\n" +
                    "Exceeding by 5: 2d2+acrobatics\n" +
                    "Exceeding by 10: 2d2+2+acrobatics\n" +
                    "Exceeding by 15: 3d2+2+acrobatics"));

                c.ActiveAbilities.Add(new PathwayAbility("Mental Disruption",
                    "They can cause slight hallucinations to targets lowering the dc of Theft(stealing) and of Swindling\n" +
                    "10+seq+deception\n" +
                    "extra action\n" +
                    "dc15+seq: the target sees slight auditory hallucinations (-1 to the dc)\n" +
                    "dc20+seq: The target sees illusions influencing their environment (-3 to the dc)\n" +
                    "dc25+seq: The target suffers from stronger hallucinations (-5 dc)\n" +
                    "this ability only leaves a temporary effect as such it does not influence the targets combat abilities"));

                c.ActiveAbilities.Add(new PathwayAbility("Charm",
                    "In conversations the user always sounds believable\n" +
                    "When deceiving someone they can add their sequence bonus to the roll resulting in it being 10+seq+deception and gain advantage on Deception Rolls(Only for Convincing) if the targets sequence is lower or equal to theirs"));

                c.ActiveAbilities.Add(new PathwayAbility("Eloquence",
                    "For every minute in conversation their deceptive abilities get stronger and stronger\n" +
                    "1 minute → +1 deception\n" +
                    "3 minutes→ +2 deception\n" +
                    "8 minutes → +3 deception"));

                c.ActiveAbilities.Add(new PathwayAbility("Thought misdirection",
                    "During every dialogue said in a conversation be that in battle or out of battle they can slowly influence their targets thinking making them drop their guard.\n" +
                    "10+seq+deception\n" +
                    "extra action\n" +
                    "dc15+seq: they lower the dc for any type of stealing by 1\n" +
                    "dc20+seq: they lower the dc for any type of stealing by 2\n" +
                    "dc30+seq: they lower the dc for any type of stealing by 3"));

                c.AddOrUpgradeAbility("Superior Observation", "Superior Observation",
                    "A swindler can now use their Superior Observation to Observe the target’s mental state. \n" +
                    "10+seq+sleight of hand\n" +
                    "dc10+seq: They can figure out the targets outward mental state\n" +
                    "dc15+seq: They can glimpse into the targets inner mental state\n" +
                    "They gain a +2 on Superior Observation rolls regarding finding the position of valuables and their Valuable Sense range is increased to 20 meters");

                c.ActiveAbilities.Add(new PathwayAbility("Theft (Item-Stealing-Ranged)",
                    "They can steal spiritual materials from a short distance which equals 4 meters or less.\n" +
                    "Costs 1 Spirituality"));
            }

            if (c.CurrentSequence <= 7)
            {
                c.MaxHP += 7;
                c.MaxSHP += 4;
                c.MaxSpirituality += 3;
                c.SleightOfHand += 2;
                c.Deception += 2;
                c.Movement += 2;
                c.AC += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Decryption",
                    "They are capable of recreating the truth behind incidents and events as well as usage of different things with minor information\n" +
                    "10+seq+sleight of hand\n" +
                    "Costs 2 Spirituality \n" +
                    "Extra Action\n" +
                    "Decryption (Information): They can figure out information about mystical items, someone's pathway, a god's honorific name.\n" +
                    "dc10+seq: They glean superficial information, e.g. something like the pathway or activation incantation of a charm\n" +
                    "dc15+seq: They can glean cleared information like the effects of an artifact\n" +
                    "dc18+seq: They glean full information on the abilities of an artifact or person, based on what is known\n" +
                    "dc25+seq: They can look into the deeper secrets like possible origins or connections of a person / artifact\n\n" +
                    "Decryption(Illusion): They can use their decryption check to break through illusions, dreams or mysteries or location of people.\n" +
                    "For example they can figure out where a stealthed person is they saw prior by decrypting against their stealth check.\n\n" +
                    "Decryption(Secrets): They can use their decryption to figure out the secrets of behind mystical items or sealed artifacts or other “secretive” things\n" +
                    "The dc is determined by the dm based on the information known by the Cryptologist as well as the status of the secret\n\n" +
                    "Decryption(Symbols): They can figure out the hidden meanings behind various things. This includes subtle actions, a Hunter's plans, a story's metaphors etc.\n" +
                    "The more information the know of the target like who the planner / writer is or other works of theirs the easier it is to decrypt.\n\n" +
                    "Decryption(Combat): They can decrypt the enemies actions taken next round or this round (based on initiative) to prepare beforehand. \n" +
                    "Once per turn spend 2 Spirituality to quickly decrypt the enemies action. \n" +
                    "Extra Action\n" +
                    "Only works if the enemy has already been seen in action at least once, be that before combat or in combat.\n" +
                    "dc10+seq: They are minorly prepared for the enemies actions, +2 AC against the enemies first move\n" +
                    "dc12+seq: +2 AC against the enemies first two moves\n" +
                    "dc15+seq: +2 AC against the enemies first 3 Moves ( 2 extras and 1 main)\n" +
                    "dc17+seq: Enjoy the prior bonus and a +2 on the dodge.\n" +
                    "Instead of preparing for the enemies attacks the Cryptologist can also prepare for the right moment to steal\n" +
                    "dc10+seq: +1 to sleight of hand\n" +
                    "dc12+seq: +2\n" +
                    "dc15+seq: +3\n" +
                    "dc20+seq: +3 and advantage\n" +
                    "Every decryption gleans at least something. If a decryption is not used via average but gets above dc10 with a roll then they gain a bonus to their next decryption regarding that matter decided by the DM"));

                c.AddOrUpgradeAbility("Superior Observation", "Superior Observation",
                    "They can now use their check to also glean clues regarding situations, objects or other things. Those clues will provide bonuses to theft rolls or decryption rolls.");
            }

            if (c.CurrentSequence <= 6)
            {
                c.MaxHP += 10;
                c.MaxSHP += 4;
                c.MaxSpirituality += 3;
                c.SleightOfHand += 2;
                c.Deception += 2;
                c.Movement += 3;
                c.AC += 3;
                c.Acrobatics += 2;

                c.AddOrUpgradeAbility("Combat Buffs", "Combat Buffs (Passive)", "Gain an additional +1d6 dmg.");

                c.ActiveAbilities.Add(new PathwayAbility("Mental Resistance",
                    "Mental corruption has a lowered effect on them.\n" +
                    "They take -2 sanity damage"));

                c.ActiveAbilities.Add(new PathwayAbility("Theft (Stealing)",
                    "Theft has its success rate overall increased and they now can affect beyonder powers and objects over a longer distance"));

                c.AddOrUpgradeAbility("Theft (Item-Stealing)", "Theft (Item-Stealing)",
                    "It gains the effects of Ranged Stealing as well as further enhancements.\n" +
                    "Stealing Costs 2 Spirituality\n" +
                    "They can steal items from a range of 50 meters without being found out.\n" +
                    "Furthermore they can also steal an enemies weapons, beyonder items etc.\n" +
                    "The Requirement for that is a decryption on the enemy and item that's at least a 15 \n" +
                    "Stealing is done with a theft check against the enemies highest stat. The prometheus has disadvantage on the roll unless the target is fully decrypted as well as the item to be stolen.\n" +
                    "High level items are harder to steal and they gain further disadvantage against high level beings.\n" +
                    "Ownerless objects can be stolen without a check unless they are natural phenomena.");

                c.ActiveAbilities.Add(new PathwayAbility("Theft (Ability-Stealing)",
                    "They can temporarily steal a targets beyonder power and use it themselves with proficiency for one combat encounter or 10 minutes.\n" +
                    "Stealing Costs 3 Spirituality\n" +
                    "Extra Action\n" +
                    "Ability-Stealing is performed with a sleight of hand check against the target's roll used for that ability. The Prometheus roll will be performed with disadvantage.\n" +
                    "The DM will give a couple of “colors” as a theft target if the information known about the target is insufficient. \n" +
                    "Insufficient means, not knowing pathway, sequence and abilities. \n" +
                    "If they know pathway sequence and the ability they want to target they can filter out that ability but have to rely on luck for the others.\n" +
                    "They can steal beyonder abilities of Their Sequence -2 without performing a roll but they will still have to rely on “Colors” if they don’t know the correspondingly needed knowledge\n" +
                    "Stealing beyond abilities higher than their own sequence results in an additional disadvantage gained per sequence difference.\n" +
                    "If they know the ability but not the mysticism knowledge related to it they have to wait 1 turn before stealing it.\n\n" +
                    "The stolen ability will be used with deception instead of the original stat used. The sequence bonus will be equivalent to the target it was stolen from.\n" +
                    "Having successfully stolen an ability means the target can’t activate it anymore for at least a couple of hours. Already active abilities stay activated but once they run out they can’t be used anymore.\n" +
                    "Mental Corruption can also be stolen but the Prometheus takes sanity damage on trying to steal it or successfully doing so\n" +
                    "They can only steal one ability per target"));

                c.AddOrUpgradeAbility("Superior Observation", "Superior Observation",
                    "Their valuable sense range has been increased to 50 meters and they automatically know the approximate value and possible types.\n" +
                    "Only concealment can cause valuables to be hidden from a Prmetheus.\n" +
                    "Furthermore they gain advantage on Superior Observation");
            }

            if (c.CurrentSequence <= 5)
            {
                c.MaxHP += 10;
                c.MaxSHP += 2;
                c.MaxSpirituality += 4;
                c.SleightOfHand += 3;
                c.Deception += 2;
                c.Movement += 2;
                c.AC += 2;

                c.ActiveAbilities.Add(new PathwayAbility("Theft Reaction (Passive)", "They gain an additional reaction only usable for theft"));

                c.ActiveAbilities.Add(new PathwayAbility("Dream Infusion",
                    "Dream Stealers are able to infiltrate the Dreams of others and infuse scenes within the Dream to influence their target's future decisions and actions.\n" +
                    "10+seq+deception\n" +
                    "Main Action\n" +
                    "dc15+seq→ targets will follow your influences to some degree\n" +
                    "dc20+seq→ targets will follow your influence to a good degree\n" +
                    "dc25+seq→ targets will follow your influence to a profound extent\n" +
                    "dc30+seq→ Targets will abide by your influences believing them"));

                c.ActiveAbilities.Add(new PathwayAbility("Disguise (Theft of the Secrets of Heaven)",
                    "They can disguise themselves as followers of a True Deity bypassing defenses, Stealing prayer responses and ritualistic magic. \n" +
                    "Costs 8 Spirituality\n" +
                    "Main Action\n" +
                    "The Target doesn’t necessarily need to be a living thing, objects high enough in status or infused with divinity also work.\n" +
                    "10+seq+deception\n" +
                    "dc15: They can steal the prayer required for creating a low-mid sequence level charm\n" +
                    "dc22: They can steal something up to high mid sequence level, be that an item being bestowed or a high level charm. \n" +
                    "This also does include information being bestowed.\n" +
                    "Backlash from the deity might happen if they realise the theft.\n" +
                    "They have to utter the following incantation to complete the theft: \"Steal the secrets of heaven, Swift as a decree, be driven.\" \n" +
                    "In combat stealing responses can be done as well but 3 successful decryptions have to be done on the target and information regarding the deity prayed to must be gleaned.\n" +
                    "If this is done successful, they can prevent the target from gaining the support or even obtain it themselves if the DM deems it reasonable enough"));

                c.AddOrUpgradeAbility("Theft (Stealing)", "Theft (Stealing)",
                    "Their Theft gains more conceptualized allowing them to use it on thoughts, intentions, knowledge, ideals, attacks, memories and Dreams. The range has been increased to 80 meters.");

                c.ActiveAbilities.Add(new PathwayAbility("Theft (Thoughts)",
                    "As a reaction, or Theft Reaction, they can stop the target's action.\n" +
                    "Costs 3 Spirituality\n" +
                    "Must be done against the targets check\n" +
                    "The stolen thought will be executed on the user's next turn or if it's an action that can be done quickly enough like snapping your fingers it will be done at the moment. \n" +
                    "Intention can also be stolen turning someone shooting an air bullet into making the sound of a bullet."));

                c.ActiveAbilities.Add(new PathwayAbility("Theft (Knowledge)",
                    "They can temporarily for up to 10 minutes steal someone's knowledge.\n" +
                    "Reaction or theft reaction\n" +
                    "Costs 4 Spirituality\n" +
                    "This can only be done if the target has been decrypted to a sufficient degree and the decrypted information includes the knowledge that wants to be stolen.\n" +
                    "Rolls against the targets highest stat with the Dream Stealer gaining advantage"));

                c.ActiveAbilities.Add(new PathwayAbility("Theft (Attacks)",
                    "They can steal the attacks targeting them to nullify them. They won’t experience side effects unless the attack itself has side effects on the user.\n" +
                    "Costs 3 Spirituality\n" +
                    "They roll against the enemies attack with a Theft Reaction (not normal reaction) with disadvantage to steal the attack.\n" +
                    "They can perform the attack themselves on their next turn or subsequent ones by using their theft reaction and action."));

                c.AddOrUpgradeAbility("Theft (Ability-Stealing)", "Theft (Ability-Stealing)",
                    "The stolen beyonder power can now be used for half an hour or two combat encounters. \n" +
                    "They can now keep the power stored for a week and in that time the victim won’t regain the ability.\n" +
                    "Ability Stealing can also be performed with a Theft Reaction");

                c.AddOrUpgradeAbility("Theft (Item-Stealing)", "Theft (Item-Stealing)",
                    "They can now steal organs or fetuses and similar things.\n" +
                    "Attempting to Steal an Organ costs 6 Spirituality\n" +
                    "Costs a Main Action\n" +
                    "Stealing an organ is done with a -5 and disadvantage against the target's highest stat.\n" +
                    "Successfully stealing an Organ does percentual max hp dmg determined by the DM.");

                c.ActiveAbilities.Add(new PathwayAbility("Theft (Ideals)",
                    "They can target someone's ideals and make them lose motivation.\n" +
                    "Costs 5 Spirituality\n" +
                    "Main Action\n" +
                    "Rolls with double disadvantage against the target's highest Stat.\n" +
                    "The effect of successfully stealing is determined by the DM but at the minimum it does Sanity Damage and at the maximum makes someone advancing to Demigod fail their advancement."));

                c.AddOrUpgradeAbility("Decryption", "Decryption",
                    "Their decryption (Illusion) now works against even those of high sequence.\n" +
                    "Even if they don’t achieve a high result they can see through illusions below seq4 after 2 turns of decryption.\n" +
                    "Decrypting high sequence illusions takes 5 turns.");
            }

            if (c.CurrentSequence <= 4)
            {
                c.MaxHP *= 2;
                c.MaxSHP *= 2;
                c.MaxSpirituality *= 3;
                c.SleightOfHand += 3;
                c.Disguise += 3;
                c.Movement += 3;
                c.AC += 3;

                c.AddOrUpgradeAbility("Theft Reaction", "Theft Reaction", "Gains another Theft Reaction");

                c.ActiveAbilities.Add(new PathwayAbility("Avatars",
                    "Upon complete digestion, they can separate some of their Beyonder Characteristics and create Avatars which can operate independently from the main body.\n" +
                    "Low-level Avatars have the ability to use some of their higher Sequence powers. Still, certain matters regarding the use of high Sequence powers would take time.\n" +
                    "higher sequence powers only enjoy the bonus of the current sequences stat boosts\n" +
                    "Avatars possess the same kind of actions the main body has\n" +
                    "Avatars can absorb Error Pathway Beyonder Characteristics to enhance their level.\n" +
                    "Creating an Avatar that equals the main body in level could leave the mental state unstable and can make said Avatar rebel against them.\n" +
                    "They can create at most 5 Avatars upon drinking the potion and 8 upon full digestion\n" +
                    "Performing Actions together with an avatar gives Advantage per avatar used\n" +
                    "Expends the avatars Reactions to do this"));

                c.ActiveAbilities.Add(new PathwayAbility("Decryption (Assistance)",
                    "dc23+seq: They find out truths and locations as well as knowledge about targets (+2 to theft, +2 AC)\n" +
                    "dc28+seq: They find out many truths about locations and knowledge about targets (+3 theft, +3Ac)\n" +
                    "dc33+seq: They accurately decrypt the truth of many things(+4 theft, +4 AC)"));

                c.ActiveAbilities.Add(new PathwayAbility("Insect Physiology",
                    "As parts of a Parasite's body have been transformed into Insects, they will not actually die from attacks unless they are hit in a vital part of their body.\n" +
                    "To kill them an attack that does more than 30 dmg when they are at 1 HP needs to be unleashed"));

                c.AddOrUpgradeAbility("Theft(Stealing)", "Theft (Stealing)",
                    "They can now steal things such as life span which counts as valuable as well as peoples organs.");

                c.ActiveAbilities.Add(new PathwayAbility("Parasitism",
                    "This is a manifestation of Life Theft, Parasites can use Worms of Time to be a literal leech that can latch onto a target's Spirit Body, turning that target into their host.\n" +
                    "Main Action\n" +
                    "This ability has 2 modes:\n" +
                    "Concealed Mode: They can hide in the body of their target and see and hear everything their host sees and hears but cannot fully Control their host communication at this stage. This means the host has to speak vocally for communication.\n" +
                    "neither the host nor the parasite gain any stat boosts\n" +
                    "Their Stealing abilities on the host enjoy a bonus of +3 while in the host's body.\n\n" +
                    "This also grants them some level of Concealment abilities as Divinations that are directed at them will instead be obstructed by their host.\n" +
                    "Controlling Mode: They nearly fuse with their target's Spirit Body, enabling full Control over the body and understanding the target's thoughts and intentions and direct governance over the physical actions of the target.\n" +
                    "They get access to all of the targets beyonder abilities and stat boosts"));

                c.AddOrUpgradeAbility("Decryption", "Decryption",
                    "Their decryption is massively enhanced, not always enjoying advantage to all decryption checks as well as being higher rewarded by DMs upon successful decryptions.\n" +
                    "They now instantly crack lower sequence level illusions and only need 2-3 turns for sequence on the same level.");

                c.AddOrUpgradeAbility("Theft (Stealing)", "Theft (Stealing)",
                    "A parasite can now steal broader things like position, distance, or different aspects of life.\n" +
                    "If the parasite has a deep grasp on the situation and the targets sequence is lower than theirs they can steal whatever they want without needing to perform a check\n" +
                    "They can steal from a distance of 500 meters.\n" +
                    "Stealing from clones is considered as stealing from the main body making those things be stolen from them as well.\n" +
                    "They can now fit up to two Thefts into one reaction but they gain another disadvantage on the second Theft.");

                c.AddOrUpgradeAbility("Theft (Ability-Stealing)", "Theft (Ability-Stealing)",
                    "Even if they don’t know all the information the DM will present three abilities and name them that can be stolen.\n" +
                    "They can now steal up to 3 Abilities from the same target but only one per turn.\n" +
                    "Stealing on your turn and on the turn the enemy attacks you is counted as different turns\n" +
                    "They can now use the abilities for up to two hours\n" +
                    "They can now also steal general abilities such as walking, flying and seeing. This does count towards the three ability stealing limit.\n" +
                    "Abilities they steal only return after multiple weeks if not given back or used");

                c.AddOrUpgradeAbility("Theft (Item-Stealing)", "Theft (Item-Stealing)",
                    "They can now store away the items they have stolen and return them at a suitable time.\n" +
                    "Free Action");

                c.AddOrUpgradeAbility("Theft (Thoughts)", "Theft (Thoughts)",
                    "They no longer need to act out the actions. ");

                c.ActiveAbilities.Add(new PathwayAbility("Theft (Life)",
                    "They can steal someone's organs and other aspects of life like their breath.\n" +
                    "They will roll with only one disadvantage like usual.\n" +
                    "Main Action or Theft Reaction\n" +
                    "Theft Reaction like this has a -3 to the roll\n" +
                    "Costs 8 Spirituality\n" +
                    "Based on the thing stolen the DM has to determine the effects or damage dealt."));

                c.ActiveAbilities.Add(new PathwayAbility("Theft (Position/Distance)",
                    "They can steal someone's position replacing theirs with that person's or directly quickly traverse.\n" +
                    "Costs 8 Spirituality to use\n" +
                    "Extra Action or movement action\n" +
                    "To Position swap they roll against the target's highest ability with advantage. If the check is up to 2 lower their position swap succeeds.\n" +
                    "Stealing Distance is done via reaching a dc\n" +
                    "dc10: 150 Meters\n" +
                    "dc20: 300 Meters\n" +
                    "dc30: 500 Meters"));
            }
        }

            public static void ApplyDoorPathway(Character c)
            {
                if (c.CurrentSequence <= 9)
                {
                    c.MaxHP += 3;
                    c.MaxSHP += 2;
                    c.MaxSpirituality += 2;
                    c.Performance += 1;
                    c.AC += 1;
                    c.Movement += 2;

                    c.ActiveAbilities.Add(new PathwayAbility("Door Opening (Extra)",
                        "Apprentice possesses the ability to Open some things related to doors.\n" +
                        "Costs 1 Spirituality\n" +
                        "They can phase through walls and other big obstacles.\n" +
                        "Passing through none mystical objects and walls that are not out of conventional human standard will always result in automatic success\n" +
                        "Even if their connection to the spirit world is cut they can still use this ability.\n" +
                        "They can open any lock which doesn’t contain mystical powers, as well as a small number of locks that are reinforced with Beyonder effects.\n" +
                        "10+seq+performance\n" +
                        "Costs 1 Spirituality\n" +
                        "dc10: Open normal locks\n" +
                        "dc15: Open locks that are reinforced with low level beyonder effects"));
                }
                if (c.CurrentSequence <= 8)
                {
                    c.MaxHP += 4;
                    c.MaxSHP += 2;
                    c.MaxSpirituality += 2;
                    c.Performance += 2;
                    c.AC += 2;
                    c.Movement += 1;

                    c.ActiveAbilities.Add(new PathwayAbility("Trickmaster Spells",
                        "Trick masters can use many different kinds of relatively weak spells and spell-like abilities. Those abilities can be executed with 10+seq+performance\n\n" +
                        "--- Spells ---\n" +
                        "• Gas Transfer (Extra): Transfer toxic or harmful gases away or to a needed place. Costs 1 Spirituality. dc10: 8m, dc12: 11m, dc14: 15m.\n" +
                        "• Flash (Extra): Release a quick flash of light affecting vision. 10 meter range. Costs 2 Spirituality. dc10: -2 to hitting for 1 turn. dc14: -3 to hitting for 1 turn. dc16: -3 to hitting and -1 to perception for 1 turn.\n" +
                        "• Escape Trick (Reaction): Use multiple tricks to quickly and stealthily move around a target, dodging an attack (performance vs attack roll). Costs 2 Spirituality. Only works against non-aoe attacks.\n" +
                        "• Tumble (Extra): Coat a 5-6m radius with grease. Targets roll movement save DC 18 or stumble and have next roll disadvantaged. Costs 2 Spirituality.\n" +
                        "• Object Manipulation (Main): Bounce designated objects in a 5m radius (no precise operation). 10m range. Costs 2 Spirituality. If enemy steps into radius, take 4d2 dmg/turn. Hitting target requires -6 to hitting roll. 1d4 dmg per object. Max 5 objects.\n" +
                        "• Electric Shock (Main): Release shock through conductive medium. Range determined by medium (max 200m). Costs 3 Spirituality. Undodgeable. dc10: 1d8 dmg. dc15: 1d8 dmg + 4 charged. dc20: 1d8 dmg + 6 charged. Stuns next round if target <20 Max HP and max dmg rolled.\n" +
                        "• Freezing (Main): Rapid cooling effect via palm or ray. 10m range. Costs 2 Spirituality. Deals 1d8 dmg. dc10: 1 freeze stack. dc15: 2 freeze stacks. dc20: 3 freeze stacks.\n" +
                        "• Loud Noise (Extra): Create a massive sound. Costs 1 Spirituality. dc10: perception -1. dc15: perception -2. dc20: perception -3.\n" +
                        "• Black Curtain (Extra): Create a lightless curtain concealing objects. Costs 1 Spirituality. dc10: +2 stealth. dc15: +3 stealth. dc20: +4 stealth.\n" +
                        "• Burning (Extra): Ignite objects in 3m range. Costs 1 Spirituality. Thrown objects apply 1 burning stack.\n" +
                        "• Fog (Main): Generate fog blocking perception in 15m radius. Costs 3 Spirituality. Melee attacks disadvantaged, ranged attacks -5 and disadvantaged. dc10: perception -1. dc15: perception -2. dc20: perception -3 and disadvantaged.\n" +
                        "• Wind (Extra): Manifest level 7-8 gale up to 30m range. Costs 3 Spirituality. Enemy rolls against user or gets disadvantaged melee, ranged, perception, and movement."));
                }
                if (c.CurrentSequence <= 7)
                {
                    c.MaxHP += 7;
                    c.MaxSHP += 2;
                    c.Performance += 2;
                    c.Astrology += 2;
                    c.MaxSpirituality += 4;
                    c.Movement += 2;
                    c.AC += 1;

                    c.ActiveAbilities.Add(new PathwayAbility("Heightened Spiritual Intuition (Reaction)",
                        "Spirituality is massively increased allowing advanced divination and anti-divination, heightening spiritual intuition.\n" +
                        "10+seq+astrology\n" +
                        "Costs 2 Spirituality\n" +
                        "dc10: Know the extra action the enemy will take roughly (+1AC against that)\n" +
                        "dc15: Know both the extra actions the enemy will take roughly (+1 AC against them)\n" +
                        "dc20: Know the main action the enemy will take roughly (+1 AC against that)\n" +
                        "dc25: Know the main and one extra action roughly (+1AC)\n" +
                        "dc30: Know the main action or an extra action halfway accurately (+2AC)\n" +
                        "Danger intuition can be used as a reactionary action granting +1 AC at combat start."));

                    c.ActiveAbilities.Add(new PathwayAbility("Divination (Main/Extra)",
                        "Divine the location of things you have a connection to or people you have a possession of.\n" +
                        "10+seq+astrology\n" +
                        "Costs 5 Spirituality\n" +
                        "Divination for information increases DCs by 5.\n" +
                        "Can be interfered with or fail if a higher status individual is involved.\n" +
                        "dc10: Very rough image\n" +
                        "dc14: General outline\n" +
                        "dc19: Block level\n" +
                        "dc24: Street level\n" +
                        "dc29: House complex\n" +
                        "nat20: Exact location\n" +
                        "nat1: Target notices you if they have high spirituality, you fall into disarray, and may see things you shouldn't.\n" +
                        "Can overlap silhouettes of 2 people to determine if they are the same person (no dice check required)."));

                    c.ActiveAbilities.Add(new PathwayAbility("Anti-Divination (Extra/Reaction/Main)",
                        "Interfere with others' Divination and Spiritual Intuition within the surrounding area.\n" +
                        "10+seq+astrology\n" +
                        "Costs 4 Spirituality\n" +
                        "Roll against the person targeting you with divination; success causes their divination to fail. Status differences affect info gathered."));

                    c.AddOrUpgradeAbility("Door Opening", "Door Opening",
                        "Their ability to phase into obstacles has been enhanced.\n" +
                        "They can now bring other people with them.\n" +
                        "They can open tiny Doors in a wall in order to see inside of a room.");

                    c.ActiveAbilities.Add(new PathwayAbility("Spirit Vision",
                        "See non-physical things (ghosts, specters, Soul parts) and deduce health/emotions.\n" +
                        "While active, grants +1 to astrology."));
                }
                if (c.CurrentSequence <= 6)
                {
                    c.MaxHP += 8;
                    c.MaxSHP += 2;
                    c.Performance += 2;
                    c.Astrology += 2;
                    c.MaxSpirituality += 2;
                    c.Movement += 1;
                    c.AC += 2;

                    c.ActiveAbilities.Add(new PathwayAbility("Record (Extra/Reaction)",
                        "After witnessing a Beyonder power, attempt to Record its mystical symbols, storing it for a single use.\n" +
                        "Everything they can see is their range.\n" +
                        "Only one record (Reaction or Extra Action) per turn. Reaction counts for next turn.\n" +
                        "Costs 4 Spirituality to record. Recorded ability costs its original spirituality.\n" +
                        "Performed via 10+seq+performance.\n" +
                        "Limits: 1 Demigod level, 8 Seq 5-6, 20 Seq 7-9 abilities.\n" +
                        "Recording Seq 7 and below is guaranteed.\n" +
                        "Higher levels require a recording check against the target's highest ability check. For every level higher, gain 1 disadvantage and -2 to the roll.\n" +
                        "When a Seq 7 power is demonstrated by a Seq 5 and Recorded in a Seq 7 slot, it manifests at Seq 6 level.\n" +
                        "Power isn't equal: Equal/1 level higher = halved effects. 2 levels higher = 75% reduced. Lower levels = equal or slightly lower."));
                }
                if (c.CurrentSequence <= 5)
                {
                    c.MaxHP += 6;
                    c.MaxSHP += 4;
                    c.Performance += 2;
                    c.Astrology += 3;
                    c.MaxSpirituality += 3;
                    c.InstantActions += 1;
                    c.Movement += 3;
                    c.AC += 2;

                    c.ActiveAbilities.Add(new PathwayAbility("Traveler’s Door (Main)",
                        "Open a Door to the Spirit World and travel there while sensing the real world. Long distance teleportation.\n" +
                        "Max distance 1800 km without rest. Cannot exceed in a single instance.\n" +
                        "Costs 10 Spirituality\n" +
                        "10+seq+astrology\n" +
                        "dc10: 500 km\n" +
                        "dc15: 1000 km\n" +
                        "dc20: 1500 km\n" +
                        "dc25: 1800 km"));

                    c.ActiveAbilities.Add(new PathwayAbility("Blink",
                        "Short distance Traveling that leaves afterimages.\n" +
                        "• Blink (Reaction): React to an attack/move to avoid effects. Costs 5 Spirit. 10+seq+performance vs enemy check. On success, can follow up with Instant Action attack.\n" +
                        "• Blink (State): Grants +5 Movement and +10 AC. Costs 8 Spirit to enter, 3 to upkeep. If hit, perform 10+seq+performance (DC 26) to remain in state. If an enemy misses, use a Blink Action to instantly strike back with an ability. Using an Action/Blink Action this way increases Spirit cost by 2 (consumes next turn's action)."));

                    c.ActiveAbilities.Add(new PathwayAbility("Positioning (Passive)",
                        "Travelers identify exactly where they are. Intuitive sense of direction in Spirit World (never get lost/injured coming out).\n" +
                        "Unaffected by illusions confusing direction.\n" +
                        "No negative effects from terrain affecting position/movement."));

                    c.ActiveAbilities.Add(new PathwayAbility("Invisible Hand (Main/Instant)",
                        "Capture objects or people from a distance.\n" +
                        "10+seq+performance\n" +
                        "Costs 3 Spirituality\n" +
                        "Stronger target = less drag distance.\n" +
                        "Equal Sequence: roll against highest enemy check to drag.\n" +
                        "1 Sequence lower: 100 Meters\n" +
                        "Below that: 300 meters (Max distance)"));

                    c.AddOrUpgradeAbility("Record", "Record",
                        "Beyonder abilities below sequence 4 lose their effectiveness reduction. Sequence 4 unleashes 80% strength, Sequence 3 unleashes 60%.\n" +
                        "Can Record up to 4 Demigod Abilities.");
                }
                if (c.CurrentSequence <= 4)
                {
                    c.MaxHP *= 2;
                    c.MaxSHP *= 2;
                    c.MaxSpirituality *= 3;
                    c.Performance += 4;
                    c.Astrology += 4;
                    c.InstantActions += 1;
                    c.Movement += 4;
                    c.AC += 3;

                    c.ActiveAbilities.Add(new PathwayAbility("Spirituality (Passive)",
                        "Quickly break through Illusions and are warned of demigod level illusions.\n" +
                        "Automatically break through illusions after 2 turns of a demigod illusion, or instantly through a below demigod one."));

                    c.ActiveAbilities.Add(new PathwayAbility("Space Concealment (Main)",
                        "Split a targeted area into 2 to create a Concealed space (50m diameter), only accessible through a specific Door.\n" +
                        "Every Concealed Space must have a Door (exit/observe).\n" +
                        "Can create a Mystical Item housing a small concealed space.\n" +
                        "10+seq+astrology/performance\n" +
                        "Costs 8 Spirituality\n" +
                        "dc10: conceal from Seq 6\n" +
                        "dc14: conceal from Seq 5\n" +
                        "dc26: conceal from Seq 4\n" +
                        "dc30: conceal from Seq 3"));

                    c.ActiveAbilities.Add(new PathwayAbility("Transfiguration (Main)",
                        "Transform into one illusory Door after another, layering infinitely to make attacks never reach them.\n" +
                        "Costs 15 Spirituality\n" +
                        "State: Harder to attack, abilities significantly weaker if hit. Cannot attack, must stay at least 2 turns. +12 AC and 90% dmg reduction.\n" +
                        "No actions/reactions can be used. Extra actions limitedly employed."));

                    c.ActiveAbilities.Add(new PathwayAbility("Secret Keeping (Extra/Reaction)",
                        "Conceal Secrets, block intuition, or become a Secret by shattering a crystal ball.\n" +
                        "Massively enhances anti-divination.\n" +
                        "Costs 7 Spirituality\n" +
                        "dc15: Divination DC +6\n" +
                        "dc20: Divination DC +9\n" +
                        "dc25: Divination DC +12\n" +
                        "dc30: Divination DC +12 and disadvantage"));

                    c.ActiveAbilities.Add(new PathwayAbility("Exile (Main)",
                        "Exile a target under control into a chaotic space behind a manifested illusory Door.\n" +
                        "Exiles for 3 turns. Max level is Seq 3 (removes one Extra Action from an Angel).\n" +
                        "Costs 14 Spirituality\n" +
                        "10+seq+astrology\n" +
                        "After duration, target appears at your side. Exiled Space contains dangerous/opportune doors determined by DM."));

                    c.AddOrUpgradeAbility("Record", "Record",
                        "Demigod level recorded powers retain full strength. Seq 5 is guaranteed.\n" +
                        "Recording Demigod/Saint abilities has no disadvantage.\n" +
                        "Angel: Disadvantage 2 and -5.\n" +
                        "KoA: Disadvantage 4 and -10.\n" +
                        "Demigod/Saint = 100% / 80% power. Angel = 20% power. KoA = 1% power.\n" +
                        "Record (State): Can record states (e.g., sun halo buff). Drains Spirituality continuously when used.");

                    c.AddOrUpgradeAbility("Door Opening", "Door Opening",
                        "They can use this to open up certain restrictions on their recording abilities by rolling against the restrictions. Only works against beyonders below angel level.");

                    c.AddOrUpgradeAbility("Traveler’s Door", "Traveler's Door",
                        "Their traveling ability and Blink have been greatly enhanced making them almost uncatchable among demigods. \n" +
                        "• Traveling: max distance per dc is increased by 3000km.\n" +
                        "• Blink: While they are in Blinking state, they could use various different Beyonder powers at a speed faster than normal; however, they cannot sustain this for too long.\n" +
                        "   • Costs 6 Spirituality per turn to upkeep this version.\n" +
                        "   • They can now use Instant Actions instead of Actions while in Blink State.\n" +
                        "   • Using a Blink Action costs 6 extra Spirituality.\n" +
                        "   • While in this Blink state Instant Actions regenerate at turn start.\n" +
                        "   • Blink(Reaction): Can now also be used to avoid mental attacks.");

                    c.ActiveAbilities.Add(new PathwayAbility("Worms of Stars",
                        "Secrets Sorcerers can negate some mental attacks by dividing the burden across their Worms of Star, while leaving some of them still in control of their bodies\n" +
                        "To make this work effectively they need to use a mental Beyonder power like Hypnosis to support them, enabling them to divide the burden without having to do it manually.\n" +
                        "While using this ability the Sanity damage they take is reduced by 8.\n" +
                        "Unless hypnosis is used it has to be used as a reactionary action\n"));
                }
            }
    }
}
