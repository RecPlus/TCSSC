using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Adamantite_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Shortsword");
			Tooltip.SetDefault("Secondary attack: Does a hit that push the enemies a lot");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 200000;
        item.rare = 3;
			item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 80;
				item.knockBack = 3;
                item.useTime = 18;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 18;
				item.mana = 0;
    }
	
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("midboost"), 180);
			player.AddBuff(21, 900);
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
				item.autoReuse = false;
				item.melee = true;
				item.damage = 130;
				item.knockBack = 28;
                item.useTime = 50;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 50;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 80;
				item.knockBack = 3;
                item.useTime = 18;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 18;
				item.mana = 0;
            }
		         return base.CanUseItem(player);
        }
		
			public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			if(player.altFunctionUse == 2)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 60);
			}
		}
	
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(391, 6);
        recipe.SetResult(this);                     
	recipe.AddTile(134);
        recipe.AddRecipe();
	}
}}	