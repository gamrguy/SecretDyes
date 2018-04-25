using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using SecretDyes.Dyes;
using ShaderLib;

namespace SecretDyes
{
	public class DevShader : ModArmorShaderData
	{
		public override int? BoundItemID => Mod.ItemType<DevDye>();

		public DevShader() {
			PassName = "ArmorDev";
		}

		public override void Apply(Entity e, DrawData? drawData) {
			// This is mostly vanilla code, with some irrelevant parts cut out.
			// The most important part is that "uDirection" is always 1, letting the shader stay the same direction.
			Shader.Parameters["uTime"].SetValue(Main.GlobalTime);
			Shader.Parameters["uOpacity"].SetValue(Opacity);
			if(drawData.HasValue) {
				DrawData value = drawData.Value;
				Vector4 value2;
				if(value.sourceRect.HasValue) {
					value2 = new Vector4(value.sourceRect.Value.X, value.sourceRect.Value.Y, value.sourceRect.Value.Width, value.sourceRect.Value.Height);
				} else {
					value2 = new Vector4(0f, 0f, value.texture.Width, value.texture.Height);
				}
				Shader.Parameters["uSourceRect"].SetValue(value2);
				Shader.Parameters["uWorldPosition"].SetValue(Main.screenPosition + value.position);
				Shader.Parameters["uImageSize0"].SetValue(new Vector2((float)value.texture.Width, (float)value.texture.Height));
				Shader.Parameters["uRotation"].SetValue(value.rotation * (value.effect.HasFlag(SpriteEffects.FlipHorizontally) ? -1f : 1f));
				Shader.Parameters["uDirection"].SetValue(1);
			} else {
				Shader.Parameters["uSourceRect"].SetValue(new Vector4(0f, 0f, 4f, 4f));
				Shader.Parameters["uRotation"].SetValue(0f);
			}
			if(e != null) {
				Shader.Parameters["uDirection"].SetValue(1);
			}

			Shader.CurrentTechnique.Passes["ArmorDev"].Apply();
		}
	}
}