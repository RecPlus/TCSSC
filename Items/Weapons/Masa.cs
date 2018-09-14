using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Masa : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Masa");
		}
    public override void SetDefaults()
    {
        item.damage = 13;
        item.melee = true;
        item.width = 16;
        item.height = 16;
        item.useTime = 6;
        item.useAnimation = 6;
        item.useStyle = 3;
        item.knockBack = 0;
        item.value = 10000;
        item.rare = 2;
        item.UseSound = SoundID.Item1;
        item.autoReuse = true;
		item.shoot = mod.ProjectileType("nothing");
    }
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 29);
			}
		}
	
	public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(31, 60);
			player.AddBuff(mod.BuffType("lowboost"), 180);
			player.AddBuff(21, 900);
		}

}}