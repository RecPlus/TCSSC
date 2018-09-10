using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class bullet : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Old 45mm Caliber Bullet");
			Tooltip.SetDefault("'Santa's gift'\nSecondary attack: Throws the bullet like a boomerang");
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
				item.damage = 500;
				item.knockBack = 2;
                item.useTime = 35;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 35;
				item.noMelee = false;
				item.noUseGraphic = false;
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
				item.damage = 85;
				item.knockBack = 3;
                item.useTime = 15;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 15;
				item.shoot = mod.ProjectileType("bulletthrow");
                item.shootSpeed = 8f;
				item.noMelee = true;
				item.noUseGraphic = true;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 500;
				item.knockBack = 2;
                item.useTime = 35;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 0f;
                item.useAnimation = 35;
				item.noMelee = false;
				item.noUseGraphic = false;
            }
		         return base.CanUseItem(player);
        }
		
				public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("highboost"), 100);
			player.AddBuff(21, 600);
		}
		
}}