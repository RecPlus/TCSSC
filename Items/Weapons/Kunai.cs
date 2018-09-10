using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Kunai : ModItem
{
	
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kunai");
			Tooltip.SetDefault("'Bones Lee secret weapon'\nChance to throw a boomerang kunai when hitting an enemy\nSecondary attack: Throwing Kunais");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 650000;
        item.rare = 8;
						item.autoReuse = true;
				item.melee = true;
				item.damage = 120;
				item.knockBack = 1;
                item.useTime = 12;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 10f;
                item.useAnimation = 12;
				item.noUseGraphic = false;
				item.noMelee = false;
    }
	
	public override bool AltFunctionUse(Player player)
        {
            return true;
        }
	
	    public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2) // Right Click function
            {
				item.useStyle = 1;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 80;
				item.knockBack = 3;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 20;
				item.shoot = mod.ProjectileType("KunaiII");
                item.shootSpeed = 10f;
				item.noUseGraphic = true;
				item.noMelee = true;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 120;
				item.knockBack = 1;
                item.useTime = 12;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 10f;
                item.useAnimation = 12;
				item.noUseGraphic = false;
				item.noMelee = false;
            }
		         return base.CanUseItem(player);
        }
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
			{
	item.shoot = mod.ProjectileType("KunaiP");
	item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 1;
		{
			player.AddBuff(mod.BuffType("highboost"), 120);
			player.AddBuff(21, 700);
		}
			}
			
					public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 1 + Main.rand.Next(1);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(0)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("nothing"), damage, knockBack, player.whoAmI);
			}
			return false;
		}
}}