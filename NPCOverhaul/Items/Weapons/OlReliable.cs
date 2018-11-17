using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NPCOverhaul.Items.Weapons
{
    public class OlReliable : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ol' Reliable");
            Tooltip.SetDefault("This gun has brought great service to the Treasure Hunter over the years.");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 5000;
            item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10; 
            item.shootSpeed = 16f;
            item.useAmmo = AmmoID.Bullet;
        }

       
    }
}