using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class nightmare : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Nightmare");
			Tooltip.SetDefault("Secondary attack: Fires bats");
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
				item.damage = 300;
				item.knockBack = 0;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 20;
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
				item.autoReuse = true;
				item.melee = true;
				item.damage = 175;
				item.knockBack = 3;
                item.useTime = 50;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 50;
				item.shoot = 316;
                item.shootSpeed = 7f;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 300;
				item.knockBack = 0;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 20;
            }
		         return base.CanUseItem(player);
        }
	
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(mod.BuffType("highboost"), 100);
			player.AddBuff(21, 600);
		}
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 65);
			}
		}
}}