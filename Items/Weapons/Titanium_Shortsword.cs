using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Titanium_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Titanium Shortsword");
			Tooltip.SetDefault("Secondary attack: The sword gives you 'Titanium skin' buff for 3 seconds");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 300000;
        item.rare = 4;
		item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 47;
				item.knockBack = 2;
                item.useTime = 13;
				item.UseSound = SoundID.Item1;
				item.shoot = 402;
				item.shootSpeed = 2f;
                item.useAnimation = 13;
    }
	
		 public override bool AltFunctionUse(Player player)
        {
            return true;
        }
	
	    public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2) // Right Click function
            {
				item.useStyle = 4;
				item.autoReuse = false;
				item.melee = true;
				item.damage = 190;
				item.knockBack = 0;
                item.useTime = 25;
				item.UseSound = SoundID.Item34;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 25;
				item.mana = 100;
				item.buffType = mod.BuffType("titaniumskin");    //this is where you put your Buff name
                item.buffTime = 180;    //this is the buff duration        20000 = 6 min
				item.noMelee = true;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 190;
				item.knockBack = 3;
                item.useTime = 33;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 33;
				item.mana = 0;
						item.buffType = 0;    //this is where you put your Buff name
                item.buffTime = 0;    //this is the buff duration        20000 = 6 min
				item.noMelee = false;
            }
		         return base.CanUseItem(player);
        }
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("midboost"), 180);
			player.AddBuff(21, 900);
		}
	
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(1198, 7);
        recipe.SetResult(this);                     
	recipe.AddTile(134);
        recipe.AddRecipe();
	}
}}	