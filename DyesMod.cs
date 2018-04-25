using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ShaderLib;
using SecretDyes.Dyes;

namespace SecretDyes
{
	public class DyesMod : Mod
	{
        public override void Load()
        {
			ShaderLoader.RegisterMod(this);

			if(Main.netMode != NetmodeID.Server) {
				ShaderLoader.AddModArmorShaderData(new NormalShader("SilverTrimShader", "ArmorSilverTrim", Color.White), this, ItemType<SilverTrimDye>());
				ShaderLoader.AddModArmorShaderData(new NormalShader("PlaidShader", "ArmorPlaid", Color.White), this, ItemType<PlaidDye>());

				ShaderLoader.AddModArmorShaderData(new NormalShader("ForceFieldShader", "ArmorForceField", new Color(0f, 0.9f, 1.0f)), this, ItemType<ArmorFFDye>());
				ShaderLoader.AddModArmorShaderData(new NormalShader("ForceFieldShaderRed", "ArmorForceField", new Color(1.0f, 0f, 0f)), this, ItemType<ArmorFFDyeRed>());
				ShaderLoader.AddModArmorShaderData(new NormalShader("ForceFieldShaderGreen", "ArmorForceField", new Color(0f, 1.0f, 0f)), this, ItemType<ArmorFFDyeGreen>());
				ShaderLoader.AddModArmorShaderData(new NormalShader("ForceFieldShaderBlue", "ArmorForceField", new Color(0f, 0f, 1.0f)), this, ItemType<ArmorFFDyeBlue>());
				ShaderLoader.AddModArmorShaderData(new NormalShader("ForceFieldShaderWhite", "ArmorForceField", new Color(1.0f, 1.0f, 1.0f)), this, ItemType<ArmorFFDyeWhite>());
				ShaderLoader.AddModArmorShaderData(new NormalShader("ForceFieldShaderPink", "ArmorForceField", new Color(1.0f, 0.1f, 0.5f)), this, ItemType<ArmorFFDyePink>());
				ShaderLoader.AddModArmorShaderData(new NormalShader("ForceFieldShaderPurple", "ArmorForceField", new Color(0.5f, 0f, 1.0f)), this, ItemType<ArmorFFDyePurple>());
			}
		}

		public override void AddRecipeGroups()
		{
			//Creates a recipe group for the four Strange Plant items.
			RecipeGroup group = new RecipeGroup(() => Language.GetText("Any") + " " + Lang.GetItemName(ItemID.StrangePlant1), new int[]
				{
					ItemID.StrangePlant1,
					ItemID.StrangePlant2,
					ItemID.StrangePlant3,
					ItemID.StrangePlant4
				});
			RecipeGroup.RegisterGroup("SecretDyes:AnyStrangePlant", group);
		}
	}
}