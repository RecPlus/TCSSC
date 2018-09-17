using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons.Basic {
public class Hard_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hard Shortsword");
			Tooltip.SetDefault("'Silver + Tungsten shortsword, Extremely hard sword!'\nSecondary attack: Does a super hit that punch the enemies");
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
                item.useTime = 17;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 17;
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
			item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 25;
				item.knockBack = 9;
                item.useTime = 60;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 8f;
                item.useAnimation = 60;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 15;
				item.knockBack = 2;
                item.useTime = 17;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 17;
            }
		         return base.CanUseItem(player);
        }
		
	
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(3513);
recipe.AddIngredient(3489);
        recipe.SetResult(this);                     
	recipe.AddTile(16);
        recipe.AddRecipe();
	}
}}	