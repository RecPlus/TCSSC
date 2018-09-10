using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class clorophyte_shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chlorophyte Shortsword");
			Tooltip.SetDefault("Secondary attack: Attacks like a normal sword and inflicts venom + poison debuff");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 950000;
        item.rare = 7;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 185;
				item.knockBack = 0;
                item.useTime = 16;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 16;
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
				item.autoReuse = true;
				item.melee = true;
				item.damage = 70;
				item.knockBack = 3;
                item.useTime = 14;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 14;
				item.shoot = 0;
                item.shootSpeed = 2f;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 185;
				item.knockBack = 0;
                item.useTime = 16;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 16;
            }
		         return base.CanUseItem(player);
        }
		
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(1006, 5);
        recipe.SetResult(this);                     
	recipe.AddTile(134);
        recipe.AddRecipe();
	}
	
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(20, 500);
			player.AddBuff(mod.BuffType("midboost"), 240);
			player.AddBuff(21, 900);
			if(player.altFunctionUse == 2)
			target.AddBuff(70, 120);
		player.AddBuff(mod.BuffType("midboost"), 120);
		player.AddBuff(21, 600);
		}
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 3);
			}
		}
}}