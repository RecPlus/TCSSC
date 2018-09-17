using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons.Basic {
public class Royal_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Royal Shortsword");
			Tooltip.SetDefault("'Gold + Platinum Shortsword, the sword of the kings!'\nSecondary attack: Throws a bouncing sword");
		}
    public override void SetDefaults()
    {
        item.width = 40;
        item.height = 40;
        item.value = 5000;
        item.rare = 1;
			item.useStyle = 3;
				item.autoReuse = false;
				item.melee = true;
				item.damage = 20;
				item.knockBack = 2;
                item.useTime = 15;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 15;
    }
	
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("tinyboost"), 150);
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
				item.damage = 30;
				item.knockBack = 3;
                item.useTime = 45;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("RoyalP");
				item.shootSpeed = 7f;
                item.useAnimation = 45;
				item.noMelee = true;
				item.noUseGraphic = true;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = false;
				item.melee = true;
				item.damage = 20;
				item.knockBack = 2;
                item.useTime = 15;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 15;
				item.noMelee = false;
				item.noUseGraphic = false;
            }
		         return base.CanUseItem(player);
        }
		
	
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(3519);
recipe.AddIngredient(3483);
        recipe.SetResult(this);                     
	recipe.AddTile(16);
        recipe.AddRecipe();
	}
}}	