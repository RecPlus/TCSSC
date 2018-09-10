using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class rainbow : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Rainbow Knife");
			Tooltip.SetDefault("Secondary attack: Fires colourful lasers");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 750000;
        item.rare = 10;
					item.autoReuse = true;
				item.melee = true;
				item.damage = 450;
				item.knockBack = 0;
                item.useTime = 15;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 15;
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
				item.damage = 80;
				item.knockBack = 3;
                item.useTime = 9;
				item.shoot = mod.ProjectileType("Death_Ray");
				item.shootSpeed = 7f;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 9;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 450;
				item.knockBack = 0;
                item.useTime = 15;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 15;
            }
		         return base.CanUseItem(player);
        }
		
				public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(4);
			for (int i = 3; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
	    }
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 59);
				
			}
			if (Main.rand.Next(4) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 60);
			}
			if (Main.rand.Next(5) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 61);
			}
			if (Main.rand.Next(2) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 62);
			}
			if (Main.rand.Next(1) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 63);
			}
		}
		
			 public override void AddRecipes()                
    {       
		     ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(null, "Blood_Shortsword");
recipe.AddIngredient(null, "Brilliant_Dagger");
recipe.AddIngredient(null, "mecacutter");
recipe.AddIngredient(null, "sacrificedagger");
recipe.AddIngredient(null, "nightmare");
recipe.AddIngredient(3458, 10);
recipe.AddIngredient(1570);
        recipe.SetResult(this);                     
	recipe.AddTile(412);
        recipe.AddRecipe();
		
			     recipe = new ModRecipe(mod);                 
recipe.AddIngredient(null, "Blood_Shortsword");
recipe.AddIngredient(null, "Brilliant_Dagger");
recipe.AddIngredient(null, "mecacutter");
recipe.AddIngredient(null, "sacrificedagger");
recipe.AddIngredient(null, "bullet");
recipe.AddIngredient(3458, 10);
recipe.AddIngredient(1570);
        recipe.SetResult(this);                     
	recipe.AddTile(412);
        recipe.AddRecipe();
	}
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("highboost"), 180);
			player.AddBuff(21, 900);
			target.AddBuff(24, 180);
			target.AddBuff(70, 180);
			target.AddBuff(153, 180);
			target.AddBuff(20, 180);
			target.AddBuff(120, 300);
			target.AddBuff(137, 300);
			target.AddBuff(103, 300);
		}
		
}}