using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Warriant : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Warriant");
			Tooltip.SetDefault("Secondary attack: Hits and confuses some enemies around you");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 200000;
        item.rare = 4;
			item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 80;
				item.knockBack = 3;
                item.useTime = 22;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 22;
				item.mana = 0;
    }
	
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("midboost"), 120);
			player.AddBuff(21, 450);
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
				item.damage = 80;
				item.knockBack = 0;
                item.useTime = 100;
				item.UseSound = SoundID.NPCDeath10;
				item.shoot = mod.ProjectileType("areadamage");
				item.shootSpeed = 0f;
                item.useAnimation = 100;
				item.mana = 100;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 80;
				item.knockBack = 3;
                item.useTime = 22;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 22;
				item.mana = 0;
            }
		         return base.CanUseItem(player);
        }
}}	