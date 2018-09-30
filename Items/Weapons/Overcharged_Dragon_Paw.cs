using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Overcharged_Dragon_Paw : ModItem
{
	
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Overcharged Dragon Paw");
			Tooltip.SetDefault("Secondary Attack: Activates the dragon's curse, you can do insane amount of damage, \nbut you will die in a few seconds until activated");
		}
    public override void SetDefaults()
    {
        item.width = 42;
        item.height = 42;
        item.useStyle = 3;
        item.value = 500000;
        item.rare = 8;
						item.autoReuse = true;
				item.melee = true;
				item.damage = 350;
				item.knockBack = 5;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
				item.shootSpeed = 25f;
                item.useAnimation = 20;
				item.shoot = mod.ProjectileType("nothing");
    }
	
	 public override bool AltFunctionUse(Player player)
        {
            return true;
        }
	
	     public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2) // Right Click function
            {
				item.crit = 0;
				item.useStyle = 4;
				item.autoReuse = false;
				item.melee = true;
				item.damage = 350;
				item.knockBack = 5;
                item.useTime = 10;
				item.UseSound = SoundID.NPCDeath10;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 10;
				item.mana = 200;
				item.buffType = mod.BuffType("curse");    //this is where you put your Buff name
                item.buffTime = 3600;    //this is the buff duration        20000 = 6 min
				item.noMelee = true;
            } 
			else
            {
				item.crit = 0;
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 350;
				item.knockBack = 5;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 20;
				item.mana = 0;
						item.buffType = 0;    //this is where you put your Buff name
                item.buffTime = 0;    //this is the buff duration        20000 = 6 min
				item.noMelee = false;
            }
		         return base.CanUseItem(player);
        }
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
		 if (Main.rand.NextFloat(5) < 1)
            {
				item.crit = 50;
				item.useStyle = 1;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 350;
				item.knockBack = 10;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
				item.shoot = 706;
				item.shootSpeed = 8f;
                item.useAnimation = 20;
				item.mana = 0;
				item.buffType = 0;    //this is where you put your Buff name
                item.buffTime = 0;    //this is the buff duration        20000 = 6 min
				item.noMelee = false;
            } 
		{
			player.AddBuff(mod.BuffType("highboost"), 90);
			player.AddBuff(21, 500);
		}
		}
		
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			 if (Main.rand.NextFloat(5) < 1)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 269);
			}
		}
}}