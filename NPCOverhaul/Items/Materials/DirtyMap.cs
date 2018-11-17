using Terraria.ID;
using Terraria.ModLoader;

namespace NPCOverhaul.Items.Materials
{
	public class DirtyMap : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dirty Map");
			Tooltip.SetDefault("Someone might find this useful.");
		}
		public override void SetDefaults()
		{
			
			
			item.width = 40;
			item.height = 40;
			item.rare = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TatteredCloth, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
