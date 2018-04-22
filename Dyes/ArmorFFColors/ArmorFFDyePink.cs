using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SecretDyes.Dyes
{
	public class ArmorFFDyePink : ModItem
	{
		public override string Texture {
			get {
				return "Terraria/Item_" + ItemID.MartianArmorDye;
			}
		}

		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Forcefield Dye (Pink)");
			Tooltip.SetDefault("Alien technology never felt\nso cool and so useless.");
		}

		public override void SetDefaults()
		{
			item.dye = 1; //Allows dye to be equipped
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.DyeVat);
			recipe.AddIngredient(mod.ItemType("ArmorFFDye"));
			recipe.AddIngredient(ItemID.PinkDye);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

