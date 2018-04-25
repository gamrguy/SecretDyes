using Terraria;
using Terraria.DataStructures;
using ShaderLib;
using SecretDyes.Dyes;

namespace SecretDyes
{
	public class PulsatingRainbowShader : ModArmorShaderData
	{
		public override int? BoundItemID => Mod.ItemType<ArmorFFDyeRainbow>();

		public PulsatingRainbowShader() {
			PassName = "ArmorForceField";
		}

		public override void PreApply(Entity e, DrawData? drawData) {
			Primary = Main.DiscoColor;
		}
	}
}