using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TCSSC.Drops
{
    public class nurse : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
 
 
            //THIS IS AN EXAMPLE OF HOW TO MAKE ITEMS DROP FROM ALL NPCs IN A SPECIFIC BIOME   //this make the item drop only in hardmode
            {
				 if(Main.hardMode)
                if(npc.type ==  18)          //this is where you choose what biome you whant the item to drop. ZoneCorrupt is in Corruption
                {
                    if (Main.rand.Next(4) == 1)      //this is the item rarity, so 9 = 1 in 10 chance that the npc will drop the item.
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Stringe"), 1);//this is where you set what item to drop ,ItemID.VileMushroom is an example of how to add vanila items , Main.rand.Next(5, 10) it's the quantity,so it will chose a number from 5 to 10
                    }
					
                }
            }
		}
	}
}	