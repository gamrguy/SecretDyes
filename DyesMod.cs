using System;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ShaderLib;
using ShaderLib.Shaders;
using SecretDyes.Dyes;

namespace SecretDyes
{
	public class DyesMod : Mod
	{
        public override void Load()
        {
			ShaderLoader.RegisterMod(this);

			GameShaders.Armor.BindShader(ItemType<DevDye>(), new ArmorShaderData(ShaderLibMod.shaderRef, "ArmorDev"));
			GameShaders.Armor.BindShader(ItemType<SilverTrimDye>(), new ArmorShaderData(ShaderLibMod.shaderRef, "ArmorSilverTrim"));
			GameShaders.Armor.BindShader(ItemType<PlaidDye>(), new ArmorShaderData(ShaderLibMod.shaderRef, "ArmorPlaid"));

			GameShaders.Armor.BindShader(ItemType<ArmorFFDye>(), new ArmorShaderData(ShaderLibMod.shaderRef, "ArmorForceField").UseColor(0f, 0.9f, 1.0f));
			GameShaders.Armor.BindShader(ItemType<ArmorFFDyeRed>(), new ArmorShaderData(ShaderLibMod.shaderRef, "ArmorForceField").UseColor(1.0f, 0f, 0f));
			GameShaders.Armor.BindShader(ItemType<ArmorFFDyeGreen>(), new ArmorShaderData(ShaderLibMod.shaderRef, "ArmorForceField").UseColor(0f, 1.0f, 0f));
			GameShaders.Armor.BindShader(ItemType<ArmorFFDyeBlue>(), new ArmorShaderData(ShaderLibMod.shaderRef, "ArmorForceField").UseColor(0f, 0f, 1.0f));
			GameShaders.Armor.BindShader(ItemType<ArmorFFDyeWhite>(), new ArmorShaderData(ShaderLibMod.shaderRef, "ArmorForceField").UseColor(1.0f, 1.0f, 1.0f));
			GameShaders.Armor.BindShader(ItemType<ArmorFFDyePink>(), new ArmorShaderData(ShaderLibMod.shaderRef, "ArmorForceField").UseColor(1.0f, 0.1f, 0.5f));
			GameShaders.Armor.BindShader(ItemType<ArmorFFDyePurple>(), new ArmorShaderData(ShaderLibMod.shaderRef, "ArmorForceField").UseColor(0.5f, 0f, 1.0f));
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