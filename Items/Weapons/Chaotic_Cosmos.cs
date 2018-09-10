using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Chaotic_Cosmos : ModItem
{
	
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chaotic Cosmos");
			Tooltip.SetDefault("'A big worm from a danger world drops that sword'\nFires Gamma Rays on use\nFires cosmic devourers on hit");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 650000;
        item.rare = 10;
						item.autoReuse = true;
				item.melee = true;
				item.damage = 450;
				item.knockBack = 0;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 7f;
                item.useAnimation = 20;
    }
	
	    public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2) // Right Click function
            {
				item.useStyle = 1;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 300;
				item.knockBack = 3;
                item.useTime = 5;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 100;
				item.shoot = mod.ProjectileType("Gamma_Ray");
                item.shootSpeed = 10f;
				item.mana = 100;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 450;
				item.knockBack = 0;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 5f;
                item.useAnimation = 20;
				item.mana = 0;
            }
		         return base.CanUseItem(player);
        }
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
			{
	item.shoot = mod.ProjectileType("Shadow_Eater");
		{
			player.AddBuff(mod.BuffType("supboost"), 120);
			player.AddBuff(21, 700);
		}
			}
			
					public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 2 + Main.rand.Next(50);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("Gamma_Ray"), damage, knockBack, player.whoAmI);
			}
			return false;
		}
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 65);
			}
		}
}}