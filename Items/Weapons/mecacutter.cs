using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class mecacutter : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mecha Laserbeam Cutter");
			Tooltip.SetDefault("Secondary attack: Fires lasers quickly");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 1000000;
        item.rare = 6;
						item.autoReuse = true;
				item.melee = true;
				item.damage = 110;
				item.knockBack = 2;
                item.useTime = 13;
				item.UseSound = SoundID.Item15;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 13;
    }
	
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("midboost"), 120);
			player.AddBuff(21, 900);
		}
	
		 public override bool AltFunctionUse(Player player)
        {
            return true;
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
				item.damage = 110;
				item.knockBack = 2;
                item.useTime = 13;
				item.UseSound = SoundID.Item15;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 13;
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
}}