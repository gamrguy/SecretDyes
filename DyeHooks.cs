using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Shaders;
using ShaderLib;

namespace SecretDyes
{
	class DyeHooks : GlobalShader
	{
		public override int ItemInventoryShader(Item item, SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale) {
			return item.modItem != null && item.modItem.mod.Name == Mod.Name ? GameShaders.Armor.GetShaderIdFromItemId(item.type) : 0;
		}

		public override int ItemWorldShader(Item item, SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI) {
			return item.modItem != null && item.modItem.mod.Name == Mod.Name ? GameShaders.Armor.GetShaderIdFromItemId(item.type) : 0;
		}
	}
}
