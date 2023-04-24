using System;

namespace Amongus
{
    class Quiz{
        
        
        static string getItemname(){
            Console.Write("Input item name: ");
            string itemname = Console.ReadLine();
            return itemname;
        }
        static string getItemType(){
            Console.Write("Input type of item: ");
            string itemtype = Console.ReadLine();
            
            if (itemtype == "ShowAll"){
                Console.WriteLine();
                Console.WriteLine("Pls Don't input 'ShowAll'");
                Console.WriteLine();
                getItemType();
            }

            return itemtype;
        }
         
        static void Update_Inventory(ref string[] item,ref string[] type,int order){
          
            string itemName = getItemname();
            string itemType = getItemType();
          
            item[order] = itemName;
            type[order] = itemType;
        }

        static bool Search_Item_From_Inventory(string[] item,string[] type,string typeSearch){
            int max = item.Count();

            if (typeSearch == "End") {
                return false;
            }

            for (int i = 0;i < max;i++){
                if (typeSearch == "ShowAll"){
                    Console.WriteLine();
                    Console.WriteLine(item[i]);
                    Console.WriteLine(type[i]);
                } else {
                    if (type[i] == typeSearch) {
                        Console.WriteLine();
                        Console.WriteLine(item[i]);    
                    }
                }
            }

            return true;
        }
        
        static void Main(string[] args){
            Console.Write("Input inventory limit: ");
            int max_Inventory =  int.Parse(Console.ReadLine());
            string[] item = new string[max_Inventory];
            string[] type = new string[max_Inventory];
            // Get Inventory data
            for (int i = 0; i < max_Inventory; i++){
                Update_Inventory(ref item,ref type,i);
            }

            // Search

            while (true) {
                Console.WriteLine();
                Console.Write("Input to search item by type: ");
                string searchType = Console.ReadLine();
                if (!Search_Item_From_Inventory(item,type,searchType)){
                    break;
                }
            }
        }
    }
}