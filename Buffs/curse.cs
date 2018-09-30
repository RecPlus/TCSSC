using Terraria;
using Terraria.ModLoader;

namespace TCSSC.Buffs
{
	public class curse : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Dragon's Curse");
			Description.SetDefault("Extreme power at cost of your life");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			
		player.lifeRegen = -200;
		player.meleeDamage = 10f;
		for (int d = 0; d < 70; d++)
{
	Dust.NewDust(player.position, player.width, player.height, 269, 0f, 0f, 150);
	Dust.NewDust(player.position, player.width, player.height, 275, 0f, 0f, 150);
}
		}
	}
}	