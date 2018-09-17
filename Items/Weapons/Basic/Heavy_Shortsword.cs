using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons.Basic {
public class Heavy_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavy Shortsword");
			Tooltip.SetDefault("'Iron + Lead shortsword, 30 kilograms of sword!'\nSecondary attack: Throws the sword like a shuriken");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 2000;
        item.rare = 1;
			item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 35;
				item.knockBack = 3;
                item.useTime = 40;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 40;
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
				item.autoReuse = false;
				item.melee = true;
				item.damage = 30;
				item.knockBack = 3;
                item.useTime = 45;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("HeavyP");
				item.shootSpeed = 8f;
                item.useAnimation = 45;
				item.noMelee = true;
				item.noUseGraphic = true;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = false;
				item.melee = true;
				item.damage = 35;
				item.knockBack = 3;
                item.useTime = 30;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 30;
				item.noMelee = false;
				item.noUseGraphic = false;
            }
		         return base.CanUseItem(player);
        }
		
	
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(6);
recipe.AddIngredient(3495);
        recipe.SetResult(this);                     
	recipe.AddTile(16);
        recipe.AddRecipe();
	}
}}	