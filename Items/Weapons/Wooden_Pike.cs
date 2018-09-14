using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Wooden_Pike : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Pike");
		}
    public override void SetDefaults()
    {
        item.damage = 3;
        item.melee = true;
        item.width = 22;
        item.height = 22;
        item.useTime = 6;
        item.useAnimation = 6;
        item.useStyle = 3;
        item.knockBack = 0;
        item.value = 1000;
        item.rare = 0;
        item.UseSound = SoundID.Item1;
        item.autoReuse = false;
    }
	
	public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("tinyboost"), 60);
			player.AddBuff(21, 300);
		}
		
				    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(9, 1);
        recipe.SetResult(this);                     
	recipe.AddTile(18);
        recipe.AddRecipe();
	}
}}
