using Terraria;
using Terraria.ModLoader;

namespace TCSSC.Buffs
{
	public class regen : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Stringe Life Drain");
			Description.SetDefault("Increases life regen");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
		player.lifeRegen = 25;
		}
	}
}	