using System;

namespace FridayFrozenTask
{
    
    
        class Program
        {
            class Item
            {
                string name;
                string item;CannotUnloadAppDomainException
                

                public Movie(string _name, string _item)
                {
                    name = _name;
                    item = _item;
                }

                public string Name
                {
                    get { return name ; }
                }
                public string Items
                {
                    get { return item; }
                }
                
                
                    
                

                class ItemList
                {
                    List<Item> Items;
                    long totallifetimeGross;

                    public ItemLists()
                    {
                        Items = new List<Item>();
                        
                    }

                    public void AddItemsToList(string name, string item)
                    {
                        Item newMovie = new Item(name, item);
                        Items.Add(newItem); ;
                    }

                    public void ItemsForChristmas()
                    {
                        foreach (Item item in Items)
                        {
                            Console.WriteLine($"{item.Name}, {item.Items} for christmas");
                        }
                    }
                }
                static void Main(string[] args)
                {
                    string filePath = @"C:\Users\opilane\samples";
                    string fileName = @"Frozenl.txt";
                    string fullFilePath = Path.Combine(filePath, fileName);

                    string[] linesFromFile = File.ReadAllLines(fullFilePath);

                    ItemList myItems = new ItemList();


                    foreach (string line in linesFromFile)
                    {
                        string[] tempArray = line.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                        string ItemName = tempArray[0];
                        string ItemItem = tempArray[1];
                        myItems.AddItemsToList(ItemName, ItemItem);
                    }
                    myItems.ItemsForChristmas();
                }
            }
        }
    }




