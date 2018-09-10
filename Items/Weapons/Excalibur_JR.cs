using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Excalibur_JR : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Excalibur Junior");
			Tooltip.SetDefault("'The great excalibur son'\nSecondary attack: Shoot the sword like a boomerang");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 500000;
        item.rare = 5;
					item.autoReuse = false;
				item.melee = true;
				item.damage = 150;
				item.knockBack = 2;
                item.useTime = 12;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 12;
						item.noMelee = false;
				item.noUseGraphic = false;
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
				item.useStyle = 1;
				item.autoReuse = false;
				item.melee = true;
				item.damage = 200;
				item.knockBack = 3;
                item.useTime = 60;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 60;
				item.shoot = mod.ProjectileType("Excalibur");
                item.shootSpeed = 5f;
						item.noMelee = true;
				item.noUseGraphic = true;
            } else
			
            {
			    item.useStyle = 3;
				item.autoReuse = false;
				item.melee = true;
				item.damage = 150;
				item.knockBack = 2;
                item.useTime = 12;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 12;
						item.noMelee = false;
				item.noUseGraphic = false;
            }
		         return base.CanUseItem(player);
        }
		
					    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(1225, 5);
        recipe.SetResult(this);                     
	recipe.AddTile(134);
        recipe.AddRecipe();
	}
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 57);
			}
		}
}}