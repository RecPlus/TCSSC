using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Stringe : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Big Syringe");
			Tooltip.SetDefault("Drains life on attack");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 350000;
        item.rare = 6;
		item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 50;
				item.knockBack = 2;
                item.useTime = 15;
				item.UseSound = SoundID.Item1;
				item.shoot = 0;
				item.shootSpeed = 2f;
                item.useAnimation = 15;
				item.shoot = mod.ProjectileType("nothing");
    }
	
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("lowboost"), 180);
			player.AddBuff(mod.BuffType("regen"), 30);
			player.AddBuff(21, 1600);
		}
	
	
	    public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2) // Right Click function
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 75;
				item.knockBack = 3;
                item.useTime = 55;
				item.UseSound = SoundID.Item15;
                item.useAnimation = 55;
				item.shoot = mod.ProjectileType("nothing");
                item.shootSpeed = 6f;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 50;
				item.knockBack = 2;
                item.useTime = 15;
				item.UseSound = SoundID.Item1;
				item.shoot = 0;
				item.shootSpeed = 2f;
                item.useAnimation = 15;
            }
		         return base.CanUseItem(player);
        }

}}