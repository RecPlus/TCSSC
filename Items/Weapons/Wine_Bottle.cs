using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Wine_Bottle : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Wine Bottle");
			Tooltip.SetDefault("'The most painful weapon in the world'");
		}
    public override void SetDefaults()
    {
        item.width = 30;
        item.height = 30;
        item.useStyle = 3;
        item.value = 100000;
        item.rare = 2;
				item.useStyle = 3;
				item.autoReuse = false;
				item.melee = true;
				item.damage = 30;
				item.knockBack = 3;
                item.useTime = 18;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 18;
				item.mana = 0;
						item.buffType = 0;    //this is where you put your Buff name
                item.buffTime = 0;    //this is the buff duration        20000 = 6 min
				item.noMelee = false;
            
    }
	
	public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("lowboost"), 120);
			player.AddBuff(21, 600);
		}
	
}}	