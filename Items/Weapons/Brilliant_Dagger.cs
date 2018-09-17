using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Brilliant_Dagger : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brilliant Dagger");
			Tooltip.SetDefault("Secondary attack: Fires light orbs");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 650000;
        item.rare = 5;
			item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 85;
				item.knockBack = 2;
                item.useTime = 13;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 13;
    }
	
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("midboost"), 180);
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
				item.damage = 50;
				item.knockBack = 3;
                item.useTime = 20;
				item.UseSound = SoundID.Item15;
                item.useAnimation = 20;
				item.shoot = mod.ProjectileType("smallorbgood");
                item.shootSpeed = 6f;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 85;
				item.knockBack = 2;
                item.useTime = 13;
				item.UseSound = SoundID.Item1;
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
		
				    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient (null, "Blood_Shortsword");
recipe.AddIngredient (66, 90);
recipe.AddIngredient (520, 5);
        recipe.SetResult(this);                     
	recipe.AddTile(134);
        recipe.AddRecipe();
	}
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 59);
			}
		}
}}