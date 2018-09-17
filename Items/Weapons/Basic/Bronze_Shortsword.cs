using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons.Basic {
public class Bronze_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Shortsword");
			Tooltip.SetDefault("'Cooper + Tin Shortsword, a nice idea!'\nSecondary attack: Throws the sword like a boomerang");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 1500;
        item.rare = 1;
			item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 15;
				item.knockBack = 2;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 20;
				item.noMelee = false;
				item.noUseGraphic = false;
    }
	
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("tinyboost"), 120);
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
				item.autoReuse = true;
				item.melee = true;
				item.damage = 23;
				item.knockBack = 3;
                item.useTime = 45;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("BronzeP");
				item.shootSpeed = 8f;
                item.useAnimation = 45;
				item.noMelee = true;
				item.noUseGraphic = true;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 15;
				item.knockBack = 2;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 20;
				item.noMelee = false;
				item.noUseGraphic = false;
            }
		         return base.CanUseItem(player);
        }
		
	
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(3507);
recipe.AddIngredient(3501);
        recipe.SetResult(this);                     
	recipe.AddTile(16);
        recipe.AddRecipe();
	}
}}	