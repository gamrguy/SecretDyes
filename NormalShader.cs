using Microsoft.Xna.Framework;
using ShaderLib;

namespace SecretDyes
{
	public class NormalShader : ModArmorShaderData
	{
		public override bool Autoload() => false;

		private string _name;
		public override string Name => _name;

		public NormalShader() { }

		public NormalShader(string name, string passName, Color c) {
			_name = name;
			PassName = passName;
			Primary = c;
		}
	}
}