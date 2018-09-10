using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class sacrificedagger : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Cultistm Sacrifice Dagger");
			Tooltip.SetDefault("'An essential tool in lizards sacrifices'");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 500000;
        item.rare = 8;
		item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 115;
				item.knockBack = 2;
                item.useTime = 8;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 8;
    }
	
	    public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2) // Right Click function
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 36;
				item.knockBack = 3;
                item.useTime = 8;
				item.UseSound = SoundID.Item15;
                item.useAnimation = 8;
				item.shoot = 389;
                item.shootSpeed = 6f;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 115;
				item.knockBack = 2;
                item.useTime = 8;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 8;
            }
		         return base.CanUseItem(player);
        }
		
						public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 6);
			}
		}
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(24, 1200);
				player.AddBuff(mod.BuffType("highboost"), 60);
			player.AddBuff(21, 600);
		}
}}