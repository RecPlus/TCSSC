using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Night_Stabber : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night's Little Blade");
		}
    public override void SetDefaults()
    {
        item.damage = 65;
        item.melee = true;
        item.width = 16;
        item.height = 16;
        item.useTime = 19;
        item.useAnimation = 19;
        item.useStyle = 3;
        item.knockBack = 4;
        item.value = 100000;
        item.rare = 3;
        item.UseSound = SoundID.Item1;
        item.autoReuse = true;
    }

	    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(null, "Masa");
recipe.AddIngredient(null, "Demon_Shortsword");
recipe.AddIngredient(null, "Fiery_Knife");
recipe.AddIngredient(null, "Grass_Perforator");
        recipe.SetResult(this);                     
	recipe.AddTile(26);
        recipe.AddRecipe();
		
			 recipe = new ModRecipe(mod);                 
recipe.AddIngredient(null, "Masa");
recipe.AddIngredient(null, "Crimcutter");
recipe.AddIngredient(null, "Fiery_Knife");
recipe.AddIngredient(null, "Grass_Perforator");
        recipe.SetResult(this);                     
	recipe.AddTile(26);
        recipe.AddRecipe();
		
    }
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 27);
			}
		}
	
	public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(32, 600);
			player.AddBuff(mod.BuffType("midboost"), 120);
			player.AddBuff(21, 900);
		}

}}