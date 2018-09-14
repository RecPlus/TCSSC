using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Moosy_Sword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moosy Sword");
		}
    public override void SetDefaults()
    {
        item.damage = 7;
        item.melee = true;
        item.width = 32;
        item.height = 32;
        item.useTime = 20;
        item.useAnimation = 20;
        item.useStyle = 3;
        item.knockBack = 5;
        item.value = 150;
        item.rare = 0;
        item.UseSound = SoundID.Item1;
        item.autoReuse = true;
    }
	
	public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("tinyboost"), 120);
			player.AddBuff(21, 400);
		}

}}