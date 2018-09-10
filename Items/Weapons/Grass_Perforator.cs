
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Grass_Perforator : ModItem
{
	
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grass Perforator");
			Tooltip.SetDefault("'Dont touch it, it can poison you'\nHas a chance to spread some toxic clouds around you when you hit an enemy");
		}
    public override void SetDefaults()
    {
       item.damage = 20;
        item.melee = true;
        item.width = 16;
        item.height = 16;
        item.useTime = 9;
        item.useAnimation = 9;
        item.useStyle = 3;
        item.knockBack = 2;
        item.value = 6500;
        item.rare = 2;
        item.UseSound = SoundID.Item1;
		item.shoot = mod.ProjectileType("nothing");
		item.shootSpeed = 3f;
        item.autoReuse = true;
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
				item.damage = 20;
				item.knockBack = 2;
                item.useTime = 9;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 3f;
                item.useAnimation = 9;
				item.mana = 0;
            }
		         return base.CanUseItem(player);
        }
		
		  public override void AddRecipes()                
    {          
	     ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(209, 6);
recipe.AddIngredient(331, 6);
        recipe.SetResult(this);                     
	recipe.AddTile(16);
        recipe.AddRecipe();
    }
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
			{
	item.shoot = 228;
		{
		target.AddBuff(20, 300);
						player.AddBuff(mod.BuffType("lowboost"), 180);
						player.AddBuff(21, 600);
		}
			}
			
					public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 2 + Main.rand.Next(3);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("nothing"), damage, knockBack, player.whoAmI);
			}
			return false;
		}
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 3);
			}
		}
}}