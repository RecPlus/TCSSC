using Terraria;
using Terraria.ModLoader;

namespace TCSSC.Buffs
{
	public class titaniumskin : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Titanium Skin");
			Description.SetDefault("Increase defense by 50");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
		player.statDefense += 50;  
		}
	}
}	