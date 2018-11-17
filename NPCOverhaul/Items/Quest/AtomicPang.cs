using Terraria.ID;
using Terraria.ModLoader;

namespace NPCOverhaul.Items.Quest
{
    public class AtomicPang : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Atomic Pang");
            Tooltip.SetDefault("This coin was crafted with passion and lots of effort. No wonder there aren't many of them.");
        }
        public override void SetDefaults()
        {


            item.width = 40;
            item.height = 40;
            item.rare = 4;
        }

       
    }
}
