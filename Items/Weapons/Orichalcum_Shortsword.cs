using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Orichalcum_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orichalcum Shortsword");
			Tooltip.SetDefault("Secondary attack: Fires powerful petals that push the enemies a lot");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 250000;
        item.rare = 4;
			item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 87;
				item.knockBack = 3;
                item.useTime = 21;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 21;
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
				item.autoReuse = false;
				item.melee = true;
				item.damage = 30;
				item.knockBack = 25;
                item.useTime = 35;
				item.UseSound = SoundID.Item1;
				item.shoot = 221;
				item.shootSpeed = 30f;
                item.useAnimation = 35;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 87;
				item.knockBack = 3;
                item.useTime = 21;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 21;
            }

		         return base.CanUseItem(player);
        }
		
					
				public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("midboost"), 120);
			player.AddBuff(21, 900);
		}
		
						public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 2 + Main.rand.Next(1);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
		
	
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(1191, 6);
        recipe.SetResult(this);                     
	recipe.AddTile(134);
        recipe.AddRecipe();
	}
}}	