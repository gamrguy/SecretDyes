using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SecretDyes.Dyes
{
	public class SilverTrimDye : ModItem
	{
		public override string Texture {
			get {
				return "Terraria/Item_" + ItemID.SilverDye;
			}
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silver Trim Dye");
			Tooltip.SetDefault("Like those 'and Silver' dyes, but\n without the preceding color.");
		}

		public override void SetDefaults()
		{
			item.dye = 1; //Allows dye to be equipped
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			//recipe: 1 Strange Plant, 1 Silver and Black Dye, 1 Silver Dye
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.DyeVat);
			recipe.AddRecipeGroup("SecretDyes:AnyStrangePlant");
			recipe.AddIngredient(ItemID.SilverAndBlackDye);
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

