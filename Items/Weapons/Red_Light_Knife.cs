using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Red_Light_Knife: ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Light Knife");
			Tooltip.SetDefault("Secondary attack: The sword gives you 'Feather falling' and 'Swiftness' buff for 5 seconds");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 95000;
        item.rare = 1;
						item.autoReuse = true;
				item.melee = true;
				item.damage = 20;
				item.knockBack = 3;
                item.useTime = 12;
				item.UseSound = SoundID.Item15;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 12;
				item.mana = 0;
				item.noMelee = false;
    }
	
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("lowboost"), 120);
			player.AddBuff(21, 600);
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
				item.damage = 20;
				item.knockBack = 0;
                item.useTime = 25;
				item.UseSound = SoundID.Item15;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 25;
				item.mana = 45;
				item.noMelee = true;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 20;
				item.knockBack = 3;
                item.useTime = 12;
				item.UseSound = SoundID.Item15;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 12;
				item.mana = 0;
				item.noMelee = false;
            }
		         return base.CanUseItem(player);
        }
		
			public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 60);
			}
		}
		
				public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			if(player.altFunctionUse == 2)
			{
				player.AddBuff(3, 300, true);
				player.AddBuff(8, 300, true);
		    }
		}
	
			    public override void AddRecipes()    
	{
	    ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(117, 7);
recipe.AddIngredient(178, 5);
        recipe.SetResult(this);                     
	recipe.AddTile(16);
        recipe.AddRecipe();
	}
}}	