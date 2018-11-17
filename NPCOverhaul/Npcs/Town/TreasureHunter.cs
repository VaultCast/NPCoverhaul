using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace NPCOverhaul.Npcs.Town
{
    [AutoloadHead]
    public class TreasureHunter : ModNPC
    {
        public override string Texture
        {
            get
            {
                return "NPCOverhaul/Npcs/Town/TreasureHunter";
            }
        }
        public override bool Autoload(ref string name)
        {
            name = "Treasure Hunter";
            return mod.Properties.Autoload;
        }
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 20;
            
        }
        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (player.active)
                {
                    for (int j = 0; j < player.inventory.Length; j++)
                    {
                        if (player.inventory[j].type == mod.ItemType("DirtyMap"))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)
        {
            return true;
        }
        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(4))
            {
                case 0:
                    return "Dave";
                case 1:
                    return "John";
                case 2:
                    return "Jacob";
                default:
                    return "Josh";
            }
        }
        public override string GetChat()
        {
            int demoMan = NPC.FindFirstNPC(NPCID.Demolitionist);
            if (demoMan >= 0 && Main.rand.NextBool(4))
            {
                return "Can you get " + Main.npc[demoMan].GivenName + " to lend me some bombs? There's a chest I can't get to.";
            }
            switch (Main.rand.Next(3))
            {
                case 0:
                    return "That map you got might lead to some treasure!";
                case 1:
                    return "I know the caves like the back of my hand!";
                default:
                    return "Thanks for giving me a place to stay. It really helps.";
            }
        }
        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Shop";
            button2 = "Treasure";
            
        }
        
        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
         
            if (firstButton)
            {
                shop = true;
            }
            else
            {
                Main.npcChatText = "Hey bud, can you find a coin looking thing for me?  It has an atomic sign engraved on it.";
                if (Main.LocalPlayer.HasItem(mod.ItemType("AtomicPang")))
                {
                    Main.npcChatText = "Thanks for finding this! Please take this as payment. Now off to study this in 3DSmax!";
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OlReliable"));
                }
            }
        }
        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.Chest);
            nextSlot++;
            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("OlReliable"));
                nextSlot++;
            }
        }
    }
}
