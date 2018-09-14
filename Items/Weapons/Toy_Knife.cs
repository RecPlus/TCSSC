using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Toy_Knife : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gangster Knife");
			Tooltip.SetDefault("Secondary attack: Attacks like a normal sword");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 10000;
        item.rare = 1;
					item.autoReuse = true;
				item.melee = true;
				item.damage = 25;
				item.knockBack = 0;
                item.useTime = 15;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 15;
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
				item.damage = 20;
				item.knockBack = 3;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 20;
				item.shoot = 0;
                item.shootSpeed = 2f;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 25;
				item.knockBack = 0;
                item.useTime = 15;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 15;
            }
		         return base.CanUseItem(player);
        }
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("tinyboost"), 60);
			player.AddBuff(21, 600);
		}
		
}}