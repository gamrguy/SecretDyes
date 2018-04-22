using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SecretDyes.Dyes
{
	public class ArmorFFDye : ModItem
	{
        public override string Texture {
            get {
                return "Terraria/Item_" + ItemID.MartianArmorDye;
            }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forcefield Dye");
            Tooltip.SetDefault("Alien technology never felt\nso cool and so useless.");
        }

		public override void SetDefaults()
		{
			item.dye = 1; //Allows dye to be equipped
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			//recipe: 1 Strange Plant, 1 Martian Dye, 5 Conduit Plating
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.DyeVat);
			recipe.AddRecipeGroup("SecretDyes:AnyStrangePlant");
			recipe.AddIngredient(ItemID.MartianArmorDye);
			recipe.AddIngredient(ItemID.MartianConduitPlating, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

