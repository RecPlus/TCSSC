using Terraria;
using Terraria.ModLoader;

namespace TCSSC.Buffs
{
	public class supboost : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Supreme Boost");
			Description.SetDefault("200 Defense Boost");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
		player.statDefense += 200;  
		}
	}
}	