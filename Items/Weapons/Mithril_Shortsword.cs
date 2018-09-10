using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Mithril_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mythril Shortsword");
			Tooltip.SetDefault("Secondary attack: Fires a mithril sword beam");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 250000;
        item.rare = 3;
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
	
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("midboost"), 120);
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
				item.useStyle = 1;
				item.autoReuse = false;
				item.melee = true;
				item.damage = 50;
				item.knockBack = 3;
                item.useTime = 21;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("swordbeam");
				item.shootSpeed = 7f;
                item.useAnimation = 21;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 80;
				item.knockBack = 3;
                item.useTime = 21;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 21;
				item.mana = 0;
            }
		         return base.CanUseItem(player);
        }
		
			public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 63);
			}
		}
	
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(382, 5);
        recipe.SetResult(this);                     
	recipe.AddTile(134);
        recipe.AddRecipe();
	}
}}	