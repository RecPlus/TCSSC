using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TCSSC.Items.Potions {

    public class titanium_skin : ModItem
    {
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Titanium skin potion");
			Tooltip.SetDefault("Increase your defense by 15");
		}
		
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 100;                
            item.rare = 1;
            item.buffType = mod.BuffType("titaniumskin");    //this is where you put your Buff name
            item.buffTime = 3600;    //this is the buff duration        20000 = 6 min
            return;
        }
		
		 public override void AddRecipes()                
    {                                             
	
     ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(292);
recipe.AddIngredient(2303);
recipe.AddIngredient(315);
recipe.AddIngredient(126);	
        recipe.SetResult(this);                     
	recipe.AddTile(13);
	recipe.AddTile(355);
        recipe.AddRecipe();
		
		     recipe = new ModRecipe(mod);                 
recipe.AddIngredient(1106);
recipe.AddIngredient(315);
recipe.AddIngredient(126);	
        recipe.SetResult(this);                     
	recipe.AddTile(13);
	recipe.AddTile(355);
        recipe.AddRecipe();
		
			     recipe = new ModRecipe(mod);                 
recipe.AddIngredient(366);
recipe.AddIngredient(315);
recipe.AddIngredient(126);	
        recipe.SetResult(this);                     
	recipe.AddTile(13);
	recipe.AddTile(355);
        recipe.AddRecipe();
    }		
    }
}