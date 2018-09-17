using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons.Basic {
public class Cactus_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cactus Shortsword");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 750;
        item.rare = 0;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 10;
				item.knockBack = 1;
				item.knockBack = 1;
                item.useTime = 27;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 27;
    }	
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
				player.AddBuff(mod.BuffType("tinyboost"), 60);
			player.AddBuff(21, 300);
		}
		
				    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(276, 6);
        recipe.SetResult(this);                     
	recipe.AddTile(18);
        recipe.AddRecipe();
	}
}}