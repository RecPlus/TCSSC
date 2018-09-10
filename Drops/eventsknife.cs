using System;
using Terraria;
using Terraria.ModLoader;

namespace TCSSC.Drops
{
	public class eventsknife : GlobalNPC
	{	
	
	public override void NPCLoot(NPC npc)
	{
		if(npc.type == 325)
		{
			if (Main.rand.NextFloat(7) < 1) // 13.23% chance
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("nightmare"));
			}
		}
		
		if(npc.type == 346)
		{
			if (Main.rand.NextFloat(7) < 1) // 13.23% chance
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("bullet"));
			}
		}
		
			if(npc.type == 246)
		{
			if (Main.rand.NextFloat(4) < 1) // 13.23% chance
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("sacrificedagger"));
			}
		}
		// Addtional if statements here if you would like to add drops to other vanilla npc.
	}
}}
