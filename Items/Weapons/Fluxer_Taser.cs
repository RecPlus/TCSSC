
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Fluxer_Taser : ModItem
{
	
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fluxer Taser");
			Tooltip.SetDefault("'250.000V High Quality Taser.'\nHas a chance to electrocute your enemies");
		}
    public override void SetDefaults()
    {
       item.damage = 550;
        item.melee = true;
        item.width = 32;
        item.height = 32;
        item.useTime = 30;
        item.useAnimation = 30;
        item.useStyle = 3;
        item.knockBack = 5;
        item.value = 500000;
        item.rare = 8;
        item.UseSound = SoundID.Item1;
		item.shoot = mod.ProjectileType("nothing");
		item.shootSpeed = 4f;
        item.autoReuse = true;
    }
	
	    public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2) // Right Click function
            {
				item.useStyle = 1;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 550;
				item.knockBack = 3;
                item.useTime = 5;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 100;
				item.shoot = mod.ProjectileType("Gamma_Ray");
                item.shootSpeed = 10f;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 550;
				item.knockBack = 5;
                item.useTime = 30;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 4f;
                item.useAnimation = 30;
            }
		         return base.CanUseItem(player);
        }
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
			{
	item.shoot = 459;
		{
						player.AddBuff(mod.BuffType("highboost"), 120);
						player.AddBuff(21, 300);
		}
			}
			
					public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 2 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("nothing"), damage, knockBack, player.whoAmI);
			}
			return false;
		}
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 226);
			}
		}
}}