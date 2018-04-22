using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SecretDyes.Dyes
{
	public class PlaidDye : ModItem
	{
        public override string Texture {
            get {
                return "Terraria/Item_" + ItemID.BrownDye;
            }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plaid Dye");
            Tooltip.SetDefault("Quite the fashion statement");
        }

		public override void SetDefaults()
		{
			item.dye = 1; //Allows dye to be equipped
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			//recipe: 1 Strange Plant, 1 Red Dye, 1 Green Dye
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.DyeVat);
			recipe.AddRecipeGroup("SecretDyes:AnyStrangePlant");
			recipe.AddIngredient(ItemID.RedDye);
			recipe.AddIngredient(ItemID.GreenDye);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

