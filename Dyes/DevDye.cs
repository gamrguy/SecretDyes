using Terraria.ID;
using Terraria.ModLoader;

namespace SecretDyes.Dyes
{
	public class DevDye : ModItem
	{
		public override string Texture => "Terraria/Item_" + ItemID.ReflectiveGoldDye;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Devious Dye");
			Tooltip.SetDefault("Quite shifty!");
		}

		public override void SetDefaults()
		{
			item.dye = 1; //Allows dye to be equipped
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			//recipe: 1 Strange Plant, 1 Shifting Sands Dye, 5 Crystal Blocks
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.DyeVat);
			recipe.AddRecipeGroup("SecretDyes:AnyStrangePlant");
			recipe.AddIngredient(ItemID.ShiftingSandsDye);
			recipe.AddIngredient(ItemID.CrystalBlock, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

