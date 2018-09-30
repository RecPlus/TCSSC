using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Buffs
{
	public class Solar_Boost : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Solar Boost");
			Description.SetDefault("Increases Life regen and defense\nIf player has 200HP or lower, these values duplicates");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
	    player.statDefense += 10;  
		player.lifeRegen = 7;
		if (player.statLife <= 200)
		{
		 player.statDefense += 20;  
		player.lifeRegen = 14;
		Dust.NewDust(player.position, player.width, player.height, 228);
		}
		}
	}
}	