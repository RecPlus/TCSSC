using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Terra_Cutter : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Cutter Of The True Terrarian");
			Tooltip.SetDefault("'An unnecessary long name for an unnecessary short sword'");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 650000;
        item.rare = 8;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 150;
				item.knockBack = 2;
                item.useTime = 18;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 18;
    }
	
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
			{
				item.UseSound = SoundID.Item60;
	item.shoot = mod.ProjectileType("Cursed_Blast");
		{
						player.AddBuff(mod.BuffType("highboost"), 120);
						player.AddBuff(21, 900);
		}
			}
	
	    public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2) // Right Click function
            {
				item.useStyle = 1;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 80;
				item.knockBack = 3;
                item.useTime = 20;
				item.UseSound = SoundID.Item15;
                item.useAnimation = 20;
				item.shoot = mod.ProjectileType("nothing");
                item.shootSpeed = 15f;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 150;
				item.knockBack = 2;
                item.useTime = 18;
				item.UseSound = SoundID.Item60;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 20f;
                item.useAnimation = 18;
            }
		         return base.CanUseItem(player);
        }
		
				    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient (null, "Excalibur_JR");
recipe.AddIngredient (null, "Night_Stabber");
recipe.AddIngredient (1006, 7);
recipe.AddIngredient (1570, 2);
        recipe.SetResult(this);                     
	recipe.AddTile(134);
        recipe.AddRecipe();
	}
}}