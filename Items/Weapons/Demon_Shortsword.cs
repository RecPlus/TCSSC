using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Demon_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demon's Shortsword");
		}
    public override void SetDefaults()
    {
        item.damage = 30;
        item.melee = true;
        item.width = 16;
        item.height = 16;
        item.useTime = 14;
        item.useAnimation = 14;
        item.useStyle = 3;
        item.knockBack = 2;
        item.value = 5500;
        item.rare = 1;
        item.UseSound = SoundID.Item1;
        item.autoReuse = true;
    }
	
	    public override void AddRecipes()                
    {                                             
	
     ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(57, 5);	
        recipe.SetResult(this);                     
	recipe.AddTile(16);
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
			target.AddBuff(153, 30);
			player.AddBuff(mod.BuffType("lowboost"), 180);
			player.AddBuff(21, 900);
		}

}}