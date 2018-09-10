using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Palladium_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Palladium Shortsword");
			Tooltip.SetDefault("Secondary attack: Attacks extremely fast, but deals very low damage");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 150000;
        item.rare = 4;
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 75;
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
				item.autoReuse = true;
				item.melee = true;
				item.damage = 25;
				item.knockBack = 3;
                item.useTime = 6;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 6;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 75;
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
	
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(1184, 5);
        recipe.SetResult(this);                     
	recipe.AddTile(16);
        recipe.AddRecipe();
	}
}}	