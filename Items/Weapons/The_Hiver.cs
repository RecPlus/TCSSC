using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class The_Hiver : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Khive");
			Tooltip.SetDefault("'This knife hides a small bee hive in the handle\nSecondary attack: Throws a bee swarm");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 15000;
        item.rare = 3;
			item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 30;
				item.knockBack = 3;
                item.useTime = 13;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 13;
				item.mana = 0;
    }
	
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("lowboost"), 120);
			player.AddBuff(21, 600);
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
				item.autoReuse = false;
				item.melee = true;
				item.damage = 20;
				item.knockBack = 0;
                item.useTime = 50;
				item.UseSound = SoundID.Item1;
				item.shoot = 181;
				item.shootSpeed = 7f;
                item.useAnimation = 50;
				item.noUseGraphic = true;
				item.noMelee = true;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 30;
				item.knockBack = 3;
                item.useTime = 13;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 13;
				item.noUseGraphic = false;
				item.noMelee = false;
            }
		         return base.CanUseItem(player);
        }
		
				public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(3);
			for (int i = 3; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
}}	