using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Blood_Shortsword : ModItem
{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonism");
			Tooltip.SetDefault("When you attack, the sword fires little fire sparks\nSecondary attack: Fires Devil's hearts");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.value = 350000;
        item.rare = 5;
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
			player.AddBuff(mod.BuffType("midboost"), 180);
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
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 75;
				item.knockBack = 3;
                item.useTime = 55;
				item.UseSound = SoundID.Item15;
                item.useAnimation = 55;
				item.shoot = mod.ProjectileType("Heart");
                item.shootSpeed = 6f;
            } else
			
            {
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
		         return base.CanUseItem(player);
        }
		
						public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Blood"));
			}
		}
}}