using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class anon : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stick");
			Tooltip.SetDefault("'...'");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 100000;
        item.rare = 11;
				item.useStyle = 3;
				item.autoReuse = false;
				item.melee = true;
				item.damage = 2000;
				item.knockBack = 3;
                item.useTime = 15;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 15f;
                item.useAnimation = 15;
				item.mana = 1;
						item.buffType = 0;    //this is where you put your Buff name
                item.buffTime = 0;    //this is the buff duration        20000 = 6 min
				item.noMelee = false;
            
    }
	
	 public override void AddRecipes()                
    {       
		     ModRecipe recipe = new ModRecipe(mod);
recipe.AddIngredient(3069);
recipe.AddIngredient(null, "Wooden_Pike");
recipe.AddIngredient(null, "Night_Stabber");			 
recipe.AddIngredient(null, "Stringe");			 	
recipe.AddIngredient(null, "bullet");
recipe.AddIngredient(null, "rainbow");
recipe.AddIngredient(null, "Chaotic_Cosmos");
recipe.AddIngredient(1570);
recipe.AddIngredient(3458, 100);
recipe.AddIngredient(117, 30);
recipe.AddIngredient(1552, 30);
recipe.AddIngredient(3261, 30);
        recipe.SetResult(this);                     
	recipe.AddTile(412);
        recipe.AddRecipe();
	}
	
	public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
			{
	item.shoot = 402;
		{
			player.AddBuff(mod.BuffType("supboost"), 600);
			player.AddBuff(21, 1200);
		}
			}
			
					public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 30 + Main.rand.Next(30);
			for (int i = 30; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				item.shoot = 612;
			}
			return false;
	    }
}}	